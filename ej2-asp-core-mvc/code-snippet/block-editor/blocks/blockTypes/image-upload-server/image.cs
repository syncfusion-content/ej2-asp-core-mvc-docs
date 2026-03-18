using Syncfusion.EJ2.BlockEditor;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;


namespace MVC_Sample.Controllers
{
    public class HomeController : Controller
    {
        public class BlockModel
        {
            public string id { get; set; }
            public string blockType { get; set; }
            public object properties { get; set; }
            public List<object> content { get; set; }
            public List<BlockModel> children { get; set; }
            public int indent { get; set; }
        }
        public ImageBlockSettings ImageBlockSettings { get; set; }
        public List<BlockModel> BlockData { get; set; }
        public ActionResult Index()
        {
            BlockData = new List<BlockModel>()
            {
                new BlockModel
                {
                    blockType = "Image",
                    properties = new { src = "https://cdn.syncfusion.com/ej2/richtexteditor-resources/RTE-Overview.png", altText = "Sample image" }
                },
                new BlockModel
                {
                    blockType = "Paragraph",
                    content = new List<object>
                    {
                        new { contentType = "Text", content = "You can customize images further by configuring properties like allowedTypes for file upload restrictions, saveFormat for storage preferences, and cssClass for custom styling." }
                    }
                }
            };
            ImageBlockSettings = new ImageBlockSettings()
            {
                SaveUrl = "[SERVICE_HOSTED_PATH]/api/Home/SaveImage",
                Path = "[SERVICE_HOSTED_PATH]/Uploads/"
            };
            ViewData["BlockData"] = BlockData;
            ViewData["ImageBlockSettings"] = ImageBlockSettings;
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

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
