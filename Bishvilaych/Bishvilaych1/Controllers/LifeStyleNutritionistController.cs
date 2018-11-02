using BussinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;


namespace Bishvilaych.Controllers
{

    public class LifeStyleNutritionistController : Controller
    {
        //the first time with the date of today
        //id from the session   
        [HttpGet]
        public ActionResult LifeStyleNutritionist()
        {
            if (Session["Patiant"] == null)
            {
                return RedirectToAction("Login", "Account");
            }  
            BLLifeStyleNutritionist lsn = new BLLifeStyleNutritionist();
            LifeStyle ls = lsn.getLifeStyleNutritionist(Session["Patiant"].ToString(),DateTime.Today);
            return View(ls);
        }

        [HttpPost]
        public ActionResult LifeStyleNutritionist(LifeStyle ls)
        {
            try
            {
                BLLifeStyleNutritionist lsn = new BLLifeStyleNutritionist();
                int result = lsn.addOrUpdateLifeStyleNutritionist((float)ls.Height, (float)ls.Wieght, ls.BMI,
                    ls.BloodPressure, ls.pulse, ls.NotEat, ls.NotEatT, ls.Meals, ls.Fruits, ls.Vegetables,
                    ls.Dairy, ls.Water, ls.Diet, ls.DietT, (float)ls.SleepingHours, ls.Activity, DateTime.Today, Session["Patiant"].ToString());
                if (result == 0)
                   Session["message"] = "הנתונים נוספו בהצלחה";
                else
                   Session["message"] = "שגיאה בהוספת הנתונים";                             
            }
            catch (Exception)
            {
                return View(ls);
            }
            return View(ls);
        }

        public ActionResult AllDates()
        {
            BLLifeStyleNutritionist bl = new BLLifeStyleNutritionist();
            BLUpdateDateAndCode bldc = new BLUpdateDateAndCode();
            List<Updatings> allUpd = bldc.getUpdateDateAndcode(Session["Patiant"].ToString());
            List<LifeStyle> allLife = bl.getLifeStyleNutritionistById(Session["Patiant"].ToString());
            Dictionary<DateTime, LifeStyle> allDatesAndLife = new Dictionary<DateTime, LifeStyle>();
            foreach (var item in allUpd)
            {
                allDatesAndLife.Add(item.UpdateDate, allLife.Where(x => x.UpdateCode == item.Code).Single());
            }

            return Json(allDatesAndLife, JsonRequestBehavior.AllowGet);
        }




       


    }

}
