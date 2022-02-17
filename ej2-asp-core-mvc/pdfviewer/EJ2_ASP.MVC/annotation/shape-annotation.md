---
layout: post
title: Shape Annotation in ##Platform_Name## Pdfviewer Component
description: Learn here all about Shape Annotation in Syncfusion ##Platform_Name## Pdfviewer component and more.
platform: ej2-asp-core-mvc
control: Shape Annotation
publishingplatform: ##Platform_Name##
documentation: ug
---


# Shape Annotation in the ASP.NET MVC PDF Viewer component

The PDF Viewer control provides the options to add, edit, and delete the shape annotations. The shape annotation types supported in the PDF Viewer control are:

* Line
* Arrow
* Rectangle
* Circle
* Polygon

![ShapeAnnotation](../../../pdfviewer/images/shape_annot.png)

## Adding a shape annotation to the PDF document

Shape annotations can be added to the PDF document using the annotation toolbar.

* Click the **Edit Annotation** button in the PDF Viewer toolbar. A toolbar appears below it.
* Click the **Shape Annotation** drop-down button. A drop-down pop-up will appear and shows the shape annotations to be added.
* Select the shape types to be added to the page in the drop-down pop-up. It enables the selected shape annotation mode.
* You can add the shapes over the pages of the PDF document.

In the pan mode, if the shape annotation mode is entered, the PDF Viewer control will switch to text select mode.

![ShapeTool](../../../pdfviewer/images/shape_toolbar.png)

Refer to the following code sample to switch to the circle annotation mode.

```html
    <!--Element to set shape annotation mode-->
    <button id="set" onclick="addAnnot()">Circle</button>
    <div style="width:100%;height:600px">
        @Html.EJS().PdfViewer("pdfviewer").ServiceUrl(VirtualPathUtility.ToAbsolute("~/PdfViewer/")).DocumentPath("PDF_Succinctly.pdf").Render()
    </div>
    <script>
        function addAnnot() {
            var pdfViewer = document.getElementById('pdfviewer').ej2_instances[0];
            pdfViewer.annotation.setAnnotationMode('Circle');
        }
    </script>
```

## Editing the properties of the shape annotation

The fill color, stroke color, thickness, and opacity of the shape annotation can be edited using the Edit color tool, Edit stroke color tool, Edit thickness tool, and Edit opacity tool in the annotation toolbar.

### Editing fill color

The fill color of the annotation can be edited using the color palette provided in the Edit Color tool.

![ShapeFillColor](../../../pdfviewer/images/shape_fillcolor.png)

### Editing stroke color

The stroke color of the annotation can be edited using the color palette provided in the Edit Stroke Color tool.

![ShapeStrokeColor](../../../pdfviewer/images/shape_strokecolor.png)

### Editing thickness

The thickness of the border of the annotation can be edited using the range slider provided in the Edit Thickness tool.

![ShapeThickness](../../../pdfviewer/images/shape_thickness.png)

### Editing opacity

The opacity of the annotation can be edited using the range slider provided in the Edit Opacity tool.

![ShapeOpacity](../../../pdfviewer/images/shape_opacity.png)

### Editing the line properties

The properties of the line shapes such as line and arrow annotations can be edited using the Line Properties window. It can be opened by selecting the Properties option in the context menu that appears on right-clicking the line and arrow annotations.

Refer to the following code sample to set the default annotation settings.

![ShapeProperty](../../../pdfviewer/images/shape_lineproperty.png)

## Setting default properties during the control initialization

The properties of the shape annotations can be set before creating the control using LineSettings, ArrowSettings, RectangleSettings, CircleSettings, and PolygonSettings.

```html
    <div style="width:100%;height:600px">
        @Html.EJS().PdfViewer("pdfviewer").ServiceUrl(VirtualPathUtility.ToAbsolute("~/PdfViewer/")).DocumentPath("PDF_Succinctly.pdf").LineSettings(new Syncfusion.EJ2.PdfViewer.PdfViewerLineSettings { FillColor = "blue", Opacity = 0.6, StrokeColor = "green" }).ArrowSettings(new Syncfusion.EJ2.PdfViewer.PdfViewerArrowSettings { FillColor = "green", Opacity = 0.6, StrokeColor = "blue" }).RectangleSettings(new Syncfusion.EJ2.PdfViewer.PdfViewerRectangleSettings { FillColor = "yellow", Opacity = 0.6, StrokeColor = "orange" }).CircleSettings(new Syncfusion.EJ2.PdfViewer.PdfViewerCircleSettings { FillColor = "orange", Opacity = 0.6, StrokeColor = "pink" }).PolygonSettings(new Syncfusion.EJ2.PdfViewer.PdfViewerPolygonSettings { FillColor = "pink", Opacity = 0.6, StrokeColor = "yellow" }).Render()
    </div>
```