using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Avishag Charatz

namespace DataAccessLayer
    {
        public class DAL_AddDiagnozeAndHospitalization
        {

            private string connStr = null;

            public DAL_AddDiagnozeAndHospitalization()
            {
                connStr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            }

            //שליפת אבחנה
            public DataSet Draw_Diagnoze(ListDictionary Params) //קבלת רשימת פרמטרים
            {
                DBCtrl db_ctrl = new DBCtrl();
                if (!db_ctrl.isConnected())
                {
                    db_ctrl.connectToDb(connStr);
                }

                string sp_name = "Draw_Diagnoze"; //שם הפרוצדורה
                DataSet retDataDs = new DataSet(); //הכנת הטבלה אליה יכנסו הנתונים
                string retError;

                if (DBCtrl.GetDataSetOut(connStr, sp_name, Params, ref retDataDs, out retError) == true)
                {
                    db_ctrl.closeConnDB();
                }

                return retDataDs; //החזרת הטבלה המלאה בנתונים
            }

            //שליפת סטטוס
            public DataSet Draw_Status(ListDictionary Params) //קבלת רשימת פרמטרים
            {
                DBCtrl db_ctrl = new DBCtrl();
                if (!db_ctrl.isConnected())
                {
                    db_ctrl.connectToDb(connStr);
                }

                string sp_name = "Draw_Status"; //שם הפרוצדורה
                DataSet retDataDs = new DataSet(); //הכנת הטבלה אליה יכנסו הנתונים
                string retError;

                if (DBCtrl.GetDataSetOut(connStr, sp_name, Params, ref retDataDs, out retError) == true)
                {
                    db_ctrl.closeConnDB();
                }

                return retDataDs; //החזרת הטבלה המלאה בנתונים
            }


        //הוספת אבחון
        public int Add_Diagnoze(ListDictionary Params) //קבלת רשימת פרמטרים
            {
                DBCtrl db_ctrl = new DBCtrl();
                if (!db_ctrl.isConnected())
                {
                    db_ctrl.connectToDb(connStr);
                }

                string sp_name = "Add_Diagnoze"; //שם הפרוצדורה

                return db_ctrl.ExecuteNonQueryFunction(connStr, sp_name, ref Params); //החזרת תוצאה
            }
        public int Update_Diagnoze(ListDictionary Params) //קבלת רשימת פרמטרים
        {
            DBCtrl db_ctrl = new DBCtrl();
            if (!db_ctrl.isConnected())
            {
                db_ctrl.connectToDb(connStr);
            }

            string sp_name = "Update_Diagnoze"; //שם הפרוצדורה

            return db_ctrl.ExecuteNonQueryFunction(connStr, sp_name, ref Params); //החזרת תוצאה
        }
      



        //שליפת בית חולים
        public DataSet Draw_Hospital(ListDictionary Params) //קבלת רשימת פרמטרים
            {
                   DBCtrl db_ctrl = new DBCtrl();
                if (!db_ctrl.isConnected())
                {
                    db_ctrl.connectToDb(connStr);
                }

                string sp_name = "Draw_Hospital"; //שם הפרוצדורה
                DataSet retDataDs = new DataSet(); //הכנת הטבלה אליה יכנסו הנתונים
                string retError;

                if (DBCtrl.GetDataSetOut(connStr, sp_name, Params, ref retDataDs, out retError) == true)
                {
                    db_ctrl.closeConnDB();
                }

                return retDataDs; //החזרת הטבלה המלאה בנתונים
            }

        //הוספת אשפוז
        public int Add_Hospitalization(ListDictionary Params) //קבלת רשימת פרמטרים
            {
                DBCtrl db_ctrl = new DBCtrl();
                if (!db_ctrl.isConnected())
                {
                    db_ctrl.connectToDb(connStr);
                }

                string sp_name = "Add_Hospitalization"; //שם הפרוצדורה

                return db_ctrl.ExecuteNonQueryFunction(connStr, sp_name, ref Params); //החזרת תוצאה
            }
        public int Update_Hospitalization(ListDictionary Params) //קבלת רשימת פרמטרים
        {
            DBCtrl db_ctrl = new DBCtrl();
            if (!db_ctrl.isConnected())
            {
                db_ctrl.connectToDb(connStr);
            }

            string sp_name = "Update_Hospitalization"; //שם הפרוצדורה

            return db_ctrl.ExecuteNonQueryFunction(connStr, sp_name, ref Params); //החזרת תוצאה
        }
     
    }
    }
