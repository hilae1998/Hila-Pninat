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
    public class FullListworkerController : Controller
    {
        [HttpGet]
        public ActionResult WorkersList()
        {
            //check UserName and UserPassword, if right, go to Home page.
            BLWorkersList b = new BLWorkersList();

            List<Workers> p = b.getWorkers();

            return View(p);
        }
    }
}
