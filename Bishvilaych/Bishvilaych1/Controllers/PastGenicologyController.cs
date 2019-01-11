using BussinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Bishvilaych.Controllers
{
    public class PastGenicologyController : Controller
    {
        BLVisitSummery b = new BLVisitSummery();//מופע לשימוש הפונקצייה getUpdating
        BLPastGenicology p = new BLPastGenicology();

        // כניסה ללשונית הסטוריה גניקולגית
        public ActionResult PastGenicology()
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
                ViewBag.status2 = Session["status2"];
                Session["status2"] = "";
                string id = Session["Patiant"].ToString(); 
                BLPastGenicology BL = new BLPastGenicology();
                PastGenicology p = BL.getPastGenicology(id, DateTime.Today); // שליפת נתוני המטופלת מהמסד
                return View(p); 
            }
            catch(Exception e)
            {
                return View();
            }
        }

        [HttpPost]// עדכון הנתונים במסד
        public ActionResult PastGenicology(PastGenicology pg)
        {
            try
            {
                Session.Timeout += 10;
                string id = Session["Patiant"].ToString();
                BLPastGenicology bl = new BLPastGenicology();
                int result = bl.addOrUpdatePastGenicology(id, DateTime.Today,
                pg.AgeOfMenarche, pg.CycleRegular, pg.CycleRegularT, pg.MenstrualSyptoms,
                pg.MenstrualSyptomsT, pg.MenopauseSyptoms, pg.MenopauseSyptomsT,
                pg.Contraception, pg.ContraceptionT);
                if (result == 0)// שמירת הנתונים צלחה
                {
                    Session["status2"] = "הנתונים נשמרו בהצלחה";                
                    return RedirectToAction("PastGenicology", "PastGenicology", new { pg });
                }
                else// כשל בשמירת הנתונים
                {
                    Session["status2"] = "התרחשה שגיאה";
                    return RedirectToAction("PastGenicology", "PastGenicology", new { pg });
                }
            }
            catch
            {
                Session["status2"] = "התרחשה שגיאה";
                return RedirectToAction("PastGenicology", "PastGenicology", new { pg });
            }
        }

        public ActionResult getLastVisit()// פונ' לשליפת נתונים לאוסף ההסטוריה הרפואית
        {
            List<MyPastGeniDict> myl = new List<MyPastGeniDict>();
            myl = funcGetAjax();
            return Json(myl, JsonRequestBehavior.AllowGet);
        }
        private List<MyPastGeniDict> funcGetAjax()//פונקציה היוצרת לי כעין מילון אשר הקי שלו זה תאריך והוליו שלו זה בדיקה רפואית של אותו תאריך
        {

            List<DateTime> l2 = new List<DateTime>();
            l2 = b.get_updating(Session["Patiant"].ToString());//מביא לי את רשימת התאריכים
            PastGenicology pastGenicology;
            List<MyPastGeniDict> myl = new List<MyPastGeniDict>();
            MyPastGeniDict myPastGeniDict;
            foreach (var item in l2)//ריצה על רשימת התאריכים
            {
                pastGenicology = p.getPastGenicology(Session["Patiant"].ToString(), item);//מביא לי את בדיקה רפואית של תאריך מסוים
                myPastGeniDict = new MyPastGeniDict();//הקצאת מחלקה               
                DateTime t = new DateTime(item.Year, item.Month, item.Day);//תאריך בפורמט מסודר
                myPastGeniDict.date = t.ToShortDateString();
                myPastGeniDict.list = pastGenicology;
                myl.Add(myPastGeniDict);
            }
            return myl;
        }
    }
    class MyPastGeniDict // מודל ליצירת אוסף ההסטוריה הרפואית 
    {
        public string date { get; set; }
        public PastGenicology list { get; set; }

    }
}
