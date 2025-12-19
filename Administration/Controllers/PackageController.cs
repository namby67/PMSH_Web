using System.Data;
using Administration.DTO;
using Administration.Services.Interfaces;
using BaseBusiness.BO;
using BaseBusiness.Model;
using BaseBusiness.util;
using Microsoft.AspNetCore.Mvc;

namespace Administration.Controllers
{
    [Route("/Administration/RateCode")]
    public class PackageController : Controller
    {
        private readonly IAdministrationService _administrationService;
        private readonly IPackageService _packageService;

        public PackageController(IAdministrationService administrationService, IPackageService packageService)
        {
            _administrationService = administrationService;
            _packageService = packageService;
        }

        [HttpGet("Package")] // Truyeenf DataGrid , script api
        public IActionResult Package()
        {
            List<SeasonModel> listSeason = PropertyUtils.ConvertToList<SeasonModel>(SeasonBO.Instance.FindAll());
            List<PackageModel> listPackage = PropertyUtils.ConvertToList<PackageModel>(PackageBO.Instance.FindAll());
            List<TransactionsModel> listTransaction = PropertyUtils.ConvertToList<TransactionsModel>(TransactionsBO.Instance.FindAll());
            List<PackageForecastGroupModel> listPackageForecastGroup = PropertyUtils.ConvertToList<PackageForecastGroupModel>(PackageForecastGroupBO.Instance.FindAll());
            List<CurrencyModel> listCurrency = _administrationService.GetAllCurrency();
            List<RhythmPostingModel> listRhythmPosting = PropertyUtils.ConvertToList<RhythmPostingModel>(RhythmPostingBO.Instance.FindAll());


            ViewBag.SeasonList = listSeason;
            ViewBag.TransactionList = listTransaction;
            ViewBag.PackageList = listPackage;
            ViewBag.PackageForecastGroup = listPackageForecastGroup;
            ViewBag.CurrencyList = listCurrency;
            ViewBag.RhythmPostingList = listRhythmPosting;
            return View("~/Views/Administration/RateCode/Package.cshtml");
            // Truyền đường dẫn chuẩn vào để tìm đúng
        }

        [HttpGet("GetByIDPackage")]
        public async Task<IActionResult> GetByIDPackage(int id)
        {
            try
            {
                if (id <= 0)
                {
                    return Json(new
                    {
                        success = false,
                        message = "Invalid ID"
                    });
                }
                if (PackageBO.Instance.FindByPrimaryKey(id) is not PackageModel pack || pack.ID == 0)
                {
                    return Json(new
                    {
                        success = false,
                        message = $"Rate Code not found (ID = {id})"
                    });
                }

                return Json(new
                {
                    success = true,
                    message = "Success",
                    data = pack
                });
            }
            catch (Exception ex)
            {
                // _logger.LogError(ex, $"GetByID failed with ID {id}");
                return Json(new
                {
                    success = false,
                    message = "Error: " + ex.Message
                });
            }
        }

        [HttpPost("SavePackage")]
        public IActionResult SavePackage([FromBody] PackageDTO dto)
        {
            try
            {
                if (dto == null)
                {
                    return BadRequest(new
                    {
                        success = false,
                        message = "Payload is null"
                    });
                }

                List<string> errors = [];

                // ===== BASIC VALIDATION =====
                if (string.IsNullOrWhiteSpace(dto.TransCode))
                    errors.Add("Transaction Code is required.");

                if (string.IsNullOrWhiteSpace(dto.Description))
                    errors.Add("Description is required.");
                else if (dto.Description.Length > 255)
                    errors.Add("Description must be at most 255 characters.");

                if (dto.UserInsertID <= 0)
                    errors.Add("UserID is required.");

                // ===== BUSINESS VALIDATION =====

                // Business Date
                var businessDates = PropertyUtils
                    .ConvertToList<BusinessDateModel>(BusinessDateBO.Instance.FindAll());

                if (businessDates == null || businessDates.Count == 0)
                    errors.Add("Business date not available. Contact system administrator.");

                // Transaction Code
                if (!string.IsNullOrWhiteSpace(dto.TransCode))
                {
                    var transList = TransactionsBO.Instance.FindByAttribute("Code", dto.TransCode);
                    if (transList == null || transList.Count == 0)
                        errors.Add("Invalid Transaction Code.");
                }

                // Forecast Group
                if (dto.ForecastGroupID <= 0)
                {
                    errors.Add("Forecast Group is required.");
                }
                else
                {
                    var forecastGroup = PackageForecastGroupBO.Instance
                        .FindByPrimaryKey(dto.ForecastGroupID);

                    if (forecastGroup == null)
                        errors.Add("Invalid Forecast Group.");
                }

                // ===== RETURN IF ERROR =====
                if (errors.Count != 0)
                {
                    return Json(new
                    {
                        success = false,
                        message = "Validation failed.",
                        errors
                    });
                }

                // ===== CALL SERVICE =====
                int id = _packageService.Save(dto);

                return Ok(new
                {
                    success = true,
                    message = "Success",
                    data = new { id }
                });
            }
            catch (KeyNotFoundException ex)
            {
                return Json(new
                {
                    success = false,
                    message = ex.Message
                });
            }
            catch (Exception ex)
            {
                return Json( new
                {
                    success = false,
                    message = ex.Message,
                    innerException = ex.InnerException?.Message,
                    stackTrace = ex.StackTrace
                });
            }
        }
    }
}
