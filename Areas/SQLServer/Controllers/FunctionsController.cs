using Microsoft.AspNetCore.Mvc;

namespace CIITEdge.Areas.SQLServer.Controllers
{
    [Area("SQLServer")]
    public class FunctionsController : Controller
    {
        // 1. SQL Functions Introduction
        public IActionResult Index()
        {
            return View();
        }

        // 2. String Functions
        public IActionResult StringFunctions()
        {
            return View();
        }

        // 3. Numeric Functions
        public IActionResult NumericFunctions()
        {
            return View();
        }

        // 4. Date & Time Functions
        public IActionResult DateTimeFunctions()
        {
            return View();
        }

        // 5. Conversion Functions
        public IActionResult ConversionFunctions()
        {
            return View();
        }

        // 6. NULL Functions
        public IActionResult NullFunctions()
        {
            return View();
        }
    }
}