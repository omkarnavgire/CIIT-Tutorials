using Microsoft.AspNetCore.Mvc;

namespace CIITEdge.Areas.Python.Controllers
{
    [Area("Python")]
    public class FileHandlingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ReadingFiles()
        {
            return View();
        }

        public IActionResult WritingFiles()
        {
            return View();
        }

        public IActionResult FileDirectories()
        {
            return View();
        }

        public IActionResult CSVFiles()
        {
            return View();
        }

        public IActionResult JSONFiles()
        {
            return View();
        }
    }
}