using System;
using System.Collections.Generic;
using System.IO;
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
        public ActionResult DocumentScanner2(string newname)
        {
            HttpPostedFileBase file = Request.Files["FileUpload"];
            string newfilename = Request.Form["NewNameFile"];
            string message = "";
            if (newfilename == "" || newfilename == null)// החזר הודעה ללקוח אם שם המסמך התקבל ריק או חסר ערך
            {
                message = "נא לתת שם לקובץ";
                return Json(message, JsonRequestBehavior.AllowGet);
            }
            //בדיקה האם קיימת תקייה אישית ללקוח במידה ולא, יצירת תקייה מתאימה
            var IsFolderPath = System.IO.File.Exists(Server.MapPath("~/ScannedPatientsDocuments/" + Session["Patiant"].ToString()));
            if (!IsFolderPath)
                Directory.CreateDirectory(Server.MapPath("~/ScannedPatientsDocuments/" + Session["Patiant"].ToString()));
            var absolutePath = Server.MapPath("~/ScannedPatientsDocuments/" + Session["Patiant"].ToString() + "/" + newfilename + "." + file.FileName.Split('.')[1]);
            bool IsExist = System.IO.File.Exists(absolutePath);//
            if (file.ContentLength > 0)
            {
                if (IsExist) //אם קיים מסמך בעל שם זהה
                {
                    message = "קיים מסמך בעל שם זהה,נסה שם אחר";
                    return Json(message, JsonRequestBehavior.AllowGet);
                }
                else
                {//העתק לתיקיית הלקוח את המסמך עם שם החדש
                    var fileName = Path.GetFileName(file.FileName);
                    file.SaveAs(absolutePath);
                    message = "המסמך נסרק בהצלחה";
                }
            }
           
            return Json(message, JsonRequestBehavior.AllowGet);
        }
        public void ShowFileInNewTab(string path,string type)
        {

            System.Diagnostics.Process.Start(path);
           
           
        }

    }
}
    public class Exstension
    {
        public Dictionary<string, string> DictExst = new Dictionary<string, string>();
        public Exstension()
        {
            DictExst["png"] = "~/Images/FormatIcons/png.png";
            DictExst["jpeg"] ="~/Images/FormatIcons/jpg.png";
            DictExst["jpg"] ="~/Images/FormatIcons/jpg.png";
            DictExst["docx"] ="~/Images/FormatIcons/png.png";
            DictExst["xls"] ="~/Images/FormatIcons/xls.png";
            DictExst["xlsx"] ="~/Images/FormatIcons/xls.png";
            DictExst["txt"] = "~/Images/FormatIcons/txt.png";
        }

    }

