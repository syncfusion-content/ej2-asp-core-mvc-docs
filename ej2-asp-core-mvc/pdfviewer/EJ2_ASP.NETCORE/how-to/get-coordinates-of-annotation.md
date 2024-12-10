---
layout: post
title: Retrieve Annotation Coordinates in ##Platform_Name## Pdfviewer Component
description: Learn here all about how to retrieve annotation coordinates in Syncfusion ##Platform_Name## Pdfviewer component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Retrieve Annotation Coordinates
publishingplatform: ##Platform_Name##
documentation: ug
---

# Retrieve Annotation Coordinates in ASP.NET Core PDF Viewer

### Overview
This guide explains how to capture and log the coordinates of annotations in Syncfusion's PDF Viewer using ASP.NET Core. This functionality is essential for applications requiring precise annotation management.

### Steps to Retrieve Annotation Coordinates

**Step 1:** Set Up the PDF Viewer in Your ASP.NET Core Project

Follow the steps provided in the [Syncfusion PDF Viewer Getting Started Guide](https://ej2.syncfusion.com/aspnetcore/documentation/pdfviewer/getting-started) to create a basic PDF Viewer sample.

**Step 2:** Implement Annotation Event Handling

Within your Razor view, configure the PDF Viewer to capture annotation details using the `annotationAdd` event. Log or handle these details as necessary.

```cs
@page "{handler?}"
@model IndexModel
@{
    ViewData["Title"] = "Home page";
}

<div class="text-center">
    <ejs-pdfviewer id="pdfviewer" style="height:600px"
                   documentPath="https://cdn.syncfusion.com/content/pdf/pdf-succinctly.pdf"
                   resourceUrl="https://cdn.syncfusion.com/ej2/27.2.2/dist/ej2-pdfviewer-lib"
                   annotationAdd="onAnnotationAdd">
    </ejs-pdfviewer>
</div>

<script type="text/javascript">
    // Handle annotation add event
    function onAnnotationAdd(args) {
        console.log(args);  // Log the event arguments when an annotation is added
    }
</script>
```

By following these steps, you can effectively capture and log annotation coordinates in your ASP.NET Core applications using Syncfusion's PDF Viewer component.

[View sample in GitHub](https://github.com/SyncfusionExamples/asp-core-pdf-viewer-examples/tree/master/How%20to)
