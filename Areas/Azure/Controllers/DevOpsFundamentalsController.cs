using Microsoft.AspNetCore.Mvc;

namespace CIITEdge.Areas.Azure.Controllers;

[Area("Azure")]
public class DevOpsFundamentalsController : Controller
{
    public IActionResult AzureDevOps() => View();
    public IActionResult WhatIsDevOps() => View();
    public IActionResult BenefitsOfDevOps() => View();
    public IActionResult WhatIsAzureDevOps() => View();
    public IActionResult ServicesUsedInAzureDevOps() => View();
    public IActionResult CreateAzureDevOpsProject() => View();
    public IActionResult AzureDevOpsUsersAndUseCases() => View();
    public IActionResult AzureDevOpsBenefits() => View();
    public IActionResult AzureDevOpsDrawbacks() => View();
    public IActionResult AzureDevOpsVsDevOps() => View();
    public IActionResult AzureDevOpsCertification() => View();
    public IActionResult AzureBoards() => View();
}
