using System.Data;
using Microsoft.Data.SqlClient;
using BaseBusiness.util;
using Administration.Services.Interfaces;
using System.Text;

namespace Administration.Services.Implements
{
    public class RateCodeUserRightService : IRateCodeUserRightService
    {
        public DataTable RateCodeUserRightTypeData(string? userName, string? rateCode)
        {

            try
            {
                StringBuilder sql = new(@"
                    SELECT *
                    FROM UserRateCodePermission
                    WHERE 1 = 1
                ");

                if (!string.IsNullOrWhiteSpace(userName))
                {
                    sql.Append($" AND UserName = '{userName.Trim()}'");
                }

                if (!string.IsNullOrWhiteSpace(rateCode))
                {
                    sql.Append($" AND RateCode = '{rateCode.Trim()}'");
                }

                return TextUtils.Select(sql.ToString());
            }
            catch (Exception ex)
            {
                throw new Exception($"ERROR: {ex.Message}", ex);
            }
        }
    }
}
