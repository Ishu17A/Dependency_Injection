using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BL;

namespace Dependency_Injection.Controllers
{
    public class HomeController : Controller
    {

        private IEmployee employee = null;

        public HomeController(IEmployee _employee)
        {
            employee = _employee;
        }
        public ActionResult Index()
        {

            int count = employee.getallstudents();  
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}