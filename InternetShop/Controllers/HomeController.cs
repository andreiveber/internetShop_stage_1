using Microsoft.AspNetCore.Mvc;

namespace InternetShop.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Products()
        {
            return View();
        }
    }
}
