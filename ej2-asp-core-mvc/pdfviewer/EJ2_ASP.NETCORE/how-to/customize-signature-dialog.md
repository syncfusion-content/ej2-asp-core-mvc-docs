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

Customize the signature dialogue in Syncfusion PDF Viewer. The [signatureFieldSettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PdfViewer.PdfViewerSignatureFieldSettings.html) property of the PDF Viewer instance is used to access the signature dialog settings.

The [displayMode](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PdfViewer.DisplayMode.html) property determines the display mode of the signature dialogue. A value of `1` indicates that the signature dialogue should be displayed in a separate window. The `hideTypeSelection` property hides the signature field type selection dialogue, allowing users to choose the type of signature field they want to add. The `hideUploadSignature` property is used to hide the upload signature dialogue, which allows users to upload an image file to use as their signature. The [hideSaveSignatur](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PdfViewer.PdfViewerSignatureDialogSettings.html) property hides the save signature dialogue, allowing users to save their signature for future use. The `hideDrawSignature` property is set to true, meaning the Draw Signature option will be hidden in the signature dialog.

Modify these properties to suit your needs and customize the signature dialogue in Syncfusion PDF Viewer accordingly.

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
            hideTypeSelection: true, // hides the typed signature tab 
            hideUploadSignature: true, // hides the upload signature tab
            hideSaveSignature: true // hides the save signature option
        };
    };
</script>

```

[View Sample in GitHub]().