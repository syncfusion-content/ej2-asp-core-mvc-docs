---
layout: post
title: Get Page Info in EJ2 ASP.NET MVC PDF Viewer | Syncfusion
description: Learn here all about Get Page Info in ASP.NET MVC PDF Viewer component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: PDF Viewer
publishingplatform: ##Platform_Name##
documentation: ug
---

# Get Page Info from PDF document

The PDF Viewer library allows you to retrieves the information of a specified page in the viewer using the **getPageInfo()** method.This provides essential information such as the height, width and rotation.

The following steps are used to getPageInfo.

**Step 1:** Follow the steps provided in the [link](https://ej2.syncfusion.com/aspnetmvc/documentation/pdfviewer/getting-started/) to create a simple PDF Viewer sample.

**Step 2:** The following code snippet to implement the functionality for retrieving height, width and rotation of a specified page in the viewer.

{% tabs %}
{% highlight cshtml tabtitle="Standalone" %}

<button type="button" onclick="getPageInfo()">getPageInfo</button>
<div style="width:100%;height:600px">
    @Html.EJS().PdfViewer("pdfviewer").DocumentPath("https://cdn.syncfusion.com/content/pdf/hive-succinctly.pdf").Render()
</div>

<script>
    function getPageInfo() {
        let pageInfo;
        let pageIndex: number = 0;
        var viewer = document.getElementById('pdfviewer').ej2_instances[0];
        viewer.getPageInfo(pageIndex).then(function (value) {
            pageInfo = value;
            //The height of the page in points.
            let height = pageInfo.height;
            //The width of the page in points.
            let width = pageInfo.width;
            //The rotation angle of the page in degrees.
            let rotation = pageInfo.rotation;
        });
    }
</script>

{% endhighlight %}
{% endtabs %}

By following these steps, you can successfully integrate and use the get page info API in the EJ2 PDF Viewer.