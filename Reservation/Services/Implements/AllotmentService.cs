using System.Data;
using BaseBusiness.util;
using Microsoft.Data.SqlClient;
using Reservation.Services.Interfaces;

namespace Reservation.Services.Implements
{
    public class AllotmentService : IAllotmentService
    {
        public async Task<DataTable> GetAllAllotmentData(string? Code, string? Name, int inactive = 0)
        {
            try
            {
                SqlParameter[] param = [
                    new SqlParameter("@Code", Code ?? string.Empty),
                    new SqlParameter("@Name", Name ?? string.Empty),
                    new SqlParameter("@Inactive", inactive)
                    ];
                DataTable myTable = DataTableHelper.getTableData("spFrmRateClassSearch", param);
                return myTable;

            }
            catch (Exception ex)
            {

                throw new Exception($"ERROR: {ex.Message}", ex);
            }
        }
    }
}
