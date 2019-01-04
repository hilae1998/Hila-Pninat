using BussinesLayer;
using BussinessLayer;
using System;
using System.Collections.Generic;
using System.Web.Mvc;
//Ortal 
namespace Bishvilaych.Controllers
{
    public class PhyicalExamController : Controller
    {
        BLVisitSummery b = new BLVisitSummery();
        BLPhyicalExam p = new BLPhyicalExam();
        //כשנכנס נפתח דף של היום הנוכחי חדש או מלא
        public ActionResult PhyicalExam()
        {
            if (Session["Patiant"] == null)
            {
                return RedirectToAction("Login", "Account");
            }
            string id = Session["Patiant"].ToString();
            BLPhyicalExam b = new BLPhyicalExam();
            PhysicalExam p = b.GetPhyicalExam(DateTime.Today, id);
            return View(p);
        }

        [HttpPost]
        public ActionResult SavevPhyicalExam(PhysicalExam p)
        {
            try
            {
                BLPhyicalExam bl = new BLPhyicalExam();
                int result = bl.AddOrUpdatePhysicalExam1(DateTime.Today, Session["Patiant"].ToString(),
                p.ApearsWell, p.ApearsWellT, p.PupilsEqual, p.PupilsEqualT, p.TmNormal, p.TmNormalT, p.Oropharynx,
                p.OropharynxT, p.Atraumatic, p.AtraumaticT, p.HeentMucosa, p.HeentMucosaT, p.Supple,
                p.SuppleT, p.thyromegaly, p.thyromegalyT, p.HeartsoundsRegular, p.HeartsoundsRegularT, p.Murmur,
                p.MurmurT, p.GoodAir, p.GoodAirT, p.ClearToAuscultation, p.ClearToAuscultationT, p.SymmetricalBreast,
                p.SymmetricalBreastT, p.Palpable, p.PalpableT, p.SkinChanges, p.SkinChangesT, p.Nipple,
                p.NippleT, p.Axillary, p.AxillaryT, p.Soft, p.SoftT, p.Tender, p.TenderT,
                p.ABDdescription, p.BowelSounds, p.BowelSoundsT, p.RenalArtery, p.RenalArteryT,
                p.Masses, p.MassesT, p.Organomegaly, p.OrganomegalyT, p.SkinAbnormalities, p.SkinAbnormalitiesT,
                p.SignificantScoliosis, p.SignificantScoliosisT, p.Kyphosis, p.KyphosisT, p.Edema, p.EdemaT,
                p.EXTRash, p.EXTRashT, p.Varicosities, p.VaricositiesT, p.Pppx4, p.Pppx4T, p.PedalEdema, p.PedalEdemaT,
                p.Toes, p.ToesT, p.Pattelar, p.PattelarT, p.Gait, p.GaitT, p.Speech, p.SpeechT,
                p.Female, p.FemaleT, p.PelvicMucosa, p.Kegels, p.Cervix, p.VaginalWalls, p.VaginalWallsT, p.Pap, p.PapT);
                if (result == 0)
                    return Json("הנתונים נשמרו בהצלחה", JsonRequestBehavior.AllowGet);
                else
                    return Json("התרחשה שגיאה", JsonRequestBehavior.AllowGet);
                
            }
            catch /*Exception e*/
            {
                return View(p);
            }
        }
        public ActionResult getLastVisit()
        {
            List<MyODict> myl = new List<MyODict>();
            myl = funcGetAjax();
            return Json(myl, JsonRequestBehavior.AllowGet);
        }
        private List<MyODict> funcGetAjax()//פונקציה היוצרת לי כעין מילון אשר הקי שלו זה תאריך והוליו שלו זה בדיקה רפואית של אותו תאריך
        {

            List<DateTime> l2 = new List<DateTime>();
            l2 = b.get_updating(Session["Patiant"].ToString());//מביא לי את רשימת התאריכים
            PhysicalExam s;
            List<MyODict> myl = new List<MyODict>();
            MyODict j;
            foreach (var item in l2)//ריצה על רשימת התאריכים
            {
                s = p.GetPhyicalExam(item, Session["Patiant"].ToString());//מביא לי את בדיקה רפואית של תאריך מסוים
                j = new MyODict();//הקצאת מחלקה               
                DateTime t = new DateTime(item.Year, item.Month, item.Day);//תאריך בפורמט מסודר
                j.date = t.ToShortDateString();
                j.list = s;
               
                myl.Add(j);
            }
            return myl;
        }
  }  
         class MyODict
        {

            public string date { get; set; }
            public PhysicalExam list { get; set; }
            //public int Kegels { get; set; }
            //public int PelvicMucosa { get; set; }

        }

    
}