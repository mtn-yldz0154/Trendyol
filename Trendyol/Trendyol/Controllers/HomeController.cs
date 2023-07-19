using Microsoft.AspNetCore.Mvc;

namespace Trendyol.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
