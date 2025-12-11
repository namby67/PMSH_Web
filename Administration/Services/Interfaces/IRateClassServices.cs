using System.Data;

namespace Administration.Services.Interfaces
{
    public interface IRateClassService
    {
        // lấy danh sách cho DataGrid
        Task<DataTable> RateClassTypeData(string? Code, string? Name, int inactive = 0);
    }
}
