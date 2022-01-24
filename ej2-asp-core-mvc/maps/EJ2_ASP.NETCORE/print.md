---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Print of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Print
publishingplatform: ##Platform_Name##
documentation: ug
---

# Print and Export in ASP.NET Core Maps component

## Print

The rendered Maps can be printed directly from the browser by calling the [`print`](https://ej2.syncfusion.com/documentation/api/maps/#print) method. To use the print functionality, set the [`AllowPrint`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.Maps.html#Syncfusion_EJ2_Maps_Maps_AllowPrint) property to "**true**".

{% aspTab template="maps/print-export/print", sourceFiles="print.cs" %}

{% endaspTab %}

![Print](../images/Print/print.png)

## Export

### Image Export

To use the image export functionality in Maps, set the `AllowImageExport` property to **true**. The rendered map can be exported as an image using the `export` method. This method requires two parameters: image type and file name. The Maps can be exported as an image in the following formats.

* JPEG
* PNG
* SVG

{% aspTab template="maps/print-export/export", sourceFiles="export.cs" %}

{% endaspTab %}

![Image export](../images/Print/export.png)

### Exporting Maps as base 64 string of the file

The image can be exported as base64 string for the JPEG and PNG formats. The rendered Maps can be exported to image as a base64 string using the `export` method. There are four parameters required: image type, file name, orientation of the exported PDF document which must be set as **null** for image export and finally **allowDownload** which should be set as **false** to return base64 string.

{% aspTab template="maps/print-export/base64", sourceFiles="export.cs" %}

{% endaspTab %}

### PDF Export

To use the PDF export functionality, set the `AllowPdfExport` property to **true**. The rendered Maps can be exported as PDF using the `export` method. The `export`  method requires three parameters: file type, file name and orientation of the PDF document. The orientation setting is optional and **0** indicates portrait and **1** indicates landscape.

{% aspTab template="maps/print-export/exportPdf", sourceFiles="export.cs" %}

{% endaspTab %}

![PDF export](../images/Print/export.png)

### Export the tile Maps

The rendered Maps with providers such as OSM, Bing and Google static Maps can be exported using the `export` method. It supports the following export formats.

* JPEG
* PNG
* PDF

{% aspTab template="maps/print-export/export-tile", sourceFiles="export-tile.cs" %}

{% endaspTab %}

![Tile export](../images/Print/osm-export.png)