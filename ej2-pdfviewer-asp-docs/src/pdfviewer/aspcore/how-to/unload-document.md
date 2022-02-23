---
title: "Unload the PDF document programmatically"
component: "PDF Viewer"
description: "Learn how to unload the PDF document programmatically in PDF Viewer control."
---

# Unload the PDF document programmatically

The PDF Viewer library allows you to unload the PDF document being displayed in the PDF Viewer control programmatically using the [**unload()**](https://ej2.syncfusion.com/documentation/api/pdfviewer/#unload) method.

The following steps are used to unload the PDF document programmatically.

**Step 1:** Follow the steps provided in the [link](https://ej2.syncfusion.com/aspnetcore/documentation/pdfviewer/getting-started/) to create a simple PDF Viewer sample.

**Step 2:** Add the following code snippet to perform the unload operation.

```html
<button type="button" onclick="unload()">Unload Document</button>

<script>
    // Unload the PDF document.
    function unload() {
        var viewer = document.getElementById('pdfViewer').ej2_instances[0];
        viewer.unload();
    }
</script>
```

Download the Sample, [how to unload the PDF document programmatically](https://www.syncfusion.com/downloads/support/directtrac/general/ze/EJ2CoreSample1768814962.zip)