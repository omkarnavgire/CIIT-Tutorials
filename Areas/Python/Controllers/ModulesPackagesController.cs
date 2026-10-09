using Microsoft.AspNetCore.Mvc;

namespace CIITEdge.Areas.Python.Controllers
{
    [Area("Python")]
    public class ModulesPackagesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Modules()
        {
            return View();
        }

        public IActionResult ImportStatement()
        {
            return View();
        }

        public IActionResult BuiltInModules()
        {
            return View();
        }

        public IActionResult CreatingPackages()
        {
            return View();
        }

        public IActionResult PipPackages()
        {
            return View();
        }

        public IActionResult VirtualEnvironments()
        {
            return View();
        }
    }
}