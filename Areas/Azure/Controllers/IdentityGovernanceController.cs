using Microsoft.AspNetCore.Mvc;
using CIITEdge.Areas.Azure.Models;
using CIITEdge.Areas.Azure;

namespace CIITEdge.Areas.Azure.Controllers;

[Area("Azure")]
public class IdentityGovernanceController : Controller
{
    public IActionResult MicrosoftEntraIDFundamentals() => View();
    public IActionResult ManagedIdentityAndServicePrincipals() => View();
    public IActionResult Lab04CreateATestUserAndGroup() => Lesson("Lab 04 — Create a Test User and Group", "Lab04CreateATestUserAndGroup", 3);
    public IActionResult Lab05AssignALeastPrivilegeRBACRole() => Lesson("Lab 05 — Assign a Least-Privilege RBAC Role", "Lab05AssignALeastPrivilegeRBACRole", 4);

    private IActionResult Lesson(string title, string action, int number)
    {
        var module = AzureLessonCatalog.GetModule("IdentityGovernance");
        var topic = module.Topics[number - 1];
        var lesson = new AzureLesson
        {
            ModuleKey = "IdentityGovernance",
            ModuleTitle = "Microsoft Entra ID & Azure Governance",
            Title = title,
            Controller = "IdentityGovernance",
            Action = action,
            Number = number,
            Total = module.Topics.Count,
            Kind = topic.Kind.ToString()
        };
        return View("Lesson", lesson);
    }
}