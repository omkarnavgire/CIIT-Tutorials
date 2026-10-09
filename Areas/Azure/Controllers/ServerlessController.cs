using Microsoft.AspNetCore.Mvc;
using CIITEdge.Areas.Azure.Models;
using CIITEdge.Areas.Azure;

namespace CIITEdge.Areas.Azure.Controllers;

[Area("Azure")]
public class ServerlessController : Controller
{
    public IActionResult AzureFunctionsExecutionModel() => Lesson("Azure Functions Execution Model", "AzureFunctionsExecutionModel", 1);
    public IActionResult TriggersBindingsAndConfiguration() => Lesson("Triggers, Bindings and Configuration", "TriggersBindingsAndConfiguration", 2);
    public IActionResult ServiceBusEventGridAndLogicApps() => Lesson("Service Bus, Event Grid and Logic Apps", "ServiceBusEventGridAndLogicApps", 3);
    public IActionResult Lab18CreateAnHTTPTriggeredFunction() => Lesson("Lab 18 — Create an HTTP-triggered Function", "Lab18CreateAnHTTPTriggeredFunction", 4);
    public IActionResult Lab19CreateATimerTriggeredFunction() => Lesson("Lab 19 — Create a Timer-triggered Function", "Lab19CreateATimerTriggeredFunction", 5);
    public IActionResult Lab20BuildAQueueBasedWorkflowWithServiceBus() => Lesson("Lab 20 — Build a Queue-based Workflow with Service Bus", "Lab20BuildAQueueBasedWorkflowWithServiceBus", 6);

    private IActionResult Lesson(string title, string action, int number)
    {
        var module = AzureLessonCatalog.GetModule("Serverless");
        var topic = module.Topics[number - 1];
        var lesson = new AzureLesson
        {
            ModuleKey = "Serverless",
            ModuleTitle = "Serverless & Azure Integration",
            Title = title,
            Controller = "Serverless",
            Action = action,
            Number = number,
            Total = module.Topics.Count,
            Kind = topic.Kind.ToString()
        };
        return View("Lesson", lesson);
    }
}