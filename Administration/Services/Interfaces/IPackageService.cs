using System.Data;
using Administration.DTO;

namespace Administration.Services.Interfaces
{
    public interface IPackageService
    {
        Task<DataTable> RateCategoryTypeData(string? strPackageCode);
        Task<DataTable> PackageDataByID(int? PackageID);
        int Save(PackageDTO dto);

    }
}
