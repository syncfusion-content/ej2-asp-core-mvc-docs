---
layout: post  
title: Show and Hide Annotations in EJ2 ASP.NET CORE PdfViewer | Syncfusion  
description: Learn how to show and hide annotations in the Syncfusion ASP.NET CORE PDF Viewer component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: PDF Viewer
publishingplatform: ##Platform_Name##
documentation: ug  
---

# Show and Hide Annotations in PDF Viewer

### Overview

This guide demonstrates how to dynamically show and hide annotations in the Syncfusion PDF Viewer component in an ASP.NET Core application. This functionality is useful when you want to provide users with the ability to toggle the visibility of annotations within PDF documents.

##### Conclusion

By implementing the show and hide annotations functionality in the Syncfusion PDF Viewer, you can provide users with a more flexible document viewing experience. This approach maintains the original annotations data while giving users control over their visibility, which is particularly useful in document review, presentation, and analysis scenarios. The toggle mechanism demonstrates how to effectively use the PDF Viewer's annotation APIs to create enhanced user interactions with PDF documents.

[View sample in GitHub](https://github.com/SyncfusionExamples/asp-core-pdf-viewer-examples/tree/master/How%20to/ShowHideAnnotations) Implementation Steps

**Step 1:** Set up the PDF Viewer in your ASP.NET Core project

First, create a basic PDF Viewer implementation in your ASP.NET Core application.

**Step 2:** Add a toggle button and implement the show/hide functionality

Add a button that allows users to toggle the visibility of annotations within the PDF document.

```html
@page "{handler?}"
@using ShowHideAnnotations.Pages
@model IndexModel
@{
    ViewData["Title"] = "Home page";
}
<div class="text-center">
    <button id="toggleBtn" onclick="toggleAnnotations()">Hide Annotations</button>
    <ejs-pdfviewer id="pdfviewer" style="height:600px" serviceUrl="/Index" documentPath="">
    </ejs-pdfviewer>
</div>

<script type="text/javascript">
    var exportObject = null;
    var annotationsVisible = true;
    
    // Function to run when page loads
    document.addEventListener('DOMContentLoaded', function() {
        // Get viewer instance
        var viewer = document.getElementById('pdfviewer').ej2_instances[0];
        // Load the PDF document
        if (viewer) {
            viewer.documentPath="Data/Annotations.pdf";
            // You can also add any initialization code here
            console.log("PDF viewer initialized and document loading started");
        }
    });
    
    function toggleAnnotations() {
        var viewer = document.getElementById('pdfviewer').ej2_instances[0];
        
        if (annotationsVisible) {
            // Hide annotations by exporting and deleting them
            viewer.exportAnnotationsAsObject().then(function(value) {
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

[View sample in GitHub](https://github.com/SyncfusionExamples/asp-core-pdf-viewer-examples/tree/master/How%20to/ShowHideAnnotations)