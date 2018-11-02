using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    class DAStiker
    {
        private string connStr = null;

        public int Get_Stiker(ListDictionary Params) //קבלת רשימת פרמטרים
        {
            DBCtrl db_ctrl = new DBCtrl();
            if (!db_ctrl.isConnected())
            {
                db_ctrl.connectToDb(connStr);
            }

            string sp_name = "Get_Stiker"; //שם הפרוצדורה

            return db_ctrl.ExecuteNonQueryFunction(connStr, sp_name, ref Params); //החזרת תוצאה
        }
    }
}
