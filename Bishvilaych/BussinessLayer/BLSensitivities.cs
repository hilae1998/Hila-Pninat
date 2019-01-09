using BussinessLayer;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer 
{
    public class BLSensitivities
    {
        public List< Sensitivities> GetAllSensitivities(string Id)
        {
            DASensitivities DAS = new DASensitivities();
            ListDictionary Params = new ListDictionary();

            Params.Add("@MyId", Id);
            DataSet ds = DAS.GetAllSensitivities(Params);
            Sensitivities S = new Sensitivities();
            List<Sensitivities> MyS = new List<Sensitivities>();

            foreach (DataRow item in ds.Tables[0].Rows)
            {
                S.Code = BLCtrl.getInt(item, "Code", 0);
                S.Sensitivity = BLCtrl.getInt(item, "Sensitivity", 0);
                S.Medicine = BLCtrl.getInt(item, "Medicine", 0);
                S.Kind = BLCtrl.getString(item, "Kind", "");
                S.DesicionDate = BLCtrl.getDateTime(item, "DesicionDate", new DateTime(2018 - 1 - 1));
                S.Desided = BLCtrl.getString(item, "Desided", "");
                S.Influenss = BLCtrl.getString(item, "Influenss", "");
                S.By = BLCtrl.getInt(item, "By", 0);
                S.PatiantCode = BLCtrl.getString(item, "PatiantCode", "");
                MyS.Add(S);
            }

            return MyS;
        }

        public List<string> GetNameWorker(string Num)
        {
            DASensitivities DAS = new DASensitivities();
            ListDictionary Params = new ListDictionary();
            Params.Add("@Num", Num);
            DataSet ds = DAS.GetNameWorker(Params);
            string S;
            List<string> MyNameWorker = new List<string>();
            S = BLCtrl.getString(ds.Tables[0].Rows[0], "LastName" + ' ' + "FirstName", "");
            MyNameWorker.Add(S);
            return MyNameWorker;
        }

        public List<string> GetNameMedicine(string Num)
        {
            DASensitivities DAS = new DASensitivities();
            ListDictionary Params = new ListDictionary();
            Params.Add("@Num", Num);
            DataSet ds = DAS.GetNameMedicine(Params);
            string S;
            List<string> MyNameMedicine = new List<string>();
            S = BLCtrl.getString(ds.Tables[0].Rows[0], "Medicine", "");
            MyNameMedicine.Add(S);
            return MyNameMedicine;
        }

        public List<string> GetNameSensitivity(string Num)
        {
            DASensitivities DAS = new DASensitivities();
            ListDictionary Params = new ListDictionary();
            Params.Add("@Num", Num);
            DataSet ds = DAS.GetNameSensitivity(Params);
            string S;
            List<string> MyNameSensitivity = new List<string>();
            S = BLCtrl.getString(ds.Tables[0].Rows[0], "Medicine", "");
            MyNameSensitivity.Add(S);
            return MyNameSensitivity;
        }

        public int DeleteSensitivities(int Code)
        {
            DASensitivities DAS = new DASensitivities();
            ListDictionary Params = new ListDictionary();
            Params.Add("@Code", Code);

            int result = DAS.DeleteSensitivities(Params);
            return result;
        }



    }
}
