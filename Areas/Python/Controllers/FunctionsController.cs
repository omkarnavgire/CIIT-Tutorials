using Microsoft.AspNetCore.Mvc;

namespace CIITEdge.Areas.Python.Controllers
{
    [Area("Python")]
    public class FunctionsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult DefiningCallingFunctions()
        {
            return View();
        }

        public IActionResult ParametersArguments()
        {
            return View();
        }

        public IActionResult ReturnValues()
        {
            return View();
        }

        public IActionResult Scope()
        {
            return View();
        }

        public IActionResult Recursion()
        {
            return View();
        }

        public IActionResult LambdaFunctions()
        {
            return View();
        }
    }
}