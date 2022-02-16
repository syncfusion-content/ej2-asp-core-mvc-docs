---
layout: post
title: Export As Image in ##Platform_Name## Pdfviewer Component
description: Learn here all about Export As Image in Syncfusion ##Platform_Name## Pdfviewer component and more.
platform: ej2-asp-core-mvc
control: Export As Image
publishingplatform: ##Platform_Name##
documentation: ug
---

# Exporting PDFs as raster images

The PDF Viewer server library allows the PDF document pages to be exported as raster images. Exporting can be done using the ExportAsImage() method. This option helps to convert a PDF into an image. The APIs available to export the PDF document pages as images are listed as follows:

## ExportAsImage(int pageindex)

Exports the specified page as image using the Pdfium rendering engine.

```cs

//Uses the Syncfusion.EJ2.PdfViewer assembly
PdfRenderer pdfExportImage = new PdfRenderer();
//Loads the PDF document
pdfExportImage.Load(@"currentDirectory\..\..\..\..\Data\HTTP Succinctly.pdf");
//Exports the PDF document pages into images
Bitmap bitmapimage = pdfExportImage.ExportAsImage(0);
//Save the exported image in disk
bitmapimage.Save(@"currentDirectory\..\..\..\..\Images\" + "bitmapImage" + i.ToString() + ".png");

```

## ExportAsImage(int pageIndex, float dpiX, float dpiY)

Exports the specified page as image with respect to the specified DPI values.

```cs

//Uses the Syncfusion.EJ2.PdfViewer assembly
PdfRenderer pdfExportImage = new PdfRenderer();
//Loads the PDF document
pdfExportImage.Load(@"currentDirectory\..\..\..\..\Data\HTTP Succinctly.pdf");
//Exports the PDF document pages into images
Bitmap bitmapimage = pdfExportImage.ExportAsImage(0, 200, 200);
//Save the exported image in disk
bitmapimage.Save(@"currentDirectory\..\..\..\..\Images\" + "bitmapImage" + i.ToString() + ".png");

```

## ExportAsImage(int pageIndex, SizeF customSize, bool keepAspectRatio)

Exports the specified page as image with respect to the specified custom size.

```cs

//Uses the Syncfusion.EJ2.PdfViewer assembly
PdfRenderer pdfExportImage = new PdfRenderer();
//Loads the PDF document
pdfExportImage.Load(@"currentDirectory\..\..\..\..\Data\HTTP Succinctly.pdf");
//Exports the PDF document pages into images
Bitmap bitmapimage = pdfExportImage.ExportAsImage(0, new SizeF(200, 300), true);
//Save the exported image in disk
bitmapimage.Save(@"currentDirectory\..\..\..\..\Images\" + "bitmapImage" + i.ToString() + ".png");

```

## ExportAsImage(int pageIndex, SizeF customSize, float dpiX, float dpiY, bool keepAspectRatio)

Exports the specified page as image with respect to the custom size and the specified DPI values.

```cs

//Uses the Syncfusion.EJ2.PdfViewer assembly
PdfRenderer pdfExportImage = new PdfRenderer();
//Loads the PDF document
pdfExportImage.Load(@"currentDirectory\..\..\..\..\Data\HTTP Succinctly.pdf");
//Exports the PDF document pages into images
Bitmap bitmapimage = pdfExportImage.ExportAsImage(0, new SizeF(200, 300),200,200, true);
//Save the exported image in disk
bitmapimage.Save(@"currentDirectory\..\..\..\..\Images\" + "bitmapImage" + i.ToString() + ".png");


```

## ExportAsImage(int startIndex, int endIndex)

Exports the specified pages as images using the Pdfium rendering engine.

```cs

//Uses the Syncfusion.EJ2.PdfViewer assembly
PdfRenderer pdfExportImage = new PdfRenderer();
//Loads the PDF document
pdfExportImage.Load(@"currentDirectory\..\..\..\..\Data\HTTP Succinctly.pdf");
//Exports the PDF document pages into images
Bitmap[] bitmapimage = pdfExportImage.ExportAsImage(0, pdfExportImage.PageCount-1);
for (int i =0; i < pdfExportImage.PageCount; i++)
{
// Save the exported image in disk
bitmapimage[i].Save(@"currentDirectory\..\..\..\..\Images\" + "bitmapImage" + i.ToString() + ".png");
}

```

## ExportAsImage(int startIndex, int endIndex, float dpiX, float dpiY)

Exports the specified pages as images with respect to the specified DPI values.

```cs

//Uses the Syncfusion.EJ2.PdfViewer assembly
PdfRenderer pdfExportImage = new PdfRenderer();
//Loads the PDF document
pdfExportImage.Load(@"currentDirectory\..\..\..\..\Data\HTTP Succinctly.pdf");
//Exports the PDF document pages into images
Bitmap[] bitmapimage = pdfExportImage.ExportAsImage(0, pdfExportImage.PageCount-1, 200, 200);
for (int i =0; i < pdfExportImage.PageCount; i++)
{
//Save the exported image in disk
bitmapimage[i].Save(@"currentDirectory\..\..\..\..\Images\" + "bitmapImage" + i.ToString() + ".png");
}

```

## ExportAsImage(int startIndex, int endIndex, SizeF customSize, bool keepAspectRatio)

Exports the specified pages as images with respect to the specified custom size.

```cs

//Uses the Syncfusion.EJ2.PdfViewer assembly
PdfRenderer pdfExportImage = new PdfRenderer();
//Loads the PDF document
pdfExportImage.Load(@"currentDirectory\..\..\..\..\Data\HTTP Succinctly.pdf");
//Exports the PDF document pages into images
Bitmap[] bitmapimage = pdfExportImage.ExportAsImage(0, pdfExportImage.PageCount-1, new SizeF(200, 300), false);
for (int i =0; i < pdfExportImage.PageCount; i++)
{
//Save the exported image in disk
bitmapimage[i].Save(@"currentDirectory\..\..\..\..\Images\" + "bitmapImage" + i.ToString() + ".png");
}

```

## ExportAsImage(int startIndex, int endIndex, SizeF customSize, float dpiX, float dpiY, bool keepAspectRatio)

Exports the specified pages as images with respect to the custom size and the specified DPI values.

```cs

//Uses the Syncfusion.EJ2.PdfViewer assembly
PdfRenderer pdfExportImage = new PdfRenderer();
//Loads the PDF document
pdfExportImage.Load(@"currentDirectory\..\..\..\..\Data\HTTP Succinctly.pdf");
//Exports the PDF document pages into images
Bitmap[] bitmapimage = pdfExportImage.ExportAsImage(0, pdfExportImage.PageCount-1, new SizeF(200, 300),200,200,false);
for (int i =0; i < pdfExportImage.PageCount; i++)
{
//Save the exported image in disk
bitmapimage[i].Save(@"currentDirectory\..\..\..\..\Images\" + "bitmapImage" + i.ToString() + ".png");
}

```

>Kindly ensure the provided document path and output image saved locations in your application level.