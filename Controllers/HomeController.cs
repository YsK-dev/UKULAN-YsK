using Microsoft.AspNetCore.Mvc;

namespace UKULAN_YsK.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
