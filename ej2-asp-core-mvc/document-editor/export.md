---
layout: post
title: Export in ##Platform_Name## Document Editor Component | Syncfusion
description: Learn here all about Export in Syncfusion ##Platform_Name## Document Editor component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Export
publishingplatform: ##Platform_Name##
documentation: ug
---


# Export in Document Editor Component

Document editor exports the document into various known file formats in client-side such as Microsoft Word document (.docx), text document (.txt), and its own format called **Syncfusion Document Text (.sfdt)**.

We are providing two types of save APIs  as mentioned below.

|API name|Purpose|
|--------|---------|
|save(filename,FormatType):void<br>FormatType: Sfdt or Docx or Txt|Creates the document with specified file name and format type. Then, the created file is downloaded in the client browser by default.|
|saveAsBlob(FormatType):Blob|Creates the document in specified format type and returns the created document as Blob.<br>This blob can be uploaded to your required server, database, or file path.|

## Sfdt export

The following example shows how to export documents in document editor as Syncfusion document text (.sfdt).

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/document-editor/export-sfdt/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Document-editor.cs" %}
{% include code-snippet/document-editor/export-sfdt/document-editor.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/document-editor/export-sfdt/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Document-editor.cs" %}
{% include code-snippet/document-editor/export-sfdt/document-editor.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



N>To enable Sfdt export for a document editor instance, set [`enableSfdtExport`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DocumentEditor.DocumentEditor.html#Syncfusion_EJ2_DocumentEditor_DocumentEditor_EnableSfdtExport) to true.

## Word export

The following example shows how to export the document as Word document (.docx).

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/document-editor/export-docx/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Document-editor.cs" %}
{% include code-snippet/document-editor/export-docx/document-editor.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/document-editor/export-docx/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Document-editor.cs" %}
{% include code-snippet/document-editor/export-docx/document-editor.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



N>To enable word export for a document editor instance, set [`enableWordExport`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DocumentEditor.DocumentEditor.html#Syncfusion_EJ2_DocumentEditor_DocumentEditor_EnableWordExport) to true.

## Word Template Export 

The following example shows how to export the document as Word Template (.dotx).

>Note: The Syncfusion Document Editor component's document pagination (page-by-page display) can't be guaranteed for all the Word documents to match the pagination of Microsoft Word application. For more information about [why the document pagination (page-by-page display) differs from Microsoft Word](../document-editor/import/#why-the-document-pagination-differs-from-microsoft-word)

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/document-editor/export-dotx/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Document-editor.cs" %}
{% include code-snippet/document-editor/export-dotx/document-editor.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/document-editor/export-dotx/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Document-editor.cs" %}
{% include code-snippet/document-editor/export-dotx/document-editor.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Text export

The following example shows how to export document as text document (.txt).

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/document-editor/export-txt/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Document-editor.cs" %}
{% include code-snippet/document-editor/export-txt/document-editor.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/document-editor/export-txt/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Document-editor.cs" %}
{% include code-snippet/document-editor/export-txt/document-editor.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



N>To enable text export for a document editor instance, set [`enableTextExport`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DocumentEditor.DocumentEditor.html#Syncfusion_EJ2_DocumentEditor_DocumentEditor_EnableTextExport) to true.

## Export as blob

Document editor also supports API to store the document into a blob.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/document-editor/export-blob/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Export-blob.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/document-editor/export-blob/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Export-blob.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}



For instance, to export the document as Rich Text Format file, implement an ASP.NET MVC web API controller using DocIO library by passing the DOCX blob.

```csharp
//API controller for the conversion.
[HttpPost]
public HttpResponseMessage ExportAsRtf()
{
    System.Web.HttpPostedFile data = HttpContext.Current.Request.Files[0];
    //Opens document stream
    WordDocument wordDocument = new WordDocument(data.InputStream);
    MemoryStream stream = new MemoryStream();
    //Converts document stream as RTF
    wordDocument.Save(stream, FormatType.Rtf);
    wordDocument.Close();
    stream.Position = 0;
    return new HttpResponseMessage() { Content = new StreamContent(stream) };
}
```

In client-side, you can consume this web service and save the document as Rich Text Format (.rtf) file.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/document-editor/export-rtf/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Export-rtf.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/document-editor/export-rtf/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Export-rtf.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}



## See Also

* [Feature modules](../document-editor/feature-module/)
* [How to export the document as pdf](../document-editor/how-to/export-document-as-pdf).
