---
layout: post
title: Rendering event in  EJ2 ASP.NET MVC PDF Viewer | Syncfusion
description: Learn here all about Rendering event in ASP.NET MVC PDF Viewer component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: PDF Viewer
publishingplatform: ##Platform_Name##
documentation: ug
---

# PageRenderInitiate and PageRenderComplete event

In Syncfusion<sup style="font-size:70%">&reg;</sup> PDF Viewer, `pageRenderInitiate` and `pageRenderComplete` actions are events that occur during the rendering process of PDF documents. 

**pageRenderInitiate** 

The `pageRenderInitiate` event is triggered when the rendering of a page in the PDF document begins. This event provides developers with an opportunity to perform any necessary initialization or setup before the rendering of the page content commences. It can be utilized to prepare resources, set up rendering parameters, or execute any other actions required before the page rendering process starts.

**pageRenderComplete**

The `pageRenderComplete` event is triggered when the rendering of a page in the PDF document is completed. This event allows developers to perform cleanup tasks or finalize rendering-related processes after the rendering of the page content finishes. It can be used to release resources, finalize rendering settings, or handle any post-rendering tasks necessary for the application.

{% tabs %}
{% highlight html tabtitle="Standalone" %}

@{
    ViewBag.Title = "Home Page";
}

<div style="width:100%;height:600px">
    @Html.EJS().PdfViewer("pdfviewer").DocumentPath("https://cdn.syncfusion.com/content/pdf/hive-succinctly.pdf").PageRenderInitiate("pageRenderInitiate").PageRenderComplete("pageRenderComplete").Render()
</div>

<script>
function pageRenderInitiate(args) { 
   // This method is called when the page rendering starts
    console.log('Rendering of pages started');
    console.log(args);
};

function pageRenderComplete(args) {
   // This method is called when the page rendering completes
   console.log('Rendering of pages completed');
   console.log(args);
};
</script>

{% endhighlight %}
{% highlight html tabtitle="Server-Backed" %}

@{
    ViewBag.Title = "Home Page";
}

<div style="width:100%;height:600px">
    @Html.EJS().PdfViewer("pdfviewer").ServiceUrl(VirtualPathUtility.ToAbsolute("~/api/PdfViewer/")).DocumentPath("https://cdn.syncfusion.com/content/pdf/hive-succinctly.pdf").PageRenderInitiate("pageRenderInitiate").PageRenderComplete("pageRenderComplete").Render()
</div>

<script>
function pageRenderInitiate(args) { 
   // This method is called when the page rendering starts
    console.log('Rendering of pages started');
    console.log(args);
};

function pageRenderComplete(args) {
   // This method is called when the page rendering completes
   console.log('Rendering of pages completed');
   console.log(args);
};
</script>

{% endhighlight %}
{% endtabs %}

The provided code demonstrates how to subscribe to the `pageRenderInitiate` and `pageRenderComplete` events in the Syncfusion<sup style="font-size:70%">&reg;</sup> PDF Viewer component. 

[View sample in GitHub](https://github.com/SyncfusionExamples/mvc-pdf-viewer-examples/tree/master/How%20to/PageRenderStarted%20and%20PageRenderCompleted%20event/PDFViewerSample)