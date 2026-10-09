using Microsoft.AspNetCore.Mvc;

namespace CIITEdge.Areas.Angular.Controllers
{
    [Area("Angular")]
    public class HttpClientController : Controller
    {
        // 1. HttpClient Introduction
        // Angular HttpClient and HTTP communication basics
        public IActionResult Index()
        {
            return View();
        }

        // 2. Configuring HttpClient
        // Setting up HttpClient in Angular application
        public IActionResult Configuration()
        {
            return View();
        }

        // 3. GET Request
        // Fetching data from an API
        public IActionResult GetRequest()
        {
            return View();
        }

        // 4. POST, PUT and DELETE Requests
        // Sending, updating and deleting API data
        public IActionResult HttpMethods()
        {
            return View();
        }

        // 5. Request Headers and Parameters
        // Working with HTTP headers, query parameters and route parameters
        public IActionResult HeadersAndParameters()
        {
            return View();
        }

        // 6. HTTP Error Handling
        // Handling API errors and failed HTTP requests
        public IActionResult ErrorHandling()
        {
            return View();
        }
    }
}