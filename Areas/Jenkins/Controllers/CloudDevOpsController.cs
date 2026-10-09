using Microsoft.AspNetCore.Mvc;

namespace CIITEdge.Areas.Jenkins.Controllers
{
    [Area("Jenkins")]
    public class CloudDevOpsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult GitHubIntegration()
        {
            return View();
        }


        public IActionResult DockerBuild()
        {
            return View();
        }


        public IActionResult DockerRegistry()
        {
            return View();
        }


        public IActionResult Aws()
        {
            return View();
        }


        public IActionResult Ec2Deployment()
        {
            return View();
        }


        public IActionResult S3Artifacts()
        {
            return View();
        }


        public IActionResult KubernetesAgents()
        {
            return View();
        }


        public IActionResult KubernetesDeployment()
        {
            return View();
        }


        public IActionResult GitOps()
        {
            return View();
        }


        public IActionResult ExternalIntegrations()
        {
            return View();
        }
    }
}
