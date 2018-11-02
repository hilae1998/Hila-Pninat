using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//אורית אוחיון
namespace BussinessLayer
{
    public class BLPatientList
    {
        public List<Patiants> getPatiants()
        {
            PatientsList dm = new PatientsList();

            ListDictionary Params = new ListDictionary();
            // Params.Add("@dt", dt);

            DataSet ds = dm.getPatiants(Params);
            List<Patiants> l = new List<Patiants>();
            Patiants p;
            foreach (DataRow item in ds.Tables[0].Rows)
            {
               // f.FollowUp = BLCtrl.getString(item, "FollowUp", "");
                p = new Patiants();
                // p.Id = item.Field<string>("Id");
                //p.FirstName = item.Field<string>("FirstName");
                //p.Doctor = item.Field<string>("Doctor");
                p.Id = BLCtrl.getString(item, "Id", " ");
                p.FirstName = BLCtrl.getString(item, "FirstName", " ");
                p.LastName = BLCtrl.getString(item, "LastName", " ");
                p.Doctor = BLCtrl.getString(item, "Doctor", " ");
                l.Add(p);

            }

            return l;

        }
    }
}
