using System.Data;

namespace Administration.Services.Interfaces
{
    public interface IRateClassService
    {
        // lấy danh sách cho DataGrid
        Task<DataTable> RateClassTypeData(int inactive = 0);
    }
}
