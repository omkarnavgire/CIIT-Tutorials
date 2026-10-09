using Microsoft.AspNetCore.Mvc;
using CIITEdge.Areas.Azure.Models;
using CIITEdge.Areas.Azure;

namespace CIITEdge.Areas.Azure.Controllers;

[Area("Azure")]
public class LoadBalancingController : Controller
{
    public IActionResult WhatisLoadBalancing() => Lesson("What is Load Balancing?", "WhatisLoadBalancing", 1);
    public IActionResult AzureLoadBalancer() => Lesson("Azure Load Balancer", "AzureLoadBalancer", 2);
    public IActionResult AzureApplicationGateway() => Lesson("Azure Application Gateway", "AzureApplicationGateway", 3);
    public IActionResult PracticalVMLoadBalancer() => Lesson("Practical — VM + Load Balancer", "PracticalVMLoadBalancer", 4);
    public IActionResult PracticalApplicationGateway() => Lesson("Practical — Application Gateway", "PracticalApplicationGateway", 5);

    private IActionResult Lesson(string title, string action, int number)
    {
        var module = AzureLessonCatalog.GetModule("LoadBalancing");
        var lesson = new AzureLesson
        {
            ModuleKey = "LoadBalancing",
            ModuleTitle = module.Title,
            Title = title,
            Controller = "LoadBalancing",
            Action = action,
            Number = number,
            Total = module.Topics.Count,
            Topic = AzureLessonCatalog.GetTopic("LoadBalancing", action)
        };
        return View("Lesson", lesson);
    }
}
