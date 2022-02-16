---
layout: post
title: Text_search in ##Platform_Name## Pdfviewer Component
description: Learn here all about Text_search in Syncfusion ##Platform_Name## Pdfviewer component and more.
platform: ej2-asp-core-mvc
control: Text_search
publishingplatform: ##Platform_Name##
documentation: ug
---

# Text Search

The Text Search option in PDF Viewer is used to find and highlight the text content from the document. You can enable/disable the text search using the following code snippet.

```html
    <div style="width:100%;height:600px">
        <ejs-pdfviewer id="pdfviewer"
                style="height:600px"
                serviceUrl="/api/PdfViewer"
                documentPath=@ViewBag.DocumentPath
                enableTextSearch="true">
        </ejs-pdfviewer>
    </div>
```

![Alt text](./images/search.png)

## See also

* [Toolbar items](./toolbar)
* [Feature Modules](./feature-module)