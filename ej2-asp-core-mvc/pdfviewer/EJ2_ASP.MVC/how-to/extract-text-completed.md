---
layout: post
title: extractTextCompleted Event in EJ2 ASP.NET MVC PDF Viewer | Syncfusion
description: Learn here all about extractTextCompleted Event in ASP.NET MVC PDF Viewer component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: PDF Viewer
publishingplatform: ##Platform_Name##
documentation: ug
---

# Extract text using extractTextCompleted Event

The PDF Viewer library allows you to extract the text from a page along with the bounds. Text extraction can be done using the **isExtractText** property and [**extractTextCompleted**](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PdfViewer.PdfViewer.html#Syncfusion_EJ2_PdfViewer_PdfViewer_ExtractTextCompleted) event. `extractTextCompleted` event Triggers when an text extraction is completed in the PDF Viewer.

Here is an example of how you can use the extractTextCompleted event:

{% tabs %}
{% highlight cshtml tabtitle="Standalone" %}

@using Syncfusion.EJ2
@{
    ViewBag.Title = "Home Page";
}

<div>
    <!-- Render PDF Viewer -->
    @Html.EJS().PdfViewer("pdfviewer").DocumentPath("https://cdn.syncfusion.com/content/pdf/pdf-succinctly.pdf").Render()
</div>

<!-- Ensure necessary Syncfusion scripts and styles are included -->
<script src="https://cdn.syncfusion.com/ej2/29.1.33/dist/ej2.min.js"></script>
<script type="text/javascript">
    window.onload = function () {
        // Initialize PDF viewer instance
        var viewer = document.getElementById('pdfviewer').ej2_instances[0];

        // Set up the event handler for text extraction completion
        viewer.extractTextCompleted = function (args) {
            console.log('Extracted Text Completed');
            // Log the extracted text collection
            console.log(args.documentTextCollection);

            // Access text data from page 1 (0-based index)
            console.log(args.documentTextCollection[1]);
            console.log(args.documentTextCollection[1][1].TextData);  // Extracted text data from the second element (adjust index based on your need)
            console.log(args.documentTextCollection[1][1].PageText);  // Text from the page

            // Extract and log the bounds of the first text in the page
            console.log(args.documentTextCollection[1][1].TextData[0].Bounds);
        };

        // Optionally, trigger the text extraction (for example, from page 1)
        viewer.extractText(1, 'TextOnly').then(function (val) {
            console.log('Extracted Text from Page 1:');
            console.log(val);
        });
    };
</script>


{% endhighlight %}
{% endtabs %}

[View sample in GitHub](https://github.com/SyncfusionExamples/mvc-pdf-viewer-examples/tree/master/How%20to)
