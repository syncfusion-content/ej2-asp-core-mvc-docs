using CoreSample.Models;
using Microsoft.AspNetCore.Mvc;
using Syncfusion.EJ2.BlockEditor;
using System.Diagnostics;
using System.Net.Http.Headers;
namespace CoreSample.Controllers
{
    public class HomeController : Controller
    {
        private Microsoft.AspNetCore.Hosting.IHostingEnvironment hostingEnv;
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
        public HomeController(Microsoft.AspNetCore.Hosting.IHostingEnvironment env)
        {
            hostingEnv = env;
        }
        public IActionResult Index()
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
            ViewBag.BlockData = BlockData;
            ViewBag.ImageBlockSettings = ImageBlockSettings;
            return View();
        }

        [AcceptVerbs("Post")]
        public void SaveImage(IList<IFormFile> UploadFiles)
        {
            try
            {
                foreach (IFormFile file in UploadFiles)
                {
                    if (UploadFiles != null)
                    {
                        string filename = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
                        filename = hostingEnv.WebRootPath + "\\Uploads" + $@"\{filename}";

                        // Create a new directory, if it does not exists
                        if (!Directory.Exists(hostingEnv.WebRootPath + "\\Uploads"))
                        {
                            Directory.CreateDirectory(hostingEnv.WebRootPath + "\\Uploads");
                        }

                        if (!System.IO.File.Exists(filename))
                        {
                            using (FileStream fs = System.IO.File.Create(filename))
                            {
                                file.CopyTo(fs);
                                fs.Flush();
                            }
                            Response.StatusCode = 200;
                        }
                    }
                }
            }
            catch (Exception)
            {
                Response.StatusCode = 204;
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
