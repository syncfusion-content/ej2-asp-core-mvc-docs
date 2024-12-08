---
layout: post
title: Save PDF to Azure Blob Storage in ##Platform_Name## PdfViewer | Syncfusion
description: Save PDF files to Azure Blob Storage in ASP.NET CORE PDF Viewer component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: PDF Viewer
publishingplatform: ##Platform_Name##
documentation: ug
---

# Save PDF file to Azure Blob Storage

PDF Viewer allows to save PDF file to Azure Blob Storage using either the Standalone or Server-backed PDF Viewer. Below are the steps and a sample to demonstrate how to save PDF to Azure Blob Storage.

## Using Standalone PDF Viewer

To save a PDF file to Azure Blob Storage, you can follow the steps below.

**Step 1:** Create the Azure Blob Storage account.

Log in to the Azure Portal. Create a new Storage Account with preferred settings. Note access keys during the setup. Within the Storage Account, create a Blob Container following the steps in this [link](https://learn.microsoft.com/en-us/azure/storage/common/storage-account-create?toc=%2Fazure%2Fstorage%2Fblobs%2Ftoc.json&tabs=azure-portal).

**Step 2:** Create PDF Viewer Sample in ASP.NET Core

Follow instructions provided in the Syncfusion<sup style="font-size:70%">&reg;</sup> PDF Viewer Getting Started [Guide](https://ej2.syncfusion.com/aspnetcore/documentation/pdfviewer/getting-started-with-server-backed) to create a simple PDF Viewer sample in ASP.NET Core.

**Step 3:** Modify the `Index.cshtml.cs` File in the Project. 

1. Import the required namespaces at the top of the file.

```csharp
using Azure.Storage.Blobs;
```

2. Add the following private fields to the `Index.cshtml.cs` class, and assign the values to the corresponding fields. Add `Upload()` method to save the downloaded PDF files to Azure Blob Storage container.

```csharp
private readonly string ConnectionString = "Your Connection string from Azure";
private readonly string blobContainerName = "Your container name in Azure";

public async Task<IActionResult> OnPostUploadAsync([FromBody] UploadFileRequest request)
{
  if (request == null || string.IsNullOrEmpty(request.FileName) || string.IsNullOrEmpty(request.FileContent))
  {
    return new JsonResult(new { error = "Invalid file or file name." }) { StatusCode = 400 };
  }
  try
  {
    byte[] fileBytes = Convert.FromBase64String(request.FileContent);
    BlobServiceClient blobServiceClient = new BlobServiceClient(ConnectionString);
    BlobContainerClient containerClient = blobServiceClient.GetBlobContainerClient(blobContainerName);
    BlobClient blobClient = containerClient.GetBlobClient(request.FileName);

    using (var stream = new MemoryStream(fileBytes))
    {
      await blobClient.UploadAsync(stream, true);
    }

    var fileUrl =  blobClient.Uri.ToString();
    return new JsonResult(fileUrl);
  }
  catch (Exception ex)
  {
    return new JsonResult(new { error = ex.Message }) { StatusCode = 500 };
  }
}
```

N> Replace **Your Connection string from Azure** with the actual connection string for your Azure Blob Storage account and **Your container name in Azure** with the actual container name.

1. Configure a custom toolbar item for the download function to save a PDF file in Azure Blob Storage.

```csharp
<div class="text-center">
    <ejs-pdfviewer id="pdfviewer" style="height:600px" created="loadDocument" toolbarClick="toolbarClick">
    </ejs-pdfviewer>
</div>

<script type="text/javascript">
  window.onload = function () {
    var pdfViewer = document.getElementById('pdfviewer').ej2_instances[0];
    var toolItem1 = {
      prefixIcon: 'e-icons e-pv-download-document-icon',
      id: 'download_pdf',
      tooltipText: 'Download file',
      align: 'right'
    };
    pdfViewer.toolbarSettings = {
      showTooltip: true,
      toolbarItems: ['OpenOption', 'PageNavigationTool', 'MagnificationTool', 'PanTool', 'SelectionTool', 'SearchOption', 'PrintOption', toolItem1, 'UndoRedoTool', 'AnnotationEditTool', 'FormDesignerEditTool', 'CommentTool', 'SubmitForm']
    };
  }
  function toolbarClick(args) {
    var pdfViewer = document.getElementById('pdfviewer').ej2_instances[0];
    if (args.item && args.item.id === 'download_pdf') {
      saveDocument();
    }
  }
</script>
```

2. Retrieve the PDF viewer instance and save the current PDF as a Blob. Next, read the Blob as an ArrayBuffer and convert it to a Base64 string using arrayBufferToBase64 method. Finally, upload the Base64 string to Azure Blob Storage using the `Index.cshtml.cs`.

```csharp
function saveDocument() {
  var pdfViewer = document.getElementById('pdfviewer').ej2_instances[0];
  var fileName = pdfViewer.fileName;
  pdfViewer.saveAsBlob().then(function (value) {
    var reader = new FileReader();
    reader.onload = async () => {
      if (reader.result) {
        const arrayBuffer = reader.result;
        var base64String = arrayBufferToBase64(arrayBuffer);
        var data = {
          fileName: fileName,
          fileContent: base64String
        };

        fetch('/Index?handler=Upload', {
          method: 'POST',
          headers: {
              'Content-Type': 'application/json'
          },
          body: JSON.stringify(data)
        }).then(response => response.json())
          .then(data => {
              if (data.uri) {
                  alert('File uploaded successfully! Blob URI: ' + data.uri);
              } else {
                  alert('Error occurred..' + data.error);
              }
          }).catch(error => {
              alert('Error occurred..' + data.error);
          });
      }
    };
    reader.readAsArrayBuffer(value);
  });
}
```

N> The **Azure.Storage.Blobs** NuGet package must be installed in your application to use the previous code example.

[View sample in GitHub](https://github.com/SyncfusionExamples/open-save-pdf-documents-in-azure-blob-storage/tree/master/Open%20and%20Save%20PDF%20in%20Azure%20Blob%20Storage%20using%20Standalone).

## Using Server-Backed PDF Viewer

To save a PDF file to Azure Blob Storage, you can follow the steps below.

**Step 1:** Create the Azure Blob Storage account

Log in to the Azure Portal. Create a new Storage Account with preferred settings. Note access keys during the setup. Within the Storage Account, create a Blob Container following the steps in this [link](https://learn.microsoft.com/en-us/azure/storage/common/storage-account-create?toc=%2Fazure%2Fstorage%2Fblobs%2Ftoc.json&tabs=azure-portal).

**Step 2:** Create PDF Viewer Sample in ASP.NET Core

Follow instructions provided in the Syncfusion<sup style="font-size:70%">&reg;</sup> PDF Viewer Getting Started [Guide](https://ej2.syncfusion.com/aspnetcore/documentation/pdfviewer/getting-started-with-server-backed) to create a simple PDF Viewer sample in ASP.NET Core.

**Step 3:** Modify the `Index.cshtml.cs` File in the Project 

1. Import the required namespaces at the top of the file.

```csharp
using System.IO;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Specialized;
```

2. Add the following private fields and constructor parameters to the `Index.cshtml.cs` class, In the constructor, assign the values from the configuration to the corresponding fields.

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

[View sample in GitHub](https://github.com/SyncfusionExamples/open-save-pdf-documents-in-azure-blob-storage/tree/master/Open%20and%20Save%20PDF%20in%20Azure%20Blob%20Storage%20using%20Server-Backend).