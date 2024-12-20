---
layout: post
title: Open document from Azure Blob Storage in ##Platform_Name## Document editor control | Syncfusion
description:  Learn about how to Open document from Azure Blob Storage in ##Platform_Name## Document editor control of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Open document from Azure Blob Storage
publishingplatform: ##Platform_Name##
documentation: ug
domainurl: ##DomainURL##
---

# Open document from Azure Blob Storage

To load document from Azure Blob Storage in a Document Editor, you can follow the steps below

{% if page.publishingplatform == "aspnet-core" %}

**Step 1:** Create a Simple Document Editor Sample in ASP.NET Core

Start by following the steps provided in this [link](../../document-editor/getting-started-core) to create a simple Document Editor sample in ASP.NET Core. This will give you a basic setup of the Document Editor component. 

{% elsif page.publishingplatform == "aspnet-mvc" %}

**Step 1:** Create a Simple Document Editor Sample in ASP.NET MVC

Start by following the steps provided in this [link](../../document-editor/getting-started) to create a simple Document Editor sample in ASP.NET MVC. This will give you a basic setup of the Document Editor component. 

{% endif %}

**Step 2:** Modify the `DocumentEditorController.cs` File in the Web Service Project

* Open the `DocumentEditorController.cs` file in your web service project.

* Import the required namespaces at the top of the file:

```csharp
using System.IO;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Specialized;
```

* Add the following private fields and constructor parameters to the `DocumentEditorController` class, In the constructor, assign the values from the configuration to the corresponding fields


```csharp
private readonly string _storageConnectionString;
private readonly string _storageContainerName;
private readonly ILogger<DocumentEditorController> _logger;

public DocumentEditorController(IConfiguration configuration, ILogger<DocumentEditorController> logger)
{
  _storageConnectionString = configuration.GetValue<string>("connectionString");
  _storageContainerName = configuration.GetValue<string>("containerName");
  _logger = logger;
}
```

* Modify the `LoadFromAzure()` method to load the document from  Azure Blob Storage

```csharp

[HttpPost("LoadFromAzure")]
[Microsoft.AspNetCore.Cors.EnableCors("MyPolicy")]
[Route("[controller]/LoadFromAzure")]
//Post action for Loading the PDF documents 
  
public IActionResult LoadFromAzure([FromBody] Dictionary<string, string> jsonObject)
{
  MemoryStream stream = new MemoryStream();

  if (jsonObject == null && !jsonObject.ContainsKey("documentName"))
  {
     return null
  }
  BlobServiceClient blobServiceClient = new BlobServiceClient(_storageConnectionString);
  string fileName = jsonObject["documentName"];
  BlobContainerClient containerClient = blobServiceClient.GetBlobContainerClient(_storageContainerName);
  BlockBlobClient blockBlobClient = containerClient.GetBlockBlobClient(fileName);
  blockBlobClient.DownloadTo(stream);
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
  "connectionString": "*Your Connection string from Azure*",
  "containerName": "*Your container name in Azure*"
}
```

N> Replace **Your Connection string from Azure** with the actual connection string for your Azure Blob Storage account and **Your container name in Azure** with the actual container name 

**Step 3:**  Modify the Index.cshtml File in the Document Editor sample

In the client-side, the document is returned from the web service is opening using [`open`](../../api/document-editor/#open) method.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/document-editor-container/open-azure-blob/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Document-editor.cs" %}
{% include code-snippet/document-editor-container/open-azure-blob/document-editor.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/document-editor-container/open-azure-blob/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Document-editor.cs" %}
{% include code-snippet/document-editor-container/open-azure-blob/document-editor.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

N> The **Azure.Storage.Blobs** NuGet package must be installed in your application to use the previous code example.
