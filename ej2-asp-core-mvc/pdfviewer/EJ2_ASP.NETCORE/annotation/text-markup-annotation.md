---
layout: post
title: Text Markup Annotation in ##Platform_Name## Pdfviewer Component
description: Learn here all about Text Markup Annotation in Syncfusion ##Platform_Name## Pdfviewer component and more.
platform: ej2-asp-core-mvc
control: Text Markup Annotation
publishingplatform: ##Platform_Name##
documentation: ug
---


# Text Markup Annotation in the ASP.NET Core PDF Viewer component

The PDF Viewer control provides the options to add, edit, and delete text markup annotations such as highlight, underline, and strikethrough annotations in the PDF document.

![Alt text](../../pdfviewer/images/text_markup_annotation.png)

## Highlight a text

There are two ways to highlight a text in the PDF document:

1. Using the context menu
    * Select a text in the PDF document and right-click it.
    * Select **Highlight** option in the context menu that appears.

![Alt text](../../pdfviewer/images/highlight_context.png)

<!-- markdownlint-disable MD029 -->
2. Using the annotation toolbar
    * Click the **Edit Annotation** button in the PDF Viewer toolbar. A toolbar appears below it.
    * Select the **Highlight** button in the annotation toolbar. It enables the highlight mode.
    * Select the text and the highlight annotation will be added.
    * You can also select the text and apply the highlight annotation using the **Highlight** button.

![Alt text](../../pdfviewer/images/highlight_button.PNG)

In the pan mode, if the highlight mode is entered, the PDF Viewer control will switch to text select mode to enable the text selection for highlighting the text.

Refer to the following code sample to switch to the highlight mode.

```html
    <!--Element to set text markup annotation mode-->
    <button id="set" onclick="addAnnot()">Highlight</button>
    <div style="width:100%;height:600px">
        <ejs-pdfviewer id="pdfviewer" style="height:600px" serviceUrl="/api/PdfViewer" documentPath=@ViewBag.DocumentPath>
        </ejs-pdfviewer>
    </div>
    <script>
        function addAnnot() {
            var pdfViewer = document.getElementById('pdfviewer').ej2_instances[0];
            pdfViewer.annotation.setAnnotationMode('Highlight');
        }
    </script>
```

Refer to the following code sample to switch back to normal mode from the highlight mode.

```html
    <!--Element to set text markup annotation mode-->
    <button id="set" onclick="addAnnot()">Highlight</button>
    <!--Element to set normal mode-->
    <button id="setNone" onclick="setNone()">Normal Mode</button>
    <div style="width:100%;height:600px">
        <ejs-pdfviewer id="pdfviewer" style="height:600px" serviceUrl="/api/PdfViewer" documentPath=@ViewBag.DocumentPath>
        </ejs-pdfviewer>
    </div>
    <script>
        function addAnnot() {
            var pdfViewer = document.getElementById('pdfviewer').ej2_instances[0];
            pdfViewer.annotation.setAnnotationMode('Highlight');
        }

        function setNone() {
            var pdfViewer = document.getElementById('pdfviewer').ej2_instances[0];
            pdfViewer.annotation.setAnnotationMode('None');
        }
    </script>
```

## Underline a text

There are two ways to underline a text in the PDF document:

1. Using the context menu
    * Select a text in the PDF document and right-click it.
    * Select the **Underline** option in the context menu that appears.

![Alt text](../../pdfviewer/images/underline_context.png)

<!-- markdownlint-disable MD029 -->
2. Using the annotation toolbar
    * Click the **Edit Annotation** button in the PDF Viewer toolbar. A toolbar appears below it.
    * Select the **Underline** button in the annotation toolbar. It enables the underline mode.
    * Select the text and the underline annotation will be added.
    * You can also select the text and apply the underline annotation using the **Underline** button.

![Alt text](../../pdfviewer/images/underline_button.png)

In the pan mode, if the underline mode is entered, the PDF Viewer control will switch to text select mode to enable the text selection for underlining the text.

Refer to the following code sample to switch to the underline mode.

```html
    <!--Element to set text markup annotation mode-->
    <button id="set" onclick="addAnnot()">Underline</button>
    <div style="width:100%;height:600px">
        <ejs-pdfviewer id="pdfviewer" style="height:600px" serviceUrl="/api/PdfViewer" documentPath=@ViewBag.DocumentPath>
        </ejs-pdfviewer>
    </div>
    <script>
        function addAnnot() {
            var pdfViewer = document.getElementById('pdfviewer').ej2_instances[0];
            pdfViewer.annotation.setAnnotationMode('Underline');
        }
    </script>
```

Refer to the following code sample to switch back to normal mode from the underline mode.

```html
    <!--Element to set text markup annotation mode-->
    <button id="set" onclick="addAnnot()">Underline</button>
    <!--Element to set normal mode-->
    <button id="setNone" onclick="setNone()">Normal Mode</button>
    <div style="width:100%;height:600px">
        <ejs-pdfviewer id="pdfviewer" style="height:600px" serviceUrl="/api/PdfViewer" documentPath=@ViewBag.DocumentPath>
        </ejs-pdfviewer>
    </div>
    <script>
        function addAnnot() {
            var pdfViewer = document.getElementById('pdfviewer').ej2_instances[0];
            pdfViewer.annotation.setAnnotationMode('Underline');
        }

        function setNone() {
            var pdfViewer = document.getElementById('pdfviewer').ej2_instances[0];
            pdfViewer.annotation.setAnnotationMode('None');
        }
    </script>
```

## Strikethrough a text

There are two ways to strikethrough a text in the PDF document:

1. Using the context menu
    * Select a text in the PDF document and right-click it.
    * Select the **Strikethrough** option in the context menu that appears.

![Alt text](../../pdfviewer/images/strikethrough_context.png)

<!-- markdownlint-disable MD029 -->
2. Using the annotation toolbar
    * Click the **Edit Annotation** button in the PDF Viewer toolbar. A toolbar appears below it.
    * Select the **Strikethrough** button in the annotation toolbar. It enables the strikethrough mode.
    * Select the text and the strikethrough annotation will be added.
    * You can also select the text and apply the strikethrough annotation using the **Strikethrough** button.

![Alt text](../../pdfviewer/images/strikethrough_button.png)

In the pan mode, if the strikethrough mode is entered, the PDF Viewer control will switch to text select mode to enable the text selection for striking through the text.

Refer to the following code sample to switch to the strikethrough mode.

```html
    <!--Element to set text markup annotation mode-->
    <button id="set" onclick="addAnnot()">Strikethrough</button>
    <div style="width:100%;height:600px">
        <ejs-pdfviewer id="pdfviewer" style="height:600px" serviceUrl="/api/PdfViewer" documentPath=@ViewBag.DocumentPath>
        </ejs-pdfviewer>
    </div>
    <script>
        function addAnnot() {
            var pdfViewer = document.getElementById('pdfviewer').ej2_instances[0];
            pdfViewer.annotation.setAnnotationMode('Strikethrough');
        }
    </script>
```

Refer to the following code sample to switch back to normal mode from the strikethrough mode.

```html
    <!--Element to set text markup annotation mode-->
    <button id="set" onclick="addAnnot()">Strikethrough</button>
    <!--Element to set normal mode-->
    <button id="setNone" onclick="setNone()">Normal Mode</button>
    <div style="width:100%;height:600px">
        <ejs-pdfviewer id="pdfviewer" style="height:600px" serviceUrl="/api/PdfViewer" documentPath=@ViewBag.DocumentPath>
        </ejs-pdfviewer>
    </div>
    <script>
        function addAnnot() {
            var pdfViewer = document.getElementById('pdfviewer').ej2_instances[0];
            pdfViewer.annotation.setAnnotationMode('Strikethrough');
        }

        function setNone() {
            var pdfViewer = document.getElementById('pdfviewer').ej2_instances[0];
            pdfViewer.annotation.setAnnotationMode('None');
        }
    </script>
```

## Deleting a text markup annotation

The selected annotation can be deleted in the following ways:

1. Using the Delete key
    * Select the annotation to be deleted.
    * Click the Delete key in the keyboard. The selected annotation will be deleted.

2. Using the annotation toolbar
    * Select the annotation to be deleted.
    * Click the **Delete Annotation** button in the annotation toolbar. The selected annotation will be deleted.

![Alt text](../../pdfviewer/images/delete_button.png)

## Editing the properties of the text markup annotation

The color and the opacity of the text markup annotation can be edited using the Edit Color tool and the Edit Opacity tool in the annotation toolbar.

### Editing color

The color of the annotation can be edited using the color palette provided in the Edit Color tool.

![Alt text](../../pdfviewer/images/edit_color.png)

### Editing opacity

The opacity of the annotation can be edited using the range slider provided in the Edit Opacity tool.

![Alt text](../../pdfviewer/images/edit_opacity.png)

## Setting default properties during the control initialization

The properties of the text markup annotation can be set before creating the control using the highlightSettings, underlineSettings, and strikethroughSettings.

>After editing the default color and opacity using the Edit Color tool and Edit Opacity tool, they will be changed to the selected values.

Refer to the following code sample to set the default annotation settings.

```html
    <div style="width:100%;height:600px">
        <ejs-pdfviewer id="pdfviewer" style="height:600px" serviceUrl="/api/PdfViewer" documentPath=@ViewBag.DocumentPath
            highlightSettings="@(new Syncfusion.EJ2.PdfViewer.PdfViewerHighlightSettings {Author="Guest User", Color="#ffff00", Opacity=0.9})"
            underlineSettings="@(new Syncfusion.EJ2.PdfViewer.PdfViewerUnderlineSettings {Author="Guest User", Color="#00ffff", Opacity=0.9})"
            strikethroughSettings="@(new Syncfusion.EJ2.PdfViewer.PdfViewerStrikethroughSettings {Author="Guest User", Color="#ff00ff", Opacity=0.9})" >
        </ejs-pdfviewer>
    </div>
```

## Performing undo and redo

The PDF Viewer performs undo and redo for the changes made in the PDF document. In the text markup annotation, undo and redo actions are provided for:

* Inclusion of the text markup annotations.
* Deletion of the text markup annotations.
* Change of either color or opacity of the text markup annotations.

The undo and redo actions can be done by the following ways:

1. Using the keyboard shortcuts:
    After performing a text markup annotation action, you can undo it by using the Ctrl + Z shortcut and redo by using the Ctrl + Y shortcut.
2. Using toolbar:
    The undo and redo can be done using the **Undo** tool and **Redo** tool provided in the toolbar.

Refer to the following code sample for calling undo and redo actions from the client-side.

```html
    <!--Element to call undo-->
    <button id="undo" onclick="Undo()">Undo</button>
    <!--Element to call redo-->
    <button id="redo" onclick="Redo()">Redo</button>
    <div style="width:100%;height:600px">
        <ejs-pdfviewer id="pdfviewer" style="height:600px" serviceUrl="/api/PdfViewer" documentPath=@ViewBag.DocumentPath>
        </ejs-pdfviewer>
    </div>
    <script>
        function Undo() {
            var pdfViewer = document.getElementById('pdfviewer').ej2_instances[0];
            pdfViewer.undo();
        }

        function Redo() {
            var pdfViewer = document.getElementById('pdfviewer').ej2_instances[0];
            pdfViewer.redo();
        }
    </script>
```

## Saving the text markup annotation

When you click the download tool in the toolbar, the text markup annotations will be saved in the PDF document. This action will not affect the original document.

## Printing the text markup annotation

When the print tool is selected in the toolbar, the PDF document will be printed along with the text markup annotations added to the pages. This action will not affect the original document.

## Disabling text markup annotation

The PDF Viewer control provides an option to disable the text markup annotation feature. The code sample for disabling the feature is as follows.

```html
    <div style="width:100%;height:600px">
        <ejs-pdfviewer id="pdfviewer" style="height:600px" enableTextMarkupAnnotation=false serviceUrl="/api/PdfViewer" documentPath=@ViewBag.DocumentPath>
        </ejs-pdfviewer>
    </div>
```