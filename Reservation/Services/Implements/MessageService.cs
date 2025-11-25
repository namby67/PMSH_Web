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
    public class MessageService : IMessageService
    {
        public DataTable SearchMessage(string Name, string ReservationHolder, string ConfirmationNo, string CRSNo,string RoomNo, string Zone, string Status, string Receive, string Print)
        {
            try
            {
                SqlParameter[] param = new SqlParameter[]
                {
                    new SqlParameter("@Name", Name),
                    new SqlParameter("@ReservationHolder", ReservationHolder),
                    new SqlParameter("@ConfirmationNo", ConfirmationNo),
                    new SqlParameter("@CRSNo", CRSNo),
                    new SqlParameter("@RoomNo", RoomNo),

                    new SqlParameter("@Zone", Zone),
                    new SqlParameter("@Status", Status),
                    new SqlParameter("@Receive", Receive),
                    new SqlParameter("@Print", Print),

                };

                DataTable myTable = DataTableHelper.getTableData("spMessageSearch", param);
                return myTable;
            }
            catch (SqlException ex)
            {

                throw new Exception($"ERROR: {ex.Message}", ex);
            }
        }
    }
}
