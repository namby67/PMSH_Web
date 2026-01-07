using BaseBusiness.Contants;
using Profile.DTO;

namespace Profile.Services.Interfaces
{
    public interface INewProfileService
    {
        ApiResponseAddError<ValidationErrorDto> CreateProfile(SaveProfileRequestDto dto);
    }
}
