using System;
using System.Collections.Generic;
// מחלקת לקוח
public class Customers
{
    public int Code { get; set; }
    public string Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Phone { get; set; }
    public string Phone2 { get; set; }
    public string City { get; set; }
    public string Street { get; set; }

    public static implicit operator List<object>(Customers v)
    {
        throw new NotImplementedException();
    }
}
