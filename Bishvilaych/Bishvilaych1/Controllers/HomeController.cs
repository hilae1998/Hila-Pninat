using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bishvilaych.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Home()
        {
            ViewBag.auth = 0;
            //ViewBag.auth = Session["auth"].ToString();
            return View();
        }

        public ActionResult Patiants()
        {
            return View("~/Views/Patiants/Patiants.cshtml");
        }

        public ActionResult Workers()
        {
            return View("~/Views/Workers/Workers.cshtml");
        }

        public ActionResult Costomers()
        {
            return View("~/Views/Customers/Costomers.cshtml");
        }

        public ActionResult Reciepts()
        {
            return View("~/Views/Reciepts/Reciepts.cshtml");
        }
    }
}
