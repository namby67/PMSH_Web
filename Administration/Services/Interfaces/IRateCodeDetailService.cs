using System.Data;
using static Administration.DTO.RateCodeDetailDTO;

namespace Administration.Services.Interfaces
{
    public interface IRateCodeDetailService
    {
        // Task<DataTable> RateCodeTypeData(Dictionary<string, object?> parameter);
        // Task<DataTable> RateCodeGroupDataByID(Dictionary<string, object?> parameter);
        Task<DataTable> RateCodeTypeData(string? rateCode,
            string? rateCategory,
            int? typeOfDate,
            DateTime? fromDate,
            DateTime? toDate);
        Task<DataTable> RateCodeGroupDataByID(int? RateCodeID);
        Task<DataTable> GetRateCodeDetailsAsync(RateCodeDetailInputDto input);


    }
}
