using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public class BL_AddWorker
    {
        public int Add_Worker(string Id, string FirstName, string LastName)
        {
            DA_Add_Worker dm = new DA_Add_Worker();

            ListDictionary Params = new ListDictionary();
            Params.Add("@Id", BLCtrl.sendString(Id, ""));
            Params.Add("@FirstName", BLCtrl.sendString(FirstName, ""));
            Params.Add("@LastName", BLCtrl.sendString(LastName, ""));

            int result = dm.Add_Worker(Params);

            return result;
        }
        public int CheckWorkerID(string Id)
        {
            DA_Add_Worker dm = new DA_Add_Worker();

            ListDictionary Params = new ListDictionary();
            Params.Add("@id", BLCtrl.sendString(Id, ""));


            int result = dm.CheckWorkerID(Params);

            return result;
        }
    }
}