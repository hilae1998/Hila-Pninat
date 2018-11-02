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
    public class BL_AddPatiants
    {
        public int Add_Patiants(string Id, string FirstName,string LastName,int kupah)
        {
            DA_Add_Patiants dm = new DA_Add_Patiants();

            ListDictionary Params = new ListDictionary();
            Params.Add("@Id", BLCtrl.sendString(Id,""));
            Params.Add("@FirstName", BLCtrl.sendString(FirstName, ""));
            Params.Add("@LastName", BLCtrl.sendString(LastName, ""));
            Params.Add("@kupah", BLCtrl.sendInt(kupah,1));

            int result = dm.Add_Patiants(Params);

            return result;
        }
        public int CheckID(string Id)
       {
            DA_Add_Patiants dm = new DA_Add_Patiants();

            ListDictionary Params = new ListDictionary();
            Params.Add("@id", BLCtrl.sendString(Id, ""));
          

            int result = dm.CheckID(Params);

            return result;
        }
        public List<Kupot> Draw_Kupah()
        {
            DA_Add_Patiants dm = new DA_Add_Patiants();
            ListDictionary Params = new ListDictionary();
            DataSet ds = dm.Draw_Kupah(Params);
            List<Kupot> l = new List<Kupot>();
            Kupot k;
            foreach (DataRow item in ds.Tables[0].Rows)
            {
                k = new Kupot();
                k.Kupah = BLCtrl.getString(item, "Kupah", "");
                k.Code = BLCtrl.getInt(item, "Code",0);
                l.Add(k);
            }
            return l;
        }
    }
}