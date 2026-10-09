using Microsoft.AspNetCore.Mvc;

namespace CIITEdge.Areas.Python.Controllers
{
    [Area("Python")]
    public class ControlFlowController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ConditionalStatements()
        {
            return View();
        }

        public IActionResult ForLoop()
        {
            return View();
        }

        public IActionResult WhileLoop()
        {
            return View();
        }

        public IActionResult BreakContinuePass()
        {
            return View();
        }
    }
}