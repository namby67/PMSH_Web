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
    public class FolioDetailService : IFolioDetailService
    {
        public DataTable GetFolioDetailByFolioID(int folioID, int mode)
        {
            try
            {
                SqlParameter[] param = new SqlParameter[]
                {
                    new SqlParameter("@FolioID", folioID),
                    new SqlParameter("@Mode", mode),
                };

                DataTable myTable = DataTableHelper.getTableData("spSearchTransactionInFolioByDev", param);
                return myTable;
            }
            catch (SqlException ex)
            {

                throw new Exception($"ERROR: {ex.Message}", ex);
            }
        }
    }
}
