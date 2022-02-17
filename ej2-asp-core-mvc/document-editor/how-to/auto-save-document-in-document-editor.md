---
layout: post
title: Auto Save Document In Document Editor in ##Platform_Name## Document Editor Component
description: Learn here all about Auto Save Document In Document Editor in Syncfusion ##Platform_Name## Document Editor component and more.
platform: ej2-asp-core-mvc
control: Auto Save Document In Document Editor
publishingplatform: ##Platform_Name##
documentation: ug
---


# How to auto save the document of Document Editor component into AWS S3

In this article, we are going to see how to autosave the document in AWS S3. You can automatically save the edited content in regular intervals of time. It helps reduce the risk of data loss by saving an open document automatically at customized intervals.

The following example illustrates how to auto save the document in AWS S3.

* In the client-side, using content change event, we can automatically save the edited content in regular intervals of time. Based on `contentChanged` boolean, the document send as Docx format to server-side using `saveAsBlob` method.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/document-editor/auto-save/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Auto-save.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/document-editor/auto-save/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Auto-save.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}



* Configure the access key and secret key in `web.config` file and register profile in `startup.cs`.

In `web.config`, add key like below format:

```c#
 <appSettings>
    <add key="AWSProfileName" value="sync_development" />
    <add key="AWSAccessKey" value="" />
    <add key="AWSSecretKey" value="" />
  </appSettings>
```

In `startup.cs`, register profile in below format:

```c#
Amazon.Util.ProfileManager.RegisterProfile("sync_development","", "");
```

* In server-side, Receives the stream content from client-side and process it to save the document in aws s3. Add Web API in controller file like below to save the document in aws s3.

```c#
[AcceptVerbs("Post")]
[HttpPost]
[EnableCors("AllowAllOrigins")]
[Route("SaveToS3")]
public string SaveToS3()
{
    IFormFile file = HttpContext.Request.Form.Files[0];
    Stream stream = new MemoryStream();
    file.CopyTo(stream);
    UploadFileStreamToS3(stream, "documenteditor", "", "GettingStarted.docx");
    stream.Close();
    return "Sucess";
}

public bool UploadFileStreamToS3(System.IO.Stream localFilePath, string bucketName, string subDirectoryInBucket, string fileNameInS3)
{
    AWSCredentials credentials = new StoredProfileAWSCredentials("sync_development");
    IAmazonS3 client = new AmazonS3Client(credentials, Amazon.RegionEndpoint.USEast1);
    TransferUtility utility = new TransferUtility(client);
    TransferUtilityUploadRequest request = new TransferUtilityUploadRequest();

    if (subDirectoryInBucket == "" || subDirectoryInBucket == null)
    {
request.BucketName = bucketName; //no subdirectory just bucket name  
    }
    else
    {   // subdirectory and bucket name  
request.BucketName = bucketName + @"/" + subDirectoryInBucket;
    }
    request.Key = fileNameInS3; //file name up in S3  
    request.InputStream = localFilePath;
    utility.Upload(request); //commensing the transfer  

    return true; //indicate that the file was sent  
}
```

Get the complete working sample in this [`link`](https://github.com/SyncfusionExamples/Auto-Save-documents-in-Word-Processor).
