---
layout: post
title: Server Actions in ##Platform_Name## Pdfviewer Component
description: Learn here all about Server Actions in Syncfusion ##Platform_Name## Pdfviewer component and more.
platform: ej2-asp-core-mvc
control: Server Actions
publishingplatform: ##Platform_Name##
documentation: ug
---


# Server Actions

Syncfusion PDF Viewer control is client-server oriented. It processes the PDF document on the server-side and sends the processed PDF data to the client to render the PDF document and for further operations in the PDF Viewer.

The server actions or server methods in the MVC PDF Viewer controller are:

* Load
* RenderPdfPages
* RenderThumbnailImages
* Bookmarks
* RenderAnnotationComments
* Unload
* ExportAnnotations
* ImportAnnotations
* ImportFormFields
* ExportFormFields
* Download
* PrintImages

## Load action

> public ActionResult Load(jsonObjects jsonObject)

The [Load]( https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PdfViewer.PdfViewerServerActionSettingsBuilder.html#Syncfusion_EJ2_PdfViewer_PdfViewerServerActionSettingsBuilder_Load_System_String_) action will be triggered initially on loading a PDF file. Syncfusion PDF Viewer control will store the document in the cache based on the hashid during the initial loading of the pdf file. Initially, the request will be sent for 100 pages only and another request will be sent for the remaining pages. So the Load action will get triggered twice when loading a PDF file with pages more than 100, which is called virtual loading.

This action on its first trigger calls the GetDocumentPath method in the PdfViewerController.cs with which the path of the document is determined. The PDF file to be loaded must be located in the folder structure as specified in the GetDocumentPath method.

The Load action calls the [Load]( https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PdfViewer.PdfRenderer.html#Syncfusion_EJ2_PdfViewer_PdfRenderer_Load_System_IO_Stream_System_Collections_Generic_Dictionary_System_String_System_String__) method to load the PDF file in the PDF Viewer.

```cs
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
```

## RenderPdfPages

> public ActionResult RenderPdfPages(jsonObjects jsonObject)

Whenever a new page is loaded, [RenderPdfPages]( https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PdfViewer.PdfViewerServerActionSettingsBuilder.html#Syncfusion_EJ2_PdfViewer_PdfViewerServerActionSettingsBuilder_RenderPages_System_String_) action will be called. When a PDF file is loaded with PDF Viewer, only two pages will be loaded initially by hitting this action for loading each page. Further pages will be loaded on demand by hitting this action.

The RenderPdfPages action calls the [GetPage](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PdfViewer.PdfRenderer.html#Syncfusion_EJ2_PdfViewer_PdfRenderer_GetPage_System_Collections_Generic_Dictionary_System_String_System_String__) method to render each PDF pages.

```cs
[System.Web.Mvc.HttpPost]
public ActionResult RenderPdfPages(jsonObjects jsonObject)
{
    PdfRenderer pdfviewer = new PdfRenderer();
    var jsonData = JsonConverter(jsonObject);
    object jsonResult = pdfviewer.GetPage(jsonData);
    return Content(JsonConvert.SerializeObject(jsonResult));
}
```

## RenderThumbnailImages action

> public ActionResult RenderThumbnailImages(jsonObjects jsonObject)

The [RenderThumbnailImages]( https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PdfViewer.PdfViewerServerActionSettingsBuilder.html#Syncfusion_EJ2_PdfViewer_PdfViewerServerActionSettingsBuilder_RenderThumbnail_System_String_) action will be triggered initially on loading a PDF file. It renders the thumbnails images of all the pages in the PDF file. When a thumbnail image is clicked, the RenderPdfPages action will be triggered to load the selected page.

This action calls the [GetThumbnailImages]( https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PdfViewer.PdfRenderer.html#Syncfusion_EJ2_PdfViewer_PdfRenderer_GetThumbnailImages_System_Collections_Generic_Dictionary_System_String_System_String__) method.

```cs
[System.Web.Mvc.HttpPost]
public ActionResult RenderThumbnailImages(jsonObjects jsonObject)
{
    PdfRenderer pdfviewer = new PdfRenderer();
    var jsonData = JsonConverter(jsonObject);
    object result = pdfviewer.GetThumbnailImages(jsonData);
    return Content(JsonConvert.SerializeObject(result));
}
```

## Bookmarks

> public ActionResult Bookmarks(jsonObjects jsonObject)

The Bookmarks action will be triggered initially on loading a PDF file. All the headings in the PDF file will get added to the Bookmarks collection in the bookmarks panel with the help of this action. When a bookmark is selected, the page containing the selected heading will be rendered or opened.

This action calls the [GetBookmarks]( https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PdfViewer.PdfRenderer.html#Syncfusion_EJ2_PdfViewer_PdfRenderer_GetBookmarks_System_Collections_Generic_Dictionary_System_String_System_String__) method.

```cs
[System.Web.Mvc.HttpPost]
public ActionResult Bookmarks(jsonObjects jsonObject)
{
    PdfRenderer pdfviewer = new PdfRenderer();
    var jsonData = JsonConverter(jsonObject);
    object jsonResult = pdfviewer.GetBookmarks(jsonData);
    return Content(JsonConvert.SerializeObject(jsonResult));
}
```

## RenderAnnotationComments

> public ActionResult RenderAnnotationComments(jsonObjects jsonObject)

The [RenderAnnotationComments]( https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PdfViewer.PdfViewerServerActionSettingsBuilder.html#Syncfusion_EJ2_PdfViewer_PdfViewerServerActionSettingsBuilder_RenderComments_System_String_) action will be triggered initially on loading a PDF file.

It calls the [GetAnnotationComments]( https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PdfViewer.PdfRenderer.html#Syncfusion_EJ2_PdfViewer_PdfRenderer_GetAnnotationComments_System_Collections_Generic_Dictionary_System_String_System_String__) method to retrieve the annotation comments in the PDF file.

```cs
[System.Web.Mvc.HttpPost]
public ActionResult RenderAnnotationComments(jsonObjects jsonObject)
{
    PdfRenderer pdfviewer = new PdfRenderer();
    var jsonData = JsonConverter(jsonObject);
    object jsonResult = pdfviewer.GetAnnotationComments(jsonData);
    return Content(JsonConvert.SerializeObject(jsonResult));
}
```

## Unload action

> public ActionResult Unload(jsonObjects jsonObject)

The [Unload]( https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PdfViewer.PdfViewerServerActionSettingsBuilder.html#Syncfusion_EJ2_PdfViewer_PdfViewerServerActionSettingsBuilder_Unload_System_String_) action will be triggered on unloading a PDF file by closing or refreshing the browser.

This action calls the [ClearCache]( https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PdfViewer.PdfRenderer.html#Syncfusion_EJ2_PdfViewer_PdfRenderer_ClearCache_System_Collections_Generic_Dictionary_System_String_System_String__) method to clear the cache objects while closing the PDF Viewer.

```cs
[System.Web.Mvc.HttpPost]
public ActionResult Unload(jsonObjects jsonObject)
{
    PdfRenderer pdfviewer = new PdfRenderer();
    var jsonData = JsonConverter(jsonObject);
    pdfviewer.ClearCache(jsonData);
    return this.Content("Document cache is cleared");
}
```

## ExportAnnotations action

> public ActionResult ExportAnnotations(jsonObjects jsonObject)

The [ExportAnnotations]( https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PdfViewer.PdfViewerServerActionSettingsBuilder.html#Syncfusion_EJ2_PdfViewer_PdfViewerServerActionSettingsBuilder_ExportAnnotations_System_String_) action will be triggered by clicking either the “Export annotation to JSON file” option or the “Export annotation to XFDF file” option in the annotation toolbar.

This action calls the [ExportAnnotation]( https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PdfViewer.PdfRenderer.html#Syncfusion_EJ2_PdfViewer_PdfRenderer_ExportAnnotation_System_Collections_Generic_Dictionary_System_String_System_String__) method to export the annotations in the PDF Viewer to a JSON file or an XFDF file.

```cs
[System.Web.Mvc.HttpPost]
public ActionResult ExportAnnotations(jsonObjects jsonObject)
{
    PdfRenderer pdfviewer = new PdfRenderer();
    var jsonData = JsonConverter(jsonObject);
    string jsonResult = pdfviewer.ExportAnnotation(jsonData);
    return Content((jsonResult));
}
```

## ImportAnnotations

> public ActionResult ImportAnnotations(jsonObjects jsonObject)

The [ImportAnnotations]( https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PdfViewer.PdfViewerServerActionSettingsBuilder.html#Syncfusion_EJ2_PdfViewer_PdfViewerServerActionSettingsBuilder_ImportAnnotations_System_String_) action will be triggered by clicking the “Import annotation from XFDF file” option in the annotation toolbar.

This action calls the [ImportAnnotation]( https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PdfViewer.PdfRenderer.html#Syncfusion_EJ2_PdfViewer_PdfRenderer_ImportAnnotation_System_Collections_Generic_Dictionary_System_String_System_String__) method to import the annotations from an XFDF file.

```cs
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
```

## ImportFormFields action

> public ActionResult ImportFormFields(jsonObjects jsonObject)

The [ImportFormFields]( https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PdfViewer.PdfViewerServerActionSettingsBuilder.html#Syncfusion_EJ2_PdfViewer_PdfViewerServerActionSettingsBuilder_ImportFormFields_System_String_) action will be triggered by calling it from the UI code.

This action calls the [ImportFormFields]( https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PdfViewer.PdfRenderer.html#Syncfusion_EJ2_PdfViewer_PdfRenderer_ImportFormFields_System_Collections_Generic_Dictionary_System_String_System_String__) method to import the form fields into the PDF Viewer from a JSON object or file.

```cs
[System.Web.Mvc.HttpPost]
public ActionResult ImportFormFields(jsonObjects jsonObject)
{
    PdfRenderer pdfviewer = new PdfRenderer();
    var jsonData = JsonConverter(jsonObject);
    object jsonResult = pdfviewer.ImportFormFields(jsonData);
    return Content(JsonConvert.SerializeObject(jsonResult));
}
```

## ExportFormFields action

> public ActionResult ExportFormFields(jsonObjects jsonObject)

The [ExportFormFields]( https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PdfViewer.PdfViewerServerActionSettingsBuilder.html#Syncfusion_EJ2_PdfViewer_PdfViewerServerActionSettingsBuilder_ExportFormFields_System_String_) action will be triggered by clicking the Submit Form option in the PDF Viewer toolbar. The Submit Form option is enabled only when there are form fields. It exports the form fields into a JSON file.

This action calls the [ExportFormFields]( https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PdfViewer.PdfRenderer.html#Syncfusion_EJ2_PdfViewer_PdfRenderer_ExportFormFields_System_Collections_Generic_Dictionary_System_String_System_String__) method to export the form fields into a JSON string.

```cs
[System.Web.Mvc.HttpPost]
public ActionResult ExportFormFields(jsonObjects jsonObject)
{
    PdfRenderer pdfviewer = new PdfRenderer();
    var jsonData = JsonConverter(jsonObject);
    string jsonResult = pdfviewer.ExportFormFields(jsonData);
    return Content(jsonResult);
}
```

## Download action

> public ActionResult Download(jsonObjects jsonObject)

The [Download]( https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PdfViewer.PdfViewerServerActionSettingsBuilder.html#Syncfusion_EJ2_PdfViewer_PdfViewerServerActionSettingsBuilder_Download_System_String_) action will be triggered by clicking the Download option in the PDF Viewer toolbar to download the PDF file.

This action calls the [GetDocumentAsBase64]( https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PdfViewer.PdfRenderer.html#Syncfusion_EJ2_PdfViewer_PdfRenderer_GetDocumentAsBase64_System_Collections_Generic_Dictionary_System_String_System_String__) method to get the PDF file as a base64 string.

```cs
[System.Web.Mvc.HttpPost]
public ActionResult Download(jsonObjects jsonObject)
{
    PdfRenderer pdfviewer = new PdfRenderer();
    var jsonData = JsonConverter(jsonObject);
    string documentBase = pdfviewer.GetDocumentAsBase64(jsonData);
    return Content(documentBase);
}
```

## PrintImages

> public ActionResult PrintImages(jsonObjects jsonObject)

The [PrintImages]( https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PdfViewer.PdfViewerServerActionSettingsBuilder.html#Syncfusion_EJ2_PdfViewer_PdfViewerServerActionSettingsBuilder_Print_System_String_) action will be triggered by clicking the Print option in the PDF Viewer toolbar.

It calls the [GetPrintImage]( https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PdfViewer.PdfRenderer.html#Syncfusion_EJ2_PdfViewer_PdfRenderer_GetPrintImage_System_Collections_Generic_Dictionary_System_String_System_String__) method multiple times to get each page in the PDF file as images to print the entire file.

```cs
[System.Web.Mvc.HttpPost]
public ActionResult PrintImages(jsonObjects jsonObject)
{
    PdfRenderer pdfviewer = new PdfRenderer();
    var jsonData = JsonConverter(jsonObject);
    object pageImage = pdfviewer.GetPrintImage(jsonData);
    return Content(JsonConvert.SerializeObject(pageImage));
}
```

## Other methods

### GetDocumentPath

> private string GetDocumentPath(string document)

The GetDocumentPath method will be called inside the Load method to get the path of the document to be loaded.

```cs
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
```

### JsonConverter method

> public Dictionary<string, string> JsonConverter(jsonObjects results)

The JsonConverter method will be called by other server action methods to convert the jsonObjects into JSON data of type `Dictionary<string, string>`.

```cs
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
```

### GetPlainText method

> private HttpResponseMessage GetPlainText(string pageImage)

The GetPlainText method will be useful when you want to perform a server action without downloading the action result in the browser. This method just provides the status of the action result as a HttpResponseMessage by preventing the file download.

```cs
private HttpResponseMessage GetPlainText(string pageImage)
{
    var responseText = new HttpResponseMessage(HttpStatusCode.OK);
    responseText.Content = new StringContent(pageImage, System.Text.Encoding.UTF8, "text/plain");
    return responseText;
}
```

## jsonObjects class

The jsonObjects used as the parameter in each method is a class with various properties needed for different features in the PDF Viewer. This class must be defined in the PdfViewerController to perform all the above actions.

```cs
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
```