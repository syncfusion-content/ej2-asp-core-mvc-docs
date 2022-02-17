---
layout: post
title: Export in ##Platform_Name## Barcode Component
description: Learn here all about Export in Syncfusion ##Platform_Name## Barcode component and more.
platform: ej2-asp-core-mvc
control: Export
publishingplatform: ##Platform_Name##
documentation: ug
---


# Export

Export barcode as an image and base64 string is common for barcode,QRcode and datamatrix. The following code samples explain how to export barcode as an image and base64 string.

## Export

Barcode provides the support to export its content as an image in the specified image type and downloads it in the browser.
The following code example shows how to export the barcode as an image

```typescript

var barcode = document.getElementById("barcode").ej2_instances[0];
var filename = 'Export';
barcode.exportImage(filename,'JPG');

```

The filename specifies the name of the file to be downloaded.

### Export As Base64String

Barcode provides the support to export its content as an image in the specified image type and returns it as base64 string.
The following code example shows how to export the barcode as a base64 string

```typescript

var barcode = document.getElementById("barcode").ej2_instances[0];
await barcode.exportAsBase64Image('JPG');

```

>Format is to specify the type or format of the exported file. You can export the barcode to the following formats:
>* JPG.
>* PNG.