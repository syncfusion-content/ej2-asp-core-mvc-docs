---
layout: Post
title: How to change default size in EJ2 ASP.NET MVC PDF Viewer | Syncfusion
description: Learn how to change the default width and height in the ASP.NET MVC PDF Viewer component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: How to change the default width and height
publishingplatform: ej2-asp-core-mvc
documentation: UG
---

# How to change the default width and height

To change the default width and height of the Syncfusion PDF Viewer, modify the `width` and `height` properties of the PDFViewer control.

```html
<div>
    <div style="width:100%;height:600px">
        @Html.EJS().PdfViewer("pdfviewer").ServiceUrl(VirtualPathUtility.ToAbsolute("~/Home/")).DocumentPath("PDF_Succinctly.pdf").Height("1000px").Width("80%").Render()
    </div>
</div>
```
In this example, the Width property is set to `80%`, and the Height property is set to `1000px`. Change these values to any desired size in pixels or percentages.

N> The Syncfusion PDFViewer control requires a service URL that points to an endpoint that returns a PDF document to be displayed. In the example above, the ServiceUrl property is set to "~/Home/." Modify this URL to match your service endpoint that returns a PDF document.

[View sample in GitHub](https://github.com/SyncfusionExamples/mvc-pdf-viewer-examples/tree/EJ2-69063-defaultWidthHeight/How%20to/Change%20Default%20Height%20and%20Width)