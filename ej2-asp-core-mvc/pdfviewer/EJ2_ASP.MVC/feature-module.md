---
layout: post
title: Feature Module in ##Platform_Name## Pdfviewer Component
description: Learn here all about Feature Module in Syncfusion ##Platform_Name## Pdfviewer component and more.
platform: ej2-asp-core-mvc
control: Feature Module
publishingplatform: ##Platform_Name##
documentation: ug
---


# Feature modules

The PDF Viewer features are segregated into individual feature-wise modules to enable selectively referencing in the application. The required modules should be injected to extend its functionality. The following are the selective modules of PDF Viewer that can be included as required:

The available PdfViewer modules are:

* **Toolbar**:- Built in toolbar for better user interaction.
* **Magnification**:- Perform zooming operation for better viewing experience.
* **Navigation**:- Easy navigation across the PDF pages.
* **LinkAnnotation**:- Easy navigation within and outside of the PDF document.
* **ThumbnailView**:- Easy navigation with in the PDF document.
* **BookmarkView**:- Easy navigation based on the bookmark content of the PDF document.
* **TextSelection**:- Select and copy text from a PDF file.
* **TextSearch**:- Search a text easily across the PDF document.
* **Print**:- Print the entire document or a specific page directly from the browser.
* **Annotation**:- Annotations can be added or edited in the PDF document.

>In addition to injecting the required modules in your application, enable corresponding properties to extend the functionality for a PDF Viewer instance.
Refer to the following table.

| Module | Property to enable the functionality for a PDF Viewer instance |
|---|---|
|Toolbar|`@Html.EJS().PdfViewer("container").EnableToolbar(true).Render()`|
|Magnification|`@Html.EJS().PdfViewer("container").EnableMagnification(true).Render()`|
|Navigation|`@Html.EJS().PdfViewer("container").EnableNavigation(true).Render()`|
|LinkAnnotation|`@Html.EJS().PdfViewer("container").EnableHyperlink(true).Render()`|
|ThumbnailView|`@Html.EJS().PdfViewer("container").EnableThumbnail(true).Render()`|
|BookmarkView|`@Html.EJS().PdfViewer("container").EnableBookmark(true).Render()`|
|TextSelection|`@Html.EJS().PdfViewer("container").EnableTextSelection(true).Render()`|
|TextSearch|`@Html.EJS().PdfViewer("container").EnableTextSearch(true).Render()`|
|Print|`@Html.EJS().PdfViewer("container").EnablePrint(true).Render()`|
|Annotation|`@Html.EJS().PdfViewer("container").EnableAnnotation(true).Render()`|

## See also

* [Toolbar items](./toolbar)
* [Toolbar customization](./how-to/toolbar_customization)