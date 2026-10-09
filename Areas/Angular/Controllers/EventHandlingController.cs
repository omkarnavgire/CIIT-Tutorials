using Microsoft.AspNetCore.Mvc;

namespace CIITEdge.Areas.Angular.Controllers
{
    [Area("Angular")]
    public class EventHandlingController : Controller
    {
        // 1. Event Handling Introduction
        // What is Event Handling and how Angular handles DOM events
        public IActionResult Index()
        {
            return View();
        }

        // 2. DOM Events
        // click, input, change, submit, keyup, mouse events, etc.
        public IActionResult DOMEvents()
        {
            return View();
        }

        // 3. Event Binding Syntax
        // (click), (input), (change), (keyup), etc.
        public IActionResult EventBinding()
        {
            return View();
        }

        // 4. Event Object
        // $event and accessing event information
        public IActionResult EventObject()
        {
            return View();
        }

        // 5. Passing Data to Event Handlers
        // Passing values and parameters from template to component
        public IActionResult PassingData()
        {
            return View();
        }
    }
}