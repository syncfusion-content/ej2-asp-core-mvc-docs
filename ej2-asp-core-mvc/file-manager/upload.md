---
layout: post
title: Upload in ##Platform_Name## File Manager Component
description: Learn here all about Upload in Syncfusion ##Platform_Name## File Manager component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Upload
publishingplatform: ##Platform_Name##
documentation: ug
---

# Upload in File Manager component

The File Manager component provides a [uploadSettings](https://ej2.syncfusion.com/javascript/documentation/api/file-manager/#uploadsettings) property with various options to customize how files are uploaded, including controlling file size, restricting file types, checking for excessively large and empty files, and enabling chunk uploads.

## Directory Upload

The [directoryUpload](https://ej2.syncfusion.com/javascript/documentation/api/file-manager/uploadSettingsModel/#directoryupload) property controls whether users can browse and upload entire directories (folders) in the Syncfusion File Manager component. 

To enable directory upload, set the `directoryUpload` property to `true` in the `uploadSettings` configuration.

When set to `true`, this property enables directory upload in the File Manager, allowing users to upload entire folders. If set to `false`, only individual files can be uploaded. 

>Note: When `directoryUpload` is set to `true`, only folders can be uploaded. When it is set to `false`, only individual files can be uploaded. Simultaneous uploading of files and folders is not supported.

To learn more about the folder upload actions, refer to this [link](https://ej2.syncfusion.com/aspnetcore/documentation/file-manager/file-operations#folder-upload-support)

## Chunk Upload

The [chunkSize](https://ej2.syncfusion.com/documentation/api/file-manager/uploadSettingsModel/#chunksize) property specifies the size of each chunk when uploading large files. It divides the file into smaller parts, which are uploaded sequentially to the server.

This property allows you to enable chunked uploads for large files by specifying a `chunkSize`.

By specifying a `chunkSize`, the large file is divided into smaller parts, reducing the load on the network and making the upload process more efficient.

With chunk upload, the pause and resume options gives users enhanced control over the file upload process.

![File Manager with chunkUpload](./images/filemanager-chunkupload.png "File Manager chunkUpload")

>Note: 
>1. Chunk upload will work when the selected file size is greater than the specified chunk size. Otherwise, it upload the files normally. 
>2. The pause and resume features are available only when the chunk upload is enabled.
>3. To handle chunk upload in server side, an additional argument of `size` with `long` type must be passed to the Upload method in the controller. Refer to the [Physical File Provider](https://github.com/SyncfusionExamples/ej2-aspcore-file-provider/blob/master/Controllers/FileManagerController.cs#L75) example on how this can be implemented.

## Auto Upload

The [autoUpload](https://ej2.syncfusion.com/documentation/api/file-manager/uploadSettingsModel/#autoupload) property controls whether files are automatically uploaded when they are added to the upload queue in the File Manager component.

The default value is `true`, the File Manager will automatically upload files as soon as they are added to the upload queue. If set to `false`, the files will not be uploaded automatically, giving you the chance to manipulate the files before uploading them to the server.

## Auto Close

The [autoClose](https://ej2.syncfusion.com/documentation/api/file-manager/uploadSettingsModel/#autoclose) property controls whether the upload dialog automatically closes after all the files have been uploaded.

The default value is set to `false`, the upload dialog remains open even after the upload process is complete. If `autoClose` set to `true`, the upload dialog will automatically close after all the files in the upload queue are uploaded.

## Prevent upload based on file extensions

The [allowedExtensions](https://ej2.syncfusion.com/documentation/api/file-manager/uploadSettingsModel/#allowedextensions) property specifies which file types are allowed for upload in the File Manager component by defining their extensions.

This property lets you define which file types can be uploaded by specifying allowed extensions, separated by commas. For example, to allow only image files, you would set the `allowedExtensions` property to .jpg,.png.

By setting the `allowedExtensions` property, you restrict the file types that can be uploaded. Only files with the specified extensions will be accepted.

## Restrict drag and drop upload

The File Manager component provides support for external drag-and-drop functionality for uploading files by dragging it from local file system to File Manager.

Setting [allowDragAndDrop](https://ej2.syncfusion.com/angular/documentation/api/file-manager#allowdraganddrop) property to false will not prevent the file upload operation through external drag and drop. It will only prevent drag and drop action within the File Manager component

To completely prevent the external drag-and-drop upload functionality (i.e., disallowing users from dragging and dropping files from outside into the File Manager), you can set the [dropArea](https://ej2.syncfusion.com/documentation/api/uploader#droparea) property to null. This can be done by accessing the File Manager instance via its class methods.

The following example demonstrates the uploadSettings customizations.


{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/file-manager/upload-feature-cs1/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController_mvc.cs" %}
{% include code-snippet/file-manager/upload-feature-cs1/HomeController_mvc.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/file-manager/upload-feature-cs1/razor %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController_mvc.cs" %}
{% include code-snippet/file-manager/upload-feature-cs1/HomeController_mvc.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}
