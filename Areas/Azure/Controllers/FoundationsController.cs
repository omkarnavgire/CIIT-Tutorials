using Microsoft.AspNetCore.Mvc;
using CIITEdge.Areas.Azure.Models;
using CIITEdge.Areas.Azure;

namespace CIITEdge.Areas.Azure.Controllers;

[Area("Azure")]
public class FoundationsController : Controller
{
    public IActionResult Index() => RedirectToAction(nameof(CloudConceptsYouMustKnow));
    public IActionResult CloudConceptsYouMustKnow() => Lesson("Cloud Concepts You Must Know", "CloudConceptsYouMustKnow", 1);
    public IActionResult AzureGlobalInfrastructure() => Lesson("Azure Global Infrastructure", "AzureGlobalInfrastructure", 2);
    public IActionResult RegionsZonesAndRegionPairs() => Lesson("Regions, Zones and Region Pairs", "RegionsZonesAndRegionPairs", 3);
    public IActionResult Lab01CreateResourceGroupAndExplorePortal() => Lesson("Lab 01 — Create Resource Group and Explore Portal", "Lab01CreateResourceGroupAndExplorePortal", 4);
    public IActionResult Lab02CreateYourFirstAzureResource() => Lesson("Lab 02 — Create Your First Azure Resource", "Lab02CreateYourFirstAzureResource", 5);
    public IActionResult Lab03SetABudgetAndCostAlert() => Lesson("Lab 03 — Set a Budget and Cost Alert", "Lab03SetABudgetAndCostAlert", 6);

    private IActionResult Lesson(string title, string action, int number)
    {
        var module = AzureLessonCatalog.GetModule("Foundations");
        var topic = module.Topics[number - 1];
        var lesson = new AzureLesson
        {
            ModuleKey = "Foundations",
            ModuleTitle = "Introduction to Microsoft Azure",
            Title = title,
            Controller = "Foundations",
            Action = action,
            Number = number,
            Total = module.Topics.Count,
            Kind = topic.Kind.ToString()
        };
        return View("Lesson", lesson);
    }
}