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
    public class DAgetUpdateDateAndCode
    {
        private string connStr = null;

        public DAgetUpdateDateAndCode()
        {
            connStr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        }

        public DataSet getPastGenicology()
        {
            throw new NotImplementedException();
        }
        //select
        public DataSet getUpdateDateAndCode(ListDictionary Params) //קבלת רשימת פרמטרים
        {
            DBCtrl db_ctrl = new DBCtrl();
            if (!db_ctrl.isConnected())
            {
                db_ctrl.connectToDb(connStr);
            }

            string sp_name = "getUpdateDateAndCode"; //שם הפרוצדורה
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
