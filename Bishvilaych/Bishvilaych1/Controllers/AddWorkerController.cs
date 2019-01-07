
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
    public class AddWorkerController : Controller
    {
        public ActionResult addWorker()
        {
            return View();
        }
        [HttpPost]
        public ActionResult addWorker(Workers s)// הוספת עובד
        {
            try
            {
                BL_AddWorker b = new BL_AddWorker();
                int i = 0;
                i = b.CheckWorkerID(s.Id);
                bool check = myStatic.IsValidId(s.Id);// שליחה לפונ' לבדיקת תקינות תעודת הזהות
                if (i == 20)// אם העובד אינו קיים במערכת 
                {
                    if (check == false)// אם התעודת זהות איננה תקינה
                    {
                        s.Id = "";
                        ModelState.AddModelError("Id", "תעודת זהות אינה תקינה");
                    }
                    if (ModelState.IsValid)
                    {
                        ModelState.Remove("Id");
                        int result = b.Add_Worker(s.Id, s.FirstName, s.LastName);
                        ViewBag.message = "עובד נוסף למערכת בהצלחה";
                        return View(new Workers());
                    }
                }
                else //אם העובד קיים במערכת
                {
                    s.Id = "";
                    ModelState.AddModelError("Id", "עובד קיים במערכת");
                }
                return View(s);
            }
            catch (Exception e)
            {
                return View(s);

            }


        }
        [HttpGet]
        public ActionResult checkWorkerID(string ID)// שליחה לבדיקה אם עובד קיים/לא קיים במערכת 
        {
            try
            {
                BussinessLayer.BL_AddWorker b = new BussinessLayer.BL_AddWorker();
                int i;
                string messege;

                i = b.CheckWorkerID(ID);
                if (i == 20)
                {
                    messege = "";
                }
                else
                {
                    messege = "עובד קיים במערכת";
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