---
layout: post
title: Open Thumbnail in EJ2 ASP.NET MVC PDF Viewer | Syncfusion
description: Learn here all about Open Thumbnail in ASP.NET MVC PDF Viewer component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Open Thumbnail
publishingplatform: ej2-asp-core-mvc
documentation: ug
---


# Open Thumbnail pane programmatically

The PDF Viewer library allows you to open the thumbnail pane programmatically using the [**openThumbnailPane()**](https://ej2.syncfusion.com/documentation/api/pdfviewer/thumbnailView/#openthumbnailpane) method.

The following steps are used to open the thumbnail.

**Step 1:** Follow the steps provided in the [link](https://ej2.syncfusion.com/aspnetmvc/documentation/pdfviewer/getting-started/) to create a simple PDF Viewer sample.

**Step 2:** Use the following code snippet to open thumbnail.

```html
<button type="button" onclick="openThumbnail()">Open Thumbnail Pane</button>

<script>
    function openThumbnail() {
        var viewer = document.getElementById('pdfViewer').ej2_instances[0];
        // Open Thumbnail Pane.
        viewer.thumbnailViewModule.openThumbnailPane();
    }
</script>
```

Find the sample, [how to open the thumbnail pane programmatically](https://www.syncfusion.com/downloads/support/directtrac/general/ze/EJ2MvcSample1928984973.zip)