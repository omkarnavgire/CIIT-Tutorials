using Microsoft.AspNetCore.Mvc;
using CIITEdge.Areas.Azure.Models;
using CIITEdge.Areas.Azure;

namespace CIITEdge.Areas.Azure.Controllers;

[Area("Azure")]
public class MonitoringController : Controller
{
    public IActionResult AzureMonitorMentalModel() => Lesson("Azure Monitor Mental Model", "AzureMonitorMentalModel", 1);
    public IActionResult MetricsLogsAndActivityLog() => Lesson("Metrics, Logs and Activity Log", "MetricsLogsAndActivityLog", 2);
    public IActionResult ApplicationInsightsAndDistributedTracing() => Lesson("Application Insights and Distributed Tracing", "ApplicationInsightsAndDistributedTracing", 3);
    public IActionResult Lab21CreateALogAnalyticsWorkspace() => Lesson("Lab 21 — Create a Log Analytics Workspace", "Lab21CreateALogAnalyticsWorkspace", 4);
    public IActionResult Lab22CreateAnAlertAndActionGroup() => Lesson("Lab 22 — Create an Alert and Action Group", "Lab22CreateAnAlertAndActionGroup", 5);
    public IActionResult Lab23DiagnoseAFailedWebApplication() => Lesson("Lab 23 — Diagnose a Failed Web Application", "Lab23DiagnoseAFailedWebApplication", 6);

    private IActionResult Lesson(string title, string action, int number)
    {
        var module = AzureLessonCatalog.GetModule("Monitoring");
        var topic = module.Topics[number - 1];
        var lesson = new AzureLesson
        {
            ModuleKey = "Monitoring",
            ModuleTitle = "Azure Monitor & Troubleshooting",
            Title = title,
            Controller = "Monitoring",
            Action = action,
            Number = number,
            Total = module.Topics.Count,
            Kind = topic.Kind.ToString()
        };
        return View("Lesson", lesson);
    }
}