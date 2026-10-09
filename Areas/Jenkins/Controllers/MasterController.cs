using Microsoft.AspNetCore.Mvc;

namespace CIITEdge.Areas.Jenkins.Controllers
{
    [Area("Jenkins")]
    public class MasterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Credentials()
        {
            return View();
        }


        public IActionResult Secrets()
        {
            return View();
        }


        public IActionResult RBAC()
        {
            return View();
        }


        public IActionResult LdapOidc()
        {
            return View();
        }


        public IActionResult AgentSecurity()
        {
            return View();
        }


        public IActionResult SharedLibraries()
        {
            return View();
        }


        public IActionResult JCasC()
        {
            return View();
        }


        public IActionResult BackupRecovery()
        {
            return View();
        }


        public IActionResult Performance()
        {
            return View();
        }


        public IActionResult FinalProject()
        {
            return View();
        }
    }
}
