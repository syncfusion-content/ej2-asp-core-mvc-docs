---
layout: post
title: Extract Text Using Text Collections in ##Platform_Name## Pdfviewer Component
description: Learn here all about Extract Text Using Text Collections in Syncfusion ##Platform_Name## Pdfviewer component and more.
platform: ej2-asp-core-mvc
control: Extract Text Using Text Collections
publishingplatform: ##Platform_Name##
documentation: ug
---


# Extract Text using TextLineCollection

The PDF Viewer server library allows you to extract the text from a page along with the bounds using TextLineCollection. Text extracting can be done using the **ExtractText()** method.

Add the following dependency to your application using the `NuGet Package Manager`.
* Syncfusion.EJ2.PdfViewer.AspNet.Core.Windows

For Linux and OSX operating systems, use the corresponding libraries as follows:
* Syncfusion.EJ2.PdfViewer.AspNet.Core.Linux
* Syncfusion.EJ2.PdfViewer.AspNet.Core.OSX

>From Volume 2 2019 release Syncfusion.Pdf.Net.Core and Syncfusion.Compression.Net.Core packages are added as dependency for PDF Viewer control. Ensure the dependency packages are referred in your application properly.

The following code snippet explains how to extract the text from a page using TextLineCollection.

```cs

var path = @"currentDirectory\..\..\..\..\Data\Simple.pdf";
var fileInfo = new FileInfo(path);
var docStream = new FileStream(fileInfo.FullName, FileMode.Open, FileAccess.Read);
// Load the PDF document.
PdfLoadedDocument document = new PdfLoadedDocument(docStream);
// Loading page collections
PdfPageBase page = document.Pages[0] as PdfLoadedPage;
//Extract text from the page.
var text = page.ExtractText(out TextLineCollection textLineCollection);

```

Find the sample [How to extract text using TextLineCollection](https://www.syncfusion.com/downloads/support/directtrac/general/ze/EXTRAC~21056703041)

>Ensure the provided document path and output text saved locations in your application level.