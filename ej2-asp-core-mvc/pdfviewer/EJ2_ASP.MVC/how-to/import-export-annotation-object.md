---
layout: post
title: Import Export Annotation Object in ##Platform_Name## Pdfviewer Component
description: Learn here all about Import Export Annotation Object in Syncfusion ##Platform_Name## Pdfviewer component and more.
platform: ej2-asp-core-mvc
control: Import Export Annotation Object
publishingplatform: ##Platform_Name##
documentation: ug
---


# Import and Export annotation as object

The PDF Viewer library allows you to import annotations from objects or streams instead of loading it as a file. To import such annotation objects, the PDF Viewer control must export the PDF annotations as objects using the [**ExportAnnotationsAsObject()**](https://ej2.syncfusion.com/documentation/api/pdfviewer/#exportannotationsasobject) method. Only the annotations objects that are exported from the PDF Viewer can be imported.

The following steps are used to import and export annotation as object.

**Step 1:** Follow the steps provided in the [link](https://ej2.syncfusion.com/aspnetmvc/documentation/pdfviewer/getting-started/) to create a simple PDF Viewer sample.

**Step 2:** Use the following code snippet to perform import and export annotation.

```html
<button type="button" onclick="exportAnnotation()">Export Annoatation</button>
<button type="button" onclick="importAnnotation()">Import Annoatation</button>

<script>
   var exportObject;
     //Export annotation as object.
    function exportAnnotation() {
        var viewer = document.getElementById('pdfViewer').ej2_instances[0];
        viewer.exportAnnotationsAsObject().then(function (value) {
            exportObject = value
        });
    }
    //Import annotation that are exported as object.
    function importAnnotation() {
        var viewer = document.getElementById('pdfViewer').ej2_instances[0];
        viewer.importAnnotation(JSON.parse(exportObject));
    }
</script>
```

Find the Sample, [how to import and export annotation as object](https://www.syncfusion.com/downloads/support/directtrac/general/ze/EJ2MvcSample-654457926.zip)