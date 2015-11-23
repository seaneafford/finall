using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace final.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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
        public ActionResult projectss()// is still here only to redirect to details page.
        {
            ViewBag.Message = "hi";

            return View();
        }
             public ActionResult niceProjects()// to carousel
        {
            ViewBag.Message = "hi";

            return View();
        }
    }
}