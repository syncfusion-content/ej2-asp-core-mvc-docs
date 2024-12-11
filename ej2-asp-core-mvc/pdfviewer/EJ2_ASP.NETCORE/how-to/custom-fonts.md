---
layout: post
title: Add custom fonts to the PDF Viewer using the PDF document | Syncfusion
description: Learn here all about how to add custom fonts using the PDF document in Syncfusion ##Platform_Name## Pdfviewer component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: PDF Viewer
publishingplatform: ##Platform_Name##
documentation: ug
---

# How to add custom fonts to the PDF viewer used in the PDF document

To use custom fonts in the Syncfusion<sup style="font-size:70%">&reg;</sup> PDF Viewer within your PDF document, you need to add the custom TTF font files to the resource URL directory and configure the viewer to load these fonts. You can specify the custom font names using the
**customFonts** property, which accepts an array of font names.

The following steps are used to customize the selection border.

**Step 1:** Add the custom TTF font files to the resource URL path referenced in your application. For example, place the custom TTF files in the ej2-pdfviewer-lib folder, which will serve as the resource URL path.

**Step 2:** The following code snippet are how you can add custom fonts to the PDF viewer.

```html

<div style="width:100%;height:600px">
    <button id="loadPDF Viewer">Load PDF Viewer</button>
    <div id="pdfViewer" style="height: 100%;width: 100%;"></div>
</div>

<script>
    document.getElementById("loadPDF Viewer").addEventListener('click', function () {
        $.ajax({
            url: 'https://localhost:44327/pdfviewer/GetPdfDocument',
            type: "GET",
            success: function (data) {
                var viewer = new ej.pdfviewer.PdfViewer({
                    documentPath: data,
                });
                viewer.customFonts = ["arialbd.ttf", "arial.ttf", "BKANT.TTF", "calibri.ttf", "GARA.TTF", "GARAIT.TTF", "msgothic.ttc", "trebuc.ttf", "wingding.ttf"];
                viewer.appendTo("#pdfViewer");
            }
        });
    });
</script>

```

By following these steps, you can successfully integrate and use custom fonts in your PDF documents displayed in the EJ2 PDF Viewer.