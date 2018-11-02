using BussinesLayer;
using BussinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace Bishvilaych.Controllers
{
    public class VisitSummaryController : Controller
    {
        BLVisitSummery b = new BLVisitSummery();
        public ActionResult VisitSummary()
        {            
            return View();
        }
        [HttpPost]
        public ActionResult SavevisitSummary(Reccomendations[] a, Summary[] b)
        {

            BussinessLayer.BLVisitSummery blv2 = new BussinessLayer.BLVisitSummery();
            string aj = Session["Patiant"].ToString();
            if (a != null) { 
            foreach (var item in a)
            {
               
               int result= blv2.UpdateReccomendations(DateTime.Today, Session["Patiant"].ToString(), item.Code, item.Reccomendation);
            }}
            if (b != null) { 
            foreach (var item in b)
            {
                int result2 = blv2.UpdateSummary(DateTime.Today, Session["Patiant"].ToString(), item.Mentioned, item.FollowUp);
            }}
            return  RedirectToAction ("VisitSummary");

        }

       [HttpGet]
        public ActionResult getLastVisit()
        {
            List<MyDict> myl = new List<MyDict>();
            myl = funcGetAjax();
            return Json(myl, JsonRequestBehavior.AllowGet);
        }
        private List<MyDict> funcGetAjax()
        {
            List<DateTime> l2 = new List<DateTime>();
            l2 = b.get_updating(Session["Patiant"].ToString());
            Summary s;
            List<MyDict> myl = new List<MyDict>();
            MyDict j;
            foreach (var item in l2)
            {
                s = b.getSummary(item, Session["Patiant"].ToString());
                j = new MyDict();
                List<Reccomendations> ListRecommendations = new List<Reccomendations>();
                ListRecommendations = b.getReccomendations(item, Session["Patiant"].ToString());
                DateTime t = new DateTime(item.Year, item.Month, item.Day);
                j.date = t.ToShortDateString();
                j.list = ListRecommendations;
                j.followUp = s.FollowUp;
                j.mentioned = s.Mentioned == true ? 0 : 1;
                myl.Add(j);
            }
            return myl;
        }

    
 }
    class MyDict
    {
       
        public string date{ get; set; }
        public List<Reccomendations> list { get; set; }
        public int followUp { get; set; }
        public int mentioned { get; set; }

   
    }
}
