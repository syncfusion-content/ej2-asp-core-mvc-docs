---
layout: post  
title: Show and Hide Annotations in EJ2 ASP.NET MVC PdfViewer | Syncfusion  
description: Learn how to dynamically show and hide annotations in the Syncfusion ASP.NET MVC PDF Viewer component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Show and Hide Annotations
publishingplatform: ##Platform_Name##
documentation: ug  
---

# Show and Hide Annotations in PDF Viewer

### Overview

This guide demonstrates how to implement functionality to dynamically show and hide annotations in a PDF document loaded in the Syncfusion PDF Viewer using ASP.NET MVC. This feature is particularly useful in scenarios where you need to present a clean view of the document or toggle between annotated and non-annotated views.

### How to Show and Hide Annotations

**Step 1:** Set Up the PdfViewer in Your ASP.NET MVC Project

First, follow the steps provided in the [getting started guide](https://ej2.syncfusion.com/aspnetmvc/documentation/pdfviewer/getting-started) to create a simple PDF Viewer sample.

**Step 2:** Add Toggle Button and Implementation

Add a button to toggle annotation visibility and implement the necessary JavaScript functions to handle the show/hide functionality:

```html
@using Syncfusion.EJ2;
@{
    ViewBag.Title = "Home Page";
}
<div class="text-center">
    <button id="toggleBtn" onclick="toggleAnnotations()">Hide Annotations</button>
    <div style="height:600px">
        @Html.EJS().PdfViewer("pdfviewer").ServiceUrl(VirtualPathUtility.ToAbsolute("~/Home/")).Render()
    </div>
</div>

<script type="text/javascript">
    var exportObject = null;
    var annotationsVisible = true;
    
    // Function to run when page loads
    document.addEventListener('DOMContentLoaded', function () {
        // Get viewer instance
        var viewer = document.getElementById('pdfviewer').ej2_instances[0];
        // Load the PDF document
        if (viewer) {
            viewer.documentPath = "Annotations.pdf";
            // You can also add any initialization code here
            console.log("PDF viewer initialized and document loading started");
        }
    });
    
    function toggleAnnotations() {
        var viewer = document.getElementById('pdfviewer').ej2_instances[0];
        if (annotationsVisible) {
            // Hide annotations by exporting and deleting them
            viewer.exportAnnotationsAsObject().then(function (value) {
                exportObject = value;
                var count = viewer.annotationCollection.length;
                for (var i = 0; i < count; i++) {
                    // Always delete the first item as the collection shrinks
                    viewer.annotationModule.deleteAnnotationById(viewer.annotationCollection[0].annotationId);
                }
                annotationsVisible = false;
                document.getElementById('toggleBtn').textContent = 'Show Annotations';
            });
        } else {
            // Restore annotations
            if (exportObject) {
                var exportAnnotObject = JSON.parse(exportObject);
                viewer.importAnnotation(exportAnnotObject);
            }
            annotationsVisible = true;
            document.getElementById('toggleBtn').textContent = 'Hide Annotations';
        }
    }
</script>
```
### Conclusion

This implementation provides a clean, efficient way to toggle the visibility of annotations in your PDF documents. It's particularly useful for presentation scenarios or when you need to focus on the document content without the distraction of annotations.

[View sample in GitHub](https://github.com/SyncfusionExamples/mvc-pdf-viewer-examples/tree/master/How%20to)