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
    public class BLUpdateDateAndCode
    {
        public List<Updatings> getUpdateDateAndcode(string id)
        {
            DAgetUpdateDateAndCode da = new DAgetUpdateDateAndCode();
            ListDictionary Params = new ListDictionary();
            Params.Add("@id", id);
            DataSet ds = da.getUpdateDateAndCode(Params);
            List<Updatings> l = new List<Updatings>();
            Updatings f;

            foreach (DataRow item in ds.Tables[0].Rows)
            {
                f = new Updatings();
                f.UpdateDate = BLCtrl.getDateTime(item,"UpdateDate",new DateTime());
                f.Code= BLCtrl.getInt(item,"Code",0);
                l.Add(f);
            }
            return l;
        }
    }
}
