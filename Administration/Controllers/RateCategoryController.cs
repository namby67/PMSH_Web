using System.Collections;
using System.Data;
using System.Linq;
using Administration.Services.Interfaces;
using BaseBusiness.bc;
using BaseBusiness.BO;
using BaseBusiness.Model;
using BaseBusiness.util;
using Microsoft.AspNetCore.Mvc;

namespace Administration.Controllers
{
    [Route("/Administration/RateCode")]
    public class RateCategoryController : Controller
    {
        private readonly IRateCategoryService _svRateCategory;
        public RateCategoryController(IRateCategoryService RateCategory)
        {
            _svRateCategory = RateCategory;
        }
        [HttpGet("RateCategory")] // Truyeenf DataGrid , script api
        public IActionResult RateCategory()
        {
            return View("~/Views/Administration/RateCode/RateCategory.cshtml");
            // Truyền đường dẫn chuẩn vào để tìm đúng
        }



        [HttpGet("GetAllRateCategory")]
        public async Task<IActionResult> RateCategoryGetAll(int inactive = 0)
        {
            try
            {
                DataTable dataTable = await _svRateCategory.RateCategoryTypeData(inactive);
                var result = (from d in dataTable.AsEnumerable()
                              select new
                              {
                                  ID = d["ID"]?.ToString() ?? "",
                                  Code = d["Code"]?.ToString() ?? "",
                                  Description = d["Description"]?.ToString() ?? "",
                                  CreatedDate = d["CreatedDate"] != DBNull.Value ? Convert.ToDateTime(d["CreatedDate"]) : (DateTime?)null,
                                  UpdatedDate = d["UpdatedDate"] != DBNull.Value ? Convert.ToDateTime(d["UpdatedDate"]) : (DateTime?)null,
                                  CreatedBy = d["CreatedBy"]?.ToString() ?? "",
                                  UpdatedBy = d["UpdatedBy"]?.ToString() ?? "",
                                  Inactive = d["Inactive"] != DBNull.Value ? Convert.ToInt32(d["Inactive"]) : 0,

                              }).ToList();
                return Json(result);
            }
            catch (Exception ex)
            {

                return BadRequest(new { success = false, message = ex.Message });
            }
        }
        [HttpPost("RateCategorySave")]
        public async Task<IActionResult> RateCategorySave(string idRateCategory, string codeClass, string descriptionaccty, string user, string inactive)
        {
            try
            {
                // Collect validation errors
                List<string> errors = [];
                user = user.Trim().Trim('"');

                // Validate inputs
                if (string.IsNullOrWhiteSpace(codeClass))
                    errors.Add("Code is required.");
                else if (codeClass.Length > 50)
                    errors.Add("Code must be at most 50 characters.");

                if (!string.IsNullOrEmpty(descriptionaccty) && descriptionaccty.Length > 500)
                    errors.Add("Description must be at most 500 characters.");

                if (string.IsNullOrWhiteSpace(user))
                    errors.Add("User is required.");
                else
                {
                    if (user.Length > 100)
                        errors.Add("User must be at most 100 characters.");
                }

                if (inactive != null && inactive != "0" && inactive != "1")
                    errors.Add("Inactive must be 0 or 1.");

                // Validate ID format for update
                int parsedId = 0;
                bool isUpdate = false;
                if (!string.IsNullOrWhiteSpace(idRateCategory) && idRateCategory != "0")
                {
                    if (!int.TryParse(idRateCategory, out parsedId) || parsedId <= 0)
                        errors.Add("Invalid Rate Category ID format.");
                    else
                        isUpdate = true;
                }

                // Get business dates
                List<BusinessDateModel> businessDates = PropertyUtils.ConvertToList<BusinessDateModel>(BusinessDateBO.Instance.FindAll());
                if (businessDates == null || businessDates.Count == 0)
                    errors.Add("Business date not available. Contact system administrator.");

                // Check for duplicate Code (case-insensitive) for insert/update
                if (!string.IsNullOrWhiteSpace(codeClass))
                {
                    var allRateCategories = PropertyUtils.ConvertToList<RateCategoryModel>(RateCategoryBO.Instance.FindAll()) ?? new List<RateCategoryModel>();
                    bool duplicate = allRateCategories.Any(r => string.Equals(r.Code?.Trim(), codeClass.Trim(), StringComparison.OrdinalIgnoreCase) && r.ID != parsedId);
                    if (duplicate)
                        errors.Add("Code already exists.");
                }

                // Return errors if any
                if (errors.Any())
                {
                    return BadRequest(new { success = false, message = "Validation failed.", errors });
                }

                // Prepare model
                RateCategoryModel _Model = new();
                _Model.Code = codeClass.Trim();
                _Model.Description = descriptionaccty ?? string.Empty;
                _Model.Inactive = inactive == "1";

                if (isUpdate)
                {
                    // Verify existing record
                    var existing = RateCategoryBO.Instance.FindByPrimaryKey(parsedId) as RateCategoryModel;
                    if (existing == null || existing.ID == 0)
                    {
                        return NotFound(new { success = false, message = $"Rate Category not found (ID = {parsedId})" });
                    }

                    _Model.ID = parsedId;
                    _Model.UpdatedBy = user;
                    _Model.UpdatedDate = businessDates![0].BusinessDate;
                    _Model.CreatedBy = existing.CreatedBy;
                    _Model.CreatedDate = existing.CreatedDate;
                    RateCategoryBO.Instance.Update(_Model);
                }
                else
                {
                    _Model.UpdatedBy = user;
                    _Model.CreatedBy = user;
                    _Model.CreatedDate = businessDates![0].BusinessDate;
                    _Model.UpdatedDate = _Model.CreatedDate;
                    RateCategoryBO.Instance.Insert(_Model);
                }

                return Json(new { success = true, message = "Success", data = new { id = _Model.ID } });
            }
            catch (Exception ex)
            {
                return BadRequest(new { success = false, message = ex.Message });
            }
        }
        [HttpPost("RateCategoryDelete")]
        public IActionResult RateCategoryDelete(int id)
        {
            try
            {
                ArrayList arr = RateCodeBO.Instance.FindByAttribute("RateCategoryID", id);
                if (arr.Count == 0)
                {
                    return Json(new { success = false, message = "Rate Category is being referenced to in other modules.\nDelete failed.!" });
                }
                RateCategoryBO.Instance.Delete(id);

                return Json(new { success = true, message = $"Success Delete! {id}" });
            }
            catch (Exception ex)
            {
                return BadRequest(new { success = false, message = ex.Message });
            }
        }
    }
}

