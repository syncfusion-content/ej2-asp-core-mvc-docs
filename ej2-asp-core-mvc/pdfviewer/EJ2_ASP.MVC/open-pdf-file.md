---
layout: post
title: Open PDF files in EJ2 ASP.NET MVC PDF Viewer | Syncfusion
description: Learn here all about Opening PDF in ASP.NET MVC PDF Viewer component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: How to Open PDF From Base64
publishingplatform: ##Platform_Name##
documentation: ug
---

# Opening a PDF from Base64 data in PDF Viewer
### Overview

This guide demonstrates how to load a PDF document from a Base64 string into the Syncfusion PDF Viewer using ASP.NET MVC. This feature is useful for loading PDF data received from a client, database, or other sources where the document is encoded in Base64.

### Opening PDF from Base64 data

**Step 1:** Set Up the PdfViewer in Your ASP.NET MVC Project

 Follow the steps provided in the [link](https://ej2.syncfusion.com/aspnetmvc/documentation/pdfviewer/getting-started) to create a simple PDF Viewer sample.

**Step 2:** Use the following code snippet to load PDF document using base64 string.


{% tabs %}
{% highlight html tabtitle="Standalone" %}

@using Syncfusion.EJ2
@{
    ViewBag.Title = "Home Page";
}
<div>
    <div style="height:500px;width:100%;">
        <button type="button" onclick="LoadFromBase64()">:Load From Base64</button>
        <!-- Render PDF Viewer using the Html helper method -->
        @Html.EJS().PdfViewer("pdfViewer").DocumentPath("https://cdn.syncfusion.com/content/pdf/pdf-succinctly.pdf").ResourceUrl("https://cdn.syncfusion.com/ej2/28.1.33/dist/ej2-pdfviewer-lib").Render()
    </div>
</div>

    <script type="text/javascript">
        //Load PDF document from base64 String
        function LoadFromBase64() {
            var viewer = document.getElementById('pdfViewer').ej2_instances[0];
            //Enter Base64 Data
            viewer.load('Enter Base64 Data',null);
        }
    </script>

{% endhighlight %}
{% endtabs %}

[View sample in GitHub](https://github.com/SyncfusionExamples/mvc-pdf-viewer-examples/tree/master/How%20to)
