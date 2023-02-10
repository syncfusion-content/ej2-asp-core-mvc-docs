---
layout: post
title: change the default width and height in EJ2 ASP.NET MVC PDF Viewer | Syncfusion
description: Learn here all about how to change the default width and height in ASP.NET MVC PDF Viewer component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: How to change the default width and height
publishingplatform: ej2-asp-core-mvc
documentation: UG
---

# How to change the default width and height

To change the default width and height of the Syncfusion PDF Viewer, you need to modify the `width` and `height` properties of the PDFViewer control.

```html
<div>
    <div style="width:100%;height:600px">
        @Html.EJS().PdfViewer("pdfviewer").ServiceUrl(VirtualPathUtility.ToAbsolute("~/Home/")).DocumentPath("PDF_Succinctly.pdf").Height("1000px").Width("800%").Render()
    </div>
</div>
```

In this example, the Width property is set to `800%` and the Height property is set to `1000px`. You can change these values to any desired size in pixels or percentage.

N> That the Syncfusion PDFViewer control requires a service URL that points to an endpoint that returns the PDF document to be displayed. In the example above, the ServiceUrl property is set to "~/Home/". You will need to modify this URL to match your own service endpoint that returns the PDF document.

[View Sample in GitHub](https://github.com/SyncfusionExamples/mvc-pdf-viewer-examples/tree/EJ2-69063-defaultWidthHeight/How%20to/Change%20Default%20Height%20and%20Width)