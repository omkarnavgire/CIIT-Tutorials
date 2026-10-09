using Microsoft.AspNetCore.Mvc;

namespace CIITEdge.Areas.SQLServer.Controllers
{
    [Area("SQLServer")]
    public class IndexesController : Controller
    {
        // 1. Indexes Introduction
        public IActionResult Index()
        {
            return View();
        }

        // 2. Clustered Index
        public IActionResult ClusteredIndex()
        {
            return View();
        }

        // 3. Non-Clustered Index
        public IActionResult NonClusteredIndex()
        {
            return View();
        }

        // 4. Creating & Dropping Indexes
        public IActionResult CreateDropIndexes()
        {
            return View();
        }

        // 5. Index Performance
        public IActionResult IndexPerformance()
        {
            return View();
        }
    }
}