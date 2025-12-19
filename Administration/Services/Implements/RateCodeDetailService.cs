using System.Data;
using Microsoft.Data.SqlClient;
using BaseBusiness.util;
using static Administration.DTO.RateCodeDetailDTO;

namespace Administration.Services.Implements
{
    public class RateCodeDetailService : IRateCodeDetailService
    {

        public async Task<DataTable> RateCodeTypeData(string? rateCode, string? rateCategory, int? typeOfDate, DateTime? fromDate, DateTime? toDate)
        {
            try
            {
                SqlParameter[] param = [
                    new SqlParameter("@strRateCode", rateCode ?? string.Empty),
                    new SqlParameter("@strRateCategory", rateCategory ?? string.Empty),
                    new SqlParameter("@typeOfDate", typeOfDate ??  (object)DBNull.Value),
                    new SqlParameter("@FromDate", fromDate ?? (object)DBNull.Value),
                    new SqlParameter("@ToDate", toDate ?? (object)DBNull.Value),
                    ];
                DataTable myTable = DataTableHelper.getTableData("spRateCodeSearch", param);
                return myTable;

            }
            catch (Exception ex)
            {

                throw new Exception($"ERROR: {ex.Message}", ex);
            }
        }
        public async Task<DataTable> RateCodeGroupDataByID(int? RateCodeID)
        {
            try
            {
                SqlParameter[] param = [
                    new SqlParameter("@RateCodeID", RateCodeID ?? (object)DBNull.Value)
                    ];
                DataTable myTable = DataTableHelper.getTableData("spGetRateCodeDetailByRateCodeIDGrouped", param);
                return myTable;
                
            }
            catch (Exception ex)
            {

                throw new Exception($"ERROR: {ex.Message}", ex);
            }
        }

        public async Task<DataTable> GetRateCodeDetailsAsync(RateCodeDetailInputDto input)
        {
            try
            {
                SqlParameter[] param =
                [
                new("@RateCodeID", input.RateCodeID),
                new("@beginDate", input.BeginDate ?? (object)DBNull.Value),
                new("@endDate", input.EndDate ?? (object)DBNull.Value),
                new("@roomType", input.RoomType ?? string.Empty),
                new("@transCode", input.TransCode ?? string.Empty),
                new("@currencyID", input.CurrencyID ?? string.Empty),
                new("@packageID", input.PackageID),
                new("@a1", input.A1),
                new("@a2", input.A2),
                new("@a3", input.A3),
                new("@a4", input.A4),
                new("@a5", input.A5),
                new("@a6", input.A6),
                new("@c1", input.C1),
                new("@c2", input.C2),
                new("@c3", input.C3),
                new("@minLOS", input.MinLOS),
                new("@maxLOS", input.MaxLOS),
                new("@minRoom", input.MinRoom),
                new("@maxRoom", input.MaxRoom)
                ];

                DataTable myTable = DataTableHelper.getTableData("spGetRateCodeDetails", param);
                return myTable;
            }
            catch (Exception ex)
            {
                throw new Exception($"ERROR in GetRateCodeDetailsAsync: {ex.Message}", ex);
            }
        }
        // public async Task<DataTable> RateCodeGroupDataByID(Dictionary<string, object?> parameter)
        // {
        //     try
        //     {
        //         SqlParameter[] sqlParameters = [.. parameter.Select(item => new SqlParameter(item.Key, item.Value ?? DBNull.Value))];
        //         return DataTableHelper.getTableData("spGetRateCodeDetailByRateCodeIDGrouped", sqlParameters);
        //     }
        //     catch (Exception ex)
        //     {

        //         throw new Exception($"ERROR: {ex.Message}", ex);
        //     }
        // }


        // public async Task<DataTable> RateCodeTypeData(Dictionary<string, object?> parameter)
        // {
        //     //Validate năm
        //     if (parameter.TryGetValue("@FromDate", out object? value1))
        //         parameter["@FromDate"] = DateValidator.Validate((DateTime?)value1);
        //     if (parameter.TryGetValue("@ToDate", out object? value2))
        //         parameter["@ToDate"] = DateValidator.Validate((DateTime?)value2);

        //     //Chuyển đổi qua parameter
        //     SqlParameter[] sqlParameters = [.. parameter.Select(item => new SqlParameter(item.Key, item.Value ?? DBNull.Value))];

        //     //Call stored
        //     return DataTableHelper.getTableData("spRateCodeSearch", sqlParameters);
        // }

        // public Task<DataTable> RateCodeTypeData(string? rateCode, string? rateCategory, int? typeOfDate, DateTime? fromDate, DateTime? toDate)
        // {
        //     throw new NotImplementedException();
        // }


        // // Hàm validate năm chênh lệch 500 5
        // public static class DateValidator
        // {
        //     private const int YearLimit = 500;

        //     public static DateTime Validate(DateTime? time)
        //     {
        //         if (time == null)
        //         {
        //             return DateTime.Now;
        //         }
        //         var now = DateTime.Now;
        //         var min = now.AddYears(-YearLimit);
        //         var max = now.AddYears(YearLimit);

        //         if (time < min) return min;
        //         if (time > max) return max;

        //         return time.Value;
        //     }
        // }
    }
}
