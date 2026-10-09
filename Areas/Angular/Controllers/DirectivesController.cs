using Microsoft.AspNetCore.Mvc;

namespace CIITEdge.Areas.Angular.Controllers
{
    [Area("Angular")]
    public class DirectivesController : Controller
    {
        // 1. Directives Introduction
        // What are Directives, Types of Directives
        public IActionResult Index()
        {
            return View();
        }

        // 2. Attribute Directives
        // ngClass, ngStyle and custom attribute directives
        public IActionResult AttributeDirectives()
        {
            return View();
        }

        // 3. Structural Directives
        // *ngIf, *ngFor, *ngSwitch and structural concepts
        public IActionResult StructuralDirectives()
        {
            return View();
        }

        // 4. Custom Directives
        // Creating and using custom directives
        public IActionResult CustomDirectives()
        {
            return View();
        }
    }
}