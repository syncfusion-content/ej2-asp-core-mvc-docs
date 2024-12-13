---
layout: post
title: Measurement Annotation in EJ2 ASP.NET CORE PDF Viewer | Syncfusion
description: Learn here all about Measurement Annotation in ASP.NET CORE PDF Viewer component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Measurement Annotation
publishingplatform: ##Platform_Name##
documentation: ug
---

# Measurement Annotation in the ASP.NET Core PDF Viewer component

The PDF Viewer provides the options to add measurement annotations. You can measure the page annotations with the help of measurement annotation. The supported measurement annotations in the PDF Viewer control are:

* Distance
* Perimeter
* Area
* Radius
* Volume

![CalibrateAnnotation](../../pdfviewer/images/calibrate_annotation.png)

## Adding a measurement annotation to the PDF document

The measurement annotations can be added to the PDF document using the annotation toolbar.

* Click the **Edit Annotation** button in the PDF Viewer toolbar. A toolbar appears below it.
* Click the **Measurement Annotation** dropdown button. A dropdown pop-up will appear and shows the measurement annotations to be added.
* Select the measurement type to be added to the page in the dropdown pop-up. It enables the selected measurement annotation mode.
* You can measure and add the annotation over the pages of the PDF document.

In the pan mode, if the measurement annotation mode is entered, the PDF Viewer control will switch to text select mode.

![CalibrateTool](../../pdfviewer/images/calibrate_tool.png)

Refer to the following code sample to switch to the distance annotation mode.

{% tabs %}
{% highlight cshtml tabtitle="Standalone" %}

<!--Element to set measurement annotation mode-->
<button id="set" onclick="addAnnot()">Distance</button>
<div style="width:100%;height:600px">
    <ejs-pdfviewer id="pdfviewer"
                   style="height:600px"
                   documentPath="https://cdn.syncfusion.com/content/pdf/pdf-succinctly.pdf">
    </ejs-pdfviewer>
</div>
<script>
    function addAnnot() {
        var pdfViewer = document.getElementById('pdfviewer').ej2_instances[0];
        pdfViewer.annotation.setAnnotationMode('Distance');
    }
</script>

{% endhighlight %}
{% highlight cshtml tabtitle="Server-Backed" %}

<!--Element to set measurement annotation mode-->
<button id="set" onclick="addAnnot()">Distance</button>
<div style="width:100%;height:600px">
    <ejs-pdfviewer id="pdfviewer"
                   style="height:600px"
                   serviceUrl="/api/PdfViewer"
                   documentPath="https://cdn.syncfusion.com/content/pdf/pdf-succinctly.pdf">
    </ejs-pdfviewer>
</div>
<script>
    function addAnnot() {
        var pdfViewer = document.getElementById('pdfviewer').ej2_instances[0];
        pdfViewer.annotation.setAnnotationMode('Distance');
    }
</script>

{% endhighlight %}
{% endtabs %}

## Adding a measurement annotation to the PDF document Programmatically

With the PDF Viewer library, you can add a measurement annotation to the PDF Viewer control programmatically using the **addAnnotation()** method.

Here's a example of how you can utilize the **addAnnotation()** method to include a measurement annotation programmatically:

{% tabs %}
{% highlight cshtml tabtitle="Standalone" %}

<button onclick="addDistanceAnnotation()">Add Distance Annotation programatically</button>
<button onclick="addPerimeterAnnotation()">Add Perimeter Annotation programatically</button>
<button onclick="addAreaAnnotation()">Add Area Annotation programatically</button>
<button onclick="addRadiusAnnotation()">Add Radius Annotation programatically</button>
<button onclick="addVolumeAnnotation()">Add Volume Annotation programatically</button>
<div style="width:100%;height:600px">
    <ejs-pdfviewer id="pdfviewer"
                   style="height:600px"
                   documentPath="https://cdn.syncfusion.com/content/pdf/pdf-succinctly.pdf">
    </ejs-pdfviewer>
</div>
<script>
    function addDistanceAnnotation() {
        var viewer = document.getElementById('pdfviewer').ej2_instances[0];
        viewer.annotation.addAnnotation("Distance", {
            offset: { x: 200, y: 230 },
            pageNumber: 1,
            vertexPoints: [{ x: 200, y: 230 }, { x: 350, y: 230 }]
        });
    }
    function addPerimeterAnnotation() {
        var viewer = document.getElementById('pdfviewer').ej2_instances[0];
        viewer.annotation.addAnnotation("Perimeter", {
            offset: { x: 200, y: 350 },
            pageNumber: 1,
            vertexPoints: [{ x: 200, y: 350 }, { x: 285, y: 350 }, { x: 286, y: 412 }]
        });
    }
    function addAreaAnnotation() {
        var viewer = document.getElementById('pdfviewer').ej2_instances[0];
        viewer.annotation.addAnnotation("Area", {
            offset: { x: 200, y: 500 },
            pageNumber: 1,
            vertexPoints: [{ x: 200, y: 500 }, { x: 288, y: 499 }, { x: 289, y: 553 }, { x: 200, y: 500 }]
        });
    }
    function addRadiusAnnotation() {
        var viewer = document.getElementById('pdfviewer').ej2_instances[0];
        viewer.annotation.addAnnotation("Radius", {
            offset: { x: 200, y: 630 },
            pageNumber: 1,
            width: 90,
            height: 90
        });
    }
    function addVolumeAnnotation() {
        var viewer = document.getElementById('pdfviewer').ej2_instances[0];
        viewer.annotation.addAnnotation("Volume", {
            offset: { x: 200, y: 810 },
            pageNumber: 1,
            vertexPoints: [{ x: 200, y: 810 }, { x: 200, y: 919 }, { x: 320, y: 919 }, { x: 320, y: 809 }, { x: 200, y: 810 }]
        });
    }
</script>

{% endhighlight %}
{% highlight cshtml tabtitle="Server-Backed" %}

<button onclick="addDistanceAnnotation()">Add Distance Annotation programatically</button>
<button onclick="addPerimeterAnnotation()">Add Perimeter Annotation programatically</button>
<button onclick="addAreaAnnotation()">Add Area Annotation programatically</button>
<button onclick="addRadiusAnnotation()">Add Radius Annotation programatically</button>
<button onclick="addVolumeAnnotation()">Add Volume Annotation programatically</button>
<div style="width:100%;height:600px">
    <ejs-pdfviewer id="pdfviewer"
                   style="height:600px"
                   serviceUrl="/api/PdfViewer"
                   documentPath="https://cdn.syncfusion.com/content/pdf/pdf-succinctly.pdf">
    </ejs-pdfviewer>
</div>
<script>
    function addDistanceAnnotation() {
        var viewer = document.getElementById('pdfviewer').ej2_instances[0];
        viewer.annotation.addAnnotation("Distance", {
            offset: { x: 200, y: 230 },
            pageNumber: 1,
            vertexPoints: [{ x: 200, y: 230 }, { x: 350, y: 230 }]
        });
    }
    function addPerimeterAnnotation() {
        var viewer = document.getElementById('pdfviewer').ej2_instances[0];
        viewer.annotation.addAnnotation("Perimeter", {
            offset: { x: 200, y: 350 },
            pageNumber: 1,
            vertexPoints: [{ x: 200, y: 350 }, { x: 285, y: 350 }, { x: 286, y: 412 }]
        });
    }
    function addAreaAnnotation() {
        var viewer = document.getElementById('pdfviewer').ej2_instances[0];
        viewer.annotation.addAnnotation("Area", {
            offset: { x: 200, y: 500 },
            pageNumber: 1,
            vertexPoints: [{ x: 200, y: 500 }, { x: 288, y: 499 }, { x: 289, y: 553 }, { x: 200, y: 500 }]
        });
    }
    function addRadiusAnnotation() {
        var viewer = document.getElementById('pdfviewer').ej2_instances[0];
        viewer.annotation.addAnnotation("Radius", {
            offset: { x: 200, y: 630 },
            pageNumber: 1,
            width: 90,
            height: 90
        });
    }
    function addVolumeAnnotation() {
        var viewer = document.getElementById('pdfviewer').ej2_instances[0];
        viewer.annotation.addAnnotation("Volume", {
            offset: { x: 200, y: 810 },
            pageNumber: 1,
            vertexPoints: [{ x: 200, y: 810 }, { x: 200, y: 919 }, { x: 320, y: 919 }, { x: 320, y: 809 }, { x: 200, y: 810 }]
        });
    }
</script>

{% endhighlight %}
{% endtabs %}

## Edit the existing measurement annotation programmatically

To modify existing measurement annotation in the Syncfusion<sup style="font-size:70%">&reg;</sup> PDF viewer programmatically, you can use the **editAnnotation()** method.

Here is an example of how you can use the **editAnnotation()** method:

{% tabs %}
{% highlight cshtml tabtitle="Standalone" %}

<button onclick="editDistanceAnnotation()">edit Distance Annotation programatically</button>
<button onclick="editPerimeterAnnotation()">edit Perimeter Annotation programatically</button>
<button onclick="editAreaAnnotation()">edit Area Annotation programatically</button>
<button onclick="editRadiusAnnotation()">edit Radius Annotation programatically</button>
<button onclick="editVolumeAnnotation()">edit Volume Annotation programatically</button>
<div style="width:100%;height:600px">
    <ejs-pdfviewer id="pdfviewer"
                   style="height:600px"
                   documentPath="https://cdn.syncfusion.com/content/pdf/pdf-succinctly.pdf">
    </ejs-pdfviewer>
</div>
<script>
    function editDistanceAnnotation() {
        var viewer = document.getElementById('pdfviewer').ej2_instances[0];
        for (let i = 0; i < viewer.annotationCollection.length; i++) {
            if (viewer.annotationCollection[i].subject === "Distance calculation") {
                viewer.annotationCollection[i].annotationSelectorSettings.resizerShape = "Circle"
                viewer.annotationCollection[i].strokeColor = "#0000FF";
                viewer.annotationCollection[i].thickness = 2;
                viewer.annotationCollection[i].fillColor = "#FFFF00";
                viewer.annotation.editAnnotation(viewer.annotationCollection[i]);
            }
        }
    }
    function editPerimeterAnnotation() {
        var viewer = document.getElementById('pdfviewer').ej2_instances[0];
        for (let i = 0; i < viewer.annotationCollection.length; i++) {
            if (viewer.annotationCollection[i].subject === "Perimeter calculation") {
                viewer.annotationCollection[i].annotationSelectorSettings.resizerShape = "Circle"
                viewer.annotationCollection[i].strokeColor = "#0000FF";
                viewer.annotationCollection[i].thickness = 2;
                viewer.annotationCollection[i].fillColor = "#FFFF00";
                viewer.annotation.editAnnotation(viewer.annotationCollection[i]);
            }
        }
    }
    function editAreaAnnotation() {
        var viewer = document.getElementById('pdfviewer').ej2_instances[0];
        for (let i = 0; i < viewer.annotationCollection.length; i++) {
            if (viewer.annotationCollection[i].subject === "Area calculation") {
                viewer.annotationCollection[i].annotationSelectorSettings.resizerShape = "Circle"
                viewer.annotationCollection[i].strokeColor = "#0000FF";
                viewer.annotationCollection[i].thickness = 2;
                viewer.annotationCollection[i].fillColor = "#FFFF00";
                viewer.annotation.editAnnotation(viewer.annotationCollection[i]);
            }
        }
    }
    function editRadiusAnnotation() {
        var viewer = document.getElementById('pdfviewer').ej2_instances[0];
        for (let i = 0; i < viewer.annotationCollection.length; i++) {
            if (viewer.annotationCollection[i].subject === "Radius calculation") {
                viewer.annotationCollection[i].annotationSelectorSettings.resizerShape = "Circle"
                viewer.annotationCollection[i].strokeColor = "#0000FF";
                viewer.annotationCollection[i].thickness = 2;
                viewer.annotationCollection[i].fillColor = "#FFFF00";
                viewer.annotation.editAnnotation(viewer.annotationCollection[i]);
            }
        }
    }
    function editVolumeAnnotation() {
        var viewer = document.getElementById('pdfviewer').ej2_instances[0];
        for (let i = 0; i < viewer.annotationCollection.length; i++) {
            if (viewer.annotationCollection[i].subject === "Volume calculation") {
                viewer.annotationCollection[i].annotationSelectorSettings.resizerShape = "Circle"
                viewer.annotationCollection[i].strokeColor = "#0000FF";
                viewer.annotationCollection[i].thickness = 2;
                viewer.annotationCollection[i].fillColor = "#FFFF00";
                viewer.annotation.editAnnotation(viewer.annotationCollection[i]);
            }
        }
    }
</script>

{% endhighlight %}
{% highlight cshtml tabtitle="Server-Backed" %}

<button onclick="editDistanceAnnotation()">edit Distance Annotation programatically</button>
<button onclick="editPerimeterAnnotation()">edit Perimeter Annotation programatically</button>
<button onclick="editAreaAnnotation()">edit Area Annotation programatically</button>
<button onclick="editRadiusAnnotation()">edit Radius Annotation programatically</button>
<button onclick="editVolumeAnnotation()">edit Volume Annotation programatically</button>
<div style="width:100%;height:600px">
    <ejs-pdfviewer id="pdfviewer"
                   style="height:600px"
                   serviceUrl="/api/PdfViewer"
                   documentPath="https://cdn.syncfusion.com/content/pdf/pdf-succinctly.pdf">
    </ejs-pdfviewer>
</div>
<script>
    function editDistanceAnnotation() {
        var viewer = document.getElementById('pdfviewer').ej2_instances[0];
        for (let i = 0; i < viewer.annotationCollection.length; i++) {
            if (viewer.annotationCollection[i].subject === "Distance calculation") {
                viewer.annotationCollection[i].annotationSelectorSettings.resizerShape = "Circle"
                viewer.annotationCollection[i].strokeColor = "#0000FF";
                viewer.annotationCollection[i].thickness = 2;
                viewer.annotationCollection[i].fillColor = "#FFFF00";
                viewer.annotation.editAnnotation(viewer.annotationCollection[i]);
            }
        }
    }
    function editPerimeterAnnotation() {
        var viewer = document.getElementById('pdfviewer').ej2_instances[0];
        for (let i = 0; i < viewer.annotationCollection.length; i++) {
            if (viewer.annotationCollection[i].subject === "Perimeter calculation") {
                viewer.annotationCollection[i].annotationSelectorSettings.resizerShape = "Circle"
                viewer.annotationCollection[i].strokeColor = "#0000FF";
                viewer.annotationCollection[i].thickness = 2;
                viewer.annotationCollection[i].fillColor = "#FFFF00";
                viewer.annotation.editAnnotation(viewer.annotationCollection[i]);
            }
        }
    }
    function editAreaAnnotation() {
        var viewer = document.getElementById('pdfviewer').ej2_instances[0];
        for (let i = 0; i < viewer.annotationCollection.length; i++) {
            if (viewer.annotationCollection[i].subject === "Area calculation") {
                viewer.annotationCollection[i].annotationSelectorSettings.resizerShape = "Circle"
                viewer.annotationCollection[i].strokeColor = "#0000FF";
                viewer.annotationCollection[i].thickness = 2;
                viewer.annotationCollection[i].fillColor = "#FFFF00";
                viewer.annotation.editAnnotation(viewer.annotationCollection[i]);
            }
        }
    }
    function editRadiusAnnotation() {
        var viewer = document.getElementById('pdfviewer').ej2_instances[0];
        for (let i = 0; i < viewer.annotationCollection.length; i++) {
            if (viewer.annotationCollection[i].subject === "Radius calculation") {
                viewer.annotationCollection[i].annotationSelectorSettings.resizerShape = "Circle"
                viewer.annotationCollection[i].strokeColor = "#0000FF";
                viewer.annotationCollection[i].thickness = 2;
                viewer.annotationCollection[i].fillColor = "#FFFF00";
                viewer.annotation.editAnnotation(viewer.annotationCollection[i]);
            }
        }
    }
    function editVolumeAnnotation() {
        var viewer = document.getElementById('pdfviewer').ej2_instances[0];
        for (let i = 0; i < viewer.annotationCollection.length; i++) {
            if (viewer.annotationCollection[i].subject === "Volume calculation") {
                viewer.annotationCollection[i].annotationSelectorSettings.resizerShape = "Circle"
                viewer.annotationCollection[i].strokeColor = "#0000FF";
                viewer.annotationCollection[i].thickness = 2;
                viewer.annotationCollection[i].fillColor = "#FFFF00";
                viewer.annotation.editAnnotation(viewer.annotationCollection[i]);
            }
        }
    }
</script>


{% endhighlight %}
{% endtabs %}

## Editing the properties of measurement annotation

The fill color, stroke color, thickness, and opacity of the measurement annotation can be edited using the Edit Color tool, Edit Stroke Color tool, Edit Thickness tool, and Edit Opacity tool in the annotation toolbar.

### Editing fill color

The fill color of the annotation can be edited using the color palette provided in the Edit Color tool.

![CalibrateFillColor](../../pdfviewer/images/calibrate_fillcolor.png)

### Editing stroke color

The stroke color of the annotation can be edited using the color palette provided in the Edit Stroke Color tool.

![CalibrateStrokeColor](../../pdfviewer/images/calibrate_stroke.png)

### Editing thickness

The thickness of the border of the annotation can be edited using the range slider provided in the Edit thickness tool.

![CalibrateThickness](../../pdfviewer/images/calibrate_thickness.png)

### Editing opacity

The opacity of the annotation can be edited using the range slider provided in the Edit Opacity tool.

![CalibrateOpacity](../../pdfviewer/images/calibrate_opacity.png)

### Editing the line properties

The properties of the line shapes such as distance and perimeter annotations can be edited using the Line properties window. It can be opened by selecting the Properties option in the context menu that appears on right-clicking the distance and perimeter annotations.

![CalibrateProperty](../../pdfviewer/images/calibrate_lineprop.png)

## Setting default properties during control initialization

The properties of the shape annotations can be set before creating the control using DistanceSettings, PerimeterSettings, AreaSettings, RadiusSettings, and VolumeSettings.
Refer to the following code sample to set the default annotation settings.

{% tabs %}
{% highlight cshtml tabtitle="Standalone" %}

<div style="width:100%;height:600px">
    <ejs-pdfviewer id="pdfviewer"
                   style="height:600px"
                   documentPath="https://cdn.syncfusion.com/content/pdf/pdf-succinctly.pdf"
                   distanceSettings="@(new Syncfusion.EJ2.PdfViewer.PdfViewerDistanceSettings
            {FillColor="blue", Opacity=0.6, StrokeColor="green"})"
                   perimeterSettings="@(new Syncfusion.EJ2.PdfViewer.PdfViewerPerimeterSettings
            {FillColor="green", Opacity=0.6, StrokeColor="blue"})"
                   areaSettings="@(new Syncfusion.EJ2.PdfViewer.PdfViewerAreaSettings
            {FillColor="yellow", Opacity=0.6, StrokeColor="orange"})"
                   radiusSettings="@(new Syncfusion.EJ2.PdfViewer.PdfViewerRadiusSettings
            {FillColor="orange", Opacity=0.6, StrokeColor="pink"})"
                   volumeSettings="@(new Syncfusion.EJ2.PdfViewer.PdfViewerVolumeSettings
            {FillColor="pink", Opacity=0.6, StrokeColor="yellow"})">
    </ejs-pdfviewer>
</div>

{% endhighlight %}
{% highlight cshtml tabtitle="Server-Backed" %}

<div style="width:100%;height:600px">
    <ejs-pdfviewer id="pdfviewer"
                   style="height:600px"
                   serviceUrl="/api/PdfViewer"
                   documentPath="https://cdn.syncfusion.com/content/pdf/pdf-succinctly.pdf"
                   distanceSettings="@(new Syncfusion.EJ2.PdfViewer.PdfViewerDistanceSettings
            {FillColor="blue", Opacity=0.6, StrokeColor="green"})"
                   perimeterSettings="@(new Syncfusion.EJ2.PdfViewer.PdfViewerPerimeterSettings
            {FillColor="green", Opacity=0.6, StrokeColor="blue"})"
                   areaSettings="@(new Syncfusion.EJ2.PdfViewer.PdfViewerAreaSettings
            {FillColor="yellow", Opacity=0.6, StrokeColor="orange"})"
                   radiusSettings="@(new Syncfusion.EJ2.PdfViewer.PdfViewerRadiusSettings
            {FillColor="orange", Opacity=0.6, StrokeColor="pink"})"
                   volumeSettings="@(new Syncfusion.EJ2.PdfViewer.PdfViewerVolumeSettings
            {FillColor="pink", Opacity=0.6, StrokeColor="yellow"})">
    </ejs-pdfviewer>
</div>

{% endhighlight %}
{% endtabs %}

## Editing scale ratio and unit of the measurement annotation

The scale ratio and unit of measurement can be modified using the scale ratio option provided in the context menu of the PDF Viewer control.

![CalibrateScaleRatio](../../pdfviewer/images/calibrate_scaleratio.png)

The Units of measurements supported for the measurement annotations in the PDF Viewer are:

* Inch
* Millimeter
* Centimeter
* Point
* Pica
* Feet

![CalibrateScaleDialog](../../pdfviewer/images/calibrate_scaledialog.png)

## Setting default scale ratio settings during the control initialization

The properties of scale ratio for measurement annotation can be set before creating the control using the ScaleRatioSettings as shown in the following code sample.

{% tabs %}
{% highlight cshtml tabtitle="Standalone" %}

<div style="width:100%;height:600px">
    <ejs-pdfviewer id="pdfviewer"
                   style="height:600px"
                   documentPath="https://cdn.syncfusion.com/content/pdf/pdf-succinctly.pdf"
                   measurementSettings="@(new Syncfusion.EJ2.PdfViewer.PdfViewerMeasurementSettings
            {ScaleRatio=2, ConversionUnit=Syncfusion.EJ2.PdfViewer.CalibrationUnit.Cm})">
    </ejs-pdfviewer>
</div>

{% endhighlight %}
{% highlight cshtml tabtitle="Server-Backed" %}

<div style="width:100%;height:600px">
    <ejs-pdfviewer id="pdfviewer"
                   style="height:600px"
                   serviceUrl="/api/PdfViewer"
                   documentPath="https://cdn.syncfusion.com/content/pdf/pdf-succinctly.pdf"
                   measurementSettings="@(new Syncfusion.EJ2.PdfViewer.PdfViewerMeasurementSettings
            {ScaleRatio=2, ConversionUnit=Syncfusion.EJ2.PdfViewer.CalibrationUnit.Cm})">
    </ejs-pdfviewer>
</div>

{% endhighlight %}
{% endtabs %}