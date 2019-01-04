using BussinessLayer;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer
{
    //moriyabonan
    public class BLWorker
    {
        //public int CheckWorker(string Id,int myout1)
        //   {

        //   DAWorker dm = new DAWorker();
        //   ListDictionary Params = new ListDictionary();
        //   Params.Add("@id", Id);
        //   Params.Add("@@myOut", myout1);
        //   int result = dm.CheckWorker(Params);
        //   return result;

        //   }
        public int Cheak_JobUser(string username, string password)
        {
            DAWorker dm = new DAWorker();

            ListDictionary Params = new ListDictionary();
            Params.Add("@username", BLCtrl.sendString(username, ""));
            Params.Add("@password", BLCtrl.sendString(password, ""));
            int result = dm.Cheak_JobUser(Params);
            return result;

        }

    }
}
