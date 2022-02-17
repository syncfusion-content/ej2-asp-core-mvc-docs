---
layout: post
title: Load Documents in ##Platform_Name## Pdfviewer Component
description: Learn here all about Load Documents in Syncfusion ##Platform_Name## Pdfviewer component and more.
platform: ej2-asp-core-mvc
control: Load Documents
publishingplatform: ##Platform_Name##
documentation: ug
---


# Load PDF documents dynamically

The PDF Viewer server library allows to switch or load the PDF documents dynamically after the initial load operation. To achieve this, load the PDF document as a base64 string or file name in PDF Viewer control using the **Load()** method dynamically.

The following steps are used to load the PDF document dynamically.

**Step 1:** Follow the steps provided in the [link](https://ej2.syncfusion.com/aspnetcore/documentation/pdfviewer/getting-started/) to create a simple PDF Viewer sample.

**Step 2:** Use the following code snippet to load PDF document using base64 string.

```html
<button type="button" onclick="load1()">LoadDocumentFromBase64</button>
<script>
function load1() {
    var viewer = document.getElementById('pdfViewer').ej2_instances[0];
    viewer.load("data:application/pdf;base64," + addBase64String, null);
}
</script>
```

**Step 3:** Use the following code snippet to load PDF document using document name.

```html
<button type="button" onclick="load2()">LoadDocument</button>
<script>
// load document using document name.
function load2() {
    var viewer = document.getElementById('pdfViewer').ej2_instances[0];
    viewer.load("HTTP Succinctly.pdf",null)
}
</script>
```

Download the sample, [how to load PDF documents dynamically](https://www.syncfusion.com/downloads/support/directtrac/general/ze/EJ2CoreSample1651615851.zip)