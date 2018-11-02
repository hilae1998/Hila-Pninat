using System.Collections.Generic;
using System.Web.Mvc;
using BussinesLayer;

namespace Bishvilaych.Controllers//Maayan
{
    public class MedicinesSensitiveController:Controller
    {
        public ActionResult MedicinesSensitive()
        {
            string id = Session["Patiant"].ToString();
            BLMedicines blm = new BLMedicines();
            BLSensitivities bls = new BLSensitivities();
            List< Medicines> m = blm.GetAllMedicines(id);
            List<Sensitivities> s = bls.GetAllSensitivities(id);

            MyMedicinesSensitive mms = new MyMedicinesSensitive();
            mms.MyM = m;
            mms.MyS = s;

            return View(mms);
        }
    }

    public class MyMedicinesSensitive
    {
        public List<Medicines> MyM { get; set; }
        public List<Sensitivities> MyS { get; set; }
    }


}