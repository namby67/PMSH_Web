using Administration.DTO;

namespace Administration.Services.Interfaces
{
    public interface IPackageDetailService
    {
        List<PackageDetailDTO> GetPackageDetailsByPackageID(int packageId);
         public int Save(PackageDetailDTO dto);
    }
}
