using BussinesLayer;
using BussinessLayer;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;


namespace Bishvilaych.Controllers
{
    public class ReciepitsListOfCustomersController : Controller
    {
        [HttpGet]
        public ActionResult ReciepitsListOfCustomers()
        {
            try
            {
                if (Session["UserName"] == null || Session["UserPasswerd"] == null)
                {
                    return RedirectToAction("Login", "Account");
                }
                //if (Session["Patiant"] == null)
                //{
                //    return RedirectToAction("Login", "Account");
                //}
                Session.Timeout += 10;
                BLReceipt bl = new BLReceipt();
                List<receipt> NewReceiptList = new List<receipt>();//קבלות ממוינות 
                List<receipt> result = bl.getReceipt(Session["Customers"].ToString(), "c");
                if (result != null && result.Count > 1)//מיון תוצאות
                {

                    var GroupResult = result.GroupBy(gro => new { gro.receiptNum }).Select(xx => new { xx.Key.receiptNum }).ToList();
                    foreach (var rec in GroupResult)
                    {
                        double sum = 0;
                        foreach (var itemInResult in result)//סכימת תשלומים לקבלה אחת
                        {
                            if (itemInResult.receiptNum == rec.receiptNum)
                                sum += itemInResult.Sum;
                        }
                        var SingleReceipt = result.FirstOrDefault(xxx => xxx.receiptNum == rec.receiptNum);//לוקחים רשומה אחת והופכים אותה לקבלה מאוחדת
                        SingleReceipt.Sum = sum;//עדכון הסכום הכולל של כל התשלומים לקבלה
                        NewReceiptList.Add(SingleReceipt);
                    }

                }
                else
                {
                    if (result!=null && result.Count != 0)
                        NewReceiptList.Add(result.FirstOrDefault());
                }

                BLGetCustomersById blc = new BLGetCustomersById();
                MyCustomersRecepitModels model = new MyCustomersRecepitModels();
                model.recepit = NewReceiptList;
                Customers c = blc.getCustomersById(Session["Customers"].ToString());
                model.MyC = c;
                return View(model);
            }
            catch
            {
                MyPatiantsRecepitModels model = new MyPatiantsRecepitModels();
                return View(model);
            }
        }
    }

    public class MyCustomersRecepitModels
    {
        public List<receipt> recepit { get; set; }
        public Customers MyC { get; set; }
    }
}
