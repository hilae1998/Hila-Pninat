using BussinesLayer;
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
            if (i != 20)
            {

            }
            else
            {
                int result = b.Add_Patiants(s.Id, s.FirstName, s.LastName, s.Kupah);
            }                     
            return View();
        }
        [HttpGet]
        public ActionResult checkID(string ID)
        {
            BussinessLayer.BL_AddPatiants b = new BussinessLayer.BL_AddPatiants();

            int i;
            string messege;
           
            i = b.CheckID(ID);
            if (i == 20)
            {
                messege = "מטופל נכנס למערכת בהצלחה";
            }
            else
            {
                messege = "מטופל קיים במערכת";
            }
            return Json(messege, JsonRequestBehavior.AllowGet);

        }
    }
}