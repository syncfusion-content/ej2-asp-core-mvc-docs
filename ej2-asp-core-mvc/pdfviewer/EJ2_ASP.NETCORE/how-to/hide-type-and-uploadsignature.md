---
layout: post
title: Hide the type and upload signature dialogue | Syncfusion
description: Learn how to hide the type and upload signature dialogue in Syncfusion ##Platform_Name## Pdfviewer component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Hide the type and upload signature dialogue
publishingplatform: ##Platform_Name##
documentation: ug
---

# How to Hide the type and upload signature dialogue

To hide the type and upload signature dialogue in Syncfusion PDF Viewer, you can use the following code

```html
<div >
    <ejs-pdfviewer 
        id="pdfviewer" 
        style="height:600px" 
        serviceUrl="/Index" 
        documentLoad="documentLoaded" 
        documentPath="Data/PDF_Succinctly.pdf">
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

In the signatureDialogSettings object, set the `hideTypeSignature` and `hideUploadSignature` properties to `true` to hide the type and upload signature dialogue, respectively. Additionally, set the `hideSaveSignature property` to `true` to hide the Save Signature button.The `displayMode `property is used to control the display mode of the signature dialog box. Setting it to `0` will hide the dialog box.

[View Sample in GitHub]().