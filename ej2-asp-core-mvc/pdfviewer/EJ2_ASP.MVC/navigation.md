---
layout: post
title: Navigation in ##Platform_Name## Pdfviewer Component
description: Learn here all about Navigation in Syncfusion ##Platform_Name## Pdfviewer component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Navigation
publishingplatform: ##Platform_Name##
documentation: ug
---


# Navigation

The ASP.NET Core PDF Viewer supports different internal and external navigations.

## Toolbar page navigation option

The default toolbar of PDF Viewer contains the following navigation options:

* **Go to page**:- Navigates to the specific page of a PDF document.
* **Show next page**:- Navigates to next page of a PDF document.
* **Show previous page**:- - Navigates to the previous page of a PDF document.
* **Show first page**:-  Navigates to the first page of a PDF document.
* **Show last page**:- Navigates to the last page of a PDF document.

You can enable/disable page navigation option in PDF Viewer using the following code snippet.

```html
    <div style="width:100%;height:600px">
        @Html.EJS().PdfViewer("pdfviewer").ServiceUrl(VirtualPathUtility.ToAbsolute("~/api/PdfViewer/")).EnableNavigation(true).DocumentPath("Hive_Succinctly.pdf").Render()
    </div>
```

![Alt text](./images/navigation.png)

## Bookmark navigation

The bookmarks saved in PDF files are loaded and made ready for easy navigation.
You can enable/disable bookmark navigation by using the following code snippet.,

```html
    <div style="width:100%;height:600px">
       @Html.EJS().PdfViewer("pdfviewer").ServiceUrl(VirtualPathUtility.ToAbsolute("~/api/PdfViewer/")).EnableBookmark(true).DocumentPath("Hive_Succinctly.pdf").Render()
    </div>
```

![Alt text](./images/bookmark.png)

## Thumbnail navigation

Thumbnails is the miniature representation of actual pages in PDF files. This feature displays thumbnails of the pages and allows navigation.
You can enable/disable thumbnail navigation by using the following code snippet.,

```html
    <div style="width:100%;height:600px">
       @Html.EJS().PdfViewer("pdfviewer").ServiceUrl(VirtualPathUtility.ToAbsolute("~/api/PdfViewer/")).EnableThumbnail(true).DocumentPath("Hive_Succinctly.pdf").Render()
    </div>
```

![Alt text](./images/thumbnail.png)

## Hyperlink navigation

Hyperlink navigation features enables navigation to the URLs (website links) in a PDF file.

![Alt text](./images/link.png)

## Table of content navigation

Table of contents navigation allows users to navigate to different parts of a PDF file that are listed in the table of contents section.

You can enable/disable link navigation by using the following code snippet.,

```html
    <div style="width:100%;height:600px">
       @Html.EJS().PdfViewer("pdfviewer").ServiceUrl(VirtualPathUtility.ToAbsolute("~/api/PdfViewer/")).EnableHyperlink(true).DocumentPath("Hive_Succinctly.pdf").Render()
    </div>
```

You can change the open state of the hyperlink in the PDF Viewer by using the following code snippet.,

```html
    <div style="width:100%;height:600px">
     @Html.EJS().PdfViewer("pdfviewer").ServiceUrl(VirtualPathUtility.ToAbsolute("~/api/PdfViewer/")).hyperlinkOpenState(Syncfusion.EJ2.PdfViewer.LinkTarget.NewTab).DocumentPath("Hive_Succinctly.pdf").Render()
    </div>
```

![Alt text](./images/toc.png)

## Update page navigation programmatically

You can update the page navigation options such as previous page, next page programmatically by using the `goToPreviousPage()` and `goToNextPage()` API's.

The following code sample illustrates how to perform page navigation options using button click.

```html
@using Syncfusion.EJ2
@using Syncfusion.EJ2.PdfViewer
@using System.IO

@{
    ViewBag.Title = "Home Page";
}

<button type="button" onclick="previouspage()">Previous Page</button>
<button type="button" onclick="nextpage()">Next Page</button>
<button type="button" onclick="addAnnotation()">Add annotation</button>
<button type="button" onclick="addFormField()">Add FormField</button>
<button type="button" onclick="addtags()">Add tags</button>
<div style="width:100%;height:600px">
    <!--Code to render PDF Viewer-->
    @Html.EJS().PdfViewer("pdfviewer").ServiceUrl(VirtualPathUtility.ToAbsolute("~/PdfViewer/")).DocumentPath("PDF Succinctly.pdf").Render()
</div>
<style>
    #pdfviewer {
        display: block;
    }
    
</style>

<script>
    //Method to add free text annotation programmatically.
    function  addAnnotation() {
        var viewer = document.getElementById('pdfviewer').ej2_instances[0];
    viewer.annotation.setAnnotationMode("FreeText");
    }
    //Method to add form field value programmatically.
    function addFormField() {
        var pdfviewer = document.getElementById('pdfviewer').ej2_instances[0];
            pdfviewer.formDesignerModule.addFormField('Textbox', {
                name: 'Textbox',
            bounds: {X: 146, Y: 229, Width: 150, Height: 24 },
            });
    }
    //Method to add tag filed programmatically.
    function addtags() {
        var viewer = document.getElementById('pdfviewer').ej2_instances[0];
        viewer.annotation.setAnnotationMode("StickyNotes");
    }
    //Method to navigate to the previous page programmatically.
    function previouspage() {
        var viewer = document.getElementById('pdfviewer').ej2_instances[0];
        viewer.navigation.goToPreviousPage();
    }
    //Method to navigate to the next page programmatically.
    function nextpage() {
        var viewer = document.getElementById('pdfviewer').ej2_instances[0];
        viewer.navigation.goToNextPage();
    }

</script>
```

[View sample in GitHub](https://github.com/SyncfusionExamples/mvc-pdf-viewer-examples/tree/master/How%20to/Update%20navigation%2C%20annotation%20and%20form%20fields)

## See also

* [Toolbar items](./toolbar)
* [Feature Modules](./feature-module)