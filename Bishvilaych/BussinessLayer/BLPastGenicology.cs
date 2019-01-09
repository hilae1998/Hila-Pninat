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
    public class BLPastGenicology
    {
        public List<PastGenicology> getPastGeniclogiById(string id)
        {
            DAPastGenicology da = new DAPastGenicology();
            ListDictionary Params = new ListDictionary();
            Params.Add("@id", id);
            DataSet ds = da.getPastGeniclogiById(Params);
            PastGenicology pg = new PastGenicology();
            List<PastGenicology> pgl = new List<PastGenicology>();

            foreach (DataRow item in ds.Tables[0].Rows)
            {
                pg = new PastGenicology();
                pg.UpdateCode = BLCtrl.getInt(item, "UpdateCode", 0);
                pg.AgeOfMenarche = BLCtrl.getInt(item, "AgeOfMenarche", 18);
                pg.CycleRegular = BLCtrl.getBool(item, "CycleRegular", true);
                pg.CycleRegularT = BLCtrl.getString(item, "CycleRegularT", "");
                pg.MenstrualSyptoms = BLCtrl.getBool(item, "MenstrualSyptoms", false);
                pg.MenstrualSyptomsT = BLCtrl.getString(item, "MenstrualSyptomsT", "");
                pg.MenopauseSyptoms = BLCtrl.getBool(item, "MenopauseSyptoms", false);
                pg.MenopauseSyptomsT = BLCtrl.getString(item, "MenopauseSyptoms", "");
                pg.Contraception = BLCtrl.getBool(item, "Contraception", false);
                pg.ContraceptionT = BLCtrl.getString(item, "ContraceptionT", "");
                pgl.Add(pg);
            }
            return pgl;
        }
        public PastGenicology getPastGenicology(string id, DateTime date)
        {
            DAPastGenicology da = new DAPastGenicology();
            ListDictionary Params = new ListDictionary();
            Params.Add("@id", id);
            Params.Add("@date", date);
            DataSet ds = da.getPastGenicology(Params);
            PastGenicology pg = new PastGenicology();
            pg.UpdateCode = BLCtrl.getInt(ds.Tables[0].Rows[0], "UpdateCode", 0);
            pg.AgeOfMenarche = BLCtrl.getInt(ds.Tables[0].Rows[0], "AgeOfMenarche", 18);
            pg.CycleRegular = BLCtrl.getBool(ds.Tables[0].Rows[0],"CycleRegular",true); 
            pg.CycleRegularT = BLCtrl.getString(ds.Tables[0].Rows[0], "CycleRegularT", "");
            pg.MenstrualSyptoms = BLCtrl.getBool(ds.Tables[0].Rows[0],"MenstrualSyptoms",false);
            pg.MenstrualSyptomsT = BLCtrl.getString(ds.Tables[0].Rows[0],"MenstrualSyptomsT","");
            pg.MenopauseSyptoms = BLCtrl.getBool(ds.Tables[0].Rows[0],"MenopauseSyptoms",false);
            pg.MenopauseSyptomsT = BLCtrl.getString(ds.Tables[0].Rows[0],"MenopauseSyptomsT","");
            pg.Contraception = BLCtrl.getBool(ds.Tables[0].Rows[0], "Contraception", false);
            pg.ContraceptionT = BLCtrl.getString(ds.Tables[0].Rows[0],"ContraceptionT","");
            return pg;
        }
        public int addOrUpdatePastGenicology(string id1, DateTime date1, int
            AgeOfMenarche1, bool CycleRegular1, string CycleRegularT1, bool MenstrualSyptoms1,
            string MenstrualSyptomsT1, bool MenopauseSyptoms1, string MenopauseSyptomsT1, bool
            Contraception1, string ContraceptionT1)
        {
            DAPastGenicology da = new DAPastGenicology();
            ListDictionary Params = new ListDictionary();
            Params.Add("@id1", BLCtrl.sendString(id1, ""));
            Params.Add("@date1", BLCtrl.sendDateTime(date1, DateTime.Today));
            Params.Add("@AgeOfMenarche1", BLCtrl.sendInt(AgeOfMenarche1, 0));
            Params.Add("@CycleRegular1", BLCtrl.sendBool(CycleRegular1, true));
            Params.Add("@CycleRegularT1", BLCtrl.sendString(CycleRegularT1, ""));
            Params.Add("@MenstrualSyptoms1", BLCtrl.sendBool(MenstrualSyptoms1, false));
            Params.Add("@MenstrualSyptomsT1", BLCtrl.sendString(MenstrualSyptomsT1, ""));
            Params.Add("@MenopauseSyptoms1", BLCtrl.sendBool(MenopauseSyptoms1, false));
            Params.Add("@MenopauseSyptomsT1", BLCtrl.sendString(MenopauseSyptomsT1, ""));
            Params.Add("@Contraception1", BLCtrl.sendBool(Contraception1, false));
            Params.Add("@ContraceptionT1", BLCtrl.sendString(ContraceptionT1, ""));
            int result = da.addOrUpdatePastGenicology(Params);
            return result;
        }
    }
}
