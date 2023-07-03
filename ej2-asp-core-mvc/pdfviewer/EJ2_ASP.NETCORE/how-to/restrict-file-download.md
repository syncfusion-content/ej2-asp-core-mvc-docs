---
layout: post
title: Restrict file downloading while exporting  in ##Platform_Name## Pdfviewer Component
description: Learn here all about how to restrict file downloading while exporting l in Syncfusion ##Platform_Name## Pdfviewer component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Restrict file downloading while exporting 
publishingplatform: ##Platform_Name##
documentation: ug
---

# Restrict file downloading while exporting 

The Syncfusion PDF Viewer provides the **cancel** property, which gives you control over the submission of forms, exporting of form fields, exporting of annotations, and other export actions in a PDF document. By adjusting the value of the `cancel` property, you can enable or disable these operations according to your requirements.

By default, The `cancel` property is set to `false`, it means that the operations will proceed as usual without any cancellation. On the other hand, if you set the cancel property to `true`, it will stop the exporting process and prevent those operations from being carried out.

The **exportStart** event is triggered when an export process is about to start. This event allows developers to perform specific actions or implement custom logic before the export operation begins. It can be used in both the UI event handling and the API event handling approaches.

By customizing the `exportStart` event, you can implement your own logic or perform additional actions before allowing or canceling the export operation. This flexibility enables you to tailor the behavior of the PDF Viewer based on your application's requirements.

```html
<div class="text-center">
    <ejs-pdfviewer 
        id="pdfviewer" 
        style="height:600px" 
        serviceUrl="/Index" 
        documentPath="Data/PDF_Succinctly.pdf" 
        exportStart="exportStart"
    ></ejs-pdfviewer>
</div>
```

```html

<script>
    function exportStart(args) {
        args.cancel = true;
    }
</script>
```

[View sample in GitHub]()