---
layout: post
title: Async in ##Platform_Name## Uploader Component | Syncfusion
description: Learn here all about Async in Syncfusion ##Platform_Name## Uploader component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Async
publishingplatform: ##Platform_Name##
documentation: ug
---


# Asynchronous upload in Uploader

The uploader control allows you to upload the files asynchronously. 
The upload process requires save and remove action URL to manage the upload process in the server.

    *   The save action is necessary to handle the upload operation.
    *   The remove action is optional, one can handle the removed files from server.

The File can be uploaded automatically or manually. For more information, you can refer to the [Auto Upload](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.Uploader.html#Syncfusion_EJ2_Inputs_Uploader_AutoUpload) section from the documentation.

## Multiple file upload

By Default, the uploader control allows you to select and upload multiple files simultaneously. 
The selected files are organized in a list for every file selection until you clear it by clicking clear button that is shown in footer. You can add the multiple attributes to original input element of file by enabling the multiple file selection.
The following example explains about [multiple](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.Uploader.html#Syncfusion_EJ2_Inputs_Uploader_Multiple) file upload settings.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/uploader/multiple/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Multiple.cs" %}
{% include code-snippet/uploader/multiple/multiple.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/uploader/multiple/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Multiple.cs" %}
{% include code-snippet/uploader/multiple/multiple.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Single file upload

You can select and upload a single file by disabling the [multiple](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.Uploader.html#Syncfusion_EJ2_Inputs_Uploader_Multiple) file selection property. 
The file list item is removed for every selection and it always maintain a single file to upload.
You can remove the multiple attributes form the original input element of file by enabling the single file upload property.

The following example explains about single file upload settings.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/uploader/single/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Single.cs" %}
{% include code-snippet/uploader/single/single.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/uploader/single/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Single.cs" %}
{% include code-snippet/uploader/single/single.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Save action

The save action handler upload the files that needs to be specified in the [saveUrl](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.UploaderAsyncSettings.html#Syncfusion_EJ2_Inputs_UploaderAsyncSettings_SaveUrl) property. 
The save handler receives the submitted files and manages the save process in server. 
After uploading the files to server location, the color of the selected file name changes to green and the remove icon is changed as bin icon.

* When the file is uploaded successfully, the event [success](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.Uploader.html#Syncfusion_EJ2_Inputs_Uploader_Success) triggers to handle the operation after upload.
* When the file is failed to upload, the event [failure](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.Uploader.html#Syncfusion_EJ2_Inputs_Uploader_Failure) triggers with information, which cause this failure.

You can cancel the upload process by setting the upload event argument [eventargs.cancel](https://ej2.syncfusion.com/documentation/api/uploader/uploadingEventArgs/#cancel) to true.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/uploader/save/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Save.cs" %}
{% include code-snippet/uploader/save/save.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/uploader/save/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Save.cs" %}
{% include code-snippet/uploader/save/save.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Server-side configuration for save action

This section explains how to handle the server-side action for saving the file from server.

```csharp
public string uploads = ".\\Uploaded Files"; // replace with your directory path

public async Task<IActionResult> Save(IFormFile UploadFiles)
{
    if (UploadFiles.Length > 0)
    {
        if (!Directory.Exists(uploads)) // Create the directory if not exists
        {
            Directory.CreateDirectory(uploads);
        }

        var filePath = Path.Combine(uploads, UploadFiles.FileName); // Get the file path
        using (var fileStream = new FileStream(filePath, FileMode.Create)) // Create the file
        {
            await UploadFiles.CopyToAsync(fileStream); // Save the file
        }
    }
    return Ok();
}
```

### Server-side configuration for saving and returning responses

The following example demonstrates the server-side action for saving files on the server and returning responses in JSON, String, and File formats.

```c#
[AcceptVerbs("Post")]
public ActionResult Save()
{
    // for JSON Data
    try
     {
        // Process uploaded data
        var responseData = new
        {
            Success = true,
            Message = "Files uploaded successfully",
            // Additional data can be added here
        };

        return Json(responseData);
     }
     catch (Exception e)
     {
         var errorResponse = new
         {
            Success = false,
            Message = "File upload failed: " + e.Message
         };

         return Json(errorResponse);
     }

    // for String Data
    try
    {
        // Process string data
        var data = "success";
        // Return the string data
        return Content(data);
    }
    catch (Exception)
    {
        var data = "failed";
        return Content(data);
    }

    // for File Data
    try
    {
        // Example: Retrieve file path for stream.txt
        var filePath = "/stream.txt"; // Example file path
   
        // Return the file
        return File(filePath, "text/plain");
    }
    catch (Exception e)
    {
        return Content("Failed to retrieve file response: " + e.Message, "text/plain");
    }
}

```

### Client-side configuration for saving and returning responses

The following example demonstrates the client-side action for saving files on the server and returning responses in JSON, String, and File formats.

```c#

@Html.EJS().Uploader("UploadFiles").Success("OnSuccessHandler").AsyncSettings(new Syncfusion.EJ2.Inputs.UploaderAsyncSettings { SaveUrl = "api/Uploader/Save" }).Render()

<script>

    function OnSuccessHandler(args) {
        if (args.e !== null) // Check if the event argument is not null
        { 
            var responseText = args.e.target.responseText;
            if (responseText.trim() !== "") {

                // for JSON and File Datas
                var jsonResponse = JSON.parse(responseText);
                if (jsonResponse !== null && jsonResponse.hasOwnProperty("success"))
                {
                    var isSuccess = jsonResponse["success"];
                    if (isSuccess) {
                        // File upload success
                        var message = jsonResponse.hasOwnProperty("message") ? jsonResponse["message"] : "File uploaded successfully";
                        // Additional processing as needed
                    }
                }

                // for string Data
                var message = responseText;
                // Additional processing as needed
            }
        }
    }
</script>

```

## Remove action

The remove action is optional. Specify the URL to handle remove process from server. 
The remove handler receives the posted files and handle the remove operation in server.

* When the files are removed successfully from the server, the [success](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.Uploader.html#Syncfusion_EJ2_Inputs_Uploader_Success) event triggers to denote the process has completed.
* When remove action fails, the event [failure](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.Uploader.html#Syncfusion_EJ2_Inputs_Uploader_Failure) triggers with information, which cause failure in remove process.

N> You can differentiate the file operation whether the success event triggers from save or remove action in its arguments [eventArgs.operation](https://ej2.syncfusion.com/documentation/api/uploader/successEventArgs/#operation).

You can remove the files which is not uploaded locally by clicking the remove icon. In this case, the success or failure events will not be triggered.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/uploader/remove/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Remove.cs" %}
{% include code-snippet/uploader/remove/remove.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/uploader/remove/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Remove.cs" %}
{% include code-snippet/uploader/remove/remove.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Server-side configuration for remove action

To remove an uploaded file from the server, it is sufficient to send only the file name. You can achieve this by setting the `postRawFile` property of the `RemovingEventArgs` to `false` during the [`removing`](https://help.syncfusion.com/cr/aspnetmvc-js2/syncfusion.ej2.inputs.uploader.html#Syncfusion_EJ2_Inputs_Uploader_Removing) event. This ensures that only the file name is sent to the server in the Remove action.

Here is an example:

```csharp
@Html.EJS().Uploader("UploadFiles").AutoUpload(false).Removing("onFileRemove").AsyncSettings(new Syncfusion.EJ2.Inputs.UploaderAsyncSettings { SaveUrl = "https://services.syncfusion.com/aspnet/production/api/FileUploader/Save", RemoveUrl = "https://services.syncfusion.com/aspnet/production/api/FileUploader/Remove" }).Render()
```

```typescript
function onFileRemove(args) {
    args.postRawFile = false;
}
```

Here’s how to handle the server-side action for removing the file from server.

```csharp
public void Remove(string UploadFiles)
{
    if (UploadFiles != null)
    {
        var filePath = Path.Combine(uploads, UploadFiles);
        if (System.IO.File.Exists(filePath))
        {
            System.IO.File.Delete(filePath); // Delete the file
        }
    }
}
```
When `postRawFile` is enabled, the complete file data will be sent to the server-side `Remove` action. The `postRawFile` option is enabled by default.

Here is an example:

```csharp
@Html.EJS().Uploader("UploadFiles").AutoUpload(false).Removing("onFileRemove").AsyncSettings(new Syncfusion.EJ2.Inputs.UploaderAsyncSettings { SaveUrl = "https://services.syncfusion.com/aspnet/production/api/FileUploader/Save", RemoveUrl = "https://services.syncfusion.com/aspnet/production/api/FileUploader/Remove" }).Render()
```

```typescript
function onFileRemove(args) {
    // The `postRawFile` option is enabled by default.
}
```

Here’s how to receive the file data in the server-side `Remove` action:

```csharp
public void Remove(IFormFile UploadFiles)
{
    // Your file removal logic goes here!
}
```

## Auto upload

By default, the uploader processes the files to upload once the files are selected and added in upload queue. To upload manually, disable the [autoUpload](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.Uploader.html#Syncfusion_EJ2_Inputs_Uploader_AutoUpload) property. When you disable this property, you can use the action buttons to call upload all or clear all actions manually. You can change those buttons text using the [buttons](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.Uploader.html#Syncfusion_EJ2_Inputs_Uploader_Buttons) &nbsp;property in Uploader control.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/uploader/auto-upload/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Auto-upload.cs" %}
{% include code-snippet/uploader/auto-upload/auto-upload.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/uploader/auto-upload/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Auto-upload.cs" %}
{% include code-snippet/uploader/auto-upload/auto-upload.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Auto upload output be like the below.

![uploader](./images/uploader-auto-01.png)

Auto upload false output be like the below.

![uploader](./images/uploader-auto-02.png)

## Sequential upload

By default, the uploader control process multiple files to upload simultaneously. When you enable the [sequentialUpload](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.Uploader.html#Syncfusion_EJ2_Inputs_Uploader_SequentialUpload) property, the selected files will process sequentially (one after the other) to the server. If the file uploaded successfully or failed, the next file will upload automatically in this sequential upload. This feature helps to reduce the upload traffic and reduce the failure of file upload.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/uploader/sequential-upload/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Sequential-upload.cs" %}
{% include code-snippet/uploader/sequential-upload/sequential-upload.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/uploader/sequential-upload/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Sequential-upload.cs" %}
{% include code-snippet/uploader/sequential-upload/sequential-upload.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Preloaded files

The uploader control allows you to preloaded the list of files that are uploaded in the server. The preloaded files are useful to view and remove the files from server that can be achieved by the [files](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.Uploader.html#Syncfusion_EJ2_Inputs_Uploader_Files) property. By default, the files are configured with uploaded successfully state on rendering file list. The following properties are mandatory to configure the preloaded files:

    *   Name
    *   Size
    *   Type

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight c# tabtitle="Preload-file.cs" %}
{% include code-snippet/uploader/file-preload/preload-file.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/uploader/file-preload/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Preload-file.cs" %}
{% include code-snippet/uploader/file-preload/preload-file.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![uploader](./images/uploader-preload.png)

## Adding additional HTTP headers with upload action

The Uploader control allows you to add the additional headers with `save` and `remove` action requests using the [uploading](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.Uploader.html#Syncfusion_EJ2_Inputs_Uploader_Uploading) and [removing](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.Uploader.html#Syncfusion_EJ2_Inputs_Uploader_Removing) events, which helps to send validation token on file upload. Access the current request and set the request header within these events.

The following code block shows how to add the additional headers with save and remove action request.

```html
   @Html.EJS().Uploader("UploadFiles").DropArea(".control-fluid").Uploading("addHeaders").Removing("addHeaders").AsyncSettings(new Syncfusion.EJ2.Inputs.UploaderAsyncSettings { SaveUrl = "https://services.syncfusion.com/aspnet/production/api/FileUploader/Save", RemoveUrl = "https://services.syncfusion.com/aspnet/production/api/FileUploader/Remove" }).Render()

```

```javascript
    function addHeaders(args) {
        args.currentRequest.setRequestHeader('custom-header', 'Syncfusion');
    }

```

N> You can also explore [ASP.NET MVC File Upload](https://www.syncfusion.com/aspnet-mvc-ui-controls/file-upload) feature tour page for its groundbreaking features. You can also explore our [ASP.NET MVC File Upload example](https://ej2.syncfusion.com/aspnetmvc/Uploader/DefaultFunctionalities#/material) to understand how to browse the files which you want to upload to the server.

## See Also

* [How to add additional data on upload](./how-to/add-additional-data-on-upload)
* [How to add confirm dialog to remove the files](./how-to/add-confirm-dialog-to-remove-the-files)
* [Check the MIME type of file before uploading it](./how-to/check-the-mime-type-of-file-before-upload-it)
* [How to open and edit the uploaded files](./how-to/open-and-edit-the-uploaded-files)
