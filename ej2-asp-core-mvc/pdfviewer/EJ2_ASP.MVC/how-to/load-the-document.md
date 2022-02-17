---
layout: post
title: Load The Document in ##Platform_Name## Pdfviewer Component
description: Learn here all about Load The Document in Syncfusion ##Platform_Name## Pdfviewer component and more.
platform: ej2-asp-core-mvc
control: Load The Document
publishingplatform: ##Platform_Name##
documentation: ug
---


# Load the PDF document

The PDF Viewer server library allows you to load the PDF document in the PDF Viewer Control. PDF Document can be loaded by adding the necessary JSON object Properties in the **PdfViewerController.cs** file.

The following steps are used to load a PDF document.

**Step 1:** Follow the steps provided in the [link](https://ej2.syncfusion.com/aspnetmvc/documentation/pdfviewer/getting-started/) to create a simple PDF Viewer sample.

**Step 2:** Add the following code snippet in PDFViewerController.cs file to load a PDF document.

```cs

public class jsonObjects { public string document { get; set; }
    public string password { get; set; }
    public string zoomFactor { get; set; }
    public string isFileName { get; set; }
    public string xCoordinate { get; set; }
    public string yCoordinate { get; set; }
    public string pageNumber { get; set; }
    public string documentId { get; set; }
    public string hashId { get; set; }
    public string sizeX { get; set; }
    public string sizeY { get; set; }
    public string startPage { get; set; }
    public string endPage { get; set; }
    public string stampAnnotations { get; set; }
    public string textMarkupAnnotations { get; set; }
    public string stickyNotesAnnotation { get; set; }
    public string shapeAnnotations { get; set; }
    public string measureShapeAnnotations { get; set; }
    public string action { get; set; }
    public string pageStartIndex { get; set; }
    public string pageEndIndex { get; set; }
    public string fileName { get; set; }
    public string elementId { get; set; }
    public string pdfAnnotation { get; set; }
    public string importPageList { get; set; }
    public string uniqueId { get; set; }
    public string data { get; set; }
    public string viewPortWidth { get; set; }
    public string viewportHeight { get; set; }
    public string tilecount { get; set; }
    public string isCompletePageSizeNotReceived { get; set; }
    public string freeTextAnnotation { get; set; }
    public string signatureData { get; set; }
    public string fieldsData { get; set; }
}

```

Find the sample [how to load the PDF Document in MVC PDF Viewer](https://www.syncfusion.com/downloads/support/directtrac/general/ze/PDFViewTest-1000651816)