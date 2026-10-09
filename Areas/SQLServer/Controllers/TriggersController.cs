using Microsoft.AspNetCore.Mvc;

namespace CIITEdge.Areas.SQLServer.Controllers
{
    [Area("SQLServer")]
    public class TriggersController : Controller
    {
        // 1. Triggers Introduction
        public IActionResult Index()
        {
            return View();
        }

        // 2. AFTER INSERT Trigger
        public IActionResult AfterInsertTrigger()
        {
            return View();
        }

        // 3. AFTER UPDATE Trigger
        public IActionResult AfterUpdateTrigger()
        {
            return View();
        }

        // 4. AFTER DELETE Trigger
        public IActionResult AfterDeleteTrigger()
        {
            return View();
        }

        // 5. INSTEAD OF Trigger
        public IActionResult InsteadOfTrigger()
        {
            return View();
        }
    }
}