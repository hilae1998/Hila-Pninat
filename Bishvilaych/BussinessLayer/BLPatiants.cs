using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using System.Data;

namespace BussinessLayer
{
    //Ayala Gozlan
    public class BLPatiants
    {
        public int UpdatePatiant(string id, string fname, string lname, string doctor, string reffered, string language, string city, string street, string phon, string phon2, string fax, string email, DateTime birthdate, string contactexam, string contactginformation, string father, string mother, int kupa, int maritalstatus, int children, int g, int t, int p, int a, int l, bool followup, string occapation, bool followedup)
        {
            DAPatiants dm = new DAPatiants();
            ListDictionary Params = new ListDictionary();
            Params.Add("@id", BLCtrl.sendString(id, ""));
            Params.Add("@fname", BLCtrl.sendString(fname, ""));
            Params.Add("@lname", BLCtrl.sendString(lname, ""));
            Params.Add("@doctor", BLCtrl.sendString(doctor, ""));
            Params.Add("@reffered", BLCtrl.sendString(reffered, ""));
            Params.Add("@language", BLCtrl.sendString(language,""));
            Params.Add("@city", BLCtrl.sendString(city, ""));
            Params.Add("@street", BLCtrl.sendString(street, ""));
            Params.Add("@phon", BLCtrl.sendString(phon, ""));
            Params.Add("@phon2", BLCtrl.sendString(phon2, ""));
            Params.Add("@fax", BLCtrl.sendString(fax, ""));
            Params.Add("@email", BLCtrl.sendString(email, ""));
            Params.Add("@birthdate", BLCtrl.sendDateTime(birthdate, DateTime.Today));
            Params.Add("@contactexam", BLCtrl.sendString(contactexam, ""));
            Params.Add("@contactginformation", BLCtrl.sendString(contactginformation, ""));
            Params.Add("@father", BLCtrl.sendString(father, ""));
            Params.Add("@mother", BLCtrl.sendString(mother, ""));
            Params.Add("@kupa", BLCtrl.sendInt(kupa, 0));
            Params.Add("@maritalstatus", BLCtrl.sendInt(maritalstatus, 0));
            Params.Add("@children", BLCtrl.sendInt(children, 0));
            Params.Add("@g", BLCtrl.sendInt(g, 0));
            Params.Add("@t", BLCtrl.sendInt(t, 0));
            Params.Add("@p", BLCtrl.sendInt(p, 0));
            Params.Add("@a", BLCtrl.sendInt(a, 0));
            Params.Add("@l", BLCtrl.sendInt(l, 0));
            Params.Add("@followup", BLCtrl.sendBool(followup, false));
            Params.Add("@occapation", BLCtrl.sendString(occapation, ""));
            Params.Add("@followedup", BLCtrl.sendBool(followedup, false));

            
            int result = dm.UpdatePatiant(Params);
            return result;

        }

        public Patiants getPatiantsById(string id)
        {
            DAPatiants da = new DAPatiants();
            ListDictionary Params = new ListDictionary();
            Params.Add("@id", id);
            DataSet ds = da.getPatiantsById(Params);
            Patiants p = new Patiants();
            p.A = BLCtrl.getInt(ds.Tables[0].Rows[0], "A", 0);
            p.BirthDate = BLCtrl.getDateTime(ds.Tables[0].Rows[0],"BirthDate", DateTime.Today);
            p.Children = BLCtrl.getInt(ds.Tables[0].Rows[0], "Children", 0);
            p.City = BLCtrl.getString(ds.Tables[0].Rows[0], "City", "");
            p.Code = BLCtrl.getInt(ds.Tables[0].Rows[0], "Code", 0);
            p.ContactExam = BLCtrl.getString(ds.Tables[0].Rows[0], "ContactExam", "");
            p.ContactGinformation = BLCtrl.getString(ds.Tables[0].Rows[0], "ContactGinformation", "");
            p.Doctor = BLCtrl.getString(ds.Tables[0].Rows[0], "Doctor", "");
            p.Email = BLCtrl.getString(ds.Tables[0].Rows[0], "Email", "");
            p.FathersOrigin = BLCtrl.getString(ds.Tables[0].Rows[0], "FathersOrigin", "");
            p.Fax = BLCtrl.getString(ds.Tables[0].Rows[0], "Fax", "");
            p.FirstName = BLCtrl.getString(ds.Tables[0].Rows[0], "FirstName", "");
            p.followedup = BLCtrl.getBool(ds.Tables[0].Rows[0], "followedup", false);
            p.FollowUp = BLCtrl.getBool(ds.Tables[0].Rows[0], "FollowUp", false);
            p.G = BLCtrl.getInt(ds.Tables[0].Rows[0], "G", 0);
            p.Id = BLCtrl.getString(ds.Tables[0].Rows[0], "Id", "");
            p.Kupah = BLCtrl.getInt(ds.Tables[0].Rows[0], "Kupah", 0);
            p.L = BLCtrl.getInt(ds.Tables[0].Rows[0], "L", 0);
            p.Language = BLCtrl.getString(ds.Tables[0].Rows[0], "Language", "");
            p.LastName = BLCtrl.getString(ds.Tables[0].Rows[0], "LastName", "");
            p.MaritalStatus = BLCtrl.getInt(ds.Tables[0].Rows[0], "MaritalStatus", 0);
            p.MothersOrigin = BLCtrl.getString(ds.Tables[0].Rows[0], "MothersOrigin", "");
            p.Occupation = BLCtrl.getString(ds.Tables[0].Rows[0], "Occupation", "");
            p.P = BLCtrl.getInt(ds.Tables[0].Rows[0], "P", 0);
            p.Phone = BLCtrl.getString(ds.Tables[0].Rows[0], "Phone", "");
            p.Phone2 = BLCtrl.getString(ds.Tables[0].Rows[0], "Phone2", "");
            p.reffered = BLCtrl.getString(ds.Tables[0].Rows[0], "reffered", "");
            p.Street = BLCtrl.getString(ds.Tables[0].Rows[0], "Street", "");
            p.T = BLCtrl.getInt(ds.Tables[0].Rows[0], "T", 0);

            return p;

        }
    }
}
