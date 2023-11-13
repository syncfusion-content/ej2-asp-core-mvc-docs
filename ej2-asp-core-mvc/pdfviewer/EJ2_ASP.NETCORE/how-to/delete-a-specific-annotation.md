---
layout: post
title: Delete A Specific Annotation in ##Platform_Name## Pdfviewer Component
description: Learn here all about Delete A Specific Annotation in Syncfusion ##Platform_Name## Pdfviewer component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Delete A Specific Annotation
publishingplatform: ##Platform_Name##
documentation: ug
---

# Delete a specific annotation using deleteAnnotationById

The PDF Viewer server library allows you to delete a specific annotation from PDF document. Deleting a specific annotation can be done using the **deleteAnnotationById()** method. This method is used to delete a specific annotation using its id.

The following steps are used to delete a specific annotation from PDF Document.

**Step 1:** Follow the steps provided in the [link](https://ej2.syncfusion.com/aspnetcore/documentation/pdfviewer/getting-started/) to create simple PDF Viewer sample.

**Step 2:** Use the following code snippet to delete a specific annotation using deleteAnnotationById() method.


{% tabs %}
{% highlight cshtml tabtitle="Standalone" %}

<button onclick="deleteAnnotationbyId()">deleteAnnotationbyId</button>

<div style="width:100%;height:600px">
    <ejs-pdfviewer 
        id="pdfviewer"
        documentPath="https://cdn.syncfusion.com/content/pdf/pdf-succinctly.pdf">
    </ejs-pdfviewer>
</div>


<script>
    function deleteAnnotationbyId() {
        var viewer = document.getElementById('pdfviewer').ej2_instances[0];
        viewer.annotationModule.deleteAnnotationById(viewer.annotationCollection[0].annotationId);
    }
</script>

{% endhighlight %}
{% highlight cshtml tabtitle="Server-Backed" %}

<button onclick="deleteAnnotationbyId()">deleteAnnotationbyId</button>

<div style="width:100%;height:600px">
    <ejs-pdfviewer 
        id="pdfviewer"
        serviceUrl='/Index'
        documentPath="https://cdn.syncfusion.com/content/pdf/pdf-succinctly.pdf">
    </ejs-pdfviewer>
</div>

<script>
    function deleteAnnotationbyId() {
        var viewer = document.getElementById('pdfviewer').ej2_instances[0];
        viewer.annotationModule.deleteAnnotationById(viewer.annotationCollection[0].annotationId);
    }
</script>

{% endhighlight %}
{% endtabs %}


[View sample in GitHub](https://github.com/SyncfusionExamples/asp-core-pdf-viewer-examples/tree/master/How%20to/Delete%20a%20specific%20annotation%20using%20deleteAnnotationById)