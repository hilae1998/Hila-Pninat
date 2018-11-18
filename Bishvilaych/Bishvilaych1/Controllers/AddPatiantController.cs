﻿using BussinesLayer;
using BussinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//אושרית אביוב
namespace Bishvilaych.Controllers
{
    public class AddPatiantController : Controller
    {
        public ActionResult addPatiant()
        {
            return View();
        }

        [HttpPost]
        public ActionResult addPatiant(Patiants s)
        {
            //check UserName and UserPassword, if right, go to Home page.
            BL_AddPatiants b = new BL_AddPatiants();
            int i = 0;
            i = b.CheckID(s.Id);
            if (i == 20)
            {
                if (ModelState.IsValid)
                {
                    int result = b.Add_Patiants(s.Id, s.FirstName, s.LastName, s.Kupah);
                    ViewBag.message = "מטופל נוסף למערכת בהצלחה";
                    return View(new Patiants());
                }
            }
            else
            {
                s.Id = "";
                ModelState.AddModelError("Id", "מטופל קיים במערכת");
            }                     
            return View(s);
        }
        [HttpGet]
        public ActionResult checkID(string ID)
        {
            BL_AddPatiants b = new BL_AddPatiants();

            int i;
            string messege;
           
            i = b.CheckID(ID);
            if (i == 20)
            {
                messege = "";
            }
            else
            {
                messege = "מטופל קיים במערכת";
            }
            return Json(messege, JsonRequestBehavior.AllowGet);

        }
    }
}