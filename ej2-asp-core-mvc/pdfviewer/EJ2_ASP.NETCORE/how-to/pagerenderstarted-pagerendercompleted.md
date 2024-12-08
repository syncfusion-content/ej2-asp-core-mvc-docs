---
layout: post
title: Rendering event in EJ2 ASP.NET Core PDF Viewer | Syncfusion
description: Learn here all about Rendering event in ASP.NET Core Pdfviewer component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: PDF Viewer
publishingplatform: ##Platform_Name##
documentation: ug
---

# PageRenderInitiate and pageRenderComplete event

In Syncfusion<sup style="font-size:70%">&reg;</sup> PDF Viewer, `pageRenderInitiate` and `pageRenderComplete` actions are events that occur during the rendering process of PDF documents. 

**pageRenderInitiate** 

The `pageRenderInitiate` event is triggered when the rendering of a page in the PDF document begins. This event provides developers with an opportunity to perform any necessary initialization or setup before the rendering of the page content commences. It can be utilized to prepare resources, set up rendering parameters, or execute any other actions required before the page rendering process starts.

**pageRenderComplete**

The `pageRenderComplete` event is triggered when the rendering of a page in the PDF document is completed. This event allows developers to perform cleanup tasks or finalize rendering-related processes after the rendering of the page content finishes. It can be used to release resources, finalize rendering settings, or handle any post-rendering tasks necessary for the application.

{% tabs %}
{% highlight cshtml tabtitle="Standalone" %}

@{
    ViewData["Title"] = "Home page";
}

<div style="width:100%;height:600px">
    <ejs-pdfviewer id="pdfviewer"
                   documentPath="https://cdn.syncfusion.com/content/pdf/pdf-succinctly.pdf"
                   resourceUrl="https://cdn.syncfusion.com/ej2/23.2.6/dist/ej2-pdfviewer-lib"
                   pageRenderInitiate="pageRenderInitiate"
                   pageRenderComplete="pageRenderComplete">
    </ejs-pdfviewer>
</div>
<script type="text/javascript">

    function pageRenderInitiate(args) { 
        // This method is called when the page rendering starts
        console.log('Rendering of pages started');
        console.log(args);
    }
    function pageRenderComplete(args) {
        // This method is called when the page rendering completes
        console.log('Rendering of pages completed');
        console.log(args); 
    };

</script>

{% endhighlight %}
{% highlight cshtml tabtitle="Server-Backed" %}

@{
    ViewData["Title"] = "Home page";
}

<div style="width:100%;height:600px">
    <ejs-pdfviewer id="pdfviewer"
                   documentPath="https://cdn.syncfusion.com/content/pdf/pdf-succinctly.pdf"
                   serviceUrl="/Index" 
                   pageRenderInitiate="pageRenderInitiate"
                   pageRenderComplete="pageRenderComplete">
    </ejs-pdfviewer>
</div>
<script type="text/javascript">

    function pageRenderInitiate(args) { 
        // This method is called when the page rendering starts
        console.log('Rendering of pages started');
        console.log(args);
    }
    function pageRenderComplete(args) {
        // This method is called when the page rendering completes
        console.log('Rendering of pages completed');
        console.log(args); 
    };

</script>
{% endhighlight %}
{% endtabs %}

The provided code demonstrates how to subscribe to the `pageRenderInitiate` and `pageRenderComplete` events in the Syncfusion<sup style="font-size:70%">&reg;</sup> PDF Viewer component.