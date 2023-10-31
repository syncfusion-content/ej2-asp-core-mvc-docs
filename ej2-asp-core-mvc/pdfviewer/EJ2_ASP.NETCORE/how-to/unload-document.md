---
layout: post
title: Unload Document in ##Platform_Name## Pdfviewer Component
description: Learn here all about Unload Document in Syncfusion ##Platform_Name## Pdfviewer component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Unload Document
publishingplatform: ##Platform_Name##
documentation: ug
---

# Unload the PDF document programmatically

The PDF Viewer library allows you to unload the PDF document being displayed in the PDF Viewer control programmatically using the [**unload()**](https://ej2.syncfusion.com/documentation/api/pdfviewer/#unload) method.

The following steps are used to unload the PDF document programmatically.

**Step 1:** Follow the steps provided in the [link](https://ej2.syncfusion.com/aspnetcore/documentation/pdfviewer/getting-started/) to create a simple PDF Viewer sample.

**Step 2:** Add the following code snippet to perform the unload operation.

{% tabs %}
{% highlight cshtml tabtitle="Standalone" %}

<button type="button" onclick="unload()">Unload Document</button>

<div style="width:100%;height:600px">
    <ejs-pdfviewer 
        id="pdfviewer"
        documentPath="https://cdn.syncfusion.com/content/pdf/pdf-succinctly.pdf">
    </ejs-pdfviewer>
</div>

<script>
    // Unload the PDF document.
    function unload() {
        var viewer = document.getElementById('pdfviewer').ej2_instances[0];
        viewer.unload();
    }
</script>

{% endhighlight %}
{% highlight cshtml tabtitle="Server-Backed" %}

<button type="button" onclick="unload()">Unload Document</button>

<div style="width:100%;height:600px">
    <ejs-pdfviewer 
        id="pdfviewer"
        serviceUrl='/Index'
        documentPath="https://cdn.syncfusion.com/content/pdf/pdf-succinctly.pdf">
    </ejs-pdfviewer>
</div>

<script>
    // Unload the PDF document.
    function unload() {
        var viewer = document.getElementById('pdfviewer').ej2_instances[0];
        viewer.unload();
    }
</script>

{% endhighlight %}
{% endtabs %}


[View sample in GitHub](https://github.com/SyncfusionExamples/asp-core-pdf-viewer-examples/tree/master/How%20to/Unload%20the%20PDF%20document%20programmatically)