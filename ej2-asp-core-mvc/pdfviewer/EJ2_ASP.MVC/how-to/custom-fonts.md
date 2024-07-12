---
layout: post
title: Add the custom fonts during the initial loading | Syncfusion
description: Learn here all about Custom Fonts in ASP.NET MVC PDF Viewer component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Custom Fonts
publishingplatform: ej2-asp-core-mvc
documentation: ug
---

# Add the custom fonts during the initial loading

To add a custom fonts in the Syncfusion PDF viewer, you need to add the custom font TTF files to the correct directory and configure the viewer to load these fonts. You can add the custom fonts by using the **customFonts** property. This property consists of an array of font path locations as strings.

The following steps are used to customize the selection border.

**Step 1:** We need to add the custom font TTF file to the **src/pdfviewer/ej2-pdfviewer-lib** directory.

**Step 2:** The following code snippet are how you can add the custom fonts during the initial loading.

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