using Microsoft.AspNetCore.Mvc;

namespace CIITEdge.Areas.Angular.Controllers
{
    [Area("Angular")]
    public class ServicesController : Controller
    {
        // 1. Services Introduction
        // What are Services and why they are used
        public IActionResult Index()
        {
            return View();
        }

        // 2. Creating Angular Services
        // Creating and registering a service
        public IActionResult CreatingServices()
        {
            return View();
        }

        // 3. Using Services in Components
        // Injecting and consuming services
        public IActionResult UsingServices()
        {
            return View();
        }

        // 4. Sharing Data Through Services
        // Sharing data between components using a service
        public IActionResult SharingData()
        {
            return View();
        }

        // 5. Service Scope and Singleton Services
        // Understanding service instances and providedIn
        public IActionResult ServiceScope()
        {
            return View();
        }
    }
}