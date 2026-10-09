using Microsoft.AspNetCore.Mvc;

namespace CIITEdge.Areas.Angular.Controllers
{
    [Area("Angular")]
    public class ComponentsController : Controller
    {
        // 1. Components Overview
        public IActionResult Index()
        {
            return View();
        }

        // 2. Component Anatomy
        public IActionResult ComponentAnatomy()
        {
            return View();
        }

        // 3. Creating Components with Angular CLI
        public IActionResult CreatingComponents()
        {
            return View();
        }

        // 4. Component Selector
        public IActionResult ComponentSelector()
        {
            return View();
        }

        // 5. Component Template
        public IActionResult ComponentTemplate()
        {
            return View();
        }

        // 6. Component Styles
        public IActionResult ComponentStyles()
        {
            return View();
        }

        // 7. Component Metadata
        public IActionResult ComponentMetadata()
        {
            return View();
        }

        // 8. Standalone Components
        public IActionResult StandaloneComponents()
        {
            return View();
        }

        // 9. Parent and Child Components
        public IActionResult ParentChildComponents()
        {
            return View();
        }

        // 10. Reusable Components
        public IActionResult ReusableComponents()
        {
            return View();
        }
    }
}