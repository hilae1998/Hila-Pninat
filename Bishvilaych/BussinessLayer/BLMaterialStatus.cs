using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using System.Data;
using BussinessLayer;

namespace BussinessLayer
{
    public class BLMaterialStatus
    {
        public List<MaritalStatus> getMaterialStatus()
        {
            DAMaterialStatus dams = new DAMaterialStatus();
            ListDictionary Params = new ListDictionary();
            DataSet ds = dams.getMaterialStatus();
            List<MaritalStatus> lms = new List<MaritalStatus>();
            MaritalStatus ms;
            foreach (DataRow item in ds.Tables[0].Rows)
            {
                ms = new MaritalStatus();
                ms.Code = BLCtrl.getInt(item, "Code", 0);
                ms.Maritalstatus = BLCtrl.getString(item, "Maritalstatus", "");
                lms.Add(ms);
            }
            return lms;
        }
    }
}
