using BussinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bishvilaych1.Controllers
{
    public class AddImmusationController : Controller
    {

        public ActionResult AddImmusations()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddImmusations(Screenings s)
        {
            //check UserName and UserPassword, if right, go to Home page.
            BL_AddImmunization b = new BL_AddImmunization();
            int result = b.Add_Immunization(Session["patient"].ToString(), s.immunization, s.SDate, s.Year, s.Text);
            return View();
        }

        //public ActionResult UpdateImmusations(Screenings s)
        //{
        //    //check UserName and UserPassword, if right, go to Home page.
        //    BL_AddImmunization b = new BL_AddImmunization();
        //    int result = b.Add_Immunization(s.immunization, s.SDate, s.Year, s.Text);
        //    return View();
        //}
        public class MyModels
        {
            public List<immunizations> Myi { get; set; }
        }

    }
}