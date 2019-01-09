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
   public class BL_AddImmunization
    {
        public int Add_Immunization(string pat, int immunization, DateTime SDate, int Year,string Text)
        {
            
            DA_AddImmunization dm = new DA_AddImmunization();
            ListDictionary Params = new ListDictionary();
            Params.Add("@patient", BLCtrl.sendString(pat, " "));
            Params.Add("@immunization", BLCtrl.sendInt(immunization, 0));
            Params.Add("@SDate", BLCtrl.sendDateTime(SDate, DateTime.Today));
            Params.Add("@Year",BLCtrl.sendInt(Year,2018));
            Params.Add("@Text",BLCtrl.sendString(Text," "));

            int result = dm.AddImmunization(Params);

            return result;
        }
        public List<immunizations> Draw_ImmusationList()
        {
            DA_AddImmunization dm = new DA_AddImmunization();
            ListDictionary Params = new ListDictionary();
            DataSet ds = dm.Draw_ImmusationList(Params);
            List<immunizations> l = new List<immunizations>();
            immunizations i;
            foreach (DataRow item in ds.Tables[0].Rows)
            {
                i = new immunizations();
                i.immunization = item.Field<string>("immunization");
                i.Code = item.Field<int>("Code");
                l.Add(i);
            }
            return l;
        }
    }
}
