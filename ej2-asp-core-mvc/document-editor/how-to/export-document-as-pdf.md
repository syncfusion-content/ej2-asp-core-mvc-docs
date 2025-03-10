---
layout: post
title: Export PDF Document in ##Platform_Name## Document Editor Component |Syncfusion
description: Learn here all about export document as PDF in Syncfusion ##Platform_Name## Document Editor component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Export Document As PDF
publishingplatform: ##Platform_Name##
documentation: ug
---


# How to export the document as PDF in React Document Editor

This article explains how to export the document as PDF format. You can export the document as PDF in following ways:

## Export the document as PDF in client-side

Use [`pdf export component`](https://www.npmjs.com/package/@syncfusion/ej2-pdf-export) in application level to export the document as PDF using `exportasimage` API. Here, all pages will be converted to image and inserted as PDF pages (works like print as PDF). There is one limitation, the text can't be searched because the PDF is exported as image.

N> You can install the PDF export packages from this [`link`](https://www.npmjs.com/package/@syncfusion/ej2-pdf-export).

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/document-editor-container/export-pdf-client/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Export-pdf-client.cs" %}
{% include code-snippet/document-editor-container/export-pdf-client/document-editor.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/document-editor-container/export-pdf-client/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Export-pdf-client.cs" %}
{% include code-snippet/document-editor-container/export-pdf-client/document-editor.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Export document as PDF in server-side using Syncfusion<sup style="font-size:70%">&reg;</sup> DocIO

With the help of [`Syncfusion DocIO`](https://help.syncfusion.com/file-formats/docio/word-to-pdf), you can export the document as PDF in server-side. Here, you can search the text.

The following way illustrates how to convert the document as PDF:

* Using `serialize` API, convert the document as Sfdt and send it to server-side.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/document-editor-container/export-pdf-server/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Export-pdf-server.cs" %}
{% include code-snippet/document-editor-container/export-pdf-server/document-editor.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/document-editor-container/export-pdf-server/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Export-pdf-server.cs" %}
{% include code-snippet/document-editor-container/export-pdf-server/document-editor.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

{% if page.publishingplatform == "aspnet-core" %}

* Using Save API in server-side, you can convert the sfdt to stream.
* Finally, convert the stream to PDF using `Syncfusion.DocIORenderer.Net.Core` library.

```csharp
[AcceptVerbs("Post")]
[HttpPost]
[EnableCors("AllowAllOrigins")]
[Route("ExportPdf")]
public void ExportPdf([FromBody]SaveParameter data)
{
    // Converts the sfdt to stream
    Stream document = WordDocument.Save(data.content, FormatType.Docx);
    Syncfusion.DocIO.DLS.WordDocument doc = new Syncfusion.DocIO.DLS.WordDocument(document, Syncfusion.DocIO.FormatType.Docx);
    //Instantiation of DocIORenderer for Word to PDF conversion
    DocIORenderer render = new DocIORenderer();
    //Converts Word document into PDF document
    PdfDocument pdfDocument = render.ConvertToPDF(doc);
    // Saves the document to server machine file system, you can customize here to save into databases or file servers based on requirement.
    FileStream fileStream = new FileStream("sample.pdf", FileMode.OpenOrCreate, FileAccess.ReadWrite);
    //Saves the PDF file
    pdfDocument.Save(fileStream);
    pdfDocument.Close();
    fileStream.Close();
    document.Close();
}

```

{% elsif page.publishingplatform == "aspnet-mvc" %}

* Using Save API in server-side, you can convert the sfdt to stream.
* Finally, convert the stream to PDF using `Syncfusion.DocToPdfConverter.AspNet.Mvc5` library.

```csharp

using Syncfusion.DocIO;
using Syncfusion.DocIO.DLS;
using Syncfusion.Pdf;
using Syncfusion.DocToPDFConverter;

[HttpPost]
public void ExportPdf([FromBody] SaveParameter data)
{
    // Converts the sfdt to stream
    Stream document = WordDocument.Save(data.Content, Syncfusion.EJ2.DocumentEditor.FormatType.Docx);
    Syncfusion.DocIO.DLS.WordDocument doc = new Syncfusion.DocIO.DLS.WordDocument(document, Syncfusion.DocIO.FormatType.Docx);
    //Instantiation of DocIORenderer for Word to PDF conversion
    DocToPDFConverter render = new DocToPDFConverter();
    //Converts Word document into PDF document
    PdfDocument pdfDocument = render.ConvertToPDF(doc);
    string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "App_Data", "sample.pdf");
    // Saves the document to server machine file system, you can customize here to save into databases or file servers based on requirement.
    FileStream fileStream = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite);
    //Saves the PDF file
    pdfDocument.Save(fileStream);
    pdfDocument.Close();
    fileStream.Close();
    document.Close();
}

```
{% endif %}

Get the complete working sample in this [`link`](https://github.com/SyncfusionExamples/Export-document-as-PDF-in-Document-Editor/).