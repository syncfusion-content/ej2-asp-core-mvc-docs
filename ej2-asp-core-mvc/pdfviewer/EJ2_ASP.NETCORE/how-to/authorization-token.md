---
layout: post
title: Authorization Token in ##Platform_Name## Pdfviewer Component
description: Learn here all about Authorization Token in Syncfusion ##Platform_Name## Pdfviewer component and more.
platform: ej2-asp-core-mvc
control: Authorization Token
publishingplatform: ##Platform_Name##
documentation: ug
---


# Include the Authorization token

The PDF Viewer library allows you to include the authorization token in the PDF viewer AJAX request using the properties of the ajaxRequest header available in `AjaxRequestSettings`, and it will be included in every AJAX request send from PDF Viewer.

The following steps are used to include the authorization token to the PDF viewer control.

**Step 1:** Follow the steps provided in the [link](https://ej2.syncfusion.com/aspnetcore/documentation/pdfviewer/getting-started/) to create simple PDF Viewer sample in React.

**Step 2:** Add the following code snippet to include the authorization token.

```html
<script>
// Include the Authorization token
window.onload = function () {
    var pdfViewer = document.getElementById('pdfViewer').ej2_instances[0];
    pdfViewer.ajaxRequestSettings = {
        ajaxHeaders: [
            {
                headerName: 'Authorization',

                headerValue: 'Bearer 64565dfgfdsjweiuvbiuyhiueygf'
            }
        ],
        withCredentials: false
    };
}
</script>
```

Find the Sample, [how to include authorization token](https://www.syncfusion.com/downloads/support/directtrac/general/ze/EJ2CoreSample597389369.zip)
