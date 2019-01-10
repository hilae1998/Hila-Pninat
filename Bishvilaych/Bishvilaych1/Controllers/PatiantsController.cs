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
        public ActionResult Patiants()// כניסה לדף ראשי- מטופלות
        {
            if (Session["UserName"] == null || Session["UserPasswerd"] == null)
            {
                return RedirectToAction("Login", "Account");
            }
            return View();
        }
        [HttpPost]// כניסה לתיק הרפואי של מטופלת
        public ActionResult Patiants(string idpatiant)
        {
            try
            {
                Session.Timeout += 10;//session הגדלת ה
                Session["IdPatiants"] = idpatiant;
                BLCheck_Patient b = new BLCheck_Patient();

                if (idpatiant.Length > 9 || idpatiant == "")// תעודת זהות אינה תקינה
                {
                    ViewBag.error = "תעודת זהות לא חוקית";
                    return View();
                }
                if (b.Check_Patient(idpatiant) == 0)// כשמכניסים תעודת זהות של מטופל קיים
                {
                    Session["Patiant"] = idpatiant;
                    return RedirectToAction("Demography", "Patiants");
                }
                else// תעודת זהות של מטופל שאינו קיים
                {
                    ViewBag.error = "תעודת זהות לא קיימת";
                    return View();
                }
            }
            catch(Exception e)
            {
                return View();
            }
        }
        [HttpGet] // כניסה ללשונית פרטים דמוגרפיים של מטופלת
        public ActionResult Demography()
        {
            try
            {
                Session.Timeout += 10;
                if (Session["Patiant"] == null)
                {
                    return RedirectToAction("Login", "Account");
                }
                ViewBag.status = Session["status"];
                Session["status"] = "";
                BLPatiants blp = new BLPatiants();
                Patiants p = blp.getPatiantsById(Session["Patiant"].ToString());//שליפת נתוני המטופלת מהמסד
                BLMaterialStatus blms = new BLMaterialStatus();
                List<MaritalStatus> ms = blms.getMaterialStatus();//שליפת נתוני המטופלת מהמסד
                BLGetKupot blk = new BLGetKupot();
                List<Kupot> k = blk.getKupot();//שליפת נתוני המטופלת מהמסד
                MyModels M = new MyModels();
                M.MyP = p;
                M.MyS = ms;
                M.MyK = k;
                return View(M);
            }
            catch(Exception e)
            {
                return View();
            }
        }
        [HttpPost]// עדכון הנתונים במסד
        public ActionResult Demography(Patiants pat)
        {
            try
            {
                pat.Id = pat.Id.TrimEnd('/');
                BLPatiants bl = new BLPatiants();
                int result = bl.UpdatePatiant(pat.Id, pat.FirstName, pat.LastName, pat.Doctor, pat.reffered, pat.Language, pat.City, pat.Street, pat.Phone, pat.Phone2, pat.Fax, pat.Email, pat.BirthDate, pat.ContactExam, pat.ContactGinformation, pat.FathersOrigin, pat.MothersOrigin, pat.Kupah, pat.MaritalStatus, pat.Children, pat.G, pat.T, pat.P, pat.A, pat.L, pat.FollowUp, pat.Occupation, pat.followedup);
                if (result == 0)// שמירת הנתונים צלחה
                {
                    Session["status"] = "הנתונים נשמרו בהצלחה";                
                    return RedirectToAction("Demography", "Patiants", new { pat.Id });
                }
                else// כשל בשמירת הנתונים
                {
                    Session["status"] = "התרחשה שגיאה";    
                    return RedirectToAction("Demography", "Patiants", new { pat.Id });
                }
            }
            catch
            {
                Session["status"] = "התרחשה שגיאה";
                return RedirectToAction("Demography", "Patiants", new { pat.Id });
            }
        }
    }
    public class MyModels // מודל של פרטים דמוגרפיים המורכב משלושה מודלים
    {
        public Patiants MyP { get; set; }
        public List<MaritalStatus> MyS { get; set; }
        public List<Kupot> MyK { get; set; }
    }
}

