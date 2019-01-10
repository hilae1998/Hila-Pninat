using DataAccessLayer;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;

namespace BussinessLayer
{
   public class BLAddCustomer
    {
        public int Add_Customers( string id ,string firstName,string lastName,
                           string phone,string phone2,string city,string street )
        {
            DAAddCustomer dm = new DAAddCustomer();
            ListDictionary Params = new ListDictionary();
            Params.Add("@Id", BLCtrl.sendString(id, ""));
            Params.Add("@FristName", BLCtrl.sendString(firstName,""));
            Params.Add("@LastName", BLCtrl.sendString(lastName, ""));
            Params.Add("@Phone", BLCtrl.sendString(phone,""));
            Params.Add("@Pone2", BLCtrl.sendString(phone2,""));
            Params.Add("@City", BLCtrl.sendString(city, ""));
            Params.Add("@Street", BLCtrl.sendString(street,""));
           
            int result = dm.Add_Customers(Params);
            return result;
        }
        public int CheckCustomerID(string Id)
        {
            DAAddCustomer dm = new DAAddCustomer();

            ListDictionary Params = new ListDictionary();
            Params.Add("@id", BLCtrl.sendString(Id, ""));


            int result = dm.CheckCustomerID(Params);

            return result;
        }
    }
}
