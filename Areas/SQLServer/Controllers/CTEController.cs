using Microsoft.AspNetCore.Mvc;

namespace CIITEdge.Areas.SQLServer.Controllers
{
    [Area("SQLServer")]
    public class CTEController : Controller
    {
        // 1. CTE Introduction
        public IActionResult Index()
        {
            return View();
        }

        // 2. Simple CTE
        public IActionResult SimpleCTE()
        {
            return View();
        }

        // 3. CTE with JOIN
        public IActionResult CTEWithJoin()
        {
            return View();
        }

        // 4. CTE with Aggregate Functions
        public IActionResult CTEWithAggregate()
        {
            return View();
        }

        // 5. Recursive CTE
        public IActionResult RecursiveCTE()
        {
            return View();
        }
    }
}