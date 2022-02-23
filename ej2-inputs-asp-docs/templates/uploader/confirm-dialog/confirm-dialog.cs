using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EJ2CoreSampleBrowser.Controllers.TextBoxes
{
    public partial class UploaderController : Controller
    {
        public ActionResult DefaultFunctionalities()
        {
            ViewBag.button = new
            {
                content = "Cancel",
                isPrimary = true
            };

            ViewBag.button1 = new
            {
                content = "Ok",
                isPrimary = true
            };
            
            return View();
        }
    }
}
