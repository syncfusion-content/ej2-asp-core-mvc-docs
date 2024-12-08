---
layout: post
title: Shape Annotation in ##Platform_Name## PDF Viewer Component | Syncfusion
description: Learn here all about Shape Annotation in Syncfusion ##Platform_Name## PDF Viewer component of Syncfusion Essential JS 2 and more.
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

![ShapeAnnotation](../images/shape_annot.png)

## Adding a shape annotation to the PDF document

Shape annotations can be added to the PDF document using the annotation toolbar.

* Click the **Edit Annotation** button in the PDF Viewer toolbar. A toolbar appears below it.
* Click the **Shape Annotation** drop-down button. A drop-down pop-up will appear and shows the shape annotations to be added.
* Select the shape types to be added to the page in the drop-down pop-up. It enables the selected shape annotation mode.
* You can add the shapes over the pages of the PDF document.

In the pan mode, if the shape annotation mode is entered, the PDF Viewer control will switch to text select mode.

![ShapeTool](../images/shape_toolbar.png)

Refer to the following code sample to switch to the circle annotation mode.

{% tabs %}
{% highlight html tabtitle="Standalone" %}

<!--Element to set shape annotation mode-->
<button id="set" onclick="addAnnot()">Circle</button>
<div style="width:100%;height:600px">
    @Html.EJS().PdfViewer("pdfviewer").DocumentPath("https://cdn.syncfusion.com/content/pdf/pdf-succinctly.pdf").Render()
</div>
<script>
    function addAnnot() {
        var pdfViewer = document.getElementById('pdfviewer').ej2_instances[0];
        pdfViewer.annotation.setAnnotationMode('Circle');
    }
</script>

{% endhighlight %}
{% highlight html tabtitle="Server-Backed" %}

<!--Element to set shape annotation mode-->
<button id="set" onclick="addAnnot()">Circle</button>
<div style="width:100%;height:600px">
    @Html.EJS().PdfViewer("pdfviewer").ServiceUrl(VirtualPathUtility.ToAbsolute("~/PdfViewer/")).DocumentPath("https://cdn.syncfusion.com/content/pdf/pdf-succinctly.pdf").Render()
</div>
<script>
    function addAnnot() {
        var pdfViewer = document.getElementById('pdfviewer').ej2_instances[0];
        pdfViewer.annotation.setAnnotationMode('Circle');
    }
</script>

{% endhighlight %}
{% endtabs %}

## Adding a shape annotation to the PDF document Programmatically

With the PDF Viewer library, you can add a shape annotation to the PDF Viewer control programmatically using the **addAnnotation()** method.

Here's a example of how you can utilize the **addAnnotation()** method to include a shape annotation programmatically:

{% tabs %}
{% highlight html tabtitle="Standalone" %}

<button onclick="addLineAnnotation()">add Line Annotation programatically</button>
<button onclick="addArrowAnnotation()">add Arrow Annotation programatically</button>
<button onclick="addRectangleAnnotation()">add Rectangle Annotation programatically</button>
<button onclick="addCircleAnnotation()">add Circle Annotation programatically</button>
<button onclick="addPolygonAnnotation()">add Polygon Annotation programatically</button>

<div style="width:100%;height:600px">
    @Html.EJS().PdfViewer("pdfviewer").DocumentPath("https://cdn.syncfusion.com/content/pdf/pdf-succinctly.pdf").Render()
</div>
<script>
    function addLineAnnotation() {
        var pdfviewer = document.getElementById('pdfviewer').ej2_instances[0];
        pdfviewer.annotation.addAnnotation("Line", {
            offset: { x: 200, y: 230 },
            pageNumber: 1,
            vertexPoints: [{ x: 200, y: 230 }, { x: 350, y: 230 }]
        });
    }
    function addArrowAnnotation() {
        var pdfviewer = document.getElementById('pdfviewer').ej2_instances[0];
        pdfviewer.annotation.addAnnotation("Arrow", {
            offset: { x: 200, y: 370 },
            pageNumber: 1,
            vertexPoints: [{ x: 200, y: 370 }, { x: 350, y: 370 }]
        });
    }
    function addRectangleAnnotation() {
        var pdfviewer = document.getElementById('pdfviewer').ej2_instances[0];
        pdfviewer.annotation.addAnnotation("Rectangle", {
            offset: { x: 200, y: 500 },
            pageNumber: 1,
            vertexPoints: [{ x: 200, y: 500 }, { x: 288, y: 499 }, { x: 289, y: 553 }, { x: 200, y: 500 }]
        });
    }
    function addCircleAnnotation() {
        var pdfviewer = document.getElementById('pdfviewer').ej2_instances[0];
        pdfviewer.annotation.addAnnotation("Circle", {
            offset: { x: 200, y: 630 },
            pageNumber: 1,
            width: 90,
            height: 90
        });
    }
    function addPolygonAnnotation() {
        var pdfviewer = document.getElementById('pdfviewer').ej2_instances[0];
        pdfviewer.annotation.addAnnotation("Polygon", {
            offset: { x: 200, y: 800 },
            pageNumber: 1,
            vertexPoints: [{ x: 200, y: 800 }, { x: 242, y: 771 }, { x: 289, y: 799 }, { x: 278, y: 842 }, { x: 211, y: 842 }, { x: 200, y: 800 }]
        });
    }
</script>

{% endhighlight %}
{% highlight html tabtitle="Server-Backed" %}

<button onclick="addLineAnnotation()">add Line Annotation programatically</button>
<button onclick="addArrowAnnotation()">add Arrow Annotation programatically</button>
<button onclick="addRectangleAnnotation()">add Rectangle Annotation programatically</button>
<button onclick="addCircleAnnotation()">add Circle Annotation programatically</button>
<button onclick="addPolygonAnnotation()">add Polygon Annotation programatically</button>

<div style="width:100%;height:600px">
    @Html.EJS().PdfViewer("pdfviewer").ServiceUrl(VirtualPathUtility.ToAbsolute("~/PdfViewer/")).DocumentPath("https://cdn.syncfusion.com/content/pdf/pdf-succinctly.pdf").Render()
</div>

<script>
    function addLineAnnotation() {
        var pdfviewer = document.getElementById('pdfviewer').ej2_instances[0];
        pdfviewer.annotation.addAnnotation("Line", {
            offset: { x: 200, y: 230 },
            pageNumber: 1,
            vertexPoints: [{ x: 200, y: 230 }, { x: 350, y: 230 }]
        });
    }
    function addArrowAnnotation() {
        var pdfviewer = document.getElementById('pdfviewer').ej2_instances[0];
        pdfviewer.annotation.addAnnotation("Arrow", {
            offset: { x: 200, y: 370 },
            pageNumber: 1,
            vertexPoints: [{ x: 200, y: 370 }, { x: 350, y: 370 }]
        });
    }
    function addRectangleAnnotation() {
        var pdfviewer = document.getElementById('pdfviewer').ej2_instances[0];
        pdfviewer.annotation.addAnnotation("Rectangle", {
            offset: { x: 200, y: 500 },
            pageNumber: 1,
            vertexPoints: [{ x: 200, y: 500 }, { x: 288, y: 499 }, { x: 289, y: 553 }, { x: 200, y: 500 }]
        });
    }
    function addCircleAnnotation() {
        var pdfviewer = document.getElementById('pdfviewer').ej2_instances[0];
        pdfviewer.annotation.addAnnotation("Circle", {
            offset: { x: 200, y: 630 },
            pageNumber: 1,
            width: 90,
            height: 90
        });
    }
    function addPolygonAnnotation() {
        var pdfviewer = document.getElementById('pdfviewer').ej2_instances[0];
        pdfviewer.annotation.addAnnotation("Polygon", {
            offset: { x: 200, y: 800 },
            pageNumber: 1,
            vertexPoints: [{ x: 200, y: 800 }, { x: 242, y: 771 }, { x: 289, y: 799 }, { x: 278, y: 842 }, { x: 211, y: 842 }, { x: 200, y: 800 }]
        });
    }
</script>

{% endhighlight %}
{% endtabs %}

## Edit the existing shape annotation programmatically

To modify existing shape annotation in the Syncfusion<sup style="font-size:70%">&reg;</sup> PDF viewer programmatically, you can use the **editAnnotation()** method.

Here is an example of how you can use the **editAnnotation()** method:

{% tabs %}
{% highlight html tabtitle="Standalone" %}

<button onclick="editLineAnnotation()">edit Line Annotation programatically</button>
<button onclick="editArrowAnnotation()">edit Arrow Annotation programatically</button>
<button onclick="editRectangleAnnotation()">edit Rectangle Annotation programatically</button>
<button onclick="editCircleAnnotation()">edit Circle Annotation programatically</button>
<button onclick="editPolygonAnnotation()">edit Polygon Annotation programatically</button>

<div style="width:100%;height:600px">
    @Html.EJS().PdfViewer("pdfviewer").DocumentPath("https://cdn.syncfusion.com/content/pdf/pdf-succinctly.pdf").Render()
</div>

<script>
    function editLineAnnotation() {
        var pdfviewer = document.getElementById('pdfviewer').ej2_instances[0];
        for (let i = 0; i < pdfviewer.annotationCollection.length; i++) {
            if (pdfviewer.annotationCollection[i].subject === "Line") {
                pdfviewer.annotationCollection[i].strokeColor = "#0000FF";
                pdfviewer.annotationCollection[i].thickness = 2;
                pdfviewer.annotationCollection[i].annotationSelectorSettings.resizerShape = "Circle"
                pdfviewer.annotation.editAnnotation(pdfviewer.annotationCollection[i]);
            }
        }
    }
    function editArrowAnnotation() {
        var pdfviewer = document.getElementById('pdfviewer').ej2_instances[0];
        for (let i = 0; i < pdfviewer.annotationCollection.length; i++) {
            if (pdfviewer.annotationCollection[i].subject === "Arrow") {
                pdfviewer.annotationCollection[i].strokeColor = "#0000FF";
                pdfviewer.annotationCollection[i].thickness = 2;
                pdfviewer.annotationCollection[i].fillColor = "#FFFF00";
                pdfviewer.annotationCollection[i].annotationSelectorSettings.resizerShape = "Circle"
                pdfviewer.annotation.editAnnotation(pdfviewer.annotationCollection[i]);
            }
        }
    }
    function editRectangleAnnotation() {
        var pdfviewer = document.getElementById('pdfviewer').ej2_instances[0];
        for (let i = 0; i < pdfviewer.annotationCollection.length; i++) {
            if (pdfviewer.annotationCollection[i].subject === "Rectangle") {
                pdfviewer.annotationCollection[i].strokeColor = "#0000FF";
                pdfviewer.annotationCollection[i].thickness = 2;
                pdfviewer.annotationCollection[i].fillColor = "#FFFF00";
                pdfviewer.annotationCollection[i].annotationSelectorSettings.resizerShape = "Circle"
                pdfviewer.annotation.editAnnotation(pdfviewer.annotationCollection[i]);
            }
        }
    }
    function editCircleAnnotation() {
        var pdfviewer = document.getElementById('pdfviewer').ej2_instances[0];
        for (let i = 0; i < pdfviewer.annotationCollection.length; i++) {
            if (pdfviewer.annotationCollection[i].subject === "Circle") {
                pdfviewer.annotationCollection[i].strokeColor = "#0000FF";
                pdfviewer.annotationCollection[i].thickness = 2;
                pdfviewer.annotationCollection[i].fillColor = "#FFFF00";
                pdfviewer.annotationCollection[i].annotationSelectorSettings.resizerShape = "Circle"
                pdfviewer.annotation.editAnnotation(pdfviewer.annotationCollection[i]);
            }
        }
    }
    function editPolygonAnnotation() {
        var pdfviewer = document.getElementById('pdfviewer').ej2_instances[0];
        for (let i = 0; i < pdfviewer.annotationCollection.length; i++) {
            if (pdfviewer.annotationCollection[i].subject === "Polygon") {
                pdfviewer.annotationCollection[i].strokeColor = "#0000FF";
                pdfviewer.annotationCollection[i].thickness = 2;
                pdfviewer.annotationCollection[i].fillColor = "#FFFF00";
                pdfviewer.annotationCollection[i].annotationSelectorSettings.resizerShape = "Circle"
                pdfviewer.annotation.editAnnotation(pdfviewer.annotationCollection[i]);
            }
        }
    }
</script>


{% endhighlight %}
{% highlight html tabtitle="Server-Backed" %}

<button onclick="editLineAnnotation()">edit Line Annotation programatically</button>
<button onclick="editArrowAnnotation()">edit Arrow Annotation programatically</button>
<button onclick="editRectangleAnnotation()">edit Rectangle Annotation programatically</button>
<button onclick="editCircleAnnotation()">edit Circle Annotation programatically</button>
<button onclick="editPolygonAnnotation()">edit Polygon Annotation programatically</button>

<div style="width:100%;height:600px">
    @Html.EJS().PdfViewer("pdfviewer").ServiceUrl(VirtualPathUtility.ToAbsolute("~/PdfViewer/")).DocumentPath("https://cdn.syncfusion.com/content/pdf/pdf-succinctly.pdf").Render()
</div>

<script>
    function editLineAnnotation() {
        var pdfviewer = document.getElementById('pdfviewer').ej2_instances[0];
        for (let i = 0; i < pdfviewer.annotationCollection.length; i++) {
            if (pdfviewer.annotationCollection[i].subject === "Line") {
                pdfviewer.annotationCollection[i].strokeColor = "#0000FF";
                pdfviewer.annotationCollection[i].thickness = 2;
                pdfviewer.annotationCollection[i].annotationSelectorSettings.resizerShape = "Circle"
                pdfviewer.annotation.editAnnotation(pdfviewer.annotationCollection[i]);
            }
        }
    }
    function editArrowAnnotation() {
        var pdfviewer = document.getElementById('pdfviewer').ej2_instances[0];
        for (let i = 0; i < pdfviewer.annotationCollection.length; i++) {
            if (pdfviewer.annotationCollection[i].subject === "Arrow") {
                pdfviewer.annotationCollection[i].strokeColor = "#0000FF";
                pdfviewer.annotationCollection[i].thickness = 2;
                pdfviewer.annotationCollection[i].fillColor = "#FFFF00";
                pdfviewer.annotationCollection[i].annotationSelectorSettings.resizerShape = "Circle"
                pdfviewer.annotation.editAnnotation(pdfviewer.annotationCollection[i]);
            }
        }
    }
    function editRectangleAnnotation() {
        var pdfviewer = document.getElementById('pdfviewer').ej2_instances[0];
        for (let i = 0; i < pdfviewer.annotationCollection.length; i++) {
            if (pdfviewer.annotationCollection[i].subject === "Rectangle") {
                pdfviewer.annotationCollection[i].strokeColor = "#0000FF";
                pdfviewer.annotationCollection[i].thickness = 2;
                pdfviewer.annotationCollection[i].fillColor = "#FFFF00";
                pdfviewer.annotationCollection[i].annotationSelectorSettings.resizerShape = "Circle"
                pdfviewer.annotation.editAnnotation(pdfviewer.annotationCollection[i]);
            }
        }
    }
    function editCircleAnnotation() {
        var pdfviewer = document.getElementById('pdfviewer').ej2_instances[0];
        for (let i = 0; i < pdfviewer.annotationCollection.length; i++) {
            if (pdfviewer.annotationCollection[i].subject === "Circle") {
                pdfviewer.annotationCollection[i].strokeColor = "#0000FF";
                pdfviewer.annotationCollection[i].thickness = 2;
                pdfviewer.annotationCollection[i].fillColor = "#FFFF00";
                pdfviewer.annotationCollection[i].annotationSelectorSettings.resizerShape = "Circle"
                pdfviewer.annotation.editAnnotation(pdfviewer.annotationCollection[i]);
            }
        }
    }
    function editPolygonAnnotation() {
        var pdfviewer = document.getElementById('pdfviewer').ej2_instances[0];
        for (let i = 0; i < pdfviewer.annotationCollection.length; i++) {
            if (pdfviewer.annotationCollection[i].subject === "Polygon") {
                pdfviewer.annotationCollection[i].strokeColor = "#0000FF";
                pdfviewer.annotationCollection[i].thickness = 2;
                pdfviewer.annotationCollection[i].fillColor = "#FFFF00";
                pdfviewer.annotationCollection[i].annotationSelectorSettings.resizerShape = "Circle"
                pdfviewer.annotation.editAnnotation(pdfviewer.annotationCollection[i]);
            }
        }
    }
</script>

{% endhighlight %}
{% endtabs %}

## Editing the properties of the shape annotation

The fill color, stroke color, thickness, and opacity of the shape annotation can be edited using the Edit color tool, Edit stroke color tool, Edit thickness tool, and Edit opacity tool in the annotation toolbar.

### Editing fill color

The fill color of the annotation can be edited using the color palette provided in the Edit Color tool.

![ShapeFillColor](../images/shape_fillcolor.png)

### Editing stroke color

The stroke color of the annotation can be edited using the color palette provided in the Edit Stroke Color tool.

![ShapeStrokeColor](../images/shape_strokecolor.png)

### Editing thickness

The thickness of the border of the annotation can be edited using the range slider provided in the Edit Thickness tool.

![ShapeThickness](../images/shape_thickness.png)

### Editing opacity

The opacity of the annotation can be edited using the range slider provided in the Edit Opacity tool.

![ShapeOpacity](../images/shape_opacity.png)

### Editing the line properties

The properties of the line shapes such as line and arrow annotations can be edited using the Line Properties window. It can be opened by selecting the Properties option in the context menu that appears on right-clicking the line and arrow annotations.

Refer to the following code sample to set the default annotation settings.

![ShapeProperty](../images/shape_lineproperty.png)

## Setting default properties during the control initialization

The properties of the shape annotations can be set before creating the control using LineSettings, ArrowSettings, RectangleSettings, CircleSettings, and PolygonSettings.

{% tabs %}
{% highlight html tabtitle="Standalone" %}

<div style="width:100%;height:600px">
    @Html.EJS().PdfViewer("pdfviewer").DocumentPath("https://cdn.syncfusion.com/content/pdf/pdf-succinctly.pdf").LineSettings(new Syncfusion.EJ2.PdfViewer.PdfViewerLineSettings { FillColor = "blue", Opacity = 0.6, StrokeColor = "green" }).ArrowSettings(new Syncfusion.EJ2.PdfViewer.PdfViewerArrowSettings { FillColor = "green", Opacity = 0.6, StrokeColor = "blue" }).RectangleSettings(new Syncfusion.EJ2.PdfViewer.PdfViewerRectangleSettings { FillColor = "yellow", Opacity = 0.6, StrokeColor = "orange" }).CircleSettings(new Syncfusion.EJ2.PdfViewer.PdfViewerCircleSettings { FillColor = "orange", Opacity = 0.6, StrokeColor = "pink" }).PolygonSettings(new Syncfusion.EJ2.PdfViewer.PdfViewerPolygonSettings { FillColor = "pink", Opacity = 0.6, StrokeColor = "yellow" }).Render()
</div>

{% endhighlight %}
{% highlight html tabtitle="Server-Backed" %}

<div style="width:100%;height:600px">
    @Html.EJS().PdfViewer("pdfviewer").ServiceUrl(VirtualPathUtility.ToAbsolute("~/PdfViewer/")).DocumentPath("https://cdn.syncfusion.com/content/pdf/pdf-succinctly.pdf").LineSettings(new Syncfusion.EJ2.PdfViewer.PdfViewerLineSettings { FillColor = "blue", Opacity = 0.6, StrokeColor = "green" }).ArrowSettings(new Syncfusion.EJ2.PdfViewer.PdfViewerArrowSettings { FillColor = "green", Opacity = 0.6, StrokeColor = "blue" }).RectangleSettings(new Syncfusion.EJ2.PdfViewer.PdfViewerRectangleSettings { FillColor = "yellow", Opacity = 0.6, StrokeColor = "orange" }).CircleSettings(new Syncfusion.EJ2.PdfViewer.PdfViewerCircleSettings { FillColor = "orange", Opacity = 0.6, StrokeColor = "pink" }).PolygonSettings(new Syncfusion.EJ2.PdfViewer.PdfViewerPolygonSettings { FillColor = "pink", Opacity = 0.6, StrokeColor = "yellow" }).Render()
</div>

{% endhighlight %}
{% endtabs %}