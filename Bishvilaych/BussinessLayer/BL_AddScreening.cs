using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//אורית אוחיון 
//הוספת בדיקת עזר 
namespace BussinessLayer
{
    public class BL_AddScreening
    {
        public int Screening(string pat, int Screening, DateTime SDate, int Year,string Text)
        {
            DA_AddScreening dm = new DA_AddScreening();

            ListDictionary Params = new ListDictionary();
            Params.Add("@patient", BLCtrl.sendString(pat, " "));
            Params.Add("@Screening",BLCtrl.sendInt( Screening,0));
            Params.Add("@SDate",BLCtrl.sendDateTime( SDate,DateTime.Today));
            Params.Add("@Year",BLCtrl.sendInt( Year,2018));
            Params.Add("@Text",BLCtrl.sendString( Text," "));

            int result = dm.AddScreening(Params);

            return result;
        }
        //public List<Screenings> DrawScreningList()
        //{
        //    DA_AddScreening dm = new DA_AddScreening();
        //    ListDictionary Params = new ListDictionary();
        //    DataSet ds = dm.DrawScreningList(Params);
        //    List<Screenings> l = new List<Screenings>();
        //    Screenings i;
        //    foreach (DataRow item in ds.Tables[0].Rows)
        //    {
        //        i = new Screenings();
        //        i.immunization = item.Field<string>("screining");
        //        l.Add(i);
        //    }
        //    return l;
        //}
        public List<ScreeningsKinds> DrawScreningList()
        {
            DA_AddScreening dm = new DA_AddScreening();
            ListDictionary Params = new ListDictionary();
            DataSet ds = dm.DrawScreningList(Params);
            List<ScreeningsKinds> l = new List<ScreeningsKinds>();
            ScreeningsKinds i;
            foreach (DataRow item in ds.Tables[0].Rows)
            {
                i = new ScreeningsKinds();
                i.Screening = item.Field<string>("Screening");
                i.Code = item.Field<int>("Code");
                l.Add(i);
            }
            return l;
        }


    }
}
