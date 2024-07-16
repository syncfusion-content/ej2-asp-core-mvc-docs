---
layout: post
title: AWS S3 in ##Platform_Name## Syncfusion PDF Viewer Component
description: Learn here all about how to Open PDF files from AWS S3 in ASP.NET MVC PDF Viewer component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: PDF Viewer
publishingplatform: ##Platform_Name##
documentation: ug
---

# Open PDF file from AWS S3

PDF Viewer allows to load PDF file from AWS S3 using either the Standalone or Server-backed PDF Viewer. Below are the steps and a sample to demonstrate how to open a PDF from AWS S3.

## Using Standalone PDF Viewer

To load a PDF file from AWS S3 in a PDF Viewer, you can follow the steps below

**Step 1:** Create AWS S3 account 

Set up an AWS S3 account by following the instructions on the official AWS site: [AWS Management Console](https://docs.aws.amazon.com/AmazonS3/latest/userguide/Welcome.html). Create an S3 bucket and generate access keys while ensuring secure storage of credentials.

**Step 2:** Create PDF Viewer Sample in ASP.NET MVC

Follow instructions provided in the Syncfusion PDF Viewer Getting Started [Guide](https://ej2.syncfusion.com/aspnetmvc/documentation/pdfviewer/getting-started) to create a simple PDF Viewer sample in ASP.NET MVC.

**Step 3:** Modify the `~/Views/Shared/_Layout.cshtml` File in the Project 

1. Add the required scripts using CDN inside the `<head>` of `~/Views/Shared/_Layout.cshtml` file as follows,

{% tabs %}
{% highlight c# tabtitle="~/_Layout.cshtml" %}

<head>
    ...
    <script src="https://sdk.amazonaws.com/js/aws-sdk-2.1654.0.min.js"></script>
</head>

{% endhighlight %}
{% endtabs %}

**Step 4:** Modify the `~/Views/Home/Index.cshtml` File in the Project 

1. Configures AWS SDK with the region, access key, and secret access key. This configuration allows the application to interact with AWS services like S3.

N> Replace **Your Region** with the actual Region of your AWS S3 account and **Your Access Key** with the actual Access Key of your AWS S3 account and **Your Security Access Key** with the actual Security Access Key of your AWS S3 account.

```csharp
AWS.config.update({
  region: '**Your Region**', // Update this your region
  accessKeyId: '*Your Access Key*', // Update this with your access key id
  secretAccessKey: '*Your Security Access Key*', // Update this with your secret access key
});
```

2. Sets the parameters for fetching the PDF document from S3, including the bucket name and file key. Then Uses the getObject method of the S3 instance to retrieve the document. Converts the document data to a Base64 string and loads it into the Syncfusion PDF Viewer then load Base64 string generated into the viewer.load method.

N> Replace **Your Bucket Name** with the actual Bucket name of your AWS S3 account and **Your Key** with the actual File Key of your AWS S3 account.

```csharp
loadDocument() {
    const s3 = new AWS.S3();
    const getObjectParams = {
        Bucket: '**Your Bucket Name**',
        Key: '**Your Key**',
    };
    this.s3.getObject(getObjectParams, (err, data) => {
        if (err) {
        console.error('Error fetching document:', err);
        } else {
        if (data && data.Body) {
            const bytes = new Uint8Array(data.Body as ArrayBuffer);
            let binary = '';
            bytes.forEach((byte) => (binary += String.fromCharCode(byte)));
            const base64String = window.btoa(binary);
            console.log('Document data as Base64:', base64String);
            var viewer = (<any>document.getElementById("pdfViewer")).ej2_instances[0];  
            setTimeout(() => {
            viewer.load("data:application/pdf;base64,"+base64String);
            }, 2000);
        }
        }
    });
}
```

N> The **AWSSDK.S3** NuGet package must be installed in your application to use the previous code example.

[View sample in GitHub](https://github.com/SyncfusionExamples/open-save-pdf-documents-in-aws-s3/tree/master/Open%20and%20Save%20PDF%20in%20AWS%20S3%20using%20Standalone).

## Using Server-Backed PDF Viewer

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

[View sample in GitHub](https://github.com/SyncfusionExamples/open-save-pdf-documents-in-aws-s3/tree/master/Open%20and%20Save%20PDF%20in%20AWS%20S3%20using%20Server-Backend)