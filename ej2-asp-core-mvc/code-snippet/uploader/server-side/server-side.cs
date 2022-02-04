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
            return View();
        }
        public void Save() {
    if (!System.IO.File.Exists(fileSavePath))
    {
        httpPostedFile.SaveAs(fileSavePath);
        HttpResponse Response = System.Web.HttpContext.Current.Response;
        Response.Clear();
        Response.ContentType = "application/json; charset=utf-8";
        <!-- Sending the file path to client side -->
        Response.StatusDescription = fileSavePath;
        Response.End();
    }
}

[AcceptVerbs("Post")]
public void openFile()
{
    // Check whether the file is available in the corresponding location
    if (System.IO.File.Exists(Request.Headers.GetValues("filePath").First()))
    {
        // This will open the selected file from server location in desktop
        Process.Start(Request.Headers.GetValues("filePath").First());
    }
}
    }
}
