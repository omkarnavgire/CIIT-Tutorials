using Microsoft.AspNetCore.Mvc;

namespace CIITEdge.Areas.Angular.Controllers
{
    [Area("Angular")]
    public class FormsController : Controller
    {
        // 1. Angular Forms Introduction
        // Forms in Angular and form handling basics
        public IActionResult Index()
        {
            return View();
        }

        // 2. Template-Driven Forms
        // ngForm, ngModel and form controls
        public IActionResult TemplateDrivenForms()
        {
            return View();
        }

        // 3. Reactive Forms
        // FormGroup, FormControl and FormBuilder
        public IActionResult ReactiveForms()
        {
            return View();
        }

        // 4. Form Validation
        // Required, email, min/max and custom validation
        public IActionResult FormValidation()
        {
            return View();
        }

        // 5. Form Submission and Error Handling
        // Submitting forms and displaying validation errors
        public IActionResult FormSubmission()
        {
            return View();
        }
    }
}