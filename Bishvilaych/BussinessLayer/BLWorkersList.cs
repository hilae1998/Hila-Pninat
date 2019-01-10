using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BussinessLayer
{
   public class BLWorkersList
    {
        public List<Workers> getWorkers()
        {
            WorkersList dm = new WorkersList();

            ListDictionary Params = new ListDictionary();

            DataSet ds = dm.getWorkers(Params);
            List<Workers> l = new List<Workers>();
            Workers w;
            foreach (DataRow item in ds.Tables[0].Rows)
            {
                w = new Workers();
                w.Id = BLCtrl.getString(item, "Id", " ");
                w.FirstName = BLCtrl.getString(item, "FirstName", " ");
                w.LastName = BLCtrl.getString(item, "LastName", " ");
                w.Job = BLCtrl.getInt(item, "Job",0);
                l.Add(w);

            }
            return l;
        }
    }
}
