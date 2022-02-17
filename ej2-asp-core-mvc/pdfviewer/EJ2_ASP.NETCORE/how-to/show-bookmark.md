---
layout: post
title: Show Bookmark in ##Platform_Name## Pdfviewer Component
description: Learn here all about Show Bookmark in Syncfusion ##Platform_Name## Pdfviewer component and more.
platform: ej2-asp-core-mvc
control: Show Bookmark
publishingplatform: ##Platform_Name##
documentation: ug
---


# Show Bookmark

The PDF Viewer server library allows you to show the bookmark programmatically by setting the [**enableBookmark**](https://ej2.syncfusion.com/javascript/documentation/api/pdfviewer/#enablebookmark) property to `true`. We can also disable the bookmark by setting the property to `false`.

>Default value of `enableBookmark` property is true.

The following steps are used to show the bookmark.

**Step 1:** Follow the steps provided in the [link](https://ej2.syncfusion.com/aspnetcore/documentation/pdfviewer/getting-started/) to create a simple PDF Viewer sample.

**Step 2:** Use the following code snippet to Show the Bookmark.

```html
<ejs-pdfviewer id="pdfviewer" serviceUrl="/api/PdfViewer" documentPath="PDF Succinctly.pdf" enableBookmark="true"></ejs-pdfviewer>
```

Download the sample [how to show bookmark](https://www.syncfusion.com/downloads/support/directtrac/general/ze/Coresample-473210677.zip)