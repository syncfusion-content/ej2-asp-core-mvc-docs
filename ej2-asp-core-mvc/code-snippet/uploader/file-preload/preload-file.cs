using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EJ2CoreSampleBrowser.Controllers.TextBoxes
{
    public partial class UploaderController : Controller
    {
        List<UploaderUploadedFiles> list = new List<UploaderUploadedFiles>();
        public ActionResult DefaultFunctionalities()
        {
            list.Add(new UploaderUploadedFiles { Name = "Books", Size = 500000, Type = ".png" });
            list.Add(new UploaderUploadedFiles { Name = "Movies", Size = 12000, Type = ".pdf" });
            list.Add(new UploaderUploadedFiles { Name = "Study materials", Size = 500000, Type = ".docx" });
            ViewBag.datasource = list;
            return View();
        }
    }
}
