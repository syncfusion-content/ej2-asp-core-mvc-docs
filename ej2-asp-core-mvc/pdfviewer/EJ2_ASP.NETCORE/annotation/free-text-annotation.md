---
layout: post
title: Free Text Annotation in ##Platform_Name## Pdfviewer Component
description: Learn here all about Free Text Annotation in Syncfusion ##Platform_Name## Pdfviewer component and more.
platform: ej2-asp-core-mvc
control: Free Text Annotation
publishingplatform: ##Platform_Name##
documentation: ug
---


# Free Text Annotation in the ASP.NET Core PDF Viewer component

The PDF Viewer control provides the options to add, edit, and delete the free text annotations.

## Adding a free text annotation to the PDF document

The Free text annotations can be added to the PDF document using the annotation toolbar.

* Click the **Edit Annotation** button in the PDF Viewer toolbar. A toolbar appears below it.
* Select the **Free Text Annotation** button in the annotation toolbar. It enables the Free Text annotation mode.
* You can add the text over the pages of the PDF document.

In the pan mode, if the free text annotation mode is entered, the PDF Viewer control will switch to text select mode.

![FreeTextAnnotation in ASP.NET Core PDF Viewer](../../../pdfviewer/images/freetext_tool.png)

Refer to the following code sample to switch to the Free Text annotation mode.

```html
    <!--Element to set free text annotation mode-->
    <button id="set" onclick="addAnnot()">FreeText</button>
    <div style="width:100%;height:600px">
        <ejs-pdfviewer id="pdfviewer" style="height:600px" serviceUrl="/api/PdfViewer" documentPath=@ViewBag.DocumentPath>
        </ejs-pdfviewer>
    </div>
    <script>
            function addAnnot() {
                var pdfViewer = document.getElementById('pdfviewer').ej2_instances[0];
                pdfViewer.annotation.setAnnotationMode('FreeText');
            }
    </script>
```

## Editing the properties of free text annotation

The font family, font size, font styles, font color, text alignment, fill color, the border stroke color, border thickness, and opacity of the free text annotation can be edited using the Font Family tool, Font Size tool, Font Color tool, Text Align tool, Font Style tool  Edit Color tool, Edit Stroke Color tool, Edit Thickness tool, and Edit Opacity tool in the annotation toolbar.

### Editing font family

The font family of the annotation can be edited by selecting the desired font in the Font Family tool.

![FontFamily](../../../pdfviewer/images/fontfamily.png)

### Editing font size

The font size of the annotation can be edited by selecting the desired size in the Font Size tool.

![FontSize](../../../pdfviewer/images/fontsize.png)

### Editing font color

The font color of the annotation can be edited using the color palette provided in the Font Color tool.

![FontColor](../../../pdfviewer/images/fontcolor.png)

### Editing the text alignment

The text in the annotation can be aligned by selecting the desired styles in the drop-down pop-up in the Text Align tool.

![FreeTextAnnotation](../../../pdfviewer/images/textalign.png)

### Editing text styles

The style of the text in the annotation can be edited by selecting the desired styles in the drop-down pop-up in the Font Style tool.

![FontStyle](../../../pdfviewer/images/fontstyle.png)

### Editing fill color

The fill color of the annotation can be edited using the color palette provided in the Edit Color tool.

![FillColor](../../../pdfviewer/images/fillcolor.png)

### Editing stroke color

The stroke color of the annotation can be edited using the color palette provided in the Edit Stroke Color tool.

![StrokeColor](../../../pdfviewer/images/fontstroke.png)

### Editing thickness

The border thickness of the annotation can be edited using the range slider provided in the Edit Thickness tool.

![FontThickness](../../../pdfviewer/images/fontthickness.png)

### Editing opacity

The opacity of the annotation can be edited using the range slider provided in the Edit Opacity tool.

![FontOpacity](../../../pdfviewer/images/fontopacity.png)

## Setting default properties during control initialization

The properties of the free text annotation can be set before creating the control using the FreeTextSettings.

After editing the default values, they will be changed to the selected values.
Refer to the following code sample to set the default free text annotation settings.

```html
    <div style="width:100%;height:600px">
        <ejs-pdfviewer id="pdfviewer" style="height:600px" serviceUrl="/api/PdfViewer" documentPath=@ViewBag.DocumentPath
                       freeTextSettings="@(new Syncfusion.EJ2.PdfViewer.PdfViewerFreeTextSettings {FillColor="green", BorderColor="blue", FontColor="yellow"})">
        </ejs-pdfviewer>
    </div>
```

You can also enable the autofit support for free text annotation by using the EnableAutoFit boolean property in FreeTextSettings as below. The width of the free text rectangle box will be increased based on the text added to it.

```html
    <div style="width:100%;height:600px">
        <ejs-pdfviewer id="pdfviewer" style="height:600px" serviceUrl="/api/PdfViewer" documentPath="PDF_Succinctly.pdf" freeTextSettings="@(new Syncfusion.EJ2.PdfViewer.PdfViewerFreeTextSettings {EnableAutoFit = true})"></ejs-pdfviewer>
    </div>
```