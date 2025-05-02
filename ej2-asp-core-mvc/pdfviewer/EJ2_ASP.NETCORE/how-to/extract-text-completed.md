---
layout: post
title: extractTextCompleted Event in Syncfusion ##Platform_Name## Pdfviewer Component
description: Learn here all about extractTextCompleted Event in Syncfusion ##Platform_Name## Pdfviewer component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Extract Text Completed
publishingplatform: ##Platform_Name##
documentation: ug
---

# Extract text using extractTextCompleted Event

The PDF Viewer library allows you to extract the text from a page along with the bounds. Text extraction can be done using the **isExtractText** property and [**extractTextCompleted**](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PdfViewer.PdfViewer.html#Syncfusion_EJ2_PdfViewer_PdfViewer_ExtractTextCompleted) event. `extractTextCompleted` event Triggers when an text extraction is completed in the PDF Viewer.

Here is an example of how you can use the extractTextCompleted event:

{% tabs %}
{% highlight cshtml tabtitle="Standalone" %}

page "{handler?}"
@model IndexModel
@{
    ViewData["Title"] = "Home page";
}

<div class="text-center">
    <ejs-pdfviewer id="pdfviewer" style="height:600px" resourceUrl="https://cdn.syncfusion.com/ej2/29.1.33/dist/ej2-pdfviewer-lib" documentPath="https://cdn.syncfusion.com/content/pdf/pdf-succinctly.pdf" isExtractText=true>
    </ejs-pdfviewer>
</div>

<script type="text/javascript">
    document.addEventListener('DOMContentLoaded', function () {
        var viewer = document.getElementById('pdfviewer').ej2_instances[0];
        viewer.isExtractText = true;
        viewer.extractTextCompleted = args => {
        //Extract the Complete text of load document
        console.log(args);
        console.log(args.documentTextCollection[1]);
        //Extract the Text data.
        console.log(args.documentTextCollection[1][1].TextData);
        //Extract Text in the Page.
        console.log(args.documentTextCollection[1][1].PageText);
        //Extracts the first text of the PDF document along with its bounds
        console.log(args.documentTextCollection[1][1].TextData[0].Bounds);
    };
    });
</script>

{% endhighlight %}
{% endtabs %}

[View sample in GitHub](https://github.com/SyncfusionExamples/asp-core-pdf-viewer-examples/tree/master/How%20to)