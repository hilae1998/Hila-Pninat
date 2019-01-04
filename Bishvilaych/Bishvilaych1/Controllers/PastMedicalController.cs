using System.Collections.Generic;
using System.Web.Mvc;
using BussinesLayer;

namespace Bishvilaych.Controllers
{
    public class PastMedicalController : Controller
    {
        [HttpGet]
        public ActionResult PastMedical()
        {
            string id = Session["Patiant"].ToString();
            BLDiagnozes bld = new BLDiagnozes();
            BLHospitalizations blh = new BLHospitalizations();
            List<Diagnozes> d = bld.GetAllDiagnoze(id);
            List<Hospitalizations> h = blh.GetAllHspitalization(id);
            MyPastMedical mpm = new MyPastMedical();
            mpm.MyD = d;
            mpm.MyH = h;
            return View(mpm);


        }
        public ActionResult Edit1(int code)
        {
            string id = Session["Patiant"].ToString();
            BLDiagnozes bld = new BLDiagnozes();
            List<Diagnozes> d = bld.GetAllDiagnoze(id);// דיאגנוז של מטופל ספציפי
            return View(d.Find(x => x.Code == code));
        }
        public ActionResult Updete1(Diagnozes d)
        {
            string id = Session["Patiant"].ToString();
            BLDiagnozes bld = new BLDiagnozes();
            int result=bld.UpdateDiagnoze(d, id);
            return RedirectToAction("PastMedical");
        }

        public ActionResult DeleteRow(int codeRow)
        {
            return Json(1, JsonRequestBehavior.AllowGet);
        }
    }
    public class MyPastMedical
    {
        public List<Diagnozes> MyD { get; set; }
        public List<Hospitalizations> MyH { get; set; }

    }
}



