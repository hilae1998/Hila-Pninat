using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    //moriyabonan
    public class DAWorker
    {
        private string connStr = null;

        public DAWorker()
        {
            connStr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        }

        public int CheckWorker(ListDictionary Params) 
        {
            DBCtrl DW_ctrl = new DBCtrl();
            if (!DW_ctrl.isConnected())
            {
                DW_ctrl.connectToDb(connStr);
            }

            string sp_name = "CheckWorker"; 

            return DW_ctrl.ExecuteNonQueryFunction(connStr, sp_name, ref Params); //החזרת תוצאה
        }
        
    }
}
