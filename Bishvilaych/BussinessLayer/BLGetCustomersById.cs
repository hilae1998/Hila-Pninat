using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using System.Data;

//Ayala Gozlan

namespace BussinessLayer
{
    public class BLGetCustomersById
    {
        public Customers getCustomersById(string id)
        {
            DAGetCustomersById da = new DAGetCustomersById();
            ListDictionary Params = new ListDictionary();
            Params.Add("@id", id);
            DataSet ds = da.getCustomersById(Params);
            Customers c = new Customers();
            c.City = BLCtrl.getString(ds.Tables[0].Rows[0], "City", "");
            c.Code = BLCtrl.getInt(ds.Tables[0].Rows[0], "Code", 0);
            c.FirstName = BLCtrl.getString(ds.Tables[0].Rows[0], "FirstName", "");
            c.Id = BLCtrl.getString(ds.Tables[0].Rows[0], "Id", "");
            c.LastName = BLCtrl.getString(ds.Tables[0].Rows[0], "LastName", "");
            c.Phone = BLCtrl.getString(ds.Tables[0].Rows[0], "Phone", "");
            c.Phone2 = BLCtrl.getString(ds.Tables[0].Rows[0], "Phone2", "");
            c.Street = BLCtrl.getString(ds.Tables[0].Rows[0], "Street", "");
            return c;
        }
    }
}
