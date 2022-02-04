using System;
using System.IO;
using System.Web;
using System.Web.Mvc;

namespace RenameImage.Controllers
{
    public class HomeController : Controller
    {
        int x = 0;
        string imageFile;

        public ActionResult Index()
        {
            return View();
        }

        [AcceptVerbs("Post")]
        public void Rename(HttpPostedFileBase UploadFiles)
        {
            try
            {
                if (UploadFiles != null)
                {
                    imageFile = UploadFiles.FileName;

                    if (UploadFiles != null)
                    {
                        var fileSave = System.Web.HttpContext.Current.Server.MapPath("~/Uploads");

                        // Create a new directory, if it does not exists
                        if (!System.IO.Directory.Exists(fileSave))
                        {
                            System.IO.Directory.CreateDirectory(fileSave);
                        }

                        var fileName = Path.GetFileName(UploadFiles.FileName);
                        var fileSavePath = Path.Combine(fileSave, fileName);

                        // Rename a uploaded image file name
                        while (System.IO.File.Exists(fileSavePath))
                        {
                            imageFile = "rteImage" + x + "-" + fileName;
                            fileSavePath = Path.Combine(fileSave, imageFile);
                            x++;
                        }

                        if (!System.IO.File.Exists(fileSavePath))
                        {
                            UploadFiles.SaveAs(fileSavePath);

                            // Modified file name shared through response header by adding custom header
                            Response.Headers.Add("name", imageFile);
                            Response.StatusCode = 200;
                            Response.ContentType = "application/json; charset=utf-8";
                        }
                    }
                }
            }
            catch (Exception)
            {
                Response.StatusCode = 204;
            }
        }
    }
}