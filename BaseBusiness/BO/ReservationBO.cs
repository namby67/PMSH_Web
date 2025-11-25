using BaseBusiness.bc;
using BaseBusiness.Facade;
using BaseBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.BO
{
    public class ReservationBO : BaseBO
    {
        private ReservationFacade facade = ReservationFacade.Instance;
        protected static ReservationBO instance = new ReservationBO();

        protected ReservationBO()
        {
            this.baseFacade = facade;
        }

        public static ReservationBO Instance
        {
            get { return instance; }
        }
        public static int GetTopConfirmationNo()
        {
            string query = "select max(cast(ConfirmationNo as int)) as ConfirmationNo from Reservation where ConfirmationNo <> '' ";
            return instance.GetFirst<int>(query);
        }
        public static int GetTopID()
        {
            string query = "select top 1 ID from Reservation order by id desc";
            return instance.GetFirst<int>(query);
        }
        public static List<ReservationModel> GetList(DateTime toDate, DateTime fromDate)
        {
            // Định dạng ngày thành YYYY-MM-DD
            string toDateStr = toDate.ToString("yyyy-MM-dd");
            string fromDateStr = fromDate.ToString("yyyy-MM-dd");

            string query = $"SELECT * FROM Reservation WHERE CAST(ArrivalDate AS DATE) >= CAST('{toDateStr}' AS DATE) AND CAST(DepartureDate AS DATE) <= CAST('{fromDateStr}' AS DATE) ORDER BY id DESC";
            return instance.GetList<ReservationModel>(query);
        }

        public static List<ProfileModel> GetProfileIndividual()
        {
            string query = $"select * from Profile where Type = 0 order by id desc ";
            return instance.GetList<ProfileModel>(query);
        }
        public static List<ReservationModel> GetReservationMaster(int reservationID)
        {
            string query = $"select * from Reservation where Relationship = {reservationID} and ReservationNo = 0";
            return instance.GetList<ReservationModel>(query);
        }
        public static List<ReservationModel> GetReservationByConfirmationNo(string confirmationNo)
        {
            string query = $"select * from Reservation where ConfirmationNo = '{confirmationNo}'";
            return instance.GetList<ReservationModel>(query);
        }
        public static List<ReservationModel> GetReservationRoomSharer(int reservationID)
        {
            string query = $"select * from Reservation where ShareRoom = {reservationID} and MainGuest = 0";
            return instance.GetList<ReservationModel>(query);
        }

        public static List<object> GetRoomTypeAvailable(DateTime fromDate, DateTime toDate)
        {
            string query = $"-- Declare date variables with original format, using CONVERT for proper parsing\r\nDECLARE @fromDate DATETIME = CONVERT(DATETIME, '{fromDate}', 103), -- 103 = DD/MM/YYYY\r\n        @toDate   DATETIME = CONVERT(DATETIME, '{toDate}', 103);\r\n\r\nSET NOCOUNT ON;\r\n\r\n-- Swap dates if fromDate is later than toDate\r\nDECLARE @tempDate DATETIME;\r\nIF @fromDate > @toDate\r\nBEGIN\r\n    SET @tempDate = @fromDate;\r\n    SET @fromDate = @toDate;\r\n    SET @toDate = @tempDate;\r\nEND;\r\n\r\n-- B1: Create date list\r\nDECLARE @dateList TABLE ([Date] DATE);\r\nDECLARE @d DATE = @fromDate;\r\nWHILE @d <= @toDate\r\nBEGIN\r\n    INSERT INTO @dateList VALUES (@d);\r\n    SET @d = DATEADD(DAY, 1, @d);\r\nEND;\r\n\r\n-- B2: Calculate RoomType x Date availability\r\n;WITH RoomAvailability AS (\r\n    SELECT \r\n        rt.ID AS RoomTypeID,\r\n        rt.Code AS RoomType,\r\n        d.[Date],\r\n        AvailableRooms = \r\n            ISNULL(inv.TotalRoom, 0)\r\n            - ISNULL(ar.AssignedRooms, 0)\r\n            - ISNULL(ur.UnassignedRooms, 0)\r\n            - ISNULL(ooo.OOORooms, 0)\r\n    FROM @dateList d\r\n    CROSS JOIN RoomType rt\r\n    LEFT JOIN (\r\n        SELECT RoomTypeID, [Date], TotalRoom\r\n        FROM RoomInventory WITH (NOLOCK)\r\n    ) inv ON inv.RoomTypeID = rt.ID AND inv.[Date] = d.[Date]\r\n    LEFT JOIN (\r\n        SELECT \r\n            r.RoomTypeID, r.RateDate AS [Date], COUNT(DISTINCT r.RoomID) AS AssignedRooms\r\n        FROM ReservationRate r WITH (NOLOCK)\r\n        JOIN Reservation re WITH (NOLOCK) ON r.ReservationID = re.ID\r\n        JOIN ReservationType k WITH (NOLOCK) ON re.ReservationTypeID = k.ID\r\n        WHERE \r\n            re.Status NOT IN (3, 4) AND re.MainGuest = 1\r\n            AND re.ReservationNo > 0 AND r.RoomID > 0 AND k.Deduct = 1\r\n        GROUP BY r.RoomTypeID, r.RateDate\r\n    ) ar ON ar.RoomTypeID = rt.ID AND ar.[Date] = d.[Date]\r\n    LEFT JOIN (\r\n        SELECT \r\n            r.RoomTypeID, d2.[Date], SUM(r.NoOfRoom) AS UnassignedRooms\r\n        FROM Reservation r WITH (NOLOCK)\r\n        JOIN RoomType rt2 WITH (NOLOCK) ON r.RoomTypeID = rt2.ID\r\n        JOIN ReservationType k WITH (NOLOCK) ON r.ReservationTypeID = k.ID\r\n        CROSS APPLY (\r\n            SELECT DATEADD(DAY, number, r.ArrivalDate) AS [Date]\r\n            FROM master..spt_values\r\n            WHERE type = 'P' AND number <= DATEDIFF(DAY, r.ArrivalDate, r.DepartureDate) - 1\r\n        ) d2\r\n        WHERE \r\n            rt2.IsPseudo = 0 AND r.RoomID = 0 AND r.MainGuest = 1 \r\n            AND r.Status NOT IN (3, 4) AND k.Deduct = 1 AND r.ReservationNo > 0\r\n        GROUP BY r.RoomTypeID, d2.[Date]\r\n    ) ur ON ur.RoomTypeID = rt.ID AND ur.[Date] = d.[Date]\r\n    LEFT JOIN (\r\n        SELECT \r\n            c.RoomTypeID, d3.[Date], COUNT(DISTINCT b.RoomID) AS OOORooms\r\n        FROM BusinessBlock b WITH (NOLOCK)\r\n        JOIN Room c WITH (NOLOCK) ON b.RoomID = c.ID\r\n        CROSS APPLY (\r\n            SELECT DATEADD(DAY, number, b.FromDateOOO) AS [Date]\r\n            FROM master..spt_values\r\n            WHERE type = 'P' AND number <= DATEDIFF(DAY, b.FromDateOOO, b.ToDateOOO)\r\n        ) d3\r\n        GROUP BY c.RoomTypeID, d3.[Date]\r\n    ) ooo ON ooo.RoomTypeID = rt.ID AND ooo.[Date] = d.[Date]\r\n    WHERE rt.IsPseudo = 0\r\n)\r\nSELECT * INTO #RoomAvailability FROM RoomAvailability;\r\n\r\n-- B3: Pivot columns\r\nDECLARE @cols NVARCHAR(MAX) = '';\r\nSELECT @cols += QUOTENAME(CONVERT(VARCHAR(10), [Date], 120)) + ',' \r\nFROM @dateList \r\nWHERE [Date] <= @toDate\r\nORDER BY [Date];\r\n\r\n-- Check if @cols is empty\r\nIF LEN(@cols) = 0\r\nBEGIN\r\n    RAISERROR ('No dates available to pivot.', 16, 1);\r\n    DROP TABLE #RoomAvailability;\r\n    RETURN;\r\nEND;\r\n\r\nSET @cols = LEFT(@cols, LEN(@cols) - 1); -- Remove trailing comma\r\n\r\nDECLARE @sql NVARCHAR(MAX) = '\r\nSELECT RoomTypeID, RoomType, ' + @cols + '\r\nFROM (\r\n    SELECT RoomTypeID, RoomType, CONVERT(VARCHAR(10), [Date], 120) AS [Date], AvailableRooms\r\n    FROM #RoomAvailability\r\n) src\r\nPIVOT (\r\n    MAX(AvailableRooms) FOR [Date] IN (' + @cols + ')\r\n) p\r\nORDER BY RoomType;\r\n';\r\n\r\nEXEC sp_executesql @sql;\r\n\r\n-- Clean up\r\nDROP TABLE #RoomAvailability;";
            return instance.GetList<object>(query);
        }
    }
}
