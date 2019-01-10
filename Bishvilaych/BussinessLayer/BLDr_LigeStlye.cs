using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BussinessLayer
{
   public class BLDr_LigeStlye
    {

        public List<LifeStyle> Get_LifeStyleById(string id)
        {
            DADr_LifeStyle dm = new DADr_LifeStyle();//הקצאת המחלקה 
            ListDictionary Params = new ListDictionary();
            //Params.Add("@date", date);//מכניס את זה לרשימה ולוקח את הפרוצדורה בSQL
            Params.Add("@id", id);
            DataSet ds = dm.getLifeStyleDrById(Params);//מקבל את המאפיין מהטבלה מהסוג שלו
            LifeStyle ls = new LifeStyle(); //הקצאה מסוג הטבלה
            List<LifeStyle> pgl = new List<LifeStyle>();


            //המרה של המאפיין מטיפוס שלו לטיפוס של המחלקה

            foreach (DataRow item in ds.Tables[0].Rows)
            {
                ls = new LifeStyle();
                ls.UpdateCode = BLCtrl.getInt(item, "UpdateCode", 0);//ask
                ls.Acohol = BLCtrl.getBool(item, "Alcohol", false);
                ls.AcoholT = BLCtrl.getString(item, "AlcoholT", "");
                ls.Smoking = BLCtrl.getBool(item, "Smoking", false);
                ls.Smoke = BLCtrl.getBool(item, "Smoke", false);
                ls.PassiveSmoking = BLCtrl.getBool(item, "PassiveSmoking", false);
                ls.PassiveSmokingT = BLCtrl.getString(item, "PassiveSmokingT", "");
                ls.Drugs = BLCtrl.getBool(item, "Drugs", false);
                ls.DrugsT = BLCtrl.getString(item, "DrugsT", "");
                ls.PastDrugs = BLCtrl.getBool(item, "PastDrugs", false);
                ls.PastDrugsT = BLCtrl.getString(item, "PastDrugsT", "");
                ls.Trauma = BLCtrl.getBool(item, "Trauma", false);
                ls.TraumaT = BLCtrl.getString(item, "TraumaT", "");
                ls.DisordersEating = BLCtrl.getBool(item, "DisordersEating", false);
                ls.DisordersEatingT = BLCtrl.getString(item, "DisordersEatingT", "");
                ls.PastDisordersEating = BLCtrl.getBool(item, "PastDisordersEating", false);
                ls.PastDisordersEatingT = BLCtrl.getString(item, "PastDisordersEatingT", "");
                ls.Anxiety = BLCtrl.getBool(item, "Anxiety", false);
                ls.AnxietyT = BLCtrl.getString(item, "AnxietyT", "");
                ls.Bi_polar = BLCtrl.getBool(item, "DisordersEatingT", false);
                ls.Bi_polarT = BLCtrl.getString(item, "Bi_polarT", "");
                ls.Depression = BLCtrl.getBool(item, "Depression", false);
                ls.DepressionT = BLCtrl.getString(item, "DepressionT", "");
                ls.OtherMentallssue = BLCtrl.getBool(item, "OtherMentalIssue", false);
                ls.OtherMentallssueT = BLCtrl.getString(item, "OtherMentalIssueT", "");
                ls.Relation = BLCtrl.getBool(item, "Relation", false);
                ls.RelationT = BLCtrl.getString(item, "RelationT", "");
                ls.Ab = BLCtrl.getBool(item, "Ab", false);
                ls.AbT = BLCtrl.getString(item, "AbT", "");
                ls.St = BLCtrl.getString(item, "St", "");
                pgl.Add(ls);
            }

            return pgl;
        }
        public LifeStyle Get_LifeStyle(DateTime date, string id)
        {
            DADr_LifeStyle dm = new DADr_LifeStyle();//הקצאת המחלקה 
            ListDictionary Params = new ListDictionary();
            Params.Add("@date", date);//מכניס את זה לרשימה ולוקח את הפרוצדורה בSQL
            Params.Add("@id", id);
            DataSet ds = dm.Get_LifeStyle(Params);//מקבל את המאפיין מהטבלה מהסוג שלו
            LifeStyle ls = new LifeStyle(); //הקצאה מסוג הטבלה
            ls.UpdateCode = BLCtrl.getInt(ds.Tables[0].Rows[0], "UpdateCode", 0);  //המרה של המאפיין מטיפוס שלו לטיפוס של המחלקה 
            ls.Acohol = BLCtrl.getBool(ds.Tables[0].Rows[0],"Alcohol",false);
            ls.AcoholT = BLCtrl.getString(ds.Tables[0].Rows[0],"AlcoholT","");
            ls.Smoking = BLCtrl.getBool(ds.Tables[0].Rows[0],"Smoking",false);
            ls.Smoke = BLCtrl.getBool(ds.Tables[0].Rows[0],"Smoke",false);
            ls.PassiveSmoking = BLCtrl.getBool(ds.Tables[0].Rows[0],"PassiveSmoking",false);
            ls.PassiveSmokingT = BLCtrl.getString( ds.Tables[0].Rows[0],"PassiveSmokingT","");
            ls.Drugs = BLCtrl.getBool(ds.Tables[0].Rows[0],"Drugs",false);
            ls.DrugsT = BLCtrl.getString(ds.Tables[0].Rows[0],"DrugsT","");
            ls.PastDrugs = BLCtrl.getBool(ds.Tables[0].Rows[0],"PastDrugs",false);
            ls.PastDrugsT = BLCtrl.getString(ds.Tables[0].Rows[0],"PastDrugsT","");
            ls.Trauma = BLCtrl.getBool(ds.Tables[0].Rows[0],"Trauma",false);
            ls.TraumaT = BLCtrl.getString(ds.Tables[0].Rows[0],"TraumaT","");
            ls.DisordersEating = BLCtrl.getBool(ds.Tables[0].Rows[0],"DisordersEating",false);
            ls.DisordersEatingT = BLCtrl.getString(ds.Tables[0].Rows[0],"DisordersEatingT","");
            ls.PastDisordersEating = BLCtrl.getBool(ds.Tables[0].Rows[0],"PastDisordersEating",false);
            ls.PastDisordersEatingT = BLCtrl.getString(ds.Tables[0].Rows[0],"PastDisordersEatingT","");
            ls.Anxiety = BLCtrl.getBool(ds.Tables[0].Rows[0],"Anxiety",false);
            ls.AnxietyT = BLCtrl.getString(ds.Tables[0].Rows[0],"AnxietyT","");
            ls.Bi_polar = BLCtrl.getBool(ds.Tables[0].Rows[0], "Bi-polar", false);
            ls.Bi_polarT = BLCtrl.getString(ds.Tables[0].Rows[0], "Bi-polarT", "");
            ls.Depression = BLCtrl.getBool(ds.Tables[0].Rows[0],"Depression",false);
            ls.DepressionT = BLCtrl.getString(ds.Tables[0].Rows[0],"DepressionT","");
            ls.OtherMentallssue = BLCtrl.getBool(ds.Tables[0].Rows[0],"OtherMentalIssue",false);
            ls.OtherMentallssueT = BLCtrl.getString(ds.Tables[0].Rows[0],"OtherMentalIssueT","");
            ls.Relation = BLCtrl.getBool(ds.Tables[0].Rows[0],"Relation",false);
            ls.RelationT = BLCtrl.getString(ds.Tables[0].Rows[0],"RelationT","");
            ls.Ab = BLCtrl.getBool(ds.Tables[0].Rows[0],"Ab",false);
            ls.AbT = BLCtrl.getString(ds.Tables[0].Rows[0],"AbT","");
            ls.St = BLCtrl.getString(ds.Tables[0].Rows[0],"St","");

            return ls;

        }

        public int AddOrUpdatelifestyle(string id,DateTime date,LifeStyle s)
           // DateTime date, string id,  float height,float wheight ,
           //int bmi , string bloodpressure, 
           //int pulse, bool noteat ,string noteatt ,int meals ,int fruits, int vegetables, bool dairy , int water,bool diet, string diett,
           //float sleepinghours , bool activity , bool alcohol,
           //string alcoholt , bool smoking, bool smoke, bool passivesmoking , bool drugs , string drugst, bool pastdrugs , bool trauma , string traumat, bool disorderseating ,  string disorderseatingt , bool depression, string depressiont,
           //bool pastdisorderseating , string pastdisorderseatingt, bool anxiety, string anxietyt, bool bipolar, string bipolart,   
           //bool othermentalissue , string othermentalissuet , bool relation,
           //string relationt , bool ab , string abt , string st)
        {
            DADr_LifeStyle dm = new DADr_LifeStyle();//הקצאת המחלקה 
            ListDictionary Params = new ListDictionary();
            Params.Add("@id", BLCtrl.sendString(id, ""));
            Params.Add("@dt", BLCtrl.sendDateTime(date, new DateTime()));//מכניס את זה לרשימה ולוקח את הפרוצדורה בSQL
           

            Params.Add("@alcohol", BLCtrl.sendBool(s.Acohol,false));
            Params.Add("@alcoholt", BLCtrl.sendString(s.AcoholT,""));
            Params.Add("@smoking", BLCtrl.sendBool( s.Smoking,false));
            Params.Add("@smoke", BLCtrl.sendBool(s.Smoke,false));
            Params.Add("@passivesmoking", BLCtrl.sendBool(s.PassiveSmoking,false));
            Params.Add("@passivesmokingt", BLCtrl.sendString(s.PassiveSmokingT, ""));//

            Params.Add("@drugs", BLCtrl.sendBool(s.Drugs,false));
            Params.Add("@drugst", BLCtrl.sendString(s.DrugsT,""));
            Params.Add("@pastdrugs", BLCtrl.sendBool(s.PastDrugs,false));
            Params.Add("@pastdrugst", BLCtrl.sendString(s.PastDrugsT, ""));
         

            Params.Add("@trauma", BLCtrl.sendBool(s.Trauma,false));
            Params.Add("@traumat", BLCtrl.sendString(s.TraumaT,""));
            Params.Add("@disorderseating", BLCtrl.sendBool(s.DisordersEating,false));
            Params.Add("@disorderseatingt", BLCtrl.sendString(s.DisordersEatingT,""));
            Params.Add("@pastdisorderseating", BLCtrl.sendBool(s.PastDisordersEating, false));
            Params.Add("@pastdisorderseatingt", BLCtrl.sendString(s.PastDisordersEatingT, ""));
            

            Params.Add("@anxiety", BLCtrl.sendBool(s.Anxiety,false));
            Params.Add("@anxietyt", BLCtrl.sendString(s.AnxietyT,""));
            Params.Add("@bipolar", BLCtrl.sendBool( s.Bi_polar,false));
            Params.Add("@bipolart", BLCtrl.sendString(s.Bi_polarT,""));
            Params.Add("@depression", BLCtrl.sendBool(s.Depression, false));
            Params.Add("@depressiont", BLCtrl.sendString(s.DepressionT, ""));
            Params.Add("@othermentalissue", BLCtrl.sendBool(s.OtherMentallssue,false));
            Params.Add("@othermentalissuet", BLCtrl.sendString(s.OtherMentallssueT,""));
            Params.Add("@relation", BLCtrl.sendBool(s.Relation,false));
            Params.Add("@relationt", BLCtrl.sendString(s.RelationT,""));
            Params.Add("@ab", BLCtrl.sendBool(s.Ab,false));
            Params.Add("@abt", BLCtrl.sendString(s.AbT, ""));
            Params.Add("@st", BLCtrl.sendString(s.St,""));


            int result = dm.AddOrUpdatelifestyle(Params);//מקבל את המאפיין מהטבלה מהסוג שלו
            return result;

        }
    }
}
