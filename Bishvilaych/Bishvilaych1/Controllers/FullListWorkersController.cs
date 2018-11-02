using BussinesLayer;
using BussinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bishvilaych.Controllers
{
    //אורית אוחיון 
    //עשיתח חדש
    public class FullListWorkers : Controller
    {
        //public ActionResult Login()
        //{
        //    return View();
        //}

        //[HttpPost]
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
