---
layout: post
title: Toolbar in ##Platform_Name## Pdfviewer Component
description: Learn here all about Toolbar in Syncfusion ##Platform_Name## Pdfviewer component and more.
platform: ej2-asp-core-mvc
control: Toolbar
publishingplatform: ##Platform_Name##
documentation: ug
---


# Built-in toolbar

The PDF Viewer comes with a powerful built-in toolbar to execute important actions such as page navigation, text search,view mode,download,print,bookmark, and thumbnails.

The following table shows built-in toolbar items and its actions:-

| Option | Description |
|---|---|
| OpenOption | This option provides an action to load the PDF documents to the PDF Viewer.|
| PageNavigationTool |This option provides an action to navigate the pages in the PDF Viewer. It contains GoToFirstPage,GoToLastPage,GotoPage,GoToNext, and GoToLast tools.|
| MagnificationTool | This option provides an action to magnify the pages either with predefined or user defined zoom factors in the PDF Viewer. Contains ZoomIn, ZoomOut, Zoom, FitPage and FitWidth tools|
| PanTool | This option provides an action for panning the pages in the PDF Viewer.|
| SelectionTool |This option provides an action to enable/disable the text selection in the PDF Viewer.|
| SearchOption |This option provides an action to search a word in the PDF documents.|
| PrintOption |This option provides an action to print the PDF document being loaded in the PDF Viewer.|
| DownloadOption |This Download option provides an action to download the PDF document that has been loaded in the PDF Viewer.|
| UndoRedoTool | This tool provides options to undo and redo the annotation actions performed in the PDF Viewer.|
| AnnotationEditTool | This tool provides options to enable or disable the edit mode of annotation in the PDF Viewer.|

## Show/Hide the default toolbar

The PDF Viewer has an option to show or hide the complete default toolbar. You can achieve this by using following two ways.,

* **Show/Hide toolbar using enableToolbar API as in the following code snippet**

```html
    <div style="width:100%;height:600px">
        <ejs-pdfviewer id="pdfviewer"
                style="height:600px"
                serviceUrl="/api/PdfViewer"
                documentPath=@ViewBag.DocumentPath
                enableToolbar="false">
        </ejs-pdfviewer>
    </div>
```

* **Show/Hide toolbar using showToolbar as in the following code snippet**

```html
    <script>
       window.onload = function () {
            var pdfViewer = document.getElementById('pdfviewer').ej2_instances[0];
            pdfViewer.toolbar.showToolbar(false);
        }
    </script>
```

## Show/Hide the default toolbaritem

The PDF Viewer has an option to show or hide these grouped items in the default toolbar.

* **Show/Hide toolbaritem using toolbarSettings as in the following code snippet.**

```html
    <div style="width:100%;height:600px">
        <ejs-pdfviewer id="pdfviewer"
                style="height:600px"
                serviceUrl="/api/PdfViewer"
                documentPath=@ViewBag.DocumentPath
                enableToolbar="true"
                toolbarSettings="@(new Syncfusion.EJ2.PdfViewer.PdfViewerToolbarSettings { ShowTooltip = true, ToolbarItem = "OpenOption"  })"
                >
        </ejs-pdfviewer>
    </div>
```

* **Show/Hide toolbaritem using showToolbaritem as in the following code snippet**

```html
    <script>
       window.onload = function () {
            var pdfViewer = document.getElementById('pdfviewer').ej2_instances[0];
            pdfViewer.toolbar.showToolbarItem(new Array("DownloadOption"),true);
        }
    </script>
```

## See also

* [Toolbar customization](./how-to/toolbar_customization)
* [Feature Modules](./feature-module)