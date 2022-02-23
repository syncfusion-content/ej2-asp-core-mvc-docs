# Print and Export in ASP.NET MVC Maps component

## Print

The rendered maps can be printed directly from the browser by calling the [`print`](https://ej2.syncfusion.com/documentation/api/maps/#print) method. To use the print functionality, set the [`AllowPrint`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.Maps.html#Syncfusion_EJ2_Maps_Maps_AllowPrint) property to **true**.

{% aspTab template="maps/print-export/print", sourceFiles="print.cs" %}

{% endaspTab %}

## Export

### Image Export

To use the image export functionality, we should set the [`AllowImageExport`](https://ej2.syncfusion.com/documentation/api/maps/#allowimageexport) property to **true**. The rendered maps can be exported as an image using the [`export`](https://ej2.syncfusion.com/documentation/api/maps/#export) method. The method requires two parameters: image type and file name. The maps can be exported as an image in the following formats.

* JPEG
* PNG
* SVG

{% aspTab template="maps/print-export/export", sourceFiles="export.cs" %}

{% endaspTab %}

We can get the image file as base64 string for the JPEG and PNG formats. The maps can be exported to image as a base64 string using the [`export`](https://ej2.syncfusion.com/documentation/api/maps/#export) method. There are four parameters required: image type, file name, orientation of the exported PDF document which must be set as **null** for image export and finally **allowDownload** which should be set as **false** to return base64 string.

{% aspTab template="maps/print-export/export", sourceFiles="export.cs" %}

{% endaspTab %}

### PDF Export

To use the PDF export functionality, we should set the [`AllowPdfExport`](https://ej2.syncfusion.com/documentation/api/maps/#allowpdfexport) property to **true**. The rendered maps can be exported as PDF using the [`export`](https://ej2.syncfusion.com/documentation/api/maps/#export) method. The [`export`](https://ej2.syncfusion.com/documentation/api/maps/#export) method requires three parameters: file type, file name and orientation of the PDF document. The orientation setting is optional and **0** indicates portrait and **1** indicates landscape.

{% aspTab template="maps/print-export/export", sourceFiles="export.cs" %}

{% endaspTab %}

### Export the tile maps

The rendered map with providers such as OSM, Bing and Google static maps can be exported using the [`export`](https://ej2.syncfusion.com/documentation/api/maps#export) method. It supports the following export formats.

* JPEG
* PNG
* PDF

{% aspTab template="maps/print-export/export-tile", sourceFiles="export-tile.cs" %}

{% endaspTab %}