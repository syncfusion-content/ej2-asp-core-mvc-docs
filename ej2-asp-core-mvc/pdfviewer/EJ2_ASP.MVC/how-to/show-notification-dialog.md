---
layout: post
title: Show Notification Dialog in EJ2 ASP.NET MVC PDF Viewer | Syncfusion
description: Learn here all about Show Notification Dialog in ASP.NET MVC PDF Viewer component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Show Notification Dialog
publishingplatform: ##Platform_Name##
documentation: ug
---


# Show the notification dialog in UI When form fields are empty

The PDF Viewer server library allows you to show the notification dialog in UI when fields in the form are not filled or empty using the following properties and events below,

* [**EnableFormFieldsValidation**](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PdfViewer.PdfViewer.html#Syncfusion_EJ2_PdfViewer_PdfViewer_EnableFormFieldsValidation)
* [**ShowNotificationDialog**](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PdfViewer.PdfViewer.html#Syncfusion_EJ2_PdfViewer_PdfViewer_ShowNotificationDialog)
* [**validateFormFields**](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PdfViewer.PdfViewer.html#Syncfusion_EJ2_PdfViewer_PdfViewer_ValidateFormFields)

The following steps are used to show the notification dialog in UI.

**Step 1:** Follow the steps provided in the [link](https://ej2.syncfusion.com/aspnetmvc/documentation/pdfviewer/getting-started/) to create a simple PDF Viewer sample.

**Step 2:** Use the following code snippet to show the notification dialog when form fields are empty.

```cs

@Html.EJS().PdfViewer("pdfviewer").ServiceUrl(VirtualPathUtility.ToAbsolute("~/PdfViewer/")).DocumentPath("https://cdn.syncfusion.com/content/pdf/form-filling-document.pdf").ValidateFormFields("validateFormFields").EnableFormFieldsValidation(true).ShowNotificationDialog(false).Render()

<script>
    function validateFormFields(args) {
        var nonfilledFormFields = args.nonFillableFields;
        var viewer = document.getElementById('pdfviewer').ej2_instances[0];
        var errorMessage = "Kindly fill all the form fieds";
        viewer.showNotificationPopup(errorMessage);
    }
</script>

```

Find the sample of [how to show the notification dialog in UI When form fields are empty](https://www.syncfusion.com/downloads/support/directtrac/general/ze/MVC_SAMPLE_d50d2de6-1937239856.zip)