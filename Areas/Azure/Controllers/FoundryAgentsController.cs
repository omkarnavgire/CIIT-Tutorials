using Microsoft.AspNetCore.Mvc;
using CIITEdge.Areas.Azure.Models;
using CIITEdge.Areas.Azure;

namespace CIITEdge.Areas.Azure.Controllers;

[Area("Azure")]
public class FoundryAgentsController : Controller
{
    public IActionResult WhatisMicrosoftFoundry() => Lesson("What is Microsoft Foundry?", "WhatisMicrosoftFoundry", 1);
    public IActionResult WhatisanAIAgent() => Lesson("What is an AI Agent?", "WhatisanAIAgent", 2);
    public IActionResult CreateFirstAgent() => Lesson("Create First Agent", "CreateFirstAgent", 3);
    public IActionResult AgentPlayground() => Lesson("Agent Playground", "AgentPlayground", 4);
    public IActionResult PracticalEmployeeSupportAIAgent() => Lesson("Practical — Employee Support AI Agent", "PracticalEmployeeSupportAIAgent", 5);

    private IActionResult Lesson(string title, string action, int number)
    {
        var module = AzureLessonCatalog.GetModule("FoundryAgents");
        var lesson = new AzureLesson
        {
            ModuleKey = "FoundryAgents",
            ModuleTitle = module.Title,
            Title = title,
            Controller = "FoundryAgents",
            Action = action,
            Number = number,
            Total = module.Topics.Count,
            Topic = AzureLessonCatalog.GetTopic("FoundryAgents", action)
        };
        return View("Lesson", lesson);
    }
}
