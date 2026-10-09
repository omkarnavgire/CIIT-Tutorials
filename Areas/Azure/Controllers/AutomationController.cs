using Microsoft.AspNetCore.Mvc;
using CIITEdge.Areas.Azure.Models;
using CIITEdge.Areas.Azure;

namespace CIITEdge.Areas.Azure.Controllers;

[Area("Azure")]
public class AutomationController : Controller
{
    public IActionResult AzureCLIAndCloudShell() => Lesson("Azure CLI and Cloud Shell", "AzureCLIAndCloudShell", 1);
    public IActionResult PowerShellAndAzureResourceManagement() => Lesson("PowerShell and Azure Resource Management", "PowerShellAndAzureResourceManagement", 2);
    public IActionResult BicepAndDeclarativeInfrastructure() => Lesson("Bicep and Declarative Infrastructure", "BicepAndDeclarativeInfrastructure", 3);
    public IActionResult Lab36ProvisionAResourceGroupAndVNetWithCLI() => Lesson("Lab 36 — Provision a Resource Group and VNet with CLI", "Lab36ProvisionAResourceGroupAndVNetWithCLI", 4);
    public IActionResult Lab37DeployAzureResourcesWithBicep() => Lesson("Lab 37 — Deploy Azure Resources with Bicep", "Lab37DeployAzureResourcesWithBicep", 5);
    public IActionResult Lab38ValidatePreviewAndRollBackAnIaCChange() => Lesson("Lab 38 — Validate, Preview and Roll Back an IaC Change", "Lab38ValidatePreviewAndRollBackAnIaCChange", 6);

    private IActionResult Lesson(string title, string action, int number)
    {
        var module = AzureLessonCatalog.GetModule("Automation");
        var topic = module.Topics[number - 1];
        var lesson = new AzureLesson
        {
            ModuleKey = "Automation",
            ModuleTitle = "Azure CLI, PowerShell & Infrastructure as Code",
            Title = title,
            Controller = "Automation",
            Action = action,
            Number = number,
            Total = module.Topics.Count,
            Kind = topic.Kind.ToString()
        };
        return View("Lesson", lesson);
    }
}