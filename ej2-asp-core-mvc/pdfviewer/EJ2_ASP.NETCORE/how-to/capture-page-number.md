---
layout: post
title: Capture Page Number in ##Platform_Name## Pdfviewer Component
description: Learn here all about Capture Page Number in Syncfusion ##Platform_Name## Pdfviewer component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Capture Page Number
publishingplatform: ##Platform_Name##
documentation: ug
---

# Capture the current page number being viewed

The PDF Viewer server library allows you to capture the page number that is currently being viewed in the load PDF document. Use the [**currentPageNumber**](https://ej2.syncfusion.com/javascript/documentation/api/pdfviewer/#currentpagenumber) property to get the page number which is currently in view.

The following steps are used to capture the current page number.

**Step 1:** Follow the steps provided in the [link](https://ej2.syncfusion.com/aspnetcore/documentation/pdfviewer/getting-started/) to create a simple PDF Viewer sample.

**Step 2:** Use the following code snippet to Capture the current page number being viewed.


{% tabs %}
{% highlight html tabtitle="Standalone" %}

<button onclick="currentPage()">currentpage</button>

<div style="width:100%;height:600px">
    <ejs-pdfviewer 
        id="pdfviewer"
        documentPath="https://cdn.syncfusion.com/content/pdf/pdf-succinctly.pdf">
    </ejs-pdfviewer>
</div>

<script>
    function currentPage() {
        var viewer = document.getElementById('pdfviewer').ej2_instances[0];
        var pageNumber = viewer.currentPageNumber;
        alert("current page number is" + pageNumber);
    }
</script>

{% endhighlight %}
{% highlight html tabtitle="Server-Backed" %}

<button onclick="currentPage()">currentpage</button>

<div style="width:100%;height:600px">
    <ejs-pdfviewer 
        id="pdfviewer"
        documentPath="https://cdn.syncfusion.com/content/pdf/pdf-succinctly.pdf"
        serviceUrl='/Index'>
    </ejs-pdfviewer>
</div>

<script>
    function currentPage() {
        var viewer = document.getElementById('pdfviewer').ej2_instances[0];
        var pageNumber = viewer.currentPageNumber;
        alert("current page number is" + pageNumber);
    }
</script>

{% endhighlight %}
{% endtabs %}

[View sample in GitHub]()