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
    public class FullListWorkersController : Controller
    {
        [HttpGet] 
        public ActionResult WorkersList()
        {
            //check UserName and UserPassword, if right, go to Home page.
            BLWorkersList b = new BLWorkersList();

            List<Workers> p = b.getWorkers();

            return View(p);
        }

        public ActionResult decision(string id)
        {
            Session["WorkerDetails"] = id;
            return RedirectToAction("WorkerDetails", "WorkerDetails");
        }
    }  
}
