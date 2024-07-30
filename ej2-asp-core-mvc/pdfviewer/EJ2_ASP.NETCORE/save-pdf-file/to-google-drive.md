---
layout: post
title: Google Drive in ##Platform_Name## PDF Viewer Component
description: Save PDF files to Google Drive in ASP.NET CORE PDF Viewer component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: PDF Viewer
publishingplatform: ##Platform_Name##
documentation: ug
---

# Save PDF file to Google Drive

To save a PDF file to Google Drive, you can follow the steps below

**Step 1** Set up Google Drive API

You must set up a project in the Google Developers Console and enable the Google Drive API. Obtain the necessary credentials to access the API. For more information, view the official [link](https://developers.google.com/drive/api/guides/enable-sdk).

**Step 2:** Create PDF Viewer Sample in ASP.NET Core

Follow instructions provided in the Syncfusion PDF Viewer Getting Started [Guide](https://ej2.syncfusion.com/aspnetcore/documentation/pdfviewer/getting-started-with-server-backed) to create a simple PDF Viewer sample in ASP.NET Core.

**Step 3:** Modify the `Index.cshtml.cs` File in the Project 

1. Import the required namespaces at the top of the file.

```csharp
using System.IO;
using Google.Apis.Drive.v3;
using Google.Apis.Util.Store;
```

2. Add the following private fields and constructor parameters to the `Index.cshtml.cs` class, In the constructor, assign the values from the configuration to the corresponding fields

```csharp

string[] Scopes = { DriveService.Scope.Drive };
private IConfiguration _configuration;
public readonly string folderId;
private readonly string applicationName;
public readonly string credentialPath;

public IndexModel(Microsoft.AspNetCore.Hosting.IHostingEnvironment hostingEnvironment, IMemoryCache cache, IConfiguration configuration)
{
    _hostingEnvironment = hostingEnvironment;
    _cache = cache;
    _configuration = configuration;
    folderId = _configuration.GetValue<string>("FolderId");
    credentialPath = _configuration.GetValue<string>("CredentialPath");
    applicationName = _configuration.GetValue<string>("ApplicationName");
}
       
```
3. Modify the `OnPostDownloadAsync()` method to save the downloaded PDF files to Google Drive bucket

```csharp
public async Task<IActionResult> OnPostDownloadAsync([FromBody] jsonObjects responseData)
{
    PdfRenderer pdfviewer = new PdfRenderer(_cache);
    var jsonObject = JsonConverterstring(responseData);
    string documentBase = pdfviewer.GetDocumentAsBase64(jsonObject);
    byte[] documentBytes = Convert.FromBase64String(documentBase.Split(",")[1]);
    string documentId = jsonObject["documentId"];
    string result = Path.GetFileNameWithoutExtension(documentId);
    string fileName = result + "_downloaded.pdf";

    UserCredential credential;

    using (var memStream = new FileStream(credentialPath, FileMode.Open, FileAccess.Read))
    {
        string credPath = "token.json";
        credential = await GoogleWebAuthorizationBroker.AuthorizeAsync(
            GoogleClientSecrets.Load(memStream).Secrets,
            Scopes,
            "user",
            CancellationToken.None,
            new FileDataStore(credPath, true));
    }

    // Create the Drive API service.
    var service = new DriveService(new BaseClientService.Initializer()
    {
        HttpClientInitializer = credential,
        ApplicationName = applicationName,
    });
    var fileMetadata = new Google.Apis.Drive.v3.Data.File()
    {
        Name = fileName,
        Parents = new List<string> { folderId }
    };
    FilesResource.CreateMediaUpload request;
    using (var stream = new MemoryStream(documentBytes))
    {
        request = service.Files.Create(fileMetadata, stream, "application/pdf");
        request.Fields = "id";
        object value = await request.UploadAsync();
    }
    return Content(documentBase);
}

```

4. Open the `appsettings.json` file in your web service project, Add the following lines below the existing `"AllowedHosts"` configuration

```json
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*",
  "FolderId": "Your Google Drive Folder ID",
  "CredentialPath": "Your Path to the OAuth 2.0 Client IDs json file",
  "ApplicationName": "Your Application name"
}
```

N> Replace **Your Google Drive Folder ID**, **Your Application name**, and **Your Path to the OAuth 2.0 Client IDs json file** with your actual Google drive folder ID , Your name for your application and the path for the JSON file.

N> The **FolderId** part is the unique identifier for the folder. For example, if your folder URL is: `https://drive.google.com/drive/folders/abc123xyz456`, then the folder ID is `abc123xyz456`.

**Step 4:** Set the PDF Viewer Properties in ASP.NET Core PDF viewer component

Set the `documentPath` property of the PDF viewer component to the desired name of the PDF file you wish to load from Azure Blob Storage. Ensure that you correctly pass the document name from the files available in your azure container to the documentPath property.

```csharp

@page "{handler?}"
@model IndexModel
@{
    ViewData["Title"] = "Home page";
}

<div class="text-center">
    <ejs-pdfviewer id="pdfviewer" style="height:600px" serviceUrl="/Index" documentPath="PDF_Succinctly.pdf">
    </ejs-pdfviewer>
</div>

```

N> The **Google.Apis.Drive.v3** NuGet package must be installed in your application to use the previous code example.

[View sample in GitHub](https://github.com/SyncfusionExamples/open-save-pdf-documents-in-google-drive)