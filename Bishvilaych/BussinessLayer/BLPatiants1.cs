using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer
{
    class BLPatiants1
    {
        public int CheckPatiants1(string Id)
        {
            DAPatiants dm = new DAPatiants();
            ListDictionary Params = new ListDictionary();
            Params.Add("@id", Id);
            int result = dm.CheckPatiants1(Params);
            return result;
        }
    }
}
