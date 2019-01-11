using BussinesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bishvilaych1.Controllers
{
    public class RecieptsController : Controller
    {
        //כספי
        public ActionResult Reciepts()
        {

            return View();
        }

        public JsonResult GetTheData(int PageNumber,int PageSize)//Lazy Load
        {
            try
            {
                BLReceipt bl = new BLReceipt();
                var result = bl.getAllReceipt(PageNumber, PageSize);
                return Json(result);
            }
            catch
            {
                return Json("");
            }

}
    }
}