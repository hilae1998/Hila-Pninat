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
    public class SensitivesController : Controller
    {
        public ActionResult Sensitive()
        {
            return View();
        }

        [HttpPost]
       public ActionResult addSensitivities(Sensitivities s)
        { 
       
          BL_AddMedicineVitaminAndSensitivities b = 
                new BL_AddMedicineVitaminAndSensitivities();
       
          int result = b.Add_Sensitivities(s.Sensitivity, s.Medicine, s.Influenss, s.DesicionDate,s.Desided);
       
          return View();
       }
        
        [HttpPost]
        public ActionResult UpdateSensitives(Sensitivities s)
        {
            BL_AddMedicineVitaminAndSensitivities b = 
                new BL_AddMedicineVitaminAndSensitivities();
            return View(s);
        }
    }
}
