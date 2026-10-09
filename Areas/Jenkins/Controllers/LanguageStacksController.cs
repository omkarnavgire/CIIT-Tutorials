using Microsoft.AspNetCore.Mvc;

namespace CIITEdge.Areas.Jenkins.Controllers
{
    [Area("Jenkins")]
    public class LanguageStacksController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Maven()
        {
            return View();
        }


        public IActionResult SpringBoot()
        {
            return View();
        }


        public IActionResult JUnitReports()
        {
            return View();
        }


        public IActionResult JarWarArtifacts()
        {
            return View();
        }


        public IActionResult NodeReact()
        {
            return View();
        }


        public IActionResult NpmTesting()
        {
            return View();
        }


        public IActionResult Python()
        {
            return View();
        }


        public IActionResult Pytest()
        {
            return View();
        }


        public IActionResult DotNet()
        {
            return View();
        }
    }
}
