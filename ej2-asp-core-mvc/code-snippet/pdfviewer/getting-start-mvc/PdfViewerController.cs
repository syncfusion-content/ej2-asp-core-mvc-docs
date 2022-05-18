using Newtonsoft.Json;
using Syncfusion.EJ2.PdfViewer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace PDFViewerSample.Controllers
{
    public class HomeController : Controller
    {
        [System.Web.Mvc.HttpPost]
        public ActionResult Load(jsonObjects jsonObject)
        {
            PdfRenderer pdfviewer = new PdfRenderer();
            MemoryStream stream = new MemoryStream();
            var jsonData = JsonConverter(jsonObject);
            object jsonResult = new object();
            if (jsonObject != null && jsonData.ContainsKey("document"))
            {
                if (bool.Parse(jsonData["isFileName"]))
                {
                    string documentPath = GetDocumentPath(jsonData["document"]);

                    if (!string.IsNullOrEmpty(documentPath))
                    {
                        byte[] bytes = System.IO.File.ReadAllBytes(documentPath);
                        stream = new MemoryStream(bytes);

                    }
                    else
                    {
                        string fileName = jsonData["document"].Split(new string[] { "://" }, StringSplitOptions.None)[0];
                        if (fileName == "http" || fileName == "https")
                        {
                            var WebClient = new WebClient();
                            byte[] pdfDoc = WebClient.DownloadData(jsonData["document"]);
                            stream = new MemoryStream(pdfDoc);
                        }
                        else
                        {
                            return this.Content(jsonData["document"] + " is not found");
                        }

                    }
                }
                else
                {
                    byte[] bytes = Convert.FromBase64String(jsonData["document"]);
                    stream = new MemoryStream(bytes);

                }
            }
            jsonResult = pdfviewer.Load(stream, jsonData);
            return Content(JsonConvert.SerializeObject(jsonResult));
        }

        public Dictionary<string, string> JsonConverter(jsonObjects results)
        {
            Dictionary<string, object> resultObjects = new Dictionary<string, object>();
            resultObjects = results.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public)
                .ToDictionary(prop => prop.Name, prop => prop.GetValue(results, null));
            var emptyObjects = (from kv in resultObjects
                                where kv.Value != null
                                select kv).ToDictionary(kv => kv.Key, kv => kv.Value);
            Dictionary<string, string> jsonResult = emptyObjects.ToDictionary(k => k.Key, k => k.Value.ToString());
            return jsonResult;
        }

        [System.Web.Mvc.HttpPost]
        public ActionResult ExportAnnotations(jsonObjects jsonObject)
        {
            PdfRenderer pdfviewer = new PdfRenderer();
            var jsonData = JsonConverter(jsonObject);
            string jsonResult = pdfviewer.ExportAnnotation(jsonData);
            return Content((jsonResult));
        }

        [System.Web.Mvc.HttpPost]
        public ActionResult ImportAnnotations(jsonObjects jsonObject)
        {
            PdfRenderer pdfviewer = new PdfRenderer();
            string jsonResult = string.Empty;
            var jsonData = JsonConverter(jsonObject);
            if (jsonObject != null && jsonData.ContainsKey("fileName"))
            {
                string documentPath = GetDocumentPath(jsonData["fileName"]);
                if (!string.IsNullOrEmpty(documentPath))
                {
                    jsonResult = System.IO.File.ReadAllText(documentPath);
                }
                else
                {
                    return this.Content(jsonData["document"] + " is not found");
                }
            }
            return Content(JsonConvert.SerializeObject(jsonResult));
        }

        [System.Web.Mvc.HttpPost]
        public ActionResult ImportFormFields(jsonObjects jsonObject)
        {

            PdfRenderer pdfviewer = new PdfRenderer();
            var jsonData = JsonConverter(jsonObject);
            object jsonResult = pdfviewer.ImportFormFields(jsonData);
            return Content(JsonConvert.SerializeObject(jsonResult));
        }

        [System.Web.Mvc.HttpPost]
        public ActionResult ExportFormFields(jsonObjects jsonObject)
        {

            PdfRenderer pdfviewer = new PdfRenderer();
            var jsonData = JsonConverter(jsonObject);
            string jsonResult = pdfviewer.ExportFormFields(jsonData);

            return Content(jsonResult);

        }

        [System.Web.Mvc.HttpPost]
        public ActionResult RenderPdfPages(jsonObjects jsonObject)
        {
            PdfRenderer pdfviewer = new PdfRenderer();
            var jsonData = JsonConverter(jsonObject);
            object jsonResult = pdfviewer.GetPage(jsonData);
            return Content(JsonConvert.SerializeObject(jsonResult));
        }

        [System.Web.Mvc.HttpPost]
        public ActionResult Unload(jsonObjects jsonObject)
        {
            PdfRenderer pdfviewer = new PdfRenderer();
            var jsonData = JsonConverter(jsonObject);
            pdfviewer.ClearCache(jsonData);
            return this.Content("Document cache is cleared");
        }

        [System.Web.Mvc.HttpPost]
        public ActionResult RenderThumbnailImages(jsonObjects jsonObject)
        {
            PdfRenderer pdfviewer = new PdfRenderer();
            var jsonData = JsonConverter(jsonObject);
            object result = pdfviewer.GetThumbnailImages(jsonData);
            return Content(JsonConvert.SerializeObject(result));
        }

        [System.Web.Mvc.HttpPost]
        public ActionResult Bookmarks(jsonObjects jsonObject)
        {
            PdfRenderer pdfviewer = new PdfRenderer();
            var jsonData = JsonConverter(jsonObject);
            object jsonResult = pdfviewer.GetBookmarks(jsonData);
            return Content(JsonConvert.SerializeObject(jsonResult));
        }

        [System.Web.Mvc.HttpPost]
        public ActionResult RenderAnnotationComments(jsonObjects jsonObject)
        {
            PdfRenderer pdfviewer = new PdfRenderer();
            var jsonData = JsonConverter(jsonObject);
            object jsonResult = pdfviewer.GetAnnotationComments(jsonData);
            return Content(JsonConvert.SerializeObject(jsonResult));
        }

        [System.Web.Mvc.HttpPost]
        public ActionResult Download(jsonObjects jsonObject)
        {
            PdfRenderer pdfviewer = new PdfRenderer();
            var jsonData = JsonConverter(jsonObject);
            string documentBase = pdfviewer.GetDocumentAsBase64(jsonData);
            return Content(documentBase);
        }

        [System.Web.Mvc.HttpPost]
        public ActionResult PrintImages(jsonObjects jsonObject)
        {
            PdfRenderer pdfviewer = new PdfRenderer();
            var jsonData = JsonConverter(jsonObject);
            object pageImage = pdfviewer.GetPrintImage(jsonData);
            return Content(JsonConvert.SerializeObject(pageImage));
        }

        private HttpResponseMessage GetPlainText(string pageImage)
        {
            var responseText = new HttpResponseMessage(HttpStatusCode.OK);
            responseText.Content = new StringContent(pageImage, System.Text.Encoding.UTF8, "text/plain");
            return responseText;
        }

        private string GetDocumentPath(string document)
        {
            string documentPath = string.Empty;
            if (!System.IO.File.Exists(document))
            {
                var path = HttpContext.Request.PhysicalApplicationPath;
                if (System.IO.File.Exists(path + "App_Data\\" + document))
                    documentPath = path + "App_Data\\" + document;
            }
            else
            {
                documentPath = document;
            }
            return documentPath;
        }
        public ActionResult Index()
        {
            return View();
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
    public class jsonObjects
    {
        public string document { get; set; }
        public string password { get; set; }
        public string zoomFactor { get; set; }
        public string isFileName { get; set; }
        public string xCoordinate { get; set; }
        public string yCoordinate { get; set; }
        public string pageNumber { get; set; }
        public string documentId { get; set; }
        public string hashId { get; set; }
        public string sizeX { get; set; }
        public string sizeY { get; set; }
        public string startPage { get; set; }
        public string endPage { get; set; }
        public string stampAnnotations { get; set; }
        public string textMarkupAnnotations { get; set; }
        public string stickyNotesAnnotation { get; set; }
        public string shapeAnnotations { get; set; }
        public string measureShapeAnnotations { get; set; }
        public string action { get; set; }
        public string pageStartIndex { get; set; }
        public string pageEndIndex { get; set; }
        public string fileName { get; set; }
        public string elementId { get; set; }
        public string pdfAnnotation { get; set; }
        public string importPageList { get; set; }
        public string uniqueId { get; set; }
        public string data { get; set; }
        public string viewPortWidth { get; set; }
        public string viewportHeight { get; set; }
        public string tilecount { get; set; }
        public string isCompletePageSizeNotReceived { get; set; }
        public string freeTextAnnotation { get; set; }
        public string signatureData { get; set; }
        public string fieldsData { get; set; }
        public string FormDesigner { get; set; }
        public string inkSignatureData { get; set; }
    }
}