---
layout: post
title: Import Export Annotation in EJ2 ASP.NET MVC PDF Viewer | Syncfusion
description: Learn how to Import Export Annotation in ASP.NET MVC PDF Viewer component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Import Export Annotation Object
publishingplatform: ej2-asp-core-mvc
documentation: ug
---


# Import and Export annotation

The PDF Viewer library allows you to import annotations from objects or streams instead of loading it as a file. To import such annotation objects, the PDF Viewer control must export the PDF annotations as objects using the [**ExportAnnotationsAsObject()**](https://ej2.syncfusion.com/documentation/api/pdfviewer/#exportannotationsasobject) method. Only the annotations objects that are exported from the PDF Viewer can be imported.

The following steps are used to import and export annotations in various formats such as objects, JSON, and XFDF.

**Step 1:** Follow the steps provided in the [link](https://ej2.syncfusion.com/aspnetmvc/documentation/pdfviewer/getting-started/) to create a simple PDF Viewer sample.

**Step 2:** Use the following code snippet to perform import and export annotation.

```html
    <button type="button" onclick="exportAsJson()">Export Annotation As Json</button>
    <button type="button" onclick="exportAsXfdf()">Export Annotation As Xfdf</button>
    <button type="button" onclick="exportAnnotation()">Export Annotation</button>
    <button type="button" onclick="importAnnotation()">Import Annotation</button>

<script>
   var exportObject;
        //Export annotation as Json
        function exportAsJson() {
            var viewer = document.getElementById('pdfViewer').ej2_instances[0];
            viewer.exportAnnotation('Json');
        }
        //Export annotation as Xfdf
        function exportAsXfdf() {
            var viewer = document.getElementById('pdfViewer').ej2_instances[0];
            viewer.exportAnnotation('Xfdf');
        }
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

[View sample in GitHub](https://github.com/SyncfusionExamples/mvc-pdf-viewer-examples/tree/master/How%20to)