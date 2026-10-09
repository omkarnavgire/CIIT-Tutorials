using Microsoft.AspNetCore.Mvc;

namespace CIITEdge.Areas.SQLServer.Controllers
{
    [Area("SQLServer")]
    public class AdvancedSQLController : Controller
    {
        // 1. Advanced SQL Introduction
        public IActionResult Index()
        {
            return View();
        }

        // 2. Temporary Tables
        public IActionResult TemporaryTables()
        {
            return View();
        }

        // 3. Table Variables
        public IActionResult TableVariables()
        {
            return View();
        }

        // 4. Dynamic SQL
        public IActionResult DynamicSQL()
        {
            return View();
        }

        // 5. Error Handling
        public IActionResult ErrorHandling()
        {
            return View();
        }

        // 6. Performance Optimization
        public IActionResult PerformanceOptimization()
        {
            return View();
        }
    }
}