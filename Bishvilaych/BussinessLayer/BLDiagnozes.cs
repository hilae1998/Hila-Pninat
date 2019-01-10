using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessLayer;

namespace BussinesLayer
{
    public class BLDiagnozes
    {
        public List< Diagnozes> GetAllDiagnoze(string Id)
        {
            DADiagnoze DAD = new DADiagnoze();
            ListDictionary Params = new ListDictionary();
            Params.Add("@MyId", Id);
            DataSet ds = DAD.GetAllDiagnoze(Params);
            Diagnozes D = new Diagnozes();
            List<Diagnozes> MyD = new List<Diagnozes>();
            foreach(DataRow item in ds.Tables[0].Rows)
            {

                D.Code = BLCtrl.getInt(item, "Code", 0);
                D.Diagnoze = BLCtrl.getInt(item, "Diagnoze",1);
                D.Status = BLCtrl.getInt(item, "Status", 1);
                D.BeginDate = BLCtrl.getDateTime(item, "BeginDate", new DateTime(2018-1-1));
                D.EndDate = BLCtrl.getDateTime(item, "EndDate", new DateTime(2018-1-1));
                D.By = BLCtrl.getInt(item, "By", 0);
                D.PatiantCode = BLCtrl.getInt(item, "PatiantCode", 0);
                MyD.Add(D);
            }
            
            return MyD;
        }

        public List<string> GetNameDiagnoze(int Num)
        {
            DADiagnoze DAD = new DADiagnoze();
            ListDictionary Params = new ListDictionary();
            Params.Add("@Num", Num);
            DataSet ds = DAD.GetNameDiagnoze(Params);
            string S;
            List<string> MyNameDiagnoze = new List<string>();            
            S = BLCtrl.getString(ds.Tables[0].Rows[0], "Diagnoze", ""); 
            MyNameDiagnoze.Add(S);  
            return MyNameDiagnoze;
        }

        public List<string> GetNameStatus(int Num)
        {
            DADiagnoze DAD = new DADiagnoze();
            ListDictionary Params = new ListDictionary();
            Params.Add("@Num", Num);
            DataSet ds = DAD.GetNameStatus(Params);
            string S;
            List<string> MyNameStatus = new List<string>();
            S = BLCtrl.getString(ds.Tables[0].Rows[0], "Status", "");
            MyNameStatus.Add(S);
            return MyNameStatus;
        }

        public List<string> GetNameWorker(int Num)
        {
            DADiagnoze DAD = new DADiagnoze();
            ListDictionary Params = new ListDictionary();
            Params.Add("@Num", Num);
            DataSet ds = DAD.GetNameWorker(Params);
            string S;
            List<string> MyNameWorker = new List<string>();
            S = BLCtrl.getString(ds.Tables[0].Rows[0], "FullName","");
            MyNameWorker.Add(S);
            return MyNameWorker;
        }
        //public int DeleteDiagnoze(int Code)
        //{
        //    DADiagnoze DAD = new DADiagnoze();
        //    ListDictionary Params = new ListDictionary();
        //    Params.Add("@Code", Code);
            
        //    int result = DAD.DeleteDiagnoze(Params);
        //    return result;
        //}

        public int UpdateDiagnoze(Diagnozes d, string id)
        {
            DADiagnoze DAD = new DADiagnoze();
            ListDictionary Params = new ListDictionary();
            Params.Add("@BeginDate", d.BeginDate);
            Params.Add("@By", d.By);
            Params.Add("@Code", d.Code);
            Params.Add("@Diagnoze", d.Diagnoze);
            Params.Add("@EndDate", d.EndDate);
            Params.Add("@PatiantCode", d.PatiantCode);
            Params.Add("@Status", d.Status);
            int result = DAD.UpdateDiagnoze(Params);
            //List<Diagnozes> all= GetAllDiagnoze(id);
            //string S;
            //List<string> MyNameWorker = new List<string>();
            //S = BLCtrl.getString(ds.Tables[0].Rows[0], "FullName", "");
            //MyNameWorker.Add(S);
            return result;
        }

    }
}
