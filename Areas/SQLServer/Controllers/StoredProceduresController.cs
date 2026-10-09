using Microsoft.AspNetCore.Mvc;

namespace CIITEdge.Areas.SQLServer.Controllers
{
    [Area("SQLServer")]
    public class StoredProceduresController : Controller
    {
        // 1. Stored Procedures Introduction
        public IActionResult Index()
        {
            return View();
        }

        // 2. Creating a Stored Procedure
        public IActionResult CreatingStoredProcedure()
        {
            return View();
        }

        // 3. Input Parameters
        public IActionResult InputParameters()
        {
            return View();
        }

        // 4. Output Parameters
        public IActionResult OutputParameters()
        {
            return View();
        }

        // 5. Executing & Modifying Stored Procedures
        public IActionResult ExecuteModifyStoredProcedure()
        {
            return View();
        }
    }
}