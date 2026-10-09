using Microsoft.AspNetCore.Mvc;
using CIITEdge.Areas.Azure.Models;
using CIITEdge.Areas.Azure;

namespace CIITEdge.Areas.Azure.Controllers;

[Area("Azure")]
public class SecurityController : Controller
{
    public IActionResult AzureSecurityFundamentals() => Lesson("Azure Security Fundamentals", "AzureSecurityFundamentals", 1);
    public IActionResult EntraIDSecurity() => Lesson("Entra ID Security", "EntraIDSecurity", 2);
    public IActionResult AzureKeyVault() => Lesson("Azure Key Vault", "AzureKeyVault", 3);
    public IActionResult PracticalKeyVaultSecret() => Lesson("Practical — Key Vault Secret", "PracticalKeyVaultSecret", 4);
    public IActionResult SecurityNSGHardening() => Lesson("NSG Security Hardening", "SecurityNSGHardening", 5);

    private IActionResult Lesson(string title, string action, int number)
    {
        var module = AzureLessonCatalog.GetModule("Security");
        var lesson = new AzureLesson
        {
            ModuleKey = "Security",
            ModuleTitle = module.Title,
            Title = title,
            Controller = "Security",
            Action = action,
            Number = number,
            Total = module.Topics.Count,
            Topic = AzureLessonCatalog.GetTopic("Security", action)
        };
        return View("Lesson", lesson);
    }
}
