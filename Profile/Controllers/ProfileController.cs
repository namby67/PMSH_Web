using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using BaseBusiness.BO;
using BaseBusiness.Model;
using BaseBusiness.util;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Profile.Services.Interfaces;
namespace Profile.Controllers
{
    public class ProfileController : Controller
    {
        private readonly IConfiguration _configuration;
        private readonly ILogger<ProfileController> _logger;
        private readonly IMemoryCache _cache;
        private readonly IProfileExportService _iProfileService;
        private readonly IMembershipService _iMembershipService;

        public ProfileController(ILogger<ProfileController> logger,
             IMemoryCache cache, IConfiguration configuration, IProfileExportService iProfileService,IMembershipService iMembershipService)
        {
            _cache = cache;
            _logger = logger;
            _configuration = configuration;
            _iProfileService = iProfileService;
            _iMembershipService = iMembershipService;
        }
        
        public IActionResult Index()
        {
            return View();
        }

        #region common
        /// <summary>
        /// get all city
        /// </summary>
        /// <param ></param>
        /// <returns>list city model</returns>

        [HttpGet]
        public async Task<IActionResult> GetAllCity()
        {
            List<CityModel> list = new List<CityModel>();
            try
            {
                list = PropertyUtils.ConvertToList<CityModel>(CityBO.Instance.FindAll());
            }
            catch (Exception ex)
            {
                return Json(ex.Message);
            }

            return Json(list);

        }

        // get all language
        [HttpGet]
        public async Task<IActionResult> GetAllLanguage()
        {
            List<LanguageModel> list = new List<LanguageModel>();
            try
            {
                list = PropertyUtils.ConvertToList<LanguageModel>(LanguageBO.Instance.FindAll());
            }
            catch (Exception ex)
            {
                return Json(ex.Message);
            }

            return Json(list);

        }

        // get all title
        [HttpGet]
        public async Task<IActionResult> GetAllTitle()
        {
            List<TitleModel> list = new List<TitleModel>();
            try
            {
                list = PropertyUtils.ConvertToList<TitleModel>(TitleBO.Instance.FindAll());
            }
            catch (Exception ex)
            {
                return Json(ex.Message);
            }

            return Json(list);

        }

        // get all nationality
        [HttpGet]
        public async Task<IActionResult> GetAllNationality()
        {
            List<NationalityModel> list = new List<NationalityModel>();
            try
            {
                list = PropertyUtils.ConvertToList<NationalityModel>(NationalityBO.Instance.FindAll());
            }
            catch (Exception ex)
            {
                return Json(ex.Message);
            }

            return Json(list);

        }

        // get all country
        [HttpGet]
        public async Task<IActionResult> GetAllCountry()
        {
            List<CountryModel> list = new List<CountryModel>();
            try
            {
                list = PropertyUtils.ConvertToList<CountryModel>(CountryBO.Instance.FindAll());
            }
            catch (Exception ex)
            {
                return Json(ex.Message);
            }

            return Json(list);

        }

        // get all state
        [HttpGet]
        public async Task<IActionResult> GetAllState()
        {
            List<StateModel> list = new List<StateModel>();
            try
            {
                list = PropertyUtils.ConvertToList<StateModel>(StateBO.Instance.FindAll()).Where(x => x.Inactive == true).ToList();
            }
            catch (Exception ex)
            {
                return Json(ex.Message);
            }

            return Json(list);

        }

        // get all state
        [HttpGet]
        public async Task<IActionResult> GetAllVIP()
        {
            List<VIPModel> list = new List<VIPModel>();
            try
            {
                list = PropertyUtils.ConvertToList<VIPModel>(VIPBO.Instance.FindAll());
            }
            catch (Exception ex)
            {
                return Json(ex.Message);
            }

            return Json(list);

        }

        // get all owner
        [HttpGet]
        public async Task<IActionResult> GetAllOwner()
        {
            List<OwnerModel> list = new List<OwnerModel>();
            try
            {
                list = PropertyUtils.ConvertToList<OwnerModel>(OwnerBO.Instance.FindAll());
            }
            catch (Exception ex)
            {
                return Json(ex.Message);
            }

            return Json(list);

        }

        // get all terrtory
        [HttpGet]
        public async Task<IActionResult> GetAllTerritory()
        {
            List<TerritoryModel> list = new List<TerritoryModel>();
            try
            {
                list = PropertyUtils.ConvertToList<TerritoryModel>(TerritoryBO.Instance.FindAll());
            }
            catch (Exception ex)
            {
                return Json(ex.Message);
            }

            return Json(list);

        }
        [HttpGet]
        public async Task<IActionResult> GetAllCompanyType()
        {
            List<CompanyTypeModel> list = new List<CompanyTypeModel>();
            try
            {
                list = PropertyUtils.ConvertToList<CompanyTypeModel>(CompanyTypeBO.Instance.FindAll());
            }
            catch (Exception ex)
            {
                return Json(ex.Message);
            }

            return Json(list);

        }
        [HttpGet]
        public async Task<IActionResult> GetAllCurrency()
        {
            List<CurrencyModel> list = new List<CurrencyModel>();
            try
            {
                list = PropertyUtils.ConvertToList<CurrencyModel>(CurrencyBO.Instance.FindAll());
            }
            catch (Exception ex)
            {
                return Json(ex.Message);
            }

            return Json(list);

        }

        [HttpGet]
        public async Task<IActionResult> GetMarketType()
        {
            List<MarketTypeModel> list = new List<MarketTypeModel>();
            try
            {
                list = PropertyUtils.ConvertToList<MarketTypeModel>(MarketTypeBO.Instance.FindAll());
            }
            catch (Exception ex)
            {
                return Json(ex.Message);
            }

            return Json(list);

        }
        [HttpGet]
        public async Task<IActionResult> GetMarketByFK(int marketTypeID)
        {
            List<MarketModel> list = new List<MarketModel>();
            try
            {
                list = PropertyUtils.ConvertToList<MarketModel>(MarketBO.Instance.FindAll()).Where(x => x.MarketTypeID == marketTypeID).ToList();
            }
            catch (Exception ex)
            {
                return Json(ex.Message);
            }

            return Json(list);

        }

        //get all membertype
        [HttpGet]
        public async Task<IActionResult> GetAllMemberType()
        {
            List<MemberTypeModel> list = new List<MemberTypeModel>();
            try
            {
                list = PropertyUtils.ConvertToList<MemberTypeModel>(MemberTypeBO.Instance.FindAll()).ToList();
            }
            catch (Exception ex)
            {
                return Json(ex.Message);
            }

            return Json(list);

        }
        //get all agent
        [HttpGet]
        public async Task<IActionResult> GetAllAgent()
        {
            List<ProfileModel> list = new List<ProfileModel>();
            try
            {
                list = PropertyUtils.ConvertToList<ProfileModel>(ProfileBO.Instance.FindAll()).Where(x => x.Type == 1).ToList();
            }
            catch (Exception ex)
            {
                return Json(ex.Message);
            }

            return Json(list);

        }

        //get all company
        [HttpGet]
        public async Task<IActionResult> GetAllCompany()
        {
            List<ProfileModel> list = new List<ProfileModel>();
            try
            {
                list = PropertyUtils.ConvertToList<ProfileModel>(ProfileBO.Instance.FindAll()).Where(x => x.Type == 2).ToList();
            }
            catch (Exception ex)
            {
                return Json(ex.Message);
            }

            return Json(list);

        }

        //get all contact
        [HttpGet]
        public async Task<IActionResult> GetAllContact()
        {
            List<ProfileModel> list = new List<ProfileModel>();
            try
            {
                list = PropertyUtils.ConvertToList<ProfileModel>(ProfileBO.Instance.FindAll()).Where(x => x.Type == 5).ToList();
            }
            catch (Exception ex)
            {
                return Json(ex.Message);
            }

            return Json(list);

        }

        //get all profile individual
        [HttpGet]
        public async Task<IActionResult> GetAllProfileIndividual()
        {
            List<ProfileModel> list = new List<ProfileModel>();
            try
            {
                list = PropertyUtils.ConvertToList<ProfileModel>(ProfileBO.Instance.FindAll()).Where(x => x.Type == 0).ToList();
            }
            catch (Exception ex)
            {
                return Json(ex.Message);
            }

            return Json(list);

        }

        //get all roomtype
        [HttpGet]
        public async Task<IActionResult> GetAllRoomType()
        {
            List<RoomTypeModel> list = new List<RoomTypeModel>();
            try
            {
                list = PropertyUtils.ConvertToList<RoomTypeModel>(RoomTypeBO.Instance.FindAll()).ToList();
            }
            catch (Exception ex)
            {
                return Json(ex.Message);
            }

            return Json(list);

        }


        //get all room by room type
        [HttpGet]
        public async Task<IActionResult> GetRoomByRoomType(int roomTypeID)
        {
            List<RoomModel> list = new List<RoomModel>();
            try
            {
                list = PropertyUtils.ConvertToList<RoomModel>(RoomBO.Instance.FindAll()).Where(room => roomTypeID == 0 || room.RoomTypeID == roomTypeID).ToList();
            }
            catch (Exception ex)
            {
                return Json(ex.Message);
            }

            return Json(list);

        }
        #endregion

        #region SearchProfile
        public IActionResult SearchProfile()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> GetAllProfiles(string code, string account, string firstName, string keyWord, string city, int type, bool showSaleInCharge)
        {
            try
            {
                DataTable myData = ProfileBO.GetAllProfile(code, account, firstName, keyWord, city, type, showSaleInCharge);

                var result = (from d in myData.AsEnumerable()
                              select new
                              {
                                  ID = int.Parse(d["_ProfileID"].ToString()),
                                  Code = !string.IsNullOrEmpty(d["Code"].ToString()) ? d["Code"] : "",
                                  VIP = !string.IsNullOrEmpty(d["VIP"].ToString()) ? d["VIP"] : "",
                                  Account = !string.IsNullOrEmpty(d["Account"].ToString()) ? d["Account"] : "",
                                  PassPort = !string.IsNullOrEmpty(d["PassPort"].ToString()) ? d["PassPort"] : "",
                                  IdentityCard = !string.IsNullOrEmpty(d["IdentityCard"].ToString()) ? d["IdentityCard"] : "",
                                  Address = !string.IsNullOrEmpty(d["Address"].ToString()) ? d["Address"] : "",
                                  City = !string.IsNullOrEmpty(d["City"].ToString()) ? d["City"] : "",
                                  Nationality = !string.IsNullOrEmpty(d["Nationality"].ToString()) ? d["Nationality"] : "",
                                  HandPhone = !string.IsNullOrEmpty(d["HandPhone"].ToString()) ? d["HandPhone"] : "",
                                  Telephone = !string.IsNullOrEmpty(d["Telephone"].ToString()) ? d["Telephone"] : "",
                                  Email = !string.IsNullOrEmpty(d["Email"].ToString()) ? d["Email"] : "",
                                  Keyword = !string.IsNullOrEmpty(d["Keyword"].ToString()) ? d["Keyword"] : "",
                                  PostalCode = !string.IsNullOrEmpty(d["PostalCode"].ToString()) ? d["PostalCode"] : "",
                                  ReturnGuest = !string.IsNullOrEmpty(d["ReturnGuest"].ToString()) ? d["ReturnGuest"] : "",
                                  StayNo = !string.IsNullOrEmpty(d["StayNo"].ToString()) ? d["StayNo"] : "",
                                  Type = !string.IsNullOrEmpty(d["Type"].ToString()) ? d["Type"] : "",
                                  TaxCode = !string.IsNullOrEmpty(d["TaxCode"].ToString()) ? d["TaxCode"] : "",
                                  FullAccount = !string.IsNullOrEmpty(d["FullAccount"].ToString()) ? d["FullAccount"] : "",
                                  HomeAddress = !string.IsNullOrEmpty(d["HomeAddress"].ToString()) ? d["HomeAddress"] : "",
                                  ARNo = !string.IsNullOrEmpty(d["ARNo"].ToString()) ? d["ARNo"] : "",
                                  Website = !string.IsNullOrEmpty(d["Website"].ToString()) ? d["Website"] : "",
                                  DateOfBirth = !string.IsNullOrEmpty(d["DateOfBirth"].ToString()) ? d["DateOfBirth"] : "",
                                  AcctContact = !string.IsNullOrEmpty(d["AcctContact"].ToString()) ? d["AcctContact"] : "",
                                  Description = !string.IsNullOrEmpty(d["Description"].ToString()) ? d["Description"] : "",
                                  AcctIsBlackListContact = !string.IsNullOrEmpty(d["IsBlackList"].ToString()) ? d["IsBlackList"] : "",
                                  PersonInChargeID = !string.IsNullOrEmpty(d["PersonInChargeID"].ToString()) ? d["PersonInChargeID"] : "",

                              }).ToList();
                return Json(result);
            }
            catch (Exception ex)
            {
                return Json(ex.Message);
            }
        }
        
        [HttpGet]
        public ActionResult GetProfileByID(int id)
        {
            try
            {
                ProfileModel list = (ProfileModel)ProfileBO.Instance.FindByPrimaryKey(id);
                if (list != null && list.ID != 0)
                {
                    return Json(new
                    {
                        code = 0,
                        msg = "Success",
                        profile = list
                    });
                }
                else
                {
                    return Json(new
                    {
                        code = 1,
                        msg = "The profile could not be found. "
                    });
                }

            }
            catch (Exception ex)
            {
                return Json(new
                {
                    code = 1,
                    msg = ex.Message
                });
            }
        }

        [HttpPost]
        public ActionResult EditProfile()
        {
            try
            {
                int id = int.Parse(Request.Form["ID"].ToString());
                ProfileModel profile = (ProfileModel)ProfileBO.Instance.FindByPrimaryKey(id);
                profile.Type = 0;
                profile.Code = Request.Form["CodeIndividual"].ToString();
                profile.Account = Request.Form["AccountIndividual"].ToString();
                profile.FullAccount = "";
                profile.LastName = Request.Form["LastNameIndivdual"].ToString();
                profile.Firstname = Request.Form["FirstNameIndividual"].ToString();
                profile.MiddleName = Request.Form["MiddleNameIndividual"].ToString();
                profile.LanguageID = int.Parse(Request.Form["LanguageIndividual"].ToString());
                profile.TitleID = int.Parse(Request.Form["TitleIndividual"].ToString());
                profile.Address = Request.Form["AddressIndividual"].ToString();
                profile.HomeAddress = "";
                profile.City = Request.Form["CityIndividual"].ToString();
                profile.PostalCode = Request.Form["PostalIndividual"].ToString();
                profile.CountryID =  int.Parse(Request.Form["CountryIndividual"].ToString());
                profile.StateID = int.Parse(Request.Form["StateIndividual"].ToString());
                profile.Salutation = Request.Form["SalutationIndividual"].ToString();
                profile.VIPID = !string.IsNullOrEmpty(Request.Form["VIPIndividual"].ToString()) ? int.Parse(Request.Form["VIPIndividual"].ToString()) : 0;
                profile.VIPReason = Request.Form["ReasonIndividual"].ToString();
                profile.PrefRoom = Request.Form["PrefRoomIndividual"].ToString();
                profile.PassPort = Request.Form["PassportIndividual"].ToString();
                profile.Keyword = Request.Form["KeywordIndividual"].ToString();
                profile.DateOfBirth = !string.IsNullOrEmpty(Request.Form["DobIndividual"].ToString()) ? DateTime.Parse(Request.Form["DobIndividual"].ToString()) : DateTime.MinValue;
                profile.NationalityID = int.Parse(Request.Form["NationalityIndividual"].ToString());
                profile.Description = "";
                profile.Telephone = Request.Form["TelephoneIndividual"].ToString();
                profile.Fax = "";
                profile.Email = Request.Form["EmailIndividual"].ToString();
                profile.Website = Request.Form["WebsiteIndividual"].ToString();
                profile.HandPhone = Request.Form["HandPhoneIndividual"].ToString();
                profile.MailList = false;
                profile.Active = Request.Form["ActiveIndividual"].ToString().ToLower() == "true";
                profile.Contact = Request.Form["ContactIndividual"].ToString().ToLower() == "true";
                profile.History = false;
                profile.ContactProfileID = 0;
                profile.ARNo = "";
                profile.Position = "";
                profile.Department = "";
                profile.EnvelopGreeting = "";
                profile.OwnerID = 0;
                profile.TerritoryID = 0;
                profile.PersonInChargeID = 0;
                profile.AcctContact = "";
                profile.CurrencyID = "";
                profile.TaxCode = Request.Form["TaxIndividual"].ToString();
                profile.Type = 0;
                profile.IdentityCard = Request.Form["CardIndividual"].ToString();
                profile.MemberType = "";
                profile.MemberNo = "";
                profile.LastRoom = "";
                profile.Lastvisit = DateTime.Now;
                profile.LastRate = "";
                profile.LastRateCode = "";
                profile.LastARNo = "";
                profile.LastMemberNo = "";
                profile.ReturnGuest = -1;
                profile.IsBlackList = Request.Form["ActiveIndividual"].ToString().ToLower() == "true";
                profile.BlackListReason = Request.Form["BlackListReasonIndividual"].ToString();
                profile.SpecialUpdateBy = "";
                profile.SpecialUpdateDate = DateTime.Now;
                profile.UserInsertID = profile.UserUpdateID = 136;
                profile.CreateDate = profile.UpdateDate = DateTime.Now;
                profile.StayNo = 0;
                profile.GuestNo = "";
                profile.Occupation = "";
                profile.BonusPoints = 0;
                profile.GuestGroupID = 0;
                profile.Birthplace = "";
                profile.ExpressCheckout = false;
                profile.PayTV = false;
                profile.FirstReservation = profile.LastReservation = profile.WeddingAnniversary = profile.Firstvisit = profile.Expiry = profile.LastContact = DateTime.MinValue;
                profile.CreditCard = "";
                profile.RateCode = "";
                profile.RoomNights = 0;
                profile.BedNights = 0;
                profile.TotalTurnover = 0;
                profile.LodgePackageTurover = 0;
                profile.LodgeTurnover = 0;
                profile.FBTurnover = 0;
                profile.EventTurnover = 0;
                profile.OtherTurnover = 0;
                profile.Company = Request.Form["Company2Individual"].ToString();
                profile.BusinessTitle = Request.Form["BusinessTitleIndividual"].ToString();
                profile.Other = Request.Form["OtherIndividual"].ToString();
                profile.Religion = Request.Form["ReligionIndividual"].ToString();
                profile.Nation = Request.Form["NationIndividual"].ToString(); ;
                profile.PurposeOfStay = Request.Form["PurposeIndividual"].ToString();
                profile.MarketID = 0;
                profile.IsTransfer = false;
                ProfileBO.Instance.Update(profile);
                return Json(new { code = 0, msg = "Update sucessfully" });

            }
            catch (Exception ex)
            {
                return Json(new { code = 1, msg = ex.Message });
            }

        }

        [HttpPost]
        public ActionResult DeleteProfile(string id)
        {

            if (string.IsNullOrEmpty(id)) return null;
            ProfileBO.Instance.Delete(int.Parse(id));
            return Json(new { code = 0, msg = "Profile deleted successfully" });
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProfiles2(string code, string account, string firstName, string keyWord, string city, int type, bool showSaleInCharge, int page = 1, int pageSize = 15)
        {
            try
            {
                (DataTable data, int totalCount) = ProfileBO.GetAllProfile2(code, account, firstName, keyWord, city, type, showSaleInCharge, page, pageSize);
                var result = (from d in data.AsEnumerable()
                              select new
                              {
                                  ID = int.Parse(d["_ProfileID"].ToString()),
                                  Code = d["Code"]?.ToString() ?? "",
                                  VIP = d["VIP"]?.ToString() ?? "",
                                  Account = d["Account"]?.ToString() ?? "",
                                  PassPort = d["PassPort"]?.ToString() ?? "",
                                  IdentityCard = d["IdentityCard"]?.ToString() ?? "",
                                  Address = d["Address"]?.ToString() ?? "",
                                  City = d["City"]?.ToString() ?? "",
                                  Nationality = d["Nationality"]?.ToString() ?? "",
                                  HandPhone = d["HandPhone"]?.ToString() ?? "",
                                  Telephone = d["Telephone"]?.ToString() ?? "",
                                  Email = d["Email"]?.ToString() ?? "",
                                  Keyword = d["Keyword"]?.ToString() ?? "",
                                  PostalCode = d["PostalCode"]?.ToString() ?? "",
                                  ReturnGuest = d["ReturnGuest"]?.ToString() ?? "",
                                  StayNo = d["StayNo"]?.ToString() ?? "",
                                  Type = d["Type"]?.ToString() ?? "",
                                  TaxCode = d["TaxCode"]?.ToString() ?? "",
                                  FullAccount = d["FullAccount"]?.ToString() ?? "",
                                  HomeAddress = d["HomeAddress"]?.ToString() ?? "",
                                  ARNo = d["ARNo"]?.ToString() ?? "",
                                  Website = d["Website"]?.ToString() ?? "",
                                  DateOfBirth = d["DateOfBirth"]?.ToString() ?? "",
                                  AcctContact = d["AcctContact"]?.ToString() ?? "",
                                  Description = d["Description"]?.ToString() ?? "",
                                  AcctIsBlackListContact = d["IsBlackList"]?.ToString() ?? "",
                                  PersonInChargeID = d["PersonInChargeID"]?.ToString() ?? ""
                              }).ToList();
                return Json(new { data = result, totalCount = totalCount });
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        #endregion

        #region new profile
        //[ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult SaveProfile()
        {
            try
            {
                int profileType = int.Parse(Request.Form["Type"].ToString());
                ProfileModel profile = new ProfileModel();
                profile.Type = profileType;
                if (profileType == 0)
                {
                    profile.Code = Request.Form["CodeIndividual"].ToString();
                    profile.Account = Request.Form["AccountIndividual"].ToString();
                    profile.FullAccount = "";
                    profile.LastName = Request.Form["LastNameIndivdual"].ToString();
                    profile.Firstname = Request.Form["FirstNameIndividual"].ToString();
                    profile.MiddleName = Request.Form["MiddleNameIndividual"].ToString();
                    profile.LanguageID = int.Parse(Request.Form["LanguageIndividual"].ToString());
                    profile.TitleID = int.Parse(Request.Form["TitleIndividual"].ToString());
                    profile.Address = Request.Form["AddressIndividual"].ToString();
                    profile.HomeAddress = "";
                    profile.City = Request.Form["CityIndividual"].ToString();
                    profile.PostalCode = Request.Form["PostalIndividual"].ToString();
                    profile.CountryID = int.Parse(Request.Form["CountryIndividual"].ToString());
                    profile.StateID = int.Parse(Request.Form["StateIndividual"].ToString());
                    profile.Salutation = Request.Form["SalutationIndividual"].ToString();
                    profile.VIPID = int.Parse(Request.Form["VIPIndividual"].ToString());
                    profile.VIPReason = Request.Form["ReasonIndividual"].ToString();
                    profile.PrefRoom = Request.Form["PrefRoomIndividual"].ToString();
                    profile.PassPort = Request.Form["PassportIndividual"].ToString();
                    profile.Keyword = Request.Form["KeywordIndividual"].ToString();
                    profile.DateOfBirth = DateTime.Parse(Request.Form["DobIndividual"].ToString());
                    profile.NationalityID = int.Parse(Request.Form["NationalityIndividual"].ToString());
                    profile.Description = "";
                    profile.Telephone = Request.Form["TelephoneIndividual"].ToString();
                    profile.Fax = "";
                    profile.Email = Request.Form["EmailIndividual"].ToString();
                    profile.Website = Request.Form["WebsiteIndividual"].ToString();
                    profile.HandPhone = Request.Form["HandPhoneIndividual"].ToString();
                    profile.MailList = false;
                    profile.Active = Request.Form["ActiveIndividual"].ToString().ToLower() == "true";
                    profile.Contact = Request.Form["ContactIndividual"].ToString().ToLower() == "true";
                    profile.History = false;
                    profile.ContactProfileID = 0;
                    profile.ARNo = "";
                    profile.Position = "";
                    profile.Department = "";
                    profile.EnvelopGreeting = "";
                    profile.OwnerID = 0;
                    profile.TerritoryID = 0;
                    profile.PersonInChargeID = 0;
                    profile.AcctContact = "";
                    profile.CurrencyID = "";
                    profile.TaxCode = Request.Form["TaxIndividual"].ToString();
                    profile.Type = 0;
                    profile.IdentityCard = Request.Form["CardIndividual"].ToString();
                    profile.MemberType = "";
                    profile.MemberNo = "";
                    profile.LastRoom = "";
                    profile.Lastvisit = DateTime.Now;
                    profile.LastRate = "";
                    profile.LastRateCode = "";
                    profile.LastARNo = "";
                    profile.LastMemberNo = "";
                    profile.ReturnGuest = -1;
                    profile.IsBlackList = Request.Form["ActiveIndividual"].ToString().ToLower() == "true";
                    profile.BlackListReason = Request.Form["BlackListReasonIndividual"].ToString();
                    profile.SpecialUpdateBy = "";
                    profile.SpecialUpdateDate = DateTime.Now;
                    profile.UserInsertID = profile.UserUpdateID = 136;
                    profile.CreateDate = profile.UpdateDate = DateTime.Now;
                    profile.StayNo = 0;
                    profile.GuestNo = "";
                    profile.Occupation = "";
                    profile.BonusPoints = 0;
                    profile.GuestGroupID = 0;
                    profile.Birthplace = "";
                    profile.ExpressCheckout = false;
                    profile.PayTV = false;
                    profile.FirstReservation = profile.LastReservation = profile.WeddingAnniversary = profile.Firstvisit = profile.Expiry = profile.LastContact = DateTime.MinValue;
                    profile.CreditCard = "";
                    profile.RateCode = "";
                    profile.RoomNights = 0;
                    profile.BedNights = 0;
                    profile.TotalTurnover = 0;
                    profile.LodgePackageTurover = 0;
                    profile.LodgeTurnover = 0;
                    profile.FBTurnover = 0;
                    profile.EventTurnover = 0;
                    profile.OtherTurnover = 0;
                    profile.Company = Request.Form["Company2Individual"].ToString();
                    profile.BusinessTitle = Request.Form["BusinessTitleIndividual"].ToString();
                    profile.Other = Request.Form["OtherIndividual"].ToString();
                    profile.Religion = Request.Form["ReligionIndividual"].ToString();
                    profile.Nation = Request.Form["NationIndividual"].ToString(); ;
                    profile.PurposeOfStay = Request.Form["PurposeIndividual"].ToString();
                    profile.MarketID = 0;
                    profile.IsTransfer = false;

                }
                else if (profileType == 1 || profileType == 2 || profileType == 3)
                {
                    profile.Code = Request.Form["CodeCOM"].ToString();
                    profile.Account = Request.Form["AccountCOM"].ToString();
                    profile.FullAccount = "";
                    profile.LastName = "";
                    profile.Firstname = "";
                    profile.MiddleName = "";
                    profile.LanguageID = 0;
                    profile.TitleID = 0;
                    profile.Address = Request.Form["AddressCOM"].ToString();
                    profile.HomeAddress = "";
                    profile.City = Request.Form["CityCOM"].ToString();
                    profile.PostalCode = Request.Form["PostalCOM"].ToString();
                    profile.CountryID = 0;
                    profile.StateID = int.Parse(Request.Form["StateCOM"].ToString());
                    profile.Salutation = "";
                    profile.VIPID = 0;
                    profile.VIPReason = "";
                    profile.PrefRoom = "";
                    profile.PassPort = "";
                    profile.Keyword = Request.Form["KeywordCOM"].ToString();
                    profile.DateOfBirth = DateTime.MinValue;
                    profile.NationalityID = 0;
                    profile.Description = "";
                    profile.Telephone = Request.Form["TelephoneCOM"].ToString();
                    profile.Fax = "";
                    profile.Email = Request.Form["EmailCOM"].ToString();
                    profile.Website = Request.Form["WebsiteCOM"].ToString();
                    profile.HandPhone = Request.Form["HandPhoneCOM"].ToString();
                    profile.MailList = false;
                    profile.Active = Request.Form["ActiveCOM"].ToString().ToLower() == "true";
                    profile.Contact = false;
                    profile.History = false;
                    profile.ContactProfileID = 0;
                    profile.ARNo = Request.Form["ARCOM"].ToString();
                    profile.Position = "";
                    profile.Department = "";
                    profile.EnvelopGreeting = "";
                    profile.OwnerID = int.Parse(Request.Form["OwnerCOM"].ToString());
                    profile.TerritoryID = int.Parse(Request.Form["TerritoryCOM"].ToString());
                    profile.PersonInChargeID = 0;
                    profile.AcctContact = Request.Form["ContactNameCOM"].ToString();
                    profile.CurrencyID = Request.Form["CurrencyCOM"].ToString();
                    profile.TaxCode = Request.Form["TaxCOM"].ToString();
                    profile.Type = int.Parse(Request.Form["Type"].ToString());
                    profile.IdentityCard = "";
                    profile.MemberType = "";
                    profile.MemberNo = "";
                    profile.LastRoom = "";
                    profile.Lastvisit = DateTime.Now;
                    profile.LastRate = "";
                    profile.LastRateCode = "";
                    profile.LastARNo = "";
                    profile.LastMemberNo = "";
                    profile.ReturnGuest = -1;
                    profile.IsBlackList = Request.Form["BlackListCOM"].ToString().ToLower() == "true";
                    profile.BlackListReason = Request.Form["BlackListReasonCOM"].ToString();
                    profile.SpecialUpdateBy = "";
                    profile.SpecialUpdateDate = DateTime.Now;
                    profile.UserInsertID = profile.UserUpdateID = 136;
                    profile.CreateDate = profile.UpdateDate = DateTime.Now;
                    profile.StayNo = 0;
                    profile.GuestNo = "";
                    profile.Occupation = "";
                    profile.BonusPoints = 0;
                    profile.GuestGroupID = 0;
                    profile.Birthplace = "";
                    profile.ExpressCheckout = false;
                    profile.PayTV = false;
                    profile.FirstReservation = profile.LastReservation = profile.WeddingAnniversary = profile.Firstvisit = profile.Expiry = profile.LastContact = DateTime.MinValue;
                    profile.CreditCard = "";
                    profile.RateCode = "";
                    profile.RoomNights = 0;
                    profile.BedNights = 0;
                    profile.TotalTurnover = 0;
                    profile.LodgePackageTurover = 0;
                    profile.LodgeTurnover = 0;
                    profile.FBTurnover = 0;
                    profile.EventTurnover = 0;
                    profile.OtherTurnover = 0;
                    profile.Company = Request.Form["Company2COM"].ToString();
                    profile.BusinessTitle = Request.Form["BusinessTitleCOM"].ToString();
                    profile.Other = "";
                    profile.Religion = "";
                    profile.Nation = "";
                    profile.PurposeOfStay = "";
                    profile.MarketID = int.Parse(Request.Form["MarketCOM"].ToString());
                    profile.IsTransfer = false;

                }
                else if (profileType == 4)
                {
                    profile.Code = Request.Form["CodeGroup"].ToString();
                    profile.Account = "";
                    profile.FullAccount = "";
                    profile.LastName = "";
                    profile.Firstname = "";
                    profile.MiddleName = "";
                    profile.LanguageID = int.Parse(Request.Form["LanguageGroup"].ToString());
                    profile.TitleID = 0;
                    profile.Address = "";
                    profile.HomeAddress = Request.Form["HomeAddressGroup"].ToString();
                    profile.City = Request.Form["CityGroup"].ToString();
                    profile.PostalCode = Request.Form["PostalGroup"].ToString();
                    profile.CountryID = 0;
                    profile.StateID = int.Parse(Request.Form["StateGroup"].ToString());
                    profile.Salutation = "";
                    profile.VIPID = int.Parse(Request.Form["VIPGroup"].ToString());
                    profile.VIPReason = Request.Form["VIPReasonGroup"].ToString();
                    profile.PrefRoom = "";
                    profile.PassPort = "";
                    profile.Keyword = "";
                    profile.DateOfBirth = DateTime.MinValue;
                    profile.NationalityID = 0;
                    profile.Description = "";
                    profile.Telephone = Request.Form["TelephoneGroup"].ToString();
                    profile.Fax = Request.Form["FaxGroup"].ToString();
                    profile.Email = Request.Form["EmailGroup"].ToString();
                    profile.Website = Request.Form["WebsiteGroup"].ToString();
                    profile.HandPhone = Request.Form["HandPhoneGroup"].ToString();
                    profile.MailList = false;
                    profile.Active = false;
                    profile.Contact = false;
                    profile.History = Request.Form["HistoryGroup"].ToString().ToLower() == "true";
                    profile.ContactProfileID = 0;
                    profile.ARNo = "";
                    profile.Position = "";
                    profile.Department = "";
                    profile.EnvelopGreeting = "";
                    profile.OwnerID = 0;
                    profile.TerritoryID = 0;
                    profile.PersonInChargeID = 0;
                    profile.AcctContact = Request.Form["ContractNameGroup"].ToString();
                    profile.CurrencyID = Request.Form["CurrencyGroup"].ToString();
                    profile.TaxCode = "";
                    profile.Type = int.Parse(Request.Form["Type"].ToString());
                    profile.IdentityCard = "";
                    profile.MemberType = "";
                    profile.MemberNo = "";
                    profile.LastRoom = "";
                    profile.Lastvisit = DateTime.Now;
                    profile.LastRate = "";
                    profile.LastRateCode = "";
                    profile.LastARNo = "";
                    profile.LastMemberNo = "";
                    profile.ReturnGuest = -1;
                    profile.IsBlackList = false;
                    profile.BlackListReason = "";
                    profile.SpecialUpdateBy = "";
                    profile.SpecialUpdateDate = DateTime.Now;
                    profile.UserInsertID = profile.UserUpdateID = 136;
                    profile.CreateDate = profile.UpdateDate = DateTime.Now;
                    profile.StayNo = 0;
                    profile.GuestNo = "";
                    profile.Occupation = "";
                    profile.BonusPoints = 0;
                    profile.GuestGroupID = 0;
                    profile.Birthplace = "";
                    profile.ExpressCheckout = false;
                    profile.PayTV = false;
                    profile.FirstReservation = profile.LastReservation = profile.WeddingAnniversary = profile.Firstvisit = profile.Expiry = profile.LastContact = DateTime.MinValue;
                    profile.CreditCard = "";
                    profile.RateCode = "";
                    profile.RoomNights = 0;
                    profile.BedNights = 0;
                    profile.TotalTurnover = 0;
                    profile.LodgePackageTurover = 0;
                    profile.LodgeTurnover = 0;
                    profile.FBTurnover = 0;
                    profile.EventTurnover = 0;
                    profile.OtherTurnover = 0;
                    profile.Company = "";
                    profile.BusinessTitle = "";
                    profile.Other = "";
                    profile.Religion = "";
                    profile.Nation = "";
                    profile.PurposeOfStay = "";
                    profile.MarketID = 0;
                    profile.IsTransfer = false;
                }
                else
                {
                    profile.Code = Request.Form["CodeContact"].ToString();
                    profile.Account = Request.Form["AccountContact"].ToString();
                    profile.FullAccount = "";
                    profile.LastName = Request.Form["LastNameContact"].ToString();
                    profile.Firstname = Request.Form["FirstNameContact"].ToString();
                    profile.MiddleName = Request.Form["MiddleNameContact"].ToString();
                    profile.LanguageID = int.Parse(Request.Form["LanguageContact"].ToString());
                    profile.TitleID = int.Parse(Request.Form["TitleContact"].ToString());
                    profile.Address = Request.Form["AddressContact"].ToString();
                    profile.HomeAddress = Request.Form["HomeAddressContact"].ToString();
                    profile.City = Request.Form["CityContact"].ToString();
                    profile.PostalCode = Request.Form["PostalContact"].ToString();
                    profile.CountryID = int.Parse(Request.Form["CountryContact"].ToString());
                    profile.StateID = int.Parse(Request.Form["StateContact"].ToString());
                    profile.Salutation = Request.Form["SalutationContact"].ToString();
                    profile.VIPID = 0;
                    profile.VIPReason = "";
                    profile.PrefRoom = "";
                    profile.PassPort = "";
                    profile.Keyword = "";
                    profile.DateOfBirth = DateTime.Parse(Request.Form["DobContact"].ToString());
                    profile.NationalityID = 0;
                    profile.Description = "";
                    profile.Telephone = Request.Form["TelephoneContact"].ToString();
                    profile.Fax = Request.Form["FaxContact"].ToString();
                    profile.Email = Request.Form["EmaiContact"].ToString();
                    profile.Website = Request.Form["WebsiteContact"].ToString();
                    profile.HandPhone = Request.Form["HandPhoneContact"].ToString();
                    profile.MailList = false;
                    profile.Active = false;
                    profile.Contact = false;
                    profile.History = false;
                    profile.ContactProfileID = 0;
                    profile.ARNo = Request.Form["HandPhoneContact"].ToString();
                    profile.Position = Request.Form["PositionContact"].ToString();
                    profile.Department = Request.Form["DeptContact"].ToString();
                    profile.EnvelopGreeting = "";
                    profile.OwnerID = int.Parse(Request.Form["OwnerContact"].ToString());
                    profile.TerritoryID = int.Parse(Request.Form["TerritoryContact"].ToString());
                    profile.PersonInChargeID = 0;
                    profile.AcctContact = "";
                    profile.CurrencyID = "";
                    profile.TaxCode = "";
                    profile.Type = 0;
                    profile.IdentityCard = "";
                    profile.MemberType = "";
                    profile.MemberNo = "";
                    profile.LastRoom = "";
                    profile.Lastvisit = DateTime.Now;
                    profile.LastRate = "";
                    profile.LastRateCode = "";
                    profile.LastARNo = "";
                    profile.LastMemberNo = "";
                    profile.ReturnGuest = -1;
                    profile.IsBlackList = false;
                    profile.BlackListReason = "";
                    profile.SpecialUpdateBy = "";
                    profile.SpecialUpdateDate = DateTime.Now;
                    profile.UserInsertID = profile.UserUpdateID = 136;
                    profile.CreateDate = profile.UpdateDate = DateTime.Now;
                    profile.StayNo = 0;
                    profile.GuestNo = "";
                    profile.Occupation = "";
                    profile.BonusPoints = 0;
                    profile.GuestGroupID = 0;
                    profile.Birthplace = "";
                    profile.ExpressCheckout = false;
                    profile.PayTV = false;
                    profile.FirstReservation = profile.LastReservation = profile.WeddingAnniversary = profile.Firstvisit = profile.Expiry = profile.LastContact = DateTime.MinValue;
                    profile.CreditCard = "";
                    profile.RateCode = "";
                    profile.RoomNights = 0;
                    profile.BedNights = 0;
                    profile.TotalTurnover = 0;
                    profile.LodgePackageTurover = 0;
                    profile.LodgeTurnover = 0;
                    profile.FBTurnover = 0;
                    profile.EventTurnover = 0;
                    profile.OtherTurnover = 0;
                    profile.Company = "";
                    profile.BusinessTitle = "";
                    profile.Other = "";
                    profile.Religion = "";
                    profile.Nation = "";
                    profile.PurposeOfStay = "";
                    profile.MarketID = 0;
                    profile.IsTransfer = false;
                }
                ProfileBO.Instance.Insert(profile);
                return Json(new { code = 0, msg = "New profile created successfully" });

            }
            catch (Exception ex)
            {
                return Json(new { code = 1, msg = ex.Message });
            }

        }
        #endregion

        #region new profile in reservation
        //[ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult SaveProfileInReservation()
        {
            try
            {
                ProfileModel profile = new ProfileModel();

                profile.Account = Request.Form["AccountIndividual"].ToString();
                profile.FullAccount = "";
                profile.LastName = Request.Form["LastNameIndivdual"].ToString();
                profile.Firstname = Request.Form["FirstNameIndividual"].ToString();
                profile.MiddleName = Request.Form["MiddleNameIndividual"].ToString();
                profile.Type = 0;
                profile.UserInsertID = profile.UserUpdateID = int.Parse(Request.Form["userID"].ToString());
                profile.CreateDate = profile.UpdateDate = DateTime.Now;
                long id = ProfileBO.Instance.Insert(profile);
                return Json(new { code = 0, msg = "New profile created successfully",id = id });

            }
            catch (Exception ex)
            {
                return Json(new { code = 1, msg = ex.Message });
            }

        }
        #endregion

        #region DatVP __ Profile Export
        public IActionResult ProfileExport()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> SearchProfileExport(DateTime fromDate, DateTime toDate)
        {
            try
            {
                var data = _iProfileService.SearchProfileExport(fromDate, toDate);

                var result = (from d in data.AsEnumerable()
                              select d.Table.Columns.Cast<DataColumn>()
                                  .ToDictionary(
                                      col => col.ColumnName,
                                      col => d[col.ColumnName]?.ToString()
                                  )).ToList();
                return Json(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        #endregion

        #region DatVP __ Profile History
        [HttpGet]
        public async Task<IActionResult> SearchProfileHistory(int profileID)
        {
            try
            {
                var data = _iProfileService.SearchProfileHistory(profileID,0,"");

                var result = (from d in data.AsEnumerable()
                              select d.Table.Columns.Cast<DataColumn>()
                                  .ToDictionary(
                                      col => col.ColumnName,
                                      col => d[col.ColumnName]?.ToString()
                                  )).ToList();
                return Json(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        #endregion

        #region DatVP __ Profile Membership
        [HttpGet]
        public async Task<IActionResult> SearchProfileMembership(int profileID,string inactive)
        {
            try
            {
                var data = _iMembershipService.SearchProfileMembership(profileID, inactive ?? "", "");

                var result = (from d in data.AsEnumerable()
                              select d.Table.Columns.Cast<DataColumn>()
                                  .ToDictionary(
                                      col => col.ColumnName,
                                      col => d[col.ColumnName]?.ToString()
                                  )).ToList();
                return Json(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        #endregion
    }
}
