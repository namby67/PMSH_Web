using BaseBusiness.BO;
using BaseBusiness.util;
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
    public class RoutingService : IRoutingService
    {
        public DataTable SearchAllForTrans(string sqlCommand)
        {
            try
            {
                SqlParameter[] param = new SqlParameter[]
                {
                    new SqlParameter("@sqlCommand", sqlCommand),

                };

                DataTable myTable = DataTableHelper.getTableData("spSearchAllForTrans", param);
                return myTable;
            }
            catch (SqlException ex)
            {

                throw new Exception($"ERROR: {ex.Message}", ex);
            }
        }

        public DataTable SearchRouting(string reservationID, string confirmationNo)
        {
            try
            {
                SqlParameter[] param = new SqlParameter[]
                {
                    new SqlParameter("@ReservationID", reservationID),

                     new SqlParameter("@ConfirmationNo", confirmationNo),

                };

                DataTable myTable = DataTableHelper.getTableData("spReservationRouting", param);
                return myTable;
            }
            catch (SqlException ex)
            {

                throw new Exception($"ERROR: {ex.Message}", ex);
            }
        }
    }
}
