using BussinessLayer;
using DataAccessLayer;
using System.Collections.Specialized;
using System.Data;
namespace BussinesLayer
{ 
    public class BL_Acount
    {
        public int Cheak_Username( string username1 , string password1)
        {
            DA_Acount dm = new DA_Acount();

            ListDictionary Params = new ListDictionary();
            Params.Add("@username", BLCtrl.sendString(username1,""));
            Params.Add("@password", BLCtrl.sendString(password1, ""));
            int result = dm.Cheak_Username(Params);
            return result;

        }

        public int Get_Authorization()
        {
            DA_Acount dm = new DA_Acount();
            ListDictionary Params = new ListDictionary();
            DataSet ds = dm.Get_Authorization(Params);

            int returnn = 0;
            foreach (DataRow item in ds.Tables[0].Rows)
            {
                returnn = BLCtrl.getInt(item, "WokerAuthorization", 0);
            }
            return returnn;
        }
    }
}