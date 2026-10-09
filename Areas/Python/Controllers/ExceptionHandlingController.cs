using Microsoft.AspNetCore.Mvc;

namespace CIITEdge.Areas.Python.Controllers
{
    [Area("Python")]
    public class ExceptionHandlingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult TryExcept()
        {
            return View();
        }

        public IActionResult MultipleExceptions()
        {
            return View();
        }

        public IActionResult Finally()
        {
            return View();
        }

        public IActionResult RaiseException()
        {
            return View();
        }

        public IActionResult CustomExceptions()
        {
            return View();
        }
    }
}