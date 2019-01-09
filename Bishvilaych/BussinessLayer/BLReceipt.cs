using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using System.Data;
using BussinessLayer;

namespace BussinesLayer
{
    public class BLReceipt
    {
        public List<receipt> getReceipt(string code)
        {
            DAReceipt da = new DAReceipt();
            ListDictionary Params = new ListDictionary();
            Params.Add("@code", code);
            DataSet ds = da.getReceipt(Params);
            List<receipt> lr = new List<receipt>();
            receipt r;
            foreach (DataRow item in ds.Tables[0].Rows)
            {
                r = new receipt();
                r.PayBy = BLCtrl.getInt(item, "PayBy", 0);
                r.Bank = BLCtrl.getInt(item, "Bank", 0);
                r.BankAccount = BLCtrl.getString(item, "BankAccount", "");
                r.Branch = BLCtrl.getString(item, "Branch", "");
                r.CardsKind = BLCtrl.getString(item, "CardsKind", "");
                r.chequaNum = BLCtrl.getString(item, "chequaNum", "");
                r.Code = BLCtrl.getInt(item, "Code", 0);
                r.CreditCard = BLCtrl.getString(item, "CreditCard", "");
                r.name = BLCtrl.getString(item, "name", "");
                r.PaymentNum = BLCtrl.getInt(item, "PaymentNum", 0);
                r.receiptDate = BLCtrl.getDateTime(item, "receiptDate", DateTime.Today);
                r.receiptNum = BLCtrl.getInt(item, "receiptNum", 0);
                r.Sum = BLCtrl.getDouble(item, "Sum", 0);
                r.Validity = BLCtrl.getString(item, "Validity", "");
                lr.Add(r);
            }
            return lr;
        }
    }
}
