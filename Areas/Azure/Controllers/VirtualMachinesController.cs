using Microsoft.AspNetCore.Mvc;

namespace CIITEdge.Areas.Azure.Controllers;

[Area("Azure")]
public class VirtualMachinesController : Controller
{
    public IActionResult AzureVirtualMachines() => View();
    public IActionResult WhatAreVirtualMachines() => View();
    public IActionResult UsesOfVirtualMachines() => View();
    public IActionResult BeforeCreatingAzureVirtualMachine() => View();
    public IActionResult LocationOfAzureVirtualMachine() => View();
    public IActionResult AzureVirtualMachineSize() => View();
    public IActionResult OperatingSystemDisksAndImages() => View();
    public IActionResult VirtualMachineExtensions() => View();
    public IActionResult CreateAzureVirtualMachine() => View();
}
