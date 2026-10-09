using Microsoft.AspNetCore.Mvc;
using CIITEdge.Areas.Azure.Models;
using CIITEdge.Areas.Azure;

namespace CIITEdge.Areas.Azure.Controllers;

[Area("Azure")]
public class VirtualNetworkController : Controller
{
    public IActionResult WhatisAzureVNet() => Lesson("What is Azure VNet?", "WhatisAzureVNet", 1);
    public IActionResult VNetArchitecture() => Lesson("VNet Architecture", "VNetArchitecture", 2);
    public IActionResult AddressSpace() => Lesson("Address Space", "AddressSpace", 3);
    public IActionResult PracticalCreateVNetSubnets() => Lesson("Practical — Create VNet & Subnets", "PracticalCreateVNetSubnets", 4);
    public IActionResult PrivateEndpoints() => Lesson("Private Endpoints", "PrivateEndpoints", 5);

    private IActionResult Lesson(string title, string action, int number)
    {
        var module = AzureLessonCatalog.GetModule("VirtualNetwork");
        var lesson = new AzureLesson
        {
            ModuleKey = "VirtualNetwork",
            ModuleTitle = module.Title,
            Title = title,
            Controller = "VirtualNetwork",
            Action = action,
            Number = number,
            Total = module.Topics.Count,
            Topic = AzureLessonCatalog.GetTopic("VirtualNetwork", action)
        };
        return View("Lesson", lesson);
    }
}
