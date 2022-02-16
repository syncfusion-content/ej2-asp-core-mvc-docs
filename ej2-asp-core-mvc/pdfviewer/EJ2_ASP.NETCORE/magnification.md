---
layout: post
title: Magnification in ##Platform_Name## Pdfviewer Component
description: Learn here all about Magnification in Syncfusion ##Platform_Name## Pdfviewer component and more.
platform: ej2-asp-core-mvc
control: Magnification
publishingplatform: ##Platform_Name##
documentation: ug
---


# Magnification

The magnification tools of the PDF Viewer contains ZoomIn, ZoomOut, Zoom, FitPage, and FitWidth tools in the
default toolbar. The PDF Viewer also has an option to show or hide the magnification tools in the
default toolbar.

The following code snippet describes how to enable the magnification in PDF Viewer.

```html
    <div style="width:100%;height:600px">
        <ejs-pdfviewer id="pdfviewer"
                style="height:600px"
                serviceUrl="/api/PdfViewer"
                documentPath=@ViewBag.DocumentPath
                enableMagnification="true">
        </ejs-pdfviewer>
    </div>
```

The following magnification options are available in the default toolbar of PDF Viewer,

* **ZoomIn**:- Zoom in from the current zoom value of PDF pages.
* **ZoomOut**:- Zoom out from the current zoom value of PDF pages.
* **Zoom**:- Zoom to specific zoom value of PDF pages.
* **FitPage**:- Fits the page width with in the available view port size.
* **FitWidth**:- Fits the view port width based on the page content size.
* **Auto**:- Fits the page content with-in the viewport on resizing action.

![Alt text ](./images/zoom.png)

>PDF Viewer can support the zoom value ranges from 50 to 400.

## See also

* [Toolbar items](./toolbar)
* [Feature Modules](./feature-module)