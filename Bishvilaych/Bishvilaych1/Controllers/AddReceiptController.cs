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
        public ActionResult AddPatiantReceipt()
        {
            return View();
        }
        public ActionResult AddCustomerReceipt()
        {
            if (Session["UserName"] == null || Session["UserPasswerd"] == null)
            {
                return RedirectToAction("Login", "Account");
            }
            return View();
        }
        [HttpPost]
        public ActionResult AddPatiantReceipt(item FormData)//הוספת קבלה חדשה למטופלת
        {
            try
            {
                Session.Timeout += 5;//session הגדלת ה

                List<receipt> receiptList = new List<receipt>();
                receipt r = null;
                BLAddReceipt b = new BLAddReceipt();
                int recNum = b.getTopReceiptNum() + 1;//מספר הזמנה חדש
                DateTime DateR = DateTime.Now;//תאריך קבלה הוא תמיד תאריך של היום
                for (int i = 0; i < FormData.Sum.Count(); i++)//מילוי נתונים
                {
                    r = new receipt();
                    r.receiptNum = recNum;
                    r.Bank = FormData.Bank[i];
                    r.BankAccount = FormData.BankAccount[i];
                    r.Branch = FormData.Branch[i];
                    r.CardsKind = FormData.CardsKind[i];
                    r.chequaNum = FormData.chequaNum[i];
                    r.CreditCard = FormData.CreditCard[i];
                    r.name = FormData.name[i];
                    r.PayBy = FormData.PayBy[i];
                    r.PaymentNum = i + 1;
                    r.Validity = FormData.Validity[i];
                    r.receiptDate = DateR;
                    r.Sum = FormData.Sum[i];
                    receiptList.Add(r);
                }
                BLAddReceipt bl = new BLAddReceipt();
                foreach (var item in receiptList)//הכנסת שורת התשלום לטבלה בבסיס הנתונים
                {
                    int result = bl.AddPatiantReceipt(item.receiptDate, item.Sum, item.PayBy,
                    item.chequaNum, item.Bank, item.PaymentNum, item.Branch, item.BankAccount, item.CardsKind, item.CreditCard,
                    item.Validity, item.name, item.receiptNum, Session["Patiant"].ToString());
                    if (result != 0)
                    {
                        ViewBag.messege = "משהו השתבש";
                        return View();
                    }
                }
                //סגירת חלונית הוספת קבלה,רענון דף רשימת קבלות כדי לראות את הקבלה שנוספה
                TempData["messege"] = "קבלה נוספה בהצלחה";
                return Content(@"<body>
                       <script type='text/javascript'>
                         window.opener.location.reload();
                         window.close();
                       </script>
                     </body>");
            }
            catch (Exception e)
            {
                ViewBag.messege = e.ToString();
                return View();
            }


        }

        [HttpPost]
        public ActionResult AddCustomerReceipt(item FormData)//הוספת קבלה חדשה ללקוח
        {
            try
            {

                List<receipt> receiptList = new List<receipt>();
                receipt r = null;
                BLAddReceipt b = new BLAddReceipt();
                int recNum = b.getTopReceiptNum() + 1;//מספר הזמנה חדש
                DateTime DateR = DateTime.Now;//תאריך קבלה הוא תמיד תאריך של היום
                for (int i = 0; i < FormData.Sum.Count(); i++)//מילוי נתונים
                {
                    r = new receipt();
                    r.receiptNum = recNum;
                    r.Bank = FormData.Bank[i];
                    r.BankAccount = FormData.BankAccount[i];
                    r.Branch = FormData.Branch[i];
                    r.CardsKind = FormData.CardsKind[i];
                    r.chequaNum = FormData.chequaNum[i];
                    r.CreditCard = FormData.CreditCard[i];
                    r.name = FormData.name[i];
                    r.PayBy = FormData.PayBy[i];
                    r.PaymentNum = i + 1;
                    r.Validity = FormData.Validity[i];
                    r.receiptDate = DateR;
                    r.Sum = FormData.Sum[i];
                    receiptList.Add(r);
                }
                BLAddReceipt bl = new BLAddReceipt();
                foreach (var item in receiptList)//הכנסת שורת התשלום לטבלה בבסיס הנתונים
                {
                    int result = bl.AddCustomerReceipt(item.receiptDate, item.Sum, item.PayBy,
                    item.chequaNum, item.Bank, item.PaymentNum, item.Branch, item.BankAccount, item.CardsKind, item.CreditCard,
                    item.Validity, item.name, item.receiptNum, Session["Customers"].ToString());
                    if (result != 0)
                    {
                        ViewBag.messege = "משהו השתבש";
                        return View();
                    }
                }
                //סגירת חלונית הוספת קבלה,רענון דף רשימת קבלות כדי לראות את הקבלה שנוספה
                TempData["messege"] = "קבלה נוספה בהצלחה";
                return Content(@"<body>
                       <script type='text/javascript'>
                         window.opener.location.reload();
                         window.close();
                       </script>
                     </body>");
            }
            catch (Exception e)
            {
                ViewBag.messege = e.ToString();
                return View();
            }

        }

    }
    public class item
    {
        public DateTime receiptDate { get; set; }
        public double[] Sum { get; set; }
        public int[] PayBy { get; set; }
        public string[] chequaNum { get; set; }
        public int[] Bank { get; set; }
        public string[] Branch { get; set; }
        public string[] BankAccount { get; set; }
        public string[] CardsKind { get; set; }
        public string[] CreditCard { get; set; }
        public string[] Validity { get; set; }
        public string[] name { get; set; }
        public int[] PaymentNum { get; set; }
    }
}
