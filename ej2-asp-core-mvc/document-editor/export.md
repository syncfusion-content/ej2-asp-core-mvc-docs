---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Export of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Export
publishingplatform: ##Platform_Name##
documentation: ug
---


# Export

Document editor exports the document into various known file formats in client-side such as Microsoft Word document (.docx), text document (.txt), and its own format called **Syncfusion Document Text (.sfdt)**.

## Sfdt export

The following example shows how to export documents in document editor as Syncfusion document text (.sfdt).

{% aspTab template="document-editor/export-sfdt", sourceFiles="document-editor.cs" %}

{% endaspTab %}

>To enable Sfdt export for a document editor instance, set `enableSfdtExport` to true.

## Word export

The following example shows how to export the document as Word document (.docx).

{% aspTab template="document-editor/export-docx", sourceFiles="document-editor.cs" %}

{% endaspTab %}

>To enable word export for a document editor instance, set `enableWordExport` to true.

## Text export

The following example shows how to export document as text document (.txt).

{% aspTab template="document-editor/export-txt", sourceFiles="document-editor.cs" %}

{% endaspTab %}

>To enable text export for a document editor instance, set `enableTextExport` to true.

## Export as blob

Document editor also supports API to store the document into a blob. Refer to the following sample to export document into blob in client-side.

{% aspTab template="document-editor/export-blob" %}

{% endaspTab %}

For instance, to export the document as Rich Text Format file, implement an ASP.NET MVC web API controller using DocIO library by passing the DOCX blob. Refer to the following code example.

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

In client-side, you can consume this web service and save the document as Rich Text Format (.rtf) file. Refer to the following example.

{% aspTab template="document-editor/export-rtf" %}

{% endaspTab %}

## See Also

* [Feature modules](../../document-editor/feature-module/)
* [How to export the document as pdf](../document-editor/how-to/export-document-as-pdf).
