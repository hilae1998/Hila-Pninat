using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Data;
using System.Data.Common;
using System.Collections.Specialized;

namespace DataAccessLayer
{
    class DBCtrl
    {
        private SqlConnection dbConn;

        public DBCtrl()
        {
            dbConn = null;
        }


        public bool isConnected()
        {
            return ((dbConn != null) && (dbConn.State == System.Data.ConnectionState.Open));
        }

        internal void connectToDb(object connStr)
        {
            throw new NotImplementedException();
        }

        public bool connectToDb(string conn_str)
        {

            if (dbConn == null)
                dbConn = new SqlConnection(conn_str);

            dbConn.ConnectionString = conn_str;
            try

            {
                //dbConn.
                dbConn.Open();
                

                return true;

            }
            catch (Exception e)
            {
                return false;
                throw e;
            }   
        }

        internal static bool GetDataSetOut(object connStr, string sp_name, ListDictionary @params, ref DataSet retDataDs, out string retError)
        {
            throw new NotImplementedException();
        }

        public bool closeConnDB()
        {
            if (dbConn != null)
            {

                try
                {
                    dbConn.Close();
                    return true;
                }
                catch (Exception e)
                {

                    throw e;
                }
            }

            return false;
        }

        // GetDataTable
       public DataTable GetDataTable(string ConnectionString, string StoredProcedure, ref ListDictionary Params)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(StoredProcedure, ConnectionString);
            string param = null;
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            try
            {
                if (Params != null)
                {
                    foreach (string param_loopVariable in Params.Keys)
                    {
                        param = param_loopVariable;
                        da.SelectCommand.Parameters.AddWithValue(param, Params[param]);
                    }
                }

                da.Fill(dt);
            }
            catch (Exception ex)
            {
                throw ex;
                //to_do
                //Logger.LoggerManager.Error("GetDataTable: " + StoredProcedure + ", " + ex.ToString());
            }
            return dt;
        }

        // GetDataSet
        public DataSet GetDataSet(string ConnectionString, string StoredProcedure, ref ListDictionary Params)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(StoredProcedure, ConnectionString);
            string param = null;
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            try
            {
                if (Params != null)
                {
                    foreach (string param_loopVariable in Params.Keys)
                    {
                        param = param_loopVariable;
                        da.SelectCommand.Parameters.AddWithValue(param, Params[param]);
                    }
                }

                da.Fill(ds);
            }
            catch (Exception ex)
            {
                throw ex;
                //to_do
                //Logger.LoggerManager.Error("GetDataSet: " + StoredProcedure + ", " + ex.ToString());
            }
            return ds;
        }

        // GetDataSet NewFormat 
        public static bool GetDataSetOut(string connectionString, string storedProcedure, ListDictionary Params, ref DataSet ds, out string retError)
        {
            ds = null;
            retError = null;

            try
            {
                ds = new DataSet();
                //connection to the SQl + SP
                SqlDataAdapter sqlDa = new SqlDataAdapter(storedProcedure, connectionString)
                { SelectCommand = { CommandType = CommandType.StoredProcedure } };
                if (Params != null) //checks if there are any params to add and add's them
                {
                    foreach (string paramLoopVariable in Params.Keys)
                    {
                        string param = paramLoopVariable;
                        sqlDa.SelectCommand.Parameters.AddWithValue(param, Params[param]);
                    }
                }
                sqlDa.Fill(ds); //Fill the ds(DataSet) with results from DB
                return true;
            }
            catch (Exception e) //If error occures send error by retError
            {
                retError = e.ToString();
                return false;
            }
           
        }

        //// ExecuteNonQuery
        //public void ExecuteNonQuery(string ConnectionString, string StoredProcedure, ref ListDictionary Params)
        //{
        //    SqlCommand cmd = new SqlCommand();
        //    string param = null;
        //    try
        //    {
        //        cmd.CommandText = StoredProcedure;
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.Connection = new SqlConnection(ConnectionString);

        //        if (Params != null)
        //        {
        //            foreach (string param_loopVariable in Params.Keys)
        //            {
        //                param = param_loopVariable;
        //                cmd.Parameters.AddWithValue(param, Params[param]);
        //            }
        //        }

        //        cmd.Connection.Open();
        //        cmd.ExecuteNonQuery();
        //        cmd.Connection.Close();

        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //        //to_do
        //        //Logger.LoggerManager.Error("ExecuteNonQuery: " + StoredProcedure + ", " + ex.ToString());
        //    }
        //}

        // ExecuteNonQueryFunction - return integer
        public int ExecuteNonQueryFunction(string ConnectionString, string StoredProcedure, ref ListDictionary Params)
        {
            SqlCommand cmd = new SqlCommand();
            string param = null;
            int returnvalue = -1;//If the procedure runs successfully, the value changes to positiv num 
            try
            {
                cmd.CommandText = StoredProcedure;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = new SqlConnection(ConnectionString);
                if (Params != null)//add parameters to procedure
                {
                    foreach (string param_loopVariable in Params.Keys)
                    {
                        param = param_loopVariable;
                        cmd.Parameters.AddWithValue(param, Params[param]);
                    }
                }
                cmd.Parameters.Add("@myOut", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();//execute the procedure
                cmd.Connection.Close();
                returnvalue = Convert.ToInt32(cmd.Parameters["@myOut"].Value);
            }
            catch (Exception ex)
            {
               // throw ex;
                //TODO: throw exception to client side
            }
            finally
            {
                cmd.Connection.Close();
            }
            return returnvalue;
        }


    }
}