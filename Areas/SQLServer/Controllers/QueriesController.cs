using Microsoft.AspNetCore.Mvc;

namespace CIITEdge.Areas.SQLServer.Controllers
{
    [Area("SQLServer")]
    public class QueriesController : Controller
    {
        // 1. Queries Introduction
        public IActionResult Index()
        {
            return View();
        }

        // 2. WHERE Clause
        public IActionResult WhereClause()
        {
            return View();
        }

        // 3. ORDER BY Clause
        public IActionResult OrderByClause()
        {
            return View();
        }

        // 4. DISTINCT
        public IActionResult Distinct()
        {
            return View();
        }

        // 5. LIKE Operator
        public IActionResult LikeOperator()
        {
            return View();
        }

        // 6. IN, BETWEEN & IS NULL
        public IActionResult InBetweenIsNull()
        {
            return View();
        }
    }
}