using Microsoft.AspNetCore.Mvc;
using CIITEdge.Areas.Azure.Models;
using CIITEdge.Areas.Azure;

namespace CIITEdge.Areas.Azure.Controllers;

[Area("Azure")]
public class NetworkingController : Controller
{
    public IActionResult VNetArchitectureAndAddressPlanning() => Lesson("VNet Architecture and Address Planning", "VNetArchitectureAndAddressPlanning", 1);
    public IActionResult SubnetsRoutingAndDNS() => Lesson("Subnets, Routing and DNS", "SubnetsRoutingAndDNS", 2);
    public IActionResult NSGTrafficFiltering() => Lesson("NSG Traffic Filtering", "NSGTrafficFiltering", 3);
    public IActionResult PublicVsPrivateConnectivity() => Lesson("Public vs Private Connectivity", "PublicVsPrivateConnectivity", 4);
    public IActionResult Lab11BuildAVNetWithWebAppDataSubnets() => Lesson("Lab 11 — Build a VNet with Web/App/Data Subnets", "Lab11BuildAVNetWithWebAppDataSubnets", 5);
    public IActionResult Lab12ControlSSHHTTPWithNSGRules() => Lesson("Lab 12 — Control SSH/HTTP with NSG Rules", "Lab12ControlSSHHTTPWithNSGRules", 6);
    public IActionResult Lab13TestPrivateIPConnectivityBetweenVMs() => Lesson("Lab 13 — Test Private IP Connectivity Between VMs", "Lab13TestPrivateIPConnectivityBetweenVMs", 7);
    public IActionResult Lab14CreateAPrivateEndpointForStorage() => Lesson("Lab 14 — Create a Private Endpoint for Storage", "Lab14CreateAPrivateEndpointForStorage", 8);

    private IActionResult Lesson(string title, string action, int number)
    {
        var module = AzureLessonCatalog.GetModule("Networking");
        var topic = module.Topics[number - 1];
        var lesson = new AzureLesson
        {
            ModuleKey = "Networking",
            ModuleTitle = "Azure Virtual Networking",
            Title = title,
            Controller = "Networking",
            Action = action,
            Number = number,
            Total = module.Topics.Count,
            Kind = topic.Kind.ToString()
        };
        return View("Lesson", lesson);
    }
}