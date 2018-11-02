using BussinesLayer;
using BussinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
//של איילה
namespace Bishvilaych.Controllers
{
    public class AccountController : Controller
    {
        public ActionResult Login()
       {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Workers model)
        {
            ////check UserName and UserPassword, if right, go to Home page.
            //BL_Account b = new BL_Account();

            //int result = b.Cheak_Username(0);

            //Session["auth"] = 0;
            //return RedirectToAction("Home","Home");

            BL_Acount l = new BL_Acount();
            int result = l.Cheak_Username(model.UserName, model.UserPasswerd);
            if (result == 1)
            {
                //return RedirectToAction("Costomer", "CustomerController");
                //return View();
                return RedirectToAction("Home","Home");

            }
            if (result == 0)
            {
                ViewBag.messege = "שם משתמש לא קיים";
            }
            else
                ViewBag.messege = "הסיסמא לא קיימת";
            return View("Login");
        }

    }
}
