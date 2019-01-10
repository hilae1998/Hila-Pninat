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
        // מסך ראשי-מסך הבית
        public ActionResult Home()
        {
            try
            {
                if (Session["UserName"] == null || Session["UserPasswerd"] == null)
                    return RedirectToAction("Login", "Account");
                string un = Session["UserName"].ToString();
                string pw = Session["UserPasswerd"].ToString();
                BLWorker bl = new BLWorker();
                int job = bl.Cheak_JobUser(un, pw);
                if (job == 0)
                    Session["auth"] = 5;
                else
                    Session["auth"] = job;
                return View();
            }
            catch (Exception)
            {
                return View();
            }

        }

        // בלחיצה על כפתור מטופלות
        public ActionResult Patiants()
        {
            return View("~/Views/Patiants/Patiants.cshtml");
        }

        // בלחיצה על כפתור עובדות
        public ActionResult Workers()
        {
            return View("~/Views/Workers/Workers.cshtml");
        }

        // בלחיצה על כפתור לקוחות
        public ActionResult Costomers()
        {
            return View("~/Views/Customers/Costomers.cshtml");
        }

        // בלחיצה על כפתור כספי
        public ActionResult Reciepts()
        {
            return View("~/Views/Reciepts/Reciepts.cshtml");
        }
    }
}
