---
layout: post
title: Access File Name in ##Platform_Name## Pdfviewer Component
description: Learn here all about Access File Name in Syncfusion ##Platform_Name## Pdfviewer component and more.
platform: ej2-asp-core-mvc
control: Access File Name
publishingplatform: ##Platform_Name##
documentation: ug
---


# Access file name

The PDF Viewer server library allows you to can access the filename of the loaded PDF document using the **documentLoad** and **downloadEnd** event. Using these events, we can access the filename while loading and downloading the PDF document.

The following steps are used to access the file name of loaded PDF document in PDF viewer control,

**Step 1:** Follow the steps provided in the [link](https://ej2.syncfusion.com/aspnetmvc/documentation/pdfviewer/getting-started/) to create simple PDF Viewer sample.

**Step 2:** Access file name using below code snippet,

```html

@Html.EJS().PdfViewer("pdfviewer").ServiceUrl(VirtualPathUtility.ToAbsolute("~/PdfViewer/")).DocumentLoad("documentLoad").DownloadEnd("documentLoad").Render()

<script>
    function documentLoad(args) {
        var viewer = document.getElementById('pdfviewer').ej2_instances[0];
        viewer.fileName = "pdfsuccintly.pdf";
        console.log(args);
    }  
</script>

```

Download the sample [how to access file name](https://www.syncfusion.com/downloads/support/directtrac/general/ze/MVC_SAMPLE-609765609)