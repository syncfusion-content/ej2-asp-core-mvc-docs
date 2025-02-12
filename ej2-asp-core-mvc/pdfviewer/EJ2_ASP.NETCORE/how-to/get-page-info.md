---
layout: post
title: Get Page Info with EJ2 ASP.NET Core PDF Viewer Control | Syncfusion
description: Learn here all about Get Page Info in Syncfusion ##Platform_Name## Pdfviewer component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: PDF Viewer
publishingplatform: ##Platform_Name##
documentation: ug
---

# Get Page Info in ASP.NET Core PDF Viewer control

The PDF Viewer library allows you to retrieves the information of a specified page in the viewer using the **getPageInfo()** method.This provides essential information such as the height, width and rotation.

The following steps are used to getPageInfo.

**Step 1:** Follow the steps provided in the [link](https://ej2.syncfusion.com/aspnetcore/documentation/pdfviewer/getting-started/) to create a simple PDF Viewer sample.

**Step 2:** The following code snippet to implement the functionality for retrieving height, width and rotation of a specified page in the viewer.

{% tabs %}
{% highlight cshtml tabtitle="Standalone" %}

@page "{handler?}"
@model IndexModel
@{
    ViewData["Title"] = "Home page";
}

<div class="text-center">
    <button id="getPageInfo">Get Page Info</button>
    <ejs-pdfviewer id="pdfviewer" style="height:600px" resourceUrl="https://cdn.syncfusion.com/ej2/27.2.2/dist/ej2-pdfviewer-lib" documentPath="https://cdn.syncfusion.com/content/pdf/pdf-succinctly.pdf">
    </ejs-pdfviewer>
</div>

<script type="text/javascript">
document.addEventListener('DOMContentLoaded', function () {
    var pdfViewer = document.getElementById('pdfviewer').ej2_instances[0];

    // Add event listener for retrieving page information
    document.getElementById('getPageInfo').addEventListener('click', function () {
        retrievePageInfo();
    });

    function retrievePageInfo() {
        if (pdfViewer) {
             // Set the page index for which info is required
            const pageIndex = 0;

            // To Retrieve and log the page information
            console.log(pdfViewer.getPageInfo(pageIndex));

            // To Log the specific page information details to the console
            var pageInfo = pdfViewer.getPageInfo(pageIndex);

            if (pageInfo) {
                console.log(`Page Info for Page Index ${pageIndex}:`);
                console.log(`Height: ${pageInfo.height}`);
                console.log(`Width: ${pageInfo.width}`);
                console.log(`Rotation: ${pageInfo.rotation}`);
            } 
        } 
    }
});
</script>

{% endhighlight %}
{% endtabs %}

By following these steps, you can successfully integrate and use the get page info API in the EJ2 PDF Viewer.

[View Sample in GitHub](https://github.com/SyncfusionExamples/asp-core-pdf-viewer-examples/tree/master/How%20to)