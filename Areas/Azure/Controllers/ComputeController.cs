using Microsoft.AspNetCore.Mvc;
using CIITEdge.Areas.Azure.Models;
using CIITEdge.Areas.Azure;

namespace CIITEdge.Areas.Azure.Controllers;

[Area("Azure")]
public class ComputeController : Controller
{
    public IActionResult AzureVirtualMachinesArchitecture() => Lesson("Azure Virtual Machines Architecture", "AzureVirtualMachinesArchitecture", 1);
    public IActionResult VMImagesSizesAndDisks() => Lesson("VM Images, Sizes and Disks", "VMImagesSizesAndDisks", 2);
    public IActionResult PublicIPPrivateIPAndNSG() => Lesson("Public IP, Private IP and NSG", "PublicIPPrivateIPAndNSG", 3);
    public IActionResult Lab06CreateALinuxVM() => Lesson("Lab 06 — Create a Linux VM", "Lab06CreateALinuxVM", 4);
    public IActionResult Lab07ConnectWithSSHAndHardenAccess() => Lesson("Lab 07 — Connect with SSH and Harden Access", "Lab07ConnectWithSSHAndHardenAccess", 5);
    public IActionResult Lab08InstallNGINXAndPublishAWebPage() => Lesson("Lab 08 — Install NGINX and Publish a Web Page", "Lab08InstallNGINXAndPublishAWebPage", 6);

    private IActionResult Lesson(string title, string action, int number)
    {
        var module = AzureLessonCatalog.GetModule("Compute");
        var topic = module.Topics[number - 1];
        var lesson = new AzureLesson
        {
            ModuleKey = "Compute",
            ModuleTitle = "Azure Compute: Virtual Machines & App Hosting",
            Title = title,
            Controller = "Compute",
            Action = action,
            Number = number,
            Total = module.Topics.Count,
            Kind = topic.Kind.ToString()
        };
        return View("Lesson", lesson);
    }
}