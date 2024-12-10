---
layout: post
title: Retrieve Annotation Coordinates in EJ2 ASP.NET MVC PDF Viewer | Syncfusion
description: Learn here how to retrieve annotation coordinates in ASP.NET MVC PDF Viewer component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: PDF Viewer
publishingplatform: ##Platform_Name##
documentation: ug
---

# Retrieve Annotation Coordinates

### Overview
This guide explains how to capture and log the coordinates of annotations in Syncfusion's PDF Viewer using ASP.NET MVC. This functionality is essential for applications requiring precise annotation management.

### Steps to Retrieve Annotation Coordinates

**Step 1:** Set Up the PDF Viewer in Your ASP.NET MVC Project

Follow the steps provided in the [Syncfusion PDF Viewer Getting Started Guide](https://ej2.syncfusion.com/aspnetmvc/documentation/pdfviewer/getting-started) to create a basic PDF Viewer sample.

**Step 2:** Implement Annotation Event Handling

Within your view, configure the PDF Viewer to capture annotation details using the `annotationAdd` event. Log or handle these details as necessary.

```cs
@using Syncfusion.EJ2.PdfViewer
@{
    ViewBag.Title = "Retrieve Annotation Coordinates";
}

<div>
    <div style="height:500px;width:100%;">
        @Html.EJS().PdfViewer("pdfviewer")
            .DocumentPath("https://cdn.syncfusion.com/content/pdf/pdf-succinctly.pdf")
            .AnnotationAdd("onAnnotationAdd")
            .Render()
    </div>
</div>

<script type="text/javascript">
    // Function to handle the annotationAdd event
    function onAnnotationAdd(args) {
        console.log(args); // Log annotation details, including coordinates
    }
</script>
```

By following these steps, you can effectively capture and log annotation coordinates in your ASP.NET MVC applications using Syncfusion's PDF Viewer component.

[View sample in GitHub](https://github.com/SyncfusionExamples/mvc-pdf-viewer-examples/tree/master/How%20to)