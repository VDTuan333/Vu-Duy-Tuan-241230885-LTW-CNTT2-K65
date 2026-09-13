using Microsoft.AspNetCore.Mvc;

namespace vdtlesson04View.Controllers
{
    public class VdtRazorCodeController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }
    }
}
