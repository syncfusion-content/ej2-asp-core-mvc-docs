---
layout: post
title: Instantiate with EJ2 ASP.NET Core PDF Viewer Control | Syncfusion
description: Learn how to dynamically instantiate the PDF Viewer component in Syncfusion ##Platform_Name## Pdfviewer component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Instantiate the PDF Viewer component dynamically and load PDF documents
publishingplatform: ##Platform_Name##
documentation: ug
---

# Instantiate the PDF Viewer component dynamically

To instantiate a PDF Viewer component dynamically and load PDF documents in Syncfusion PDF Viewer, use the following steps:

In your HTML file, create a div element that will act as a container for the PDF Viewer component, and use the jQuery $.ajax method to make an AJAX request to your server and retrieve a PDF document. Once the document is retrieved, use the PDF Viewer API to load the document into the PDF Viewer component.

Use the serviceUrl property of the PDF Viewer instance to set the URL of a PDF document you want to load.

```html

<div style="width:100%;height:600px">
    <button id="loadPDF Viewer">Load PDF Viewer</button>
    <div id="pdfViewer" style="height: 100%;width: 100%;"></div>
</div>

<script>
    document.getElementById("loadPDF Viewer").addEventListener('click', function () {
        $.ajax({
            url: 'https://localhost:44327/pdfviewer/GetPdfDocument',
            type: "GET",
            success: function (data) {
                var viewer = new ej.pdfviewer.PdfViewer({
                    serviceUrl: "https://localhost:44327/pdfviewer",
                    documentPath: data,
                });
                viewer.appendTo("#pdfViewer");
            }
        });
    });
</script>

```

In your controller, create an action method that returns a PDF document as an action result.

[View Sample in GitHub](https://github.com/SyncfusionExamples/asp-core-pdf-viewer-examples/tree/master/Common/Instantiate%20PDF%20Viewer%20dynamically).