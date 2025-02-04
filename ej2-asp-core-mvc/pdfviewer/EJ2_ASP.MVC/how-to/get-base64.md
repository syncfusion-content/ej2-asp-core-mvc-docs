---
layout: post  
title: Retrieving Base64 Value in EJ2 ASP.NET MVC PdfViewer | Syncfusion  
description: Learn how to retrieve the Base64 value in the Syncfusion ASP.NET MVC PDF Viewer component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: How to retrieve Base64
publishingplatform: ##Platform_Name##
documentation: ug  
---

# Retrieving Base64 Value from a PDF in PDF Viewer
### Overview

This guide demonstrates how to fetch the base64-encoded value of a PDF document loaded in the Syncfusion PDF Viewer using ASP.NET MVC. This feature is beneficial for transferring the PDF data as a Base64 string or performing client-side processing.

### How to Retrieve Base64 Value

**Step 1:** Set Up the PdfViewer in Your ASP.NET MVC Project

 Follow the steps provided in the [link](https://ej2.syncfusion.com/aspnetmvc/documentation/pdfviewer/getting-started) to create a simple PDF Viewer sample.

**Step 2:** Add Button and Function for Fetching Base64 Value

Incorporate a button in your view to enable users to start the process of converting the loaded PDF document into a Base64 string.

```html
<div>
    <div style="height:500px;width:100%;">
        <!-- Button to trigger Base64 conversion -->
        <button id="getBase64">Get Base64</button>
        @Html.EJS().PdfViewer("pdfviewer").DocumentPath("https://cdn.syncfusion.com/content/pdf/pdf-succinctly.pdf").Render()
    </div>
</div>

<!-- Ensure necessary Syncfusion scripts and styles are included -->
<script src="https://cdn.syncfusion.com/ej2/27.2.4/dist/ej2.min.js"></script>

<script type="text/javascript">
    window.onload = function () {
        var viewer = document.getElementById('pdfviewer').ej2_instances[0];
        // Add an event listener to the button to get Base64 string of the loaded document
        document.getElementById('getBase64').addEventListener('click', function () {
            getBase64EncodedDocument();  // Call the function to get the Base64 string
        });

        // Function to get Base64 of the loaded document
        function getBase64EncodedDocument() {
            viewer.saveAsBlob().then(function (blob) {
                var reader = new FileReader();
                reader.readAsDataURL(blob);
                reader.onload = function () {
                    var base64data = reader.result;
                    console.log(base64data);
                    // You can handle the base64data as needed, e.g., sending it to a server or displaying it
                };
            }).catch(function (error) {
                console.error('Error converting PDF to Base64:', error);
            });
        }
    };
</script>

```
### Conclusion

By following these steps, you can easily convert and retrieve a PDF document's Base64 string. This conversion is particularly useful for transmitting PDF data or integrating with systems that require Base64 encoding.

[View sample in GitHub](https://github.com/SyncfusionExamples/mvc-pdf-viewer-examples/tree/master/How%20to)