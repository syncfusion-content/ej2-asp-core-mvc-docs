---
layout: post
title: Extract Text in ##Platform_Name## Pdfviewer Component
description: Learn here all about Extract Text in Syncfusion ##Platform_Name## Pdfviewer component and more.
platform: ej2-asp-core-mvc
control: Extract Text
publishingplatform: ##Platform_Name##
documentation: ug
---

# Extract Text from PDF document

The PDF Viewer server library allows you to extract the text from a page along with the bounds. Text extracting can be done using the ExtractText() method. Add the following dependency to your application using the `NuGet Package Manager`.
* Syncfusion.EJ2.PdfViewer.AspNet.Core.Windows

For Linux and OSX operating systems, use the corresponding libraries as follows:
* Syncfusion.EJ2.PdfViewer.AspNet.Core.Linux
* Syncfusion.EJ2.PdfViewer.AspNet.Core.OSX

>From Volume 2 2019 release Syncfusion.Pdf.Net.Core and Syncfusion.Compression.Net.Core packages are added as dependency for PDF Viewer control. Ensure the dependency packages are referred in your application properly.

The following code snippet explains how to extract the text from a page.

```cs

//Uses the Syncfusion.EJ2.PdfViewer assembly
PdfRenderer pdfExtractText = new PdfRenderer();
pdfExtractText.Load(@"currentDirectory\..\..\..\..\Data\HTTP Succinctly.pdf");
//Returns the bounds of the text
List<Syncfusion.EJ2.PdfViewer.TextData> textCollection = new List<Syncfusion.EJ2.PdfViewer.TextData>();
//Extracts the text from the first page of the PDF document along with its bounds
string text = pdfExtractText.ExtractText(0, out textCollection);
System.IO.File.WriteAllText(@"currentDirectory\..\..\..\..\Data\data.txt", text);

```

Sample:
[http://www.syncfusion.com/downloads/support/directtrac/general/ze/ExtractText-1972118166](http://www.syncfusion.com/downloads/support/directtrac/general/ze/ExtractText-1972118166)

>Ensure the provided document path and output text saved locations in your application level.