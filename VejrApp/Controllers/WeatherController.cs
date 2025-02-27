using Microsoft.AspNetCore.Mvc;

namespace VejrApp.Controllers
{
    public class WeatherController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
