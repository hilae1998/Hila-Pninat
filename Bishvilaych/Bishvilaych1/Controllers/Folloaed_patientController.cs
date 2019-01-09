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
    public class FollowedPatiantController : Controller
    {
        [HttpGet] // שליפת רשימת המטופלות למקעב
        public ActionResult Patiants()
        {
            try
            {
                Session.Timeout += 5;//session הגדלת ה
                BLFolloaed_patient b = new BLFolloaed_patient();
                List<Patiants> result = b.getFolloaed_patient();
                return View(result);
            }
            catch (Exception)
            {
                return View();
            }
        }
    }
}
