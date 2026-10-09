using Microsoft.AspNetCore.Mvc;
using CIITEdge.Areas.Azure.Models;
using CIITEdge.Areas.Azure;

namespace CIITEdge.Areas.Azure.Controllers;

[Area("Azure")]
public class FinalProjectController : Controller
{
    public IActionResult ProjectArchitecture() => Lesson("Project Architecture", "ProjectArchitecture", 1);
    public IActionResult FinalArchitectureReview() => Lesson("Final Architecture Review", "FinalArchitectureReview", 2);
    public IActionResult DeployBackendVMA() => Lesson("Deploy Backend VM-A", "DeployBackendVMA", 3);
    public IActionResult TestCompleteRequestFlow() => Lesson("Test Complete Request Flow", "TestCompleteRequestFlow", 4);
    public IActionResult FinalEndtoEndTest() => Lesson("Final End-to-End Test", "FinalEndtoEndTest", 5);

    private IActionResult Lesson(string title, string action, int number)
    {
        var module = AzureLessonCatalog.GetModule("FinalProject");
        var lesson = new AzureLesson
        {
            ModuleKey = "FinalProject",
            ModuleTitle = module.Title,
            Title = title,
            Controller = "FinalProject",
            Action = action,
            Number = number,
            Total = module.Topics.Count,
            Topic = AzureLessonCatalog.GetTopic("FinalProject", action)
        };
        return View("Lesson", lesson);
    }
}
