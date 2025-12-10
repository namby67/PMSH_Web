using System.Data;
using Microsoft.Data.SqlClient;
using BaseBusiness.util;
using Administration.Services.Interfaces;

namespace Administration.Services.Implements
{
    public class RateCodeService : IRateCodeService
    {
        public DataTable GetAllRateCode(string? rateCode, string? rateCategory)
        {
            try
            {
                var p1 = new SqlParameter("@strRateCode",
                    string.IsNullOrWhiteSpace(rateCode) || rateCode == "0"
                        ? DBNull.Value
                        : rateCode);

                var p2 = new SqlParameter("@strRateCategory",
                    string.IsNullOrWhiteSpace(rateCategory) || rateCategory == "0"
                        ? DBNull.Value
                        : rateCategory);

                SqlParameter[] parameters = { p1, p2 };

                DataTable dataTable = DataTableHelper.getTableData("spGetRateCode", parameters);
                return dataTable;
            }
            catch (Exception ex)
            {
                throw new Exception($"ERROR: {ex.Message}", ex);
            }
        }

    }
}
