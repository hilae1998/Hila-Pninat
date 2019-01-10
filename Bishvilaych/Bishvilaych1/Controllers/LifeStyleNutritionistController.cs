using BussinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Bishvilaych.Controllers
{
    public class LifeStyleNutritionistController : Controller
    {
        BLVisitSummery b = new BLVisitSummery();//מופע לשימוש הפונקצייה getUpdating
        BLLifeStyleNutritionist p = new BLLifeStyleNutritionist();

        [HttpGet]//כניסה ללשונית אורח חיים תזונאית של מטופלת
        public ActionResult LifeStyleNutritionist()
        {
            try
            {
                Session.Timeout += 10;
                if (Session["Patiant"] == null)
                {
                    return RedirectToAction("Login", "Account");
                }
                ViewBag.status3 = Session["status3"];
                Session["status3"] = "";

                BLLifeStyleNutritionist lsn = new BLLifeStyleNutritionist();
                LifeStyle ls = lsn.getLifeStyleNutritionist(Session["Patiant"].ToString(), DateTime.Today);// שליפת נתוני המטופלת מהמסד
                return View(ls);
            }
            catch (Exception)
            {
                return View();
            }
        }

        [HttpPost]// עדכון הנתונים במסד
        public ActionResult LifeStyleNutritionist(LifeStyle ls)
        {
            try
            {
                BLLifeStyleNutritionist lsn = new BLLifeStyleNutritionist();
                int result = lsn.addOrUpdateLifeStyleNutritionist(ls.Height, ls.Wieght, ls.BMI,
                    ls.BloodPressure, ls.pulse, ls.NotEat, ls.NotEatT, ls.Meals, ls.Fruits, ls.Vegetables,
                    ls.Dairy, ls.Water, ls.Diet, ls.DietT, ls.SleepingHours, ls.Activity, DateTime.Today, Session["Patiant"].ToString());
                if (result == 0)// שמירת הנתונים צלחה
                {
                    Session["status3"] = "הנתונים נשמרו בהצלחה";
                    return RedirectToAction("LifeStyleNutritionist", "LifeStyleNutritionist", new { ls });
                }
                else// כשל בשמירת הנתונים
                {
                    Session["status3"] = "התרחשה שגיאה";
                    return RedirectToAction("LifeStyleNutritionist", "LifeStyleNutritionist", new { ls });
                }

            }
            catch (Exception)
            {
                Session["status3"] = "התרחשה שגיאה";
                return RedirectToAction("LifeStyleNutritionist", "LifeStyleNutritionist", new { ls });
            }
        }


        public ActionResult getLastVisit()// פונ' לשליפת נתונים לאוסף ההסטוריה הרפואית
        {
            List<MyLifeStyleNutri> myl = new List<MyLifeStyleNutri>();
            myl = funcGetAjax();
            return Json(myl, JsonRequestBehavior.AllowGet);
        }
        private List<MyLifeStyleNutri> funcGetAjax()//פונקציה היוצרת לי כעין מילון אשר הקי שלו זה תאריך והוליו שלו זה בדיקה רפואית של אותו תאריך
        {

            List<DateTime> l2 = new List<DateTime>();
            l2 = b.get_updating(Session["Patiant"].ToString());//מביא לי את רשימת התאריכים
            LifeStyle lifeStyle;
            List<MyLifeStyleNutri> myl = new List<MyLifeStyleNutri>();
            MyLifeStyleNutri myLifeStyleNutri;
            foreach (var item in l2)//ריצה על רשימת התאריכים
            {
                lifeStyle = p.getLifeStyleNutritionist(Session["Patiant"].ToString(),item);//מביא לי את בדיקה רפואית של תאריך מסוים
                myLifeStyleNutri = new MyLifeStyleNutri();//הקצאת מחלקה               
                DateTime t = new DateTime(item.Year, item.Month, item.Day);//תאריך בפורמט מסודר
                myLifeStyleNutri.date = t.ToShortDateString();
                myLifeStyleNutri.list = lifeStyle;

                myl.Add(myLifeStyleNutri);
            }
            return myl;
        }
    }
    class MyLifeStyleNutri // מודל ליצירת אוסף ההסטוריה הרפואית 
    {

        public string date { get; set; }
        public LifeStyle list { get; set; }

    }
}
