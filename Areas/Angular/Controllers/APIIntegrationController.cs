using Microsoft.AspNetCore.Mvc;

namespace CIITEdge.Areas.Angular.Controllers
{
    [Area("Angular")]
    public class APIIntegrationController : Controller
    {
        // 1. API Integration Introduction
        // Angular application and REST API communication
        public IActionResult Index()
        {
            return View();
        }

        // 2. Connecting Angular with REST API
        // Connecting Angular services with backend API
        public IActionResult ConnectingAPI()
        {
            return View();
        }

        // 3. Consuming API Data
        // Fetching and displaying API response data
        public IActionResult ConsumingAPI()
        {
            return View();
        }

        // 4. CRUD API Integration
        // Create, Read, Update and Delete operations using API
        public IActionResult CRUDIntegration()
        {
            return View();
        }

        // 5. API Response and Error Handling
        // Handling API responses, errors and loading states
        public IActionResult ResponseHandling()
        {
            return View();
        }
    }
}