using Administration.DTO;
using Administration.Services.Interfaces;
using BaseBusiness.BO;
using BaseBusiness.Model;
using BaseBusiness.util;
using Microsoft.AspNetCore.Mvc;

namespace Administration.Controllers
{
    [Route("/Administration/RateCode")]
    public class PackageDetailController : Controller
    {
        private readonly IPackageDetailService _packagedetail;
        public PackageDetailController(IPackageDetailService packagedetail)
        {
            _packagedetail = packagedetail;
        }
        [HttpGet("PackageDetail")] // Truyeenf DataGrid , script api
        public IActionResult PackageDetail()
        {
            return View("~/Views/Administration/RateCode/PackageDetail.cshtml");
            // Truyền đường dẫn chuẩn vào để tìm đúng
        }

        [HttpGet("GetPackageDetailByIDPackage")]
        public IActionResult GetPackageDetailByIDPackage(int id)
        {
            try
            {
                if (id <= 0)
                {
                    return BadRequest(new
                    {
                        success = false,
                        message = "Invalid PackageID"
                    });
                }

                var dtoList = _packagedetail.GetPackageDetailsByPackageID(id);

                if (dtoList == null || dtoList.Count == 0)
                {
                    return Ok(new
                    {
                        success = true,
                        message = "No package detail found",
                        data = new List<PackageDetailDTO>()
                    });
                }

                return Ok(new
                {
                    success = true,
                    message = "Success",
                    data = dtoList
                });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new
                {
                    success = false,
                    message = ex.Message,
                    innerException = ex.InnerException?.Message,
                    stackTrace = ex.StackTrace
                });
            }
        }

        [HttpPost("SaveDetailPackage")]
        public IActionResult SaveDetailPackage([FromBody] PackageDetailDTO dto)
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

                //Basic Validation
                if (dto.CalculationRuleID < 0)
                {
                    errors.Add("Calculation is required.");
                }
                if (dto.RhythmPostingID < 0)
                {
                    errors.Add("RhythmPosting is required.");
                }
                if (dto.SeasonID < 0)
                {
                    errors.Add("Season is required.");
                }
                if (string.IsNullOrWhiteSpace(dto.TransCode))
                    errors.Add("Transaction Code is required.");

                if (string.IsNullOrWhiteSpace(dto.CurrencyID))
                    errors.Add("Currency Code is required.");

                //Business Validation
                var businessDates = PropertyUtils
                    .ConvertToList<BusinessDateModel>(BusinessDateBO.Instance.FindAll());

                if (businessDates == null || businessDates.Count == 0)
                    errors.Add("Business date not available. Contact system administrator.");


                var RhythmPostingList = RhythmPostingBO.Instance.FindByPrimaryKey(dto.RhythmPostingID);
                if (RhythmPostingList == null)
                    errors.Add("Business date not available. Contact system administrator.");

                // Transaction Code
                if (!string.IsNullOrWhiteSpace(dto.TransCode))
                {
                    var transList = TransactionsBO.Instance.FindByAttribute("Code", dto.TransCode);
                    if (transList == null || transList.Count == 0)
                        errors.Add("Invalid Transaction Code.");
                }
                if (!string.IsNullOrWhiteSpace(dto.CurrencyID))
                {
                    var currencyList = CurrencyBO.Instance.FindByPrimaryKey(dto.CurrencyID);
                    if (currencyList == null || currencyList.Count == 0)
                        errors.Add("Invalid Transaction Code.");
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
                int id = _packagedetail.Save(dto);

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
                return Json(new
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
