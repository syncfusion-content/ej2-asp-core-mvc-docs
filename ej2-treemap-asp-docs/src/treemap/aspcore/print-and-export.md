# Print and Export

## Print

To use the print functionality, we should set the [`allowPrint`](https://ej2.syncfusion.com/documentation/api/treemap/#allowprint) property to **true**. The rendered treemap can be printed directly from the browser by calling the method [`print`](https://ej2.syncfusion.com/documentation/api/treemap/#print).

{% aspTab template="treemap/print_export/print", sourceFiles="print.cs" %}

{% endaspTab %}

## Export

### Image Export

To use the image export functionality, we should set the [`allowImageExport`](https://ej2.syncfusion.com/documentation/api/treemap/#allowimageexport) property to **true**. The rendered treemap can be exported as an image using the [`export`](https://ej2.syncfusion.com/documentation/api/treemap/#export) method. The method requires two parameters: image type and file name. The treemap can be exported as an image in the following formats.

* JPEG
* PNG
* SVG

{% aspTab template="treemap/print_export/export", sourceFiles="export.cs" %}

{% endaspTab %}

We can get the image file as base64 string for the JPEG and PNG formats. The treemap can be exported to image as a base64 string using the [`export`](https://ej2.syncfusion.com/documentation/api/treemap/#export) method. There are four parameters required: image type, file name, orientation of the exported PDF document which must be set as **null** for image export and finally **allowDownload** which should be set as **false** to return base64 string.

{% aspTab template="treemap/print_export/base64", sourceFiles="export.cs" %}

{% endaspTab %}

### PDF Export

To use the PDF export functionality, we should set the [`allowPdfExport`](https://ej2.syncfusion.com/documentation/api/treemap/#allowpdfexport) property to **true**. The rendered treemap can be exported as PDF using the [`export`](https://ej2.syncfusion.com/documentation/api/treemap/#export) method. The [`export`](https://ej2.syncfusion.com/documentation/api/treemap/#export) method requires three parameters: file type, file name and orientation of the PDF document. The orientation setting is optional and **0** indicates portrait and **1** indicates landscape.

{% aspTab template="treemap/print_export/exportPdf", sourceFiles="export.cs" %}

{% endaspTab %}

>The exporting of the treemap as base64 string is not supported in the PDF export.