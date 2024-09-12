using Microsoft.AspNetCore.Mvc;

namespace Environments.Controllers
{
    public class HomeController : Controller
    {
        Route("/")
        public IActionResult Index()
        {
            return View();
        }
    }
}
