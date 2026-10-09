using Microsoft.AspNetCore.Mvc;

namespace CIITEdge.Areas.Python.Controllers
{
    [Area("Python")]
    public class DatabaseProgrammingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SQLite()
        {
            return View();
        }

        public IActionResult DatabaseConnectivity()
        {
            return View();
        }

        public IActionResult CRUDOperations()
        {
            return View();
        }

        public IActionResult SQLWithPython()
        {
            return View();
        }
    }
}