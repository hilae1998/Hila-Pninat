using BussinesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bishvilaych.Controllers
{
    public class CustomersListController : Controller
    {
        
        [HttpGet]// שליפת רשימת לקוחות העמותה
        public ActionResult Customers_()
        {
            try
            {
                if (Session["UserName"] == null || Session["UserPasswerd"] == null)
                {
                    return RedirectToAction("Login", "Account");
                }
                Session.Timeout += 5;//session הגדלת ה
                BLCustomers bc = new BLCustomers();
                List<Customers> result = bc.getCustomers();
                return View(result);
            }
            catch (Exception)
            {
                return View();
            }
        }
        // בלחיצה על לקוח מרשימת הלקוחות
        public ActionResult decision(string id)
        {
            Session["WorkerDetails"] = id;
            return RedirectToAction("ReciepitsListOfCustomers", "ReciepitsListOfCustomers");// הפניה לפרטי לקוח שעליו לחצו
        }

    }
}
