using Microsoft.AspNetCore.Mvc;

namespace CIITEdge.Areas.Azure.Controllers;

[Area("Azure")]
public class AzureSQLController : Controller
{
    public IActionResult DatabaseAvailabilityAndConsistency() => View();
    public IActionResult KeyTerminologies() => View();
    public IActionResult DeploymentModesInAzure() => View();
    public IActionResult AvailabilityAndConsistency() => View();
    public IActionResult ForSingleServerDeployment() => View();
    public IActionResult ForFlexibleServerDeployment() => View();
    public IActionResult AzureDatabaseAvailabilityServices() => View();
    public IActionResult MicrosoftAzureSQLDatabase() => View();
    public IActionResult WhatIsMicrosoftAzureSQLDatabase() => View();
    public IActionResult AzureSQLVsSQLServer() => View();
    public IActionResult WhyAzureSQLDatabase() => View();
    public IActionResult AzureSQLUseCases() => View();
    public IActionResult AzureSQLArchitecture() => View();
    public IActionResult AzureSQLDatabaseFeatures() => View();
    public IActionResult AzureSQLDatabaseTiers() => View();
    public IActionResult AzureSQLDatabaseServices() => View();
    public IActionResult AzureSQLHandsOn() => View();
    public IActionResult QueryingUsingAzureSQLDatabase() => View();
    public IActionResult PricingOfAzureSQLDatabase() => View();
    public IActionResult DeletingDatabasesInAzureSQL() => View();
}
