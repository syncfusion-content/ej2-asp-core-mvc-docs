---
layout: post
title: AWS S3 in ##Platform_Name## Syncfusion PDF Viewer Component
description: Save PDF files to AWS S3 in ASP.NET CORE PDF Viewer component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: PDF Viewer
publishingplatform: ##Platform_Name##
documentation: ug
---

# Save PDF file to AWS S3

PDF Viewer allows to save PDF file to AWS S3 using either the Standalone or Server-backed PDF Viewer. Below are the steps and a sample to demonstrate how to save PDF to AWS S3.

## Using Standalone PDF Viewer

To save a PDF file to AWS S3, you can follow the steps below

**Step 1:** Create AWS S3 account 

 Set up an AWS S3 account by following the instructions on the official AWS site: [AWS Management Console](https://docs.aws.amazon.com/AmazonS3/latest/userguide/Welcome.html). Create an S3 bucket and generate access keys while ensuring secure storage of credentials.

**Step 2:** Create PDF Viewer Sample in ASP.NET Core

Follow instructions provided in the Syncfusion PDF Viewer Getting Started [Guide](https://ej2.syncfusion.com/aspnetcore/documentation/pdfviewer/getting-started) to create a simple PDF Viewer sample in ASP.NET Core.

**Step 3:** Modify the `~/Pages/Shared/_Layout.cshtml` File in the Project 

1. Add the required scripts using CDN inside the `<head>` of `~/Pages/Shared/_Layout.cshtml` file as follows,

{% tabs %}
{% highlight c# tabtitle="~/_Layout.cshtml" %}

<head>
    ...
    <script src="https://sdk.amazonaws.com/js/aws-sdk-2.1654.0.min.js"></script>
</head>

{% endhighlight %}
{% endtabs %}

**Step 4:** Modify the `~/Pages/Index.cshtml` File in the Project 

1. Configures AWS SDK with the region, access key, and secret access key. This configuration allows the application to interact with AWS services like S3.

N> Replace **Your Region** with the actual Region of your AWS S3 account and **Your Access Key** with the actual Access Key of your AWS S3 account and **Your Security Access Key** with the actual Security Access Key of your AWS S3 account.

```csharp
AWS.config.update({
  region: '**Your Region**', // Update this your region
  accessKeyId: '*Your Access Key*', // Update this with your access key id
  secretAccessKey: '*Your Security Access Key*', // Update this with your secret access key
});
```

2. Configure a custom toolbar item for the download function to save a PDF file in Azure Blob Storage.

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

3. Retrieve the PDF viewer instance and save the current PDF as a Blob. Then, read the Blob using a FileReader to convert it into an ArrayBuffer, and upload the ArrayBuffer to AWS S3 using the putObject method of the S3 instance.

N> Replace **Your Bucket Name** with the actual Bucket name of your AWS S3 account and **Your Key** with the actual File Key of your AWS S3 account.

```csharp
function saveDocument() {
    const s3 = new AWS.S3();
    var pdfViewer = document.getElementById('pdfviewer').ej2_instances[0];
    pdfViewer.saveAsBlob().then(function (value) {
        var reader = new FileReader();
        reader.onload = () => {
          const uint8Array = new Uint8Array(reader.result);
          const putObjectParams = {
            Bucket: '**Your Bucket Name**',
            Key: '**Your Key**',
            Body: uint8Array,
            ContentType: 'application/pdf',
          };
          s3.putObject(putObjectParams, (err, data) => {
            if (err) {
                console.error('Error uploading document:', err);
            } else {
                console.log('Document uploaded successfully:', data);
            }
          });
        };
        reader.readAsArrayBuffer(value);
    });
}
```

N> The **AWSSDK.S3** NuGet package must be installed in your application to use the previous code example.

[View sample in GitHub](https://github.com/SyncfusionExamples/open-save-pdf-documents-in-aws-s3/tree/master/Open%20and%20Save%20PDF%20in%20AWS%20S3%20using%20Standalone).

## Using Server-Backed PDF Viewer

To save a PDF file to AWS S3, you can follow the steps below

**Step 1:** Create AWS S3 account 

 Set up an AWS S3 account by following the instructions on the official AWS site: [AWS Management Console](https://docs.aws.amazon.com/AmazonS3/latest/userguide/Welcome.html). Create an S3 bucket and generate access keys while ensuring secure storage of credentials.

**Step 2:** Create PDF Viewer Sample in ASP.NET Core

Follow instructions provided in the Syncfusion PDF Viewer Getting Started [Guide](https://ej2.syncfusion.com/aspnetcore/documentation/pdfviewer/getting-started-with-server-backed) to create a simple PDF Viewer sample in ASP.NET Core.

**Step 3:** Modify the `Index.cshtml.cs` File in the Project 

1. Import the required namespaces at the top of the file.

```csharp
using System.IO;
using Amazon;
using Amazon.S3;
using Amazon.S3.Model;
```

2. Add the following private fields and constructor parameters to the `Index.cshtml.cs` class, In the constructor, assign the values from the configuration to the corresponding fields

```csharp

private IConfiguration _configuration;
public readonly string _accessKey;
public readonly string _secretKey;
public readonly string _bucketName;

public IndexModel(Microsoft.AspNetCore.Hosting.IHostingEnvironment hostingEnvironment, IMemoryCache cache, IConfiguration configuration)
{
  _hostingEnvironment = hostingEnvironment;
  _cache = cache;
  _configuration = configuration;
  _accessKey = _configuration.GetValue<string>("AccessKey");
  _secretKey = _configuration.GetValue<string>("SecretKey");
  _bucketName = _configuration.GetValue<string>("BucketName");
}
```
3. Modify the `OnPostDownload()` method to save the downloaded PDF files to AWS S3 bucket

```csharp

 public IActionResult OnPostDownload([FromBody] jsonObjects responseData)
 {
     PdfRenderer pdfviewer = new PdfRenderer(_cache);
     var jsonObject = JsonConverterstring(responseData);
     string documentBase = pdfviewer.GetDocumentAsBase64(jsonObject);
     RegionEndpoint bucketRegion = RegionEndpoint.USEast1;

     // Configure the AWS SDK with your access credentials and other settings
     var s3Client = new AmazonS3Client(_accessKey, _secretKey, bucketRegion);
     string bucketName = _bucketName;
     string documentName = jsonObject["documentId"];
     string result = Path.GetFileNameWithoutExtension(documentName);
     byte[] bytes = Convert.FromBase64String(documentBase.Split(",")[1]);
     using (MemoryStream stream = new MemoryStream(bytes))
     {
         var request = new PutObjectRequest
         {
             BucketName = bucketName,
             Key = result + "_downloaded.pdf",
             InputStream = stream,
         };
         // Upload the PDF document to AWS S3
         var response = s3Client.PutObjectAsync(request).Result;
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
  "AccessKey": "Your Access Key from AWS S3",
  "SecretKey": "Your Secret Key from AWS S3",
  "BucketName": "Your Bucket name from AWS S3"
}
```

N> Replace **Your Access Key from AWS S3**, **Your Secret Key from AWS S3**, and **Your Bucket name from AWS S3** with your actual AWS access key, secret key and bucket name

**Step 4:** Set the PDF Viewer Properties in ASP.NET Core PDF viewer component

Set the `documentPath` property of the PDF viewer component to the desired name of the PDF file you wish to load from AWS S3. Ensure that you correctly pass the document name from the files available in your azure container to the documentPath property.

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

N> The **AWSSDK.S3** NuGet package must be installed in your application to use the previous code example.

[View sample in GitHub](https://github.com/SyncfusionExamples/open-save-pdf-documents-in-aws-s3/tree/master/Open%20and%20Save%20PDF%20in%20AWS%20S3%20using%20Server-Backend)