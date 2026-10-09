using Microsoft.AspNetCore.Mvc;

namespace CIITEdge.Areas.SQLServer.Controllers
{
    [Area("SQLServer")]
    public class IntroductionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Installation()
        {
            return View();
        }

        public IActionResult Fundamentals()
        {
            return View();
        }
    }
}