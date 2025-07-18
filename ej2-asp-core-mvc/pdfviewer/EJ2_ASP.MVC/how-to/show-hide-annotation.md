---
layout: post  
title: Show and Hide Annotations in EJ2 ASP.NET MVC PdfViewer | Syncfusion  
description: Learn how to dynamically show and hide annotations in the Syncfusion ASP.NET MVC PDF Viewer component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Show and Hide Annotations
publishingplatform: ##Platform_Name##
documentation: ug  
---

# Show and Hide Annotations in PDF Viewer

### Overview

This guide demonstrates how to implement functionality to dynamically show and hide annotations in a PDF document loaded in the Syncfusion PDF Viewer using ASP.NET MVC. This feature is particularly useful in scenarios where you need to present a clean view of the document or toggle between annotated and non-annotated views.

### How to Show and Hide Annotations

**Step 1:** Set Up the PdfViewer in Your ASP.NET MVC Project

First, follow the steps provided in the [getting started guide](https://ej2.syncfusion.com/aspnetmvc/documentation/pdfviewer/getting-started) to create a simple PDF Viewer sample.

**Step 2:** Add Toggle Button and Implementation

Add a button to toggle annotation visibility and implement the necessary JavaScript functions to handle the show/hide functionality:

{% tabs %}
{% highlight html tabtitle="Standalone" %}

@using Syncfusion.EJ2
@{
    ViewBag.Title = "Home Page";
}
<div>
    <div class="button-container" style="margin-bottom: 10px;">
        <button id="hideBtn" class="e-btn e-primary">Hide Annotations</button>
        <button id="unhideBtn" class="e-btn e-primary">Show Annotations</button>
    </div>
    <div style="height:500px;width:100%;">
        @Html.EJS().PdfViewer("pdfviewer").DocumentPath("https://cdn.syncfusion.com/content/pdf/pdf-succinctly.pdf").ResourceUrl("https://cdn.syncfusion.com/ej2/30.1.37/dist/ej2-pdfviewer-lib").Render()
    </div>
</div>

<script type="text/javascript">
    var exportObject;
    
    // Function to hide annotations
    function HideAnnotations() {
        var pdfviewer = document.getElementById('pdfviewer').ej2_instances[0];
        pdfviewer.exportAnnotationsAsObject().then(function(value) {
            exportObject = value;
            pdfviewer.deleteAnnotations();
        });
    }
    
    // Function to unhide annotations
    function UnHideAnnotations() {
        var pdfviewer = document.getElementById('pdfviewer').ej2_instances[0];
        if (exportObject) {
            pdfviewer.importAnnotation(JSON.parse(exportObject));
        }
    }
    
    // Add event listeners to buttons
    document.getElementById('hideBtn').addEventListener('click', HideAnnotations);
    document.getElementById('unhideBtn').addEventListener('click', UnHideAnnotations);
</script>

{% endhighlight %}
{% endtabs %}

This implementation provides a clean, efficient way to toggle the visibility of annotations in your PDF documents. It's particularly useful for presentation scenarios or when you need to focus on the document content without the distraction of annotations.

[View sample in GitHub](https://github.com/SyncfusionExamples/mvc-pdf-viewer-examples/tree/master/How%20to)