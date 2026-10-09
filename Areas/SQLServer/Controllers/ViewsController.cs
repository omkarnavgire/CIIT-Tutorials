using Microsoft.AspNetCore.Mvc;

namespace CIITEdge.Areas.SQLServer.Controllers
{
    [Area("SQLServer")]
    public class ViewsController : Controller
    {
        // 1. SQL Views Introduction
        public IActionResult Index()
        {
            return View();
        }

        // 2. Creating a View
        public IActionResult CreatingView()
        {
            return View();
        }

        // 3. Updating a View
        public IActionResult UpdatingView()
        {
            return View();
        }

        // 4. Altering a View
        public IActionResult AlteringView()
        {
            return View();
        }

        // 5. Dropping a View
        public IActionResult DroppingView()
        {
            return View();
        }
    }
}