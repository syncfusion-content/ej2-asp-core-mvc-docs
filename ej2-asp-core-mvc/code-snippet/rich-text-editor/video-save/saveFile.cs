using System.IO;
using System.Web;
using System.Web.Mvc;

namespace FileUpload.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.items = new[] { "Video" };
            return View();
        }

        [AcceptVerbs("Post")]
        public void SaveFiles(HttpPostedFileBase UploadFiles)
        {
            if (UploadFiles != null)
            {
                string path = Server.MapPath("~/Files/");

                // Create a new directory, if it does not exists
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                // Save a file in directory
                UploadFiles.SaveAs(path + Path.GetFileName(UploadFiles.FileName));
            }
        }
    }
}