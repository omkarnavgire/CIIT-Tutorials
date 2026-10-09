using Microsoft.AspNetCore.Mvc;
using CIITEdge.Areas.Azure.Models;
using CIITEdge.Areas.Azure;

namespace CIITEdge.Areas.Azure.Controllers;

[Area("Azure")]
public class AKSController : Controller
{
    public IActionResult WhatisKubernetes() => Lesson("What is Kubernetes?", "WhatisKubernetes", 1);
    public IActionResult WhatisAKS() => Lesson("What is AKS?", "WhatisAKS", 2);
    public IActionResult AKSArchitecture() => Lesson("AKS Architecture", "AKSArchitecture", 3);
    public IActionResult Deployments() => Lesson("Deployments", "Deployments", 4);
    public IActionResult PracticalDeployApplicationtoAKS() => Lesson("Practical — Deploy Application to AKS", "PracticalDeployApplicationtoAKS", 5);

    private IActionResult Lesson(string title, string action, int number)
    {
        var module = AzureLessonCatalog.GetModule("AKS");
        var lesson = new AzureLesson
        {
            ModuleKey = "AKS",
            ModuleTitle = module.Title,
            Title = title,
            Controller = "AKS",
            Action = action,
            Number = number,
            Total = module.Topics.Count,
            Topic = AzureLessonCatalog.GetTopic("AKS", action)
        };
        return View("Lesson", lesson);
    }
}
