using Microsoft.AspNetCore.Mvc;

namespace Environments.Controllers
{
    public class HomeController : Controller
    {
        [Route("/some-route")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("/some-route")]
        public IActionResult Other()
        {
            return View();
        }
    }
}
