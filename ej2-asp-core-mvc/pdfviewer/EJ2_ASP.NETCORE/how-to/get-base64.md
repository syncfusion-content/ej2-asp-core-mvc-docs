---
layout: post  
title: Retrieving Base64 Value in EJ2 ASP.NET CORE PdfViewer | Syncfusion  
description: Learn how to retrieve the Base64 value in the Syncfusion ASP.NET CORE PDF Viewer component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: PDF Viewer
publishingplatform: ##Platform_Name##
documentation: ug  
---

# Retrieving Base64 Value from a PDF in PDF Viewer
### Overview

This guide demonstrates how to fetch the base64-encoded value of a PDF document loaded in the Syncfusion PDF Viewer using ASP.NET CORE. This feature is beneficial for transferring the PDF data as a Base64 string or performing client-side processing.

### How to Retrieve Base64 Value

**Step 1:** Set Up the PdfViewer in Your ASP.NET MVC Project

 Follow the steps provided in the [link](https://ej2.syncfusion.com/aspnetcore/documentation/pdfviewer/getting-started) to create a simple PDF Viewer sample.

**Step 2:** Add Button and Function for Fetching Base64 Value

Incorporate a button in your view to enable users to start the process of converting the loaded PDF document into a Base64 string.

```html
<div class="text-center">
    <!-- Button to trigger the fetching of Base64 -->
    <button id="getBase64">Get Base64</button>
    <ejs-pdfviewer id="pdfviewer" style="height:600px" resourceUrl="https://cdn.syncfusion.com/ej2/27.2.2/dist/ej2-pdfviewer-lib" documentPath="https://cdn.syncfusion.com/content/pdf/pdf-succinctly.pdf">
    </ejs-pdfviewer>
</div>

<script type="text/javascript">
    document.addEventListener('DOMContentLoaded', function () {
        var pdfViewer = document.getElementById('pdfviewer').ej2_instances[0];
        // Add an event listener to the button to get Base64 string of the loaded document
        document.getElementById('getBase64').addEventListener('click', function () {
            base64ofloadedDocument();  // Call the function to get the Base64 string
        });
        // Function to get Base64 of the loaded document
        function base64ofloadedDocument() {
            pdfViewer.saveAsBlob().then(function (value) {
                var data = value;
                var reader = new FileReader();
                reader.readAsDataURL(data);
                reader.onload = function () {
                    var base64data = reader.result;
                    console.log(base64data);
                };
            });
        }
    });
</script>

```
### Conclusion

By following these steps, you can easily convert and retrieve a PDF document's Base64 string. This conversion is particularly useful for transmitting PDF data or integrating with systems that require Base64 encoding.

[View sample in GitHub](https://github.com/SyncfusionExamples/mvc-pdf-viewer-examples/tree/master/How%20to)