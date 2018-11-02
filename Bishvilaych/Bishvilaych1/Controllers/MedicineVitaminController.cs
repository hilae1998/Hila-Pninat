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
    public class MedicineVitaminController : Controller
    {
        public ActionResult MedicineVitamin()
        {
            return View();
        }

        [HttpPost]
        public ActionResult addMedicineVitamin(Medicines mv)
        {

            BL_AddMedicineVitaminAndSensitivities b = new BL_AddMedicineVitaminAndSensitivities();

            return View(mv);
        }

        [HttpPost]
        public ActionResult updateMedicineVitamin(Medicines mv)
        {

            BL_AddMedicineVitaminAndSensitivities b = new BL_AddMedicineVitaminAndSensitivities();

            string result = b.Update_MedicineVitamin(mv.Influens, mv.Vitamin, mv.Active, mv.GivenKind, mv.Quantity, mv.Days, mv.GivenOn, mv.Text);

            return View();
        }
    }
}
