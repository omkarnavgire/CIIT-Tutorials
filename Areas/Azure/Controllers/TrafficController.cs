using Microsoft.AspNetCore.Mvc;
using CIITEdge.Areas.Azure.Models;
using CIITEdge.Areas.Azure;

namespace CIITEdge.Areas.Azure.Controllers;

[Area("Azure")]
public class TrafficController : Controller
{
    public IActionResult AzureLoadBalancerArchitecture() => Lesson("Azure Load Balancer Architecture", "AzureLoadBalancerArchitecture", 1);
    public IActionResult ApplicationGatewayAndLayer7Routing() => Lesson("Application Gateway and Layer-7 Routing", "ApplicationGatewayAndLayer7Routing", 2);
    public IActionResult HealthProbesBackendPoolsAndRules() => Lesson("Health Probes, Backend Pools and Rules", "HealthProbesBackendPoolsAndRules", 3);
    public IActionResult Lab24PutTwoVMsBehindALoadBalancer() => Lesson("Lab 24 — Put Two VMs Behind a Load Balancer", "Lab24PutTwoVMsBehindALoadBalancer", 4);
    public IActionResult Lab25ConfigureApplicationGatewayForAWebApp() => Lesson("Lab 25 — Configure Application Gateway for a Web App", "Lab25ConfigureApplicationGatewayForAWebApp", 5);
    public IActionResult Lab26TestABackendFailureAndHealthProbe() => Lesson("Lab 26 — Test a Backend Failure and Health Probe", "Lab26TestABackendFailureAndHealthProbe", 6);

    private IActionResult Lesson(string title, string action, int number)
    {
        var module = AzureLessonCatalog.GetModule("Traffic");
        var topic = module.Topics[number - 1];
        var lesson = new AzureLesson
        {
            ModuleKey = "Traffic",
            ModuleTitle = "Load Balancing & Application Gateway",
            Title = title,
            Controller = "Traffic",
            Action = action,
            Number = number,
            Total = module.Topics.Count,
            Kind = topic.Kind.ToString()
        };
        return View("Lesson", lesson);
    }
}