using System.IO;
using System.Web;
using System.Web.Mvc;

namespace ImageUpload.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [AcceptVerbs("Post")]
        public void SaveImage(HttpPostedFileBase UploadFiles)
        {
            if (UploadFiles != null)
            {
                string path = Server.MapPath("~/Uploads/");

                // Create a new directory, if it does not exists
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                // Save a image file in directory
                UploadFiles.SaveAs(path + Path.GetFileName(UploadFiles.FileName));
            }
        }
    }
}