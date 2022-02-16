---
layout: post
title: Chunk Upload in ##Platform_Name## Uploader Component
description: Learn here all about Chunk Upload in Syncfusion ##Platform_Name## Uploader component and more.
platform: ej2-asp-core-mvc
control: Chunk Upload
publishingplatform: ##Platform_Name##
documentation: ug
---


# Chunk Upload

The Uploader sends the large file split into small chunks and transmits to the server using AJAX. You can also pause, resume, and retry the failed chunk file.

> * The chunk upload works in asynchronous upload only.

* This feature is available from the Essential Studio Vol 2, 2018 release.

To enable the chunk upload, set the size to [chunkSize](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.UploaderAsyncSettings.html#Syncfusion_EJ2_Inputs_UploaderAsyncSettings_ChunkSize) option of the upload and it receives the value in `bytes`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/uploader/chunk/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Chunk.cs" %}
{% include code-snippet/uploader/chunk/chunk.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/uploader/chunk/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Chunk.cs" %}
{% include code-snippet/uploader/chunk/chunk.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![uploader](./images/uploader-chunk.png)

The chunk upload functionality separates the selected files into blobs of the data or chunks. These chunks are transmitted to the server using an AJAX request.
The chunks are sent in **sequential** order, and the next chunk can be sent to the server according to the [success](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.Uploader.html#Syncfusion_EJ2_Inputs_Uploader_ChunkSuccess) of the previous chunk. If any one
of the chunk failed, then the remaining chunk cannot be sent to the server.
The [chunkSuccess](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.Uploader.html#Syncfusion_EJ2_Inputs_Uploader_ChunkSuccess) or [chunkFailure](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.Uploader.html#Syncfusion_EJ2_Inputs_Uploader_ChunkFailure) &nbsp;event will
be triggered when the chunk is sent to the server successfully or failed. If all the chunks are sent to the server successfully, the uploader success event is triggered.

> Chunk upload will work when the selected file size is greater than the specified chunk size. otherwise, it upload the files normally.

## Additional configurations

To modify the chunk upload, the following options can be used.

* **RetryAfterDelay** - If error occurs while sending any chunk request from JavaScript, hold the operation for 500 milliseconds (by default), and retry the operation using chunk. This can be achieved by using the [asyncSettings.retryAfterDelay](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.UploaderAsyncSettings.html#Syncfusion_EJ2_Inputs_UploaderAsyncSettings_RetryAfterDelay) property. You can modify the holding time interval in milliseconds.

* **RetryCount** - Specifies the number of retry actions performed when the file fails to upload. By default, retry action is performed 3 times. If the file fails to upload continuously, the request is
aborted and the uploader [failure](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.UploaderBuilder.html#Syncfusion_EJ2_Inputs_UploaderBuilder_Failure_System_String_) event will trigger.

The following sample specifies the chunk upload delay with 3000 milliseconds and the retry count is 5. The failure event is triggered as the wrong saveUrl is used.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/uploader/retry/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Retry.cs" %}
{% include code-snippet/uploader/retry/retry.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/uploader/retry/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Retry.cs" %}
{% include code-snippet/uploader/retry/retry.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Resumable upload

Allows you to resume an upload operation after a network failure or manually interrupts (pause) the upload. You can perform pause and resume upload actions using public methods (pause and resume)
and UI interaction. The pause icon is enabled after the upload begins.

> This pause and resume features available only when the chunk upload is enabled.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/uploader/resumable/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Resumable.cs" %}
{% include code-snippet/uploader/resumable/resumable.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/uploader/resumable/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Resumable.cs" %}
{% include code-snippet/uploader/resumable/resumable.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![uploader](./images/uploader-resume.png)

## Cancel upload

The uploader component allows you to cancel the uploading file. This can be achieved by clicking the cancel icon or using the `cancel` method. The [cancelling](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.Uploader.html#Syncfusion_EJ2_Inputs_Uploader_Canceling) event will be fired whenever the file upload request is canceled. While canceling the upload request, the partially uploaded file is removed from the server.

When the request fails, the pause icon is changed to retry icon. By clicking the retry icon, sends the failed chunk request again to the server and upload started from where it is failed. You can retry the canceled upload request again using retry UI or `retry` methods. But, if you retry this, the file upload action again starts from initial.

The following example explains about chunk upload with cancel support.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/uploader/cancel/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Cancel.cs" %}
{% include code-snippet/uploader/cancel/cancel.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/uploader/cancel/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Cancel.cs" %}
{% include code-snippet/uploader/cancel/cancel.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![uploader](./images/uploader-cancel.png)

> The retry action has different working behavior for chunk upload and default upload.

* Chunk upload - Retries to upload the failed request where it is failed previously.
* Default upload - Retries to upload the failed file again from initial.

## Server-Side configurations

The server-side implementation entirely depends on the application requirements and logic. The following code snippet provides the server-side logic to handle the chunk upload using the uploader components.

```csharp
// Server configuration for upload a file.
public void Save()
{
    try
    {
        if (System.Web.HttpContext.Current.Request.Files.AllKeys.Length > 0)
        {
            var httpPostedChunkFile = System.Web.HttpContext.Current.Request.Files["chunkFile"];
            if (httpPostedChunkFile != null)
            {
                var saveFile = System.Web.HttpContext.Current.Server.MapPath("UploadedFiles");
                var SaveFilePath = Path.Combine(saveFile, httpPostedChunkFile.FileName + ".part");
                var chunkIndex = System.Web.HttpContext.Current.Request.Form["chunk-index"];
                if (chunkIndex == "0")
                {
                    //httpPostedChunkFile.SaveAs(SaveFilePath);
                }
                else
                {
                    //  MergeChunkFile(SaveFilePath, httpPostedChunkFile.InputStream);
                    var totalChunk = System.Web.HttpContext.Current.Request.Form["total-chunk"];
                    if (Convert.ToInt32(chunkIndex) == (Convert.ToInt32(totalChunk) - 1))
                    {
                        var savedFile = System.Web.HttpContext.Current.Server.MapPath("UploadedFiles");
                        var originalFilePath = Path.Combine(savedFile, httpPostedChunkFile.FileName);
                        System.IO.File.Move(SaveFilePath, originalFilePath);
                    }
                }
                HttpResponse ChunkResponse = System.Web.HttpContext.Current.Response;
                ChunkResponse.Clear();
                ChunkResponse.ContentType = "application/json; charset=utf-8";
                ChunkResponse.StatusDescription = "File uploaded succesfully";
                ChunkResponse.End();
            }
            var httpPostedFile = System.Web.HttpContext.Current.Request.Files["UploadFiles"];

            if (httpPostedFile != null)
            {
                var fileSave = System.Web.HttpContext.Current.Server.MapPath("UploadedFiles");
                var fileSavePath = Path.Combine(fileSave, httpPostedFile.FileName);
                if (!System.IO.File.Exists(fileSavePath))
                {
                    //   httpPostedFile.SaveAs(fileSavePath);
                    HttpResponse Response = System.Web.HttpContext.Current.Response;
                    Response.Clear();
                    Response.ContentType = "application/json; charset=utf-8";
                    Response.StatusDescription = "File uploaded succesfully";
                    Response.End();
                }
                else
                {
                HttpResponse Response = System.Web.HttpContext.Current.Response;
                    Response.Clear();
                    Response.Status = "204 File already exists";
                    Response.StatusCode = 204;
                    Response.StatusDescription = "File already exists";
                    Response.End();
                }
            }
        }
    }
    catch (Exception e)
    {
        HttpResponse Response = System.Web.HttpContext.Current.Response;
        Response.Clear();
        Response.ContentType = "application/json; charset=utf-8";
        Response.StatusCode = 204;
        Response.Status = "204 No Content";
        Response.StatusDescription = e.Message;
        Response.End();
    }
}
// Server configuration for remove a uploaded file
public void Remove()
{
    try
    {
    HttpResponse Response = System.Web.HttpContext.Current.Response;
    Response.Clear();
    Response.Status = "200 OK";
    Response.StatusCode = 200;
    Response.ContentType = "application/json; charset=utf-8";
    Response.StatusDescription = "File removed succesfully";
    Response.End();
    }
    catch (Exception e)
    {
        HttpResponse Response = System.Web.HttpContext.Current.Response;
        Response.Clear();
        Response.Status = "200 OK";
        Response.StatusCode = 200;
        Response.ContentType = "application/json; charset=utf-8";
        Response.StatusDescription = "File removed succesfully";
        Response.End();
    }
}
  
// Merge the current chunk file with previous uploaded chunk files
 public void MergeChunkFile(string fullPath, Stream chunkContent)
{
    try
    {
        using (FileStream stream = new FileStream(fullPath, FileMode.Append, FileAccess.Write, FileShare.ReadWrite))
        {
            using (chunkContent)
            {
                chunkContent.CopyTo(stream);
            }
        }
    }
    catch (IOException ex)
    {
        throw ex;
    }
}
```

> You can also explore [ASP.NET MVC File Upload](https://www.syncfusion.com/aspnet-mvc-ui-controls/file-upload) feature tour page for its groundbreaking features. You can also explore our [ASP.NET MVC File Upload example](https://ej2.syncfusion.com/aspnetmvc/Uploader/DefaultFunctionalities#/material) to understand how to browse the files which you want to upload to the server.
