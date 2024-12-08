---
layout: post
title: Load N number of pages on initial loading in EJ2 ASP.NET MVC PDF Viewer | Syncfusion
description: Learn here all about Load N number of pages on initial loading in ASP.NET MVC PDF Viewer component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Load N number of pages on initial loading
publishingplatform: ej2-asp-core-mvc
documentation: ug
---

# Load N number of pages on initial loading

The initial rendering in a PDF viewer allows users to control the number of pages displayed when opening a PDF document. This improves the user experience by providing flexibility in loading a specific number of pages initially, while additional pages are dynamically rendered as the user scrolls through the document. This approach enhances the responsiveness of the PDF viewer and minimizes delays as users can access specific pages without waiting for the entire document to load.

To utilize this capability in Syncfusion<sup style="font-size:70%">&reg;</sup> PDF Viewer, use the [initialRenderPages](https://help.syncfusion.com/cr/aspnetmvc-js2/syncfusion.ej2.pdfviewer.pdfviewer.html#Syncfusion_EJ2_PdfViewer_PdfViewer_InitialRenderPages) property. You can achieve the desired outcome by setting this property to the desired number of pages you want to load initially. However, it's important to exercise caution when setting a high value for the initialRenderPages in large documents with numerous pages. Rendering a large number of pages simultaneously can increase memory usage and slow down loading times, impacting the performance of the PDF viewer.

Using the `initialRenderPages` property judiciously is advisable, especially when dealing with larger documents. It is more suitable for scenarios where a smaller range of pages, such as 10-20, can be loaded to provide a quick initial view of the document.

{% tabs %}
{% highlight html tabtitle="Standalone" %}

```cs
@{
    ViewBag.Title = "Home Page";
    double InitialRenderPages = 10;
}

<div>
    <div style="height:100%; width: 100%;">
        @Html.EJS().PdfViewer("pdfviewer").DocumentPath("https://cdn.syncfusion.com/content/pdf/pdf-succinctly.pdf").InitialRenderPages(InitialRenderPages).Render()
    </div>
</div>
```

{% endhighlight %}
{% highlight html tabtitle="Server-Backed" %}

```cs
@{
    ViewBag.Title = "Home Page";
    double InitialRenderPages = 10;
}

<div>
    <div style="height:100%; width: 100%;">
        @Html.EJS().PdfViewer("pdfviewer").ServiceUrl(VirtualPathUtility.ToAbsolute("~/Home/")).DocumentPath("https://cdn.syncfusion.com/content/pdf/pdf-succinctly.pdf").InitialRenderPages(InitialRenderPages).Render()
    </div>
</div>

```
{% endhighlight %}
{% endtabs %}

[View sample in GitHub](https://github.com/SyncfusionExamples/mvc-pdf-viewer-examples/tree/master/How%20to/Load%20N%20no%20of%20pages)