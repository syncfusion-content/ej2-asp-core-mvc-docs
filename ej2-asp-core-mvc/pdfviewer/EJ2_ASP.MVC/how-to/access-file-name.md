---
layout: post
title: Access FileName in ##Platform_Name## Pdfviewer Component | Syncfusion
description: Learn here all about Access File Name in Syncfusion ##Platform_Name## Pdfviewer component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Access File Name
publishingplatform: ##Platform_Name##
documentation: ug
---


# Access file name in ##Platform_Name## Pdfviewer Component

The PDF Viewer server library allows you to can access the filename of the loaded PDF document using the [**documentLoad**](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PdfViewer.PdfViewer.html#Syncfusion_EJ2_PdfViewer_PdfViewer_DocumentLoad) and [**downloadEnd**](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PdfViewer.PdfViewer.html#Syncfusion_EJ2_PdfViewer_PdfViewer_DownloadEnd) event. Using these events, we can access the filename while loading and downloading the PDF document.

The following steps are used to access the file name of loaded PDF document in PDF viewer control,

**Step 1:** Follow the steps provided in the [link](https://ej2.syncfusion.com/aspnetmvc/documentation/pdfviewer/getting-started/) to create simple PDF Viewer sample.

**Step 2:** Access file name using below code snippet,

{% tabs %}
{% highlight html tabtitle="Standalone" %}

```html
@Html.EJS().PdfViewer("pdfviewer").DocumentPath("https://cdn.syncfusion.com/content/pdf/hive-succinctly.pdf").DocumentLoad("documentLoad").DownloadEnd("documentLoad").Render()

<script>
    function documentLoad(args) {
        var viewer = document.getElementById('pdfviewer').ej2_instances[0];
        args.fileName = "pdfsuccintly.pdf";
        //Sets the name of the file to be downloaded
        viewer.downloadFileName = "pdfsuccintly.pdf";
        console.log(args);
    }
</script>

```
{% endhighlight %}
{% highlight html tabtitle="Server-Backed" %}

```html
@Html.EJS().PdfViewer("pdfviewer").DocumentPath("https://cdn.syncfusion.com/content/pdf/hive-succinctly.pdf").ServiceUrl(VirtualPathUtility.ToAbsolute("~/PdfViewer/")).DocumentLoad("documentLoad").DownloadEnd("documentLoad").Render()

<script>
    function documentLoad(args) {
        var viewer = document.getElementById('pdfviewer').ej2_instances[0];
        args.fileName = "pdfsuccintly.pdf";
        //Sets the name of the file to be downloaded
        viewer.downloadFileName = "pdfsuccintly.pdf";
        console.log(args);
    }
</script>
```
{% endhighlight %}
{% endtabs %}

Download the sample [how to access file name](https://www.syncfusion.com/downloads/support/directtrac/general/ze/MVC_SAMPLE-609765609)