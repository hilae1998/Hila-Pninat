using DataAccessLayer;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BussinessLayer
{
   public class BLLifeStyleNutritionist
    {
        public LifeStyle getLifeStyleNutritionist( string id,DateTime date)
        {
            DALifeStyleNutritionist dm = new DALifeStyleNutritionist();
            ListDictionary Params = new ListDictionary();
            Params.Add("@id", BLCtrl.sendString(id, ""));
            Params.Add("@date", BLCtrl.sendDateTime(date, DateTime.Today));
            
            DataSet ds = dm.getLifeStyleNutritionist(Params);
            LifeStyle p = new LifeStyle();
            //p.UpdateCode = ds.Tables[0].Rows[0].Field<int>( "UpdateCode", 0);  
            //p.UpdateCode = BLCtrl.getFloat(ds.Tables[0].Rows[0], "UpdateCode", 0);
            p.UpdateCode =BLCtrl.getInt( ds.Tables[0].Rows[0],"UpdateCode",0);
            p.Height = BLCtrl.getFloat(ds.Tables[0].Rows[0], "Height",0);
            p.Wieght = BLCtrl.getFloat(ds.Tables[0].Rows[0], "Wheight", 0);
            p.BMI = BLCtrl.getInt(ds.Tables[0].Rows[0], "BMI", 0);
            p.BloodPressure = BLCtrl.getString(ds.Tables[0].Rows[0], "BloodPressure", "");
            p.pulse = BLCtrl.getInt(ds.Tables[0].Rows[0], "Pulse", 0);
            p.NotEat = BLCtrl.getBool(ds.Tables[0].Rows[0], "NotEat", false);
            p.NotEatT = BLCtrl.getString(ds.Tables[0].Rows[0], "NotEatT", "");
            p.Meals = BLCtrl.getInt(ds.Tables[0].Rows[0], "Meals", 0);
            p.Fruits = BLCtrl.getInt(ds.Tables[0].Rows[0], "Fruits", 0);
            p.Vegetables = BLCtrl.getInt(ds.Tables[0].Rows[0], "Vegetables", 0);
            p.Dairy = BLCtrl.getBool(ds.Tables[0].Rows[0], "Dairy", false);
            p.Water = BLCtrl.getInt(ds.Tables[0].Rows[0], "Water", 0);
            p.Diet = BLCtrl.getBool(ds.Tables[0].Rows[0], "Diet", false);
            p.DietT = BLCtrl.getString(ds.Tables[0].Rows[0], "DietT", "");
            p.SleepingHours = BLCtrl.getFloat(ds.Tables[0].Rows[0], "SleepingHours", 0);
            p.Activity = BLCtrl.getBool(ds.Tables[0].Rows[0], "Activity", false);
            return p;
        }

        public List<LifeStyle> getLifeStyleNutritionistById(string id)
        {

            DALifeStyleNutritionist dm = new DALifeStyleNutritionist();
            ListDictionary Params = new ListDictionary();            
            Params.Add("@id", id);
            DataSet ds = dm.getLifeStyleNutritionist(Params);
            LifeStyle p = new LifeStyle();
            List<LifeStyle> l = new List<LifeStyle>();

            foreach (DataRow item in ds.Tables[0].Rows)
            {
                p = new LifeStyle();
                p.UpdateCode = BLCtrl.getInt(item, "UpdateCode", 0);
                p.Height = BLCtrl.getFloat(item, "Height", 0);
                p.Wieght = BLCtrl.getFloat(item, "Wheight", 0);
                p.BMI = BLCtrl.getInt(item, "BMI", 0);
                p.BloodPressure = BLCtrl.getString(item, "BloodPressure", "");
                p.pulse = BLCtrl.getInt(item, "Pulse", 0);
                p.NotEat = BLCtrl.getBool(item, "NotEat", false);
                p.NotEatT = BLCtrl.getString(item, "NotEatT", "");
                p.Meals = BLCtrl.getInt(item, "Meals", 0);
                p.Fruits = BLCtrl.getInt(item, "Fruits", 0);
                p.Vegetables = BLCtrl.getInt(item, "Vegetables", 0);
                p.Dairy = BLCtrl.getBool(item, "Dairy", false);
                p.Water = BLCtrl.getInt(item, "Water", 0);
                p.Diet = BLCtrl.getBool(item, "Diet", false);
                p.DietT = BLCtrl.getString(item, "DietT", "");
                p.SleepingHours = BLCtrl.getFloat(item, "SleepingHours", 0);
                p.Activity = BLCtrl.getBool(item, "Activity", false);

                l.Add(p);
            }
            return l;
        }


        public int addOrUpdateLifeStyleNutritionist(float height, float weight, int bmi, string blood,
         int pulse, bool noteat, string noteatt, int meals, int fruits, int vegetables, bool dairy,
         int water, bool diet, string diett, float sleeping,
         bool activity, DateTime dt, string id)
        {
            DALifeStyleNutritionist dm = new DALifeStyleNutritionist();
            ListDictionary Params = new ListDictionary();
            Params.Add("@height", BLCtrl.sendFloat(height,0));
            Params.Add("@weight", BLCtrl.sendFloat(weight,0));
            Params.Add("@bmi", BLCtrl.sendInt(bmi,0));
            Params.Add("@blood", BLCtrl.sendString(blood,""));
            Params.Add("@pulse", BLCtrl.sendInt(pulse,0));
            Params.Add("@noteat", BLCtrl.sendBool(noteat, false));
            Params.Add("@noteatt", BLCtrl.sendString(noteatt,""));
            Params.Add("@meals", BLCtrl.sendInt(meals,0));
            Params.Add("@fruits", BLCtrl.sendInt(fruits,0));
            Params.Add("@vegetables", BLCtrl.sendInt(vegetables,0));
            Params.Add("@dairy", BLCtrl.sendBool(dairy, false));
            Params.Add("@water", BLCtrl.sendInt(water,0));
            Params.Add("@diet", BLCtrl.sendBool(diet, false));
            Params.Add("@diett", BLCtrl.sendString(diett,""));
            Params.Add("@sleeping", BLCtrl.sendFloat(sleeping,0));
            Params.Add("@activity ", BLCtrl.sendBool(activity, false));
            Params.Add("@dt", BLCtrl.sendDateTime(dt,DateTime.Today));
            Params.Add("@id", BLCtrl.sendString(id,""));
            int result = dm.addOrUpdateLifeStyleNutritionist(Params);
            return result;
        }



    }
}
