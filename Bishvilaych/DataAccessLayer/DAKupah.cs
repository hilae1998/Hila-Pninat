using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// לאה אמסלם
// 10/07/18--17/07/18
namespace DataAccessLayer
{
    public class DAKupah
    {
        private string connStr = null;

        public DAKupah()
        {
            connStr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        }
        //select
        //לשנות את שם הפונקציה ואת שם הפרוצדורה
        public DataSet Kupah(ListDictionary Params) //קבלת רשימת פרמטרים
        {
            DBCtrl db_ctrl = new DBCtrl();
            if (!db_ctrl.isConnected())
            {
                db_ctrl.connectToDb(connStr);
            }

            string sp_name = "Kupah"; //שם הפרוצדורה
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
