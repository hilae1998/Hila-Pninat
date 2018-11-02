using BussinesLayer;
using BussinessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//לאה אמסלם
//31/5/18
namespace Bishvilaych.Controllers
{
    public class FollowedPatiantController : Controller
    {
        [HttpGet]
        public ActionResult Patiants()
        {
            BLFolloaed_patient b = new BLFolloaed_patient();
            List<Patiants> result = b.getFolloaed_patient();
            return View(result);

        }
    }
}
