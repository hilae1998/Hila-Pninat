using System.Collections.Generic;
using System.Web.Mvc;
using BussinesLayer;

namespace Bishvilaych.Controllers//Ma'ayan
{
    public class PastMedicalController : Controller
    {
        public ActionResult PastMedical()
        {            
            string id = Session["Patiant"].ToString();
            BLDiagnozes bld = new BLDiagnozes();
            BLHospitalizations blh = new BLHospitalizations();
            List<Diagnozes> d= bld.GetAllDiagnoze(id);
            List<Hospitalizations> h = blh.GetAllHspitalization(id);       
            MyPastMedical mpm =new MyPastMedical();
            mpm.MyD = d;
            mpm.MyH = h;
            return View(mpm);
     
        }

    }

    public class MyPastMedical
    {
        public List<Diagnozes> MyD { get; set; }
        public List<Hospitalizations> MyH { get; set; }  
       
    }




}