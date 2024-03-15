---
layout: post
title: PageRenderInitiate and PageRenderComplete event in ##Platform_Name## PDF Viewer Component
description: Learn here all about PageRenderInitiate and PageRenderComplete event in Syncfusion ##Platform_Name## PDF Viewer component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: PDF Viewer
publishingplatform: ##Platform_Name##
documentation: ug
---

# PageRenderInitiate and PageRenderComplete event

In Syncfusion PDF Viewer, `pageRenderInitiate` and `pageRenderComplete` actions are events that occur during the rendering process of PDF documents. 

**pageRenderInitiate** 

The `pageRenderInitiate` event is triggered when the rendering of a page in the PDF document begins. This event provides developers with an opportunity to perform any necessary initialization or setup before the rendering of the page content commences. It can be utilized to prepare resources, set up rendering parameters, or execute any other actions required before the page rendering process starts.

**pageRenderComplete**

The `pageRenderComplete` event is triggered when the rendering of a page in the PDF document is completed. This event allows developers to perform cleanup tasks or finalize rendering-related processes after the rendering of the page content finishes. It can be used to release resources, finalize rendering settings, or handle any post-rendering tasks necessary for the application.


{% tabs %}
{% highlight html tabtitle="Standalone" %}
\
<div style="width:100%;height:600px">
    @Html.EJS().PdfViewer("pdfviewer").DocumentLoad("download").EnableDownload(true).DocumentPath("https://cdn.syncfusion.com/content/pdf/hive-succinctly.pdf").pageRenderInitiate("pageRenderInitiate").pageRenderComplete("pageRenderComplete").Render()
</div>

<script>
pdfviewer.pageRenderStart = args => {
   // This method is called when the page rendering starts
    console.log('Rendering of pages started' + args);
};

pdfviewer.pageRenderComplete = args => {
   // This method is called when the page rendering completes
   console.log('Rendering of pages completed' + args);
};
</script>

{% endhighlight %}
{% highlight html tabtitle="Server-Backed" %}

<div style="width:100%;height:600px">
    @Html.EJS().PdfViewer("pdfviewer").DocumentLoad("download")..ServiceUrl(VirtualPathUtility.ToAbsolute("~/api/PdfViewer/")).EnableDownload(true).DocumentPath("https://cdn.syncfusion.com/content/pdf/hive-succinctly.pdf").pageRenderInitiate("pageRenderInitiate").pageRenderComplete("pageRenderComplete").Render()
</div>

<script>
pdfviewer.pageRenderStart = args => {
   // This method is called when the page rendering starts
    console.log('Rendering of pages started' + args);
};

pdfviewer.pageRenderComplete = args => {
   // This method is called when the page rendering completes
   console.log('Rendering of pages completed' + args);
};
</script>

{% endhighlight %}
{% endtabs %}

The provided code demonstrates how to subscribe to the `pageRenderInitiate` and `pageRenderComplete` events in the Syncfusion PDF Viewer component. 

[View sample in GitHub]()