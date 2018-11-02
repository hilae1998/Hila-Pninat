
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BussinessLayer
{
    public class BLVisitSummery//created by hila elgrabli
    {

        
        public int UpdateReccomendations(DateTime date1, string id1, int code1, string rec1)
        {
            VisitSummary dm = new VisitSummary();

            ListDictionary Params = new ListDictionary();
            Params.Add("@date", BLCtrl.sendDateTime(date1,new DateTime()));
            Params.Add("@id", BLCtrl.sendString(id1,""));
            Params.Add("@code", BLCtrl.sendInt(code1,0));
            Params.Add("@rec", BLCtrl.sendString( rec1,""));
          
            int result = dm.UpdateReccomendations(Params);
            return result;

        }
        public int UpdateSummary(DateTime date1, string id1, bool Mentioned1, int FollowUp1 )
        {
            VisitSummary dm = new VisitSummary();

            ListDictionary Params = new ListDictionary();
            Params.Add("@date", BLCtrl.sendDateTime(date1, new DateTime()));
            Params.Add("@id", BLCtrl.sendString(id1, ""));
            Params.Add("@Mentioned", BLCtrl.sendBool(Mentioned1, true));
            Params.Add("@FollowUp", BLCtrl.sendInt(FollowUp1, 1));

            int result = dm.UpdateSummary(Params);
            return result;

        }

        public int addOrUpdateReccomendations(string id1, int code1, string rec1)
        {
            VisitSummary dm = new VisitSummary();
            ListDictionary Params = new ListDictionary();

            Params.Add("@id", BLCtrl.sendString(id1, ""));
            Params.Add("@code", BLCtrl.sendInt(code1, 0));
            Params.Add("@rec", BLCtrl.sendString(rec1, ""));
            
            int result = dm.addOrUpdateReccomendations(Params);
            return result;

        }

        public List<FollowsUp> getFollowUp()
        {
            VisitSummary dm = new VisitSummary();
            ListDictionary Params = new ListDictionary();
            DataSet ds = dm.getFollowUp(Params);
            List<FollowsUp> l = new List<FollowsUp>();
            FollowsUp f;

            foreach (DataRow item in ds.Tables[0].Rows)
            {
                f = new FollowsUp();
                f.Code = BLCtrl.getInt(item,"Code",0);
                f.FollowUp = BLCtrl.getString(item, "FollowUp", "");
                l.Add(f);
            }

            return l;



        }

        public Summary getSummary( DateTime date1 ,string id1 )
        {
            VisitSummary dm = new VisitSummary();
            ListDictionary Params = new ListDictionary();  
            Summary s = new Summary();

            Params.Add("@date", BLCtrl.sendDateTime(date1, new DateTime()));
            Params.Add("@id", BLCtrl.sendString(id1, ""));
           
            DataSet ds = dm.getSummary(Params);
           
            s.UpdateCode = BLCtrl.getInt(ds.Tables[0].Rows[0], "UpdateCode", 0);
            s.Mentioned = BLCtrl.getBool( ds.Tables[0].Rows[0],"Mentioned",false);
            s.FollowUp = BLCtrl.getInt(ds.Tables[0].Rows[0], "FollowUp", 0);
        
        



            return s;



        }
        public List<Reccomendations>getReccomendations(DateTime date1, string id1)
        {
            VisitSummary dm = new VisitSummary();
            ListDictionary Params = new ListDictionary();
            Reccomendations s;

            Params.Add("@date", BLCtrl.sendDateTime(date1, new DateTime()));
            Params.Add("@id", BLCtrl.sendString(id1, ""));

            DataSet ds = dm.getReccomendations(Params);
            List<Reccomendations> l = new List<Reccomendations>();

            foreach (DataRow item in ds.Tables[0].Rows)
            {
                s = new Reccomendations();
                s.UpdateCode = BLCtrl.getInt(item, "UpdateCode", 0);
                s.Code = BLCtrl.getInt(item, "Code", 0);
                s.Reccomendation = BLCtrl.getString(item, "Reccomendation", "");
                l.Add(s);
            }

           




            return l;



        }

        public List<DateTime> get_updating(string id1)
        {
        
            VisitSummary dm = new VisitSummary();
            ListDictionary Params = new ListDictionary();
            Params.Add("@id", id1);
           
            DataSet ds = dm.get_Updating(Params);
            List<DateTime> l = new List<DateTime>();
            DateTime f;
         
            foreach (DataRow item in ds.Tables[0].Rows)
            {
                f = new DateTime();
                f = item.Field<DateTime>("UpdateDate");
                l.Add(f);
            }

            return l;



        }//האם צריך להתמש פה בערך ברירת מחדל על ידי הפונקציה send
    }
}











