using Microsoft.AspNetCore.Mvc;

namespace CIITEdge.Areas.SQLServer.Controllers
{
    [Area("SQLServer")]
    public class SubqueriesController : Controller
    {
        // 1. Subqueries Introduction
        public IActionResult Index()
        {
            return View();
        }

        // 2. Single-Row Subquery
        public IActionResult SingleRowSubquery()
        {
            return View();
        }

        // 3. Multiple-Row Subquery
        public IActionResult MultipleRowSubquery()
        {
            return View();
        }

        // 4. Correlated Subquery
        public IActionResult CorrelatedSubquery()
        {
            return View();
        }

        // 5. Subquery with SELECT, INSERT, UPDATE & DELETE
        public IActionResult SubqueryWithDML()
        {
            return View();
        }
    }
}