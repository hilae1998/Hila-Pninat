using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
public class Diagnozes
{
    public int Code { get; set; }
    public int Diagnoze { get; set; }
    public int Status { get; set; }
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")] //This template for the date type 
    public DateTime BeginDate { get; set; }
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")] //This template for the date type 
    public DateTime EndDate { get; set; }
    public int By { get; set; }
    public int PatiantCode { get; set; }
}
