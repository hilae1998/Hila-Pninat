using BussinesLayer;
using BussinessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//אורית אוחיון
//31/5/18
namespace Bishvilaych.Controllers
{
    public class FullListPatientsController : Controller
    {
        [HttpGet]
        public ActionResult PatiantsList()
        {
            BLPatientList b = new BLPatientList();

            List<Patiants> p = b.getPatiants();

            return View(p);
        }
        public ActionResult dossesion(string id)
        {
            Session["Patiant"] = id;
            return View("~/Views/Patiants/Demography.cshtml");

        }
    }
}
