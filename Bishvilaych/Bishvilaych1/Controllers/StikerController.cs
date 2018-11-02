using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bishvilaych1.Controllers
{
    public class StikerController : Controller
    {
        [HttpPost]
        public ActionResult Finnish()
        {
            if (Session["Workers"] == null)
                RedirectToAction("Login");
            return View();
        }

        //GET: Stiker
        //public ActionResult Index()
        //{
        //    return View();
        //}

        //public class Program
        //{

        //    private enum PrinterStatus
        //    {
        //        PaperPresent,
        //        NearPaperEnd, //4
        //        paperAbsent, //5
        //        Error, // typically printer fault or not founds
        //        Default // have not do any check since kiosk is up
        //    }

        //    private static string resultSaveLocation = "";
        //    private static string applicationRunningMode = "";
        //    private static readonly ILog ApplicationExceptionLogger = LogManager.GetLogger("APP.ExceptionLogger");

        //    public static void Main(string[] args)
        //    {
        //        try
        //        {
        //            Bootstrap();

        //            string value = "";

        //            PrinterStatus currentStatus = GetPrinterPaperStatus();

        //            switch (currentStatus)
        //            {
        //                case PrinterStatus.Default:
        //                    value = "DFT";
        //                    break;
        //                case PrinterStatus.NearPaperEnd:
        //                    value = "NPE";
        //                    break;
        //                case PrinterStatus.paperAbsent:
        //                    value = "PRA";
        //                    break;
        //                case PrinterStatus.PaperPresent:
        //                    value = "PRP";
        //                    break;
        //                case PrinterStatus.Error:
        //                    value = "ERR";
        //                    break;
        //            }

        //            Console.WriteLine("Printer Status: " + currentStatus.ToString() + " Code:" + value);
        //            WriteResultToTextfile(value);
        //        }
        //        catch (Exception ex)
        //        {
        //            // display the result in console window
        //            Console.WriteLine(ex.Message);

        //            // write the exceptoin / error to log file
        //            ApplicationExceptionLogger.Error(ex);
        //        }
        //        finally
        //        {
        //            // display the result in console window
        //            Console.WriteLine("Operation completed");

        //            // if application is running in text mode, console window will 
        //            // not closed by itself
        //            if (applicationRunningMode == "TEST")
        //            {
        //                Console.ReadLine();
        //            }
        //        }

        //    }

        //    /// <summary>
        //    /// clean the file content and write -1 to indicate the failure of validating user
        //    /// </summary>
        //    private static void WriteResultToTextfile(string textToWrite)
        //    {
        //        string filePath = System.AppDomain.CurrentDomain.BaseDirectory + resultSaveLocation;

        //        File.WriteAllText(filePath, textToWrite);
        //    }

        //    /// <summary>
        //    /// setting up the application
        //    /// </summary>
        //    private static void Bootstrap()
        //    {
        //        XmlConfigurator.Configure();

        //        resultSaveLocation = ConfigurationManager.AppSettings["ResultOutputLocation"].ToString();
        //        applicationRunningMode = ConfigurationManager.AppSettings["ApplicationRunningMode"].ToString();
        //    }

        //    /// <summary>
        //    /// function to query custom printer status 
        //    /// </summary>
        //    /// <returns></returns>
        //    private static PrinterStatus GetPrinterPaperStatus()
        //    {
        //        PrinterStatus currentPrinterStatus = PrinterStatus.Default;

        //        CustomFunction.Custom printer = new Custom();
        //        string printerStatus = printer.PaperStatus();

        //        if (printerStatus.Contains("0"))
        //        {
        //            currentPrinterStatus = PrinterStatus.PaperPresent;
        //        }
        //        else if (printerStatus.Contains("4"))
        //        {
        //            currentPrinterStatus = PrinterStatus.NearPaperEnd;
        //        }
        //        else if (printerStatus.Contains("5"))
        //        {
        //            currentPrinterStatus = PrinterStatus.paperAbsent;
        //        }
        //        else if (printerStatus.Contains("Error"))
        //        {
        //            currentPrinterStatus = PrinterStatus.Error;
        //        }

        //        return currentPrinterStatus;
        //    }
        //}
    }
}