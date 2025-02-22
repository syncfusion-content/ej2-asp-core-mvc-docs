---
layout: post
title: AWS S3 in ##Platform_Name## PDF Viewer Component| Syncfusion
description: Learn here all about how to Open PDF files from AWS S3 in ASP.NET MVC PDF Viewer component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: PDF Viewer
publishingplatform: ##Platform_Name##
documentation: ug
---

# Open PDF file from AWS S3

To load a PDF file from AWS S3 in a PDF Viewer, you can follow the steps below

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
using Amazon.S3.Model;
```

2. Modify the `Load()` method to load the PDF files from AWS S3.

```csharp
    private readonly string _accessKey = "Your Access Key from AWS S35";
    private readonly string _secretKey = "Your Secret Key from AWS S3";
    private readonly string _bucketName = "Your Bucket name from AWS S3";

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
                RegionEndpoint bucketRegion = RegionEndpoint.USEast1;

                // Configure the AWS SDK with your access credentials and other settings
                var s3Client = new AmazonS3Client(_accessKey, _secretKey, bucketRegion);

                string document = jsonData["document"];

                // Specify the document name or retrieve it from a different source
                var response = await s3Client.GetObjectAsync(_bucketName, document);

                Stream responseStream = response.ResponseStream;
                responseStream.CopyTo(stream);
                stream.Seek(0, SeekOrigin.Begin);
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