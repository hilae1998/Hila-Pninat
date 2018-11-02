using BussinessLayer;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer
{
   public class BLWorkerDetails//created by hila elgrabli
    {
       
        public int UpdateWorker(string id1 , string FirstName1, string LastName1 
                                ,int Job1, int WokerAuthorization1,
                                string City1,string Street1 ,string Phone1,
                                string Phone2,string Fax1,string Email1, DateTime BirthDate1
                              )
        {
            DA_Worker_Details dm = new DA_Worker_Details();
            ListDictionary Params = new ListDictionary();
            Params.Add("@id",BLCtrl.sendString( id1,""));
            Params.Add("@FirstName",BLCtrl.sendString( FirstName1,""));
            Params.Add("@LastName", BLCtrl.sendString(LastName1,""));
            Params.Add("@Job", BLCtrl.sendInt(Job1,0));
            Params.Add("@WokerAuthorization", BLCtrl.sendInt(WokerAuthorization1,0));
            Params.Add("@City", BLCtrl.sendString(City1,""));
            Params.Add("@Street", BLCtrl.sendString(Street1,""));
            Params.Add("@Phone", BLCtrl.sendString(Phone1,""));
            Params.Add("@Phone2", BLCtrl.sendString(Phone2,""));
            Params.Add("@Fax", BLCtrl.sendString(Fax1,""));
            Params.Add("@Email", BLCtrl.sendString(Email1,""));
            Params.Add("@BirthDate", BLCtrl.sendDateTime(BirthDate1,new DateTime()));
           
            int result = dm.UpdateWorker(Params);
            return result;

        }



        public int UpdateUserNameAndPassword(string id1 ,string UserName1,string UserPassword1)
        {
            DA_Worker_Details dm = new DA_Worker_Details();
            ListDictionary Params = new ListDictionary();
            Params.Add("@id", BLCtrl.sendString(id1, ""));
            Params.Add("@UserName", BLCtrl.sendString(UserName1, ""));
            Params.Add("@UserPassword", BLCtrl.sendString(UserPassword1, ""));
          
            int result = dm.UpdateUserNameAndPassword(Params);
            return result;

        }
        public int CheckUserName(string UserName1)
        {
            DA_Worker_Details dm = new DA_Worker_Details();
            ListDictionary Params = new ListDictionary();
            Params.Add("@usename", BLCtrl.sendString(UserName1, ""));


            int result = dm.CheckUserName(Params);
            return result;

        }


        public List<Jobs> GetJob()
        {
            DA_Worker_Details dm = new DA_Worker_Details();
            ListDictionary Params = new ListDictionary();
            DataSet ds = dm.GetJob(Params);
            List<Jobs> l = new List<Jobs>();
            Jobs f;

            foreach (DataRow item in ds.Tables[0].Rows)
            {
                f = new Jobs();
                f.Code =BLCtrl.getInt( item,"Code",0);
                f.Job = BLCtrl.getString(item, "Job", "");
               
                l.Add(f);
            }

            return l;



        }


        public List<Authorizations> GetAuthorizations()
        {
            DA_Worker_Details dm = new DA_Worker_Details();
            ListDictionary Params = new ListDictionary();
            DataSet ds = dm.GetAuthorizations(Params);
            List<Authorizations> l = new List<Authorizations>();
            Authorizations f;

            foreach (DataRow item in ds.Tables[0].Rows)
            {
                f = new Authorizations();
                f.Code = BLCtrl.getInt( item,"Code",0);
                f.Authorization = BLCtrl.getString(item, "Authorization", "");
              
                l.Add(f);
            }

            return l;



        }


        public Workers GetWorker(string id1)
        {
            DA_Worker_Details dm = new DA_Worker_Details();
            ListDictionary Params = new ListDictionary();
            Params.Add("@id", BLCtrl.sendString(id1, ""));
            DataSet ds = dm.GetWorker(Params);
            Workers s = new Workers();

            s.Id = BLCtrl.getString(ds.Tables[0].Rows[0], "Id", "");
            s.FirstName= BLCtrl.getString(ds.Tables[0].Rows[0], "FirstName", "");
            s.LastName= BLCtrl.getString(ds.Tables[0].Rows[0], "LastName", "");
            s.Authorization = BLCtrl.getInt(ds.Tables[0].Rows[0], "WokerAuthorization", 0);
            s.BirthDate = BLCtrl.getDateTime(ds.Tables[0].Rows[0],"BirthDate",new DateTime());
            s.City = BLCtrl.getString(ds.Tables[0].Rows[0],"City","");
            s.Code = BLCtrl.getInt(ds.Tables[0].Rows[0],"Code",0);
            s.Email = BLCtrl.getString(ds.Tables[0].Rows[0],"Email","");
            s.Fax = BLCtrl.getString(ds.Tables[0].Rows[0],"Fax","");
            s.Phone = BLCtrl.getString(ds.Tables[0].Rows[0],"Phone","");
            s.Job = BLCtrl.getInt(ds.Tables[0].Rows[0],"Job",0);
            s.Phone2 = BLCtrl.getString(ds.Tables[0].Rows[0],"Phone2","");
            s.Street = BLCtrl.getString(ds.Tables[0].Rows[0],"Street","");




            return s;



        }


    }


}
