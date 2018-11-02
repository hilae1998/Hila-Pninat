using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Specialized;

//Ayala Gozlan

namespace DataAccessLayer
{
    public class DAReceipt
    {

        private string connStr = null;

        public DAReceipt()
        {
            connStr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        }



        //select
        //לשנות את שם הפונקציה ואת שם הפרוצדורה
        public DataSet getReceipt(ListDictionary Params) //קבלת רשימת פרמטרים
        {
            DBCtrl db_ctrl = new DBCtrl();
            if (!db_ctrl.isConnected())
            {
                db_ctrl.connectToDb(connStr);
            }

            string sp_name = "getReceipt"; //שם הפרוצדורה
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
