using BussinesLayer;
using BussinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bishvilaych1.Models;
namespace Bishvilaych.Controllers
{
    public class AddPatiantController : Controller
    {
        public ActionResult addPatiant()
        {
            if (Session["UserName"] == null || Session["UserPasswerd"] == null)
            {
                return RedirectToAction("Login", "Account");
            }
            return View();
        }
        [HttpPost]
        public ActionResult addPatiant(Patiants s) //הוספת מטופל      
        {
            try
            {
                Session.Timeout += 10;//session הגדלת ה
                BL_AddPatiants b = new BL_AddPatiants();
                int i = 0;
                i = b.CheckID(s.Id);
                bool check = myStatic.IsValidId(s.Id);// שליחה לפונ' לבדיקת תקינות תעודת הזהות
                if (i == 20)// אם המטופל אינו קיים במערכת 
                {
                    if (check == false)// אם התעודת זהות איננה תקינה
                    {
                        s.Id = "";
                        ModelState.AddModelError("Id", "תעודת זהות אינה תקינה");
                    }
                    if (ModelState.IsValid)
                    {
                        ModelState.Remove("Id");
                        int result = b.Add_Patiants(s.Id, s.FirstName, s.LastName, s.Kupah);
                        ViewBag.message = "מטופל נוסף למערכת בהצלחה";
                        return View(new Patiants());
                    }
                }
                else //אם המטופל קיים במערכת
                {
                    s.Id = "";
                    ModelState.AddModelError("Id", "מטופל קיים במערכת");
                }
                return View(s);
            }
            catch (Exception e)
            {
                return View(s);
            }
           
        }

        [HttpGet]
        public ActionResult checkID(string ID)// שליחה לבדיקה אם מטופל קיים/לא קיים במערכת 
        {
            try
            {
                BL_AddPatiants b = new BL_AddPatiants();

                int i;
                string messege;

                i = b.CheckID(ID);
                if (i == 20)
                {
                    messege = "";
                }
                else
                {
                    messege = "מטופל קיים במערכת";
                }
                return Json(messege, JsonRequestBehavior.AllowGet);
            }
            catch (Exception e)
            {
                return Json(e, JsonRequestBehavior.AllowGet);
            }

        }
    }
}