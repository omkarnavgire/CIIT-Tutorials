using Microsoft.AspNetCore.Mvc;

namespace CIITEdge.Areas.Angular.Controllers
{
    [Area("Angular")]
    public class IntroductionController : Controller
    {
        // 1. Angular Introduction
        public IActionResult Index()
        {
            return View();
        }

        // 2. Angular History
        public IActionResult History()
        {
            return View();
        }

        // 3. Angular Fundamentals
        public IActionResult Fundamentals()
        {
            return View();
        }

        // 4. Angular Architecture
        public IActionResult Architecture()
        {
            return View();
        }

        // 5. Component-Based Angular
        public IActionResult ComponentBasedAngular()
        {
            return View();
        }
    }
}
