---
title: "Download"
component: "PDF Viewer"
description: "Learn about download option in PDF Viewer to download the loaded document."
---
# Download

The PDF Viewer supports downloading the loaded PDF file. You can enable/disable the download using the following code snippet.

```html
    <div style="width:100%;height:600px">
          @Html.EJS().PdfViewer("pdfviewer").ServiceUrl(VirtualPathUtility.ToAbsolute("~/api/PdfViewer/")).EnableDownload(true).DocumentPath("Hive_Succinctly.pdf").Render()
    </div>
```

![Alt text](./images/download.png)

You can invoke download action using following code snippet.,

```html
<script>
    window.onload = function () {
        var pdfViewer = document.getElementById('pdfviewer').ej2_instances[0];
        pdfViewer.download();
    }
</script>

```

## See also

* [Toolbar items](./toolbar)
* [Feature Modules](./feature-module)