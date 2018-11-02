using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

// פנינת פרנסה
namespace Bishvilaych.Controllers
{
    public class DocumentScannerController : Controller
    {
        public ActionResult DocumentScanner()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DocumentScanner(string model)
        {
            return View();
        }
    }
}
