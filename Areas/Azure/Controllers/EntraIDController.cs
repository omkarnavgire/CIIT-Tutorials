using Microsoft.AspNetCore.Mvc;
using CIITEdge.Areas.Azure.Models;
using CIITEdge.Areas.Azure;

namespace CIITEdge.Areas.Azure.Controllers;

[Area("Azure")]
public class EntraIDController : Controller
{
    public IActionResult WhatisMicrosoftEntraID() => Lesson("What is Microsoft Entra ID?", "WhatisMicrosoftEntraID", 1);
    public IActionResult AuthenticationvsAuthorization() => Lesson("Authentication vs Authorization", "AuthenticationvsAuthorization", 2);
    public IActionResult AzureRBAC() => Lesson("Azure RBAC", "AzureRBAC", 3);
    public IActionResult Users() => Lesson("Users", "Users", 4);
    public IActionResult PracticalCreateUserAssignRole() => Lesson("Practical — Create User & Assign Role", "PracticalCreateUserAssignRole", 5);

    private IActionResult Lesson(string title, string action, int number)
    {
        var module = AzureLessonCatalog.GetModule("EntraID");
        var lesson = new AzureLesson
        {
            ModuleKey = "EntraID",
            ModuleTitle = module.Title,
            Title = title,
            Controller = "EntraID",
            Action = action,
            Number = number,
            Total = module.Topics.Count,
            Topic = AzureLessonCatalog.GetTopic("EntraID", action)
        };
        return View("Lesson", lesson);
    }
}
