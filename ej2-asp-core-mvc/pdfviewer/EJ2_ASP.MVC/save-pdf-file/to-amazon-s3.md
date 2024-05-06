---
layout: post
title: Amazon S3 in ##Platform_Name## PDF Viewer Component| Syncfusion
description: Save PDF files to Amazon S3 in ASP.NET MVC PDF Viewer component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: PDF Viewer
publishingplatform: ##Platform_Name##
documentation: ug
---

# Save PDF file to AWS S3

To save a PDF file to AWS S3 bucket, you can follow the steps below

**Step 1:** Create AWS S3 account 

 Set up an AWS S3 account by following the instructions on the official AWS site: [AWS Management Console](https://docs.aws.amazon.com/AmazonS3/latest/userguide/Welcome.html). Create an S3 bucket and generate access keys while ensuring secure storage of credentials.

**Step 2:** Create PDF Viewer Sample in ASP.NET MVC

Follow instructions provided in the Syncfusion PDF Viewer Getting Started [Guide](https://ej2.syncfusion.com/aspnetmvc/documentation/pdfviewer/getting-started-with-server-backed#integrate-pdf-viewer-into-an-aspnet-mvc-application) to create a simple PDF Viewer sample in ASP.NET MVC.

**Step 3:** Modify the `HomeController.cs` File in the Project 

1. Import the required namespaces at the top of the file.

```csharp
using System.IO;
using Amazon;
using Amazon.S3;
using Amazon.S3.Model
```

3. Modify the `Download()` method to save the downloaded PDF files to AWS S3 container

```csharp
 private readonly string _accessKey = "Your Access Key from AWS S35";
 private readonly string _secretKey = "Your Secret Key from AWS S3";
 private readonly string _bucketName = "Your Bucket name from AWS S3";

[System.Web.Mvc.HttpPost]
public ActionResult Download(jsonObjects jsonObject)
{
    PdfRenderer pdfviewer = new PdfRenderer();
    var jsonData = JsonConverter(jsonObject);
    string documentBase = pdfviewer.GetDocumentAsBase64(jsonData);
    RegionEndpoint bucketRegion = RegionEndpoint.USEast1;

    // Configure the AWS SDK with your access credentials and other settings
    var s3Client = new AmazonS3Client(_accessKey, _secretKey, bucketRegion);
    string bucketName = _bucketName;
    string documentName = jsonData["documentId"];
    string result = Path.GetFileNameWithoutExtension(documentName);
    byte[] bytes = Convert.FromBase64String(documentBase.Split(',')[1]);
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

N> Replace **Your Access Key from AWS S3**, **Your Secret Key from AWS S3**, and **Your Bucket name from AWS S3** with your actual AWS access key, secret key and bucket name

**Step 4:** Set the PDF Viewer Properties in ASP.NET MVC PDF viewer component

Set the `documentPath` property of the PDF viewer component to the desired name of the PDF file you wish to load from AWS S3. Ensure that you correctly pass the document name from the files available in your azure container to the documentPath property.

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

N> The **AWSSDK.S3** NuGet package must be installed in your application to use the previous code example.

[View sample in GitHub](https://github.com/SyncfusionExamples/open-save-pdf-documents-in-aws-s3)