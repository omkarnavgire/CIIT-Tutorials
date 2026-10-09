using Microsoft.AspNetCore.Mvc;

namespace CIITEdge.Areas.Angular.Controllers
{
    [Area("Angular")]
    public class DataBindingController : Controller
    {
        // 1. Data Binding Introduction
        // What is Data Binding, Types of Data Binding
        public IActionResult Index()
        {
            return View();
        }

        // 2. Interpolation Binding
        // {{ expression }}
        public IActionResult Interpolation()
        {
            return View();
        }

        // 3. Property Binding
        // Property Binding + Attribute Binding
        public IActionResult PropertyBinding()
        {
            return View();
        }

        // 4. Event Binding
        // click, input, change, submit, etc.
        public IActionResult EventBinding()
        {
            return View();
        }

        // 5. Two-Way Data Binding
        // [(ngModel)] and data synchronization
        public IActionResult TwoWayBinding()
        {
            return View();
        }

        // 6. Class and Style Binding
        // Class Binding + Style Binding
        public IActionResult ClassAndStyleBinding()
        {
            return View();
        }
    }
}