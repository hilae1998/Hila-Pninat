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
        public ActionResult addScreening()//מסך הוספת בדיקת עזר
        {
            return View();
        }
        [HttpPost]
        public ActionResult addScreening(Screenings s)
        {
            BL_AddScreening b = new BL_AddScreening();
            try
            {
                int result = b.Screening(Session["patient"].ToString(), s.Screening, s.SDate, s.Year, s.Text);
            }
            catch (Exception e)
            {
            }
          
            return View();
        }
        public ActionResult UpdateScreening(Screenings s)
        {
            BL_AddScreening b = new BL_AddScreening();
            int result = b.Screening(Session["patient"].ToString(), s.immunization, s.SDate, s.Year, s.Text);
            return View();
        }
    }
}