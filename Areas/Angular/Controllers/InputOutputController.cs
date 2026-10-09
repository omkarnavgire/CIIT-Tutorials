using Microsoft.AspNetCore.Mvc;

namespace CIITEdge.Areas.Angular.Controllers
{
    [Area("Angular")]
    public class InputOutputController : Controller
    {
        // 1. Component Communication Introduction
        // Parent and Child Component communication
        public IActionResult Index()
        {
            return View();
        }

        // 2. @Input Decorator
        // Passing data from Parent Component to Child Component
        public IActionResult Input()
        {
            return View();
        }

        // 3. @Output Decorator
        // Sending data from Child Component to Parent Component
        public IActionResult Output()
        {
            return View();
        }

        // 4. EventEmitter
        // Emitting events and sending data to Parent Component
        public IActionResult EventEmitter()
        {
            return View();
        }

        // 5. Input and Output Communication
        // Complete Parent-Child communication example
        public IActionResult InputOutputCommunication()
        {
            return View();
        }
    }
}