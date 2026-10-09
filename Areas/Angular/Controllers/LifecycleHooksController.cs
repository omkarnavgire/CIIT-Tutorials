using Microsoft.AspNetCore.Mvc;

namespace CIITEdge.Areas.Angular.Controllers
{
    [Area("Angular")]
    public class LifecycleHooksController : Controller
    {
        // 1. Lifecycle Hooks Introduction
        // Angular component lifecycle and lifecycle sequence
        public IActionResult Index()
        {
            return View();
        }

        // 2. ngOnInit
        // Component initialization and loading initial data
        public IActionResult OnInit()
        {
            return View();
        }

        // 3. ngOnChanges
        // Detecting changes in @Input properties
        public IActionResult OnChanges()
        {
            return View();
        }

        // 4. ngAfterViewInit
        // Working with initialized component views
        public IActionResult AfterViewInit()
        {
            return View();
        }

        // 5. ngOnDestroy
        // Cleanup before component destruction
        public IActionResult OnDestroy()
        {
            return View();
        }
    }
}