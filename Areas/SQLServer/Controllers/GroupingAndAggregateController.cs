using Microsoft.AspNetCore.Mvc;

namespace CIITEdge.Areas.SQLServer.Controllers
{
    [Area("SQLServer")]
    public class GroupingAndAggregateController : Controller
    {
        // 1. GROUP BY
        public IActionResult Index()
        {
            return View();
        }

        // 2. Aggregate Functions
        public IActionResult AggregateFunctions()
        {
            return View();
        }

        // 3. COUNT()
        public IActionResult CountFunction()
        {
            return View();
        }

        // 4. SUM()
        public IActionResult SumFunction()
        {
            return View();
        }

        // 5. AVG()
        public IActionResult AvgFunction()
        {
            return View();
        }

        // 6. MIN() & MAX()
        public IActionResult MinMaxFunctions()
        {
            return View();
        }
    }
}