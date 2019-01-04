using BussinesLayer;
using BussinessLayer;
using System.Collections.Generic;
using System.Web.Mvc;


namespace Bishvilaych.Controllers
{
    public class ReciepitsListOfCustomersController : Controller
    {
        [HttpGet]
        public ActionResult ReciepitsListOfCustomers()
        {
            BLReceipt bl = new BLReceipt();
            //List<receipt> result = bl.getReceipt(Session["Customers"].ToString());
            List<receipt> result = bl.getReceipt("123456789");
            BLGetCustomersById blc = new BLGetCustomersById();
            //Customers c = blc.getCustomersById(Session["Customers"].ToString());
            Customers c = blc.getCustomersById("123456789");
            MyCustomersRecepitModels model = new MyCustomersRecepitModels();
            model.recepit = result;
            model.MyC = c;
            return View(model);
        }
    }

    public class MyCustomersRecepitModels
    {
        public List<receipt> recepit { get; set; }
        public Customers MyC { get; set; }
    }
}
