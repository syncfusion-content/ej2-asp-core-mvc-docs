---
layout: post
title: How to change the signature indicator settings | Syncfusion
description: Learn how to change the signature indicator settings in Syncfusion ##Platform_Name## Pdfviewer component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: How to change the signature indicator settings
publishingplatform: ##Platform_Name##
documentation: ug
---

# How to change the signature indicator settings

To change the signature indicator settings in the Syncfusion PDF Viewer, use the `signatureIndicatorSettings` property of the `signatureFieldSettings` object. Modify various properties of the signature indicator such as opacity, background color, width, height, font size, text, and color.

The following is an example of how to change the signature indicator settings.

```html

<div>
    <ejs-pdfviewer 
        id="pdfviewer" 
        style="height:100%" 
        serviceUrl="/Index" 
        documentPath = "Data/FormDesigner.pdf"
        documentLoad = "onload">
    </ejs-pdfviewer>
</div>

<script>
    window.onload = function () {
        var pdfviewer = document.getElementById('pdfviewer').ej2_instances[0];
        pdfviewer.signatureFieldSettings.signatureIndicatorSettings= { 
            opacity: 1, 
            backgroundColor: 'orange', 
            width: 19, 
            height: 10, 
            fontSize: 10, 
            text: 'Your Text Here', 
            color: 'blue' 
        };
    }
</script>

```

If you want to change these properties, simply modify the corresponding value in the `signatureIndicatorSettings` object. The same goes for the initial field indicator.

[View Sample in GitHub]()