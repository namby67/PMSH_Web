using System.Data;
using Microsoft.Data.SqlClient;
using BaseBusiness.util;
using Administration.Services.Interfaces;

namespace Administration.Services.Implements
{
    public class RateCategory : IRateCategoryService
    {
        public async Task<DataTable> RateCategoryTypeData(string? Code, string? Name, int inactive = 0)
        {
            try
            {
                SqlParameter[] param = [
                    new SqlParameter("@Code", Code ?? string.Empty),
                    new SqlParameter("@Name", Name ?? string.Empty),
                    new SqlParameter("@Inactive", inactive)
                    ]; DataTable myTable = DataTableHelper.getTableData("spFrmRateCategorySearch", param);
                return myTable;

            }
            catch (Exception ex)
            {

                throw new Exception($"ERROR: {ex.Message}", ex);
            }
        }
    }
}
