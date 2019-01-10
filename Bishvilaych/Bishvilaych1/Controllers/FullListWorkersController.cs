using BussinesLayer;
using BussinessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace Bishvilaych.Controllers
{
    public class FullListWorkersController : Controller
    {
        [HttpGet] // שליפת רשימת לקוחות העמותה
        public ActionResult WorkersList()
        {
            try
            {
                Session.Timeout += 5;//session הגדלת ה
                BLWorkersList b = new BLWorkersList();
                List<Workers> p = b.getWorkers();
                return View(p);
            }
            catch (Exception)
            {
                return View();
            }
        }
        // בלחיצה על עובד מרשימת העובדות
        public ActionResult decision(string id)
        {
            Session["WorkerDetails"] = id;
            return RedirectToAction("WorkerDetails", "WorkerDetails");
        }
    }  
}
