using BaseBusiness.BO;
using BaseBusiness.util;
using Microsoft.Data.SqlClient;
using Profile.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profile.Services.Implements
{
    public class ProfileExportService : IProfileExportService
    {
        public DataTable SearchProfileExport(DateTime fromDate, DateTime toDate)
        {
            try
            {
                SqlParameter[] param = new SqlParameter[]
                {
                    new SqlParameter("@FromDate", fromDate),

                     new SqlParameter("@ToDate", toDate),

                };

                DataTable myTable = DataTableHelper.getTableData("spProfileExport", param);
                return myTable;
            }
            catch (SqlException ex)
            {

                throw new Exception($"ERROR: {ex.Message}", ex);
            }
        }

        public DataTable SearchProfileHistory(int profileID, int type, string confirmationNo)
        {
            try
            {
                SqlParameter[] param = new SqlParameter[]
                {
                    new SqlParameter("@ProfileID", profileID),

                     new SqlParameter("@Type", type),
                    new SqlParameter("@ConfirmationNo", confirmationNo),

                };

                DataTable myTable = DataTableHelper.getTableData("spProfileHistoryStayInfo", param);
                return myTable;
            }
            catch (SqlException ex)
            {

                throw new Exception($"ERROR: {ex.Message}", ex);
            }
        }
    }
}
