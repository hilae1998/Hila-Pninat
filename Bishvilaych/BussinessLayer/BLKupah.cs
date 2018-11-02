using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// לאה אמסלם
// 10/07/18 --- 16/07/18
namespace BussinessLayer
{
    public class BLKupah
    {
        public Kupot Kupah(int code)
        {
            DAKupah dcp = new DAKupah();
            ListDictionary Params = new ListDictionary();
            Params.Add("@code", BLCtrl.sendInt(code, 0));
            DataSet ds =dcp.Kupah(Params);
            Kupot k=new Kupot();
            k.Kupah = BLCtrl.getString(ds.Tables[0].Rows[0], "Kupah", "");
            return k; 
        }
    }
}