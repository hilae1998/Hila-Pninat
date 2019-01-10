﻿using BussinesLayer;
using BussinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;


namespace Bishvilaych.Controllers
{
    public class ReciepitsListOfPatiantsController : Controller
    {
        public ActionResult ReciepitsListOfPatiants()
        public ActionResult ReciepitsListOfPatiants()// כניסה לקבלות של מטופל
        {
            BLReceipt bl = new BLReceipt();
            List<receipt> NewReceiptList = new List<receipt>();//קבלות ממוינות 
            List<receipt> result = bl.getReceipt(Session["Patiant"].ToString(),"p");
            if (result != null && result.Count > 2)//מיון תוצאות
            {

                var GroupResult = result.GroupBy(gro => new { gro.receiptNum }).Select(xx=>new { xx.Key.receiptNum }).ToList();                
                foreach (var rec in GroupResult)
                {
                    double sum = 0;
                    foreach (var itemInResult in result)//סכימת תשלומים לקבלה אחת
                    {
                        if (itemInResult.receiptNum == rec.receiptNum)
                            sum += itemInResult.Sum;
                    }
                    var SingleReceipt = result.FirstOrDefault(xxx => xxx.receiptNum == rec.receiptNum);//לוקחים רשומה אחת והופכים אותה לקבלה מאוחדת
                    SingleReceipt.Sum = sum;//עדכון הסכום הכולל של כל התשלומים לקבלה
                    NewReceiptList.Add(SingleReceipt);
                }
                
            }
            BLPatiants blc = new BLPatiants();
            Patiants p = blc.getPatiantsById(Session["Patiant"].ToString());
            MyPatiantsRecepitModels model = new MyPatiantsRecepitModels();
            model.recepit = NewReceiptList;
            model.MyP = p;
            return View(model);
        }
       
            try
            {
                Session.Timeout += 10;
                BLReceipt bl = new BLReceipt();
                List<receipt> result = bl.getReceipt(Session["Patiants"].ToString());// שליפת הקבלות מהמסד
                BLPatiants blc = new BLPatiants();
                Patiants p = blc.getPatiantsById(Session["Patiants"].ToString());
                MyPatiantsRecepitModels model = new MyPatiantsRecepitModels();
                model.recepit = result;
                model.MyP = p;
                return View(model);
            }
            catch(Exception e)
            {
                return View();
            }
        }
    }
    public class MyPatiantsRecepitModels
    {
        public List<receipt> recepit { get; set; }
        public Patiants MyP { get; set; }
    }
}
