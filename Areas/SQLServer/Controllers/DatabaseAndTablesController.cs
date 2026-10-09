using Microsoft.AspNetCore.Mvc;

namespace CIITEdge.Areas.SQLServer.Controllers
{
    [Area("SQLServer")]
    public class DatabaseAndTablesController : Controller
    {
        // 1. Database
        public IActionResult Index()
        {
            return View();
        }

        // 2. Creating a Database
        public IActionResult CreatingDatabase()
        {
            return View();
        }

        // 3. Creating Tables
        public IActionResult CreatingTables()
        {
            return View();
        }

        // 4. Table Structure
        public IActionResult TableStructure()
        {
            return View();
        }

        // 5. Altering Tables
        public IActionResult AlteringTables()
        {
            return View();
        }

        // 6. Dropping Tables
        public IActionResult DroppingTables()
        {
            return View();
        }
    }
}