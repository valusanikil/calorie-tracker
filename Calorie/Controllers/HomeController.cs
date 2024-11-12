using Microsoft.AspNetCore.Mvc;

namespace Calorie.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CalorieTracker()
        {
            return View();
        }

        public IActionResult Chart()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Recipe()
        {
            return Recipe();
        }

    }
}
