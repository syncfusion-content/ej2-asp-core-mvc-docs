---
layout: post
title: File Source in ##Platform_Name## Uploader Control | Syncfusion
description: Learn here all about File Source in Syncfusion ##Platform_Name## Uploader component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: File Source
publishingplatform: ##Platform_Name##
documentation: ug
---


# File source in Uploader Control

## Paste to upload

The uploader component allows you to upload the files using the select or drop files option from the file explorer. It also supports pasting to upload the image files. You can upload any currently copied images in the clipboard.

> When you paste the image, it will be saved in the server with the filename as `image.png`. The file name can be renamed in the server end. You can generate a random name for the file name using `getUniqueID` method.

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

private IHostingEnvironment hostingEnv;
public DefaultController(IHostingEnvironment env)
    {
        this.hostingEnv = env;
    }
public void Save(IList<IFormFile> UploadFiles)
    {
    try
        {
        foreach (var file in UploadFiles)
            {
                var filename = ContentDispositionHeaderValue
                                    .Parse(file.ContentDisposition)
                                    .FileName
                                    .Trim('"');
                filename =  hostingEnv.WebRootPath + $@"\{filename}";
                long size = 0;
                size += file.Length;
                if (!System.IO.File.Exists(filename))
                {
                using (FileStream fs = System.IO.File.Create(filename))
                    {
                        file.CopyTo(fs);
                        fs.Flush();
                    }
                }
            }
        }
        catch (Exception e)
        {
            Response.Clear();
            Response.StatusCode = 204;
            Response.HttpContext.Features.Get<IHttpResponseFeature>().ReasonPhrase = "File failed to upload";
            Response.HttpContext.Features.Get<IHttpResponseFeature>().ReasonPhrase = e.Message;
        }
    }
```

## Directory upload

The uploader component allows you to upload all files in the folders to server by using the [directoryUpload](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.Uploader.html#Syncfusion_EJ2_Inputs_Uploader_DirectoryUpload) property.

When this property is enabled, the uploader component processes the files by iterating through the files and sub-directories in a directory. It allows you to select only folders instead of files to upload.

> The directory upload is available only in browsers that supports **HTML5 directory**. The uploader will process directory upload by dragging and dropping in the Edge browser.

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

private IHostingEnvironment hostingEnv;
public DefaultController(IHostingEnvironment env)
    {
        this.hostingEnv = env;
    }
    public void Save(IList<IFormFile> chunkFile, IList<IFormFile> UploadFiles)
    {
        long size = 0;
        try
        {
            foreach (var file in UploadFiles)
            {
                var filename = ContentDispositionHeaderValue
                    .Parse(file.ContentDisposition)
                    .FileName
                    .Trim('"');
                var folders = filename.Split('/');
                var uploaderFilePath = hostingEnv.WebRootPath;
                    // for Directory upload
                if (folders.Length > 1)
                {
                    for (var i = 0; i < folders.Length - 1; i++)
                    {
                        var newFolder = uploaderFilePath + $@"\{folders[i]}";
                        Directory.CreateDirectory(newFolder);
                        uploaderFilePath = newFolder;
                        filename = folders[i + 1];
                    }
                }
                filename = uploaderFilePath + $@"\{filename}";
                size += file.Length;
                if (!System.IO.File.Exists(filename))
                {
                    using (FileStream fs = System.IO.File.Create(filename))
                    {
                        file.CopyTo(fs);
                        fs.Flush();
                    }

                }
            }
        }
        catch (Exception e)
        {
            Response.Clear();
            Response.StatusCode = 204;
            Response.HttpContext.Features.Get<IHttpResponseFeature>().ReasonPhrase = "File failed to upload";
            Response.HttpContext.Features.Get<IHttpResponseFeature>().ReasonPhrase = e.Message;
        }
    }
```

## Drag and drop

The uploader component allows you to drag and drop the files to upload. You can drag the files from file explorer and drop into the drop area.

By default, the uploader component act as drop area element. The drop area gets highlighted when you drag the files over drop area.

### Custom drop area

The uploader component allows you to set external target element as drop area using the [dropArea](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.Uploader.html#Syncfusion_EJ2_Inputs_Uploader_DropArea) property. The element can be represented as HTML element or element’s id.

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



Output be like the below.

![uploader](./images/uploader-custom-drop.png)

### Customize drop area

You can customize the appearance of drop area by overriding the default drop area styles. The class “” and “” is available to handle this customization.

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



Output be like the below.

![uploader](./images/uploader-customize-drop.png)

> You can also explore [ASP.NET Core File Upload](https://www.syncfusion.com/aspnet-core-ui-controls/file-upload) feature tour page for its groundbreaking features. You can also explore our [ASP.NET Core File Upload example](https://ej2.syncfusion.com/aspnetcore/Uploader/DefaultFunctionalities#/material) to understand how to browse the files which you want to upload to the server.

## See Also

* [Achieve file upload programmatically](./how-to/achieve-file-upload-programmatically)
* [Validate image/* on drop](./how-to/validate-image-on-drop)
