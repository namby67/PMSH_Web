using System.Data;
using Microsoft.Data.SqlClient;
using BaseBusiness.util;
using Administration.Services.Interfaces;

namespace Administration.Services.Implements
{
    public class RateCategory : IRateCategoryService
    {
        public async Task<DataTable> RateCategoryTypeData(int inactive = 0)
        {
            try
            {
                SqlParameter[] param = [
                    new SqlParameter("@Inactive", inactive)
                ];
                DataTable myTable = await DataTableHelper.getTableDataAsync("spFrmRateCategorySearch", param);
                return myTable;

            }
            catch (Exception ex)
            {

                throw new Exception($"ERROR: {ex.Message}", ex);
            }
        }
    }
}
