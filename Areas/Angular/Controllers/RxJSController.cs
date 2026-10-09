using Microsoft.AspNetCore.Mvc;

namespace CIITEdge.Areas.Angular.Controllers
{
    [Area("Angular")]
    public class RxJSController : Controller
    {
        // 1. RxJS Introduction
        // RxJS library and reactive programming in Angular
        public IActionResult Index()
        {
            return View();
        }

        // 2. RxJS Operators
        // Common operators used for transforming and filtering streams
        public IActionResult Operators()
        {
            return View();
        }

        // 3. Transformation and Filtering
        // map, filter, reduce and related operators
        public IActionResult TransformationFiltering()
        {
            return View();
        }

        // 4. Combining Observables
        // combineLatest, forkJoin and other combination techniques
        public IActionResult CombiningObservables()
        {
            return View();
        }

        // 5. Higher-Order Mapping
        // switchMap, mergeMap, concatMap and exhaustMap
        public IActionResult HigherOrderMapping()
        {
            return View();
        }

        // 6. Subjects
        // Subject, BehaviorSubject and sharing data between components
        public IActionResult Subjects()
        {
            return View();
        }
    }
}