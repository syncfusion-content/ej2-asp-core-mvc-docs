---
layout: post  
title: Annotations Visibility in EJ2 ASP.NET MVC PdfViewer | Syncfusion  
description: Learn how to Control PDF Annotations Visibility in the Syncfusion ASP.NET MVC PDF Viewer component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Control PDF Annotations Visibility
publishingplatform: ##Platform_Name##
documentation: ug  
---

# Control PDF Annotations Visibility in PDF Viewer

### Overview

This guide demonstrates how to control the visibility of PDF annotations in documents loaded and saved using the Syncfusion PDF Viewer. This process allows the annotations to be visible only in the Syncfusion PDF Viewer.

### How to Control Annotation Visibility

**Step 1:** Set Up the PdfViewer in Your ASP.NET MVC Project

 Follow the steps provided in the [link](https://ej2.syncfusion.com/aspnetmvc/documentation/pdfviewer/getting-started) to create a simple PDF Viewer sample.

**Step 2:**  Set Up Your ASP.NET MVC Component

Create an ASP.NET MVC component and update the template to include a button that triggers the download operation. Additionally, create a function to save the document with the PDF annotation flag set to `noView`.

{% tabs %}
{% highlight cshtml tabtitle="Standalone" %}

@using Syncfusion.EJ2
@{
    ViewBag.Title = "Home Page";
}
<div>
    <div style="height:500px;width:100%;">
        <button onclick="save()">Download</button>
        <!-- Render PDF Viewer using the Html helper method -->
        @Html.EJS().PdfViewer("pdfviewer").DocumentPath("https://cdn.syncfusion.com/content/pdf/annotations-v1.pdf").DocumentLoad("documentLoad").DownloadEnd("documentLoad").Render()
    </div>
</div>

    <script type="text/javascript">
        function documentLoad(arg) {
            var viewer = document.getElementById('pdfviewer').ej2_instances[0];
            //Code snippet to add basic annotations. You can also include other annotations as needed.
            viewer.annotation.addAnnotation("Highlight", {
                bounds: [{ x: 97, y: 610, width: 350, height: 14 }],
                pageNumber: 1
            });
            viewer.annotation.addAnnotation("Underline", {
                bounds: [{ x: 97, y: 723, width: 353.5, height: 14 }],
                pageNumber: 1
            });
            viewer.annotation.addAnnotation("Strikethrough", {
                bounds: [{ x: 97, y: 836, width: 376.5, height: 14 }],
                pageNumber: 1
            });
        }
        function save() {
            var viewer = document.getElementById('pdfviewer').ej2_instances[0];
            viewer.saveAsBlob().then((blob) => {
                const reader = new FileReader();
                reader.onload = function () {
                    const base64data = reader.result;
                    const base64EncodedData = base64data.split('base64,')[1];
                    const document1 = new ej.pdf.PdfDocument(base64EncodedData);
                    for (let i = 0; i < document1.pageCount; i++) {
                        const page = document1.getPage(i);
                        for (let j = 0; j < page.annotations.count; j++) {
                            const annot = page.annotations.at(j);
                            annot.flags |= ej.pdf.PdfAnnotationFlag.noView;
                        }
                    }
                    document1.saveAsBlob().then((modifiedBlob) => {
                        const internalReader = new FileReader();
                        internalReader.onload = function () {
                            const modifiedBase64 = internalReader.result;
                            const downloadLink = document.createElement('a');
                            downloadLink.href = modifiedBase64;
                            downloadLink.download = 'modified.pdf';
                            downloadLink.click();
                        };
                        internalReader.readAsDataURL(modifiedBlob.blobData);
                    });
                };
                reader.readAsDataURL(blob);
            });
        }


    </script>

{% endhighlight %}
{% endtabs %}

By following these steps, the annotations in a PDF document can be set to be visible in the Syncfusion PDF Viewer, providing control over annotation visibility based on different platforms.

[View sample in GitHub](https://github.com/SyncfusionExamples/mvc-pdf-viewer-examples/tree/master/How%20to)