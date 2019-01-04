
using BussinesLayer;
using BussinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bishvilaych1.Models;
namespace Bishvilaych.Controllers
{
    public class AddWorkerController : Controller
    {
        public ActionResult addWorker()
        {
            return View();
        }

        [HttpPost]
        public ActionResult addWorker(Workers s)
        {
            //check UserName and UserPassword, if right, go to Home page.
            BL_AddWorker b = new BL_AddWorker();
            int i = 0;
            i = b.CheckWorkerID(s.Id);
            bool check = myStatic.IsValidId(s.Id);
            if (i == 20)
            {
                if (check == false)
                {
                    s.Id = "";
                    ModelState.AddModelError("Id", "תעודת זהות אינה תקינה");
                }
                if (ModelState.IsValid)
                {
                    ModelState.Remove("Id");
                    int result = b.Add_Worker(s.Id, s.FirstName, s.LastName);
                    ViewBag.message = "עובד נוסף למערכת בהצלחה";
                    return View(new Workers());
                }
            }
            else
            {
                s.Id = "";
                ModelState.AddModelError("Id", "עובד קיים במערכת");
            }
            return View(s);
        }
        [HttpGet]
        public ActionResult checkWorkerID(string ID)
        {
            BussinessLayer.BL_AddWorker b = new BussinessLayer.BL_AddWorker();

            int i;
            string messege;

            i = b.CheckWorkerID(ID);
            if (i == 20)
            {
                messege = "";
            }
            else
            {
                messege = "עובד קיים במערכת";
            }
            return Json(messege, JsonRequestBehavior.AllowGet);

        }
    }
}