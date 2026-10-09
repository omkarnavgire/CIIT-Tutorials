using Microsoft.AspNetCore.Mvc;
using CIITEdge.Areas.Azure.Models;
using CIITEdge.Areas.Azure;

namespace CIITEdge.Areas.Azure.Controllers;

[Area("Azure")]
public class IaCController : Controller
{
    public IActionResult WhatisInfrastructureasCode() => Lesson("What is Infrastructure as Code?", "WhatisInfrastructureasCode", 1);
    public IActionResult Bicep() => Lesson("Bicep", "Bicep", 2);
    public IActionResult BicepStructure() => Lesson("Bicep Structure", "BicepStructure", 3);
    public IActionResult Deployment() => Lesson("Deployment", "Deployment", 4);
    public IActionResult PracticalDeployAzureResourceswithBicep() => Lesson("Practical — Deploy Azure Resources with Bicep", "PracticalDeployAzureResourceswithBicep", 5);

    private IActionResult Lesson(string title, string action, int number)
    {
        var module = AzureLessonCatalog.GetModule("IaC");
        var lesson = new AzureLesson
        {
            ModuleKey = "IaC",
            ModuleTitle = module.Title,
            Title = title,
            Controller = "IaC",
            Action = action,
            Number = number,
            Total = module.Topics.Count,
            Topic = AzureLessonCatalog.GetTopic("IaC", action)
        };
        return View("Lesson", lesson);
    }
}
