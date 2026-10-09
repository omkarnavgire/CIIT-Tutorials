using Microsoft.AspNetCore.Mvc;

namespace CIITEdge.Areas.SQLServer.Controllers
{
    [Area("SQLServer")]
    public class JoinsController : Controller
    {
        // 1. Joins Introduction
        public IActionResult Index()
        {
            return View();
        }

        // 2. INNER JOIN 
        public IActionResult InnerJoin()
        {
            return View();
        }

        // 3. LEFT JOIN
        public IActionResult LeftJoin()
        {
            return View();
        }

        // 4. RIGHT JOIN
        public IActionResult RightJoin()
        {
            return View();
        }

        // 5. FULL OUTER JOIN
        public IActionResult FullOuterJoin()
        {
            return View();
        }

        // 6. CROSS JOIN
        public IActionResult CrossJoin()
        {
            return View();
        }
    }
}