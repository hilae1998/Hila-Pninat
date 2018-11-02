using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// לאה אמסלם
// 21/06/18
namespace BussinessLayer
{
   public class BLCheck_Customers
    {
        public int Check_Customers(string idCustomer)
        {
            DACheck_Customers dcc = new DACheck_Customers();
            ListDictionary Params = new ListDictionary();
            Params.Add("@id", BLCtrl.sendString(idCustomer, ""));
            int result = dcc.Check_Customers(Params);
            return result;
        }
    }
}
