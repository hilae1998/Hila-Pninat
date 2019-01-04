
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using Entity;

namespace BussinessLayer
{
    public class BLVisitReason
    {
        public int AddOrUpdateVisitReason(string id1, DateTime date1, bool GeneralCheck, bool BreastExam ,bool Pap, bool Diaphragm, bool OtherConcetraption, bool MenstrualCycle, bool Kallah, bool OtherReason, string Text )
        {
            DAVisitReason dm = new DAVisitReason();
            ListDictionary Params = new ListDictionary();
            Params.Add("@id1", BLCtrl.sendString(id1, ""));
            Params.Add("@date1", BLCtrl.sendDateTime(date1, DateTime.Today));
            Params.Add("@GeneralCheck", BLCtrl.sendBool(GeneralCheck, false));
            Params.Add("@BreastExam", BLCtrl.sendBool(BreastExam, false));
            Params.Add("@Pap", BLCtrl.sendBool(Pap, false));
            Params.Add("@Diaphragm", BLCtrl.sendBool(Diaphragm, false));
            Params.Add("@OtherConcetraption", BLCtrl.sendBool(OtherConcetraption, false));
            Params.Add("@MenstrualCycle", BLCtrl.sendBool(MenstrualCycle, false));
            Params.Add("@Kallah", BLCtrl.sendBool(Kallah, false));
            Params.Add("@OtherReason", BLCtrl.sendBool(OtherReason, false));
            Params.Add("@Text", BLCtrl.sendString(Text, ""));
            int result = dm.addOrUpdateVisitReason(Params);
            return result;

        }

        public VisitReason getVisitReason( DateTime date, string id)
        {
            DAVisitReason da = new DAVisitReason();
            ListDictionary Params = new ListDictionary();
            Params.Add("@date", date);
            Params.Add("@id", id);
            DataSet ds = da.getVisitReason(Params);
            VisitReason v = new VisitReason();
            v.GeneralCheck = BLCtrl.getBool(ds.Tables[0].Rows[0], "GeneralCheck", false);
            v.BreastExam = BLCtrl.getBool(ds.Tables[0].Rows[0], "BreastExam", false);
            v.Pap = BLCtrl.getBool(ds.Tables[0].Rows[0], "Pap", false);
            v.Diaphragm = BLCtrl.getBool(ds.Tables[0].Rows[0], "Diaphragm", false);
            v.OtherConcetraption = BLCtrl.getBool(ds.Tables[0].Rows[0], "OtherConcetraption", false);
            v.MenstrualCycle = BLCtrl.getBool(ds.Tables[0].Rows[0], "MenstrualCycle", false);
            v.Kallah = BLCtrl.getBool(ds.Tables[0].Rows[0], "Kallah", false);
            v.OtherReason = BLCtrl.getBool(ds.Tables[0].Rows[0], "OtherReason", false);
            v.Text = BLCtrl.getString(ds.Tables[0].Rows[0], "Text", "");
            return v;
        }
    }
}
