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
    //creat by ortal alon
   public class DAPhyicalExam
    {
        private string connStr = null;

        public DAPhyicalExam()
        {
            connStr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        }
        public DataSet AddOrUpdatePhysicalExam()
        {
            throw new NotImplementedException();
        }

        //select
        //לשנות את שם הפונקציה ואת שם הפרוצדורה
        public DataSet GetPhyicalExam(ListDictionary Params) //קבלת רשימת פרמטרים
        {
            DBCtrl db_ctrl = new DBCtrl();
            if (!db_ctrl.isConnected())
            {
                db_ctrl.connectToDb(connStr);
            }
            
            string sp_name = "GetPhysicalExam"; //שם הפרוצדורה
            DataSet retDataDs = new DataSet(); //הכנת הטבלה אליה יכנסו הנתונים
            string retError;

            if (DBCtrl.GetDataSetOut(connStr, sp_name, Params, ref retDataDs, out retError) == true)
            {
                db_ctrl.closeConnDB();
            }

            return retDataDs; //החזרת הטבלה המלאה בנתונים
        }


        //insert, update...
        //לשנות את שם הפונקציה ואת שם הפרוצדורה
        public int AddOrUpdatePhysicalExam(ListDictionary Params) //קבלת רשימת פרמטרים
        {
            DBCtrl db_ctrl = new DBCtrl();
            if (!db_ctrl.isConnected())
            {
                db_ctrl.connectToDb(connStr);
            }

            string sp_name = "AddOrUpdatePhysicalExam1"; //שם הפרוצדורה

            return db_ctrl.ExecuteNonQueryFunction(connStr, sp_name, ref Params); //החזרת תוצאה
        }
    }
}
