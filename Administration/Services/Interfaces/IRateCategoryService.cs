using System.Data;

namespace Administration.Services.Interfaces
{
    public interface IRateCategoryService
    {
        // lấy danh sách cho DataGrid
        Task<DataTable> RateCategoryTypeData(int inactive = 0);
    }
}
