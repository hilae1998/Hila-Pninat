using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using System.Data;
using BussinessLayer;

//Ayala Gozlan

namespace BussinessLayer
{
    public class BLGetKupot
    {
        public List<Kupot> getKupot()
        {
            DAGetKupot dak = new DAGetKupot();
            ListDictionary Params = new ListDictionary();
            DataSet ds = dak.getKupot();
            List<Kupot> lk = new List<Kupot>();
            Kupot k;
            foreach (DataRow item in ds.Tables[0].Rows)
            {
                k = new Kupot();
                k.Code = BLCtrl.getInt(item, "Code", 0);
                k.Kupah = BLCtrl.getString(item, "Kupah", "");
                lk.Add(k);
            }
            return lk;

        }
    }
}
