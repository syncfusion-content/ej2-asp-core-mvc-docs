---
layout: post
title: Add date to signature field in EJ2 ASP.NET MVC PDF Viewer | Syncfusion
description: Learn here all about how to add the date to the signature text in ASP.NET MVC PDF Viewer component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: How to add the date to the signature text
publishingplatform: ej2-asp-core-mvc
documentation: UG
---

# How to add the date to the signature text

To add a date with the signature text in Syncfusion<sup style="font-size:70%">&reg;</sup> PDF Viewer, use the `updateFormFieldsValue()` method. Add a signature field to a PDF document and get the signature field in a PDF using the `retrieveFormFields()` method and store it in a variable. Modify the value of the signature field and get the current date. Use the `Date()` method to get the current date and format it as desired.

Update the signature field in a PDF using the `updateFormFieldsValue()` method and pass the modified signature field as a parameter.

{% tabs %}
{% highlight html tabtitle="Standalone" %}
```html
<div>
    <div style="width:100%;height:600px">
        <button type="button" onclick="signatureWithDate()">Add Signature with the time</button>
        @Html.EJS().PdfViewer("pdfviewer").DocumentPath("https://cdn.syncfusion.com/content/pdf/form-filling-document.pdf").Render()
    </div>
</div>

<script>
    function signatureWithDate() {
        var viewer = document.getElementById('pdfviewer').ej2_instances[0];
        var formFields = viewer.retrieveFormFields();
        formFields[0].signatureType = 'Type';
        formFields[0].value = 'Syncfusion \n' + new Date();
        viewer.updateFormFieldsValue(formFields[0]);
    }
</script>
```
{% endhighlight %}
{% highlight html tabtitle="Server-Backed" %}
```html
<div>
    <div style="width:100%;height:600px">
        <button type="button" onclick="signatureWithDate()">Add Signature with the time</button>
        @Html.EJS().PdfViewer("pdfviewer").ServiceUrl(VirtualPathUtility.ToAbsolute("~/Home/")).DocumentPath("https://cdn.syncfusion.com/content/pdf/pdf-succinctly.pdf").Render()
    </div>
</div>

<script>
    function signatureWithDate() {
        var viewer = document.getElementById('pdfviewer').ej2_instances[0];
        var formFields = viewer.retrieveFormFields();
        formFields[0].signatureType = 'Type';
        formFields[0].value = 'Syncfusion \n' + new Date();
        viewer.updateFormFieldsValue(formFields[0]);
    }
</script>
```
{% endhighlight %}
{% endtabs %}

[View Sample in GitHub](https://github.com/SyncfusionExamples/mvc-pdf-viewer-examples/tree/EJ2-67373-sample/How%20to/Add%20date%20with%20the%20signature)