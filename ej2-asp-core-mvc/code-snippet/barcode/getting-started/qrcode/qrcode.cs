using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Syncfusion.EJ2.BarcodeGenerator;

namespace EJ2CoreSampleBrowser.Controllers.Barcode
{
    public partial class BarcodeController : Controller
    {
        // GET: Annotations
        public ActionResult qrcode()
        {
           return View();
        }
    }

    public class ExpandOptionsqrcode
    {
        public string text;
        public string value;
    }
    
}