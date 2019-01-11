using BussinesLayer;
using BussinessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace Bishvilaych.Controllers
{
    public class FullListPatientsController : Controller
    {
        [HttpGet]//שליפת רשימת המטופלות העמותה
        public ActionResult PatiantsList()
        {
            try
            {
                if (Session["UserName"] == null || Session["UserPasswerd"] == null)
                {
                    return RedirectToAction("Login", "Account");
                }
                Session.Timeout += 5;//session הגדלת ה
                BLPatientList b = new BLPatientList();
                List<Patiants> p = b.getPatiants();
                return View(p);
            }
            catch (Exception)
            {
                return View();
            }

        }
        //בלחיצה על מטופל מרשימת המטופלות
        public ActionResult dossesion(string id)
        {
            Session["Patiant"] = id;
            return RedirectToAction("Demography", "Patiants");
        }
    }
}
