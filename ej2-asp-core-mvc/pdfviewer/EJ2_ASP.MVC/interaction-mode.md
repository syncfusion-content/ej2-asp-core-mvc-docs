---
layout: post
title: Interaction_mode in ##Platform_Name## Pdfviewer Component
description: Learn here all about Interaction_mode in Syncfusion ##Platform_Name## Pdfviewer component and more.
platform: ej2-asp-core-mvc
control: Interaction_mode
publishingplatform: ##Platform_Name##
documentation: ug
---


# Interaction Mode

The PDF Viewer provides interaction mode for easy interaction with the loaded PDF document.  Selection mode and panning mode are the two interactions modes.

## Selection mode

In this mode, the text selection can be performed in the PDF document loaded in PDF Viewer. The panning and scrolling of the pages by touch cannot be performed in this mode. It allows users to select and copy text from the PDF files. This is helpful for copying and sharing text content. You can enable/disable the text selection using the following code snippet.

```html
    <div style="width:100%;height:600px">
        @Html.EJS().PdfViewer("pdfviewer").ServiceUrl(VirtualPathUtility.ToAbsolute("~/api/PdfViewer/")).EnableTextSelection(true).DocumentPath("Hive_Succinctly.pdf").Render()
    </div>
```

![Alt text](./images/selection.png)

## Panning Mode

In this mode, the panning and scrolling of the pages by touch can be performed in the PDF document loaded in the PDF Viewer, but the text selection cannot be performed.

![Alt text](./images/pan.png)

You can switch the interaction mode of PDF Viewer by using the following code snippet.,

```html
    <div style="width:100%;height:600px">
     @Html.EJS().PdfViewer("pdfviewer").ServiceUrl(VirtualPathUtility.ToAbsolute("~/api/PdfViewer/")).InteractionMode(Syncfusion.EJ2.PdfViewer.InteractionMode.Pan).DocumentPath("Hive_Succinctly.pdf").Render()
    </div>
```

## See also

* [Toolbar items](./toolbar)
* [Feature Modules](./feature-module)