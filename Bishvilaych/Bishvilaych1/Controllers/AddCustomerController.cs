using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BussinessLayer;


namespace Bishvilaych1.Controllers
{
    public class AddCustomerController : Controller
    {
        // GET: AddCustomer
        public ActionResult AddCustomer()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddCustomer(Customers c)
        {
            BLAddCustomer bl = new BLAddCustomer();
            int result = bl.Add_Customers(c.Id,c.FirstName,c.LastName,c.Phone,c.Phone2,c.City,c.Street);
            return View(c);//המסך נסגר עם הודעה או מציג את הויו עם הנתונים
        }

        [System.Web.Services.WebMethod]
        public  bool LegalId(string s)
        {
            int x;
            if (!int.TryParse(s, out x))
                return false;
            if (s.Length < 5 || s.Length > 9)
                return false;
            for (int i = s.Length; i < 9; i++)
                s = "0" + s;
            int sum = 0;
            for (int i = 0; i < 9; i++)
            {
                int k = ((i % 2) + 1) * (Convert.ToInt32(s[i]) - '0');
                if (k > 9)
                    k -= 9;
                sum += k;

            }
            return sum % 10 == 0;
        }
    }
}