using Microsoft.AspNetCore.Mvc;
using CIITEdge.Areas.Azure.Models;
using CIITEdge.Areas.Azure;

namespace CIITEdge.Areas.Azure.Controllers;

[Area("Azure")]
public class IntegrationController : Controller
{
    public IActionResult WhatisAzureIntegration() => Lesson("What is Azure Integration?", "WhatisAzureIntegration", 1);
    public IActionResult AzureServiceBus() => Lesson("Azure Service Bus", "AzureServiceBus", 2);
    public IActionResult Queues() => Lesson("Queues", "Queues", 3);
    public IActionResult TopicsSubscriptions() => Lesson("Topics & Subscriptions", "TopicsSubscriptions", 4);
    public IActionResult PracticalQueuebasedApplication() => Lesson("Practical — Queue-based Application", "PracticalQueuebasedApplication", 5);

    private IActionResult Lesson(string title, string action, int number)
    {
        var module = AzureLessonCatalog.GetModule("Integration");
        var lesson = new AzureLesson
        {
            ModuleKey = "Integration",
            ModuleTitle = module.Title,
            Title = title,
            Controller = "Integration",
            Action = action,
            Number = number,
            Total = module.Topics.Count,
            Topic = AzureLessonCatalog.GetTopic("Integration", action)
        };
        return View("Lesson", lesson);
    }
}
