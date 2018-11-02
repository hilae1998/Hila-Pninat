using DataAccessLayer;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;

namespace BussinessLayer
{
   public class BLAddReceipt
    {
        public int AddOrUpdateReceipt(DateTime receiptDate, int receiptNum, double sum, int payBy,
                string chequaNum,int bank, int paymentNum, string runch, string bankAccount,
                string cardsKind,string CreditCard, string validity, string name,string Id)
        {
            DAAddReceipt dm = new DAAddReceipt();
            ListDictionary Params = new ListDictionary();
            Params.Add("@ReceiptDate", BLCtrl.sendDateTime(receiptDate, new DateTime()));
            Params.Add("@ReceiptNum", BLCtrl.sendInt(receiptNum,0));
            Params.Add("@Sum", BLCtrl.sendDouble(sum,0));
            Params.Add("@PayBy", BLCtrl.sendInt(payBy,0));
            Params.Add("@chequaNum", BLCtrl.sendString(chequaNum,""));
            Params.Add("@Bank", BLCtrl.sendInt(bank,0));
            Params.Add("@Brunch", BLCtrl.sendString(runch,""));
            Params.Add("@BankAccount", BLCtrl.sendString(bankAccount,""));
            Params.Add("@CardsKind", BLCtrl.sendString(cardsKind,""));
            Params.Add("@CreditCard", BLCtrl.sendString(CreditCard,""));
            Params.Add("@Validity", BLCtrl.sendString(validity,""));
            Params.Add("@Name", BLCtrl.sendString(name,""));
            Params.Add("@paymentNum", BLCtrl.sendInt(paymentNum,0));
            Params.Add("@Id", BLCtrl.sendString(Id, ""));
            int result = dm.addReceipt(Params);
            return result;
        }

        public List<Banks> getAllBanks()
        {
            DAAddReceipt dm = new DAAddReceipt();
            ListDictionary Params = new ListDictionary();
            DataSet ds = dm.getAllBanks(Params);
            Banks b ;
            List<Banks> l = new List<Banks>();
            foreach (DataRow item in ds.Tables[0].Rows)
            {
                b = new Banks();
                b.BankNum= BLCtrl.getInt(item, "BankNum", 0);
                b.BankName= BLCtrl.getString(item, "BankName", "");
                l.Add(b);
            }
            return l;
        }
    }
}
