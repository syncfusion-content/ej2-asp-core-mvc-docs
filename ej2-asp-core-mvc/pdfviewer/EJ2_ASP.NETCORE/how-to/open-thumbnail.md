---
layout: post
title: Open Thumbnail in ##Platform_Name## Pdfviewer Component
description: Learn here all about Open Thumbnail in Syncfusion ##Platform_Name## Pdfviewer component and more.
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

Find the sample, [how to open the thumbnail pane programmatically](https://www.syncfusion.com/downloads/support/directtrac/general/ze/EJ2CoreSample-1092111159.zip)