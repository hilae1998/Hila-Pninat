using BussinesLayer;
using BussinessLayer;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Bishvilaych.Controllers
{
    public class ReciepitsListOfPatiantsController : Controller
    {
        public ActionResult ReciepitsListOfPatiants()// כניסה לקבלות של מטופל
        {
            try
            {
                Session.Timeout += 10;
                BLReceipt bl = new BLReceipt();
                List<receipt> result = bl.getReceipt(Session["Patiants"].ToString());// שליפת הקבלות מהמסד
                BLPatiants blc = new BLPatiants();
                Patiants p = blc.getPatiantsById(Session["Patiants"].ToString());
                MyPatiantsRecepitModels model = new MyPatiantsRecepitModels();
                model.recepit = result;
                model.MyP = p;
                return View(model);
            }
            catch(Exception e)
            {
                return View();
            }
        }
    }
    public class MyPatiantsRecepitModels
    {
        public List<receipt> recepit { get; set; }
        public Patiants MyP { get; set; }
    }
}
