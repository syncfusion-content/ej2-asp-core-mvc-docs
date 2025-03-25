---
layout: post
title: Find Text Async in EJ2 ASP.NET MVC PDF Viewer | Syncfusion
description: Learn about the `findTextAsync` in ASP.NET MVC PDF Viewer component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: PDF Viewer
publishingplatform: ##Platform_Name##
documentation: ug
---

# Find Text using findTextAsync Method in Syncfusion PdfViewer

The findTextAsync method in the Syncfusion PdfViewer control allows you to search for specific text or an array of strings asynchronously within a PDF document. The method returns the bounding rectangles for each occurrence of the search term, allowing you to find and work with text positions in the document.

Here is an example of how you can use the **findTextAsync** method:


```html
<div>
    <div style="height:500px;width:100%;">
    <!-- Buttons for triggering text search -->
    <button id="findTextBtn" onclick="findText()">Find Text</button>
    <button id="findTextsBtn" onclick="findTexts()">Find Multiple Texts</button>
        @Html.EJS().PdfViewer("pdfviewer").DocumentPath("https://cdn.syncfusion.com/content/pdf/pdf-succinctly.pdf").Render()
    </div>
</div>

<!-- Ensure necessary Syncfusion scripts and styles are included -->
<script src="https://cdn.syncfusion.com/ej2/28.1.33/dist/ej2.min.js"></script>

<script type="text/javascript">
    function findText() {
        var viewer = document.getElementById('pdfviewer').ej2_instances[0];
        // Search for a single text ('pdf') across all pages (case insensitive)
            viewer.textSearchModule.findTextAsync('pdf', false).then(function (res) {
                console.log(res);  // Log the search results
        });
    }
    function findTexts() {
        var viewer = document.getElementById('pdfviewer').ej2_instances[0];
        // Search for multiple texts (['pdf', 'the']) across all pages (case insensitive)
            viewer.textSearchModule.findTextAsync(['pdf', 'the'], false).then(function (res) {
                console.log(res);  // Log the search results
        });
    }
</script>

```

### Description:

The `findTextAsync` method is designed for performing an asynchronous text search within a PDF document. You can use it to search for a single string or multiple strings, with the ability to control case sensitivity. By default, the search is applied to all pages of the document. However, you can adjust this behavior by specifying the page number (pageIndex), which allows you to search only a specific page if needed.

### Parameters:

**text (string | string[]):**

The text or an array of texts you want to search for in the document.

**matchCase (boolean):**

Indicates whether the search should be case-sensitive.
When set to true, the search will match the exact case.
When set to false, the search will ignore case differences.

**pageIndex (optional, number):**

Specifies the page number (zero-based index) to search within the document.
If not provided, the search will be performed across all pages in the document.
For example, passing 0 would search only the first page of the document.

### Example Workflow:

**findTextAsync('pdf', false):**
This will search for the term "pdf" in a case-insensitive manner across all pages of the document.

**findTextAsync(['pdf', 'the'], false):**
This will search for the terms "pdf" and "the" in a case-insensitive manner across all pages of the document.

**findTextAsync('pdf', false, 0):**
This will search for the term "pdf" in a case-insensitive manner only on the first page (page 0).

**findTextAsync(['pdf', 'the'], false, 1):**
This will search for the terms "pdf" and "the" in a case-insensitive manner only on the second page (page 1).