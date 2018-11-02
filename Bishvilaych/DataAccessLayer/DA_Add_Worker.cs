using System.Configuration;
using System.Collections.Specialized;
using DataAccessLayer;

namespace DataAccessLayer
{
    public class DA_Add_Worker
    {
        private string connStr = null;

        public DA_Add_Worker()
        {
            connStr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        }

        //insert, update...
        //לשנות את שם הפונקציה ואת שם הפרוצדורה
        public int Add_Worker(ListDictionary Params) //קבלת רשימת פרמטרים
        {
            DBCtrl db_ctrl = new DBCtrl();
            if (!db_ctrl.isConnected())
            {
                db_ctrl.connectToDb(connStr);
            }

            string sp_name = "Add_Worker"; //שם הפרוצדורה

            return db_ctrl.ExecuteNonQueryFunction(connStr, sp_name, ref Params); //החזרת תוצאה
        }

        public int CheckWorkerID(ListDictionary Params) //קבלת רשימת פרמטרים
        {
            DBCtrl db_ctrl = new DBCtrl();
            if (!db_ctrl.isConnected())
            {
                db_ctrl.connectToDb(connStr);
            }

            string sp_name = "CheckWorkerID"; //שם הפרוצדורה

            return db_ctrl.ExecuteNonQueryFunction(connStr, sp_name, ref Params); //החזרת תוצאה
        }

    }
}
