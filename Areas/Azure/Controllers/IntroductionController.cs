using Microsoft.AspNetCore.Mvc;

namespace CIITEdge.Areas.Azure.Controllers;

[Area("Azure")]
public class IntroductionController : Controller
{
    public IActionResult Index() => WhatisMicrosoftAzure();
    public IActionResult AzureGlobalInfrastructure() => View();
    public IActionResult AzurePortalIntroduction() => View();
    public IActionResult FirstAzureResource() => View();
    public IActionResult WhatisMicrosoftAzure() => View();
    public IActionResult MicrosoftAzureWorking() => View();
    public IActionResult MicrosoftAzureArchitecture() => View();
    public IActionResult ServiceCategories() => View();
    public IActionResult AzureUseCases() => View();
    public IActionResult VariousAzureServices() => View();
    public IActionResult AzureCompetition() => View();
    public IActionResult AzureCloudShell() => View();
    public IActionResult HowToAccessAzureShell() => View();
    public IActionResult AwsGoogleCloudAzureComparison() => View();
}
