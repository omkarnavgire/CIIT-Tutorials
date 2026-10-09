using Microsoft.AspNetCore.Mvc;
using CIITEdge.Areas.Azure.Models;
using CIITEdge.Areas.Azure;

namespace CIITEdge.Areas.Azure.Controllers;

[Area("Azure")]
public class ContainersController : Controller
{
    public IActionResult WhatareContainers() => Lesson("What are Containers?", "WhatareContainers", 1);
    public IActionResult DockerBasics() => Lesson("Docker Basics", "DockerBasics", 2);
    public IActionResult AzureContainerRegistry() => Lesson("Azure Container Registry", "AzureContainerRegistry", 3);
    public IActionResult AzureContainerApps() => Lesson("Azure Container Apps", "AzureContainerApps", 4);
    public IActionResult PracticalDeployDockerApplication() => Lesson("Practical — Deploy Docker Application", "PracticalDeployDockerApplication", 5);

    private IActionResult Lesson(string title, string action, int number)
    {
        var module = AzureLessonCatalog.GetModule("Containers");
        var lesson = new AzureLesson
        {
            ModuleKey = "Containers",
            ModuleTitle = module.Title,
            Title = title,
            Controller = "Containers",
            Action = action,
            Number = number,
            Total = module.Topics.Count,
            Topic = AzureLessonCatalog.GetTopic("Containers", action)
        };
        return View("Lesson", lesson);
    }
}
