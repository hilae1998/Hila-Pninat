using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BussinessLayer;

namespace Bishvilaych.Controllers
{
    public class LifeStyleDrController : Controller
    {
        Dictionary<int, string> d1 = new Dictionary<int, string>();
        BLVisitSummery b1 = new BLVisitSummery();//מופע לשימוש הפונקצייה getUpdating
        BLDr_LigeStlye p = new BLDr_LigeStlye();
        LifeStyle b = new LifeStyle();
        public ActionResult LifeStyleDr()//כניסה ללשונית אורח חיים רופאה של מטופלת
        {
            try
            {
                if (d1 == null)
                    d1.Clear();
                Session.Timeout += 10;
                if (Session["Patiant"] == null)
                {
                    return RedirectToAction("Login", "Account");
                }
                ViewBag.status4 = Session["status4"];
                Session["status4"] = "";
                string id = Session["Patiant"].ToString(); 
                BLDr_LigeStlye BL = new BLDr_LigeStlye();
                LifeStyle p = BL.Get_LifeStyle(DateTime.Today, id);//שליפת נתוני המטופלת מהמסד
                return View(p); 
            }
            catch (Exception)
            {
                return View();
            }
        }

        [HttpPost]// עדכון הנתונים במסד
        public ActionResult LifeStyleDr(LifeStyle pg)
        {
            try
            {
                string id = Session["Patiant"].ToString();
                BLDr_LigeStlye bl = new BLDr_LigeStlye();
                int result = bl.AddOrUpdatelifestyle(id, DateTime.Today, pg);
                if (result == 0)// שמירת הנתונים צלחה
                {
                    Session["status4"] = "הנתונים נשמרו בהצלחה";
                    return RedirectToAction("LifeStyleDr", "LifeStyleDr", new { pg });
                }
                else// כשל בשמירת הנתונים
                {
                    Session["status4"] = "התרחשה שגיאה";
                    return RedirectToAction("LifeStyleDr", "LifeStyleDr", new { pg }); 
                }
            }
            catch
            {
                Session["status4"] = "התרחשה שגיאה";
                return RedirectToAction("LifeStyleDr", "LifeStyleDr", new { pg });

            }
        }


        public ActionResult getLastVisit()// פונ' לשליפת נתונים לאוסף ההסטוריה הרפואית
        {
            List<MyLifeStyleDr> myl = new List<MyLifeStyleDr>();
            myl = funcGetAjax();
            return Json(myl, JsonRequestBehavior.AllowGet);
        }
        private List<MyLifeStyleDr> funcGetAjax()//פונקציה היוצרת לי כעין מילון אשר הקי שלו זה תאריך והוליו שלו זה בדיקה רפואית של אותו תאריך
        {
            List<DateTime> l2 = new List<DateTime>();
            l2 = b1.get_updating(Session["Patiant"].ToString());//מביא לי את רשימת התאריכים
            LifeStyle lifeStyle;
            List<MyLifeStyleDr> myl = new List<MyLifeStyleDr>();
            MyLifeStyleDr myLifeStyleDr;
            foreach (var item in l2)//ריצה על רשימת התאריכים
            {
                lifeStyle = p.Get_LifeStyle(item, Session["Patiant"].ToString());//מביא לי את בדיקה רפואית של תאריך מסוים
                myLifeStyleDr = new MyLifeStyleDr();//הקצאת מחלקה               
                DateTime t = new DateTime(item.Year, item.Month, item.Day);//תאריך בפורמט מסודר
                myLifeStyleDr.date = t.ToShortDateString();
                myLifeStyleDr.list = lifeStyle;

                myl.Add(myLifeStyleDr);
            }
            return myl;
        }
    }
    class MyLifeStyleDr// מודל ליצירת אוסף ההסטוריה הרפואית 
    {

        public string date { get; set; }
        public LifeStyle list { get; set; }

    }
}









