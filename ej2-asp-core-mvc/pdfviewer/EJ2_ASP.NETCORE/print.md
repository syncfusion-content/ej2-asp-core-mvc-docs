---
layout: post
title: Print in ##Platform_Name## Pdfviewer Component
description: Learn here all about Print in Syncfusion ##Platform_Name## Pdfviewer component and more.
platform: ej2-asp-core-mvc
control: Print
publishingplatform: ##Platform_Name##
documentation: ug
---

# Print

The PDF Viewer supports printing the loaded PDF file. You can enable/disable the print using the following code snippet.

```html
    <div style="width:100%;height:600px">
        <ejs-pdfviewer id="pdfviewer"
                style="height:600px"
                serviceUrl="/api/PdfViewer"
                documentPath=@ViewBag.DocumentPath
                enablePrint="true">
        </ejs-pdfviewer>
    </div>
```

![Alt text](./images/print.png)

You can invoke print action using the following code snippet.,

```html
<script>
    window.onload = function () {
        var pdfViewer = document.getElementById('pdfviewer').ej2_instances[0];
        pdfViewer.print.print();
    }
</script>

```

## See also

* [Toolbar items](./toolbar)
* [Feature Modules](./feature-module)