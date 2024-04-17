---
layout: post
title: Box cloud file storage in ##Platform_Name## PDF Viewer Component
description: Learn here all about how to Open PDF files from Box cloud file storage in ASP.NET MVC PDF Viewer component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: PDF Viewer
publishingplatform: ##Platform_Name##
documentation: ug
---

# Open PDF file from Box cloud file storage

To load a PDF file from Box cloud file storage in a PDF Viewer, you can follow the steps below

**Step 1** Set up a Box developer account and create a Box application

To access Box storage programmatically, you'll need a developer account with Box. Go to the [Box Developer Console](https://developer.box.com/), sign in or create a new account, and then create a new Box application. This application will provide you with the necessary credentials Client ID and Client Secret to authenticate and access Box APIs. Before accessing files, you need to authenticate your application to access your Box account. Box API supports `OAuth 2.0 authentication` for this purpose.

**Step 2:** Create PDF Viewer Sample in ASP.NET MVC

Follow instructions provided in the Syncfusion PDF Viewer Getting Started [Guide](https://ej2.syncfusion.com/aspnetmvc/documentation/pdfviewer/getting-started-with-server-backed#integrate-pdf-viewer-into-an-aspnet-mvc-application) to create a simple PDF Viewer sample in ASP.NET MVC.

**Step 3:** Modify the `HomeController.cs` File in the Project 

1. Import the required namespaces at the top of the file.

```csharp
using Box.V2;
using Box.V2.Auth;
using Box.V2.Config;
using Box.V2.Models;
```

2. Modify the `Load()` method to load the PDF files from Box cloud file storage.

```csharp

 private readonly string _clientId = "Your_Box_Storage_ClientID";
 private readonly string _clientSecret = "Your_Box_Storage_ClientSecret";
 private readonly string _accessToken = "Your_Box_Storage_Access_Token";
 private readonly string _folderId = "Your_Folder_ID";

 [System.Web.Mvc.HttpPost]

 public async Task<ActionResult> Load(jsonObjects jsonObject)
 {
     PdfRenderer pdfviewer = new PdfRenderer();
     MemoryStream stream = new MemoryStream();
     var jsonData = JsonConverter(jsonObject);
     object jsonResult = new object();
     if (jsonObject != null && jsonData.ContainsKey("document"))
     {
         if (bool.Parse(jsonData["isFileName"]))
         {
             string objectName = jsonData["document"];
             // Initialize the Box API client with your authentication credentials
             var auth = new OAuthSession(_accessToken, "YOUR_REFRESH_TOKEN", 3600, "bearer");
             var config = new BoxConfigBuilder(_clientId, _clientSecret, new Uri("http://boxsdk")).Build();
             var client = new BoxClient(config, auth);

             // Download the file from Box storage
             var items = await client.FoldersManager.GetFolderItemsAsync(_folderId, 1000, autoPaginate: true);
             var files = items.Entries.Where(i => i.Type == "file");

             // Filter the files based on the objectName
             var matchingFile = files.FirstOrDefault(file => file.Name == objectName);

             // Fetch the file from Box storage by its name
             var fileStream = await client.FilesManager.DownloadAsync(matchingFile.Id);
             stream = new MemoryStream();
             await fileStream.CopyToAsync(stream);

             // Reset the position to the beginning of the stream
             stream.Position = 0;
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

N> replace **Your_Box_Storage_Access_Token** with your actual box access token, and **Your_Folder_ID** with the ID of the folder in your box storage where you want to perform specific operations. Remember to use your valid box API credentials, as **Your_Box_Storage_ClientID** and **Your_Box_Storage_ClientSecret"** are placeholders for your application's API key and secret.

**Step 4:** Set the PDF Viewer Properties in ASP.NET MVC PDF viewer component

Set the `documentPath` property of the PDF viewer component to the desired name of the PDF file you wish to load from Box cloud file storage. Ensure that you correctly pass the document name from the files available in your azure container to the documentPath property.

```csharp

@{
    ViewBag.Title = "Home Page";
}

<div>
    <div style="height:500px;width:100%;">
        @Html.EJS().PdfViewer("pdfviewer").ServiceUrl(VirtualPathUtility.ToAbsolute("~/Home/")).DocumentPath("PDF_Succinctly.pdf").Render()
    </div>
</div>

```
N> The **Box.V2.Core** NuGet package must be installed in your application to use the previous code example.

N> Replace `PDF_Succinctly.pdf` with the actual document name that you want to load from Box cloud file storage. Make sure to pass the document name from the box folder to the `documentPath` property of the PDF viewer component

[View sample in GitHub](https://github.com/SyncfusionExamples/open-save-pdf-documents-in-box-cloud-file-storage)