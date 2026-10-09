using Microsoft.AspNetCore.Mvc;

namespace CIITEdge.Areas.Jenkins.Controllers
{
    [Area("Jenkins")]
    public class CoreCICDController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult FirstJob()
        {
            return View();
        }


        public IActionResult SourceControl()
        {
            return View();
        }


        public IActionResult BuildSteps()
        {
            return View();
        }


        public IActionResult BuildTriggers()
        {
            return View();
        }


        public IActionResult ParameterizedBuilds()
        {
            return View();
        }


        public IActionResult GlobalTools()
        {
            return View();
        }


        public IActionResult Workspaces()
        {
            return View();
        }


        public IActionResult Artifacts()
        {
            return View();
        }


        public IActionResult UpstreamDownstream()
        {
            return View();
        }


        public IActionResult BuildHistory()
        {
            return View();
        }
    }
}
