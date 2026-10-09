using Microsoft.AspNetCore.Mvc;

namespace CIITEdge.Areas.SQLServer.Controllers
{
    [Area("SQLServer")]
    public class SQLBasicsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SQLCommands()
        {
            return View();
        }

        public IActionResult SQLCommandCategories()
        {
            return View();
        }

        public IActionResult SelectStatement()
        {
            return View();
        }

        public IActionResult InsertUpdateDelete()
        {
            return View();
        }
    }
}