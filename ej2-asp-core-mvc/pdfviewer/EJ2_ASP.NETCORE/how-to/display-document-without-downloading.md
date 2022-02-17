---
layout: post
title: Display Document Without Downloading in ##Platform_Name## Pdfviewer Component
description: Learn here all about Display Document Without Downloading in Syncfusion ##Platform_Name## Pdfviewer component and more.
platform: ej2-asp-core-mvc
control: Display Document Without Downloading
publishingplatform: ##Platform_Name##
documentation: ug
---


# Display document without downloading

The PDF Viewer server library allows you to display the downloaded PDF document in the PDF Viewer control without downloading a document in the local machine using the **load** method.

The following steps are used to display the downloaded without downloading in the local machine.

**Step 1:** Follow the steps provided in the [link](https://ej2.syncfusion.com/aspnetcore/documentation/pdfviewer/getting-started/) to create a simple PDF Viewer sample.

**Step 2:** Use the following code snippet to Display document without downloading.

```html
<button onclick="downloadDocument()">downloadDocument</button>

<script>
    function downloadDocument() {
        var viewer = document.getElementById('pdfviewer').ej2_instances[0];
        viewer.saveAsBlob().then(function (value) {
            var data = value;
            var reader = new FileReader();
            reader.readAsDataURL(data);
            reader.onload = () => {
                var base64data = reader.result;
                console.log(base64data);
                viewer.load(base64data, null);
            };
        });
    }
</script>
```

Download the sample [how to display document without downloading](https://www.syncfusion.com/downloads/support/directtrac/general/ze/Coresample-473210677.zip)