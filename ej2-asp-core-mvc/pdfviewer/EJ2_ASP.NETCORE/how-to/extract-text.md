---
layout: post
title: Extract Text in Syncfusion ##Platform_Name## Pdfviewer Component
description: Learn here all about Extract Text in Syncfusion ##Platform_Name## Pdfviewer component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Extract Text
publishingplatform: ##Platform_Name##
documentation: ug
---

# Extract Text from PDF document in serverbacked mode.

The PDF Viewer server library allows you to extract the text from a page along with the bounds. Text extracting can be done using the ExtractText() method. Add the following dependency to your application using the `NuGet Package Manager`.
* Syncfusion.EJ2.PdfViewer.AspNet.Core

N>From Volume 2 2019 release Syncfusion.Pdf.Net.Core and Syncfusion.Compression.Net.Core packages are added as dependency for PDF Viewer control. Ensure the dependency packages are referred in your application properly.

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

N>Ensure the provided document path and output text saved locations in your application level.

# Extract Text Method in standalone mode

The `extractText` method of the Syncfusion PdfViewer control enables text extraction from one or more pages in a PDF document. This method is useful for retrieving the text content along with its associated data, such as the bounds of each text element.

### extractText Method
The extractText method retrieves text data from the specified page(s) of a PDF document. It can extract text from one page, a range of pages, or even provide detailed text data, depending on the options specified.

#### Parameters:
**startIndex:** The starting page index for text extraction (0-based index).

**endIndex Or isOptions:** This can either be the ending page index for the text extraction (for extracting from multiple pages) or an option specifying text extraction criteria for a single page.

**options (optional):** Specifies additional options, such as extracting plain text `TextOnly` or more detailed text data `TextAndBounds`. You can specify various options for text extraction. These options determine whether you want to extract plain text, text with bounds, or detailed text data.

***TextOnly:*** Extracts only the plain text content without bounds or additional information.

***TextAndBounds:*** Extracts text content along with its bounds (coordinates) within the PDF.

#### Returns:
The method returns a Promise that resolves to an object containing two properties:

**textData:** An array of TextDataSettingsModel objects, each representing the details of the extracted text (including bounds, page text, etc.).

**pageText:** A concatenated string of plain text extracted from the specified page(s).

### Usage of extractText in Syncfusion PdfViewer Control
Here is an example that demonstrates how to use the extractText method:

{% tabs %}
{% highlight cshtml tabtitle="Standalone" %}

@page "{handler?}"
@model IndexModel
@{
    ViewData["Title"] = "Home page";
}

<div class="text-center">
    <button onclick="ExtractText()">Extract Text</button>
    <button onclick="ExtractTexts()">Extract Texts</button>
    <ejs-pdfviewer id="pdfviewer" style="height:600px" resourceUrl="https://cdn.syncfusion.com/ej2/29.1.33/dist/ej2-pdfviewer-lib" documentPath="https://cdn.syncfusion.com/content/pdf/pdf-succinctly.pdf">
    </ejs-pdfviewer>
</div>

<script type="text/javascript">
    function ExtractText(){
        var viewer = document.getElementById('pdfviewer').ej2_instances[0];
        viewer.extractText(1, 'TextOnly').then((val) => {
            console.log('Extracted Text from Page 1:');
            console.log(val);  // Logs the extracted text from page 1
        });
    }
     function ExtractTexts(){
         var viewer = document.getElementById('pdfviewer').ej2_instances[0];
        viewer.extractText(0, 2, 'TextOnly').then((val) => {
            console.log('Extracted Text from Pages 0 to 2:');
            console.log(val);  // Logs the extracted text from pages 0 to 2
        });
    }
</script>

{% endhighlight %}
{% endtabs %}

#### Explanation:
**Single Page Extraction:** The first `extractText` call extracts text from page 1 (`startIndex = 1`), using the 'TextOnly' option for plain text extraction.

**Multiple Pages Extraction:** The second extractText call extracts text from pages 0 through 2 (`startIndex = 0, endIndex = 2`), using the `TextOnly` option for plain text extraction.

[View sample in GitHub](https://github.com/SyncfusionExamples/asp-core-pdf-viewer-examples/tree/master/How%20to)