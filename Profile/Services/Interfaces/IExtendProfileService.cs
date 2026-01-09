using BaseBusiness.Contants;
using Profile.DTO;

namespace Profile.Services.Interfaces
{
    public interface IExtendProfileService
    {
        ApiResponse DeleteProfile(int profileId);
    }
}
