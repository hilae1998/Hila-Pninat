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
    public class BLCustomers
    {
        public List<Customers> getCustomers()
        {
            DACustomers dc = new DACustomers();
            ListDictionary Params = new ListDictionary();
            DataSet ds = dc.getCustomers(Params);
            List<Customers> lc = new List<Customers>();
            Customers c;
            foreach (DataRow item in ds.Tables[0].Rows)
            {
                c = new Customers();
                c.Id = BLCtrl.getString(item, "id", "");
                c.FirstName = BLCtrl.getString(item, "FirstName"," ");
                c.LastName = BLCtrl.getString(item, "LastName"," ");
                c.Phone = BLCtrl.getString(item, "Phone", " ");
                c.Phone2 = BLCtrl.getString(item, "Phone2"," ");
                c.City = BLCtrl.getString(item, "City"," ");
                c.Street = BLCtrl.getString(item, "Street"," ");
                lc.Add(c);
            }           
            return lc;
        }
    }
}
