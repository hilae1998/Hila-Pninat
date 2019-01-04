using BussinesLayer;
using BussinessLayer;
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
            if (Session["UserName"] == null || Session["UserPasswerd"] == null)
                return RedirectToAction("Login", "Account");
            string un = Session["UserName"].ToString(); 
            string pw = Session["UserPasswerd"].ToString() ;
            BLWorker bl = new BLWorker();
            int job = bl.Cheak_JobUser(un, pw);
            if (job == 0)
                Session["auth"] = 5;
            else
                Session["auth"] = job;
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
