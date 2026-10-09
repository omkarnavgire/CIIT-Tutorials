using Microsoft.AspNetCore.Mvc;

namespace CIITEdge.Areas.Python.Controllers
{
    [Area("Python")]
    public class IntroductionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //public IActionResult WhatIsPython()
        //{
        //    return View();
        //}

        public IActionResult Features()
        {
            return View();
        }

        public IActionResult Installation()
        {
            return View();
        }

        public IActionResult DevelopmentTools()
        {
            return View();
        }

        public IActionResult FirstProgram()
        {
            return View();
        }
    }
}