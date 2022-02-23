---
title: "Capture the current page number being viewed"
component: "PDF Viewer"
description: "Learn how to capture the current page number being viewed in PDF Documents using PDF Viewer control."
---

# Capture the current page number being viewed

The PDF Viewer server library allows you to capture the page number that is currently being viewed in the load PDF document. Use the [**currentPageNumber**](https://ej2.syncfusion.com/javascript/documentation/api/pdfviewer/#currentpagenumber) property to get the page number which is currently in view.

The following steps are used to capture the current page number.

**Step 1:** Follow the steps provided in the [link](https://ej2.syncfusion.com/aspnetcore/documentation/pdfviewer/getting-started/) to create a simple PDF Viewer sample.

**Step 2:** Use the following code snippet to Capture the current page number being viewed.

```html
<button onclick="currentPage()">currentpage</button>

<script>

    function currentPage() {
        var viewer = document.getElementById('pdfviewer').ej2_instances[0];
        var pageNumber = viewer.currentPageNumber;
        alert("current page number is" + pageNumber);
    }

</script>
```

Download the sample [how to capture the current page number being viewed](https://www.syncfusion.com/downloads/support/directtrac/general/ze/EJ2PDFViewer_Core3.0-928043304.zip)