---
layout: post
title: Add Annotation in Text Search in ##Platform_Name## | Syncfusion
description: Learn how to add rectangle annotations using search text bounds in Syncfusion ##Platform_Name## Pdfviewer component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Retrieve Annotation Coordinates
publishingplatform: ##Platform_Name##
documentation: ug
---

# Add Rectangle Annotations Using Search Text Bounds in PDF Viewer

## Overview

This guide demonstrates how to add rectangle annotations based on the bounds of highlighted search text in the PDF Viewer. This technique is useful for emphasizing search results with visual markers in annotation-supported applications.

## Steps to Add Rectangle Annotations on Search Result Highlight

**Step 1:** Set Up the PDF Viewer in Your ASP.NET Core Project

Follow the steps provided in the [Syncfusion PDF Viewer Getting Started Guide](https://ej2.syncfusion.com/aspnetcore/documentation/pdfviewer/getting-started) to create a basic PDF Viewer sample.

**Step 2:** Set Up the PdfViewer Component to add rectangle annotations based on the bounds of highlighted search text in the PDF Viewer. 


```cs

@page "{handler?}"
@model IndexModel
@{
    ViewData["Title"] = "Home page";
}
<div class="text-center">
    <!-- Control buttons for PDF Search functionality -->
    <div style="margin-top: 20px;">
        <button onclick="handleSearch()">Search PDF</button>
        <button onclick="handleSearchNext()">Search Next</button>
        <button onclick="handleCancelSearch()">Cancel Search</button>
    </div>
    <ejs-pdfviewer id="pdfviewer" style="height:600px"
                   documentPath="https://cdn.syncfusion.com/content/pdf/pdf-succinctly.pdf"
                   resourceUrl="https://cdn.syncfusion.com/ej2/28.1.33/dist/ej2-pdfviewer-lib"
                   textSearchHighlight="handleTextSearchHighlight">
    </ejs-pdfviewer>
</div>
<script type="text/javascript">
    // Function to get the PDF Viewer instance
    function getPdfViewerInstance() {
        return document.getElementById('pdfviewer').ej2_instances[0];
    }
    // Initiates a search for the term 'PDF' in the document
    function handleSearch() {
        const pdfViewer = getPdfViewerInstance();
        pdfViewer.textSearchModule.searchText('PDF', false);
    }
    // Searches for the next occurrence of the term
    function handleSearchNext() {
        const pdfViewer = getPdfViewerInstance();
        pdfViewer.textSearchModule.searchNext();
    }
    // Cancels the current text search operation
    function handleCancelSearch() {
        const pdfViewer = getPdfViewerInstance();
        pdfViewer.textSearchModule.cancelTextSearch();
    }
    // Event handler for annotation addition
    // Adds a rectangle annotation around highlighted text
    function handleTextSearchHighlight(args) {
        console.log(args);   // Log details of the added annotation around highlighted text
        const pdfViewer = getPdfViewerInstance();
        const bounds = args.bounds;
        pdfViewer.annotationModule.addAnnotation('Rectangle', {
            pageNumber: args.pageNumber,
            offset: { x: bounds.left, y: bounds.top },
            width: bounds.width,
            height: bounds.height,
        });
    }
</script>

```

By following this guide, you will enable the PDF Viewer to add rectangle annotations at search result locations, thus increasing the visibility of search results in your application.

[View sample in GitHub](https://github.com/SyncfusionExamples/asp-core-pdf-viewer-examples/tree/master/How%20to)
