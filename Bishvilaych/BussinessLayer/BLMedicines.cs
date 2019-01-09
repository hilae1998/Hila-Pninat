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
    public class BLMedicines
    {
        public List< Medicines> GetAllMedicines(string Id)
        {
            DAMedicines DAM = new DAMedicines();
            ListDictionary Params = new ListDictionary();

            Params.Add("@MyId", Id);
            DataSet ds = DAM.GetAllMedicines(Params);
            Medicines M = new Medicines();
            List<Medicines> MyM = new List<Medicines>();


            foreach (DataRow item in ds.Tables[0].Rows)
            {
                M.Code = BLCtrl.getInt(item, "Code", 0);
                M.Influens = BLCtrl.getInt(item, "Medicine", 0);
                M.Vitamin = BLCtrl.getInt(item, "Vitamin", 0);
                M.Active = BLCtrl.getBool(item, "Active", false);
                M.GivenKind = BLCtrl.getString(item, "GivenKind","");
                M.Quantity = BLCtrl.getString(item, "Quantity", "");
                M.Days = BLCtrl.getInt(item, "Days", 0);
                M.GivenOn = BLCtrl.getString(item, "GivenOn", "");
                M.Text = BLCtrl.getString(item, "Text", "");
                M.By = BLCtrl.getInt(item, "By", 0);
                M.PatiantCode = BLCtrl.getString(item, "PatiantCode", "");
                MyM.Add(M);
            }
            return MyM;
        }

        public List<string> GetNameWorker(string Num)
        {
            DAMedicines DAM = new DAMedicines();
            ListDictionary Params = new ListDictionary();
            Params.Add("@Num", Num);
            DataSet ds = DAM.GetNameWorker(Params);
            string S;
            List<string> MyNameWorker = new List<string>();
            S = BLCtrl.getString(ds.Tables[0].Rows[0], "LastName" + ' ' + "FirstName", "");
            MyNameWorker.Add(S);
            return MyNameWorker;
        }

        public List<string> GetNameVitamin(string Num)
        {
            DAMedicines DAM = new DAMedicines();
            ListDictionary Params = new ListDictionary();
            Params.Add("@Num", Num);
            DataSet ds = DAM.GetNameVitamin(Params);
            string S;
            List<string> MyNameVitamin = new List<string>();
            S = BLCtrl.getString(ds.Tables[0].Rows[0], "Vitamin", "");
            MyNameVitamin.Add(S);
            return MyNameVitamin;
        }

        public List<string> GetNameMedicine(string Num)
        {
            DAMedicines DAM = new DAMedicines();
            ListDictionary Params = new ListDictionary();
            Params.Add("@Num", Num);
            DataSet ds = DAM.GetNameMedicine(Params);
            string S;
            List<string> MyNameMedicine = new List<string>();
            S = BLCtrl.getString(ds.Tables[0].Rows[0], "Medicine", "");
            MyNameMedicine.Add(S);
            return MyNameMedicine;
        }


        public int DeleteMedicines(int Code)
        {
            DAMedicines DAM = new DAMedicines();
            ListDictionary Params = new ListDictionary();
            Params.Add("@Code", Code);

            int result = DAM.DeleteMedicines(Params);
            return result;
        }
    }
}
