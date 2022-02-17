---
layout: post
title: Include The Authorization Token in ##Platform_Name## Pdfviewer Component
description: Learn here all about Include The Authorization Token in Syncfusion ##Platform_Name## Pdfviewer component and more.
platform: ej2-asp-core-mvc
control: Include The Authorization Token
publishingplatform: ##Platform_Name##
documentation: ug
---


# Include Authorization token

The PDF Viewer server library allows you to include the Authorization token in the PDF Viewer AJAX request using the ajaxRequest headers properties available in AjaxRequestSettings and it will be included in every AJAX request send from PDF Viewer.

The following steps are used to include the Authorization token for PDF viewer control,

**Step 1:** Follow the steps provided in the [link](https://ej2.syncfusion.com/aspnetmvc/documentation/pdfviewer/getting-started/) to create simple PDF Viewer sample.

**Step 2:** Add the following code snippet to include the authorization token,

```html

@Html.EJS().PdfViewer("pdfviewer").ServiceUrl(VirtualPathUtility.ToAbsolute("~/PdfViewer/")).DocumentPath("PDF_Succinctly.pdf").AjaxRequestSettings(new PdfViewerAjaxRequestSettings { WithCredentials = true, AjaxHeaders = new object[] { new { headerName = "Testingabc", headerValue = "Testing123" } } }).Render()

```

Download the sample [how to include authorization token](https://www.syncfusion.com/downloads/support/directtrac/general/ze/MVCSAM~21380738543)