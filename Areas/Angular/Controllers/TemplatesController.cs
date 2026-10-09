using Microsoft.AspNetCore.Mvc;

namespace CIITEdge.Areas.Angular.Controllers
{
    [Area("Angular")]
    public class TemplatesController : Controller
    {
        // 1. Templates Introduction
        public IActionResult Index()
        {
            return View();
        }

        // 2. Template Syntax
        public IActionResult TemplateSyntax()
        {
            return View();
        }

        // 3. Template Expressions
        public IActionResult TemplateExpressions()
        {
            return View();
        }

        // 4. Template Statements
        public IActionResult TemplateStatements()
        {
            return View();
        }

        // 5. Template Reference Variables
        public IActionResult TemplateReferenceVariables()
        {
            return View();
        }

        // 6. ng-template
        public IActionResult NgTemplate()
        {
            return View();
        }

        // 7. ng-container
        public IActionResult NgContainer()
        {
            return View();
        }

        // 8. ngTemplateOutlet
        public IActionResult NgTemplateOutlet()
        {
            return View();
        }

        // 9. Built-in Control Flow
        public IActionResult ControlFlow()
        {
            return View();
        }

        // 10. Template Best Practices
        public IActionResult TemplateBestPractices()
        {
            return View();
        }
    }
}