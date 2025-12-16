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
    public class RateCodeUserRightController : Controller
    {
        private readonly IRateCodeUserRightService _svRateCodeUserRight;
        public RateCodeUserRightController(IRateCodeUserRightService RateCodeUserRight)
        {
            _svRateCodeUserRight = RateCodeUserRight;
        }
        [HttpGet("RateCodeUserRight")] // Truyeenf DataGrid , script api
        public IActionResult RateCodeUserRight()
        {
            List<UsersModel> listUser = PropertyUtils.ConvertToList<UsersModel>(UsersBO.Instance.FindAll());
            List<RateCodeModel> listRateCode = PropertyUtils.ConvertToList<RateCodeModel>(RateCodeBO.Instance.FindAll());
            ViewBag.RateCodeList = listRateCode;
            ViewBag.UserList = listUser;


            return View("~/Views/Administration/RateCode/RateCodeUserRight.cshtml");
            // Truyền đường dẫn chuẩn vào để tìm đúng
        }



        [HttpGet("GetAllRateCodeUserRight")]
        public async Task<IActionResult> RateCodeUserRightGetAll(string? userName, string? rateCode)
        {
            try
            {
                // Xử lý null
                userName = userName?.Trim() ?? "";
                rateCode = rateCode?.Trim() ?? "";

                // Escape ký tự ' (bắt buộc để tránh SQL injection)
                userName = userName.Replace("'", "''");
                rateCode = rateCode.Replace("'", "''");
                DataTable dataTable = _svRateCodeUserRight.RateCodeUserRightTypeData(userName, rateCode);


                var result = (from d in dataTable.AsEnumerable()
                              select new
                              {
                                  ID = d["ID"]?.ToString() ?? "",
                                  UserName = d["UserName"]?.ToString() ?? "",
                                  UserID = d["UserID"]?.ToString() ?? "",
                                  RateCodeID = d["RateCodeID"] != DBNull.Value ? Convert.ToInt32(d["RateCodeID"]) : 0,
                                  RateCode = d["RateCode"]?.ToString() ?? "",
                                  CreatedDate = d["CreatedDate"] != DBNull.Value ? Convert.ToDateTime(d["CreatedDate"]) : (DateTime?)null,
                                  UpdatedDate = d["UpdatedDate"] != DBNull.Value ? Convert.ToDateTime(d["UpdatedDate"]) : (DateTime?)null,
                                  CreatedBy = d["CreatedBy"]?.ToString() ?? "",
                                  UpdatedBy = d["UpdatedBy"]?.ToString() ?? "",
                              }).ToList();

                return Json(result);
            }
            catch (Exception ex)
            {
                return BadRequest(new { success = false, message = ex.Message });
            }
        }

        // [HttpPost("RateCodeUserRightSave")]
        // public async Task<IActionResult> RateCodeUserRightSave(string idRateCodeUserRight, string codeClass, string nameClass, string descriptionaccty, string user, string inactive)
        // {
        //     try
        //     {
        //         // Collect validation errors
        //         List<string> errors = [];
        //         user = user.Trim().Trim('"');

        //         // Validate inputs
        //         if (string.IsNullOrWhiteSpace(codeClass))
        //             errors.Add("Code is required.");
        //         else if (codeClass.Length > 50)
        //             errors.Add("Code must be at most 50 characters.");
        //         if (string.IsNullOrWhiteSpace(nameClass))
        //             errors.Add("Name is required.");
        //         else if (nameClass.Length > 50)
        //             errors.Add("Name must be at most 50 characters.");

        //         if (!string.IsNullOrEmpty(descriptionaccty) && descriptionaccty.Length > 500)
        //             errors.Add("Description must be at most 500 characters.");

        //         if (string.IsNullOrWhiteSpace(user))
        //             errors.Add("User is required.");
        //         else
        //         {
        //             if (user.Length > 100)
        //                 errors.Add("User must be at most 100 characters.");
        //         }

        //         if (inactive != null && inactive != "0" && inactive != "1")
        //             errors.Add("Inactive must be 0 or 1.");

        //         // Validate ID format for update
        //         int parsedId = 0;
        //         bool isUpdate = false;
        //         if (!string.IsNullOrWhiteSpace(idRateCodeUserRight) && idRateCodeUserRight != "0")
        //         {
        //             if (!int.TryParse(idRateCodeUserRight, out parsedId) || parsedId <= 0)
        //                 errors.Add("Invalid Rate Category ID format.");
        //             else
        //                 isUpdate = true;
        //         }

        //         // Get business dates
        //         List<BusinessDateModel> businessDates = PropertyUtils.ConvertToList<BusinessDateModel>(BusinessDateBO.Instance.FindAll());
        //         if (businessDates == null || businessDates.Count == 0)
        //             errors.Add("Business date not available. Contact system administrator.");

        //         // Check for duplicate Code (case-insensitive) for insert/update
        //         if (!string.IsNullOrWhiteSpace(codeClass))
        //         {
        //             var allRateCategories = PropertyUtils.ConvertToList<RateCodeUserRightModel>(RateCodeUserRightBO.Instance.FindAll()) ?? new List<RateCodeUserRightModel>();
        //             bool duplicate = allRateCategories.Any(r => string.Equals(r.Code?.Trim(), codeClass.Trim(), StringComparison.OrdinalIgnoreCase) && r.ID != parsedId);
        //             if (duplicate)
        //                 errors.Add("Code already exists.");
        //         }

        //         // Return errors if any
        //         if (errors.Any())
        //         {
        //             return BadRequest(new { success = false, message = "Validation failed.", errors });
        //         }

        //         // Prepare model
        //         RateCodeUserRightModel _Model = new();
        //         _Model.Code = codeClass.Trim();
        //         _Model.Name = nameClass.Trim();
        //         _Model.Description = descriptionaccty ?? string.Empty;
        //         _Model.Inactive = inactive == "1";

        //         if (isUpdate)
        //         {
        //             // Verify existing record
        //             var existing = RateCodeUserRightBO.Instance.FindByPrimaryKey(parsedId) as RateCodeUserRightModel;
        //             if (existing == null || existing.ID == 0)
        //             {
        //                 return NotFound(new { success = false, message = $"Rate Category not found (ID = {parsedId})" });
        //             }

        //             _Model.ID = parsedId;
        //             _Model.UpdatedBy = user;
        //             _Model.UpdatedDate = businessDates![0].BusinessDate;
        //             _Model.CreatedBy = existing.CreatedBy;
        //             _Model.CreatedDate = existing.CreatedDate;
        //             RateCodeUserRightBO.Instance.Update(_Model);
        //         }
        //         else
        //         {
        //             _Model.UpdatedBy = user;
        //             _Model.CreatedBy = user;
        //             _Model.CreatedDate = businessDates![0].BusinessDate;
        //             _Model.UpdatedDate = _Model.CreatedDate;
        //             RateCodeUserRightBO.Instance.Insert(_Model);
        //         }

        //         return Json(new { success = true, message = "Success", data = new { id = _Model.ID } });
        //     }
        //     catch (Exception ex)
        //     {
        //         return BadRequest(new { success = false, message = ex.Message });
        //     }
        // }
        // [HttpPost("RateCodeUserRightDelete")]
        // public IActionResult RateCodeUserRightDelete(int id)
        // {
        //     try
        //     {
        //         ArrayList arr = RateCodeBO.Instance.FindByAttribute("RateCodeUserRightID", id);
        //         if (arr.Count == 0)
        //         {
        //             return Json(new { success = false, message = "Rate Category is being referenced to in other modules.\nDelete failed.!" });
        //         }
        //         RateCodeUserRightBO.Instance.Delete(id);

        //         return Json(new { success = true, message = $"Success Delete! {id}" });
        //     }
        //     catch (Exception ex)
        //     {
        //         return BadRequest(new { success = false, message = ex.Message });
        //     }
        // }
    }
}

