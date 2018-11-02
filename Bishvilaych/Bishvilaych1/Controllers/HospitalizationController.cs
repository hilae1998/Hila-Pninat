using BussinesLayer;
using BussinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

//Avishag
namespace Bishvilaych.Controllers
{
    public class HospitalizationController : Controller
    {
        public ActionResult Hospitalization()
        {
            return View();
        }

        [HttpPost]
        public ActionResult addHospitalization(Hospitalizations h)
        {

            BL_AddDiagnozeAndHospitalization b = new  BL_AddDiagnozeAndHospitalization();

            int result = b.Add_Hospitalization (h.Year, h.Hospital, h.Department, h.Reason);

            return RedirectToAction("PastMedical", "PastMedical"); 
        }
        [HttpGet]
        public ActionResult updateHospitalization()
        {
            return View();
        }
        public ActionResult updateHospitalization(Hospitalizations h)
        {

            BL_AddDiagnozeAndHospitalization b = new BL_AddDiagnozeAndHospitalization();
            int result = b.Update_Hospitalization(h.Year, h.Hospital, h.Department, h.Reason);
            //return View(h);
            return RedirectToAction("PastMedical", "PastMedical");
        }
    }
}
