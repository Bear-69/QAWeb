using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace DevWeb.Controllers
{
    public class ProjectsController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Arena()
        {
            ViewData["Message"] = "Arena ChMS.";

            return View();
        }

        public IActionResult FMS()
        {
            ViewData["Message"] = "FMS - Form Management System.";

            return View();
        }

        public IActionResult VMS()
        {
            ViewData["Message"] = "VMS - Volunteer Management System.";

            return View();
        }
    }
}
