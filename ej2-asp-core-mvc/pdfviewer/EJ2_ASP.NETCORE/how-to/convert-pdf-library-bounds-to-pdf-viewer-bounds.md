---
layout: post  
title: Converting Library Bounds in EJ2 ASP.NET Core PdfViewer | Syncfusion  
description: Learn how to convert Library bounds into Viewer bounds in ASP.NET Core Pdfviewer component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: PDF Viewer
publishingplatform: ##Platform_Name##
documentation: ug  
---

# Converting PDF Library Bounds to PDF Viewer Bounds

### Overview

When exporting annotations from the PDF Library, you may need to convert the bounds values into the PDF Viewer format. This guide will help you achieve that using the Syncfusion PDF Viewer component.

### How to Convert Bounds Values

**Step 1:** Initialize the PdfViewer Instance

Create an instance of the PdfViewer and configure it with the required services.

**Step 2:** Handle Export Success

Convert the exported blob URL to an object and then extract and convert the annotation bounds.

**Step 3:** Create a Function to Convert Blob URL to Object

This function fetches the blob data and converts it into a JSON object.

{% tabs %}
{% highlight cshtml tabtitle="Server-Backed" %}

@page "{handler?}"
@model IndexModel
@{
    ViewData["Title"] = "Home page";
}

<div class="text-center">
    <ejs-pdfviewer id="pdfviewer" style="height:600px" serviceUrl="/Index" 
        documentPath="https://cdn.syncfusion.com/content/pdf/pdf-succinctly.pdf">
    </ejs-pdfviewer>
</div>

<script type="text/javascript">
    var pageSizes = [];
    // Event when the PDF is loaded
    document.addEventListener('DOMContentLoaded', function () {
        var pdfViewer = document.getElementById('pdfviewer').ej2_instances[0];
        pdfViewer.exportSuccess = function (args) {
            console.log(args.exportData);
            const blobURL = args.exportData;
            // Converting the exported blob into object
            convertBlobURLToObject(blobURL)
                .then((objectData) => {
                    console.log(objectData);
                    var datas = objectData;
                    var shapeAnnotationData = datas['pdfAnnotation'][0]['shapeAnnotation'];
                    shapeAnnotationData.forEach(data => {
                        if (data && data.rect && parseInt(data.rect.width)) {
                            let rect = null;
                            const pageHeight = pdfViewer.getPageInfo(parseInt(data.page)).height;
                            // Converting PDF Library values into PDF Viewer values.
                            rect = {
                                x: (parseInt(data.rect.x) * 96) / 72,
                                y: (parseInt(pageHeight) - parseInt(data.rect.height)) * 96 / 72,
                                width: (parseInt(data.rect.width) - parseInt(data.rect.x)) * 96 / 72,
                                height: (parseInt(data.rect.height) - parseInt(data.rect.y)) * 96 / 72,
                            };
                            if ((data.type == 'Line' || data.type == 'Arrow') && data.start && data.end) {
                                const [startX, startY] = data.start.split(',').map(Number);
                                const [endX, endY] = data.end.split(',').map(Number);
                                const pageHeight = pdfViewer.getPageInfo(parseInt(data.page)).height;
                                const pdfStartX = (startX * 96) / 72;
                                const pdfStartY = (parseInt(pageHeight) - startY) * 96 / 72;
                                const pdfEndX = (endX * 96) / 72;
                                const pdfEndY = (parseInt(pageHeight) - endY) * 96 / 72;
                                rect = {
                                    x: Math.min(pdfStartX, pdfEndX),
                                    y: Math.min(pdfStartY, pdfEndY),
                                    width: Math.abs(pdfEndX - pdfStartX),
                                    height: Math.abs(pdfEndY - pdfStartY),
                                };
                            }
                            console.log(data.name, rect, "-------------------------");
                        }
                    });
                })
                .catch((error) => {
                    console.error('Error converting Blob URL to object:', error);
                });
        };
        function convertBlobURLToObject(blobURL) {
            return fetch(blobURL)
                .then((response) => response.blob())
                .then((blobData) => {
                    return new Promise((resolve, reject) => {
                        const reader = new FileReader();
                        reader.onloadend = () => {
                            resolve(JSON.parse(reader.result));
                        };
                        reader.onerror = reject;
                        reader.readAsText(blobData);
                    });
                });
        }
    });
</script>

{% endhighlight %}
{% endtabs %}

### Conclusion

By following these steps, you can successfully convert PDF Library bounds values into PDF Viewer bounds values when exporting annotations as JSON. This will help maintain accuracy in the annotation placement and ensure a seamless user experience.

[View sample in GitHub](https://github.com/SyncfusionExamples/asp-core-pdf-viewer-examples/tree/master/How%20to)
