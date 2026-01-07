using BaseBusiness.BO;
using BaseBusiness.Contants;
using BaseBusiness.Model;
using BaseBusiness.util;
using Profile.DTO;
using Profile.Services.Interfaces;

namespace Profile.Services.Implements
{
    public class NewProfileService : INewProfileService
    {
        public ApiResponseAddError<ValidationErrorDto> CreateProfile(SaveProfileRequestDto dto)
        {
            var errors = new List<ValidationErrorDto>();

            try
            {
                ProfileModel profile;

                switch (dto.Type)
                {
                    case 0:
                        errors.AddRange(ValidateIndividual(dto));
                        if (errors.Count != 0)
                            return ValidationFail(errors, dto.Type);
                        profile = MapIndividual(dto);
                        break;

                    case 1:
                    case 2:
                    case 3:
                        errors.AddRange(ValidateCompany(dto));
                        if (errors.Count != 0)
                            return ValidationFail(errors, dto.Type);
                        profile = MapCompany(dto);
                        break;

                    case 4:
                        errors.AddRange(ValidateGroup(dto));
                        if (errors.Count != 0)
                            return ValidationFail(errors, dto.Type);
                        profile = MapGroup(dto);
                        break;

                    default:
                        errors.AddRange(ValidateContact(dto));
                        if (errors.Count != 0)
                            return ValidationFail(errors, dto.Type);
                        profile = MapContact(dto);
                        break;
                }

                ProfileBO.Instance.Insert(profile);

                return new ApiResponseAddError<ValidationErrorDto>
                {
                    Success = true,
                    Message = "New profile created successfully"
                };
            }
            catch (Exception ex)
            {
                return new ApiResponseAddError<ValidationErrorDto>
                {
                    Success = false,
                    Message = "Unexpected error",
                    Error = ex.Message
                };
            }
        }
        #region Validation
        public static ApiResponseAddError<ValidationErrorDto> ValidationFail(List<ValidationErrorDto> errors, int type)
        {
            return new ApiResponseAddError<ValidationErrorDto>
            {
                Success = false,
                Message = "Validation failed",
                Errors = errors,
                Type = type

            };
        }


        private static List<ValidationErrorDto> ValidateIndividual(SaveProfileRequestDto dto)
        {
            var errors = new List<ValidationErrorDto>();

            if (string.IsNullOrWhiteSpace(dto.LastNameIndivdual))
                errors.Add(new ValidationErrorDto { Field = "lastNameIndivdual", Message = "Last name not blank" });

            if (string.IsNullOrWhiteSpace(dto.FirstNameIndividual))
                errors.Add(new ValidationErrorDto { Field = "firstNameIndividual", Message = "First name not blank" });

            if (dto.NationalityIndividual == 0)
                errors.Add(new ValidationErrorDto { Field = "nationalityIndividual", Message = "Nationality not blank" });

            if (dto.BlackListIndividual && string.IsNullOrWhiteSpace(dto.BlackListReasonIndividual))
                errors.Add(new ValidationErrorDto { Field = "blackListReasonIndividual", Message = "Reason Black list not blank" });

            errors.AddRange(ValidateCodeLength(dto.CodeIndividual, "codeIndividual"));

            return errors;
        }
        private static List<ValidationErrorDto> ValidateContact(SaveProfileRequestDto dto)
        {
            var errors = new List<ValidationErrorDto>();

            if (string.IsNullOrWhiteSpace(dto.LastNameContact))
                errors.Add(new ValidationErrorDto { Field = "lastNameContact", Message = "Last name not blank" });

            if (string.IsNullOrWhiteSpace(dto.FirstNameContact))
                errors.Add(new ValidationErrorDto { Field = "firstNameContact", Message = "First name not blank" });

            errors.AddRange(ValidateCodeLength(dto.CodeIndividual, "CodeContact"));

            return errors;
        }

        private static List<ValidationErrorDto> ValidateCompany(SaveProfileRequestDto dto)
        {
            var errors = new List<ValidationErrorDto>();

            if (string.IsNullOrWhiteSpace(dto.CodeCOM))
                errors.Add(new ValidationErrorDto { Field = "codeCOM", Message = "Code not blank" });

            if (string.IsNullOrWhiteSpace(dto.AccountCOM))
                errors.Add(new ValidationErrorDto { Field = "accountCOM", Message = "Account not blank" });

            if (dto.BlackListCOM && string.IsNullOrWhiteSpace(dto.BlackListReasonCOM))
                errors.Add(new ValidationErrorDto { Field = "blackListReasonCOM", Message = "Reason Black list not blank" });

            errors.AddRange(ValidateCodeLength(dto.CodeCOM, "codeCOM"));

            return errors;
        }

        private static List<ValidationErrorDto> ValidateGroup(SaveProfileRequestDto dto)
        {
            var errors = new List<ValidationErrorDto>();

            if (string.IsNullOrWhiteSpace(dto.GroupNameGroup))
                errors.Add(new ValidationErrorDto { Field = "groupNameGroup", Message = "Group Name not blank" });

            errors.AddRange(ValidateCodeLength(dto.CodeGroup, "codeGroup"));

            return errors;
        }

        private static List<ValidationErrorDto> ValidateCodeLength(string code, string field)
        {
            var errors = new List<ValidationErrorDto>();

            if (string.IsNullOrWhiteSpace(code))
            {
                errors.Add(new ValidationErrorDto
                {
                    Field = field,
                    Message = "Code not blank"
                });
                return errors;
            }

            if (code.Length != 13)
            {
                errors.Add(new ValidationErrorDto
                {
                    Field = field,
                    Message = "Length Code format!"
                });
            }

            var exists = PropertyUtils
                .ConvertToList<ProfileModel>(
                    ProfileBO.Instance.FindByAttribute("Code", code)
                );

            if (exists != null && exists.Count != 0)
            {
                errors.Add(new ValidationErrorDto
                {
                    Field = field,
                    Message = "Profile code existing in system!"
                });
            }

            return errors;
        }

        #endregion

        #region Mapping
        private static ProfileModel MapIndividual(SaveProfileRequestDto dto)
        {
            return new ProfileModel
            {
                Type = 0,
                Code = dto.CodeIndividual,
                Account = dto.AccountIndividual,
                LastName = dto.LastNameIndivdual,
                Firstname = dto.FirstNameIndividual,
                MiddleName = dto.MiddleNameIndividual,
                LanguageID = dto.LanguageIndividual,
                TitleID = dto.TitleIndividual,
                Address = dto.AddressIndividual,
                HomeAddress = dto.BusAddressIndividual,
                City = dto.CityIndividual,
                PostalCode = dto.PostalIndividual,
                CountryID = dto.CountryIndividual,
                StateID = dto.StateIndividual,
                Salutation = dto.SalutationIndividual,
                VIPID = dto.VIPIndividual,
                VIPReason = dto.ReasonIndividual,
                PassPort = dto.PassportIndividual,
                Keyword = dto.KeywordIndividual,
                DateOfBirth = dto.DobIndividual,
                NationalityID = dto.NationalityIndividual,
                Telephone = dto.TelephoneIndividual,
                Email = dto.EmailIndividual,
                Website = dto.WebsiteIndividual,
                HandPhone = dto.HandPhoneIndividual,
                Active = dto.ActiveIndividual,
                Contact = dto.ContactIndividual,
                TaxCode = dto.TaxIndividual,
                IsBlackList = dto.BlackListIndividual,
                BlackListReason = dto.BlackListReasonIndividual,

                UserInsertID = 136,
                UserUpdateID = 136,
                CreateDate = DateTime.Now,
                UpdateDate = DateTime.Now
            };
        }
        private static ProfileModel MapCompany(SaveProfileRequestDto dto)
        {
            return new ProfileModel
            {
                Type = dto.Type,
                Code = dto.CodeCOM,
                Account = dto.AccountCOM,
                FullAccount = dto.FullAccount,

                Address = dto.AddressCOM,
                HomeAddress = dto.BusAddressCOM,
                City = dto.CityCOM,
                PostalCode = dto.PostalCOM,
                CountryID = dto.CountryCOM,
                StateID = dto.StateCOM,

                Keyword = dto.KeywordCOM,
                Description = dto.NoteCOM,
                Telephone = dto.TelephoneCOM,
                Email = dto.EmailCOM,
                Website = dto.WebsiteCOM,
                HandPhone = dto.HandPhoneCOM,

                Active = dto.ActiveCOM,
                ARNo = dto.ARCOM,
                OwnerID = dto.OwnerCOM,
                TerritoryID = dto.TerritoryCOM,
                PersonInChargeID = dto.SaleInChargeCOM,
                AcctContact = dto.ContactNameCOM,
                CurrencyID = dto.CurrencyCOM,
                TaxCode = dto.TaxCOM,
                MemberType = dto.CompanyTypeCOM,

                IsBlackList = dto.BlackListCOM,
                BlackListReason = dto.BlackListReasonCOM,
                Company = dto.Company2COM,
                BusinessTitle = dto.BusinessTitleCOM,
                MarketID = dto.MarketCOM,

                UserInsertID = 136,
                UserUpdateID = 136,
                CreateDate = DateTime.Now,
                UpdateDate = DateTime.Now
            };
        }
        private static ProfileModel MapGroup(SaveProfileRequestDto dto)
        {
            return new ProfileModel
            {
                Type = 4,
                Code = dto.CodeGroup,
                Account = dto.GroupNameGroup,

                LanguageID = dto.LanguageGruop,
                Address = dto.AddressGroup,
                HomeAddress = dto.HomeAddressGroup,
                City = dto.CityGroup,
                PostalCode = dto.PostalGroup,
                CountryID = dto.CountryGroup,
                StateID = dto.StateGroup,

                VIPID = dto.VIPGroup,
                VIPReason = dto.VIPReasonGroup,
                Description = dto.NotesGroup,

                Telephone = dto.TelephoneGroup,
                Fax = dto.FaxGroup,
                Email = dto.EmailGroup,
                Website = dto.WebsiteGroup,
                HandPhone = dto.HandPhoneGroup,

                History = dto.HistoryGroup,
                AcctContact = dto.AcctContact,
                CurrencyID = dto.CurrencyGroup,

                UserInsertID = 136,
                UserUpdateID = 136,
                CreateDate = DateTime.Now,
                UpdateDate = DateTime.Now
            };
        }
        private static ProfileModel MapContact(SaveProfileRequestDto dto)
        {
            return new ProfileModel
            {
                Type = 5,
                Code = dto.CodeContact,
                Account = dto.AccountContact,
                LastName = dto.LastNameContact,
                Firstname = dto.FirstNameContact,
                MiddleName = dto.MiddleNameContact,

                LanguageID = dto.LanguageContact,
                TitleID = dto.TitleContact,
                Address = dto.AddressContact,
                HomeAddress = dto.HomeAddressContact,
                City = dto.CityContact,
                PostalCode = dto.PostalContact,
                CountryID = dto.CountryContact,
                StateID = dto.StateContact,
                Salutation = dto.SalutationContact,
                DateOfBirth = dto.DobContact,

                Telephone = dto.TelephoneContact,
                Fax = dto.FaxContact,
                Email = dto.EmaiContact,
                Website = dto.WebsiteContact,
                HandPhone = dto.HandPhoneContact,

                Position = dto.PositionContact,
                Department = dto.DeptContact,
                OwnerID = dto.OwnerContact,
                TerritoryID = dto.TerritoryContact,

                UserInsertID = 136,
                UserUpdateID = 136,
                CreateDate = DateTime.Now,
                UpdateDate = DateTime.Now
            };
        }

        #endregion
    }
}
