using System;
// מחלקת קבלה
public class receipt
{
    public int Code { get; set; }
    public int receiptNum { get; set; }
    public string For { get; set; }
    public DateTime receiptDate { get; set; }
    public double Sum { get; set; }
    public int PayBy { get; set; }
    public string chequaNum { get; set; }
    public int Bank { get; set; }
    public string Branch { get; set; }
    public string BankAccount { get; set; }
    public string CardsKind { get; set; }
    public string CreditCard { get; set; }
    public string Validity { get; set; }
    public string name { get; set; }
    public int PaymentNum { get; set; }
}
