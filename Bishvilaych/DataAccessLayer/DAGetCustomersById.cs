using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

//Ayala Gozlan

namespace DataAccessLayer
{
    public class DAGetCustomersById
    {
        private string connStr = null;

        public DAGetCustomersById()
        {
            connStr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        }

        //public Patiants getPatiantsById()
        //{
        //    throw new NotImplementedException();
        //}


        //Ayala Gozlan
        //select
        //לשנות את שם הפונקציה ואת שם הפרוצדורה
        public DataSet getCustomersById(ListDictionary Params) //קבלת רשימת פרמטרים
        {
            DBCtrl db_ctrl = new DBCtrl();
            if (!db_ctrl.isConnected())
            {
                db_ctrl.connectToDb(connStr);
            }

            string sp_name = "getCustomersById"; //שם הפרוצדורה
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
