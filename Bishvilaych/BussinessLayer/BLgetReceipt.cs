using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//אפרת בן עזרא
namespace BussinesLayer
{
    class BLgetReceipt
    {
      
        //public receipt getReceipt(DateTime Date, int num, int sum)
        //{
        //    DAgetreceipt r = new DAgetreceipt();
        //    ListDictionary Params = new ListDictionary();
        //    Params.Add("@Date", Date);
        //    Params.Add("@num", num);
        //    Params.Add("@sum", sum);
        //    DataSet re = r.getReceipt(Params);
        //    receipt R = new receipt();
        //    R.Code = re.Tables[0].Rows[0].Field<int>("Code");
        //    R.receiptNum = re.Tables[0].Rows[0].Field<int>("receiptNum");
        //    R.receiptDate = re.Tables[0].Rows[0].Field<DateTime>("receiptDate");
        //    R.Sum = re.Tables[0].Rows[0].Field<float>("Sum");
        //    R.PayBy = re.Tables[0].Rows[0].Field<int>("PayBy");
        //    R.chequaNum = re.Tables[0].Rows[0].Field<string>("chequaNum");
        //    R.Bank = re.Tables[0].Rows[0].Field<int>("Bank");
        //    R.Branch = re.Tables[0].Rows[0].Field<string>("Branch");
        //    R.BankAccount = re.Tables[0].Rows[0].Field<string>("BankAccount");
        //    R.CardsKind = re.Tables[0].Rows[0].Field<string>("CardsKind");
        //    R.CreditCard = re.Tables[0].Rows[0].Field<string>("CreditCard");
        //    R.Validity = re.Tables[0].Rows[0].Field<string>("Validity");
        //    R.name = re.Tables[0].Rows[0].Field<string>("name");
        //    R.PaymentNum = re.Tables[0].Rows[0].Field<int>("PaymentNum");
        //    return R;
        //}

    }
}
