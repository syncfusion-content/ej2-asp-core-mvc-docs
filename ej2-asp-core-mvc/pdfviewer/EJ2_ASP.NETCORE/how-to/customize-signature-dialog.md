---
layout: post
title: How to Customize Signature Dialog | Syncfusion
description: Learn how to customize signature dialog in Syncfusion ##Platform_Name## Pdfviewer component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: How to Customize Signature Dialog
publishingplatform: ##Platform_Name##
documentation: ug
---

# How to Customize Signature Dialog

To customize the signature dialogue in Syncfusion PDF Viewer. The `signatureFieldSettings` property of the PDF Viewer instance is used to access the signature dialog settings.

The `displayMode` property determines the display mode of the signature dialogue. A value of `1` indicates that the signature dialogue should be displayed in a separate window. The `hideTypeSelection` property is used to hide the signature field type selection dialogue, which allows users to choose the type of signature field they want to add. The `hideUploadSignature` property is used to hide the upload signature dialogue, which allows users to upload an image file to use as their signature. The `hideSaveSignature property` is used to hide the save signature dialogue, which allows users to save their signature for future use. The `hideDrawSignature` property is set to true, which means that the Draw Signature option will be hidden in the signature dialog.

You can modify these properties to suit your needs and customize the signature dialogue in Syncfusion PDF Viewer accordingly.

```html

<div >
    <ejs-pdfviewer 
        id="pdfviewer" 
        style="height:100%" 
        serviceUrl="/Index" 
        documentLoad="documentLoaded" 
        documentPath="Data/FormDesigner.pdf">
    </ejs-pdfviewer>
</div>

<script>
    function documentLoaded(args) {
        var pdfViewer = document.getElementById('pdfviewer').ej2_instances[0];
        pdfViewer.signatureFieldSettings.signatureDialogSettings = {
            displayMode: 1,
            hideTypeSelection: true, // hide the signature field type selection dialogue
            hideUploadSignature: true, // hide the upload signature dialogue
            hideSaveSignature: true // hide the save signature dialogue
        };
    };
</script>

```

[View Sample in GitHub]().