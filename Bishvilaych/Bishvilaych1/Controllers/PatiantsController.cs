using BussinesLayer;
using BussinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

//לאה אמסלם
//21/06/18
namespace Bishvilaych.Controllers
{
    public class PatiantsController : Controller
    {
        [HttpGet]
        public ActionResult Patiants()
        {
            //if (Session["Workers"] == null)
            //{
            //    return View("Login");
            //}
            return View();
        }
        [HttpPost]
        public ActionResult Patiants(string idpatiant)
        {
            BLCheck_Patient b = new BLCheck_Patient();
            if (b.Check_Patient(idpatiant) == 0)
            {
                Session["Patiant"] = idpatiant;
                return RedirectToAction("Demography", "Patiants");
            }
            else
            {
                ViewBag.error = "תעודת זהות לא קיימת";
                return View();
            }
        }


        //Ayala Gozlan
        [HttpGet]
        public ActionResult Demography()
        {
            BLPatiants blp = new BLPatiants();
            Patiants p = blp.getPatiantsById(Session["Patiant"].ToString());
            BLMaterialStatus blms = new BLMaterialStatus();
            List<MaritalStatus> ms = blms.getMaterialStatus();
            BLGetKupot blk = new BLGetKupot();
            List<Kupot> k = blk.getKupot();
            MyModels M = new MyModels();
            M.MyP = p;
            M.MyS = ms;
            M.MyK = k;
            return View(M);
        }

        [HttpPost]
        public ActionResult Demography(Patiants p)
        {
            try
            {
                BLPatiants bl = new BLPatiants();
                int result = bl.UpdatePatiant(p.Id, p.FirstName, p.LastName, p.Doctor, p.reffered, p.Language, p.City, p.Street, p.Phone, p.Phone2, p.Fax, p.Email, p.BirthDate, p.ContactExam, p.ContactGinformation, p.FathersOrigin, p.MothersOrigin, p.Kupah, p.MaritalStatus, p.Children, p.G, p.T, p.P, p.A, p.L,p.FollowUp, p.Occupation, p.followedup);              
                if (result == 0)
                {
                    ViewBag.err = "הנתונים נשמרו בהצלחה";
                    return RedirectToAction("VisitReason");
                }
                else
                {
                    ViewBag.err = "התרחשה שגיאה";
                    return View(p.Id);
                }
            }
           catch
            {
                return View(p.Id);
            }
        }

        public ActionResult VisitReason()
        {
            //get visitReason and all prev updatings and sent to screenn
            return View();
        }

        
    }
    public class MyModels
    {
        public Patiants MyP { get; set; }
        public List<MaritalStatus> MyS { get; set; }
        public List<Kupot> MyK { get; set; }
    }
}

