using Microsoft.AspNetCore.Mvc;

namespace CIITEdge.Areas.SQLServer.Controllers
{
    [Area("SQLServer")]
    public class WindowFunctionsController : Controller
    {
        // 1. Window Functions Introduction
        public IActionResult Index()
        {
            return View();
        }

        // 2. ROW_NUMBER()
        public IActionResult RowNumber()
        {
            return View();
        }

        // 3. RANK() and DENSE_RANK()
        public IActionResult RankDenseRank()
        {
            return View();
        }

        // 4. LEAD() and LAG()
        public IActionResult LeadLag()
        {
            return View();
        }

        // 5. PARTITION BY
        public IActionResult PartitionBy()
        {
            return View();
        }
    }
}