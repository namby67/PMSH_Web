using BaseBusiness.BO;
using BaseBusiness.util;
using Microsoft.AspNetCore.Server.IISIntegration;
using Microsoft.Data.SqlClient;
using Reservation.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation.Services.Implements
{
    public class ShareService : IShareService
    {
        public DataTable ShareRateDetail(int reservationID)
        {
            try
            {
                SqlParameter[] param = new SqlParameter[]
                {
                    new SqlParameter("@ReservationID", reservationID),


                };

                DataTable myTable = DataTableHelper.getTableData("spShareRateDetail", param);
                return myTable;
            }
            catch (SqlException ex)
            {

                throw new Exception($"ERROR: {ex.Message}", ex);
            }
        }

        public DataTable ShareReservationDetail(int reservationID, int shareNo)
        {
            try
            {
                SqlParameter[] param = new SqlParameter[]
                {
                    new SqlParameter("@ReservationID", reservationID),
                    new SqlParameter("@ShareRoom", shareNo),


                };

                DataTable myTable = DataTableHelper.getTableData("spShareReservationDetail", param);
                return myTable;
            }
            catch (SqlException ex)
            {

                throw new Exception($"ERROR: {ex.Message}", ex);
            }
        }

        public DataTable ShareRoomDetail(int reservationID)
        {
            try
            {
                SqlParameter[] param = new SqlParameter[]
                {
                    new SqlParameter("@ReservationID", reservationID),


                };

                DataTable myTable = DataTableHelper.getTableData("spShareRoomDetail", param);
                return myTable;
            }
            catch (SqlException ex)
            {

                throw new Exception($"ERROR: {ex.Message}", ex);
            }
        }
    }
}
