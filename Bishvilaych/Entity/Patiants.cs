using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
/// <summary>
/// Summary description for Class1
/// </summary>
public class Patiants
{
    public int Code { get; set; }
    public string Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Doctor { get; set; }
    public string reffered { get; set; }
    public string Language { get; set; }
    public string City { get; set; }
    public string Street { get; set; }
    public string Phone { get; set; }
    public string Phone2 { get; set; }
    public string Fax { get; set; }
    public string Email { get; set; }
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")] //This template for the date type in Patiant page
   // [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
    public DateTime BirthDate { get; set; }
    public string ContactExam { get; set; }
    public string ContactGinformation { get; set; }
    public string FathersOrigin { get; set; }
    public string MothersOrigin { get; set; }
    public int Kupah { get; set; }
    public int MaritalStatus { get; set; }
    public int Children { get; set; }
    public int G { get; set; }
    public int T { get; set; }
    public int P { get; set; }
    public int A { get; set; }
    public int L { get; set; }
    public bool FollowUp { get; set; }
    public string Occupation { get; set; }
    public bool followedup { get; set; }
}
