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
   public class BLCheck_Workers
    {
        public int Check_Workers(string idWorkers)
        {
            DACheck_Workers dcw = new DACheck_Workers();
            ListDictionary Params = new ListDictionary();
            Params.Add("@id", BLCtrl.sendString(idWorkers, ""));
            int result = dcw.Check_Workers(Params);
            return result;
        }
    }
}
