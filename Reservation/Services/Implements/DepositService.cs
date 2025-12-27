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
    public class DepositService : IDepositService
    {
        public DataTable SearchDepositPayment(int reservationID, int depositRsqID)
        {
            try
            {
                SqlParameter[] param = new SqlParameter[]
                {
                    new SqlParameter("@ReservationID", reservationID),

                     new SqlParameter("@DepositRsqID", depositRsqID),

                };

                DataTable myTable = DataTableHelper.getTableData("spSearchDepositPayment", param);
                return myTable;
            }
            catch (SqlException ex)
            {

                throw new Exception($"ERROR: {ex.Message}", ex);
            }
        }

        public DataTable SearchDepositRequest(int reservationID)
        {
            try
            {
                SqlParameter[] param = new SqlParameter[]
                {
                    new SqlParameter("@RsvID", reservationID),


                };

                DataTable myTable = DataTableHelper.getTableData("spSearchDepositRequest", param);
                return myTable;
            }
            catch (SqlException ex)
            {

                throw new Exception($"ERROR: {ex.Message}", ex);
            }
        }
    }
}
