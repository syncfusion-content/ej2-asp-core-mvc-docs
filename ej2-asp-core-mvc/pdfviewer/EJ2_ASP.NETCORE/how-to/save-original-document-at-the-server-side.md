---
layout: post
title: Save Original Document At The Server Side in ##Platform_Name## Pdfviewer Component
description: Learn here all about Save Original Document At The Server Side in Syncfusion ##Platform_Name## Pdfviewer component and more.
platform: ej2-asp-core-mvc
control: Save Original Document At The Server Side
publishingplatform: ##Platform_Name##
documentation: ug
---


# Save original document at the server side

The PDF Viewer server library allows to save original PDF document pages at the server side. The following steps are used to save original PDF document at the server side using button click event.

The following steps are used to save original document at the server side.

**Step 1:** Follow the steps provided in the [link](https://ej2.syncfusion.com/aspnetcore/documentation/pdfviewer/getting-started/) to create simple PDF Viewer sample.

**Step 2:** Use the following code snippet to create a button click event in PDF Viewer Control.

```html

<button onclick="save()">SaveDocument</button>
<script>
    function save() {
        var pdfViewer = document.getElementById('pdfviewer1').ej2_instances[0];
        pdfViewer.serverActionSettings.download = "SaveDocument";
        pdfViewer.download();
        pdfViewer.serverActionSettings.download = "Download";
    }
</script>

```

**Step 3:** Add the following code snippet in PDFViewerController.cs to save original PDF document at the server side.

```cs

public ActionResult SaveDocument([FromBody] Dictionary<string, string> jsonObject)
{
    PdfRenderer pdfviewer = new PdfRenderer(_cache);
    string documentBase = pdfviewer.GetDocumentAsBase64(jsonObject);
    string base64String = documentBase.Split(new string[] { "data:application/pdf;base64," }, StringSplitOptions.None)[1];
    if (base64String != null || base64String != string.Empty)
    {
        byte[] byteArray = Convert.FromBase64String(base64String);

        MemoryStream ms = new MemoryStream(byteArray);
        var path = _hostingEnvironment.ContentRootPath;
        System.IO.File.WriteAllBytes(path + "/ouptut.pdf", byteArray);
    }
    return Content(string.Empty);
}

```

Download the sample [how to save original document at the server side](https://www.syncfusion.com/downloads/support/directtrac/general/ze/EJ2PDF~11039397667)

>Ensure the provided document path and output saved locations in your application level.