---
layout: post
title: Google Cloud Storage in ##Platform_Name## PDF Viewer Component
description: Learn here all about how to Open PDF files from Google Cloud Storage in ASP.NET CORE PDF Viewer component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: PDF Viewer
publishingplatform: ##Platform_Name##
documentation: ug
---

# Open PDF file from Google Cloud Storage

To load a PDF file from Google Cloud Storage in a PDF Viewer, you can follow the steps below

**Step 1** Create a Service Account

Open the Google Cloud Console. Navigate to `IAM & Admin` > `Service accounts`. Click `Create Service Account`.` Enter a name, assign roles (e.g., Storage Object Admin), and create a key in JSON format. Download the key file securely. Utilize the downloaded key file in your applications or services for authentication and access to the Google Cloud Storage bucket. For additional details, refer to the [official documentation](https://cloud.google.com/iam/docs/service-accounts-create).

**Step 2:** Create PDF Viewer Sample in ASP.NET Core

Follow instructions provided in the Syncfusion<sup style="font-size:70%">&reg;</sup> PDF Viewer Getting Started [Guide](https://ej2.syncfusion.com/aspnetcore/documentation/pdfviewer/getting-started-with-server-backed) to create a simple PDF Viewer sample in ASP.NET Core

**Step 3:** Modify the `Index.cshtml.cs` File in the Project 

1. Import the required namespaces at the top of the file.

```csharp
using System.IO;
using Google.Cloud.Storage.V1;
using Google.Apis.Auth.OAuth2;

```

2. Add the following private fields and constructor parameters to the `Index.cshtml.cs` class, In the constructor, assign the values from the configuration to the corresponding fields

```csharp

    // Private readonly object _storageClient
    private readonly StorageClient _storageClient;

    private IConfiguration _configuration;

    public readonly string _bucketName;

    public IndexModel(Microsoft.AspNetCore.Hosting.IHostingEnvironment hostingEnvironment, IMemoryCache cache, IConfiguration configuration)
    {
        _hostingEnvironment = hostingEnvironment;
        _cache = cache;
        // The key file is used to authenticate with Google Cloud Storage.
        string keyFilePath = @"path/to/service-account-key.json";

        // Load the service account credentials from the key file.
        var credentials = GoogleCredential.FromFile(keyFilePath);

        // Create a storage client with Application Default Credentials
        _storageClient = StorageClient.Create(credentials);

        _configuration = configuration;

        _bucketName = _configuration.GetValue<string>("BucketName");
    }
```

3. Modify the `OnPostLoad()` method to load the PDF files from Google Cloud Storage.

```csharp

public IActionResult OnPostLoad([FromBody] jsonObjects responseData)
{
    PdfRenderer pdfviewer = new PdfRenderer(_cache);
    MemoryStream stream = new MemoryStream();
    var jsonObject = JsonConverterstring(responseData);
    object jsonResult = new object();
    if (jsonObject != null && jsonObject.ContainsKey("document"))
    {
        if (bool.Parse(jsonObject["isFileName"]))
        {
            string bucketName = _bucketName;
            string objectName = jsonObject["document"];
            _storageClient.DownloadObject(bucketName, objectName, stream);
            stream.Position = 0;
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
  "BucketName": "Your Bucket name from Google Cloud Storage"
}
```

N> Replace **Your Bucket name from Google Cloud Storage** with the actual name of your Google Cloud Storage bucket

N> Replace **path/to/service-account-key.json** with the actual file path to your service account key JSON file. Make sure to provide the correct path and filename.

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

N> The **Google.Cloud.Storage.V1** NuGet package must be installed in your application to use the previous code example.

[View sample in GitHub](https://github.com/SyncfusionExamples/open-save-pdf-documents-in-google-cloud-storage)