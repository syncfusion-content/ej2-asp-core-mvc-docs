---
layout: post
title: Load N number of pages on initial loading in ##Platform_Name## Pdfviewer Component
description: Learn here all about Load N number of pages on initial loading in Syncfusion ##Platform_Name## Pdfviewer component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Load N number of pages on initial loading
publishingplatform: ##Platform_Name##
documentation: ug
---

# Load N number of pages on initial loading

The initial rendering in a PDF viewer allows users to control the number of pages displayed when opening a PDF document. This improves the user experience by providing flexibility in loading a specific number of pages initially, while additional pages are dynamically rendered as the user scrolls through the document. This approach enhances the responsiveness of the PDF viewer and minimizes delays as users can access specific pages without waiting for the entire document to load.

To utilize this capability in Syncfusion<sup style="font-size:70%">&reg;</sup> PDF Viewer, use the [initialRenderPages](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.pdfviewer.pdfviewer.html?_ga=2.144520115.723518961.1687236178-1796867613.1686804317#:~:text=value%20is%20null-,InitialRenderPages,-Initially%20renders%20the) property. You can achieve the desired outcome by setting this property to the desired number of pages you want to load initially. However, it's important to exercise caution when setting a high value for the initialRenderPages in large documents with numerous pages. Rendering a large number of pages simultaneously can increase memory usage and slow down loading times, impacting the performance of the PDF viewer.

Using the `initialRenderPages` property judiciously is advisable, especially when dealing with larger documents. It is more suitable for scenarios where a smaller range of pages, such as 10-20, can be loaded to provide a quick initial view of the document.

{% tabs %}
{% highlight cshtml tabtitle="Standalone" %}

@{
    ViewData["Title"] = "Home page";
    double InitialRenderPages = 5;
}

<div class="text-center">
    <ejs-pdfviewer 
        id="pdfviewer" 
        style="height:600px" 
        initialRenderPages="@InitialRenderPages" 
        documentPath="https://cdn.syncfusion.com/content/pdf/pdf-succinctly.pdf">
    </ejs-pdfviewer>
</div>

{% endhighlight %}
{% highlight cshtml tabtitle="Server-Backed" %}

@{
    ViewData["Title"] = "Home page";
    double InitialRenderPages = 5;
}

<div class="text-center">
    <ejs-pdfviewer 
        id="pdfviewer" 
        style="height:600px" 
        serviceUrl="/Index" 
        initialRenderPages="@InitialRenderPages" 
        documentPath="https://cdn.syncfusion.com/content/pdf/pdf-succinctly.pdf">
    </ejs-pdfviewer>
</div>
{% endhighlight %}
{% endtabs %}


[View sample in GitHub](https://github.com/SyncfusionExamples/asp-core-pdf-viewer-examples/tree/master/How%20to/Load%20N%20no%20of%20pages)