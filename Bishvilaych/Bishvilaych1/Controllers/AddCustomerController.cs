using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BussinessLayer;
using Bishvilaych1.Models;

namespace Bishvilaych1.Controllers
{
    public class AddCustomerController : Controller
    {
        public ActionResult AddCustomer()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddCustomer(Customers c)//הוספת לקוח
        {
            try
            {
                BLAddCustomer bl = new BLAddCustomer();
                int i = 0;
                //בדיקת תקינות 
                i = bl.CheckCustomerID(c.Id);
                bool check = myStatic.IsValidId(c.Id);// שליחה לפונ' לבדיקת תקינות תעודת הזהות
                if (i == 20)// אם הלקוח אינו קיים במערכת 
                {
                    if (check == false)// אם התעודת זהות איננה תקינה
                    {
                        c.Id = "";
                        ModelState.AddModelError("Id", "תעודת זהות אינה תקינה");
                    }
                    if (ModelState.IsValid)
                    {
                        ModelState.Remove("Id");
                        int result = bl.Add_Customers(c.Id, c.FirstName, c.LastName, c.Phone, c.Phone2, c.City, c.Street);
                        ViewBag.message = "לקוח נוסף למערכת בהצלחה";
                        return View(new Customers());
                    }
                }
                else//אם הלקוח קיים במערכת
                {
                    c.Id = "";
                    ModelState.AddModelError("Id", "לקוח קיים במערכת");
                }
                return View(c);
            }
            catch (Exception e)
            {
                return View(c);
            }

        }

        [HttpGet]
        public ActionResult checkCustomerID(string ID)// שליחה לבדיקה אם לקוח קיים/לא קיים במערכת 
        {
            string messege;
            try
            {
                BLAddCustomer b = new BLAddCustomer();

                int i;


                i = b.CheckCustomerID(ID);
                if (i == 20)
                {
                    messege = "";
                }
                else
                {
                    messege = "לקוח קיים במערכת";
                }
            }
            catch (Exception e)
            {

                messege = "שגיאה:" + e;
            }

            return Json(messege, JsonRequestBehavior.AllowGet);
        }


    }
}