using BussinesLayer;
using BussinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bishvilaych.Controllers
{
    public class PatiantsController : Controller
    {
        [HttpGet]
        public ActionResult Patiants()
        {
            if (Session["UserName"] == null || Session["UserPasswerd"] == null)
            {
                return RedirectToAction("Login", "Account");
            }
            return View();
        }
        [HttpPost]
        public ActionResult Patiants(string idpatiant)
        {
            Session["IdPatiants"] = idpatiant;
            BLCheck_Patient b = new BLCheck_Patient();

            if (idpatiant.Length > 9|| idpatiant=="")
            {
                ViewBag.error = "תעודת זהות לא חוקית";
                return View();
            }
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
        [HttpGet]
        public ActionResult Demography()
        {
            if (Session["Patiant"] == null)
            {
                return RedirectToAction("Login", "Account");
            }
            ViewBag.status = Session["status"];
            Session["status"] = "";
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
        public ActionResult Demography(Patiants pat)
        {
            try
            {
                pat.Id = pat.Id.TrimEnd('/');
                BLPatiants bl = new BLPatiants();
                int result = bl.UpdatePatiant(pat.Id, pat.FirstName, pat.LastName, pat.Doctor, pat.reffered, pat.Language, pat.City, pat.Street, pat.Phone, pat.Phone2, pat.Fax, pat.Email, pat.BirthDate, pat.ContactExam, pat.ContactGinformation, pat.FathersOrigin, pat.MothersOrigin, pat.Kupah, pat.MaritalStatus, pat.Children, pat.G, pat.T, pat.P, pat.A, pat.L, pat.FollowUp, pat.Occupation, pat.followedup);
                if (result == 0)
                {
                    Session["status"] = "הנתונים נשמרו בהצלחה";
                    // return RedirectToAction("VisitReason", "VisitReason");                 
                    return RedirectToAction("Demography", "Patiants", new { pat.Id });
                }
                else
                {
                    Session["status"] = "התרחשה שגיאה";
                    // return View(pat);
                    //return View(p.Id);      
                    return RedirectToAction("Demography", "Patiants", new { pat.Id });
                }
            }
            catch
            {
                Session["status"] = "התרחשה שגיאה";
                //return View(p.Id);
                return RedirectToAction("Demography", "Patiants", new { pat.Id });
            }
        }
    }
    public class MyModels
    {
        public Patiants MyP { get; set; }
        public List<MaritalStatus> MyS { get; set; }
        public List<Kupot> MyK { get; set; }
    }
}

