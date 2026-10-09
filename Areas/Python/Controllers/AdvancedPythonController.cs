using Microsoft.AspNetCore.Mvc;

namespace CIITEdge.Areas.Python.Controllers
{
    [Area("Python")]
    public class AdvancedPythonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Iterators()
        {
            return View();
        }

        public IActionResult Generators()
        {
            return View();
        }

        public IActionResult Decorators()
        {
            return View();
        }

        public IActionResult ContextManagers()
        {
            return View();
        }

        public IActionResult RegularExpressions()
        {
            return View();
        }
    }
}