---
layout: post
title: Export As Image in EJ2 ASP.NET Core PDF Viewer | Syncfusion
description: Learn here all about Export As Image in Syncfusion ##Platform_Name## Pdfviewer component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: PDF Viewer
publishingplatform: ##Platform_Name##
documentation: ug
---

# Export As Image from PDF document

The PDF Viewer library allows you to export specified pages as a Base64-encoded image string using the **exportAsImage()** method and exporting a range of pages as Base64-encoded image strings using the **exportAsImages()** method.

The following steps are used to exportAsImage.

**Step 1:** Follow the steps provided in the [link](https://ej2.syncfusion.com/aspnetcore/documentation/pdfviewer/getting-started/) to create a simple PDF Viewer sample.

**Step 2:** The following code snippet to implement the functionality for exporting a specified page as a Base64-encoded image string or exporting a range of pages as Base64-encoded image strings.

{% tabs %}
{% highlight cshtml tabtitle="Standalone" %}

<button type="button" onclick="exportAsImage()">ExportAsImage</button>
<div style="width:100%;height:600px">
    @Html.EJS().PdfViewer("pdfviewer").DocumentPath("https://cdn.syncfusion.com/content/pdf/hive-succinctly.pdf").Render()
</div>

<script>
    function exportAsImage() {
        var imageDetail;
        var pageIndex = 1;
        var viewer = document.getElementById('pdfviewer').ej2_instances[0];
        viewer.exportAsImage(pageIndex).then(function (value) {
            imageDetail = value;
            console.log(imageDetail);
        });
    }
</script>

{% endhighlight %}
{% endtabs %}

Similarly, to code snippet for exports the specified page as a Base64-encoded image string, allowing for custom image size:

{% tabs %}
{% highlight cshtml tabtitle="Standalone" %}

<button type="button" onclick="exportAsImageWithSize()">ExportAsImageWithSize</button>
<div style="width:100%;height:600px">
    @Html.EJS().PdfViewer("pdfviewer").DocumentPath("https://cdn.syncfusion.com/content/pdf/hive-succinctly.pdf").Render()
</div>

<script>
 function exportAsImageWithSize() {
        let imageDetail;
        let pageIndex = 1;
        let size: Size = new Size(200,500);
        var viewer = document.getElementById('pdfviewer').ej2_instances[0];
        viewer.exportAsImage(pageIndex,size).then(function (value) {
            imageDetail = value;
            console.log(imageDetail);
        });
    }
</script>

{% endhighlight %}
{% endtabs %}

Similarly, to code snippet for exports the range of pages as Base64-encoded image strings:

{% tabs %}
{% highlight cshtml tabtitle="Standalone" %}

<button type="button" onclick="exportAsImages()">ExportAsImages</button>
<div style="width:100%;height:600px">
    @Html.EJS().PdfViewer("pdfviewer").DocumentPath("https://cdn.syncfusion.com/content/pdf/hive-succinctly.pdf").Render()
</div>

<script>
 function exportAsImages() {
    let startPageIndex: number = 1;
    let endPageIndex: number = 5;
     var viewer = document.getElementById('pdfviewer').ej2_instances[0];
    viewer.exportAsImages(startPageIndex, endPageIndex).then(function (value) {
        imageDetails = value;
        console.log(imageDetails);
    });
}
</script>

{% endhighlight %}
{% endtabs %}

Similarly, to code snippet for exports the range of pages as Base64-encoded image strings, allowing for custom image size:

{% tabs %}
{% highlight cshtml tabtitle="Standalone" %}

<button type="button" onclick="exportAsImageWithSize()">ExportAsImageWithSize</button>
<div style="width:100%;height:600px">
    @Html.EJS().PdfViewer("pdfviewer").DocumentPath("https://cdn.syncfusion.com/content/pdf/hive-succinctly.pdf").Render()
</div>

<script>
 function exportAsImageWithSize() {
        let startPageIndex: number = 1;
        let endPageIndex: number = 5;
        let size: Size = new Size(200,500);
        var pdfViewer = document.getElementById('pdfviewer').ej2_instances[0];
        viewer.exportAsImages(startPageIndex, endPageIndex, size).then(function (value) {
            imageDetails = value;
            console.log(imageDetails);
        });
    }
</script>

{% endhighlight %}
{% endtabs %}

By following these steps, you can successfully integrate and use the export as image API in the EJ2 PDF Viewer.