using BussinessLayer;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer//Ma'ayan
{
    public class BLHospitalizations
    {
        public List< Hospitalizations> GetAllHspitalization(string Id)
        {
            DAHospitalizations DAH = new DAHospitalizations();
            ListDictionary Params = new ListDictionary();
            Params.Add("@MyId", Id);
            DataSet ds = DAH.GetAllHspitalization(Params);
            Hospitalizations H = new Hospitalizations();
            List<Hospitalizations> MyH = new List<Hospitalizations>();
            foreach (DataRow item in ds.Tables[0].Rows)
            {
                H.Code= BLCtrl.getInt(item, "Code", 0);
                H.Year = BLCtrl.getInt(item, "Year",0);
                H.Hospital = BLCtrl.getString(item, "Hospital","");
                H.MyProperty = BLCtrl.getInt(item, "MyProperty", 0);
                H.Department = BLCtrl.getString(item, "Department", "");
                H.Reason = BLCtrl.getString(item, "Reason", "");
                H.By = BLCtrl.getInt(item, "By", 0);
                H.PatiantCode = BLCtrl.getString(item, "PatiantCode", "");
                MyH.Add(H);
            }            
            return MyH;
        }

        public List<string> GetNameWorker(string Num)
        {
            DAHospitalizations DAH = new DAHospitalizations();
            ListDictionary Params = new ListDictionary();
            Params.Add("@Num", Num);
            DataSet ds = DAH.GetNameWorker(Params);
            string S;
            List<string> MyNameWorker = new List<string>();
            S = BLCtrl.getString(ds.Tables[0].Rows[0], "FullName", "");
            MyNameWorker.Add(S);
            return MyNameWorker;
        }

        public List<string> GetNameHospital(string Num)
        {
            DAHospitalizations DAH = new DAHospitalizations();
            ListDictionary Params = new ListDictionary();
            Params.Add("@Num", Num);
            DataSet ds = DAH.GetNameHospital(Params);
            string S;
            List<string> MyNameHospital = new List<string>();
            S = BLCtrl.getString(ds.Tables[0].Rows[0], "Hospital", "");
            MyNameHospital.Add(S);
            return MyNameHospital;
        }

        public int DeleteHospitalizations(int Code)
        {
            DAHospitalizations DAH = new DAHospitalizations();
            ListDictionary Params = new ListDictionary();
            Params.Add("@Code", Code);

            int result = DAH.DeleteHospitalizations(Params);
            return result;
        }

    }
}
