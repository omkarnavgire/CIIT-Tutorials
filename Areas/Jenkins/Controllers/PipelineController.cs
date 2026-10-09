using Microsoft.AspNetCore.Mvc;

namespace CIITEdge.Areas.Jenkins.Controllers
{
    [Area("Jenkins")]
    public class PipelineController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult DeclarativeVsScripted()
        {
            return View();
        }


        public IActionResult PipelineAnatomy()
        {
            return View();
        }


        public IActionResult AgentDirective()
        {
            return View();
        }


        public IActionResult StagesAndSteps()
        {
            return View();
        }


        public IActionResult EnvironmentVariables()
        {
            return View();
        }


        public IActionResult Parameters()
        {
            return View();
        }


        public IActionResult WhenDirective()
        {
            return View();
        }


        public IActionResult ParallelExecution()
        {
            return View();
        }


        public IActionResult PostBlock()
        {
            return View();
        }


        public IActionResult Multibranch()
        {
            return View();
        }


        public IActionResult Webhooks()
        {
            return View();
        }
    }
}
