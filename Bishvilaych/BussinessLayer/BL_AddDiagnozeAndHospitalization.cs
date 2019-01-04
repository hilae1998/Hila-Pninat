using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Avishag
namespace BussinessLayer
{
  public  class BL_AddDiagnozeAndHospitalization
    {
        private readonly object dt;

        public List<DiagnozesKinds> Draw_Diagnoze()
        {
            DAL_AddDiagnozeAndHospitalization dm = new DAL_AddDiagnozeAndHospitalization();
            ListDictionary Params = new ListDictionary();
            DataSet ds = dm.Draw_Diagnoze(Params);
            List<DiagnozesKinds> ld = new List<DiagnozesKinds>();
            DiagnozesKinds d;
            foreach(DataRow item in ds.Tables[0].Rows)
            {
                d = new DiagnozesKinds();
                d.Diagnoze = item.Field<string>("Diagnoze");
                ld.Add(d);
            }
            return ld; 
        }

        //public int Add_Hospitalization(int year, int hospital, string department, string reason)
        //{
        //    throw new NotImplementedException();
        //}

        //public int Update_Hospitalization(int year, int hospital, string department, string reason)
        //{
        //    throw new NotImplementedException();
        //}

        //public int Update_Diagnoze(int diagnoze, int status, DateTime beginDate, DateTime endDate)
        //{
        //    throw new NotImplementedException();
        //}

        //public int Add_Diagnoze(int diagnoze, int status, DateTime beginDate, DateTime endDate)
        //{
        //    throw new NotImplementedException();
        //}

        public List<Statuses> Draw_Status()
    {
        DAL_AddDiagnozeAndHospitalization dm = new DAL_AddDiagnozeAndHospitalization();
        ListDictionary Params = new ListDictionary();
        DataSet ds = dm.Draw_Status(Params);
        List<Statuses> ls = new List<Statuses>();
        Statuses s;
        foreach (DataRow item in ds.Tables[0].Rows)
        {
            s = new Statuses();
            s.Status = item.Field<string>("Status");
            ls.Add(s);
        }
        return ls;
    }

    public int Add_Diagnoze(int Diagnoze, int Status,DateTime BeginDate ,DateTime EndDate)
        {
            DAL_AddDiagnozeAndHospitalization dm = new DAL_AddDiagnozeAndHospitalization();

            ListDictionary Params = new ListDictionary();

            Params.Add("@Diagnoze", BLCtrl.sendString(Diagnoze, ""));
            Params.Add("@Status", BLCtrl.sendString(Status, ""));
            Params.Add("@BeginDate",BLCtrl.sendDateTime(BeginDate, DateTime.Today));
            Params.Add("@EndDate",BLCtrl.sendDateTime(EndDate, DateTime.Today));          
            int result = dm.Add_Diagnoze (Params);

            return result;
        }

        public int Update_Diagnoze(int Diagnoze, int Status, DateTime BeginDate, DateTime EndDate)
        {
            DAL_AddDiagnozeAndHospitalization dm = new DAL_AddDiagnozeAndHospitalization();

            ListDictionary Params = new ListDictionary();
            Params.Add("@Diagnoze", BLCtrl.sendString(Diagnoze, ""));
            Params.Add("@Status", BLCtrl.sendString(Status, ""));
            Params.Add("@BeginDate", BLCtrl.sendDateTime(BeginDate, DateTime.Today));
            Params.Add("@EndDate", BLCtrl.sendDateTime(EndDate, DateTime.Today));


            int result = dm.Update_Diagnoze(Params);

            return result;
        }

        public List<Hospitals> Draw_Hospital()
      {
          DAL_AddDiagnozeAndHospitalization dm = new DAL_AddDiagnozeAndHospitalization();
          ListDictionary Params = new ListDictionary();
          DataSet ds = dm.Draw_Hospital(Params);
          List<Hospitals> lh = new List<Hospitals>();
          Hospitals h;
          foreach (DataRow item in ds.Tables[0].Rows)
          {
              h = new Hospitals();
              h.hospital = item.Field<string>("Hospital");
              lh.Add(h);
          }
          return lh;
      }

        public int Add_Hospitalization(int Year,string Hospital, string Department,string Reason)
        {
            DAL_AddDiagnozeAndHospitalization dm = new DAL_AddDiagnozeAndHospitalization();

            ListDictionary Params = new ListDictionary();
            Params.Add("@Year",BLCtrl.sendInt("year",0));
            Params.Add("@Hospital", BLCtrl.sendString(Hospital, ""));
            Params.Add("@Department",BLCtrl.sendString("Department",""));
            Params.Add("@Reason",BLCtrl.sendString("Reason",""));

            int result = dm.Add_Hospitalization(Params);

            return result;
        }

        public int Update_Hospitalization(int Year, string Hospital, string Department, string Reason)
        {
            DAL_AddDiagnozeAndHospitalization dm = new DAL_AddDiagnozeAndHospitalization();

            ListDictionary Params = new ListDictionary();
            Params.Add("@Year", BLCtrl.sendInt("year", 0));
            Params.Add("@Hospital", BLCtrl.sendString(Hospital, ""));
            Params.Add("@Department", BLCtrl.sendString(Department, ""));
            Params.Add("@Reason", BLCtrl.sendString(Reason, ""));

            int result = dm.Update_Hospitalization(Params);

            return result;
        }
    }
}
