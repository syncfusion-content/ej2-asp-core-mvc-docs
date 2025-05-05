---
layout: post
title: Export HTML Document in ##Platform_Name## Document Editor Component |Syncfusion
description: Learn here all about export document as HTML in Syncfusion ##Platform_Name## Document Editor component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Export Document As HTML
publishingplatform: ##Platform_Name##
documentation: ug
---

# Export document as HTML in ##Platform_Name## Document editor component

Document editor doesn't provide support to export document as HTML in client side. We can export the document as HTML using Syncfusion<sup style="font-size:70%">&reg;</sup> DocIO library.

In this article, we are going to see how to export the document as HTML format. 

## How to Export the document as HTML in DocumentEditor

### Client-side Code

The following example code illustrates how to export the document as HTML in client-side.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/document-editor-container/export-HTML/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Export-HTML.cs" %}
{% include code-snippet/document-editor-container/export-HTML/document-editor.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/document-editor-container/export-HTML/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Export-HTML.cs" %}
{% include code-snippet/document-editor-container/export-HTML/document-editor.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

### Server-side Code

* Using `serialize` API, convert the document as Sfdt and send it to server-side.

The following example code illustrates how to convert the document to sfdt and pass it to server-side.

* Using Save API in server-side, you can convert the sfdt to stream.
* Finally, Save the stream into HTML format. 

Please refer below example for server-side code.

```csharp
[AcceptVerbs("Post")]
[HttpPost]
[EnableCors("AllowAllOrigins")]
[Route("ExportHTML")]
public void ExportHTML([FromBody] SaveParameter data)
{
    string name = data.FileName;
    string format = RetrieveFileType(name);
    if (string.IsNullOrEmpty(name))
    {
        name = "Document1.doc";
    }
    WDocument document = WordDocument.Save(data.Content);
    FileStream fileStream = new FileStream(name, FileMode.OpenOrCreate, FileAccess.ReadWrite);
    document.Save(fileStream, GetWFormatType(format));
    document.Close();
    fileStream.Close();
}
```
