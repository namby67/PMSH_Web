using Microsoft.AspNetCore.Mvc;

namespace Reservation.Controllers
{
    [Route("/Reservation/Allotment")]
    public class AllotmentController : Controller
    {
        [HttpGet("AllotmentType")]
        public IActionResult AllotmentType()
        {
            return View("~/Views/Reservation/Allotment/AllotmentType.cshtml");
        }

        // [HttpGet("GetAllRateClass")]
        // public async Task<IActionResult> RateClassGetAll(string? code, string? name, int inactive = 0)
        // {
        //     try
        //     {
        //         DataTable dataTable = await _svRateClass.RateClassTypeData(code, name, inactive);
        //         var result = (from d in dataTable.AsEnumerable()
        //                       select new
        //                       {
        //                           ID = d["ID"]?.ToString() ?? "",
        //                           Code = d["Code"]?.ToString() ?? "",
        //                           Name = d["Name"]?.ToString() ?? "",
        //                           Description = d["Description"]?.ToString() ?? "",
        //                           CreatedDate = d["CreatedDate"] != DBNull.Value ? Convert.ToDateTime(d["CreatedDate"]) : (DateTime?)null,
        //                           UpdatedDate = d["UpdatedDate"] != DBNull.Value ? Convert.ToDateTime(d["UpdatedDate"]) : (DateTime?)null,
        //                           CreatedBy = d["CreatedBy"]?.ToString() ?? "",
        //                           UpdatedBy = d["UpdatedBy"]?.ToString() ?? "",
        //                           Inactive = d["Inactive"] != DBNull.Value ? Convert.ToInt32(d["Inactive"]) : 0,

        //                       }).ToList();
        //         return Json(new
        //         {
        //             totalCount = result.Count, // 🔥 số bản ghi
        //             data = result
        //         });
        //     }
        //     catch (Exception ex)
        //     {
        //         return BadRequest(new { success = false, message = ex.Message });
        //     }
        // }


    }
}
