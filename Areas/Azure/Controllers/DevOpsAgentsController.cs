using Microsoft.AspNetCore.Mvc;
using CIITEdge.Areas.Azure.Models;
using CIITEdge.Areas.Azure;

namespace CIITEdge.Areas.Azure.Controllers;

[Area("Azure")]
public class DevOpsAgentsController : Controller
{
    public IActionResult WhatisAzureDevOpsAgent() => Lesson("What is Azure DevOps Agent?", "WhatisAzureDevOpsAgent", 1);
    public IActionResult MicrosofthostedAgent() => Lesson("Microsoft-hosted Agent", "MicrosofthostedAgent", 2);
    public IActionResult InstallAgent() => Lesson("Install Agent", "InstallAgent", 3);
    public IActionResult RunPipelineonLocalPC() => Lesson("Run Pipeline on Local PC", "RunPipelineonLocalPC", 4);
    public IActionResult PracticalLocalPCCICDAgent() => Lesson("Practical — Local PC CI/CD Agent", "PracticalLocalPCCICDAgent", 5);

    private IActionResult Lesson(string title, string action, int number)
    {
        var module = AzureLessonCatalog.GetModule("DevOpsAgents");
        var lesson = new AzureLesson
        {
            ModuleKey = "DevOpsAgents",
            ModuleTitle = module.Title,
            Title = title,
            Controller = "DevOpsAgents",
            Action = action,
            Number = number,
            Total = module.Topics.Count,
            Topic = AzureLessonCatalog.GetTopic("DevOpsAgents", action)
        };
        return View("Lesson", lesson);
    }
}
