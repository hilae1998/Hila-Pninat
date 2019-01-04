using BussinessLayer;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Bishvilaych.Controllers
{
    public class VisitReasonController : Controller
    {
        [HttpGet]
        public ActionResult VisitReason()
        {
            if (Session["Patiant"] == null)
            {
                return RedirectToAction("Login", "Account");
            }
            ViewBag.status1 = Session["status1"];
            Session["status1"] = "";
            string id = Session["Patiant"].ToString(); //id - from Patiant controller
            BLVisitReason bl = new BLVisitReason();
            VisitReason v = bl.getVisitReason(DateTime.Today, id);
            return View(v);
        }
        [HttpPost]
        public ActionResult VisitReason(VisitReason vr)
        {
            try
            {
                string id = Session["Patiant"].ToString();//id - from Patiant controler
                BLVisitReason bl = new BLVisitReason();
                int result = bl.AddOrUpdateVisitReason(id, DateTime.Today,
                vr.GeneralCheck, vr.BreastExam, vr.Pap, vr.Diaphragm, vr.OtherConcetraption,
                vr.MenstrualCycle, vr.Kallah, vr.OtherReason, vr.Text);// update the db with the new ditails
                if (result == 0)
                {
                    Session["status1"] = "הנתונים נשמרו בהצלחה";
                    //return RedirectToAction("PastMedical", "PastMedical");
                    return RedirectToAction("VisitReason", "VisitReason"/*, new { vr }*/);
                }
                else
                {
                    Session["status1"] = " התרחשה שגיאה";
                    return RedirectToAction("VisitReason", "VisitReason"/*, new { vr }*/);
                }
            }
            catch
            {
                Session["status1"] = "התרחשה שגיאה";
                return RedirectToAction("VisitReason", "VisitReason"/*, new { vr }*/);
            }
        }

    }
}
