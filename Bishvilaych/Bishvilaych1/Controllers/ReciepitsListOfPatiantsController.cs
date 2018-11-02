using BussinesLayer;
using BussinessLayer;
using System.Collections.Generic;
using System.Web.Mvc;

//Ayala Gozlan

namespace Bishvilaych.Controllers
{
    public class ReciepitsListOfPatiantsController : Controller
    {
        //[HttpGet]
        public ActionResult ReciepitsListOfPatiants()
        {
            BLReceipt bl = new BLReceipt();
            List<receipt> result = bl.getReceipt(Session["Patiants"].ToString());
            BLPatiants blc = new BLPatiants();
            Patiants p = blc.getPatiantsById(Session["Patiants"].ToString());
            MyPatiantsRecepitModels model = new MyPatiantsRecepitModels();
            model.recepit = result;
            model.MyP = p;
            return View(model);
        }
    }
    public class MyPatiantsRecepitModels
    {
        public List<receipt> recepit { get; set; }
        public Patiants MyP { get; set; }
    }
}
