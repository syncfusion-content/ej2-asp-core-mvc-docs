---
layout: post
title: Google Cloud Storage in ##Platform_Name## PDF Viewer Component
description: Learn here all about how to Open PDF files from Google Cloud Storage in ASP.NET MVC PDF Viewer component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: PDF Viewer
publishingplatform: ##Platform_Name##
documentation: ug
---

# Open PDF file from Google Cloud Storage

To load a PDF file from Google Cloud Storage in a PDF Viewer, you can follow the steps below

**Step 1** Create a Service Account

Open the Google Cloud Console. Navigate to `IAM & Admin` > `Service accounts`. Click `Create Service Account`.` Enter a name, assign roles (e.g., Storage Object Admin), and create a key in JSON format. Download the key file securely. Utilize the downloaded key file in your applications or services for authentication and access to the Google Cloud Storage bucket. For additional details, refer to the [official documentation](https://cloud.google.com/iam/docs/service-accounts-create).

**Step 2:** Create PDF Viewer Sample in ASP.NET MVC

Follow instructions provided in the Syncfusion<sup style="font-size:70%">&reg;</sup> PDF Viewer Getting Started [Guide](https://ej2.syncfusion.com/aspnetmvc/documentation/pdfviewer/getting-started-with-server-backed#integrate-pdf-viewer-into-an-aspnet-mvc-application) to create a simple PDF Viewer sample in ASP.NET MVC.

**Step 3:** Modify the `HomeController.cs` File in the Project 

1. Import the required namespaces at the top of the file.

```csharp
using System.IO;
using Google.Cloud.Storage.V1;
using Google.Apis.Auth.OAuth2;

```
2. Add the following private fields and constructor parameters to the `HomeController.cs` class, In the constructor, assign the values from the configuration to the corresponding fields

```csharp

    // The key file is used to authenticate with Google Cloud Storage.
    private string keyFilePath = @"path/to/service-account-key.json"; 
    private readonly string _bucketName = "Your Bucket name from Google Cloud Storage";
    private readonly StorageClient _storageClient;

    public HomeController()
    {
        // Load the service account credentials from the key file.
        var credentials = GoogleCredential.FromFile(keyFilePath);

        // Create a storage client with Application Default Credentials
        _storageClient = StorageClient.Create(credentials);
    }  

```
3. Modify the `Load()` method to load the PDF files from Google Cloud Storage bucket.

```csharp

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
   

            string bucketName = _bucketName;
            string fileName = jsonData["document"];
            _storageClient.DownloadObject(bucketName, fileName, stream);
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

N> Replace **Your Bucket name from Google Cloud Storage** with the actual name of your Google Cloud Storage bucket

N> Replace **path/to/service-account-key.json** with the actual file path to your service account key JSON file. Make sure to provide the correct path and filename.

**Step 4:** Set the PDF Viewer Properties in ASP.NET MVC PDF viewer component

Set the `documentPath` property of the PDF viewer component to the desired name of the PDF file you wish to load from Google Cloud Storage. Ensure that you correctly pass the document name from the files available in your azure container to the documentPath property.

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

N> The **Google.Cloud.Storage.V1** NuGet package must be installed in your application to use the previous code example.

[View sample in GitHub](https://github.com/SyncfusionExamples/open-save-pdf-documents-in-google-cloud-storage)