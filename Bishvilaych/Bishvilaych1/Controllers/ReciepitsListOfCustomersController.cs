using BussinesLayer;
using BussinessLayer;
using System;
using System.Collections.Generic;
using System.Web.Mvc;


namespace Bishvilaych.Controllers
{
    public class ReciepitsListOfCustomersController : Controller
    {
        [HttpGet]// כניסה לקבלות של לקוחה
        public ActionResult ReciepitsListOfCustomers(string id="")
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
                BLGetCustomersById blc = new BLGetCustomersById();
                MyCustomersRecepitModels model = new MyCustomersRecepitModels();
                if (id != "")
                {
                    List<receipt> result = bl.getReceipt(id);// שליפת הקבלות מהמסד
                    Customers c = blc.getCustomersById(id);
                    model.recepit = result;
                    model.MyC = c;
                }
                else
                {
                    //List<receipt> result = bl.getReceipt(Session["Customers"].ToString());
                    List<receipt> result = bl.getReceipt("123456789");
                    //Customers c = blc.getCustomersById(Session["Customers"].ToString());
                    Customers c = blc.getCustomersById("123456789");
                    model.recepit = result;
                    model.MyC = c;
                }
                return View(model);
            }
            catch(Exception e)
            {
                return RedirectToAction("Costomers", "Customers");
            }
        }
    }
    public class MyCustomersRecepitModels
    {
        public List<receipt> recepit { get; set; }
        public Customers MyC { get; set; }
    }
}
