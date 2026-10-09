using Microsoft.AspNetCore.Mvc;

namespace CIITEdge.Areas.Python.Controllers
{
    [Area("Python")]
    public class WebDevelopmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult FlaskBasics()
        {
            return View();
        }

        public IActionResult FastAPIBasics()

        {
            return View();
        }

        public IActionResult WebRoutes()
        {
            return View();
        }

        public IActionResult RESTAPIs()
        {
            return View();
        }

        public IActionResult APIRequests()
        {
            return View();
        }
    }
}