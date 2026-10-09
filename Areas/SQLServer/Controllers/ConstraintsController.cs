using Microsoft.AspNetCore.Mvc;

namespace CIITEdge.Areas.SQLServer.Controllers
{
    [Area("SQLServer")]
    public class ConstraintsController : Controller
    {
        // 1. Constraints Introduction
        public IActionResult Index()
        {
            return View();
        }

        // 2. PRIMARY KEY
        public IActionResult PrimaryKey()
        {
            return View();
        }

        // 3. FOREIGN KEY
        public IActionResult ForeignKey()
        {
            return View();
        }

        // 4. UNIQUE Constraint
        public IActionResult UniqueConstraint()
        {
            return View();
        }

        // 5. NOT NULL & DEFAULT
        public IActionResult NotNullDefault()
        {
            return View();
        }

        // 6. CHECK Constraint
        public IActionResult CheckConstraint()
        {
            return View();
        }
    }
}