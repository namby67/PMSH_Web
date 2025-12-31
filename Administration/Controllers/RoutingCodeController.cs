using BaseBusiness.BO;
using BaseBusiness.Model;
using BaseBusiness.util;
using Microsoft.AspNetCore.Mvc;

namespace Administration.Controllers
{
    [Route("/Administration/RoutingCode")]
    public class RoutingCodeController : Controller
    {
        public RoutingCodeController()
        {
        }

        [HttpGet("")]
        public IActionResult RoutingCode()
        {
            return View("~/Views/Administration/RoutingCode.cshtml");
            // Truyền đường dẫn chuẩn vào để tìm đúng
        }
        [HttpGet("GetAllRoutingCode")]
        public IActionResult GetAllRoutingCode()
        {
            try
            {
                var list = PropertyUtils.ConvertToList<RoutingCodeModel>(
                RoutingCodeBO.Instance.FindAll());

                return Json(new
                {
                    success = true,
                    message = "Success",
                    data = list
                });
            }
            catch (Exception ex)
            {

                return Json(new
                {
                    success = false,
                    message = "Error: " + ex.Message
                });
            }
        }
    }
}
