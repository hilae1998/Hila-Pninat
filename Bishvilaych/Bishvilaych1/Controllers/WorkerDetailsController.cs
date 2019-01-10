using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using BussinessLayer;
using BussinesLayer;


namespace Bishvilaych.Controllers
{
    public class WorkerDetailsController : Controller
    {
      
        public ActionResult WorkerDetails()// כניסה לפרטי עובד
        {
            BLWorkerDetails b = new BLWorkerDetails();
            Workers w = b.GetWorker(Session["WorkerDetails"].ToString());
            return View(w);
        }
        [HttpPost]// עדכון שם משתמש וסיסמת העובד
        public ActionResult SetUserNameAndPassword( string username, string password)
        {
            BLWorkerDetails b = new BLWorkerDetails();
            int result = b.UpdateUserNameAndPassword(Session["WorkerDetails"].ToString(), username, password);
            if (result == 0)
            {
                ViewBag.validation = "נקבע בהצלחה";
                return RedirectToAction("WorkerDetails");
            }

            else
            {
                ViewBag.validation = "שגיאה";

            }
            return View("WorkerDetails");
        }
        [HttpGet]
        public ActionResult checkusername(string value)
        {
            BLWorkerDetails b = new BLWorkerDetails();

            int i;
            string messege;
            BLWorkerDetails bd = new BLWorkerDetails();
            i = bd.CheckUserName(value);
            if (i == 20)
            {
                messege = "";
            }
            else
            {
                messege = "שם משתמש קיים במערכת,נסה שם אחר";
            }
            return Json(messege, JsonRequestBehavior.AllowGet);
            
        }
        [HttpPost]
        public ActionResult updateWorker(Workers w)// עדכון שאר פרטי העובד
        {
            ViewBag.validation = "";
            BLWorkerDetails b = new BLWorkerDetails();
            int result = b.UpdateWorker(Session["WorkerDetails"].ToString(), BLCtrl.sendString(w.FirstName, ""), BLCtrl.sendString(w.LastName, "")
               , BLCtrl.sendInt(w.Job, 1), BLCtrl.sendInt(w.Authorization, 1), BLCtrl.sendString(w.City, ""), BLCtrl.sendString(w.Street, ""), BLCtrl.sendString(w.Phone, "")
               , BLCtrl.sendString(w.Phone2, ""), BLCtrl.sendString(w.Fax, ""), BLCtrl.sendString(w.Email, ""), BLCtrl.sendDateTime(w.BirthDate, new DateTime()));
            if (result == 0)
            {
                ViewBag.validation = "הפרטים נקבעו בהצלחה";
                return RedirectToAction("WorkerDetails");
            }

            else
            {
                ViewBag.validation = "שגיאה";
            }
            return View("WorkerDetails");
        }
    }
}