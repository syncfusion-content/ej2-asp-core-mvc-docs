---
layout: post
title: AnnotationSelector Setting in EJ2 ASP.NET CORE PDF Viewer | Syncfusion
description: Learn here all about Configuring AnnotationSelector setting in ASP.NET MVC PDF Viewer component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: PDF Viewer
publishingplatform: ##Platform_Name##
documentation: ug
---

# How to Configure Annotation Selector Settings

### Annotation Selector Settings

The [**annotationSelectorSettings**](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PdfViewer.PdfViewerAnnotationSelectorSettings.html) property allows you to customize the appearance and behavior of the annotation selector in the UI. The AnnotationSelectorSettings defines the settings for the annotation selector, including border colors, sizes, and shapes. It provides fine-grained control over how annotations are displayed and interacted with.

### How to Configure Annotation Selector Settings

**Step 1:** Follow the steps provided in the [link](https://ej2.syncfusion.com/aspnetcore/documentation/pdfviewer/getting-started/) to create simple PDF Viewer sample.

**Step 2:** Set Up PDF Viewer in Your View: Add the following code snippet to your view (e.g., Index.cshtml)

```
@{
    ViewData["Title"] = "Home page";
}

<div class="text-center">
    <ejs-pdfviewer id="pdfviewer" style="height:600px" documentPath="https://cdn.syncfusion.com/content/pdf/pdf-succinctly.pdf" resourceUrl="https://cdn.syncfusion.com/ej2/27.1.48/dist/ej2-pdfviewer-lib">
    </ejs-pdfviewer>
</div>
```

**Step 3:**	 Add JavaScript for Annotation Selector Settings: Below the PDF Viewer in your view, include the following script to configure the annotationSelectorSettings

```
 <script type="text/javascript" >
window.onload = function () {
    var viewer = document.getElementById('pdfviewer').ej2_instances[0];
        viewer.annotationSelectorSettings = {
            selectionBorderColor: 'blue',
            resizerBorderColor: 'red',
            resizerFillColor: '#4070ff',
            resizerSize: 8,
            selectionBorderThickness: 1,
            resizerShape: 'Circle',
            selectorLineDashArray: [5, 6],
            resizerLocation: ej.pdfviewer.AnnotationResizerLocation.Corners | ej.pdfviewer.AnnotationResizerLocation.Edges,
            resizerCursorType: ej.pdfviewer.CursorType.grab
        };
}
</script>
```
#### Key properties include:

* **selectionBorderColor**: Sets the color for the border around selected annotations.

* **resizerBorderColor**: Sets the color for the border of the resizer handles.

* **resizerFillColor**: Defines the fill color for the resizer handles.

* **resizerSize**: Determines the size of the resizer handles.

* **selectionBorderThickness**: Specifies how thick the selection border should be.

* **resizerShape**: Allows you to choose the shape of the resizer handles (e.g., Circle or Square).

* **selectorLineDashArray**: Specifies the dash pattern for the selector line to enhance visual cues.

* **resizerLocation**: Determines where the resizer appear in relation to the annotation (e.g., Corners or Edges).

* **resizerCursorType**: Sets the cursor style when hovering over the resizer, improving user interaction.

[View sample in GitHub](https://github.com/SyncfusionExamples/asp-core-pdf-viewer-examples/tree/master/How%20to)
