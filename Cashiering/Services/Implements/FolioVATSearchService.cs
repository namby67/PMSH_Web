using BaseBusiness.BO;
using BaseBusiness.util;
using Cashiering.Services.Interfaces;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cashiering.Services.Implements
{
    public class FolioVATSearchService : IFolioVATSearchService
    {
        public DataTable SearchFolioVAT(DateTime fromDate, DateTime toDate, int folioStatus, int printStatus, int type)
        {
            try
            {
                SqlParameter[] param = new SqlParameter[]
                {
                    new SqlParameter("@FromDate", fromDate),

                     new SqlParameter("@ToDate", toDate),

                     new SqlParameter("@FolioStatus", folioStatus),
                    new SqlParameter("@PrintStatus", printStatus),
                    new SqlParameter("@Type", type),

                };

                DataTable myTable = DataTableHelper.getTableData("spFolioWithVATSearch", param);
                return myTable;
            }
            catch (SqlException ex)
            {

                throw new Exception($"ERROR: {ex.Message}", ex);

            }
        }
    }
}
