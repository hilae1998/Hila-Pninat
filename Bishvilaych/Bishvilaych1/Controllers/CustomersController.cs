using BussinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bishvilaych.Controllers
{
    public class CustomersController : Controller
    {
        [HttpGet]
        public ActionResult Costomers()
        {
            if (Session["UserName"] == null || Session["UserPasswerd"] == null)
            {
                return RedirectToAction("Login", "Account");
            }
            return View();
        }
        [HttpPost]
        public ActionResult Costomers(string idCustomer)
        {
            Session.Timeout += 10;//session הגדלת ה
            try
            {
                BLCheck_Customers b = new BLCheck_Customers();
                if (idCustomer.Length > 9 || idCustomer == "")// תעודת זהות אינה תקינה
                {
                    ViewBag.error = "תעודת זהות לא חוקית";
                    return View();
                }

                if (b.Check_Customers(idCustomer) == 0)// כשמכניסים תעודת זהות של לקוח קיים
                {
                    Session["Customers"] = idCustomer;
                    return RedirectToAction("ReciepitsListOfCustomers", "ReciepitsListOfCustomers");
                }
                else // תעודת זהות של לקוחה שאינה קיימת
                {
                    ViewBag.error = "תעודת זהות לא קיימת";
                    return View();
                }
            }
            catch (Exception)
            {
                return View();
            }

        }
    }
}
