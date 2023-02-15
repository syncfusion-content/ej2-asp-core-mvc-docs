---
layout: post
title: Export As Image with EJ2 ASP.NET Core PDF Viewer Control | Syncfusion
description: Learn here all about Export As Image in Syncfusion ##Platform_Name## Pdfviewer component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Export As Image
publishingplatform: ##Platform_Name##
documentation: ug
---

# Export as Image in ASP.NET Core PDF Viewer control

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
for (int i = 0; i < pdfExportImage.PageCount; i++)
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
for (int i = 0; i < pdfExportImage.PageCount; i++)
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
for (int i = 0; i < pdfExportImage.PageCount; i++)
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
for (int i = 0; i < pdfExportImage.PageCount; i++)
{
    //Save the exported image in disk
    bitmapimage[i].Save(@"currentDirectory\..\..\..\..\Images\" + "bitmapImage" + i.ToString() + ".png");
}

```
## Export as Image in ASP.NET Core 6.0

To export a PDF to image in ASP.NET Core 6.0 using Syncfusion PDF Viewer and Skia Bitmap, you can follow these steps:

Create an instance of PdfRenderer in the controller, and create an instance of SKBitmap to get the bitmap representation of the page. Exporting can be done using the `ExportAsImage()` method. This method helps to convert a PDF into an image. Use the SKImage class to save the SKBitmap object as a PNG image, and use the `SaveTo` method of the SKBitmap to save the image to a file. Return the image file in the response.

Here is a sample that shows how to export as image in ASP.NET Core 6.0 :

```cs

//Uses the Syncfusion.EJ2.PdfViewer assembly
PdfRenderer pdfExportImage = new PdfRenderer();
//Loads the PDF document
pdfExportImage.Load(@"currentDirectory\..\..\..\..\Data\hive_succinctly.pdf");
//Exports the PDF document pages into images
SKBitmap bitmapimage = pdfExportImage.ExportAsImage(0);
SKImage image = SKImage.FromBitmap(bitmapimage);
using (var stream = new FileStream(Path.Combine(@"currentDirectory\..\..\..\..\Data\Page1.png"), FileMode.Create))
    {//Save the exported image in disk
        var imageData = image.Encode(SKEncodedImageFormat.Png, 100);
        imageData.SaveTo(stream);
    }
    var imageFileStream = System.IO.File.OpenRead(Path.Combine(@"currentDirectory\..\..\..\..\Data\Page1.png"));
    return File(imageFileStream, "image/png");

```

[View Sample in GitHub](https://github.com/SyncfusionExamples/asp-core-pdf-viewer-examples/tree/master/Common/Export%20as%20Image%20in%20ASP.NET%20Core%206.0/ExportImageindotnet6)

N> Ensure the provided document path and output image saved locations in your application level.