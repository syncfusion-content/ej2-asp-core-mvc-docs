---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Hand Written Signature of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Hand Written Signature
publishingplatform: ##Platform_Name##
documentation: ug
---


# Handwritten Signature

The PDF Viewer control supports adding handwritten signatures to a PDF document. The handwritten signature reduces the paper work of reviewing the content and verifies it digitally.

The following code snippet describes how to enable the handwritten signature in PDF Viewer.

```html
 <ejs-pdfviewer id="pdfviewer1" serviceUrl="/api/PdfViewer" documentPath="HTTP Succinctly.pdf"  enableHandwrittenSignature="true"></ejs-pdfviewer>

```

## Adding a handwritten signature to the PDF document

The handwritten signature can be added to the PDF document using the annotation toolbar.

* Click the **Edit Annotation** button in the PDF Viewer toolbar. A toolbar appears below it.
* Select the **HandWritten Signature** button in the annotation toolbar. The signature panel will appear.

![HandWrittenSignature](./images/handwritten_sign.png)

* Draw the signature in the signature panel.

![SignaturePanel](./images/signature_panel.png)

* Then click **Create** button and move the signature using the mouse and place them in the desired location.

![SignatureAdded](./images/signature_added.png)

## Editing the properties of handwritten signature

The stroke color, border thickness, and opacity of the handwritten signature can be edited using the edit stroke color tool, edit thickness tool, and edit opacity tool in the annotation toolbar.

![SignatureProperties](./images/signature_properties.png)

Refer to the following code snippet to set the default handwritten signature settings.

```html
<ejs-pdfviewer id="pdfviewer1" serviceUrl="/api/PdfViewer" documentPath="HTTP Succinctly.pdf"  handWrittenSignatureSettings="@(new Syncfusion.EJ2.PdfViewer.PdfViewerHandWrittenSignatureSettings {Opacity=0.5,StrokeColor="red",Thickness=3})"></ejs-pdfviewer>

```

## See also

* [Toolbar items](./toolbar)
* [Feature Modules](./feature-module)
