using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseBusiness.BO;
using BaseBusiness.Model;
using BaseBusiness.util;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using RoomManagement.Services.Interfaces;
using RoomManagement.Dto;

namespace RoomManagement.Services.Implements
{
    public class RoomManagementService : IRoomManagementService
    {
        public DataTable Discrepancy(int sleep, int skip, int person, string floor, string room, string zone, string roomClass)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@Sleep", sleep),
                new SqlParameter("@Skip", skip),
                new SqlParameter("@Person", person),
                new SqlParameter("@Floor", floor ?? ""),
                new SqlParameter("@Room", room ?? ""),
                new SqlParameter("@Zone", zone ?? ""),
                new SqlParameter("@RoomClass", roomClass ?? "")
            };

            DataTable myTable = DataTableHelper.getTableData("spHKDescrepancy", param);
            return myTable;
        }
        public DataTable ItemDailyInventory(
                int groupId,
                DateTime firstDate,
                DateTime secondDate,
                DateTime thirthDate,
                DateTime fourthDate,
                DateTime fifthDate,
                DateTime sixthDate,
                DateTime seventhDate,
                DateTime eighthDate,
                DateTime ninthDate,
                DateTime tenthDate,
                DateTime eleventhDate,
                DateTime twelvethDate,
                DateTime thirtheenDate,
                DateTime fourtheenDate,
                DateTime fiftheenDate)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@GroupID", groupId),
                new SqlParameter("@FirstDate", firstDate),
                new SqlParameter("@SecondDate", secondDate),
                new SqlParameter("@ThirthDate", thirthDate),
                new SqlParameter("@FourthDate", fourthDate),
                new SqlParameter("@FifthDate", fifthDate),
                new SqlParameter("@SixthDate", sixthDate),
                new SqlParameter("@SeventhDate", seventhDate),
                new SqlParameter("@EighthDate", eighthDate),
                new SqlParameter("@NinthDate", ninthDate),
                new SqlParameter("@TenthDate", tenthDate),
                new SqlParameter("@EleventhDate", eleventhDate),
                new SqlParameter("@TwelvethDate", twelvethDate),
                new SqlParameter("@ThirtheenDate", thirtheenDate),
                new SqlParameter("@FourtheenDate", fourtheenDate),
                new SqlParameter("@FiftheenDate", fiftheenDate)
            };

            DataTable myTable = DataTableHelper.getTableData("spItemDailyInventory", param);
            return myTable;
        }
        public bool UpdateItemInventory(InventoryUpdateRequest model)
        {
            using (SqlConnection conn = new SqlConnection(DBUtils.GetDBConnectionString()))
            {
                conn.Open();

                // 1. Lấy ID theo ngày và ItemID
                int? id = null;
                using (SqlCommand cmd = new SqlCommand(@"
            EXEC spSearchAllForTrans @sqlCommand = N'SELECT ID FROM ItemInventory WHERE ItemID = @ItemID AND DATEDIFF(DAY, Date, @MatchDate) = 0'", conn))
                {
                    cmd.Parameters.AddWithValue("@ItemID", model.ItemID);
                    cmd.Parameters.AddWithValue("@MatchDate", model.MatchDate);

                    var result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                        id = Convert.ToInt32(result);
                }

                if (id == null)
                    return false;

                // 2. Thực hiện UPDATE bằng sp_executesql
                using (SqlCommand cmd = new SqlCommand("sp_executesql", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    string sqlUpdate = @"
                UPDATE ItemInventory
                SET 
                    ItemID = @ItemID,
                    Date = @Date,
                    Quantity = @Quantity,
                    VendorID = @VendorID,
                    Sun = @Sun,
                    Mon = @Mon,
                    Tue = @Tue,
                    Wed = @Wed,
                    Thu = @Thu,
                    Fri = @Fri,
                    Sat = @Sat,
                    CreateDate = @CreateDate,
                    UpdateDate = @UpdateDate,
                    UserInsertID = @UserID,
                    UserUpdateID = @UserID
                WHERE ID = @ID";

                    string parameterDef = @"
                @ItemID int,
                @Date datetime,
                @Quantity int,
                @VendorID int,
                @Sun nvarchar(4000),
                @Mon nvarchar(4000),
                @Tue nvarchar(4000),
                @Wed nvarchar(4000),
                @Thu nvarchar(4000),
                @Fri nvarchar(4000),
                @Sat nvarchar(4000),
                @CreateDate datetime,
                @UpdateDate datetime,
                @UserID int,
                @ID int";

                    cmd.Parameters.AddWithValue("@stmt", sqlUpdate);
                    cmd.Parameters.AddWithValue("@params", parameterDef);

                    var now = DateTime.Now;

                    cmd.Parameters.AddWithValue("@ItemID", model.ItemID);
                    cmd.Parameters.AddWithValue("@Date", model.Date);
                    cmd.Parameters.AddWithValue("@Quantity", model.Quantity);
                    cmd.Parameters.AddWithValue("@VendorID", 0);
                    cmd.Parameters.AddWithValue("@Sun", "False");
                    cmd.Parameters.AddWithValue("@Mon", "False");
                    cmd.Parameters.AddWithValue("@Tue", "False");
                    cmd.Parameters.AddWithValue("@Wed", "False");
                    cmd.Parameters.AddWithValue("@Thu", "False");
                    cmd.Parameters.AddWithValue("@Fri", "False");
                    cmd.Parameters.AddWithValue("@Sat", "False");
                    cmd.Parameters.AddWithValue("@CreateDate", now);
                    cmd.Parameters.AddWithValue("@UpdateDate", now);
                    cmd.Parameters.AddWithValue("@UserID", model.UserID);
                    cmd.Parameters.AddWithValue("@ID", id.Value);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
        public DataTable ItemInventoryAvailable(
                int groupId,
                DateTime firstDate,
                DateTime secondDate,
                DateTime thirthDate,
                DateTime fourthDate,
                DateTime fifthDate,
                DateTime sixthDate,
                DateTime seventhDate,
                DateTime eighthDate,
                DateTime ninthDate,
                DateTime tenthDate,
                DateTime elevenDate,
                DateTime twelveDate,
                DateTime thirtheenDate,
                DateTime fourtheenDate,
                DateTime fiftheenDate)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@GroupID", groupId),
                new SqlParameter("@FirstDate", firstDate),
                new SqlParameter("@SecondDate", secondDate),
                new SqlParameter("@ThirthDate", thirthDate),
                new SqlParameter("@FourthDate", fourthDate),
                new SqlParameter("@FifthDate", fifthDate),
                new SqlParameter("@SixthDate", sixthDate),
                new SqlParameter("@SeventhDate", seventhDate),
                new SqlParameter("@EighthDate", eighthDate),
                new SqlParameter("@NinthDate", ninthDate),
                new SqlParameter("@TenthDate", tenthDate),
                new SqlParameter("@ElevenDate", elevenDate),
                new SqlParameter("@TwelveDate", twelveDate),
                new SqlParameter("@ThirtheenDate", thirtheenDate),
                new SqlParameter("@FourtheenDate", fourtheenDate),
                new SqlParameter("@FiftheenDate", fiftheenDate)
            };

            // Giả sử bạn có helper để gọi SP và trả DataTable
            DataTable resultTable = DataTableHelper.getTableData("spItemInventoryAvailable", parameters);

            return resultTable;
        }
        public DataTable ItemResvDetail(int itemID, DateTime day)

        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@day", day),
                new SqlParameter("@ItemID", itemID)
            };

            // Giả sử bạn có helper để gọi SP và trả DataTable
            DataTable resultTable = DataTableHelper.getTableData("spItemResvDetail", parameters);

            return resultTable;
        }

        public DataTable ItemSearch(string groupID, string name)

        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@GroupID", groupID),
                new SqlParameter("@Name", name ?? "")
            };

            DataTable resultTable = DataTableHelper.getTableData("spItemSearch", parameters);

            return resultTable;
        }
        public DataTable OOOSload(int status, string roomNo, int roomClassID, DateTime fromDate, DateTime toDate, string zone)

        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Status", status),
                new SqlParameter("@RoomNo", roomNo ?? ""),
                new SqlParameter("@RoomClassID", roomClassID ),
                new SqlParameter("@FromDate", fromDate ),
                new SqlParameter("@ToDate", toDate ),
                new SqlParameter("@Zone", zone ?? "" )
            };

            DataTable resultTable = DataTableHelper.getTableData("spOOOSload", parameters);

            return resultTable;
        }
        public DataTable AvailableRoomsSearchOOO(string isDummy, string smoking, string floor, string roomTypeCode, string foStatus, string hkStatusID, string roomNo, DateTime fromDate, DateTime toDate, string zoneCode)

        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@IsDummy", isDummy ?? ""),
                new SqlParameter("@Smoking", smoking ?? ""),
                new SqlParameter("@Floor", floor ?? ""),
                new SqlParameter("@RoomTypeCode", roomTypeCode ?? ""),
                new SqlParameter("@FOStatus", foStatus ?? ""),
                new SqlParameter("@HKStatusID", hkStatusID ?? ""),
                new SqlParameter("@RoomNo", roomNo ?? ""),
                new SqlParameter("@FromDate", fromDate ),
                new SqlParameter("@ToDate", toDate ),
                new SqlParameter("@ZoneCode", zoneCode ?? "" )
            };

            DataTable resultTable = DataTableHelper.getTableData("spAvailableRoomsSearchOOO", parameters);

            return resultTable;
        }
        public DataTable RoomStatusHistoryOOO(string roomNo, DateTime fromDate, DateTime toDate, string userName)

        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@RoomNo", roomNo ?? ""),
                new SqlParameter("@FromDate", fromDate ),
                new SqlParameter("@ToDate", toDate ),
                new SqlParameter("@UserName", userName ?? "" )
            };

            DataTable resultTable = DataTableHelper.getTableData("spRoomStatusHistoryOOO", parameters);

            return resultTable;
        }
        public DataTable SearchAllForTrans(string sqlCommand)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@sqlCommand", sqlCommand ?? "")
            };

            DataTable resultTable = DataTableHelper.getTableData("spSearchAllForTrans", parameters);

            return resultTable;
        }
        

    }
}
