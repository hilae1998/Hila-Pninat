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
    // לאה אמסלם
    // 27/5/18
    public class DACustomers
    {
        private string connStr = null;

        public DACustomers()
        {
            connStr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        }

        public DataSet getCustomers()
        {
            throw new NotImplementedException();
        }



        //select
        //לשנות את שם הפונקציה ואת שם הפרוצדורה
        public DataSet getCustomers(ListDictionary Params) //קבלת רשימת פרמטרים
        {
            DBCtrl db_ctrl = new DBCtrl();
            if (!db_ctrl.isConnected())
            {
                db_ctrl.connectToDb(connStr);
            }

            string sp_name = "getCustomers"; //שם הפרוצדורה
            DataSet retDataDs = new DataSet(); //הכנת הטבלה אליה יכנסו הנתונים
            string retError;

            if (DBCtrl.GetDataSetOut(connStr, sp_name, Params, ref retDataDs, out retError) == true)
            {
                db_ctrl.closeConnDB();
            }

            return retDataDs; //החזרת הטבלה המלאה בנתונים
        }

    }
}
