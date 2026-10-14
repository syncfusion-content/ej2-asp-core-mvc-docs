---
layout: post
title: File Source in ##Platform_Name## File Upload | Syncfusion
description: Configure file sources for the Syncfusion ##Platform_Name## File Upload: select, drop, paste-from-clipboard, and directory uploads with rename support.
platform: ej2-asp-core-mvc
control: File Source
publishingplatform: ##Platform_Name##
documentation: ug
---


# File Source in ##Platform_Name## File Upload

## Paste to upload

The Uploader control allows you to upload files using the select or drop option from the file explorer. It also supports pasting to upload the image files. You can upload any currently copied images in the clipboard.

N> When you paste the image, it will be saved in the server with the filename as `image.png`. The file name can be renamed in the server end. You can generate a random name for the file name using the `getUniqueID` method.

Refer to the following example.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/uploader/paste-upload/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Paste.cs" %}
{% include code-snippet/uploader/paste-upload/paste.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/uploader/paste-upload/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Paste.cs" %}
{% include code-snippet/uploader/paste-upload/paste.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Server-side configuration for save the paste file

```csharp
[AcceptVerbs("Post")]
public void Save()
{
    var httpPostedFile = HttpContext.Current.Request.Files["UploadFiles"];
    var fileSave = HttpContext.Current.Server.MapPath("UploadedFiles");
    var fileSavePath = Path.Combine(fileSave, httpPostedFile.FileName);
    if (!System.IO.File.Exists(fileSavePath))
    {
        httpPostedFile.SaveAs(fileSavePath);
        // Get the current file name
        var oldName = httpPostedFile.FileName;
        // Get the additional data as name in server end by corresponding key.
        var newName = HttpContext.Current.Request.Form["fileName"];
        // Rename the file
        File.Move(oldName, newName);
        HttpResponse Response = System.Web.HttpContext.Current.Response;
        Response.Clear();
        Response.ContentType = "application/json; charset=utf-8";
        // Sending the file path to client side
        Response.StatusDescription = fileSavePath;
        Response.End();
    }
}
```

## Directory upload

The Uploader control allows you to upload all files in the folders to server using the [directoryUpload](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Inputs.Uploader.html#Syncfusion_EJ2_Inputs_Uploader_DirectoryUpload) property. When this property is enabled, the Uploader control processes the files by iterating through the files and sub-directories in a directory. It allows you to select only folders instead of files to upload.

N> The directory upload is available only in browsers that support **HTML5 directory**. The uploader will process directory upload via drag-and-drop in the Edge browser.

Refer to the following example to upload files to the server.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/uploader/directory/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Directory.cs" %}
{% include code-snippet/uploader/directory/directory.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/uploader/directory/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Directory.cs" %}
{% include code-snippet/uploader/directory/directory.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Server-side configuration for save the files of folders

```csharp
[AcceptVerbs("Post")]
public void Save()
{
    var httpPostedFile = System.Web.HttpContext.Current.Request.Files["UploadFiles"];
    var fileSave = System.Web.HttpContext.Current.Server.MapPath("UploadedFiles");
    // split the folders by using file name
    string[] folders = httpPostedFile.FileName.Split('/');
    string fileSavePath = "";
    if (folders.Length > 1)
    {
        for (var i = 0; i < folders.Length - 1; i++)
        {
            var newFolder = Path.Combine(fileSave, folders[i]);
            // create folder
            Directory.CreateDirectory(newFolder);
            fileSave = newFolder;
        }
        fileSavePath = Path.Combine(fileSave, folders[folders.Length - 1]);
    }
    else
    {
        fileSavePath = Path.Combine(fileSave, httpPostedFile.FileName);
    }
    if (!System.IO.File.Exists(fileSavePath))
    {
        // save file in the corresponding server location
        httpPostedFile.SaveAs(fileSavePath);
        HttpResponse Response = System.Web.HttpContext.Current.Response;
        Response.Clear();
        Response.ContentType = "application/json; charset=utf-8";
        // Sending the file path to client side
        Response.StatusDescription = fileSavePath;
        Response.End();
    }
}
```

## Drag and drop

The Uploader control allows you to drag and drop the files to upload. You can drag the files from file explorer and drop into the drop area. By default, the Uploader control acts as the drop area element. The drop area gets highlighted when you drag the files over drop area.

### Custom drop area

The Uploader control allows you to set an external target element as the drop area using the [dropArea](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Inputs.Uploader.html#Syncfusion_EJ2_Inputs_Uploader_DropArea) property. The element can be represented as an HTML element or it's id.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/uploader/custom-drop/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Index.css" %}
{% include code-snippet/uploader/custom-drop/index.css %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/uploader/custom-drop/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Index.css" %}
{% include code-snippet/uploader/custom-drop/index.css %}
{% endhighlight %}
{% endtabs %}
{% endif %}



The output is shown below.

![uploader](./images/uploader-custom-drop.png)

### Customize drop area

You can customize the appearance of drop area by overriding the default drop area styles. 
The class “” and “” is available to handle this customization.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/uploader/customize-drop/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Customize-drop.cs" %}
{% include code-snippet/uploader/customize-drop/customize-drop.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/uploader/customize-drop/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Customize-drop.cs" %}
{% include code-snippet/uploader/customize-drop/customize-drop.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



The output is shown below.

![uploader](./images/uploader-customize-drop.png)

N> Explore the [ASP.NET Core File Upload](https://www.syncfusion.com/aspnet-core-ui-controls/file-upload) feature tour page to discover its groundbreaking features. You can also check out our [ASP.NET Core File Upload example](https://ej2.syncfusion.com/aspnetcore/uploader/defaultfunctionalities#/fluent2) to see how to browse and select files for upload to the server.

## See also

* [Achieve file upload programmatically](./how-to/achieve-file-upload-programmatically)
* [Validate image/* on drop](./how-to/validate-image-on-drop)
