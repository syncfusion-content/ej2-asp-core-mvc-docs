---
layout: post
title: Open document from Google Drive in ##Platform_Name## Document editor control | Syncfusion
description: Learn about how to Open document from Google Drive in ##Platform_Name## Document editor control of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Open document from Google Drive
publishingplatform: ##Platform_Name##
documentation: ug
domainurl: ##DomainURL##
---

# Open document from Google Drive

To load a document from Google Drive in a Document editor, you can follow the steps below

**Step 1:** Set up Google Drive API

You must set up a project in the Google Developers Console and enable the Google Drive API. Obtain the necessary credentials to access the API. For more information, view the official [link](https://developers.google.com/drive/api/guides/enable-sdk).

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
using Google.Apis.Drive.v3;
using Google.Apis.Util.Store;
```

* Add the following private fields and constructor parameters to the `DocumentEditorController` class, In the constructor, assign the values from the configuration to the corresponding fields

```csharp
private IConfiguration _configuration;
public readonly string folderId;
public readonly string applicationName;
public readonly string credentialPath;
private static readonly string[] Scopes = { DriveService.Scope.DriveFile, DriveService.Scope.DriveReadonly};

public DocumentEditorController(IWebHostEnvironment hostingEnvironment, IMemoryCache cache, IConfiguration configuration)
{
  _hostingEnvironment = hostingEnvironment;
  _cache = cache;
  _configuration = configuration;
  folderId = _configuration.GetValue<string>("FolderId");
  credentialPath = _configuration.GetValue<string>("CredentialPath");
  applicationName = _configuration.GetValue<string>("ApplicationName");
}
```

* Create the `LoadFromGoogleDrive()` method to load the document from Google Drive.

```csharp
[AcceptVerbs("Post")]
[HttpPost]
[EnableCors("AllowAllOrigins")]
[Route("LoadFromGoogleDrive")]
//Post action for Loading the documents
public async Task<string> LoadFromGoogleDrive([FromBody] Dictionary<string, string> jsonObject)
{

  MemoryStream stream = new MemoryStream();
  UserCredential credential;
  using (var stream1 = new FileStream(credentialPath, FileMode.Open, FileAccess.Read))
  {
    string credPath = "token.json";
    credential = await GoogleWebAuthorizationBroker.AuthorizeAsync(
      GoogleClientSecrets.Load(stream1).Secrets,
      Scopes,
      "user",
      CancellationToken.None,
      new FileDataStore(credPath, true));
  }

  // Create Google Drive API service.
  var service = new DriveService(new BaseClientService.Initializer()
  {
    HttpClientInitializer = credential,
    ApplicationName = applicationName,
  });
  // List DOCX files in Google Drive
  listRequest.Q = "mimeType='application/vnd.openxmlformats-officedocument.wordprocessingml.document' and '" + folderId + "' in parents and trashed=false";
  listRequest.Fields = "files(id, name)";
  var files = await listRequest.ExecuteAsync();
  string fileIdToDownload = string.Empty;
  foreach (var file in files.Files)
  { 
    string fileId = file.Id;
    string fileName = file.Name;
    if (fileName == objectName)
    {
      // Save the matching fileId
      fileIdToDownload = fileId;
      break;
    }
  }
  string fileIds = fileIdToDownload;
  var request = service.Files.Get(fileIds);
  await request.DownloadAsync(stream);
  stream.Position = 0;   
  
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
  "FolderId": "Your Google Drive Folder ID",
  "CredentialPath": "Your Path to the OAuth 2.0 Client IDs json file",
  "ApplicationName": "Your Application name"
}
```

N> Replace **Your Google Drive Folder ID**, **Your Application name**, and **Your Path to the OAuth 2.0 Client IDs json file** with your actual Google drive folder ID , Your name for your application and the path for the JSON file.

N> The **FolderId** part is the unique identifier for the folder. For example, if your folder URL is: `https://drive.google.com/drive/folders/abc123xyz456`, then the folder ID is `abc123xyz456`.

**Step 4:**  Modify the Index.cshtml File in the Document Editor sample

In the client-side, the document is returned from the web service is opening using [`open`](../../api/document-editor/#open) method.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/document-editor-container/open-google-drive/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Document-editor.cs" %}
{% include code-snippet/document-editor-container/open-google-drive/document-editor.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/document-editor-container/open-google-drive/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Document-editor.cs" %}
{% include code-snippet/document-editor-container/open-google-drive/document-editor.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

N> The **Google.Apis.Drive.v3** NuGet package must be installed in your application to use the previous code example.
