using Microsoft.AspNetCore.Mvc;

namespace CIITEdge.Areas.Angular.Controllers
{
    [Area("Angular")]
    public class PipesController : Controller
    {
        // 1. Pipes Introduction
        // What are Pipes, Pipe Syntax and Purpose
        public IActionResult Index()
        {
            return View();
        }

        // 2. Built-in Pipes
        // Date, UpperCase, LowerCase, Currency, Number, Percent
        public IActionResult BuiltInPipes()
        {
            return View();
        }

        // 3. Parameterized Pipes
        // Passing parameters to pipes
        public IActionResult ParameterizedPipes()
        {
            return View();
        }

        // 4. Chaining Pipes
        // Using multiple pipes together
        public IActionResult ChainingPipes()
        {
            return View();
        }

        // 5. Custom Pipes
        // Creating and using custom pipes
        public IActionResult CustomPipes()
        {
            return View();
        }
    }
}