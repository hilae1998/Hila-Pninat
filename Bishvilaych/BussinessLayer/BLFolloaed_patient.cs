using BussinessLayer;
using DataAccessLayer;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer
{
    // לאה אמסלם
    // 27/5/18
    public class BLFolloaed_patient
    {
        public List<Patiants> getFolloaed_patient()
        {
            DAFolloaed_patient dfp = new DAFolloaed_patient();
            ListDictionary Params = new ListDictionary();
            DataSet ds = dfp.getFolloaed_patient(Params);
            List<Patiants> lp = new List<Patiants>();
            Patiants p;
            foreach (DataRow item in ds.Tables[0].Rows)
            {
                p = new Patiants();
                p.Id  = BLCtrl.getString(item, "id"," ");
                p.FirstName = BLCtrl.getString(item, "FirstName", " ");
                p.LastName = BLCtrl.getString(item, "LastName", " ");
                p.Phone = BLCtrl.getString(item, "Phone", " ");
                p.Phone2 = BLCtrl.getString(item, "Phone2", " ");
                p.City = BLCtrl.getString(item, "City", " ");
                p.Kupah = BLCtrl.getInt(item, "Kupah", 0);// לבדוק איך מביאים את שם הקופה שנמצא בפרוצודורה אחרת
                lp.Add(p);
            }                       
            return lp;
        }

       public int update_followed_up()
       {
          DAFolloaed_patient dfp = new DAFolloaed_patient();
          ListDictionary Params = new ListDictionary();      
          int result = dfp.update_followed_up(Params);
          return result;
       }
    }
}
