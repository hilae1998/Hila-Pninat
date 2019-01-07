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
            return View();
        }
        [HttpPost]
        public ActionResult AddReceipt(receipt r)
        {
            BLAddReceipt bl = new BLAddReceipt();
            int result = bl.AddOrUpdateReceipt(r.receiptDate, r.receiptNum, r.Sum, r.PayBy,
                r.chequaNum, r.Bank, r.PaymentNum, r.Branch, r.BankAccount, r.CardsKind, r.CreditCard,
                r.Validity, r.name, Session["Customers"].ToString());   
            return View();
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
