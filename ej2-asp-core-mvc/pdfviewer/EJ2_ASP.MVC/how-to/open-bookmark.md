---
layout: post
title: Open and Close Bookmark in EJ2 ASP.NET MVC PDF Viewer | Syncfusion
description: Learn here all about Open and Close Bookmark in ASP.NET MVC PDF Viewer component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: PDF Viewer
publishingplatform: ej2-asp-core-mvc
documentation: ug
---

# Open and Close Bookmark pane programmatically

The PDF Viewer library allows you to open the Bookmark pane programmatically using the **openBookmarkPane()** method.

The following steps are used to open the Bookmark.

**Step 1:** Follow the steps provided in the [link](https://ej2.syncfusion.com/aspnetmvc/documentation/pdfviewer/getting-started/) to create a simple PDF Viewer sample.

**Step 2:** Insert the following code snippet to implement the functionality for opening the Bookmark pane:

```html
<button type="button" onclick="openBookmark()">Open Bookmark Pane</button>

<script>
    function openBookmark() {
        var viewer = document.getElementById('pdfViewer').ej2_instances[0];
        // Open Bookmark pane
        viewer.bookmarkViewModule.openBookmarkPane();
    }
</script>
```

Similarly, to close the Bookmark pane programmatically, employ the following code snippet:

```html
<button type="button" closeBookmark="openBookmark()">Close Bookmark Pane</button>

<script>
    function closeBookmark() {
        var viewer = document.getElementById('pdfViewer').ej2_instances[0];
        // Open Bookmark pane
        viewer.bookmarkViewModule.closeBookmarkPane();
    }
</script>
```

[View sample in GitHub]()