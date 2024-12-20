---
layout: post
title: Open document from Dropbox cloud file storage in ##Platform_Name## Document editor control | Syncfusion
description: Learn about how to Open document from Dropbox cloud file storage in ##Platform_Name## Document editor control of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Open document from Dropbox cloud file storage
publishingplatform: ##Platform_Name##
documentation: ug
domainurl: ##DomainURL##
---

# Open document from Dropbox cloud file storage

To load a document from Dropbox cloud file storage in a Document editor, you can follow the steps below

**Step 1:** Create a Dropbox API

To create a Dropbox API App, you should follow the official documentation provided by Dropbox [link](https://www.dropbox.com/developers/documentation/dotnet#tutorial). The process involves visiting the Dropbox Developer website and using their App Console to set up your API app. This app will allow you to interact with Dropbox programmatically, enabling secure access to files and data.

{% if page.publishingplatform == "aspnet-core" %}

**Step 2:** Create a Simple Document Editor Sample in ASP.NET Core

Start by following the steps provided in this [link](../EJ2_ASP.NETCORE/getting-started-core) to create a simple Document Editor sample in ASP.NET Core. This will give you a basic setup of the Document Editor component. 

{% elsif page.publishingplatform == "aspnet-mvc" %}

**Step 2:** Create a Simple Document Editor Sample in ASP.NET MVC

Start by following the steps provided in this [link](../EJ2_ASP.MVC/getting-started) to create a simple Document Editor sample in ASP.NET MVC. This will give you a basic setup of the Document Editor component. 

{% endif %}

**Step 3:** Modify the `DocumentEditorController.cs` File in the Web Service Project

* Open the `DocumentEditorController.cs` file in your web service project.

* Import the required namespaces at the top of the file:

```csharp
using System.IO;
using Dropbox.Api;
using Dropbox.Api.Files;
```

* Add the following private fields and constructor parameters to the `DocumentEditorController` class, In the constructor, assign the values from the configuration to the corresponding fields

```csharp
private IConfiguration _configuration;
public readonly string _accessToken;
public readonly string _folderName;

public DocumentEditorController(IWebHostEnvironment hostingEnvironment, IMemoryCache cache, IConfiguration configuration)
{
  _hostingEnvironment = hostingEnvironment;
  _cache = cache;
   _configuration = configuration;
  _accessToken = _configuration.GetValue<string>("AccessToken");
  _folderName = _configuration.GetValue<string>("FolderName");
}
```

* Create the `LoadFromDropBox()` method to load the document from Dropbox cloud file storage.

```csharp

[AcceptVerbs("Post")]
[HttpPost]
[EnableCors("AllowAllOrigins")]
[Route("LoadFromBoxCloud")]
//Post action for Loading the documents

public async Task<string> LoadFromDropBox([FromBody] Dictionary<string, string> jsonObject)
{
    if (jsonObject == null && !jsonObject.ContainsKey("documentName"))
    {
      return null
    }
    MemoryStream stream = new MemoryStream();
        
    using (var dropBox = new DropboxClient(_accessToken))
    {
        using (var response = await dropBox.Files.DownloadAsync(_folderName + "/" + fileName))
        {
          var byteArray = await response.GetContentAsByteArrayAsync();
          stream = new MemoryStream(byteArray);
        }
    }
    WordDocument document = WordDocument.Load(stream, FormatType.Docx);
    string json = Newtonsoft.Json.JsonConvert.SerializeObject(document);
    document.Dispose();
    stream.Close();
    return json;
} 
```

* Open the `appsettings.json` file in your web service project, Add the following lines below the existing `"AllowedHosts"` configuration

```json
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*",
  "AccessToken": "Your_Dropbox_Access_Token",
  "FolderName": "Your_Folder_Name"
}
```

N> Replace **Your_Dropbox_Access_Token** with your actual Dropbox access token and **Your_Folder_Name** with your folder name.

**Step 4:**  Modify the Index.cshtml File in the Document Editor sample

In the client-side, the document is returned from the web service is opening using [`open`](../../api/document-editor/#open) method.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/document-editor-container/open-dropbox-cloud-file-storage/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Document-editor.cs" %}
{% include code-snippet/document-editor-container/open-dropbox-cloud-file-storage/document-editor.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/document-editor-container/open-dropbox-cloud-file-storage/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Document-editor.cs" %}
{% include code-snippet/document-editor-container/open-dropbox-cloud-file-storage/document-editor.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

N> The **Dropbox.Api** NuGet package must be installed in your application to use the previous code example.
