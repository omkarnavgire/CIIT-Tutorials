using Microsoft.AspNetCore.Mvc;

namespace CIITEdge.Areas.Python.Controllers
{
    [Area("Python")]
    public class DataStructuresController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Lists()
        {
            return View();
        }

        public IActionResult Tuples()
        {
            return View();
        }

        public IActionResult Sets()
        {
            return View();
        }

        public IActionResult Dictionaries()
        {
            return View();
        }

        public IActionResult Comprehensions()
        {
            return View();
        }
    }
}