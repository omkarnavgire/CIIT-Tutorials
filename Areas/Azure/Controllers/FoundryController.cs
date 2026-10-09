using Microsoft.AspNetCore.Mvc;
using CIITEdge.Areas.Azure.Models;
using CIITEdge.Areas.Azure;

namespace CIITEdge.Areas.Azure.Controllers;

[Area("Azure")]
public class FoundryController : Controller
{
    public IActionResult MicrosoftFoundryAndAIAgentArchitecture() => Lesson("Microsoft Foundry and AI Agent Architecture", "MicrosoftFoundryAndAIAgentArchitecture", 1);
    public IActionResult ModelsInstructionsKnowledgeAndTools() => Lesson("Models, Instructions, Knowledge and Tools", "ModelsInstructionsKnowledgeAndTools", 2);
    public IActionResult Lab42CreateAnEmployeeSupportAgent() => Lesson("Lab 42 — Create an Employee Support Agent", "Lab42CreateAnEmployeeSupportAgent", 3);
    public IActionResult Lab43AddKnowledgeAndAToolToTheAgent() => Lesson("Lab 43 — Add Knowledge and a Tool to the Agent", "Lab43AddKnowledgeAndAToolToTheAgent", 4);

    private IActionResult Lesson(string title, string action, int number)
    {
        var module = AzureLessonCatalog.GetModule("Foundry");
        var topic = module.Topics[number - 1];
        var lesson = new AzureLesson
        {
            ModuleKey = "Foundry",
            ModuleTitle = "Microsoft Foundry & AI Agents",
            Title = title,
            Controller = "Foundry",
            Action = action,
            Number = number,
            Total = module.Topics.Count,
            Kind = topic.Kind.ToString()
        };
        return View("Lesson", lesson);
    }
}