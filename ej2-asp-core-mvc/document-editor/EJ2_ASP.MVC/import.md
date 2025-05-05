---
layout: post
title: Import in ##Platform_Name## Document Editor Component | Syncfusion
description: Learn here all about Import in Syncfusion ##Platform_Name## Document Editor component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Import
publishingplatform: ##Platform_Name##
documentation: ug
---


# Importing in the ##Platform_Name## Document Editor Component

In Document Editor, the documents are stored in its own format called **Syncfusion Document Text (SFDT)**.

The following example shows how to open SFDT data in Document Editor.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/document-editor/import/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Document-editor.cs" %}
{% include code-snippet/document-editor/import/document-editor.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/document-editor/import/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Document-editor.cs" %}
{% include code-snippet/document-editor/import/document-editor.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Import document from local machine

The following example shows how to import document from local machine.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/document-editor/import-sfdt/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Document-editor.cs" %}
{% include code-snippet/document-editor/import-sfdt/document-editor.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/document-editor/import-sfdt/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Document-editor.cs" %}
{% include code-snippet/document-editor/import-sfdt/document-editor.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Opening document from URL

This article explains how to open a document from URL in DocumentEditor.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/document-editor-container/open-by-url/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Open-by-url.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/document-editor-container/open-by-url/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Open-by-url.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}



```typescript
import * as ReactDOM from 'react-dom';
import * as React from 'react';
import {
  DocumentEditorContainerComponent,Toolbar } from '@syncfusion/ej2-react-documenteditor';

DocumentEditorContainerComponent.Inject(Toolbar);
export class App extends React.Component<{}, {}> {
  container: DocumentEditorContainerComponent;
  public contentChanged:boolean=false;
  onClick():void {
    let http: XMLHttpRequest = new XMLHttpRequest();
    //add your url in which you want to open document inside the ""
    let content = { fileUrl: "" };
    let baseurl: string = "/api/documenteditor/ImportFileURL";
    http.open("POST", baseurl, true);
    http.setRequestHeader("Content-Type", "application/json;charset=UTF-8");
    http.onreadystatechange = () => {
        if (http.readyState === 4) {
            if (http.status === 200 || http.status === 304) {
                //open the SFDT text in Document Editor
                container.documentEditor.open(http.responseText);
            }
        }
    };
    http.send(JSON.stringify(content));
  }
  render() {
    return (
      <div>
      <button id='import' onClick={this.onClick.bind(this)}>Import</button>
      <DocumentEditorContainerComponent id="container" ref={(scope) => { this.container = scope; }}
        height={'590px'}
        serviceUrl="https://ej2services.syncfusion.com/production/web-services/api/documenteditor/"
        enableToolbar={true}
      />
      </div>
    );
  }
}
ReactDOM.render(<App />, document.getElementById('root'));

```

## Opening a Base64 Document

This article explains how to open a base64 document in DocumentEditor.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/document-editor-container/open-by-base64/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Open-by-base64.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/document-editor-container/open-by-base64/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Open-by-base64.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}


```typescript
import * as ReactDOM from 'react-dom';
import * as React from 'react';
import {
  DocumentEditorContainerComponent,Toolbar } from '@syncfusion/ej2-react-documenteditor';

DocumentEditorContainerComponent.Inject(Toolbar);
export class App extends React.Component<{}, {}> {
  container: DocumentEditorContainerComponent;
  public contentChanged:boolean=false;
  onClick():void {
    let base64Document: string = '<base64>';
    // Decode the Base64 string
    let binaryString: string = atob(base64Document);
    // Convert the binary string to an array buffer
    let byteArray: Uint8Array = new Uint8Array(binaryString.length);
    for (let i = 0; i < binaryString.length; i++) {
        byteArray[i] = binaryString.charCodeAt(i);
    }
    // Create a Blob from the array buffer
    let blob: Blob = new Blob([byteArray], { type: 'application/octet-stream' });
    // Create form data with the blob
    let formData: FormData = new FormData();
    formData.append('file', blob, 'GiantPanda.docx');
    let apiUrl: string = 'https://services.syncfusion.com/react/production/api/documentedtor/import';
    // Now, send formData to your WebAPI for converting Word Document(.docx) to Syncfusion Document Text(.sfdt)
    let xhrUpload: XMLHttpRequest = new XMLHttpRequest();
    xhrUpload.open('POST', apiUrl, true);
    xhrUpload.onload = function () {
        if (xhrUpload.status === 200) {
            // Open the sfdt response from the web api in client-side open api.
            container.current.documentEditor.open(xhrUpload.responseText);
        } else {
            console.error('Error uploading file: ', xhrUpload.statusText);
        }
    };
    xhrUpload.onerror = function () {
        console.error('Network error occurred while trying to upload file.');
    };
    xhrUpload.send(formData);
  }
  render() {
    return (
      <div>
      <button id='import' onClick={this.onClick.bind(this)}>Import</button>
      <DocumentEditorContainerComponent id="container" ref={(scope) => { this.container = scope; }}
        height={'590px'}
        serviceUrl="https://ej2services.syncfusion.com/production/web-services/api/documenteditor/"
        enableToolbar={true}
      />
      </div>
    );
  }
}
ReactDOM.render(<App />, document.getElementById('root'));

```

```csharp
[AcceptVerbs("Post")]
public string ImportFileURL([FromBody]FileUrlInfo param)
{
    try {
        using(WebClient client = new WebClient())
        {
            MemoryStream stream = new MemoryStream(client.DownloadData(param.fileUrl));
            WordDocument document = WordDocument.Load(stream, FormatType.Docx);
            string json = Newtonsoft.Json.JsonConvert.SerializeObject(document);
            document.Dispose();
            stream.Dispose();
            return json;
        }
    }
    catch (Exception) {
        return "";
    }
}
public class FileUrlInfo {
    public string fileUrl { get; set; }
    public string Content { get; set; }
}
```

## Convert word documents into SFDT

You can convert word documents into SFDT format using the [`Syncfusion.EJ2.WordEditor.AspNet.MVC5`](<https://www.nuget.org/packages/Syncfusion.EJ2.WordEditor.AspNet.MVC5/>) by the web API service implementation. This library helps you to convert word documents (.dotx,.docx,.docm,.dot,.doc), rich text format documents (.rtf), and text documents (.txt) into SFDT format. Refer to the following example.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/document-editor/import-docx/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Document-editor.cs" %}
{% include code-snippet/document-editor/import-docx/document-editor.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/document-editor/import-docx/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Document-editor.cs" %}
{% include code-snippet/document-editor/import-docx/document-editor.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Here’s how to handle the server-side action for converting word document in to SFDT.

```csharp
[HttpPost]
public HttpResponseMessage Import()
{
    if (HttpContext.Current.Request.Files.Count == 0)
    return null;

    HttpPostedFile file = HttpContext.Current.Request.Files[0];
    int index = file.FileName.LastIndexOf('.');
    string type = index > -1 && index < file.FileName.Length - 1 ?
    file.FileName.Substring(index) : ".docx";
    Stream stream = file.InputStream;
    stream.Position = 0;

    EJ2WordDocument document = EJ2WordDocument.Load(stream, GetFormatType(type.ToLower()));
    string json = Newtonsoft.Json.JsonConvert.SerializeObject(document);
    document.Dispose();
    stream.Close();
    return new HttpResponseMessage() { Content = new StringContent(json) };
}

internal static FormatType GetFormatType(string format)
{
    if (string.IsNullOrEmpty(format))
        throw new NotSupportedException("EJ2 DocumentEditor does not support this file format.");
    switch (format.ToLower()) {
        case ".dotx":
        case ".docx":
        case ".docm":
        case ".dotm":
            return FormatType.Docx;
        case ".dot":
        case ".doc":
            return FormatType.Doc;
        case ".rtf":
            return FormatType.Rtf;
        case ".txt":
            return FormatType.Txt;
        case ".xml":
            return FormatType.WordML;
        default:
            throw new NotSupportedException("EJ2 DocumentEditor does not support this file format.");
    }
}
```

## See Also

* [Feature modules](../document-editor/feature-module)
