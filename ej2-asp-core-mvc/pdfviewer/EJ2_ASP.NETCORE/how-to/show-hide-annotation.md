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

###  How to Show and Hide Annotations

**Step 1:** Set up the PDF Viewer in your ASP.NET Core project

First, create a basic PDF Viewer implementation in your ASP.NET Core application.

**Step 2:** Add a toggle button and implement the show/hide functionality

Add a button that allows users to toggle the visibility of annotations within the PDF document.

{% tabs %}
{% highlight cshtml tabtitle="Standalone" %}

@page "{handler?}"
@using ShowHideAnnotations.Pages
@model IndexModel
@{
ViewData["Title"] = "Home page";
}
<div class="text-center">
    <button id="hideBtn">Hide Annotations</button>
    <button id="unhideBtn">Show Annotations</button>
    <ejs-pdfviewer id="pdfviewer" style="height:600px" resourceUrl="https://cdn.syncfusion.com/ej2/30.1.37/dist/ej2-pdfviewer-lib" documentPath="https://cdn.syncfusion.com/content/pdf/pdf-succinctly.pdf">
</ejs-pdfviewer>
</div>
<script type="text/javascript">
    var exportObject = null;
    document.addEventListener('DOMContentLoaded', function() {
    var pdfviewer = document.getElementById('pdfviewer').ej2_instances[0];
        function HideAnnotations() {
            pdfviewer.exportAnnotationsAsObject().then(function(value) {
            exportObject = value;
        pdfviewer.deleteAnnotations();
    });
    }
    function UnHideAnnotations() {
        if (exportObject) {
        pdfviewer.importAnnotation(JSON.parse(exportObject));
        }
    }
    document.getElementById('hideBtn').addEventListener('click', HideAnnotations);
    document.getElementById('unhideBtn').addEventListener('click', UnHideAnnotations);
    });
</script>

{% endhighlight %}
{% endtabs %}

This implementation provides a clean, efficient way to toggle the visibility of annotations in your PDF documents. It's particularly useful for presentation scenarios or when you need to focus on the document content without the distraction of annotations.

[View sample in GitHub](https://github.com/SyncfusionExamples/asp-core-pdf-viewer-examples/tree/master/How%20to/ShowHideAnnotations)