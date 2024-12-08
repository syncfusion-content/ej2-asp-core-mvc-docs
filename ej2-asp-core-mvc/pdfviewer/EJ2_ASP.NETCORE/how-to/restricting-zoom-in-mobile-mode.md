---
layout: post
title: Restrict Zoom Percentage in ##Platform_Name## PDF Viewer Component| Syncfusion 
description: Learn here all about how to restrict zoom percentage in Syncfusion ##Platform_Name## PDF Viewer component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: PDF Viewer
publishingplatform: ##Platform_Name##
documentation: ug
---

# How to Restrict Zoom Percentage on Mobile Devices

In Syncfusion<sup style="font-size:70%">&reg;</sup> PDF Viewer, you can easily restrict the zoom percentage on mobile devices using the **maxZoom** and **minZoom** property. This feature allows you to set specific limits for zooming, ensuring smoother scrolling performance and efficient document loading, on mobile devices.

{% tabs %}
{% highlight html tabtitle="Standalone" %}

<div style="width:100%;height:600px">
    <ejs-pdfviewer id="pdfviewer"
                   style="height:600px"
                   documentPath="https://cdn.syncfusion.com/content/pdf/pdf-succinctly.pdf">
    </ejs-pdfviewer>
</div>

<script>
    function documentLoad() {
        var viewer = document.getElementById('pdfviewer').ej2_instances[0];
        if (ej2_base_1.Browser.isDevice && !viewer.enableDesktopMode) {
            viewer.maxZoom = 200;
            viewer.minZoom = 10;
        }
       else {
            viewer.zoomMode = 'Default';
        }
    }
</script>

{% endhighlight %}
{% highlight html tabtitle="Server-Backed" %}

<div style="width:100%;height:600px">
    <ejs-pdfviewer id="pdfviewer"
                   style="height:600px"
                   serviceUrl="/api/PdfViewer"
                   documentPath="https://cdn.syncfusion.com/content/pdf/pdf-succinctly.pdf">
    </ejs-pdfviewer>
</div>

<script>
    function documentLoad() {
        var viewer = document.getElementById('pdfviewer').ej2_instances[0];
        if (ej2_base_1.Browser.isDevice && !viewer.enableDesktopMode) {
            viewer.maxZoom = 200;
            viewer.minZoom = 10;
        }
       else {
            viewer.zoomMode = 'Default';
        }
    }
</script>

{% endhighlight %}
{% endtabs %}

By implementing this, you ensure that the maximum zoom percentage on mobile devices is limited to 200% and the minimum zoom percentage is set to 10%. This prevents performance issues that may arise from excessive zooming on mobile platforms.

[View sample in GitHub](https://github.com/SyncfusionExamples/asp-core-pdf-viewer-examples/tree/master/How%20to/Restrict%20Zoom%20Percentage%20on%20Mobile%20Devices)
