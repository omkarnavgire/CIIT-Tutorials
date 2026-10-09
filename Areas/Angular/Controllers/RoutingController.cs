using Microsoft.AspNetCore.Mvc;

namespace CIITEdge.Areas.Angular.Controllers
{
    [Area("Angular")]
    public class RoutingController : Controller
    {
        // 1. Routing Introduction
        // Angular Routing and navigation basics
        public IActionResult Index()
        {
            return View();
        }

        // 2. Route Configuration
        // Defining routes and RouterModule configuration
        public IActionResult RouteConfiguration()
        {
            return View();
        }

        // 3. RouterLink and Navigation
        // Navigating between Angular components
        public IActionResult Navigation()
        {
            return View();
        }

        // 4. Route Parameters
        // Passing and reading route parameters
        public IActionResult RouteParameters()
        {
            return View();
        }

        // 5. Child Routes
        // Nested routing and child components
        public IActionResult ChildRoutes()
        {
            return View();
        }

        // 6. Route Guards
        // Protecting routes and controlling navigation
        public IActionResult RouteGuards()
        {
            return View();
        }
    }
}