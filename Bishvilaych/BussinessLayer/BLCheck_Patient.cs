using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
  public  class BLCheck_Patient
    {
        public int Check_Patient(string id1)
        {
            DACheck_Patient dcp = new DACheck_Patient();
            ListDictionary Params = new ListDictionary();
            Params.Add("@id", BLCtrl.sendString(id1, "") );
            int result = dcp.Check_Patient(Params);
            return result;
        }
    }
}
