using System.Data;
using Microsoft.Data.SqlClient;
using BaseBusiness.util;
using Administration.Services.Interfaces;

namespace Administration.Services.Implements
{
    public class RateClassService : IRateClassService
    {
        public async Task<DataTable> RateClassTypeData(int inactive = 0)
        {
            try
            {
                SqlParameter[] param = [
                    new SqlParameter("@Inactive", inactive)
                ];
                DataTable myTable =  DataTableHelper.getTableData("spFrmRateClassSearch", param);
                return myTable;

            }
            catch (Exception ex)
            {

                throw new Exception($"ERROR: {ex.Message}", ex);
            }
        }
    }
}
