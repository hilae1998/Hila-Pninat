using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// לאה אמסלם
// 21/06/18
namespace DataAccessLayer
{
    public class DACheck_Patient
    {
        private string connStr = null;

        public DACheck_Patient()
        {
            connStr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        }

        public DataSet Check_Patient()
        {
            throw new NotImplementedException();
        }



        //insert, update...
        //לשנות את שם הפונקציה ואת שם הפרוצדורה
        public int Check_Patient(ListDictionary Params) //קבלת רשימת פרמטרים
        {
            DBCtrl db_ctrl = new DBCtrl();
            if (!db_ctrl.isConnected())
            {
                db_ctrl.connectToDb(connStr);
            }

            string sp_name = "Check_Patient"; //שם הפרוצדורה

            return db_ctrl.ExecuteNonQueryFunction(connStr, sp_name, ref Params); //החזרת תוצאה
        }

    }
}

