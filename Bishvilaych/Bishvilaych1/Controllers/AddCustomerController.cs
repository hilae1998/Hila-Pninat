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
        // GET: AddCustomer
        public ActionResult AddCustomer()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddCustomer(Customers c)
        {
            BLAddCustomer bl = new BLAddCustomer();
            int i = 0;
            i = bl.CheckCustomerID(c.Id);
            bool check = myStatic.IsValidId(c.Id);
            if (i == 20)
            {
                if (check == false)
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
            else
            {
                c.Id = "";
                ModelState.AddModelError("Id", "לקוח קיים במערכת");
            }
            return View(c);
        }

        [HttpGet]
        public ActionResult checkCustomerID(string ID)
        {
            BLAddCustomer b = new BLAddCustomer();

            int i;
            string messege;

            i = b.CheckCustomerID(ID);
            if (i == 20)
            {
                messege = "";
            }
            else
            {
                messege = "לקוח קיים במערכת";
            }
            return Json(messege, JsonRequestBehavior.AllowGet);
        }


        //[System.Web.Services.WebMethod]
        //public bool LegalId(string s)
        //{
        //    int x;
        //    if (!int.TryParse(s, out x))
        //        return false;
        //    if (s.Length < 5 || s.Length > 9)
        //        return false;
        //    for (int i = s.Length; i < 9; i++)
        //        s = "0" + s;
        //    int sum = 0;
        //    for (int i = 0; i < 9; i++)
        //    {
        //        int k = ((i % 2) + 1) * (Convert.ToInt32(s[i]) - '0');
        //        if (k > 9)
        //            k -= 9;
        //        sum += k;

        //    }
        //    return sum % 10 == 0;
        //}
    }
}