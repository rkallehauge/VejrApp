using Microsoft.AspNetCore.Mvc;

namespace VejrApp.Controllers
{
    public class ApiController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
