using BaseBusiness.BO;
using BaseBusiness.util;
using DevExpress.XtraGauges.Core.Base;
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
    public class GroupAdminService : IGroupAdminService
    {
        public DataTable SearchGroupCheckInRoom(string ConfirmationNo, string Inspected,string Clean, string AllRooms, string CleanAndInspected) {
            try
            {
                SqlParameter[] param = new SqlParameter[]
                {
                    new SqlParameter("@ConfirmationNo", ConfirmationNo),
                     new SqlParameter("@Inspected", Inspected),
                                         new SqlParameter("@Clean", Clean),

                     new SqlParameter("@AllRooms", AllRooms),
                     new SqlParameter("@CleanAndInspected", CleanAndInspected),
                };

                DataTable myTable = DataTableHelper.getTableData("spGroupCheckInByConfirmationNo", param);
                return myTable;
            }
            catch (SqlException ex)
            {

                throw new Exception($"ERROR: {ex.Message}", ex);
            }
        }

        public DataTable spReservationSearchByConfirmationNo(string ConfirmationNo)
        {
            try
            {
                SqlParameter[] param = new SqlParameter[]
                {
                    new SqlParameter("@ConfirmationNo", ConfirmationNo),

                };

                DataTable myTable = DataTableHelper.getTableData("spReservationSearchByConfirmationNo", param);
                return myTable;
            }
            catch (SqlException ex)
            {

                throw new Exception($"ERROR: {ex.Message}", ex);
            }
        }
    }
}
