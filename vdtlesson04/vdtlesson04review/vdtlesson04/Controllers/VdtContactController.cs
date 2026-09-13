using Microsoft.AspNetCore.Mvc;

namespace vdtlesson04.Controllers
{
    public class VdtContactController : Controller
    {
        public IActionResult Index()
        {
            ViewData["hoten"] = "vu duy tuan";
            ViewBag.age = "20++";
            TempData["email"] = "vuduytuan25042006@gmail.com";
            return View();
        }
    }
}
