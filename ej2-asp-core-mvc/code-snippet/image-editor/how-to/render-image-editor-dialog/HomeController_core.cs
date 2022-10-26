using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Syncfusion.EJ2.Popups;

namespace EJ2CoreSampleBrowser.Controllers
{
    public partial class ImageEditorController : Controller
    {

        public IActionResult ProfilePicture()
        {
            ViewBag.popupPosition = new DialogPositionData() { X = "center", Y = "100" };
            return View();
        }
    }
}