using Microsoft.AspNetCore.Mvc;

namespace CIITEdge.Areas.SQLServer.Controllers
{
    [Area("SQLServer")]
    public class TransactionsController : Controller
    {
        // 1. Transactions Introduction
        public IActionResult Index()
        {
            return View();
        }

        // 2. COMMIT
        public IActionResult Commit()
        {
            return View();
        }

        // 3. ROLLBACK
        public IActionResult Rollback()
        {
            return View();
        }

        // 4. SAVEPOINT
        public IActionResult Savepoint()
        {
            return View();
        }

        // 5. Transaction with TRY...CATCH
        public IActionResult TransactionTryCatch()
        {
            return View();
        }
    }
}