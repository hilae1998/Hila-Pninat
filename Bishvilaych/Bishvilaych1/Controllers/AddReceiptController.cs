using BussinesLayer;
using BussinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bishvilaych.Controllers
{
    public class AddReceiptController : Controller
    {
        public ActionResult AddReceipt()
        {
            if (Session["UserName"] == null || Session["UserPasswerd"] == null)
            {
                return RedirectToAction("Login", "Account");
            }
            return View();
        }
        [HttpPost]
        public ActionResult AddReceipt(receipt r)//הוספת קבלה חדשה
        {
            try
            {
                Session.Timeout += 5;//session הגדלת ה
                BLAddReceipt bl = new BLAddReceipt();
                int result = bl.AddOrUpdateReceipt(r.receiptDate, r.receiptNum, r.Sum, r.PayBy,
                    r.chequaNum, r.Bank, r.PaymentNum, r.Branch, r.BankAccount, r.CardsKind, r.CreditCard,
                    r.Validity, r.name, Session["Customers"].ToString());
                return View(r);
            }
            catch (Exception e)
            {
                return View(r);
            }

          
        }
        public static bool IsNum(string s)
        {
            int x;
            return int.TryParse(s, out x);
        }

        //public ActionResult getBanks()
        //{
        //    List<Banks> b = new List<Banks>();
        //    BLAddReceipt bl = new BLAddReceipt();
        //    b = bl.getAllBanks();
        //    return Json(b,JsonRequestBehavior.AllowGet);
        //}
    }
}
