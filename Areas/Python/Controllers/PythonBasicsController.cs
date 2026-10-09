using Microsoft.AspNetCore.Mvc;

namespace CIITEdge.Areas.Python.Controllers
{
    [Area("Python")]
    public class PythonBasicsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Variables()
        {
            return View();
        }

        public IActionResult DataTypes()
        {
            return View();
        }

        public IActionResult Operators()
        {
            return View();
        }

        public IActionResult Strings()
        {
            return View();
        }

        public IActionResult InputOutput()
        {
            return View();
        }

        public IActionResult TypeConversion()
        {
            return View();
        }
    }
}