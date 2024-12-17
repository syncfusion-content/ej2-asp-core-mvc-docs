---
layout: post
title: Add Annotation in Text Search in EJ2 ASP.NET MVC PDF Viewer | Syncfusion
description: Learn how to add rectangle annotations using search text bounds in ASP.NET MVC PDF Viewer component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: PDF Viewer
publishingplatform: ##Platform_Name##
documentation: ug
---

# Add Rectangle Annotations Using Search Text Bounds in PDF Viewer

## Overview

This guide demonstrates how to add rectangle annotations based on the bounds of highlighted search text in the PDF Viewer. This technique is useful for emphasizing search results with visual markers in annotation-supported applications.

## Steps to Add Rectangle Annotations on Search Result Highlight

**Step 1:** Set Up the PDF Viewer in Your ASP.NET MVC Project

Follow the steps provided in the [Syncfusion PDF Viewer Getting Started Guide](https://ej2.syncfusion.com/aspnetmvc/documentation/pdfviewer/getting-started) to create a basic PDF Viewer sample.

**Step 2:** Set Up the PdfViewer Component to add rectangle annotations based on the bounds of highlighted search text in the PDF Viewer. 

```cs
@using Syncfusion.EJ2
@{
    ViewBag.Title = "Home Page";
}
<!-- Control buttons for PDF Search functionality -->
<div style="margin-top: 20px;">
    <button onclick="handleSearch()">Search PDF</button>
    <button onclick="handleSearchNext()">Search Next</button>
    <button onclick="handleCancelSearch()">Cancel Search</button>
</div>
<div>
    <!-- Render PDF Viewer using the Html helper method -->
    @Html.EJS().PdfViewer("pdfviewer").DocumentPath("https://cdn.syncfusion.com/content/pdf/pdf-succinctly.pdf").TextSearchHighlight("handleTextSearchHighlight").Render()
</div>


<script type="text/javascript">
    window.onload = function () {
        // Access the PDF Viewer instance on page load
        var pdfViewer = getPdfViewerInstance();
        pdfViewer.enableLocalStorage = true; // Enable or configure as needed
    };
    // Function to get the PDF Viewer instance conveniently
    function getPdfViewerInstance() {
        return document.getElementById('pdfviewer').ej2_instances[0];
    }
    // Initiate search for the term 'PDF' in the document
    function handleSearch() {
        const pdfViewer = getPdfViewerInstance();
        pdfViewer.textSearchModule.searchText('PDF', false);
    }
    // Move to next search result
    function handleSearchNext() {
        const pdfViewer = getPdfViewerInstance();
        pdfViewer.textSearchModule.searchNext();
    }
    // Cancel any ongoing text search operation
    function handleCancelSearch() {
        const pdfViewer = getPdfViewerInstance();
        pdfViewer.textSearchModule.cancelTextSearch();
    }
    // Event handler for when text is highlighted during search
    function handleTextSearchHighlight(args) {
        const pdfViewer = getPdfViewerInstance();
        console.log(args);  // Display highlight event data
        const bounds = args.bounds;
        // Add rectangle annotation around highlighted text
        pdfViewer.annotationModule.addAnnotation('Rectangle', {
            pageNumber: args.pageNumber,
            offset: { x: bounds.left, y: bounds.top },
            width: bounds.width,
            height: bounds.height,
            strokeColor: "red", // Customize the stroke color if desired
            borderWidth: 2
        });
    }
</script>
```

By following this guide, you will enable the PDF Viewer to add rectangle annotations at search result locations, thus increasing the visibility of search results in your application.

[View sample in GitHub](https://github.com/SyncfusionExamples/mvc-pdf-viewer-examples/tree/master/How%20to)