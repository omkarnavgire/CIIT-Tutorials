using Microsoft.AspNetCore.Mvc;
using CIITEdge.Areas.Azure.Models;
using CIITEdge.Areas.Azure;

namespace CIITEdge.Areas.Azure.Controllers;

[Area("Azure")]
public class ArchitectureController : Controller
{
    public IActionResult AzureWellArchitectedFramework() => Lesson("Azure Well-Architected Framework", "AzureWellArchitectedFramework", 1);
    public IActionResult Reliability() => Lesson("Reliability", "Reliability", 2);
    public IActionResult ArchitectureHighAvailability() => Lesson("High Availability Design", "ArchitectureHighAvailability", 3);
    public IActionResult DisasterRecovery() => Lesson("Disaster Recovery", "DisasterRecovery", 4);
    public IActionResult CostOptimizationPractical() => Lesson("Cost Optimization Practical", "CostOptimizationPractical", 5);

    private IActionResult Lesson(string title, string action, int number)
    {
        var module = AzureLessonCatalog.GetModule("Architecture");
        var lesson = new AzureLesson
        {
            ModuleKey = "Architecture",
            ModuleTitle = module.Title,
            Title = title,
            Controller = "Architecture",
            Action = action,
            Number = number,
            Total = module.Topics.Count,
            Topic = AzureLessonCatalog.GetTopic("Architecture", action)
        };
        return View("Lesson", lesson);
    }
}
