using System.Data;

namespace Administration.Services.Interfaces
{
    public interface IRateCodeUserRightService
    {
        // lấy danh sách cho DataGrid
        DataTable RateCodeUserRightTypeData(string? userName, string? rateCode);
    }
}
