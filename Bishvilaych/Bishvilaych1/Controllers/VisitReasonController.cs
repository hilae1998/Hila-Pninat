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

        [HttpGet]//כניסה ללשונית סיבת ביקור
        public ActionResult VisitReason()
        {
            try
            {
                if (Session["UserName"] == null || Session["UserPasswerd"] == null)
                {
                    return RedirectToAction("Login", "Account");
                }
                if (Session["Patiant"] == null)
                {
                    return RedirectToAction("Login", "Account");
                }
                ViewBag.status1 = Session["status1"];
                Session["status1"] = "";
                string id = Session["Patiant"].ToString();
                BLVisitReason bl = new BLVisitReason();
                VisitReason v = bl.getVisitReason(DateTime.Today, id);// שליפת נתוני המטופלת מהמסד
                return View(v);
            }
            catch (Exception e)
            {
                return View();
            }
        }
        [HttpPost]// עדכון הנתונים במסד
        public ActionResult VisitReason(VisitReason vr)
        {
            try
            {
                Session.Timeout += 10;
                string id = Session["Patiant"].ToString();
                BLVisitReason bl = new BLVisitReason();
                int result = bl.AddOrUpdateVisitReason(id, DateTime.Today,
                vr.GeneralCheck, vr.BreastExam, vr.Pap, vr.Diaphragm, vr.OtherConcetraption,
                vr.MenstrualCycle, vr.Kallah, vr.OtherReason, vr.Text);
                if (result == 0)// שמירת הנתונים צלחה
                {
                    Session["status1"] = "הנתונים נשמרו בהצלחה";
                    return RedirectToAction("VisitReason", "VisitReason"/*, new { vr }*/);
                }
                else// כשל בשמירת הנתונים
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

        public ActionResult getLastVisit()// פונ' לשליפת נתונים לאוסף ההסטוריה הרפואית
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
    class MyVisitReasonDict // מודל ליצירת אוסף ההסטוריה הרפואית 
    {

        public string date { get; set; }
        public VisitReason list { get; set; }

    }
}

