using System;
using System.ComponentModel.DataAnnotations;
// מחלקת עובד
public class Workers
{
    public int Code { get; set; }
    public string Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string UserName { get; set; }
    public string UserPasswerd { get; set; }
    public int Job { get; set; }
    public int Authorization { get; set; }
    public string City { get; set; }
    public string Street { get; set; }
    public string Phone  { get; set; }
    public string Phone2 { get; set; }
    public string Fax { get; set; }
    public string Email { get; set; }
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
    public DateTime BirthDate { get; set; }
}
