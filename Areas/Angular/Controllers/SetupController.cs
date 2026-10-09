using Microsoft.AspNetCore.Mvc;

namespace CIITEdge.Areas.Angular.Controllers
{
    [Area("Angular")]
    public class SetupController : Controller
    {
        // 1. Angular Setup Introduction
        public IActionResult Index()
        {
            return View();
        }

        // 2. Node.js
        public IActionResult NodeJS()
        {
            return View();
        }

        // 3. Installing Node.js
        public IActionResult InstallingNodeJS()
        {
            return View();
        }

        // 4. Installing Angular CLI
        public IActionResult AngularCLI()
        {
            return View();
        }

        // 5. Creating Angular Application
        public IActionResult CreatingApplication()
        {
            return View();
        }

        // 6. Angular Project Structure
        public IActionResult ProjectStructure()
        {
            return View();
        }
    }
}