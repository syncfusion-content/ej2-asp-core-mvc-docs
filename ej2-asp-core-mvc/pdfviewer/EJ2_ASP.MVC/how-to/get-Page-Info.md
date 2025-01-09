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

@using Syncfusion.EJ2
@{
    ViewBag.Title = "Home Page";
}

<div>
    <div style="height:500px;width:100%;">
        <!-- Button to trigger Page Info retrieval -->
        <button id="getPageInfo">GetPageInfo</button>
        <!-- Render PDF Viewer -->
        @Html.EJS().PdfViewer("pdfviewer").DocumentPath("https://cdn.syncfusion.com/content/pdf/pdf-succinctly.pdf").Render()
    </div>
</div>

<!-- Ensure necessary Syncfusion scripts and styles are included -->
<script src="https://cdn.syncfusion.com/ej2/27.2.4/dist/ej2.min.js"></script>
<script type="text/javascript">
    window.onload = function () {
        var viewer = document.getElementById('pdfviewer').ej2_instances[0];
        // Add event listener for retrieving page information
        document.getElementById('getPageInfo').addEventListener('click', function () {
            retrievePageInfo();
        });
        function retrievePageInfo() {
            if (viewer) {
                // Set the page index for which info is required
                const pageIndex = 0;
                // To Retrieve and log the page information
                console.log(viewer.getPageInfo(pageIndex));
                // To Log the specific page information details to the console
                var pageInfo = viewer.getPageInfo(pageIndex);
                if (pageInfo) {
                    console.log(`Page Info for Page Index ${pageIndex}:`);
                    console.log(`Height: ${pageInfo.height}`);
                    console.log(`Width: ${pageInfo.width}`);
                    console.log(`Rotation: ${pageInfo.rotation}`);
                }
            }
        }
    };
</script>

{% endhighlight %}
{% endtabs %}

By following these steps, you can successfully integrate and use the get page info API in the EJ2 PDF Viewer.

[View Sample in GitHub](https://github.com/SyncfusionExamples/mvc-pdf-viewer-examples/tree/master/How%20to)