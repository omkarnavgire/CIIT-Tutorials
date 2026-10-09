using Microsoft.AspNetCore.Mvc;

namespace CIITEdge.Areas.Angular.Controllers
{
    [Area("Angular")]
    public class ObservablesController : Controller
    {
        // 1. Observables Introduction
        // What are Observables and how they work in Angular
        public IActionResult Index()
        {
            return View();
        }

        // 2. Creating and Subscribing to Observables
        // Creating Observable streams and using subscribe()
        public IActionResult Subscription()
        {
            return View();
        }

        // 3. Observable Data Streams
        // Handling synchronous and asynchronous data
        public IActionResult DataStreams()
        {
            return View();
        }

        // 4. Observable Operators
        // map, filter, tap and other commonly used operators
        public IActionResult Operators()
        {
            return View();
        }

        // 5. Unsubscribe and Subscription Management
        // Managing subscriptions and preventing memory leaks
        public IActionResult Unsubscribe()
        {
            return View();
        }
    }
}