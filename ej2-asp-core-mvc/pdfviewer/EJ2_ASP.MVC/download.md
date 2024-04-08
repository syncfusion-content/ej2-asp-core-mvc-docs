---
layout: post
title: Download in ASP.NET MVC PDF Viewer Component | Syncfusion
description: Learn here all about download in Syncfusion ASP.NET MVC PDF Viewer component, it's elements and more.
platform: ej2-asp-core-mvc
control: Download
publishingplatform: ej2-asp-core-mvc
documentation: ug
---

# Download a PDF document in PDF Viewer component

The PDF Viewer supports downloading the loaded PDF file. You can enable/disable the download using the following code snippet.

{% tabs %}
{% highlight html tabtitle="Standalone" %}
```html
<div style="width:100%;height:600px">
    @Html.EJS().PdfViewer("pdfviewer").DocumentLoad("download").EnableDownload(true).DocumentPath("https://cdn.syncfusion.com/content/pdf/hive-succinctly.pdf").Render()
</div>

<script>
    function download() {
        var pdfViewer = document.getElementById('pdfviewer').ej2_instances[0];
        pdfViewer.download();
    }
</script>
```
{% endhighlight %}
{% highlight html tabtitle="Server-Backed" %}
```html
<div style="width:100%;height:600px">
    @Html.EJS().PdfViewer("pdfviewer").DocumentLoad("download")..ServiceUrl(VirtualPathUtility.ToAbsolute("~/api/PdfViewer/")).EnableDownload(true).DocumentPath("https://cdn.syncfusion.com/content/pdf/hive-succinctly.pdf").Render()
</div>

<script>
    function download() {
        var pdfViewer = document.getElementById('pdfviewer').ej2_instances[0];
        pdfViewer.download();
    }
</script>
```
{% endhighlight %}
{% endtabs %}

![Alt text](./images/download.png)

## See also

* [Toolbar items](./toolbar)
* [Feature Modules](./feature-module)