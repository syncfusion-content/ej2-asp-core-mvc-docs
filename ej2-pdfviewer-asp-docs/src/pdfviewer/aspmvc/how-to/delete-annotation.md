---
title: "Delete a specific annotation using deleteAnnotationById"
component: "PDF Viewer"
description: "Learn how to delete a specific annotation using deleteAnnotationById in PDF Viewer control."
---
# Delete a specific annotation using deleteAnnotationById

The PDF Viewer server library allows you to delete a specific annotation from a PDF document. Deleting a specific annotation can be done using the **deleteAnnotationById()** method. This method is used to delete a specific annotation using its id.

The following steps are used to delete a specific annotation from PDF Document.

**Step 1:** Follow the steps provided in the [link](https://ej2.syncfusion.com/aspnetmvc/documentation/pdfviewer/getting-started/) to create simple PDF Viewer sample.

**Step 2:** Use the following code snippet to delete a specific annotation using `deleteAnnotationById()` method.

```html
<button type="button" onclick="deleteAnnotationbyId()">Delete Annotation by Id</button>

<script>
// Delete Annotation by ID.
function deleteAnnotationbyId() {
    var viewer = document.getElementById('pdfViewer').ej2_instances[0];
    viewer.annotationModule.deleteAnnotationById(viewer.annotationCollection[0].annotationId);
}
</script>

```

Download the sample [how to delete a specific annotation using deleteAnnotationById](https://www.syncfusion.com/downloads/support/directtrac/general/ze/EJ2MvcSample357842164.zip)