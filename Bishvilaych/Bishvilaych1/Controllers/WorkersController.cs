using BussinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace Bishvilaych.Controllers
{
    public class WorkersController : Controller
    {
        [HttpGet]
        public ActionResult Workers()// כניסה לדף ראשי- עובדות
        {
            if (Session["UserName"] == null || Session["UserPasswerd"] == null)
            {
                return RedirectToAction("Login", "Account");
            }
            return View();
        }

        [HttpPost]// כניסה לפרטי עובד
        public ActionResult Workers(string idWorkers)
        {
            try
            {
                Session.Timeout += 10;//session הגדלת ה
                BLCheck_Workers b = new BLCheck_Workers();
                if (idWorkers.Length > 9 || idWorkers == "")// תעודת זהות אינה חוקית
                {
                    ViewBag.error = "תעודת זהות לא חוקית";
                    return View();
                }
                if (b.Check_Workers(idWorkers) == 0)// כשמכניסים תעודת זהות של עובד קיים
                {
                    Session["WorkerDetails"] = idWorkers;
                    return RedirectToAction("WorkerDetails", "WorkerDetails");
                }
                else
                {
                    //if (b.Check_Workers(idWorkers) == 1)
                    ViewBag.error = "תעודת זהות לא קיימת";
                    return View();
                }
            }
            catch (Exception)
            {
                return View();
            }
        }
    }
}
