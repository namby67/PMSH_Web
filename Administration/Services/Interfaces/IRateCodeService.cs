using System.Data;

namespace Administration.Services.Interfaces
{
    public interface IRateCodeService
    {
        // lấy danh sách cho DataGrid
        DataTable GetAllRateCode(string? rateCode, string? RateCategory);
    }
}
