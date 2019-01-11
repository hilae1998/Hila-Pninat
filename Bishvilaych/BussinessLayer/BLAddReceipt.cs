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
        public int AddPatiantReceipt(DateTime receiptDate, double sum, int payBy,
                string chequaNum,int bank, int paymentNum, string runch, string bankAccount,
                string cardsKind,string CreditCard, string validity,string Name,int ReceiptNum, string Id)
        {
            DAAddReceipt dm = new DAAddReceipt();
            ListDictionary Params = new ListDictionary();
            Params.Add("@ReceiptDate", BLCtrl.sendDateTime(receiptDate, new DateTime()));          
            Params.Add("@Sum", BLCtrl.sendDouble(sum,0));
            if (payBy != 0)
                Params.Add("@PayBy", payBy);
            else
                Params.Add("@PayBy", DBNull.Value);
            Params.Add("@chequaNum", BLCtrl.sendString(chequaNum,""));
            if (bank != 0)
                Params.Add("@Bank", payBy);
            else
                Params.Add("@Bank", DBNull.Value);
            Params.Add("@Brunch", BLCtrl.sendString(runch,""));
            Params.Add("@BankAccount", BLCtrl.sendString(bankAccount,""));
            Params.Add("@CardsKind", BLCtrl.sendString(cardsKind,""));
            Params.Add("@CreditCard", BLCtrl.sendString(CreditCard,""));
            Params.Add("@Name", BLCtrl.sendString(Name, ""));
            Params.Add("@Validity", BLCtrl.sendString(validity,""));
            Params.Add("@paymentNum", BLCtrl.sendInt(paymentNum,0));
            Params.Add("@ReceiptNum", BLCtrl.sendInt(ReceiptNum, 0));
            Params.Add("@Id", BLCtrl.sendString(Id, ""));
            int result = dm.addReceipt(Params, "addPatiantsReceipt");
            return result;
        }
        public int AddCustomerReceipt(DateTime receiptDate, double sum, int payBy,
               string chequaNum, int bank, int paymentNum, string runch, string bankAccount,
               string cardsKind, string CreditCard, string validity,string Name, int ReceiptNum, string Id)
        {
            DAAddReceipt dm = new DAAddReceipt();
            ListDictionary Params = new ListDictionary();
            Params.Add("@ReceiptDate", BLCtrl.sendDateTime(receiptDate, new DateTime()));
            Params.Add("@Sum", BLCtrl.sendDouble(sum, 0));
            if (payBy != 0)
                Params.Add("@PayBy", payBy);
            else
                Params.Add("@PayBy", DBNull.Value);
        
            Params.Add("@chequaNum", BLCtrl.sendString(chequaNum, ""));
            if (bank != 0)
                Params.Add("@Bank", payBy);
            else
                Params.Add("@Bank", DBNull.Value);
            Params.Add("@Brunch", BLCtrl.sendString(runch, ""));
            Params.Add("@BankAccount", BLCtrl.sendString(bankAccount, ""));
            Params.Add("@CardsKind", BLCtrl.sendString(cardsKind, ""));
            Params.Add("@CreditCard", BLCtrl.sendString(CreditCard, ""));
            Params.Add("@Validity", BLCtrl.sendString(validity, ""));
            Params.Add("@Name", BLCtrl.sendString(Name, ""));
            Params.Add("@paymentNum", BLCtrl.sendInt(paymentNum, 0));
            Params.Add("@ReceiptNum", BLCtrl.sendInt(ReceiptNum, 0));
            Params.Add("@Id", BLCtrl.sendString(Id, ""));
            int result = dm.addReceipt(Params, "addCustomerReceipt");
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
        public List<PayBy> getPayBy()
        {
            DAAddReceipt dm = new DAAddReceipt();
            ListDictionary Params = new ListDictionary();
            DataSet ds = dm.getPayBay(Params);
            PayBy b;
            List<PayBy> l = new List<PayBy>();
            foreach (DataRow item in ds.Tables[0].Rows)
            {
                b = new PayBy();
                b.Code = BLCtrl.getInt(item, "Code", 0);
                b.payBy = BLCtrl.getString(item, "PayBy", "");
                l.Add(b);
            }
            return l;
        }
        public int getTopReceiptNum()//שליפת מספר הקבלה האחרון בבסיס הנתונים
        {
            DAAddReceipt dm = new DAAddReceipt();
            ListDictionary Params = new ListDictionary();
            DataSet ds = dm.getReceiptNum(Params);
            int ReceiptNum=0;
            foreach (DataRow item in ds.Tables[0].Rows)
            {
              
                ReceiptNum = BLCtrl.getInt(item, "LastreceiptNum", 0);
              
            }
            return ReceiptNum;
        }
    }
}
