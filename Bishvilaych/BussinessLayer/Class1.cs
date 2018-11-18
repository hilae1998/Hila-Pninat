using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;

namespace BussinessLayer
{
    class Class1
    {
        public List<int> getUsers(DateTime dt)
        {
            DBMapper dm = new DBMapper();

            ListDictionary Params = new ListDictionary();
            Params.Add("@dt", dt);

            DataSet ds = dm.BLAddOrUpdateScreeningsKings();

            return new List<int>();
        }
        
    }
}
