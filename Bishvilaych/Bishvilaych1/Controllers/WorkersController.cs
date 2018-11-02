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
    public class WorkersController : Controller
    {
        [HttpGet]
        public ActionResult Workers()
        {
            //if (Session["WorkerDetails"] == null)
            //{
            //    return View("Login");
            //}
            return View();
        }

        [HttpPost]
        public ActionResult Workers(string idWorkers)
        {

            BLCheck_Workers b = new BLCheck_Workers();
            if (b.Check_Workers(idWorkers) == 0)
            {
                Session["WorkerDetails"] = idWorkers;
                return RedirectToAction("WorkerDetails", "WorkerDetails");
            }
            else
            {
                if (b.Check_Workers(idWorkers) == 1)
                    ViewBag.error = "תעודת זהות לא קיימת";
            }               
            return View("Workers");                         
        }
    }
}
