using BussinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//לאה אמסלם
// 24/06/18
namespace Bishvilaych.Controllers
{
    public class CustomersController : Controller
    {
        [HttpGet]
        public ActionResult Costomers()
        {
            //if (Session["Workers"] == null)
            //{
            //    return View("Login");
            //}
            return View();
        }
        [HttpPost]
        public ActionResult Costomers(string idCustomer)
        {

            BLCheck_Customers b = new BLCheck_Customers();
            if (b.Check_Customers(idCustomer) == 0)
            {
                Session["Customers"] = idCustomer;               
                return RedirectToAction("ReciepitsListOfCustomers", "ReciepitsListOfCustomers");
            }
            else
            {
                if (b.Check_Customers(idCustomer) == 1)
                    ViewBag.error = "תעודת זהות לא קיימת";
            }
            return View("Costomers");
        }
    }
}
