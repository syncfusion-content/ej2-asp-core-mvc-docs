---
layout: post
title: Sticky Notes Annotation in EJ2 ASP.NET CORE PDF Viewer | Syncfusion
description: Learn here all about Sticky Notes Annotation in ASP.NET CORE PDF Viewer component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Sticky Notes Annotation
publishingplatform: ##Platform_Name##
documentation: ug
---

# Sticky Notes Annotation in the ASP.NET Core PDF Viewer component

The PDF Viewer control provides the options to add, edit, and delete the sticky note annotations in the PDF document.

![StickyNotesAnnotation](../../pdfviewer/images/stickynotes_annotation.png)

## Adding a sticky note annotation to the PDF document

Sticky note annotations can be added to the PDF document using the annotation toolbar.

* Click the **Comments** button in the PDF Viewer toolbar. A toolbar appears below it.
* Click the position where you want to add sticky note annotation in the PDF document.
* Sticky note annotation will be added in the clicked positions.

![StickyNotesTool](../../pdfviewer/images/stickynotes_tool.png)

Annotation comments can be added to the PDF document using the comment panel.

* Select a Sticky note annotation in the PDF document and right-click it.
* Select the Comment option in the context menu that appears.
* Now, you can add Comments, Reply, and Status using the Comment Panel.
* Now, you can add Comments, Reply, and Status using the Comment Panel.

![StickyNotesComment](../../pdfviewer/images/stickynotes_comment.png)

## Editing the properties of the sticky note annotation

### Editing opacity

The opacity of the annotation can be edited using the range slider provided in the Edit Opacity tool.

![StickyNotesOpacity](../../pdfviewer/images/sticky_opacity.png)

### Editing comments

The comment, comment reply, and comment status of the annotation can be edited using the Comment Panel.

* Open the comment panel using the Comment Panel button showing in the annotation toolbar.

![StickyNotesComment](../../pdfviewer/images/commentPanel.png)

You can modify or delete the comments or comments replay and it’s status using the menu option provided in the comment panel.

![StickyNotesEdit](../../pdfviewer/images/sticky_editbtn.png)

## Adding a sticky note annotation to the PDF document Programmatically

With the PDF Viewer library, you can add a sticky note annotation to the PDF Viewer control programmatically using the **addAnnotation()** method.

Here's a example of how you can utilize the **addAnnotation()** method to include a sticky note annotation programmatically:

{% tabs %}
{% highlight cshtml tabtitle="Standalone" %}

<button id="set" onclick="addAnnotation()">Add annotation programmatically</button>
<div style="width:100%;height:600px">
    <ejs-pdfviewer id="pdfviewer"
                   style="height:600px"
                   documentPath="https://cdn.syncfusion.com/content/pdf/pdf-succinctly.pdf">
    </ejs-pdfviewer>
</div>
<script>
  function addAnnotation() {
    var viewer = document.getElementById('pdfviewer').ej2_instances[0];
    viewer.annotation.addAnnotation("StickyNotes", {
      offset: { x: 100, y: 200 },
      pageNumber: 1,
      isLock: false
    });
  }
</script>

{% endhighlight %}
{% highlight cshtml tabtitle="Server-Backed" %}

<button id="set" onclick="addAnnotation()">Add annotation programmatically</button>
<div style="width:100%;height:600px">
    <ejs-pdfviewer id="pdfviewer"
                   style="height:600px"
                   serviceUrl="/api/PdfViewer"
                   documentPath="https://cdn.syncfusion.com/content/pdf/pdf-succinctly.pdf">
    </ejs-pdfviewer>
</div>
<script>
  function addAnnotation() {
    var viewer = document.getElementById('pdfviewer').ej2_instances[0];
    viewer.annotation.addAnnotation("StickyNotes", {
      offset: { x: 100, y: 200 },
      pageNumber: 1,
      isLock: false
    });
  }
</script>

{% endhighlight %}
{% endtabs %}

## Edit the existing sticky note annotation programmatically

To modify existing sticky note annotation in the Syncfusion<sup style="font-size:70%">&reg;</sup> PDF viewer programmatically, you can use the **editAnnotation()** method.

Here is an example of how you can use the **editAnnotation()** method:

{% tabs %}
{% highlight cshtml tabtitle="Standalone" %}

<button id="set" onclick="editAnnotation()">Edit annotation programmatically</button>
<div style="width:100%;height:600px">
    <ejs-pdfviewer id="pdfviewer"
                   style="height:600px"
                   documentPath="https://cdn.syncfusion.com/content/pdf/pdf-succinctly.pdf">
    </ejs-pdfviewer>
</div>
<script>
  function editAnnotation() {
    var viewer = document.getElementById('pdfviewer').ej2_instances[0];
    for (let i = 0; i < viewer.annotationCollection.length; i++) 
    {
      if (viewer.annotationCollection[i].shapeAnnotationType === "sticky") {
        var width = viewer.annotationCollection[i].bounds.width;
        var height = viewer.annotationCollection[i].bounds.height;
        viewer.annotationCollection[i].bounds = {x : 100, y: 100, width: width, height: height }; 
        viewer.annotation.editAnnotation(viewer.annotationCollection[i]);
      }
    }
  }
</script>

{% endhighlight %}
{% highlight cshtml tabtitle="Server-Backed" %}

<button id="set" onclick="editAnnotation()">Edit annotation programmatically</button>
<div style="width:100%;height:600px">
    <ejs-pdfviewer id="pdfviewer"
                   style="height:600px"
                   serviceUrl="/api/PdfViewer"
                   documentPath="https://cdn.syncfusion.com/content/pdf/pdf-succinctly.pdf">
    </ejs-pdfviewer>
</div>
<script>
  function editAnnotation() {
    var viewer = document.getElementById('pdfviewer').ej2_instances[0];
    for (let i = 0; i < viewer.annotationCollection.length; i++) 
    {
      if (viewer.annotationCollection[i].shapeAnnotationType === "sticky") {
        var width = viewer.annotationCollection[i].bounds.width;
        var height = viewer.annotationCollection[i].bounds.height;
        viewer.annotationCollection[i].bounds = {x : 100, y: 100, width: width, height: height }; 
        viewer.annotation.editAnnotation(viewer.annotationCollection[i]);
      }
    }
  }
</script>

{% endhighlight %}
{% endtabs %}

## Setting default properties during the control initialization

The properties of the sticky note annotation can be set before creating the control using the StickyNotesSettings.

After editing the default opacity using the Edit Opacity tool, they will be changed to the selected values. Refer to the following code sample to set the default sticky note annotation settings.

{% tabs %}
{% highlight cshtml tabtitle="Standalone" %}

<div style="width:100%;height:600px">
    <ejs-pdfviewer id="pdfviewer"
                   style="height:600px"
                   documentPath="https://cdn.syncfusion.com/content/pdf/pdf-succinctly.pdf"
                   stickyNotesSettings="@(new Syncfusion.EJ2.PdfViewer.PdfViewerStickyNotesSettings
            {Author="Syncfusion"})">
    </ejs-pdfviewer>
</div>

{% endhighlight %}
{% highlight cshtml tabtitle="Server-Backed" %}

<div style="width:100%;height:600px">
    <ejs-pdfviewer id="pdfviewer"
                   style="height:600px"
                   serviceUrl="/api/PdfViewer"
                   documentPath="https://cdn.syncfusion.com/content/pdf/pdf-succinctly.pdf"
                   stickyNotesSettings="@(new Syncfusion.EJ2.PdfViewer.PdfViewerStickyNotesSettings
            {Author="Syncfusion"})">
    </ejs-pdfviewer>
</div>

{% endhighlight %}
{% endtabs %}

## Disabling sticky note annotations

The PDF Viewer control provides an option to disable the sticky note annotations feature. The code sample for disabling the feature is as follows.

{% tabs %}
{% highlight cshtml tabtitle="Standalone" %}

<div style="width:100%;height:600px">
    <ejs-pdfviewer id="pdfviewer"
                   style="height:600px"
                   enableStickyNotesAnnotation=false
                   documentPath="https://cdn.syncfusion.com/content/pdf/pdf-succinctly.pdf">
    </ejs-pdfviewer>
</div>

{% endhighlight %}
{% highlight cshtml tabtitle="Server-Backed" %}

<div style="width:100%;height:600px">
    <ejs-pdfviewer id="pdfviewer"
                   style="height:600px"
                   enableStickyNotesAnnotation=false
                   serviceUrl="/api/PdfViewer"
                   documentPath="https://cdn.syncfusion.com/content/pdf/pdf-succinctly.pdf">
    </ejs-pdfviewer>
</div>

{% endhighlight %}
{% endtabs %}