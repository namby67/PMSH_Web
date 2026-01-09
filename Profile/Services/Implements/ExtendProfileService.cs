using BaseBusiness.BO;
using BaseBusiness.Contants;
using BaseBusiness.Model;
using BaseBusiness.util;
using Profile.DTO;
using Profile.Services.Interfaces;

namespace Profile.Services.Implements
{
    public class ExtendProfileService : IExtendProfileService
    {
        public ApiResponse DeleteProfile(int profileId)
        {
            if (profileId <= 0)
            {
                return new ApiResponse { Success = false, Message = "Invalid Profile ID.", };
            }

            // 1. Check Reservation
            if (ExistsInReservation(profileId))
                return new ApiResponse { Success = false, Message = "This profile already exists in Reservation. Indelibility" };

            // 2. Check AccountReceivable
            if (ExistsInAccountReceivable(profileId))
                return new ApiResponse { Success = false, Message = "This profile already exists in AccountReceivable. Indelibility" };

            // 3. Check BusinessBlock
            if (ExistsInBusinessBlock(profileId))
                return new ApiResponse { Success = false, Message = "This profile already exists in BusinessBlock. Indelibility" };

            // 4. Check Folio
            if (ExistsInFolio(profileId))
                return new ApiResponse { Success = false, Message = "This profile already exists in Folio. Indelibility" };

            if (ProfileBO.Instance.FindByPrimaryKey(profileId) is not ProfileModel profile)
                return new ApiResponse { Success = false, Message = "Profile not found." };

            ProfileBO.Instance.Delete(profileId);

            TextUtils.InsertActivityLog(
                "Profile",
                profileId,
                "Deleted",
                profile.Account,
                "",
                "Delete Profile"
            );

            return new ApiResponse
            {
                Success = true,
                Message = "Profile deleted successfully."
            };
        }

        #region Private checks (giữ nguyên logic cũ)

        private bool ExistsInReservation(int profileId)
        {
            var dt = TextUtils.Select($@"
            SELECT TOP 1 ID FROM dbo.Reservation WITH (NOLOCK)
            WHERE ProfileIndividualID = {profileId}
               OR ProfileAgentID = {profileId}
               OR ProfileCompanyID = {profileId}
               OR ProfileContactID = {profileId}
               OR ProfileGroupID = {profileId}
               OR ProfileSourceID = {profileId}");
            return dt.Rows.Count > 0;
        }

        private bool ExistsInAccountReceivable(int profileId)
        {
            var dt = TextUtils.Select(
                $"SELECT TOP 1 ID FROM dbo.AccountReceivable WITH (NOLOCK) WHERE ProfileID = {profileId}");
            return dt.Rows.Count > 0;
        }

        private bool ExistsInBusinessBlock(int profileId)
        {
            var dt = TextUtils.Select(
                $"SELECT TOP 1 ID FROM dbo.BusinessBlock WITH (NOLOCK) WHERE DestinationRoomInventoryID = {profileId}");
            return dt.Rows.Count > 0;
        }

        private bool ExistsInFolio(int profileId)
        {
            var dt = TextUtils.Select(
                $"SELECT TOP 1 ID FROM dbo.Folio WITH (NOLOCK) WHERE ProfileID = {profileId}");
            return dt.Rows.Count > 0;
        }
        #endregion


    }
}
