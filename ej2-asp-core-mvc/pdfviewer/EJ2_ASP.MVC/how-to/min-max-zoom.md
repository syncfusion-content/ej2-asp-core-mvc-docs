---
layout: post
title: Minimum and Maximum Zoom in EJ2 ASP.NET MVC PDF Viewer | Syncfusion
description: Learn here all about Minimum and Maximum Zoom in ASP.NET MVC PDF Viewer component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: PDF Viewer
publishingplatform: ##Platform_Name##
documentation: ug
---

# Minimum and Maximum Zoom Properties

The Syncfusion<sup style="font-size:70%">&reg;</sup> PDF Viewer provides the ability to control zoom levels for viewing PDF documents. The `minZoom` and `maxZoom` properties enable developers to set the minimum and maximum zoom levels, ensuring a consistent and controlled viewing experience.

### minZoom

The `minZoom` property specifies the minimum zoom percentage allowed in the PDF Viewer. This ensures that users cannot zoom out beyond a certain limit, which helps maintain readability and performance. Developers can set the `minZoom` property programmatically, defining the minimum zoom level based on the application's requirements. This is particularly useful for preventing users from zooming out too much, which could make the content difficult to read.

### maxZoom

The `maxZoom` property defines the maximum zoom percentage allowed in the PDF Viewer. By setting this property, developers can prevent users from zooming in too much, helping to avoid performance issues and maintain a smooth viewing experience. The `maxZoom` property can be set programmatically to control the upper limit of the zoom level. This is useful for applications where extremely high zoom levels might degrade performance or user experience.

```cs

@{
    ViewBag.Title = "Home Page";
    double maxZoom = 200;
    double minZoom = 20;
}

<div>
    <div style="height:100%; width: 100%;">
        @Html.EJS().PdfViewer("pdfviewer").ServiceUrl(VirtualPathUtility.ToAbsolute("~/Home/")).DocumentPath("PDF_Succinctly.pdf").MaxZoom(maxZoom).MinZoom(minZoom).Render()
    </div>
</div>
```

#### Restrict Zoom Percentage on Mobile Devices

You can easily restrict the zoom percentage on mobile devices using the `minZoom` and `maxZoom` properties. This feature allows you to set specific limits for zooming, ensuring smoother scrolling performance and efficient document loading on mobile devices. By controlling the zoom levels, you can provide a better user experience across different devices.

{% tabs %}
{% highlight html tabtitle="Standalone" %}

<div style="width:100%;height:600px">
    @Html.EJS().PdfViewer("pdfviewer").DocumentLoad("documentLoad").DocumentPath("https://cdn.syncfusion.com/content/pdf/hive-succinctly.pdf").Render()
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
    @Html.EJS().PdfViewer("pdfviewer").ServiceUrl(VirtualPathUtility.ToAbsolute("~/api/PdfViewer/")).DocumentLoad("documentLoad").DocumentPath("https://cdn.syncfusion.com/content/pdf/hive-succinctly.pdf").Render()
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