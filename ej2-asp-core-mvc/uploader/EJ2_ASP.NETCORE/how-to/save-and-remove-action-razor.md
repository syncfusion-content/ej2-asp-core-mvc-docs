---
layout: post
title: Wire Save and Remove Actions in Razor Page - ##Platform_Name## | Syncfusion
description: Wire save and remove action handlers in an ASP.NET Core Razor Page for the Syncfusion File Upload via the saveUrl and removeUrl in async settings.
platform: ej2-asp-core-mvc
control: Save And Remove Action Razor
publishingplatform: ##Platform_Name##
documentation: ug
---


# How to wire save and remove actions in ASP.NET Core Razor Page

The save action handler uploads the files that needs to be specified in the [`saveUrl`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.UploaderAsyncSettings.html#Syncfusion_EJ2_Inputs_UploaderAsyncSettings_SaveUrl) property. The save handler receives the submitted files and manages the save process on the server.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/uploader/razor-save/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Razor-save.cs" %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/uploader/razor-save/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Razor-save.cs" %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Server-side configuration for startup page

This section explains how to add the anti-forgery token header in the `Startup` page.

```csharp

public void ConfigureServices(IServiceCollection services)  
{  
    services.AddMvc().AddJsonOptions(x =>  
    {  
        x.SerializerSettings.ContractResolver = new DefaultContractResolver();  
    });  
    services.AddAntiforgery(o => o.HeaderName = "xsrf-token");  
}

```

* `AddAntiforgery` configures the anti-forgery token service with a custom header name (xsrf-token).
* The `DefaultContractResolver` ensures JSON property names are serialized in PascalCase.
* The client-side upload request must include this header to be validated by the server.

## Server-side configuration for save action

This section explains how to handle the server-side action for saving the uploaded file on the server.

```csharp
private IHostingEnvironment hostingEnv;

public UploaderController(IHostingEnvironment env)
{
    this.hostingEnv = env;
}

 [AcceptVerbs("Post")]  
public IActionResult OnPostSave(IList<IFormFile> UploadFiles)  
{  
    try  
    {  
        foreach (var file in UploadFiles)  
        {  
            if (UploadFiles != null)  
            {  
                var filename = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');  
                filename = hostingEnv.WebRootPath + $@"\{filename}";  
                if (!System.IO.File.Exists(filename))  
                {  
                    using (FileStream fs = System.IO.File.Create(filename))  
                    {  
                        file.CopyTo(fs);  
                        fs.Flush();  
                    }  
                }  
                else  
                {  
                    Response.Clear();  
                    Response.StatusCode = 204;  
                    Response.HttpContext.Features.Get<IHttpResponseFeature>().ReasonPhrase = "File already exists.";  
                }  
            }  
        }  
    }  
    catch (Exception e)  
    {  
        Response.Clear();  
        Response.ContentType = "application/json; charset=utf-8";  
        Response.StatusCode = 204;  
        Response.HttpContext.Features.Get<IHttpResponseFeature>().ReasonPhrase = "No Content";  
        Response.HttpContext.Features.Get<IHttpResponseFeature>().ReasonPhrase = e.Message;  
    }  
    return Content("");  
}

```

* The `OnPostSave` action receives the uploaded files through the UploadFiles parameter.
* Files are saved to the `WebRootPath` directory using the `IHostingEnvironment` service.
* If a file already exists, the server responds with a **204 status** and the reason phrase "File already exists."
* If an error occurs during the upload process, the server responds with a **204 status** and the exception message.

## Server-side configuration for remove action

This section explains how to handle the server-side action for removing the file from the server.

```csharp

private IHostingEnvironment hostingEnv;

public HomeController(IHostingEnvironment env)
{
    this.hostingEnv = env;
}
[AcceptVerbs("Post")]  
public IActionResult OnPostRemove(IList<IFormFile> UploadFiles)  
{  
    try  
    {  
        foreach (var file in UploadFiles)  
        {  
            var fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');  
            var filePath = Path.Combine(hostingEnv.WebRootPath);  
            var fileSavePath = filePath + "\\" + fileName;  
            if (!System.IO.File.Exists(fileSavePath))  
            {  
                System.IO.File.Delete(fileSavePath);  
            }  
        }  
    }  
    catch (Exception e)  
    {  
        Response.Clear();  
        Response.StatusCode = 200;  
        Response.HttpContext.Features.Get<IHttpResponseFeature>().ReasonPhrase = "File removed successfully";  
        Response.HttpContext.Features.Get<IHttpResponseFeature>().ReasonPhrase = e.Message;  
    }  
    return Content("");  
}  

```

* The `OnPostRemove` action receives the file details through the UploadFiles parameter.
* The file is deleted from the `WebRootPath` directory if it exists.
* If an error occurs during removal, the server responds with a **200 status** and the exception message.

N> Explore the [ASP.NET Core File Upload](https://www.syncfusion.com/aspnet-core-ui-controls/file-upload) feature tour page to discover its groundbreaking features. You can also check out our [ASP.NET Core File Upload example](https://ej2.syncfusion.com/aspnetcore/uploader/defaultfunctionalities#/fluent2) to see how to browse and select files for upload to the server.