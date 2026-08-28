using Microsoft.AspNetCore.Mvc;

namespace vdtLesson03.Controllers
{
    /// <summary>
    /// Name:VdtAbout
    /// Author: Dut Tuan
    /// </summary>
    public class VdtAboutController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.name = "vu duy tuan";
            ViewData["class"]="K65CNT2-LTW";
            TempData["module"] = "lap trinh web 1-1";
            return View();
        }
    }
}
