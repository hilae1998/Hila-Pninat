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
    public class AddPatiantController : Controller
    {
        public ActionResult addPatiant()
        {
            return View();
        }

        [HttpPost]
        public ActionResult addPatiant(Patiants s)
        {
            //check UserName and UserPassword, if right, go to Home page
            BL_AddPatiants b = new BL_AddPatiants();
            int i = 0;
            i = b.CheckID(s.Id);
            bool check = myStatic.IsValidId(s.Id);
            if (i == 20)// if the patiant does not exist 
            {
                if (check==false)
                {
                    s.Id = "";
                    ModelState.AddModelError("Id", "תעודת זהות אינה תקינה");
                }
                if (ModelState.IsValid)
                {
                    ModelState.Remove("Id");
                    int result = b.Add_Patiants(s.Id, s.FirstName, s.LastName, s.Kupah);
                    ViewBag.message = "מטופל נוסף למערכת בהצלחה";
                    return View(new Patiants());
                }
            }
            else // if the patiant exist
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