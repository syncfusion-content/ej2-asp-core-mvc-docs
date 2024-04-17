---
layout: post
title: Azure Blob Storage in ##Platform_Name## PDF Viewer Component
description: Save PDF files to Azure Blob Storage in ASP.NET CORE PDF Viewer component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: PDF Viewer
publishingplatform: ##Platform_Name##
documentation: ug
---

# Save PDF file to Azure Blob Storage

To save a PDF file to Azure Blob Storage, you can follow the steps below

**Step 1:** Create the Azure Blob Storage account

Log in to the Azure Portal. Create a new Storage Account with preferred settings. Note access keys during the setup. Within the Storage Account, create a Blob Container following the steps in this [link](https://learn.microsoft.com/en-us/azure/storage/common/storage-account-create?toc=%2Fazure%2Fstorage%2Fblobs%2Ftoc.json&tabs=azure-portal).

**Step 2:** Create PDF Viewer Sample in ASP.NET Core

Follow instructions provided in the Syncfusion PDF Viewer Getting Started [Guide](https://ej2.syncfusion.com/aspnetcore/documentation/pdfviewer/getting-started-with-server-backed) to create a simple PDF Viewer sample in ASP.NET Core.

**Step 3:** Modify the `Index.cshtml.cs` File in the Project 

1. Import the required namespaces at the top of the file.

```csharp
using System.IO;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Specialized;
```

2. Add the following private fields and constructor parameters to the `Index.cshtml.cs` class, In the constructor, assign the values from the configuration to the corresponding fields

```csharp

private readonly string _storageConnectionString;
private readonly string _storageContainerName;
private readonly ILogger<IndexModel> _logger;

public IndexModel(Microsoft.AspNetCore.Hosting.IHostingEnvironment hostingEnvironment, IMemoryCache cache, IConfiguration configuration, ILogger<IndexModel> logger)
{
    _hostingEnvironment = hostingEnvironment;
    _cache = cache;
    _storageConnectionString = configuration.GetValue<string>("connectionString");
    _storageContainerName = configuration.GetValue<string>("containerName");
    _logger = logger;
}
```

3. Modify the `OnPostDownload()` method to save the downloaded PDF files to Azure Blob Storage container

```csharp

public IActionResult OnPostDownload([FromBody] jsonObjects responseData)
{
    PdfRenderer pdfviewer = new PdfRenderer(_cache);
    var jsonObject = JsonConverterstring(responseData);
    string documentBase = pdfviewer.GetDocumentAsBase64(jsonObject);
    string document = jsonObject["documentId"];

    // Create a BlobServiceClient object
    BlobServiceClient blobServiceClient = new BlobServiceClient(_storageConnectionString);

    // Get a reference to the blob container
    BlobContainerClient containerClient = blobServiceClient.GetBlobContainerClient(_storageContainerName);

    string result = Path.GetFileNameWithoutExtension(document);
    // Get a reference to the blob
    BlobClient blobClient = containerClient.GetBlobClient(result + "_download.pdf");

    // Convert the document base64 string to bytes
    byte[] bytes = Convert.FromBase64String(documentBase.Split(",")[1]);

    // Upload the document to Azure Blob Storage
    using (MemoryStream stream = new MemoryStream(bytes))
    {
        blobClient.Upload(stream, true);
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
  "connectionString": "*Your Connection string from Azure*",
  "containerName": "*Your container name in Azure*"
}
```

N> Replace **Your Connection string from Azure** with the actual connection string for your Azure Blob Storage account and **Your container name in Azure** with the actual container name 

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

N> The **Azure.Storage.Blobs** NuGet package must be installed in your application to use the previous code example.

[View sample in GitHub](https://github.com/SyncfusionExamples/open-save-pdf-documents-in-azure-blob-storage).