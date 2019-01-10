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
   public class DAVisitReason
    {
            private string connStr = null;

            public DAVisitReason()
            {
                connStr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            }
            public DataSet getVisitReason(ListDictionary Params) //קבלת רשימת פרמטרים
            {
                DBCtrl db_ctrl = new DBCtrl();
                if (!db_ctrl.isConnected())
                {
                    db_ctrl.connectToDb(connStr);
                }

                string sp_name = "getVisitReason"; //שם הפרוצדורה
                DataSet retDataDs = new DataSet(); //הכנת הטבלה אליה יכנסו הנתונים
                string retError;

                if (DBCtrl.GetDataSetOut(connStr, sp_name, Params, ref retDataDs, out retError) == true)
                {
                    db_ctrl.closeConnDB();
                }

                return retDataDs; //החזרת הטבלה המלאה בנתונים
            }

            public int addOrUpdateVisitReason(ListDictionary Params) //קבלת רשימת פרמטרים
            {
                DBCtrl db_ctrl = new DBCtrl();
                if (!db_ctrl.isConnected())
                {
                    db_ctrl.connectToDb(connStr);
                }

                string sp_name = "addOrUpdateVisitReason"; //שם הפרוצדורה

                return db_ctrl.ExecuteNonQueryFunction(connStr, sp_name, ref Params); //החזרת תוצאה
        }
    }
}
