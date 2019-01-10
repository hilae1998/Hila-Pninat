using BussinesLayer;
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
    public class BL_AddMedicineVitaminAndSensitivities
    {
        private readonly object dt;

        public List<MedicinesKind> Draw_Medicine()
        {
            DAL_AddMedicineVitaminAndSensitivities dm = new DAL_AddMedicineVitaminAndSensitivities();
            ListDictionary Params = new ListDictionary();
            DataSet ds = dm.Draw_Medicine(Params);
            List<MedicinesKind> lm = new List<MedicinesKind>();
            MedicinesKind m;
            foreach (DataRow item in ds.Tables[0].Rows)
            {
                m = new MedicinesKind();
                m.Medicine = item.Field<string>("Medicine");
                lm.Add(m);
            }
            return lm;
        }

        public string Add_MedicineVitamin(int medicine, int vitamin, bool active, object givenKind, string quantity, int days, string givenOn, string text)
        {
            throw new NotImplementedException();
        }

        public string Update_MedicineVitamin(int medicine, int vitamin, bool active, object givenKind, string quantity, int days, string givenOn, string text)
        {
            throw new NotImplementedException();
        }

        public int Update_Medicines(int medicine, int vitamin, bool active, object givenKind, string quantity, int days, string givenOn, string text)
        {
            throw new NotImplementedException();
        }

        public List<Vitamins> Draw_Vitamin()
        {
            DAL_AddMedicineVitaminAndSensitivities dm = new DAL_AddMedicineVitaminAndSensitivities();
            ListDictionary Params = new ListDictionary();
            DataSet ds = dm.Draw_Medicine(Params);
            List<Vitamins> lv = new List<Vitamins>();
            Vitamins v;
            foreach (DataRow item in ds.Tables[0].Rows)
            {
                v = new Vitamins();
                v.Vitamin= item.Field<string>("Vitamin");
                lv.Add(v);
            }
            return lv;
        }

        public List<Medicines> Draw_GivenKind()
        {
            DAL_AddMedicineVitaminAndSensitivities dm = new DAL_AddMedicineVitaminAndSensitivities();
            ListDictionary Params = new ListDictionary();
            DataSet ds = dm.Draw_GivenKind(Params);
            List<Medicines> lg = new List<Medicines>();
            Medicines g;
            foreach (DataRow item in ds.Tables[0].Rows)
            {
                g = new Medicines();
                g.Influens = item.Field<int>("Medicine");
                lg.Add(g);
            }
            return lg;
        }

        public int Add_MedicineVitamin (int Medicine, int Vitamin,bool Active,string GivenKind,string Quantity,int Days,string GivenOn,string Text)
        {
            DAL_AddMedicineVitaminAndSensitivities dm = new DAL_AddMedicineVitaminAndSensitivities();

            ListDictionary Params = new ListDictionary();
            Params.Add("@Medicine",BLCtrl.sendInt("Medicine",0));
            Params.Add("@Vitamin",BLCtrl.sendInt("Vitamin",0));
            Params.Add("@Active",BLCtrl.sendBool("Active",false));
            Params.Add("@GivenKind",BLCtrl.sendString("GivenKind",""));
            Params.Add("@Quantity",BLCtrl.sendString("Quantity",""));
            Params.Add("@Days",BLCtrl.sendInt("Days",0));
            Params.Add("@GivenOn",BLCtrl.sendString("GivenOn",""));
            Params.Add("@Text",BLCtrl.sendString("Text",""));

            int result = dm.Add_MedicineVitamin(Params);

            return result;
        }

        //public int Update_MedicineVitamin(int Medicine, int Vitamin, bool Active, string GivenKind, string Quantity, int Days, string GivenOn, string Text)
        //{
        //    DAL_AddMedicineVitaminAndSensitivities dm = new DAL_AddMedicineVitaminAndSensitivities();

        //    ListDictionary Params = new ListDictionary();
        //    Params.Add("@Medicine", BLCtrl.sendInt("Medicine", 0));
        //    Params.Add("@Vitamin", BLCtrl.sendInt("Vitamin", 0));
        //    Params.Add("@Active", BLCtrl.sendBool("Active", false));
        //    Params.Add("@GivenKind", BLCtrl.sendString("GivenKind", ""));
        //    Params.Add("@Quantity", BLCtrl.sendString("Quantity", ""));
        //    Params.Add("@Days", BLCtrl.sendInt("Days", 0));
        //    Params.Add("@GivenOn", BLCtrl.sendString("GivenOn", ""));
        //    Params.Add("@Text", BLCtrl.sendString("Text", ""));

        //    int result = dm.Update_MedicineVitamin(Params);

        //    return result;
        //}

        //public List<GivenKind> Print_ReceiptMV()
        //{
        //    DAL_AddMedicineVitaminAndSensitivities dm = new DAL_AddMedicineVitaminAndSensitivities();
        //    ListDictionary Params = new ListDictionary();
        //    DataSet ds = dm.Print_ReceiptMV(Params);
        //    List<GivenKind> lg = new List<GivenKind>();
        //    GivenKind g;
        //    foreach (DataRow item in ds.Tables[0].Rows)
        //    {
        //        g = new GivenKind();
        //        g.GivenKind = item.Field<int>("GivenKind");
        //        lg.Add(g);
        //    }
        //    return lg;
        //}



        public List<Sensitivitieskinds> Draw_KindSS()
        {
            DAL_AddMedicineVitaminAndSensitivities dm = new DAL_AddMedicineVitaminAndSensitivities();
            ListDictionary Params = new ListDictionary();
            DataSet ds = dm.Draw_KindSS(Params);
            List<Sensitivitieskinds> ls = new List<Sensitivitieskinds>();
            Sensitivitieskinds s;
            foreach (DataRow item in ds.Tables[0].Rows)
            {
                s = new Sensitivitieskinds();
                s.Sensitivity = item.Field<string>("Sensitivity");
                ls.Add(s);
            }
            return ls;
        }

        public List<MedicinesKind> Draw_MedicineSS()
        {
            DAL_AddMedicineVitaminAndSensitivities dm = new DAL_AddMedicineVitaminAndSensitivities();
            ListDictionary Params = new ListDictionary();
            DataSet ds = dm.Draw_MedicineSS(Params);
            List<MedicinesKind> lm = new List<MedicinesKind>();
            MedicinesKind m;
            foreach (DataRow item in ds.Tables[0].Rows)
            {
                m = new MedicinesKind();
                m.Medicine = item.Field<string>("Medicine");
                lm.Add(m);
            }
            return lm;
        }

        public List<Medicines> Draw_Influenss()
        {
            DAL_AddMedicineVitaminAndSensitivities dm = new DAL_AddMedicineVitaminAndSensitivities();
            ListDictionary Params = new ListDictionary();
            DataSet ds = dm.Draw_Influenss(Params);
            List<Medicines> li = new List<Medicines>();
            Medicines i;
            foreach (DataRow item in ds.Tables[0].Rows)
            {
                i = new Medicines();
                i.Influens = item.Field<int>("Influens");
                li.Add(i);
            }
            return li;
        }

        public int Add_Sensitivities(int Sensitivity, int Medicine, string Influensse, DateTime DesicionDate, string Desided)
        {
            DAL_AddMedicineVitaminAndSensitivities dm = new DAL_AddMedicineVitaminAndSensitivities();

            ListDictionary Params = new ListDictionary();
            Params.Add("@Sensitivity",BLCtrl.sendInt("Sensitivity",0));
            Params.Add("@Medicine",BLCtrl.sendInt("Medicine",0));
            Params.Add("@Influensse",BLCtrl.sendString("Influensse",""));
            Params.Add("@DesicionDate",BLCtrl.sendDateTime("DesicionDate",new DateTime(01/01/2018)));
            Params.Add("@Desided",BLCtrl.sendString("Desided",""));
         
            int result = dm.Add_Sensitivities(Params);

            return result;
        }

        public int Update_Sensitivities(int Sensitivity, int Medicine, string Influensse, DateTime DesicionDate, string Desided)
        {
            DAL_AddMedicineVitaminAndSensitivities dm = new DAL_AddMedicineVitaminAndSensitivities();

            ListDictionary Params = new ListDictionary();
            Params.Add("@Sensitivity", BLCtrl.sendInt("Sensitivity", 0));
            Params.Add("@Medicine", BLCtrl.sendInt("Medicine", 0));
            Params.Add("@Influensse", BLCtrl.sendString("Influensse", ""));
            Params.Add("@DesicionDate", BLCtrl.sendDateTime("DesicionDate", new DateTime(01 / 01 / 2018)));
            Params.Add("@Desided", BLCtrl.sendString("Desided", ""));

            int result = dm.Update_Sensitivities(Params);
            return result;
        }
    }
}
