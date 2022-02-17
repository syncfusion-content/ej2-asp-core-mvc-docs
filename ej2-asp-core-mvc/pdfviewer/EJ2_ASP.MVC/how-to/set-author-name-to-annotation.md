---
layout: post
title: Set Author Name To Annotation in ##Platform_Name## Pdfviewer Component
description: Learn here all about Set Author Name To Annotation in Syncfusion ##Platform_Name## Pdfviewer component and more.
platform: ej2-asp-core-mvc
control: Set Author Name To Annotation
publishingplatform: ##Platform_Name##
documentation: ug
---

# Set author name to annotation

The PDF Viewer server library allows you to set author name to all annotations in the PDF document. Use the **author** property to set author name to all annotations.

The following steps are used to set author name to all annotation for PDF Viewer,

**Step 1:** Follow the steps provided in the [link](https://ej2.syncfusion.com/aspnetmvc/documentation/pdfviewer/getting-started/) to create simple PDF Viewer sample.

**Step 2:** Set author name to annotations using below code snippet.

```html

<script>
    function documentLoad()
    {
        var viewer = document.getElementById('pdfviewer').ej2_instances[0];
        // set author name to annotation.
        viewer.annotationSettings.author = "user1";
    }
</script>

```

Download the sample [how to set author name to annotation](https://www.syncfusion.com/downloads/support/directtrac/general/ze/MVC_SAMPLE_(2)_(1)1717421659)