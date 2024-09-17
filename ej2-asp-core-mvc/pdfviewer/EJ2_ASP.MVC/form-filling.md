---
layout: post
title: Form Filling in ##Platform_Name## Pdfviewer Component | Syncfusion
description: Learn here all about Form Filling in Syncfusion ##Platform_Name## Pdfviewer component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: PDF Viewer
publishingplatform: ##Platform_Name##
documentation: ug
---


# Form Filling in the ASP.NET MVC PDF Viewer component

PDF Viewer component allows you to display the form fields available in the PDF document. By using this, you can edit and download the form fields.

The form fields displayed in the PDF Viewer are:

* Text box
* Password box
* Combo box
* Check box
* Radio Button
* Signature Field
* List box

![FormFilling](./images/formfilling.png)

## Disabling form fields

The PDF Viewer control provides an option to disable the form fields feature. The code sample for disabling the form fields is as follows.

{% tabs %}
{% highlight html tabtitle="Standalone" %}
```html
<div style="width:100%;height:600px">
    @Html.EJS().PdfViewer("pdfviewer").EnableFormFields(false).DocumentPath("https://cdn.syncfusion.com/content/pdf/form-filling-document.pdf").Render()
</div>
```
{% endhighlight %}
{% highlight html tabtitle="Server-Backed" %}
```html
<div style="width:100%;height:600px">
    @Html.EJS().PdfViewer("pdfviewer").ServiceUrl(VirtualPathUtility.ToAbsolute("~/PdfViewer/")).EnableFormFields(false).DocumentPath("https://cdn.syncfusion.com/content/pdf/form-filling-document.pdf").Render()
</div>
```
{% endhighlight %}
{% endtabs %}

## How to draw handwritten signature in the signature field

Signature can be added to the Signature field by using the following steps:

* Click the Signature Field in the PDF document. The signature panel will appear.

![SignatureField](./images/signaturefield.png)

* Draw the signature in the signature panel.

![SignaturePanel](./images/signature.png)

* Click the **CREATE** button, the drawn signature will be added in the signature field.

![Signature](./images/sign.png)

## Delete the signature inside the signature field

You can also delete the signature in the signature field by using Delete Option in the annotation toolbar.

![DeleteSign](./images/deletesign.png)

## Import and export form fields

The PDF Viewer control provides the support to import and export form fields using a JSON object in the PDF document.

## Importing form fields using PDF Viewer API

You can import the form fields using JSON file or JSON object in code behind like the below code sample.

```html
<button id="viewer" onclick="OnImportFormFieldsClick()">Import FormFields</button>
<div style="width:100%;height:600px">
    @Html.EJS().PdfViewer("pdfviewer").ServiceUrl(VirtualPathUtility.ToAbsolute("~/PdfViewer/")).DocumentPath("https://cdn.syncfusion.com/content/pdf/form-filling-document.pdf").Render()
</div>
<script>
    function OnImportFormFieldsClick() {
        var pdfViewer = document.getElementById('pdfviewer').ej2_instances[0];
        //The json file has been placed inside the App_Data folder.);
        pdfViewer.importFormFields("D:/PDFViewer/Examples/mvcsample/App_Data/ImportFormFields.json");
    }
</script>
```

N>The JSON file for importing the form fields should be placed in the desired location and the path should be provided correctly.

## Exporting form fields from the PDF document using PDF Viewer API

You can export the form fields as JSON file in code behind as the following code sample.

{% tabs %}
{% highlight html tabtitle="Standalone" %}
```html
<button id="viewer" onclick="OnExportFormFieldsClick()">Export FormFields</button>
<div style="width:100%;height:600px">
    @Html.EJS().PdfViewer("pdfviewer").DocumentPath("https://cdn.syncfusion.com/content/pdf/form-filling-document.pdf").Render()
</div>
<script>
    function OnExportFormFieldsClick() {
        var pdfViewer = document.getElementById('pdfviewer').ej2_instances[0];
         pdfViewer.exportFormFields(null,'Json');
    }
</script>
```
{% endhighlight %}
{% highlight html tabtitle="Server-Backed" %}
```html
<button id="viewer" onclick="OnExportFormFieldsClick()">Export FormFields</button>
<div style="width:100%;height:600px">
    @Html.EJS().PdfViewer("pdfviewer").ServiceUrl(VirtualPathUtility.ToAbsolute("~/PdfViewer/")).DocumentPath("https://cdn.syncfusion.com/content/pdf/form-filling-document.pdf").Render()
</div>
<script>
    function OnExportFormFieldsClick() {
        var pdfViewer = document.getElementById('pdfviewer').ej2_instances[0];
         pdfViewer.exportFormFields(null,'Json');
    }
</script>
```
{% endhighlight %}
{% endtabs %}