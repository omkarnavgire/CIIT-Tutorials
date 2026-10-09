using Microsoft.AspNetCore.Mvc;

namespace CIITEdge.Areas.Angular.Controllers
{
    [Area("Angular")]
    public class DependencyInjectionController : Controller
    {
        // 1. Dependency Injection Introduction
        // What is DI and why Angular uses Dependency Injection
        public IActionResult Index()
        {
            return View();
        }

        // 2. Injecting Dependencies
        // Injecting services into components and other classes
        public IActionResult InjectingDependencies()
        {
            return View();
        }

        // 3. InjectionToken
        // Providing and injecting custom values or dependencies
        public IActionResult InjectionToken()
        {
            return View();
        }

        // 4. Provider Configuration
        // Understanding providers and where dependencies are provided
        public IActionResult Providers()
        {
            return View();
        }
    }
}