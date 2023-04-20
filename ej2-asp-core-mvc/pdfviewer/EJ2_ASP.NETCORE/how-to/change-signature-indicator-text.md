---
layout: post
title: How to change the signature indicator text | Syncfusion
description: Learn how to change the signature indicator text in Syncfusion ##Platform_Name## Pdfviewer component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: How to change the signature indicator text
publishingplatform: ##Platform_Name##
documentation: ug
---

# How to change the signature indicator text

To change the text of the signature indicator in Syncfusion PDF Viewer, you need to use the `signatureIndicatorSettings` property of the `signatureFieldSettings` object. You can set the `text` property of signatureIndicatorSettings to the desired text value.

Here's an example of how to change the signature indicator text in Syncfusion.

```html

<div>
    <ejs-pdfviewer 
        id="pdfviewer" 
        style="height:600px" 
        serviceUrl="/Index" 
        documentPath="Data/PDF_Succinctly.pdf">
    </ejs-pdfviewer>
</div>

<script>
    window.onload = function () {
        var pdfviewer = document.getElementById('pdfviewer').ej2_instances[0];
        pdfviewer.signatureFieldSettings.signatureIndicatorSettings.text = "Your Text Here";
    }
</script>

```

In the above code, replace `Your Text Here` with the desired text value for the signature indicator.

[View Sample in GitHub]()