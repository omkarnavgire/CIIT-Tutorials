using Microsoft.AspNetCore.Mvc;

namespace CIITEdge.Areas.Azure.Controllers;

[Area("Azure")]
public class AppServiceController : Controller
{
    public IActionResult AppServicePlan() => View();
    public IActionResult CreateAppServicePlan() => View();
    public IActionResult CreateWebApp() => View();
    public IActionResult DeployStaticWebApp() => View();
    public IActionResult UsingGithubActionInAzureAppService() => View();
}
