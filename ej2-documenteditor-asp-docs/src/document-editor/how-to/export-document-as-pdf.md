---
title: "How to export document as pdf"
component: "DocumentEditor"
description: "Learn how to export document as pdf in React Document Editor."
---

# How to export the document as pdf in React Document Editor

In this article, we are going to see how to export the document as Pdf format. You can export the document as Pdf in following ways:

## Export the document as pdf in client-side

Use [`pdf export component`](https://www.npmjs.com/package/@syncfusion/ej2-pdf-export) in application level to export the document as pdf using `exportasimage` API. Here, all pages will be converted to image and inserted as pdf pages(works like print as PDF). There is one limitation we can’t search the text because we are exporting the pdf as image.

>Note: You can install the pdf export packages from this [`link`](https://www.npmjs.com/package/@syncfusion/ej2-pdf-export).

The following example code illustrates how to export the document as pdf in client-side.

{% aspTab template="document-editor-container/export-pdf-client" %}

{% endaspTab %}

## Export document as pdf in server-side using Syncfusion DocIO

With the help of [`Synfusion DocIO`](https://help.syncfusion.com/file-formats/docio/word-to-pdf), you can export the document as Pdf in server-side. Here, you can search the text.

The following way illustrates how to convert the document as Pdf:

* Using `serialize` API, convert the document as Sfdt and send it to server-side.

The following example code illustrates how to convert the document to sfdt and pass it to server-side.

{% aspTab template="document-editor-container/export-pdf-server" %}

{% endaspTab %}

* Using Save API in server-side, you can convert the sfdt to stream.
* Finally, convert the stream to Pdf using `Syncfusion.DocIORenderer.Net.Core` library.

The following example code illustrates how to process the sfdt in server-side.

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

Get the complete working sample in this [`link`](https://github.com/SyncfusionExamples/Export-document-as-PDF-in-Document-Editor/).