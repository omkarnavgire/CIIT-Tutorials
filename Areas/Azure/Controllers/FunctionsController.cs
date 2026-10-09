using Microsoft.AspNetCore.Mvc;
using CIITEdge.Areas.Azure.Models;
using CIITEdge.Areas.Azure;

namespace CIITEdge.Areas.Azure.Controllers;

[Area("Azure")]
public class FunctionsController : Controller
{
    public IActionResult WhatisServerless() => Lesson("What is Serverless?", "WhatisServerless", 1);
    public IActionResult WhatisAzureFunctions() => Lesson("What is Azure Functions?", "WhatisAzureFunctions", 2);
    public IActionResult FunctionApp() => Lesson("Function App", "FunctionApp", 3);
    public IActionResult PracticalHTTPFunction() => Lesson("Practical — HTTP Function", "PracticalHTTPFunction", 4);
    public IActionResult PracticalTimerFunction() => Lesson("Practical — Timer Function", "PracticalTimerFunction", 5);

    private IActionResult Lesson(string title, string action, int number)
    {
        var module = AzureLessonCatalog.GetModule("Functions");
        var lesson = new AzureLesson
        {
            ModuleKey = "Functions",
            ModuleTitle = module.Title,
            Title = title,
            Controller = "Functions",
            Action = action,
            Number = number,
            Total = module.Topics.Count,
            Topic = AzureLessonCatalog.GetTopic("Functions", action)
        };
        return View("Lesson", lesson);
    }
}
