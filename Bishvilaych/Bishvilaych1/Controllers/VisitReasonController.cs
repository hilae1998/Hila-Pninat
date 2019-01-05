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
        BLVisitSummery b = new BLVisitSummery();//מופע לשימוש הפונקצייה getUpdating
        BLVisitReason p = new BLVisitReason();
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

        public ActionResult getLastVisit()
        {
            List<MyVisitReasonDict> myl = new List<MyVisitReasonDict>();
            myl = funcGetAjax();
            return Json(myl, JsonRequestBehavior.AllowGet);
        }
        private List<MyVisitReasonDict> funcGetAjax()//פונקציה היוצרת לי כעין מילון אשר הקי שלו זה תאריך והוליו שלו זה בדיקה רפואית של אותו תאריך
        {

            List<DateTime> l2 = new List<DateTime>();
            l2 = b.get_updating(Session["Patiant"].ToString());//מביא לי את רשימת התאריכים
            VisitReason visitrReason;
            List<MyVisitReasonDict> myl = new List<MyVisitReasonDict>();
            MyVisitReasonDict myVisitReasonDict;
            foreach (var item in l2)//ריצה על רשימת התאריכים
            {
                visitrReason = p.getVisitReason(item, Session["Patiant"].ToString());//מביא לי את בדיקה רפואית של תאריך מסוים
                myVisitReasonDict = new MyVisitReasonDict();//הקצאת מחלקה               
                DateTime t = new DateTime(item.Year, item.Month, item.Day);//תאריך בפורמט מסודר
                myVisitReasonDict.date = t.ToShortDateString();
                myVisitReasonDict.list = visitrReason;

                myl.Add(myVisitReasonDict);
            }
            return myl;
        }
    }
    class MyVisitReasonDict
    {

        public string date { get; set; }
        public VisitReason list { get; set; }

    }


}

