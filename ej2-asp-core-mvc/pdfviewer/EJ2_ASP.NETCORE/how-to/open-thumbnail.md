---
layout: post
title: Open Thumbnail in ##Platform_Name## Pdfviewer Component
description: Learn here all about Open Thumbnail in Syncfusion ##Platform_Name## Pdfviewer component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Open Thumbnail
publishingplatform: ##Platform_Name##
documentation: ug
---

# Open Thumbnail pane programmatically

The PDF Viewer library allows you to open the thumbnail pane programmatically using the [**openThumbnailPane()**](https://ej2.syncfusion.com/documentation/api/pdfviewer/thumbnailView/#openthumbnailpane) method.

The following steps are used to open the thumbnail.

**Step 1:** Follow the steps provided in the [link](https://ej2.syncfusion.com/aspnetcore/documentation/pdfviewer/getting-started/) to create a simple PDF Viewer sample.

**Step 2:** Use the following code snippet to open thumbnail.

{% tabs %}
{% highlight cshtml tabtitle="Standalone" %}

<button type="button" onclick="openThumbnail()">Open Thumbnail Pane</button>

<div style="width:100%;height:600px">
    <ejs-pdfviewer id="pdfviewer"
                   style="height:600px"
                   documentPath="https://cdn.syncfusion.com/content/pdf/pdf-succinctly.pdf"
                   documentLoad="openThumbnail">
    </ejs-pdfviewer>
</div>

<script>
    function openThumbnail() {
        var pdfViewer = document.getElementById('pdfviewer').ej2_instances[0];
        pdfViewer.thumbnailViewModule.openThumbnailPane();
    }
</script>
{% endhighlight %}
{% highlight cshtml tabtitle="Server-Backed" %}

<button type="button" onclick="openThumbnail()">Open Thumbnail Pane</button>

<div style="width:100%;height:600px">
    <ejs-pdfviewer id="pdfviewer"
                   style="height:600px"
                   serviceUrl='/Index'
                   documentPath="https://cdn.syncfusion.com/content/pdf/pdf-succinctly.pdf"
                   documentLoad="openThumbnail">
    </ejs-pdfviewer>
</div>

<script>
    function openThumbnail() {
        var pdfViewer = document.getElementById('pdfviewer').ej2_instances[0];
        pdfViewer.thumbnailViewModule.openThumbnailPane();
    }
</script>

{% endhighlight %}
{% endtabs %}


[View sample in GitHub](https://github.com/SyncfusionExamples/asp-core-pdf-viewer-examples/tree/master/How%20to/Open%20Thumbnail%20pane%20programmatically)