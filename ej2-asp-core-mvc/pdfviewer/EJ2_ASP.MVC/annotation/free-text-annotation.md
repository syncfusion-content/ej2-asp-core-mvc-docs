---
layout: post
title: Free Text Annotation in EJ2 ASP.NET MVC PDF Viewer | Syncfusion
description: Learn here all about Free Text Annotation in ASP.NET MVC PDF Viewer component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Free Text Annotation
publishingplatform: ##Platform_Name##
documentation: ug
---

# Free Text Annotation in the ASP.NET MVC PDF Viewer component

The PDF Viewer control provides the options to add, edit, and delete the free text annotations.

## Adding a free text annotation to the PDF document

The Free text annotations can be added to the PDF document using the annotation toolbar.

* Click the **Edit Annotation** button in the PDF Viewer toolbar. A toolbar appears below it.
* Select the **Free Text Annotation** button in the annotation toolbar. It enables the Free Text annotation mode.
* You can add the text over the pages of the PDF document.

In the pan mode, if the free text annotation mode is entered, the PDF Viewer control will switch to text select mode.

![FreeTextAnnotation in ASP.NET MVC PDF Viewer](../images/freetext_tool.png)

Refer to the following code sample to switch to the Free Text annotation mode.

{% tabs %}
{% highlight html tabtitle="Standalone" %}


<!--Element to set free text annotation mode-->
<button id="set" onclick="addAnnot()">FreeText</button>
<div style="width:100%;height:600px">
    @Html.EJS().PdfViewer("pdfviewer").DocumentPath("https://cdn.syncfusion.com/content/pdf/pdf-succinctly.pdf").Render()
</div>
<script>
    function addAnnot() {
        var pdfViewer = document.getElementById('pdfviewer').ej2_instances[0];
        pdfViewer.annotation.setAnnotationMode('FreeText');
    }
</script>

{% endhighlight %}

{% highlight html tabtitle="Server-Backed" %}

<!--Element to set free text annotation mode-->
<button id="set" onclick="addAnnot()">FreeText</button>
<div style="width:100%;height:600px">
    @Html.EJS().PdfViewer("pdfviewer").ServiceUrl(VirtualPathUtility.ToAbsolute("~/PdfViewer/")).DocumentPath("https://cdn.syncfusion.com/content/pdf/pdf-succinctly.pdf").Render()
</div>
<script>
    function addAnnot() {
        var pdfViewer = document.getElementById('pdfviewer').ej2_instances[0];
        pdfViewer.annotation.setAnnotationMode('FreeText');
       }
</script>

{% endhighlight %}
{% endtabs %}

## Adding a free text annotation programmatically to the PDF document

The PDF Viewer library allows you to add the free text annotation in the PDF Viewer control programmatically using the **addAnnotation()** method.

Here is an example of how you can use the **addAnnotation()** method to move the free text annotation programmatically:

{% tabs %}
{% highlight html tabtitle="Standalone" %}

<button id="set" onclick="addAnnotation()">Add annotation programmatically</button>

<div style="width:100%;height:600px">
    @Html.EJS().PdfViewer("pdfviewer").DocumentPath("https://cdn.syncfusion.com/content/pdf/pdf-succinctly.pdf").Render()
</div>

<script>
    function addAnnotation() {
        var pdfViewer = document.getElementById('pdfviewer').ej2_instances[0];
        pdfViewer.annotation.addAnnotation("FreeText", {
            offset: { x: 100, y: 150 },
            fontSize: 16,
            fontFamily: "Helvetica",
            pageNumber: 1,
            width: 200,
            height: 40,
            isLock: false,
            textAlignment: 'Center',
            borderStyle: 'solid',
            borderWidth: 2,
            borderColor: 'red',
            fillColor: 'blue',
            fontColor: 'white',
            defaultText: "Syncfusion"
        });
    }
</script>

{% endhighlight %}
{% highlight html tabtitle="Server-Backed" %}

<button id="set" onclick="addAnnotation()">Add annotation programmatically</button>

<div style="width:100%;height:600px">
    @Html.EJS().PdfViewer("pdfviewer").ServiceUrl(VirtualPathUtility.ToAbsolute("~/PdfViewer/")).DocumentPath("https://cdn.syncfusion.com/content/pdf/pdf-succinctly.pdf").Render()
</div>

<script>
    function addAnnotation() {
        var pdfViewer = document.getElementById('pdfviewer').ej2_instances[0];
        pdfViewer.annotation.addAnnotation("FreeText", {
            offset: { x: 100, y: 150 },
            fontSize: 16,
            fontFamily: "Helvetica",
            pageNumber: 1,
            width: 200,
            height: 40,
            isLock: false,
            textAlignment: 'Center',
            borderStyle: 'solid',
            borderWidth: 2,
            borderColor: 'red',
            fillColor: 'blue',
            fontColor: 'white',
            defaultText: "Syncfusion"
        });
    }
</script>

{% endhighlight %}
{% endtabs %}

## Change the content of an existing Free text annotation programmatically

To change the content of an existing free text annotation in the Syncfusion<sup style="font-size:70%">&reg;</sup> PDF viewer programmatically, you can use the **editAnnotation()** method.

Here is an example of how you can use the **editAnnotation()** method to change the content of a free text annotation:

{% tabs %}
{% highlight html tabtitle="Standalone" %}

<button id="set" onclick="editAnnotation()">Edit annotation programmatically</button>

<div style="width:100%;height:600px">
    @Html.EJS().PdfViewer("pdfviewer").DocumentPath("https://cdn.syncfusion.com/content/pdf/pdf-succinctly.pdf").Render()
</div>

<script>
    function editAnnotation() {
        var viewer = document.getElementById('pdfviewer').ej2_instances[0];
        for (let i = 0; i < viewer.annotationCollection.length; i++) {
            if (viewer.annotationCollection[i].subject === "Text Box") {
                var width = viewer.annotationCollection[i].bounds.width;
                var height = viewer.annotationCollection[i].bounds.height;
                viewer.annotationCollection[i].bounds = { x: 100, y: 100, width: width, height: height };
                viewer.annotationCollection[i].dynamicText = 'syncfusion';
                viewer.annotation.editAnnotation(viewer.annotationCollection[i]);
            }
        }
    }
</script>

{% endhighlight %}
{% highlight html tabtitle="Server-Backed" %}

<button id="set" onclick="editAnnotation()">Edit annotation programmatically</button>

<div style="width:100%;height:600px">
    @Html.EJS().PdfViewer("pdfviewer").ServiceUrl(VirtualPathUtility.ToAbsolute("~/PdfViewer/")).DocumentPath("https://cdn.syncfusion.com/content/pdf/pdf-succinctly.pdf").Render()
</div>

<script>
    function editAnnotation() {
        var viewer = document.getElementById('pdfviewer').ej2_instances[0];
        for (let i = 0; i < viewer.annotationCollection.length; i++) {
            if (viewer.annotationCollection[i].subject === "Text Box") {
                var width = viewer.annotationCollection[i].bounds.width;
                var height = viewer.annotationCollection[i].bounds.height;
                viewer.annotationCollection[i].bounds = { x: 100, y: 100, width: width, height: height };
                viewer.annotationCollection[i].dynamicText = 'syncfusion';
                viewer.annotation.editAnnotation(viewer.annotationCollection[i]);
            }
        }
    }
</script>

{% endhighlight %}
{% endtabs %}

## Editing the properties of free text annotation

The font family, font size, font styles, font color, text alignment, fill color, the border stroke color, border thickness, and opacity of the free text annotation can be edited using the Font Family tool, Font Size tool, Font Color tool, Text Align tool, Font Style tool  Edit Color tool, Edit Stroke Color tool, Edit Thickness tool, and Edit Opacity tool in the annotation toolbar.

### Editing font family

The font family of the annotation can be edited by selecting the desired font in the Font Family tool.

![FontFamily](../images/fontfamily.png)

### Editing font size

The font size of the annotation can be edited by selecting the desired size in the Font Size tool.

![FontSize](../images/fontsize.png)

### Editing font color

The font color of the annotation can be edited using the color palette provided in the Font Color tool.

![FontColor](../images/fontcolor.png)

### Editing the text alignment

The text in the annotation can be aligned by selecting the desired styles in the drop-down pop-up in the Text Align tool.

![FreeTextAnnotation](../images/textalign.png)

### Editing text styles

The style of the text in the annotation can be edited by selecting the desired styles in the drop-down pop-up in the Font Style tool.

![FontStyle](../images/fontstyle.png)

### Editing fill color

The fill color of the annotation can be edited using the color palette provided in the Edit Color tool.

![FillColor](../images/fillcolor.png)

### Editing stroke color

The stroke color of the annotation can be edited using the color palette provided in the Edit Stroke Color tool.

![StrokeColor](../images/fontstroke.png)

### Editing thickness

The border thickness of the annotation can be edited using the range slider provided in the Edit Thickness tool.

![FontThickness](../images/fontthickness.png)

### Editing opacity

The opacity of the annotation can be edited using the range slider provided in the Edit Opacity tool.

![FontOpacity](../images/fontopacity.png)

## Setting default properties during control initialization

The properties of the free text annotation can be set before creating the control using the FreeTextSettings.

After editing the default values, they will be changed to the selected values.
Refer to the following code sample to set the default free text annotation settings.

{% tabs %}
{% highlight html tabtitle="Standalone" %}

<div style="width:100%;height:600px">
    @Html.EJS().PdfViewer("pdfviewer").DocumentPath("https://cdn.syncfusion.com/content/pdf/pdf-succinctly.pdf").FreeTextSettings(new Syncfusion.EJ2.PdfViewer.PdfViewerFreeTextSettings { FillColor = "green", BorderColor = "blue", FontColor = "yellow" }).Render()
</div>

{% endhighlight %}
{% highlight html tabtitle="Server-Backed" %}

<div style="width:100%;height:600px">
    @Html.EJS().PdfViewer("pdfviewer").ServiceUrl(VirtualPathUtility.ToAbsolute("~/PdfViewer/")).DocumentPath("https://cdn.syncfusion.com/content/pdf/pdf-succinctly.pdf").FreeTextSettings(new Syncfusion.EJ2.PdfViewer.PdfViewerFreeTextSettings { FillColor = "green", BorderColor = "blue", FontColor = "yellow" }).Render()
</div>

{% endhighlight %}
{% endtabs %}

You can also enable the autofit support for free text annotation by using the EnableAutoFit boolean property in FreeTextSettings as below. The width of the free text rectangle box will be increased based on the text added to it.

{% tabs %}
{% highlight html tabtitle="Standalone" %}

<div style="width:100%;height:600px">
    @Html.EJS().PdfViewer("pdfviewer").DocumentPath("https://cdn.syncfusion.com/content/pdf/pdf-succinctly.pdf").FreeTextSettings(new Syncfusion.EJ2.PdfViewer.PdfViewerFreeTextSettings { EnableAutoFit = true }).Render()
</div>

{% endhighlight %}
{% highlight html tabtitle="Server-Backed" %}

<div style="width:100%;height:600px">
    @Html.EJS().PdfViewer("pdfviewer").ServiceUrl(VirtualPathUtility.ToAbsolute("~/PdfViewer/")).DocumentPath("https://cdn.syncfusion.com/content/pdf/pdf-succinctly.pdf").FreeTextSettings(new Syncfusion.EJ2.PdfViewer.PdfViewerFreeTextSettings { EnableAutoFit = true }).Render()
</div>

{% endhighlight %}
{% endtabs %}