using BussinesLayer;
using System;
using System.Collections.Generic;
using System.Linq; 
using System.Web;
using System.Web.Mvc;
//לאה אמסלם
//31/5/18
namespace Bishvilaych.Controllers
{
    public class CustomersListController : Controller
    {
        [HttpGet]
        public ActionResult Customers_()
        {
            BLCustomers bc = new BLCustomers();
            List<Customers> result = bc.getCustomers();
            return View(result);
        }

    }
}
