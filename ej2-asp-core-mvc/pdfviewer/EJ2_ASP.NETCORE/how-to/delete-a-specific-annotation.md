---
layout: post
title: Delete A Specific Annotation in ##Platform_Name## Pdfviewer Component
description: Learn here all about Delete A Specific Annotation in Syncfusion ##Platform_Name## Pdfviewer component and more.
platform: ej2-asp-core-mvc
control: Delete A Specific Annotation
publishingplatform: ##Platform_Name##
documentation: ug
---

# Delete a specific annotation using deleteAnnotationById

The PDF Viewer server library allows you to delete a specific annotation from PDF document. Deleting a specific annotation can be done using the **deleteAnnotationById()** method. This method is used to delete a specific annotation using its id.

The following steps are used to delete a specific annotation from PDF Document.

**Step 1:** Follow the steps provided in the [link](https://ej2.syncfusion.com/aspnetcore/documentation/pdfviewer/getting-started/) to create simple PDF Viewer sample.

**Step 2:** Use the following code snippet to delete a specific annotation using deleteAnnotationById() method.

```html

<button onclick="deleteAnnotationbyId()">deleteAnnotationbyId</button>

<script>

    function deleteAnnotationbyId() {
        var viewer = document.getElementById('pdfviewer1').ej2_instances[0];
        viewer.annotationModule.deleteAnnotationById(viewer.annotationCollection[0].annotationId);
    }

</script>

```

Download the sample [how to delete a specific annotation using deleteAnnotationById](https://www.syncfusion.com/downloads/support/directtrac/general/ze/EJ2PDFViewer_Core3.0-586159002)