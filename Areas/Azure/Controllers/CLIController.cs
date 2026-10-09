using Microsoft.AspNetCore.Mvc;
using CIITEdge.Areas.Azure.Models;
using CIITEdge.Areas.Azure;

namespace CIITEdge.Areas.Azure.Controllers;

[Area("Azure")]
public class CLIController : Controller
{
    public IActionResult AzureCLIIntroduction() => Lesson("Azure CLI Introduction", "AzureCLIIntroduction", 1);
    public IActionResult PowerShellBasics() => Lesson("PowerShell Basics", "PowerShellBasics", 2);
    public IActionResult ResourceGroupsusingCLI() => Lesson("Resource Groups using CLI", "ResourceGroupsusingCLI", 3);
    public IActionResult VMusingCLI() => Lesson("VM using CLI", "VMusingCLI", 4);
    public IActionResult PracticalDeployResourcesUsingCLI() => Lesson("Practical — Deploy Resources Using CLI", "PracticalDeployResourcesUsingCLI", 5);

    private IActionResult Lesson(string title, string action, int number)
    {
        var module = AzureLessonCatalog.GetModule("CLI");
        var lesson = new AzureLesson
        {
            ModuleKey = "CLI",
            ModuleTitle = module.Title,
            Title = title,
            Controller = "CLI",
            Action = action,
            Number = number,
            Total = module.Topics.Count,
            Topic = AzureLessonCatalog.GetTopic("CLI", action)
        };
        return View("Lesson", lesson);
    }
}
