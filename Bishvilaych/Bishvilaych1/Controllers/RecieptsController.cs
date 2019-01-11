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
        [HttpPost]
        public ActionResult GetTheData(int PageNumber,int PageSize)//Lazy Load
        {
            try
            {
                BLReceipt bl = new BLReceipt();
                var result = bl.getAllReceipt(PageNumber, PageSize);
                if(result.Count!=0)
                    return Json(result,JsonRequestBehavior.AllowGet);
                else//נגמרו הרשומות
                    return Json("", JsonRequestBehavior.AllowGet);
            }
            catch(Exception e)
            {
                return Json("", JsonRequestBehavior.AllowGet);
            }

}
    }
}