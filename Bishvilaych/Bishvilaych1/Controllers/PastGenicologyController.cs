using BussinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
//Pninat Parnasa
namespace Bishvilaych.Controllers
{

    public class PastGenicologyController : Controller
    {
        // when open the page
        //get the page of today empty or full
        public ActionResult PastGenicology()
        {
            if (Session["Patiant"] == null)
            {
                return RedirectToAction("Login", "Account");
            }
            string id = Session["Patiant"].ToString(); //id - from Patiant controler
            BLPastGenicology BL = new BLPastGenicology();
            PastGenicology p = BL.getPastGenicology(id, DateTime.Today); //return the ditails of the patiant
            return View(p); //send the object to the view
        }

        // came here when make change in the page of today
        // save the changes in the db 
        [HttpPost]
        public ActionResult PastGenicology(PastGenicology pg)
        {
            try
            {
                string id = Session["Patiant"].ToString();//id - from Patiant controler
                BLPastGenicology bl = new BLPastGenicology();
                int result = bl.addOrUpdatePastGenicology(id, DateTime.Today,
                pg.AgeOfMenarche, pg.CycleRegular, pg.CycleRegularT, pg.MenstrualSyptoms,
                pg.MenstrualSyptomsT, pg.MenopauseSyptoms, pg.MenopauseSyptomsT,
                pg.Contraception, pg.ContraceptionT);// update the db with the new ditails
                if (result == 0)
                    ViewBag.err = "הנתונים נשמרו בהצלחה";
                else
                    ViewBag.err = "התרחשה שגיאה";
                return View(pg);// return to the same view
            }
            catch
            {
                return View(pg);
            }
        }

        public ActionResult Dates()
        {
            BLUpdateDateAndCode blu = new BLUpdateDateAndCode();
            BLPastGenicology blp = new BLPastGenicology();
            // אוסף של כל פאסטגניקולוגי של מטופל ספציפי
            List<PastGenicology> Allpast = blp.getPastGeniclogiById(Session["Patiant"].ToString());
            //  אוסף של כל התאריכים וקודי התאריכים של מטופל ספציפי 
            List<Updatings> Allupdate = blu.getUpdateDateAndcode(Session["Patiant"].ToString());

            // אוסף של כל הפאסטים והתאריכים של כל אחד של כל מטופל 
            //Dictionary<DateTime, PastGenicology> AllPastAndDates = new Dictionary<DateTime, PastGenicology>();
            //foreach (var item in Allupdate)
            //{
            //    AllPastAndDates.Add(item.UpdateDate, Allpast.Where(x => x.UpdateCode == item.Code).Single());
            //}

            // אוסף של כל הפאסטים והתאריכים של כל אחד של כל מטופל 
            List <MyDict> AllPastAndDates = new List<MyDict>();
            MyDict one;
            foreach (var item in Allupdate)
            {
                one = new MyDict();
                one.date = item.UpdateDate.ToShortDateString();
                PastGenicology p = (PastGenicology)Allpast.FirstOrDefault(x => x.UpdateCode == item.Code);
                one.pastGenicology = p;
                AllPastAndDates.Add(one);
            }

            // מחזיר אוסף דיקשינרי של אוסף תאריכים ואוסף של פאסטגניקולוגי של מטופל ספציפי
            return Json(AllPastAndDates, JsonRequestBehavior.AllowGet);
        }
        class MyDict
        {
            public string date { get; set; }
            public PastGenicology pastGenicology { get; set; }
        }
    }
}
