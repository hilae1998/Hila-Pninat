using BussinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bishvilaych1.Controllers
{
    public class AddScreeningController : Controller
    {
        // GET: AddScreeningg
        //public ActionResult Index()
        //{
        //    return View();
        //}
        public ActionResult addScreening()
        {
            return View();
        }
        [HttpPost]
        public ActionResult addScreening(Screenings s)
        {
            //check UserName and UserPassword, if right, go to Home page.
            BL_AddScreening b = new BL_AddScreening();

            int result = b.Screening(Session["patient"].ToString(), s.Screening, s.SDate, s.Year, s.Text);
            return View();
        }
        public ActionResult UpdateScreening(Screenings s)
        {
            //check UserName and UserPassword, if right, go to Home page.
            BL_AddScreening b = new BL_AddScreening();
            int result = b.Screening(Session["patient"].ToString(), s.immunization, s.SDate, s.Year, s.Text);
            return View();
        }
    }
}