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

The server actions or server methods in the Core PDF Viewer controller are:

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

> public IActionResult Load([FromBody] Dictionary<string, string> jsonObject)

The [Load](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PdfViewer.PdfViewerServerActionSettingsBuilder.html#Syncfusion_EJ2_PdfViewer_PdfViewerServerActionSettingsBuilder_Load_System_String_) action will be triggered initially on loading a PDF file. Syncfusion PDF Viewer control will store the document in the cache based on the hashid during the initial loading of the pdf file. Initially, the request will be sent for 100 pages only and another request will be sent for the remaining pages. So the Load action will get triggered twice when loading a PDF file with pages more than 100, which is called virtual loading.

This action on its first trigger calls the GetDocumentPath method in the PdfViewerController.cs with which the path of the document is determined. The PDF file to be loaded must be located in the folder structure as specified in the GetDocumentPath method.

The Load action calls the [Load](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PdfViewer.PdfRenderer.html#Syncfusion_EJ2_PdfViewer_PdfRenderer_Load_System_IO_Stream_System_Collections_Generic_Dictionary_System_String_System_String__) method to load the PDF file in the PDF Viewer.

```cs
public IActionResult Load([FromBody] Dictionary<string, string> jsonObject)
{
    Console.WriteLine("Load called");
    //Initialize the PDF viewer object with memory cache object
    PdfRenderer pdfviewer = new PdfRenderer(_cache);
    MemoryStream stream = new MemoryStream();
    object jsonResult = new object();
    if (jsonObject != null && jsonObject.ContainsKey("document"))
    {
        if (bool.Parse(jsonObject["isFileName"]))
        {
            string documentPath = GetDocumentPath(jsonObject["document"]);
            if (!string.IsNullOrEmpty(documentPath))
            {
                byte[] bytes = System.IO.File.ReadAllBytes(documentPath);
                stream = new MemoryStream(bytes);
            }
            else
            {
                return this.Content(jsonObject["document"] + " is not found");
            }
        }
        else
        {
            byte[] bytes = Convert.FromBase64String(jsonObject["document"]);
            stream = new MemoryStream(bytes);
        }
    }
    jsonResult = pdfviewer.Load(stream, jsonObject);
    return Content(JsonConvert.SerializeObject(jsonResult));
}
```

## RenderPdfPages

> public IActionResult RenderPdfPages([FromBody] Dictionary<string, string> jsonObject)

Whenever a new page is loaded, [RenderPdfPages](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PdfViewer.PdfViewerServerActionSettingsBuilder.html#Syncfusion_EJ2_PdfViewer_PdfViewerServerActionSettingsBuilder_RenderPages_System_String_) action will be called. When a PDF file is loaded with PDF Viewer, only two pages will be loaded initially by hitting this action for loading each page. Further pages will be loaded on demand by hitting this action.

The RenderPdfPages action calls the [GetPage](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PdfViewer.PdfRenderer.html#Syncfusion_EJ2_PdfViewer_PdfRenderer_GetPage_System_Collections_Generic_Dictionary_System_String_System_String__) method to render each PDF pages.

```cs
public IActionResult RenderPdfPages([FromBody] Dictionary<string, string> jsonObject)
{
    //Initialize the PDF Viewer object with memory cache object
    PdfRenderer pdfviewer = new PdfRenderer(_cache);
    object jsonResult = pdfviewer.GetPage(jsonObject);
    return Content(JsonConvert.SerializeObject(jsonResult));
}
```

## RenderThumbnailImages action

> public IActionResult RenderThumbnailImages([FromBody] Dictionary<string, string> jsonObject)

The [RenderThumbnailImages](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PdfViewer.PdfViewerServerActionSettingsBuilder.html#Syncfusion_EJ2_PdfViewer_PdfViewerServerActionSettingsBuilder_RenderThumbnail_System_String_) action will be triggered initially on loading a PDF file. It renders the thumbnails images of all the pages in the PDF file. When a thumbnail image is clicked, the RenderPdfPages action will be triggered to load the selected page.

This action calls the [GetThumbnailImages](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PdfViewer.PdfRenderer.html#Syncfusion_EJ2_PdfViewer_PdfRenderer_GetThumbnailImages_System_Collections_Generic_Dictionary_System_String_System_String__) method.

```cs
public IActionResult RenderThumbnailImages([FromBody] Dictionary<string, string> jsonObject)
{
    //Initialize the PDF Viewer object with memory cache object
    PdfRenderer pdfviewer = new PdfRenderer(_cache);
    object result = pdfviewer.GetThumbnailImages(jsonObject);
    return Content(JsonConvert.SerializeObject(result));
}
```

## Bookmarks

> public IActionResult Bookmarks([FromBody] Dictionary<string, string> jsonObject)

The Bookmarks action will be triggered initially on loading a PDF file. All the headings in the PDF file will get added to the Bookmarks collection in the bookmarks panel with the help of this action. When a bookmark is selected, the page containing the selected heading will be rendered or opened.

This action calls the [GetBookmarks](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PdfViewer.PdfRenderer.html#Syncfusion_EJ2_PdfViewer_PdfRenderer_GetBookmarks_System_Collections_Generic_Dictionary_System_String_System_String__) method.

```cs
public IActionResult Bookmarks([FromBody] Dictionary<string, string> jsonObject)
{
    //Initialize the PDF Viewer object with memory cache object
    PdfRenderer pdfviewer = new PdfRenderer(_cache);
    var jsonResult = pdfviewer.GetBookmarks(jsonObject);
    return Content(JsonConvert.SerializeObject(jsonResult));
}
```

## RenderAnnotationComments

> public IActionResult RenderAnnotationComments([FromBody] Dictionary<string, string> jsonObject)

The [RenderAnnotationComments](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PdfViewer.PdfViewerServerActionSettingsBuilder.html#Syncfusion_EJ2_PdfViewer_PdfViewerServerActionSettingsBuilder_RenderComments_System_String_) action will be triggered initially on loading a PDF file.

It calls the [GetAnnotationComments](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PdfViewer.PdfRenderer.html#Syncfusion_EJ2_PdfViewer_PdfRenderer_GetAnnotationComments_System_Collections_Generic_Dictionary_System_String_System_String__) method to retrieve the annotation comments in the PDF file.

```cs
public IActionResult RenderAnnotationComments([FromBody] Dictionary<string, string> jsonObject)
{
    //Initialize the PDF Viewer object with memory cache object
    PdfRenderer pdfviewer = new PdfRenderer(_cache);
    object jsonResult = pdfviewer.GetAnnotationComments(jsonObject);
    return Content(JsonConvert.SerializeObject(jsonResult));
}
```

## Unload action

> public IActionResult Unload([FromBody] Dictionary<string, string> jsonObject)

The [Unload](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PdfViewer.PdfViewerServerActionSettingsBuilder.html#Syncfusion_EJ2_PdfViewer_PdfViewerServerActionSettingsBuilder_Unload_System_String_) action will be triggered on unloading a PDF file by closing or refreshing the browser.

This action calls the [ClearCache](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PdfViewer.PdfRenderer.html#Syncfusion_EJ2_PdfViewer_PdfRenderer_ClearCache_System_Collections_Generic_Dictionary_System_String_System_String__) method to clear the cache objects while closing the PDF Viewer.

```cs
public IActionResult Unload([FromBody] Dictionary<string, string> jsonObject)
{
    //Initialize the PDF Viewer object with memory cache object
    PdfRenderer pdfviewer = new PdfRenderer(_cache);
    pdfviewer.ClearCache(jsonObject);
    return this.Content("Document cache is cleared");
}
```

## ExportAnnotations action

> public IActionResult ExportAnnotations([FromBody] Dictionary<string, string> jsonObject)

The [ExportAnnotations](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PdfViewer.PdfViewerServerActionSettingsBuilder.html#Syncfusion_EJ2_PdfViewer_PdfViewerServerActionSettingsBuilder_ExportAnnotations_System_String_) action will be triggered by clicking either the “Export annotation to JSON file” option or the “Export annotation to XFDF file” option in the annotation toolbar.

This action calls the [ExportAnnotation](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PdfViewer.PdfRenderer.html#Syncfusion_EJ2_PdfViewer_PdfRenderer_ExportAnnotation_System_Collections_Generic_Dictionary_System_String_System_String__) method to export the annotations in the PDF Viewer to a JSON file or an XFDF file.

```cs
public IActionResult ExportAnnotations([FromBody] Dictionary<string, string> jsonObject)
{
    PdfRenderer pdfviewer = new PdfRenderer(_cache);
    string jsonResult = pdfviewer.ExportAnnotation(jsonObject);
    return Content(jsonResult);
}
```

## ImportAnnotations

> public IActionResult ImportAnnotations([FromBody] Dictionary<string, string> jsonObject)

The [ImportAnnotations](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PdfViewer.PdfViewerServerActionSettingsBuilder.html#Syncfusion_EJ2_PdfViewer_PdfViewerServerActionSettingsBuilder_ImportAnnotations_System_String_) action will be triggered by clicking the “Import annotation from XFDF file” option in the annotation toolbar.

This action calls the [ImportAnnotation](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PdfViewer.PdfRenderer.html#Syncfusion_EJ2_PdfViewer_PdfRenderer_ImportAnnotation_System_Collections_Generic_Dictionary_System_String_System_String__) method to import the annotations from an XFDF file.

```cs
public IActionResult ImportAnnotations([FromBody] Dictionary<string, string> jsonObject)
{
    PdfRenderer pdfviewer = new PdfRenderer(_cache);
    string jsonResult = string.Empty;
    object JsonResult;
    if (jsonObject != null && jsonObject.ContainsKey("fileName"))
    {
        string documentPath = GetDocumentPath(jsonObject["fileName"]);
        if (!string.IsNullOrEmpty(documentPath))
        {
            jsonResult = System.IO.File.ReadAllText(documentPath);
        }
        else
        {
            return this.Content(jsonObject["document"] + " is not found");
        }
    }
    else
    {
        string extension = Path.GetExtension(jsonObject["importedData"]);
        if (extension != ".xfdf")
        {
            JsonResult = pdfviewer.ImportAnnotation(jsonObject);
            return Content(JsonConvert.SerializeObject(JsonResult));
        }
        else
        {
            string documentPath = GetDocumentPath(jsonObject["importedData"]);
            if (!string.IsNullOrEmpty(documentPath))
            {
                byte[] bytes = System.IO.File.ReadAllBytes(documentPath);
                jsonObject["importedData"] = Convert.ToBase64String(bytes);
                JsonResult = pdfviewer.ImportAnnotation(jsonObject);
                return Content(JsonConvert.SerializeObject(JsonResult));
            }
            else
            {
                return this.Content(jsonObject["document"] + " is not found");
            }
        }
    }
    return Content(jsonResult);
}
```

## ImportFormFields action

> public IActionResult ImportFormFields([FromBody] Dictionary<string, string> jsonObject)

The [ImportFormFields](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PdfViewer.PdfViewerServerActionSettingsBuilder.html#Syncfusion_EJ2_PdfViewer_PdfViewerServerActionSettingsBuilder_ImportFormFields_System_String_) action will be triggered by calling it from the UI code.

This action calls the [ImportFormFields](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PdfViewer.PdfRenderer.html#Syncfusion_EJ2_PdfViewer_PdfRenderer_ImportFormFields_System_Collections_Generic_Dictionary_System_String_System_String__) method to import the form fields into the PDF Viewer from a JSON object or file.

```cs
public IActionResult ImportFormFields([FromBody] Dictionary<string, string> jsonObject)
{
    PdfRenderer pdfviewer = new PdfRenderer(_cache);
    jsonObject["data"] = GetDocumentPath(jsonObject["data"]);
    object jsonResult = pdfviewer.ImportFormFields(jsonObject);
    return Content(JsonConvert.SerializeObject(jsonResult));
}
```

## ExportFormFields action

> public IActionResult ExportFormFields([FromBody] Dictionary<string, string> jsonObject)

The [ExportFormFields](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PdfViewer.PdfViewerServerActionSettingsBuilder.html#Syncfusion_EJ2_PdfViewer_PdfViewerServerActionSettingsBuilder_ExportFormFields_System_String_) action will be triggered by clicking the Submit Form option in the PDF Viewer toolbar. The Submit Form option is enabled only when there are form fields. It exports the form fields into a JSON file.

This action calls the [ExportFormFields](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PdfViewer.PdfRenderer.html#Syncfusion_EJ2_PdfViewer_PdfRenderer_ExportFormFields_System_Collections_Generic_Dictionary_System_String_System_String__) method to export the form fields into a JSON string.

```cs
public IActionResult ExportFormFields([FromBody] Dictionary<string, string> jsonObject)
{
    PdfRenderer pdfviewer = new PdfRenderer(_cache);
    string jsonResult = pdfviewer.ExportFormFields(jsonObject);
    return Content(jsonResult);
}
```

## Download action

> public IActionResult Download([FromBody] Dictionary<string, string> jsonObject)

The [Download](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PdfViewer.PdfViewerServerActionSettingsBuilder.html#Syncfusion_EJ2_PdfViewer_PdfViewerServerActionSettingsBuilder_Download_System_String_) action will be triggered by clicking the Download option in the PDF Viewer toolbar to download the PDF file.

This action calls the [GetDocumentAsBase64](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PdfViewer.PdfRenderer.html#Syncfusion_EJ2_PdfViewer_PdfRenderer_GetDocumentAsBase64_System_Collections_Generic_Dictionary_System_String_System_String__) method to get the PDF file as a base64 string.

```cs
public IActionResult Download([FromBody] Dictionary<string, string> jsonObject)
{
    //Initialize the PDF Viewer object with memory cache object
    PdfRenderer pdfviewer = new PdfRenderer(_cache);
    string documentBase = pdfviewer.GetDocumentAsBase64(jsonObject);
    return Content(documentBase);
}
```

## PrintImages

> public IActionResult PrintImages([FromBody] Dictionary<string, string> jsonObject)

The [PrintImages](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PdfViewer.PdfViewerServerActionSettingsBuilder.html#Syncfusion_EJ2_PdfViewer_PdfViewerServerActionSettingsBuilder_Print_System_String_) action will be triggered by clicking the Print option in the PDF Viewer toolbar.

It calls the [GetPrintImage](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PdfViewer.PdfRenderer.html#Syncfusion_EJ2_PdfViewer_PdfRenderer_GetPrintImage_System_Collections_Generic_Dictionary_System_String_System_String__) method multiple times to get each page in the PDF file as images to print the entire file.

```cs
public IActionResult PrintImages([FromBody] Dictionary<string, string> jsonObject)
{
    //Initialize the PDF Viewer object with memory cache object
    PdfRenderer pdfviewer = new PdfRenderer(_cache);
    object pageImage = pdfviewer.GetPrintImage(jsonObject);
    return Content(JsonConvert.SerializeObject(pageImage));
}
```

## GetDocumentPath method

> private string GetDocumentPath(string document)

The GetDocumentPath method will be called inside the Load method to get the path of the document to be loaded.

```cs
private string GetDocumentPath(string document)
{
    string documentPath = string.Empty;
    if (!System.IO.File.Exists(document))
    {
        var path = _hostingEnvironment.ContentRootPath;
        if (System.IO.File.Exists(path + "/Data/" + document))
            documentPath = path + "/Data/" + document;
    }
    else
    {
        documentPath = document;
    }
    Console.WriteLine(documentPath);
    return documentPath;
}
```

## PdfViewerController constructor

> public PdfViewerController(IHostingEnvironment hostingEnvironment, IMemoryCache cache)

The IMemoryCache is required for rendering the PDF pages in the PDF Viewer control by storing the document in the cache. So, it has been initialized in the PdfViewerController and has to be used in all the controller methods.

```cs
private IHostingEnvironment _hostingEnvironment;
//Initialize the memory cache object
public IMemoryCache _cache;
public PdfViewerController(IHostingEnvironment hostingEnvironment, IMemoryCache cache)
{
    _hostingEnvironment = hostingEnvironment;
    _cache = cache;
    Console.WriteLine("PdfViewerController initialized");
}
```