# Print and Export

## Print

To use the print functionality, we should set the [`allowPrint`](https://ej2.syncfusion.com/documentation/api/circular-gauge/#allowprint) property to **true**. The rendered circular gauge can be printed directly from the browser by calling the method [`print`](https://ej2.syncfusion.com/documentation/api/circular-gauge/#print).

{% aspTab template="circulargauge/print-and-export/print", sourceFiles="print.cs" %}

{% endaspTab %}

## Export

### Image Export

To use the image export functionality, we should set the [`allowImageExport`](https://ej2.syncfusion.com/documentation/api/circular-gauge/#allowimageexport) property to **true**. The rendered circular gauge can be exported as an image using the [`export`](https://ej2.syncfusion.com/documentation/api/circular-gauge/#export) method. The method requires two parameters: image type and file name. The circular gauge can be exported as an image in the following formats.

* JPEG
* PNG
* SVG

{% aspTab template="circulargauge/print-and-export/export", sourceFiles="export.cs" %}

{% endaspTab %}

We can get the image file as base64 string for the JPEG and PNG formats. The circular gauge can be exported to image as a base64 string using the [`export`](https://ej2.syncfusion.com/documentation/api/circular-gauge/#export) method. There are four parameters required: image type, file name, orientation of the exported PDF document which must be set as **null** for image export and finally **allowDownload** which should be set as **false** to return base64 string.

{% aspTab template="circulargauge/print-and-export/base64", sourceFiles="export.cs" %}

{% endaspTab %}

### PDF Export

To use the PDF export functionality, we should set the [`allowPdfExport`](https://ej2.syncfusion.com/documentation/api/circular-gauge/#allowpdfexport) property to **true**. The rendered circular gauge can be exported as PDF using the [`export`](https://ej2.syncfusion.com/documentation/api/circular-gauge/#export) method. The [`export`](https://ej2.syncfusion.com/documentation/api/circular-gauge/#export) method requires three parameters: file type, file name and orientation of the PDF document. The orientation setting is optional and "0" indicates portrait and "1" indicates landscape.

{% aspTab template="circulargauge/print-and-export/exportPdf", sourceFiles="export.cs" %}

{% endaspTab %}

>Note: The exporting of the circular gauge as base64 string is not supported in the PDF export.