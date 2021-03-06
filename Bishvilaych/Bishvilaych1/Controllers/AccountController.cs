﻿using BussinesLayer;
using BussinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
namespace Bishvilaych.Controllers
{
    public class AccountController : Controller
    {
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Workers model)// הזדהות ע"י שם משתמש וסיסמא
        {
            try
            {
                BL_Acount l = new BL_Acount();
                int result = l.Cheak_Username(model.UserName, model.UserPasswerd);
                if (result == 1)//שם המשתמש והסיסמא תקינים
                {
                    Session["UserName"] = model.UserName;
                    Session["UserPasswerd"] = model.UserPasswerd;
                    if (Session["UserName"] == null || Session["UserPasswerd"] == null)
                        return View("Login");
                    return RedirectToAction("Home", "Home");// עובר למסך ראשי
                }
                else//שם המשתמש והסיסמא אינם שגויים
                {
                    ViewBag.messege = "שם משתמש או סיסמא שגויים";
                }
                return View("Login");
            }
            catch (Exception e)//זריקת שגיאה לצד שרת
            {

                ViewBag.messege = "שגיאה" + e;
                return View("Login");
            }                         
        }

    }
}
