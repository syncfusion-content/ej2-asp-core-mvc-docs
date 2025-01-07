---
layout: post
title: Import Export Annotation in ##Platform_Name## Pdfviewer Component
description: Learn here all about Import Export Annotation Object in Syncfusion ##Platform_Name## Pdfviewer component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Import Export Annotation Object
publishingplatform: ##Platform_Name##
documentation: ug
---

# Import and Export annotation

The PDF Viewer library allows you to import annotations from objects or streams instead of loading it as a file. To import such annotation objects, the PDF Viewer control must export the PDF annotations as objects using the [**ExportAnnotationsAsObject()**](https://ej2.syncfusion.com/documentation/api/pdfviewer/#exportannotationsasobject) method. Only the annotations objects that are exported from the PDF Viewer can be imported.

The following steps are used to import and export annotations in various formats such as objects, JSON, and XFDF.

**Step 1:** Follow the steps provided in the [link](https://ej2.syncfusion.com/aspnetcore/documentation/pdfviewer/getting-started/) to create a simple PDF Viewer sample.

**Step 2:** Use the following code snippet to perform import and export annotation.

{% tabs %}
{% highlight cshtml tabtitle="Standalone" %}
@page "{handler?}"
@model IndexModel
@{
    ViewData["Title"] = "Home page";
}

<button type="button" onclick="exportAsJson()">Export Annoatation As Json</button>
<button type="button" onclick="exportAsXfdf()">Export Annoatation As Xfdf</button>
<button type="button" onclick="exportAnnotation()">Export Annoatation</button>
<button type="button" onclick="importAnnotation()">Import Annoatation</button>

<div style="width:100%;height:600px">
    <ejs-pdfviewer id="pdfviewer"
                   style="height:600px"
                   documentPath="https://cdn.syncfusion.com/content/pdf/pdf-succinctly.pdf">
    </ejs-pdfviewer>
</div>

<script type ="text/javascript">

     var exportObject;
    //Export annotation as Json
    function exportAsJson(){
        var viewer = document.getElementById('pdfviewer').ej2_instances[0];
        viewer.exportAnnotation('Json');
    }
    //Export annotation as Xfdf
    function exportAsXfdf(){
        var viewer = document.getElementById('pdfviewer').ej2_instances[0];
        viewer.exportAnnotation('Xfdf');
    }
    //Export annotation as object.
    function exportAnnotation() {
        var viewer = document.getElementById('pdfviewer').ej2_instances[0];
        viewer.exportAnnotationsAsObject().then(function (value) {
            exportObject = value
        });
    }
    //Import annotation that are exported as object.
    function importAnnotation() {
        var viewer = document.getElementById('pdfviewer').ej2_instances[0];
        viewer.importAnnotation(JSON.parse(exportObject));
    }
</script>

{% endhighlight %}
{% highlight cshtml tabtitle="Server-Backed" %}

@page "{handler?}"
@model IndexModel
@{
    ViewData["Title"] = "Home page";
}

<button type="button" onclick="exportAsJson()">Export Annoatation As Json</button>
<button type="button" onclick="exportAsXfdf()">Export Annoatation As Xfdf</button>
<button type="button" onclick="exportAnnotation()">Export Annoatation</button>
<button type="button" onclick="importAnnotation()">Import Annoatation</button>

<div style="width:100%;height:600px">
    <ejs-pdfviewer id="pdfviewer"
                   style="height:600px"
                   serviceUrl= "/Index"
                   documentPath="https://cdn.syncfusion.com/content/pdf/pdf-succinctly.pdf">
    </ejs-pdfviewer>
</div>

<script type ="text/javascript">

     var exportObject;
    //Export annotation as Json
    function exportAsJson(){
        var viewer = document.getElementById('pdfviewer').ej2_instances[0];
        viewer.exportAnnotation('Json');
    }
    //Export annotation as Xfdf
    function exportAsXfdf(){
        var viewer = document.getElementById('pdfviewer').ej2_instances[0];
        viewer.exportAnnotation('Xfdf');
    }
    //Export annotation as object.
    function exportAnnotation() {
        var viewer = document.getElementById('pdfviewer').ej2_instances[0];
        viewer.exportAnnotationsAsObject().then(function (value) {
            exportObject = value
        });
    }
    //Import annotation that are exported as object.
    function importAnnotation() {
        var viewer = document.getElementById('pdfviewer').ej2_instances[0];
        viewer.importAnnotation(JSON.parse(exportObject));
    }
</script>

{% endhighlight %}
{% endtabs %}

[View sample in GitHub](https://github.com/SyncfusionExamples/asp-core-pdf-viewer-examples/tree/master/How%20to/Import%20and%20Export%20annotation%20as%20object)