using System;
using System.Data;
using System.Collections.Specialized;
using System.Configuration;

namespace DataAccessLayer
{
    public class DBMapper
    {
        private string connStr = null;

        public DBMapper()
        {
            connStr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        }

        public DataSet BLAddOrUpdateScreeningsKings()
        {
            throw new NotImplementedException();
        }

        public DataSet BLgetScreeningsKings()
        {
            throw new NotImplementedException();
        }

        public DataSet getUsers(ListDictionary Params) //קבלת רשימת פרמטרים
        {
            DBCtrl db_ctrl = new DBCtrl();
            if (!db_ctrl.isConnected())
            {
                db_ctrl.connectToDb(connStr);
            }

            string sp_name = "getUsers"; //שם הפרוצדורה
            DataSet retDataDs = new DataSet(); //הכנת הטבלה אליה יכנסו הנתונים
            string retError;

            if (DBCtrl.GetDataSetOut(connStr, sp_name, Params, ref retDataDs, out retError) == true)
            {
                db_ctrl.closeConnDB();
            }

             return retDataDs; //החזרת הטבלה המלאה בנתונים
        }
        public int addUser(ListDictionary Params) //קבלת רשימת פרמטרים
        {
            DBCtrl db_ctrl = new DBCtrl();
            if (!db_ctrl.isConnected())
            {
                db_ctrl.connectToDb(connStr);
            }

            string sp_name = "addUser"; //שם הפרוצדורה

            return db_ctrl.ExecuteNonQueryFunction(connStr, sp_name, ref Params); //החזרת תוצאה
        }

    }
}
