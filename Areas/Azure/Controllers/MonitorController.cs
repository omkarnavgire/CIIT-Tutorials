using Microsoft.AspNetCore.Mvc;
using CIITEdge.Areas.Azure.Models;
using CIITEdge.Areas.Azure;

namespace CIITEdge.Areas.Azure.Controllers;

[Area("Azure")]
public class MonitorController : Controller
{
    public IActionResult WhatisAzureMonitor() => Lesson("What is Azure Monitor?", "WhatisAzureMonitor", 1);
    public IActionResult Metrics() => Lesson("Metrics", "Metrics", 2);
    public IActionResult Logs() => Lesson("Logs", "Logs", 3);
    public IActionResult Alerts() => Lesson("Alerts", "Alerts", 4);
    public IActionResult PracticalCreateMonitoringAlert() => Lesson("Practical — Create Monitoring Alert", "PracticalCreateMonitoringAlert", 5);

    private IActionResult Lesson(string title, string action, int number)
    {
        var module = AzureLessonCatalog.GetModule("Monitor");
        var lesson = new AzureLesson
        {
            ModuleKey = "Monitor",
            ModuleTitle = module.Title,
            Title = title,
            Controller = "Monitor",
            Action = action,
            Number = number,
            Total = module.Topics.Count,
            Topic = AzureLessonCatalog.GetTopic("Monitor", action)
        };
        return View("Lesson", lesson);
    }
}
