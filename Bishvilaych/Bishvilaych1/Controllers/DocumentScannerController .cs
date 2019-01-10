using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace Bishvilaych.Controllers
{
    public class DocumentScannerController : Controller
    {
        public ActionResult DocumentScanner()
        {
            //בדיקה האם קיימת תקייה אישית ללקוח במידה ולא, יצירת תקייה מתאימה
            var IsFolderPath = System.IO.File.Exists(Server.MapPath("~/ScannedPatientsDocuments/" + Session["Patiant"].ToString()));
            if (!IsFolderPath)
                Directory.CreateDirectory(Server.MapPath("~/ScannedPatientsDocuments/" + Session["Patiant"].ToString()));
            return View();
        }
        [HttpPost]// סריקת מסמכי מטופל
        public ActionResult DocumentScanner2(string newname)
        {
            try
            {
                Session.Timeout += 5;//session הגדלת ה
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
                bool IsExist = System.IO.File.Exists(absolutePath);
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
            catch (Exception e)
            {
                return Json(e, JsonRequestBehavior.AllowGet);
            }
    
        }
       

    }
}
    

