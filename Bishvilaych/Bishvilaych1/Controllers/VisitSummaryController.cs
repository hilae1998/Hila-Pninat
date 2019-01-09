using BussinesLayer;
using BussinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace Bishvilaych.Controllers
{
    public class VisitSummaryController : Controller
    {
        BLVisitSummery b = new BLVisitSummery();

        public ActionResult VisitSummary() // כיניסה ללשונית סיכום ביקור 
        {
            if (Session["Patiant"] == null)
            {
                return RedirectToAction("Login", "Account");
            }
            return View();
        }
        [HttpPost]
        public ActionResult SavevisitSummary(Reccomendations[] a, Summary[] b)//עדכון/הוספת סיכום הביקור
        {
            int result, result2;
            BussinessLayer.BLVisitSummery blv2 = new BussinessLayer.BLVisitSummery();
            if (a != null && b != null) {
                foreach (var item in a)
                {
                    result = blv2.UpdateReccomendations(DateTime.Today, Session["Patiant"].ToString(), item.Code, item.Reccomendation);
                    if (result == -1)
                    {
                        return Json("הפעולה נכשלה", JsonRequestBehavior.AllowGet);
                    }
                }
                foreach (var item in b)
                {
                    result2 = blv2.UpdateSummary(DateTime.Today, Session["Patiant"].ToString(), item.Mentioned, item.FollowUp);
                    if (result2 == -1)
                    {
                        return Json("הפעולה נכשלה", JsonRequestBehavior.AllowGet);
                    }
                }
                return Json("הפעולה בוצעה בהצלחה", JsonRequestBehavior.AllowGet);
            }
            return Json("הפעולה נכשלה", JsonRequestBehavior.AllowGet);
        }
    

       [HttpGet]
        public ActionResult getLastVisit()//פונקציה להחזרת האובייקט בתור גייסון
        {
            List<MyDict> myl = new List<MyDict>();
            myl = funcGetAjax();
            return Json(myl, JsonRequestBehavior.AllowGet);
        }
        private List<MyDict> funcGetAjax()//פונקציה לטעינת כל סיכומי הביקור והכנסתם לאובייקט
        {   Summary s;
            List<MyDict> myl = new List<MyDict>();
            MyDict j;
            List<DateTime> l2 = new List<DateTime>();
            List<Reccomendations> ListRecommendations;
            l2 = b.get_updating(Session["Patiant"].ToString());// הרצת פרוצדורה לטעינת תאריכי עדכון קודמים         
            foreach (var item in l2)
            {
                s = b.getSummary(item, Session["Patiant"].ToString());//הפעלת פרוצדורה לטעינת סיכום בהתאם לתאריך
                j = new MyDict();
                ListRecommendations = new List<Reccomendations>();
                ListRecommendations = b.getReccomendations(item, Session["Patiant"].ToString());
                DateTime t = new DateTime(item.Year, item.Month, item.Day);
                j.date = t.ToShortDateString();
                j.list = ListRecommendations;
                j.followUp = s.FollowUp;
                j.mentioned = s.Mentioned == true ? 0 : 1;
                myl.Add(j);
            }
            return myl;
        }

    
 }
    class MyDict
    {
       
        public string date{ get; set; }
        public List<Reccomendations> list { get; set; }
        public int followUp { get; set; }
        public int mentioned { get; set; }

   
    }
}
