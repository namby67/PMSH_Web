using System.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Administration.Services.Interfaces;
using BaseBusiness.BO;
using BaseBusiness.Model;
using BaseBusiness.util;
using DevExpress.DataProcessing.InMemoryDataProcessor;
using Microsoft.AspNetCore.Mvc;

namespace Administration.Controllers
{
    [Route("/Administration/RateCode")]
    public class RateCodeController(IRateCodeService rateCodeService) : Controller
    {
        private readonly IRateCodeService _rateCodeSer = rateCodeService;

        [HttpGet("")]
        public IActionResult RateCode()
        {
            List<RateCodeModel> listRateCode = PropertyUtils.ConvertToList<RateCodeModel>(RateCodeBO.Instance.FindAll());
            List<RateCategoryModel> listRateCate = PropertyUtils.ConvertToList<RateCategoryModel>(RateCategoryBO.Instance.FindAll());
            List<RateClassModel> listRateClass = PropertyUtils.ConvertToList<RateClassModel>(RateClassBO.Instance.FindAll());
            ViewBag.RateCodeList = listRateCode;
            ViewBag.RateCateList = listRateCate;
            ViewBag.RateClass = listRateClass;
            return View("~/Views/Administration/RateCode/RateCode.cshtml");
        }
        [HttpGet("GetAllRateCode")]
        public IActionResult GetAllRateCode(string rateCode, string rateCategory)
        {
            try
            {
                DataTable dataTable = _rateCodeSer.GetAllRateCode(rateCode, rateCategory);
                var result = (from d in dataTable.AsEnumerable()
                              select new
                              {
                                  ID = d.Field<int>("ID") == 0 ? "" : d.Field<int>("ID").ToString(),
                                  Sequence = d.Field<int>("Sequence") == 0 ? "" : d.Field<int>("Sequence").ToString(),
                                  RateCode = d.Field<string>("RateCode") ?? "",
                                  Category = d.Field<string>("Category") ?? "",
                                  Description = d.Field<string>("Description") ?? ""
                              }).ToList();

                return Json(result);
            }
            catch (Exception ex)
            {
                return Json(ex.Message);
            }
        }
        [HttpGet("GetByID")]
        public async Task<IActionResult> GetByID(int id)
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
                var codeModel = RateCodeBO.Instance.FindByPrimaryKey(id) as RateCodeModel;
                if (codeModel == null || codeModel.ID == 0)
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
                    data = codeModel
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


        [HttpPost("Save")]
        public IActionResult Save([FromBody] RateCodeDto model)
        {
            try
            {
                // Basic null check
                if (model == null)
                {
                    return BadRequest(new { success = false, message = $"Payload is null" });
                }

                // Collect validation errors
                List<string> errors = new();

                if (string.IsNullOrWhiteSpace(model.RateCode))
                    errors.Add("RateCode is required.");
                else if (model.RateCode.Length > 100)
                    errors.Add("RateCode must be at most 100 characters.");

                if (!string.IsNullOrEmpty(model.Description) && model.Description.Length > 500)
                    errors.Add("Description must be at most 500 characters.");

                if (model.Sequence < 0)
                    errors.Add("Sequence must be greater than or equal to 0.");

                if (model.Display < 0 || model.Display > 255)
                    errors.Add("Display must be between 0 and 255.");

                if (model.DayUse != 0 && model.DayUse != 1)
                    errors.Add("DayUse must be 0 or 1.");

                if (model.UserID <= 0)
                    errors.Add("UserID is required.");

                if (model.RateClass <= 0)
                    errors.Add("Rate Class is required.");


                if (model.RateCategory <= 0)
                    errors.Add("Rate Category is required.");



                // Validate business date availability early
                List<BusinessDateModel> businessDates = PropertyUtils.ConvertToList<BusinessDateModel>(BusinessDateBO.Instance.FindAll());

                // Check duplicate RateCode (case-insensitive) for insert/update
                var allRateCodes = PropertyUtils.ConvertToList<RateCodeModel>(RateCodeBO.Instance.FindAll()) ?? new List<RateCodeModel>();
                if (!string.IsNullOrWhiteSpace(model.RateCode))
                {
                    bool duplicate = allRateCodes.Any(r => string.Equals(r.RateCode?.Trim(), model.RateCode.Trim(), StringComparison.OrdinalIgnoreCase) && r.ID != model.Id);
                    if (duplicate)
                        errors.Add("RateCode already exists.");
                }
                // If there are validation errors, return them
                if (errors.Any())
                {
                    return BadRequest(new { success = false, message = "Validation failed.", errors });
                }

                // Prepare entity (for update try to fetch existing)
                RateCodeModel entity;
                if (model.Id > 0)
                {
                    var existing = RateCodeBO.Instance.FindByPrimaryKey(model.Id) as RateCodeModel;
                    if (existing == null || existing.ID == 0)
                    {
                        return NotFound(new { success = false, message = $"RateCode not found (ID = {model.Id})" });
                    }
                    entity = existing;
                }
                else
                {
                    entity = new RateCodeModel();
                }

                // Map properties from DTO to entity
                entity.RateCode = model.RateCode?.Trim() ?? string.Empty;
                entity.Descripton = model.Description ?? string.Empty;
                entity.RateCategoryID = model.RateCategory;
                entity.RateClassID = model.RateClass;
                entity.Sequence = model.Sequence;
                entity.DefaultDisplay = (byte)Math.Clamp(model.Display, 0, 255);
                entity.DayUse = model.DayUse == 1;
                entity.Status = model.Active;
                entity.Negotiated = model.Negotiated;
                entity.IndividualOnly = model.IndividualOnly;
                entity.IsModify = model.IsModifiable;

                // Insert or Update with timestamps
                var businessDate = businessDates![0].BusinessDate;

                if (model.Id > 0)
                {
                    entity.UserUpdateID = model.UserID;
                    entity.UpdateDate = businessDate;
                    RateCodeBO.Instance.Update(entity);
                }
                else
                {
                    entity.UserUpdateID = model.UserID;
                    entity.CreateDate = businessDate;
                    entity.UpdateDate = entity.CreateDate;
                    RateCodeBO.Instance.Insert(entity);
                }

                return Json(new { success = true, message = "Success", data = new { id = entity.ID } });
            }
            catch (Exception ex)
            {
                return BadRequest(new { success = false, message = ex.Message });
            }
        }

        [HttpPost("RateCodeDelete")]
        public IActionResult RateCodeDelete(int id)
        {
            try
            {
                if (RateCodeBO.Instance.FindByPrimaryKey(id) is not RateCodeModel existing || existing.ID == 0)
                {
                    return NotFound(new { success = false, message = $"RateCode ID {id} not found." });
                }

                RateCodeBO.Instance.Delete(id);
                return Json(new { success = true, message = $"Successfully deleted RateCode ID {id}." });
            }
            catch (Exception ex)
            {
                return BadRequest(new { success = false, message = ex.Message });
            }
        }

        public class RateCodeDto
        {
            public int UserID { get; set; }
            public int Id { get; set; }
            public string RateCode { get; set; } = "";
            public string Description { get; set; } = "";
            public int RateClass { get; set; }
            public int RateCategory { get; set; }
            public int Sequence { get; set; }
            public int Display { get; set; }
            public int DayUse { get; set; }
            public bool Active { get; set; }
            public bool Negotiated { get; set; }
            public bool IndividualOnly { get; set; }
            public bool IsModifiable { get; set; }
        }


    }
}
