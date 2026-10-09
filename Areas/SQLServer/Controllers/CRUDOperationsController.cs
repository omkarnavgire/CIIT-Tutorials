using Microsoft.AspNetCore.Mvc;

namespace CIITEdge.Areas.SQLServer.Controllers
{
    [Area("SQLServer")]
    public class CRUDOperationsController : Controller
    {
        // 1. CRUD Operations Introduction
        public IActionResult Index()
        {
            return View();
        }

        // 2. INSERT Operation
        public IActionResult InsertOperation()
        {
            return View();
        }

        // 3. SELECT Operation
        public IActionResult SelectOperation()
        {
            return View();
        }

        // 4. UPDATE Operation
        public IActionResult UpdateOperation()
        {
            return View();
        }

        // 5. DELETE Operation
        public IActionResult DeleteOperation()
        {
            return View();
        }
    }
}