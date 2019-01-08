using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public static class BLCtrl
    {
        //send
        public static int sendInt(object item, int defaultItem)
        {
            if (item != null)
                return (int)item;
            return defaultItem;
        }

        public static float sendFloat(object item, float defaultItem)
        {
            if (item != null)
                return (float)item;
            return defaultItem;
        }
        public static double sendDouble(object item, double defaultItem)
        {
            if (item != null)
                return (double)item;
            return defaultItem;
        }

        public static string sendString(object item, string defaultItem)
        {
            if (item != null)
                return (string)item;
            return defaultItem;
        }

        public static DateTime sendDateTime(object item, DateTime defaultItem)
        {
            if (item != null)
               
                return (DateTime)item;
            return defaultItem;
        }

        public static bool sendBool(object item, bool defaultItem)
        {
            if (item != null)
                return (bool)item;
            return defaultItem;
        }


        //get
        public static int getInt(DataRow dr, string itemName, int defaultItem)
        {
            int f;
            try
            {
                f = dr.Field<int>(itemName);
            }
            catch
            {
                return defaultItem;
            }
            if (f != null)
                return f;
            return defaultItem;
        }

        public static float getFloat(DataRow dr, string itemName, float defaultItem)
        {
            double f;
            try
            {
                f = dr.Field<double>(itemName);
            }
            catch(Exception ex)
            {
                return defaultItem;
            }
            if (f != null)
                return (float)f;
            return defaultItem;
        }

        public static double getDouble(DataRow dr, string itemName, double defaultItem)
        {
            double f;
            try
            {
                f = dr.Field<double>(itemName);
            }
            catch
            {
                return defaultItem;
            }
            //if (f != null)
            //    return f;
            return defaultItem;
        }


        public static string getString(DataRow dr, string itemName, string defaultItem)
        {
            string f;
            try
            {
                f = dr.Field<string>(itemName);
            }
            catch(Exception e)
            {
                return defaultItem;
            }
            if (f != null && f != string.Empty)
                return f;
            return defaultItem;
        }

        public static DateTime getDateTime(DataRow dr, string itemName, DateTime defaultItem)
        {
            DateTime f;
            try
            {
                f = dr.Field<DateTime>(itemName);
            }
            catch
            {
                return defaultItem;
            }
            if (f != null)
                return f;
            return defaultItem;
        }

        public static bool getBool(DataRow dr, string itemName, bool defaultItem)
        {
            bool f;
            try
            {
                f = dr.Field<bool>(itemName);
            }
            catch
            {
                return defaultItem;
            }
            if (f != null)
                return f;
            return defaultItem;
        }

    }
}
