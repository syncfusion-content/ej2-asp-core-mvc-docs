---
layout: post
title: Open PDF files in EJ2 ASP.NET CORE PDF Viewer | Syncfusion
description: Learn here all about Opening PDF in ASP.NET CORE PDF Viewer component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: PDF Viewer
publishingplatform: ##Platform_Name##
documentation: ug  
---

# Opening a PDF from Base64 data in PDF Viewer
### Overview

This guide demonstrates how to load a PDF document from a Base64 string into the Syncfusion PDF Viewer using ASP.NET CORE. This feature is useful for loading PDF data received from a client, database, or other sources where the document is encoded in Base64.

### Opening PDF from Base64 data

**Step 1:** Set Up the PdfViewer in Your ASP.NET CORE Project

Follow the steps provided in the [link](https://ej2.syncfusion.com/aspnetcore/documentation/pdfviewer/getting-started) to create a simple PDF Viewer sample.

**Step 2:** Use the following code snippet to load PDF document using base64 string.


{% tabs %}
{% highlight html tabtitle="Standalone" %}

@page "{handler?}"
@model IndexModel
@{
    ViewData["Title"] = "Home page";
}

<div class="text-center">
    <button type="button" id="loadButton">Load PDF from Base64</button>
    <ejs-pdfviewer id="pdfviewer" style="height:600px" resourceUrl="https://cdn.syncfusion.com/ej2/28.1.33/dist/ej2-pdfviewer-lib" documentPath="https://cdn.syncfusion.com/content/pdf/pdf-succinctly.pdf">
    </ejs-pdfviewer>
</div>

<script type="text/javascript">
    document.getElementById('loadButton').addEventListener('click', function () {
        var pdfViewer = document.getElementById('pdfviewer').ej2_instances[0];
            //Enter the base 64 Data 
           var base64String = 'Enter Base64 Data';
           // Load the PDF document using the load() method with Base64 string
           pdfViewer.load(base64String, null); // Pass null for filename if not required
       });
</script>

{% endhighlight %}
{% endtabs %}

[View sample in GitHub](https://github.com/SyncfusionExamples/asp-core-pdf-viewer-examples/tree/master/How%20to)
