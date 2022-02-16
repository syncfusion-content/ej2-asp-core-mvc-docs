---
layout: post
title: Sticky Notes Annotation in ##Platform_Name## Pdfviewer Component
description: Learn here all about Sticky Notes Annotation in Syncfusion ##Platform_Name## Pdfviewer component and more.
platform: ej2-asp-core-mvc
control: Sticky Notes Annotation
publishingplatform: ##Platform_Name##
documentation: ug
---


# Sticky Notes Annotation in the ASP.NET MVC PDF Viewer component

The PDF Viewer control provides the options to add, edit, and delete the sticky note annotations in the PDF document.

![StickyNotesAnnotation](../../../pdfviewer/images/stickynotes_annotation.png)

## Adding a sticky note annotation to the PDF document

Sticky note annotations can be added to the PDF document using the annotation toolbar.

* Click the **Comments** button in the PDF Viewer toolbar. A toolbar appears below it.
* Click the position where you want to add sticky note annotation in the PDF document.
* Sticky note annotation will be added in the clicked positions.

![StickyNotesTool](../../../pdfviewer/images/stickynotes_tool.png)

Annotation comments can be added to the PDF document using the comment panel.

* Select a Sticky note annotation in the PDF document and right-click it.
* Select the Comment option in the context menu that appears.
* Now, you can add Comments, Reply, and Status using the Comment Panel.
* Now, you can add Comments, Reply, and Status using the Comment Panel.

![StickyNotesComment](../../../pdfviewer/images/stickynotes_comment.png)

## Editing the properties of the sticky note annotation

### Editing opacity

The opacity of the annotation can be edited using the range slider provided in the Edit Opacity tool.

![StickyNotesOpacity](../../../pdfviewer/images/sticky_opacity.png)

### Editing comments

The comment, comment reply, and comment status of the annotation can be edited using the Comment Panel.

* Open the comment panel using the Comment Panel button showing in the annotation toolbar.

![StickyNotesComment](../../../pdfviewer/images/commentPanel.png)

You can modify or delete the comments or comments replay and it’s status using the menu option provided in the comment panel.

![StickyNotesEdit](../../../pdfviewer/images/sticky_editbtn.png)

## Setting default properties during the control initialization

The properties of the sticky note annotation can be set before creating the control using the StickyNotesSettings.

After editing the default opacity using the Edit Opacity tool, they will be changed to the selected values. Refer to the following code sample to set the default sticky note annotation settings.

```html
    <div style="width:100%;height:600px">
        @Html.EJS().PdfViewer("pdfviewer").ServiceUrl(VirtualPathUtility.ToAbsolute("~/PdfViewer/")).DocumentPath("PDF_Succinctly.pdf").StickyNotesSettings(new Syncfusion.EJ2.PdfViewer.PdfViewerStickyNotesSettings { Author = "Syncfusion" }).Render()
    </div>
```

## Disabling sticky note annotations

The PDF Viewer control provides an option to disable the sticky note annotations feature. The code sample for disabling the feature is as follows.

```html
    <div style="width:100%;height:600px">
        @Html.EJS().PdfViewer("pdfviewer").ServiceUrl(VirtualPathUtility.ToAbsolute("~/PdfViewer/")).EnableStickyNotesAnnotation(false).DocumentPath("PDF_Succinctly.pdf").Render()
    </div>
```