using BussinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bishvilaych1.Controllers
{//אורית אוחיון
    public class FullListWorkerssController : Controller
    {
        [HttpGet]
        public ActionResult WorkersList()
        {
            //check UserName and UserPassword, if right, go to Home page.
            BLWorkersList b = new BLWorkersList();

            List<Workers> p = b.getWorkers();

            return View(p);
        }
        public ActionResult dossesion(string id)
        {
            Session["WorkerDetails"] = id;
            return View("~/Views/WorkerDetails/WorkerDetails.cshtml");

        }
    }
}