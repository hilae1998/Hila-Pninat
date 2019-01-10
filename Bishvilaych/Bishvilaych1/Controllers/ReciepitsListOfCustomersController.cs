using BussinesLayer;
using BussinessLayer;
using System.Collections.Generic;
using System.Web.Mvc;


namespace Bishvilaych.Controllers
{
    public class ReciepitsListOfCustomersController : Controller
    {
        [HttpGet] 
        public ActionResult ReciepitsListOfCustomers(string id = "")
        {
            BLReceipt bl = new BLReceipt();
            BLGetCustomersById blc = new BLGetCustomersById();
            MyCustomersRecepitModels model = new MyCustomersRecepitModels();
            if (id != "" && id!=null)//תעודת זהות לא ריקה
            {
                List<receipt> result = bl.getReceipt(id,"c");
                Customers c = blc.getCustomersById(id);
                model.recepit = result;
                model.MyC = c;
            }
            else
            {

                List<receipt> result = bl.getReceipt(Session["Customers"].ToString(), "c");
                Customers c = blc.getCustomersById(Session["Customers"].ToString());

                model.recepit = result;
                model.MyC = c;
            }
            return View(model);

        }
    }

    public class MyCustomersRecepitModels
    {
        public List<receipt> recepit { get; set; }
        public Customers MyC { get; set; }
    }
}
