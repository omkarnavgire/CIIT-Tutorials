using Microsoft.AspNetCore.Mvc;

namespace CIITEdge.Areas.Azure.Controllers;

[Area("Azure")]
public class DashboardsController : Controller
{
    public IActionResult CustomizingChartsOnAzureDashboard() => View();
    public IActionResult CustomizingAzureDashboardTiles() => View();
    public IActionResult AutoRefreshingDashboards() => View();
    public IActionResult SharedDashboards() => View();
    public IActionResult PinningToPortalDashboard() => View();
}
