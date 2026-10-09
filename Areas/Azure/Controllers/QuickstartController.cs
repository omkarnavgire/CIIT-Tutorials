using Microsoft.AspNetCore.Mvc;

namespace CIITEdge.Areas.Azure.Controllers;

[Area("Azure")]
public class QuickstartController : Controller
{
    public IActionResult AzureQuickstartCentre() => View();
    public IActionResult QuickstartImplementation() => View();
    public IActionResult QuickstartGuidesAndCourses() => View();
    public IActionResult QuickstartCreateWebApp() => View();
    public IActionResult QuickstartCentreSummary() => View();
}
