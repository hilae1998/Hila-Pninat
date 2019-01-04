using BussinesLayer;
using BussinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Bishvilaych.Controllers
{
    public class DiagnozeController : Controller
    {
        public ActionResult Diagnoze()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Diagnoze(Diagnozes d)
        {
            BL_AddDiagnozeAndHospitalization b = new BL_AddDiagnozeAndHospitalization();
            d.By = Convert.ToInt32(Session["auth"]);
            BLPatiants p = new BLPatiants();
            d.PatiantCode=  p.getPatiantsById(Convert.ToString(Session["IdPatiants"])).Code;
            int result = b.Add_Diagnoze(d.Diagnoze, d.Status, d.BeginDate, d.EndDate);

            return RedirectToAction("PastMedical", "PastMedical");
            //Add_Diagnoze להוסיף אבחון למסד נתונים
        }
        public ActionResult updateDiagnoze()
        {
            return View();
        }
        public ActionResult updateDiagnoze(Diagnozes d)
        {
            BL_AddDiagnozeAndHospitalization b = new BL_AddDiagnozeAndHospitalization();
            int result = b.Update_Diagnoze(d.Diagnoze, d.Status, d.BeginDate, d.EndDate);

            return RedirectToAction("PastMedical", "PastMedical");
        }
    }
}


