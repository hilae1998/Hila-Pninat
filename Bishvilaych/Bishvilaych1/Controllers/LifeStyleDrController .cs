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
        LifeStyle b = new LifeStyle();
        public ActionResult LifeStyleDr()
        {
            Session.Timeout += 20;
            if (Session["Patiant"] == null)
            {
                return RedirectToAction("Login", "Account");
            }
            ViewBag.status4 = Session["status4"];
            Session["status4"] = "";
            string id = Session["Patiant"].ToString(); //id - from Patiant controler
            BLDr_LigeStlye BL = new BLDr_LigeStlye();
            LifeStyle p = BL.Get_LifeStyle(DateTime.Today, id); //return the ditails of the patiant
            return View(p); //send the object to the view
        }

        //    Bi
        //    BiT

        [HttpPost]
        public ActionResult LifeStyleDr(LifeStyle pg)
        {
            try
            {
                string id = Session["Patiant"].ToString();//id - from Patiant controler
                BLDr_LigeStlye bl = new BLDr_LigeStlye();
                int result = bl.AddOrUpdatelifestyle(id, DateTime.Today, pg); // update the db with the new ditails
                if (result == 0)
                {
                    Session["status4"] = "הנתונים נשמרו בהצלחה";
                    return RedirectToAction("LifeStyleDr", "LifeStyleDr", new { pg });
                }
                else
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

        [HttpGet]
        public ActionResult getLastVisit()
        {
            BLUpdateDateAndCode blu = new BLUpdateDateAndCode();
            BLDr_LigeStlye blp = new BLDr_LigeStlye();
            // אוסף של כל פאסטגניקולוגי של מטופל ספציפי
            List<LifeStyle> AllDataofLife = blp.Get_LifeStyleById(Session["Patiant"].ToString());
            //  אוסף של כל התאריכים וקודי התאריכים של מטופל ספציפי 
            List<Updatings> Allupdate = blu.getUpdateDateAndcode(Session["Patiant"].ToString());
            var an = DateTime.Today;
            ViewBag.now = an.ToString();


            // אוסף של כל הפאסטים והתאריכים של כל אחד של כל מטופל 
            List<aaa> lll = new List<aaa>();
            aaa a;
            foreach (var item in Allupdate)
            {
                a = new aaa();
                a.date = item.UpdateDate.ToShortDateString();
                LifeStyle d = (LifeStyle)AllDataofLife.FirstOrDefault(x => x.UpdateCode == item.Code);
                a.mylife = d;
                lll.Add(a);
                // AllDataofLifeAndDates.Add(item.UpdateDate.ToString(), AllDataofLife.Where(x => x.UpdateCode == item.Code).Single());
            }

            // מחזיר אוסף דיקשינרי של אוסף תאריכים ואוסף של פאסטגניקולוגי של מטופל ספציפי
            return Json(lll, JsonRequestBehavior.AllowGet);

        }

        class aaa
        {
            public string date { get; set; }
            public LifeStyle mylife { get; set; }
        }
    }

}








