---
layout: post
title: Create Programmatically in EJ2 ASP.NET MVC PDF Viewer | Syncfusion
description: Learn here all about Create Programmatically in ASP.NET MVC PDF Viewer component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Create Programmatically
publishingplatform: ##Platform_Name##
documentation: ug
---

# Create form fields programmatically

The PDF Viewer control provides the option to add, edit and delete the Form Fields. The Form Fields type supported by the PDF Viewer Control are:

* Textbox
* Password
* CheckBox
* RadioButton
* ListBox
* DropDown
* SignatureField
* InitialField

## Add a form field to PDF document programmatically

Using addFormField method, the form fields can be added to the PDF document programmatically. We need to pass two parameters in this method. They are Form Field Type and Properties of Form Field Type. To add form field programmatically, Use the following code.

{% tabs %}
{% highlight html tabtitle="Standalone" %}
```html
    <div style="width:100%;height:600px">
         @Html.EJS().PdfViewer("pdfviewer").DocumentPath("https://cdn.syncfusion.com/content/pdf/form-designer.pdf").DocumentLoad("documentLoad").DownloadEnd("documentLoad").Render()
    </div>
    <script>
       function documentLoad() {
            var viewer = document.getElementById('pdfviewer').ej2_instances[0];
            viewer.formDesignerModule.addFormField("Textbox", { name: "Textbox", bounds: { X: 146, Y: 229, Width: 150, Height: 24 } });
       }
    </script>
```
{% endhighlight %}
{% highlight html tabtitle="Server-Backed" %}
```html

    <div style="width:100%;height:600px">
         @Html.EJS().PdfViewer("pdfviewer").ServiceUrl(VirtualPathUtility.ToAbsolute("~/api/PdfViewer/")).DocumentPath("https://cdn.syncfusion.com/content/pdf/form-designer.pdf").DocumentLoad("documentLoad").DownloadEnd("documentLoad").Render()
    </div>
    <script>
       function documentLoad() {
            var viewer = document.getElementById('pdfviewer').ej2_instances[0];
            viewer.formDesignerModule.addFormField("Textbox", { name: "Textbox", bounds: { X: 146, Y: 229, Width: 150, Height: 24 } });
       }
    </script>
```
{% endhighlight %}
{% endtabs %}

## Edit/Update form field programmatically

Using updateFormField method, Form Field can be updated programmatically. We should get the Form Field object/Id from FormFieldCollections property that you would like to edit and pass it as a parameter to updateFormField method. The second parameter should be the properties that you would like to update for Form Field programmatically. We have updated the value and background Color properties of Textbox Form Field.

{% tabs %}
{% highlight html tabtitle="Standalone" %}
```html
    <div style="width:100%;height:600px">
         @Html.EJS().PdfViewer("pdfviewer").DocumentPath("https://cdn.syncfusion.com/content/pdf/form-designer.pdf").DocumentLoad("documentLoad").DownloadEnd("documentLoad").Render()
    </div>
    <script>
       function documentLoad() {
            var viewer = document.getElementById('pdfviewer').ej2_instances[0];
            viewer.formDesignerModule.addFormField("Textbox", { name: "Textbox", bounds: { X: 146, Y: 229, Width: 150, Height: 24 } });
            viewer.formDesignerModule.addFormField("Textbox", { name: "Textbox", bounds: { X: 300, Y: 229, Width: 150, Height: 24 } });
            viewer.formDesignerModule.updateFormField(pdfviewer.formFieldCollections[0], { backgroundColor: 'red' });
       }
    </script>
```
{% endhighlight %}
{% highlight html tabtitle="Server-Backed" %}
```html

    <div style="width:100%;height:600px">
         @Html.EJS().PdfViewer("pdfviewer").ServiceUrl(VirtualPathUtility.ToAbsolute("~/api/PdfViewer/")).DocumentPath("https://cdn.syncfusion.com/content/pdf/form-designer.pdf").DocumentLoad("documentLoad").DownloadEnd("documentLoad").Render()
    </div>
    <script>
       function documentLoad() {
            var viewer = document.getElementById('pdfviewer').ej2_instances[0];
            viewer.formDesignerModule.addFormField("Textbox", { name: "Textbox", bounds: { X: 146, Y: 229, Width: 150, Height: 24 } });
            viewer.formDesignerModule.addFormField("Textbox", { name: "Textbox", bounds: { X: 300, Y: 229, Width: 150, Height: 24 } });
            viewer.formDesignerModule.updateFormField(pdfviewer.formFieldCollections[0], { backgroundColor: 'red' });
       }
    </script>
```
{% endhighlight %}
{% endtabs %}

## Delete form field programmatically

Using deleteFormField method, the form field can be deleted programmatically. We should retrieve the Form Field object/Id from FormFieldCollections property that you would like to delete and pass it as a parameter to deleteFormField method. To delete a Form Field programmatically, use the following code.

{% tabs %}
{% highlight html tabtitle="Standalone" %}
```html
    <div style="width:100%;height:600px">
         @Html.EJS().PdfViewer("pdfviewer").DocumentPath("https://cdn.syncfusion.com/content/pdf/form-designer.pdf").DocumentLoad("documentLoad").DownloadEnd("documentLoad").Render()
    </div>
    <script>
       function documentLoad() {
            var viewer = document.getElementById('pdfviewer').ej2_instances[0];
            viewer.formDesignerModule.addFormField("Textbox", { name: "Textbox", bounds: { X: 146, Y: 229, Width: 150, Height: 24 } });
            viewer.formDesignerModule.addFormField("Textbox", { name: "Textbox", bounds: { X: 300, Y: 229, Width: 150,Height: 24 } });
            viewer.formDesignerModule.deleteFormField(pdfviewer.formFieldCollections[0]);
           }
    </script>
```
{% endhighlight %}
{% highlight html tabtitle="Server-Backed" %}
```html

    <div style="width:100%;height:600px">
         @Html.EJS().PdfViewer("pdfviewer").ServiceUrl(VirtualPathUtility.ToAbsolute("~/api/PdfViewer/")).DocumentPath("https://cdn.syncfusion.com/content/pdf/form-designer.pdf").DocumentLoad("documentLoad").DownloadEnd("documentLoad").Render()
    </div>
    <script>
       function documentLoad() {
            var viewer = document.getElementById('pdfviewer').ej2_instances[0];
            viewer.formDesignerModule.addFormField("Textbox", { name: "Textbox", bounds: { X: 146, Y: 229, Width: 150, Height: 24 } });
            viewer.formDesignerModule.addFormField("Textbox", { name: "Textbox", bounds: { X: 300, Y: 229, Width: 150,Height: 24 } });
            viewer.formDesignerModule.deleteFormField(pdfviewer.formFieldCollections[0]);
           }
    </script>
```
{% endhighlight %}
{% endtabs %}

## Saving the form fields

When the download icon is selected on the toolbar, the Form Fields will be saved in the PDF document and this action will not affect the original document. Refer the below GIF for further reference.

![Alt text](../../pdfviewer/images/saveformfield.gif)

You can invoke download action using following code snippet.

{% tabs %}
{% highlight html tabtitle="Standalone" %}
```html
<div style="width:100%;height:600px">
    @Html.EJS().PdfViewer("pdfviewer").DocumentLoad("download").EnableDownload(true).DocumentPath("https://cdn.syncfusion.com/content/pdf/hive-succinctly.pdf").Render()
</div>

<script>
    function download() {
        var pdfViewer = document.getElementById('pdfviewer').ej2_instances[0];
        pdfViewer.download();
    }
</script>

```
{% endhighlight %}
{% highlight html tabtitle="Server-Backed" %}
```html
    <div style="width:100%;height:600px">
          @Html.EJS().PdfViewer("pdfviewer").DocumentLoad("download").ServiceUrl(VirtualPathUtility.ToAbsolute("~/api/PdfViewer/")).EnableDownload(true).DocumentPath("https://cdn.syncfusion.com/content/pdf/hive-succinctly.pdf").Render()
    </div>
<script>
    function download() {
        var pdfViewer = document.getElementById('pdfviewer').ej2_instances[0];
        pdfViewer.download();
    }
</script>

```
{% endhighlight %}
{% endtabs %}

## Printing the form fields

When the print icon is selected on the toolbar, the PDF document will be printed along with the Form Fields added to the pages and this action will not affect the original document. Refer the below GIF for further reference.

![Alt text](../../pdfviewer/images/printformfield.gif)

You can invoke print action using the following code snippet.,

{% tabs %}
{% highlight html tabtitle="Standalone" %}

```html
<div style="width:100%;height:600px">
    @Html.EJS().PdfViewer("pdfviewer").EnablePrint(true).DocumentPath("https://cdn.syncfusion.com/content/pdf/hive-succinctly.pdf").Render()
</div>

<script>
    function print() {
        var pdfViewer = document.getElementById('pdfviewer').ej2_instances[0];
        pdfViewer.print.print();
    }
</script>

```
{% endhighlight %}
{% highlight html tabtitle="Server-Backed" %}

```html
<div style="width:100%;height:600px">
    @Html.EJS().PdfViewer("pdfviewer").ServiceUrl(VirtualPathUtility.ToAbsolute("~/api/PdfViewer/")).EnablePrint(true).DocumentPath("https://cdn.syncfusion.com/content/pdf/hive-succinctly.pdf").Render()
</div>

<script>
    function print() {
        var pdfViewer = document.getElementById('pdfviewer').ej2_instances[0];
        pdfViewer.print.print();
    }
</script>

```
{% endhighlight %}
{% endtabs %}

## Open the existing PDF document

We can open the already saved PDF document contains Form Fields in it by clicking the open icon in the toolbar. Refer the below GIF for further reference.

![Alt text](../../pdfviewer/images/openexistingpdf.gif)

## Validate form fields

The form fields in the PDF Document will be validated when the `enableFormFieldsValidation` is set to true and hook the validateFormFields. The validateFormFields will be triggered when the PDF document is downloaded or printed with the non-filled form fields. The non-filled fields will be obtained in the `nonFillableFields` property of the event arguments of validateFormFields.

Add the following code snippet to validate the form fields,

{% tabs %}
{% highlight html tabtitle="Standalone" %}
```html
<div style="width:100%;height:600px">
    @Html.EJS().PdfViewer("pdfviewer").ValidateFormFields("validateFormFields").EnableFormFieldsValidation(true).DocumentPath("https://cdn.syncfusion.com/content/pdf/form-filling-document.pdf").Render()
</div>
<script>
    function validateFormFields(args) {
        var non_filledFormFields = args.nonFillableFields;
    }
</script>

```
{% endhighlight %}
{% highlight html tabtitle="Server-Backed" %}
```html
<div style="width:100%;height:600px">
    @Html.EJS().PdfViewer("pdfviewer").ServiceUrl(VirtualPathUtility.ToAbsolute("~/PdfViewer/")).ValidateFormFields("validateFormFields").EnableFormFieldsValidation(true).DocumentPath("https://cdn.syncfusion.com/content/pdf/form-filling-document.pdf").Render()
</div>
<script>
    function validateFormFields(args) {
        var non_filledFormFields = args.nonFillableFields;
    }
</script>

```
{% endhighlight %}
{% endtabs %}

## Export and import form fields

The PDF Viewer control provides the support to export and import the form field data in the following formats using the `importFormFields`, `exportFormFields`, and `exportFormFieldsAsObject` methods.

* FDF
* XFDF
* JSON

### Export and import as FDF

Using the `exportFormFields` method, the form field data can be exported in the specified data format. This method accepts two parameters:

* The first one must be the destination path for the exported data. If the path is not specified, it will ask for the location while exporting.
* The second parameter should be the format type of the form data.

The following code explains how to export the form field data as FDF.

{% tabs %}
{% highlight html tabtitle="Standalone" %}
```html

<button id="exportFdf" onclick="exportFdf()">Export FDF</button>
<button id="importFdf" onclick="importFdf()">Import FDF</button>

<div style="width:100%;height:600px">
    @Html.EJS().PdfViewer("pdfviewer").DocumentPath("https://cdn.syncfusion.com/content/pdf/pdf-succinctly.pdf").Render()
</div>

<script>
    // Event triggers on Export FDF button click.
    function exportFdf() {
        var viewer = document.getElementById('pdfviewer').ej2_instances[0];
        // Data must be the desired path for the exported document.
        viewer.exportFormFields('Data', FormFieldDataFormat.Fdf);
    }

    // Event triggers on Import FDF button click.
    function importFdf() {
        var viewer = document.getElementById('pdfviewer').ej2_instances[0];
        // The file for importing the form fields should be placed in the desired location, and the path should be provided correctly.
        viewer.importFormFields('File', FormFieldDataFormat.Fdf);
    }
</script>

```
{% endhighlight %}
{% highlight html tabtitle="Server-Backed" %}
```html

<button id="exportFdf" onclick="exportFdf()">Export FDF</button>
<button id="importFdf" onclick="importFdf()">Import FDF</button>

<div style="width:100%;height:600px">
    @Html.EJS().PdfViewer("pdfviewer").ServiceUrl(VirtualPathUtility.ToAbsolute("~/PdfViewer/")).DocumentPath("https://cdn.syncfusion.com/content/pdf/pdf-succinctly.pdf").Render()
</div>

<script>
    // Event triggers on Export FDF button click.
    function exportFdf() {
        var viewer = document.getElementById('pdfviewer').ej2_instances[0];
        // Data must be the desired path for the exported document.
        viewer.exportFormFields('Data', FormFieldDataFormat.Fdf);
    }

    // Event triggers on Import FDF button click.
    function importFdf() {
        var viewer = document.getElementById('pdfviewer').ej2_instances[0];
        // The file for importing the form fields should be placed in the desired location, and the path should be provided correctly.
        viewer.importFormFields('File', FormFieldDataFormat.Fdf);
    }
</script>

```
{% endhighlight %}
{% endtabs %}

### Export and import as XFDF

The following code explains how to export the form field data as XFDF.

{% tabs %}
{% highlight html tabtitle="Standalone" %}
```html
<button id="exportXfdf" onclick="exportXfdf()">Export XFDF</button>
<button id="importXfdf" onclick="importXfdf()">Import XFDF</button>

<div style="width:100%;height:600px">
    @Html.EJS().PdfViewer("pdfviewer").DocumentPath("https://cdn.syncfusion.com/content/pdf/pdf-succinctly.pdf").Render()
</div>

<script>
    // Event triggers on Export XFDF button click.
    function exportXfdf() {
        var viewer = document.getElementById('pdfviewer').ej2_instances[0];
        // Data must be the desired path for the exported document.
        viewer.exportFormFields('Data', FormFieldDataFormat.Xfdf);
    }

    // Event triggers on Import XFDF button click.
    function importXfdf() {
        var viewer = document.getElementById('pdfviewer').ej2_instances[0];
        // The file for importing the form fields should be placed in the desired location, and the path should be provided correctly.
        viewer.importFormFields('File', FormFieldDataFormat.Xfdf);
    }
</script>
```
{% endhighlight %}
{% highlight html tabtitle="Server-Backed" %}
```html
<button id="exportXfdf" onclick="exportXfdf()">Export XFDF</button>
<button id="importXfdf" onclick="importXfdf()">Import XFDF</button>

<div style="width:100%;height:600px">
    @Html.EJS().PdfViewer("pdfviewer").ServiceUrl(VirtualPathUtility.ToAbsolute("~/PdfViewer/")).DocumentPath("https://cdn.syncfusion.com/content/pdf/pdf-succinctly.pdf").Render()
</div>

<script>
    // Event triggers on Export XFDF button click.
    function exportXfdf() {
        var viewer = document.getElementById('pdfviewer').ej2_instances[0];
        // Data must be the desired path for the exported document.
        viewer.exportFormFields('Data', FormFieldDataFormat.Xfdf);
    }

    // Event triggers on Import XFDF button click.
    function importXfdf() {
        var viewer = document.getElementById('pdfviewer').ej2_instances[0];
        // The file for importing the form fields should be placed in the desired location, and the path should be provided correctly.
        viewer.importFormFields('File', FormFieldDataFormat.Xfdf);
    }
</script>
```
{% endhighlight %}
{% endtabs %}

### Export and import as JSON

The following code explains how to export the form field data as JSON.

{% tabs %}
{% highlight html tabtitle="Standalone" %}
```html

<button id="exportJson" onclick="exportJson()">Export JSON</button>
<button id="importJson" onclick="importJson()">Import JSON</button>

<div style="width:100%;height:600px">
    @Html.EJS().PdfViewer("pdfviewer").DocumentPath("https://cdn.syncfusion.com/content/pdf/pdf-succinctly.pdf").Render()
</div>

<script>
    // Event triggers on Export JSON button click.
    function exportJson() {
        var viewer = document.getElementById('pdfviewer').ej2_instances[0];
        // Data must be the desired path for the exported document.
        viewer.exportFormFields('Data', FormFieldDataFormat.Json);
    }

    // Event triggers on Import JSON button click.
    function importJson() {
        var viewer = document.getElementById('pdfviewer').ej2_instances[0];
        // The file for importing the form fields should be placed in the desired location, and the path should be provided correctly.
        viewer.importFormFields('File', FormFieldDataFormat.Json);
    }
</script>
```
{% endhighlight %}
{% highlight html tabtitle="Server-Backed" %}
```html

<button id="exportJson" onclick="exportJson()">Export JSON</button>
<button id="importJson" onclick="importJson()">Import JSON</button>

<div style="width:100%;height:600px">
    @Html.EJS().PdfViewer("pdfviewer").ServiceUrl(VirtualPathUtility.ToAbsolute("~/PdfViewer/")).DocumentPath("https://cdn.syncfusion.com/content/pdf/pdf-succinctly.pdf").Render()
</div>

<script>
    // Event triggers on Export JSON button click.
    function exportJson() {
        var viewer = document.getElementById('pdfviewer').ej2_instances[0];
        // Data must be the desired path for the exported document.
        viewer.exportFormFields('Data', FormFieldDataFormat.Json);
    }

    // Event triggers on Import JSON button click.
    function importJson() {
        var viewer = document.getElementById('pdfviewer').ej2_instances[0];
        // The file for importing the form fields should be placed in the desired location, and the path should be provided correctly.
        viewer.importFormFields('File', FormFieldDataFormat.Json);
    }
</script>
```
{% endhighlight %}
{% endtabs %}

### Export and import as Object

The PDF Viewer control supports exporting the form field data as an object, and the exported data will be imported into the current PDF document from the object.

The following code shows how to export the form field data as an object and import the form field data from that object into the current PDF document via a button click.

{% tabs %}
{% highlight html tabtitle="Standalone" %}
```html
<button id="exportDataAsObject" onclick="exportDataAsObject()">Export Object</button>
<button id="importData" onclick="importData()">Import Data</button>

<div style="width:100%;height:600px">
    @Html.EJS().PdfViewer("pdfviewer").DocumentPath("https://cdn.syncfusion.com/content/pdf/pdf-succinctly.pdf").Render()
</div>

<script>
    var exportedData;

    // Event triggers on Export Object button click.
    function exportDataAsObject() {
        var viewer = document.getElementById('pdfviewer').ej2_instances[0];

        // Export the form field data to an FDF object.
        viewer.exportFormFieldsAsObject(FormFieldDataFormat.Fdf).then(value => {
            exportedData = value;
        })

        //// Export the form field data to an XFDF object.
        //viewer.exportFormFieldsAsObject(FormFieldDataFormat.Xfdf).then(value => {
        //    exportedData = value;
        //})

        //// Export the form field data to an JSON object.
        //viewer.exportFormFieldsAsObject(FormFieldDataFormat.Json).then(value => {
        //    exportedData = value;
        //})
    }

    // Event triggers on Import Data button click.
    function importData() {
        var viewer = document.getElementById('pdfviewer').ej2_instances[0];

        // Import the form field data from the FDF object into the current PDF document.
        viewer.importFormFields(exportedData, FormFieldDataFormat.Fdf);

        //// Import the form field data from the XFDF object into the current PDF document.
        //viewer.importFormFields (exportedData, FormFieldDataFormat.Xfdf);

        //// Import the form field data from the FDF object into the current PDF document.
        //viewer.importFormFields (exportedData, FormFieldDataFormat.Json);
    }
</script>
```
{% endhighlight %}
{% highlight html tabtitle="Server-Backed" %}
```html
<button id="exportDataAsObject" onclick="exportDataAsObject()">Export Object</button>
<button id="importData" onclick="importData()">Import Data</button>

<div style="width:100%;height:600px">
    @Html.EJS().PdfViewer("pdfviewer").ServiceUrl(VirtualPathUtility.ToAbsolute("~/PdfViewer/")).DocumentPath("https://cdn.syncfusion.com/content/pdf/pdf-succinctly.pdf").Render()
</div>

<script>
    var exportedData;

    // Event triggers on Export Object button click.
    function exportDataAsObject() {
        var viewer = document.getElementById('pdfviewer').ej2_instances[0];

        // Export the form field data to an FDF object.
        viewer.exportFormFieldsAsObject(FormFieldDataFormat.Fdf).then(value => {
            exportedData = value;
        })

        //// Export the form field data to an XFDF object.
        //viewer.exportFormFieldsAsObject(FormFieldDataFormat.Xfdf).then(value => {
        //    exportedData = value;
        //})

        //// Export the form field data to an JSON object.
        //viewer.exportFormFieldsAsObject(FormFieldDataFormat.Json).then(value => {
        //    exportedData = value;
        //})
    }

    // Event triggers on Import Data button click.
    function importData() {
        var viewer = document.getElementById('pdfviewer').ej2_instances[0];

        // Import the form field data from the FDF object into the current PDF document.
        viewer.importFormFields(exportedData, FormFieldDataFormat.Fdf);

        //// Import the form field data from the XFDF object into the current PDF document.
        //viewer.importFormFields (exportedData, FormFieldDataFormat.Xfdf);

        //// Import the form field data from the FDF object into the current PDF document.
        //viewer.importFormFields (exportedData, FormFieldDataFormat.Json);
    }
</script>
```
{% endhighlight %}
{% endtabs %}

## Form Field Properties 

Form field properties in Syncfusion<sup style="font-size:70%">&reg;</sup> PDF Viewer allow you to customize and interact with form fields embedded within PDF documents. This documentation provides an overview of the form field properties supported by the Syncfusion<sup style="font-size:70%">&reg;</sup> PDF Viewer and explains how to use them effectively.

  * Textbox
  * Password
  * CheckBox
  * RadioButton
  * ListBox
  * DropDown
  * SignatureField
  * InitialField

### Signature and initial fields settings

Using the `updateFormField` method, the form fields can be updated programmatically.

The following code example explains how to update the signature field properties on a button click.

{% tabs %}
{% highlight html tabtitle="Standalone" %}

<button id="updateProperties" onclick="updateProperties()">Update Properties</button>

<div style="width:100%;height:600px">
    @Html.EJS().PdfViewer("pdfviewer").DocumentPath("https://cdn.syncfusion.com/content/pdf/pdf-succinctly.pdf").Render()
</div>

<script>

    // Event triggers on Update Properties button click.
    function updateProperties() {
        var viewer = document.getElementById('pdfviewer').ej2_instances[0];
        var formField = viewer.retrieveFormFields();
        viewer.formDesignerModule.updateFormField(formField[0], {
            name: 'Initial',
            isReadOnly: false,
            visibility: 'visible',
            isRequired: false,
            isPrint: true,
            tooltip: 'Initial',
            thickness: 4
        });
    }
</script>

{% endhighlight %}
{% highlight html tabtitle="Server-Backed" %}

<button id="updateProperties" onclick="updateProperties()">Update Properties</button>

<div style="width:100%;height:600px">
    @Html.EJS().PdfViewer("pdfviewer").ServiceUrl(VirtualPathUtility.ToAbsolute("~/PdfViewer/")).DocumentPath("https://cdn.syncfusion.com/content/pdf/pdf-succinctly.pdf").Render()
</div>

<script>

    // Event triggers on Update Properties button click.
    function updateProperties() {
        var viewer = document.getElementById('pdfviewer').ej2_instances[0];
        var formField = viewer.retrieveFormFields();
        viewer.formDesignerModule.updateFormField(formField[0], {
            name: 'Initial',
            isReadOnly: false,
            visibility: 'visible',
            isRequired: false,
            isPrint: true,
            tooltip: 'Initial',
            thickness: 4
        });
    }
</script>

{% endhighlight %}
{% endtabs %}

The following code example explains how to update the properties of the signature field added to the document from the form designer toolbar.

<script type="text/javascript">

    window.onload = function () {
        var viewer = document.getElementById('pdfviewer').ej2_instances[0];
        viewer.signatureFieldSettings = {
            // Set the name of the form field element.
            name: 'Signature',
            // Specify whether the signature field is in read-only or read-write mode.
            isReadOnly: false,
            // Set the visibility of the form field.
            visibility: 'visible',
            // Specify whether the field is mandatory or not.
            isRequired: false,
            // Specify whether to print the signature field.
            isPrint: true,
            // Set the text to be displayed as a tooltip.
            tooltip: 'Signature',
            // Set the thickness of the signature field. To hide the borders, set the value to 0 (zero).
            thickness: 4,
            // Specify the properties of the signature indicator in the signature field.
            signatureIndicatorSettings: {
                opacity: 1,
                backgroundColor: '#daeaf7ff',
                height: 50,
                fontSize: 15,
                text: 'Signature Field',
                color: 'white'
            }
        }
    }

</script>

![Signature Field Settings](../../pdfviewer/images/signature_field.png)

The following code example explains how to update the properties of the initial field added to the document from the form designer toolbar.

<script type="text/javascript">

window.onload = function () {
    var viewer = document.getElementById('pdfviewer').ej2_instances[0];
    viewer.initialFieldSettings  = {
        // Set the name of the form field element.
        name: 'Initial',
        // Specify whether the initial field is in read-only or read-write mode.
        isReadOnly: false,
        // Set the visibility of the form field.
        visibility: 'visible',
        // Specify whether the field is mandatory or not.
        isRequired: false,
        // Specify whether to print the initial field.
        isPrint: true,
        // Set the text to be displayed as tooltip.
        tooltip: 'Initial',
        // Set the thickness of the initial field. To hide the borders, set the value to 0 (zero).
        thickness: 4,
        // Specify the properties of the initial indicator in the initial field.
        initialIndicatorSettings: {
        opacity: 1,
        backgroundColor: '#daeaf7ff',
        height: 50,
        fontSize: 15,
        text: 'Initial Field',
        color: 'white'
        },
    }
}

</script>

![Initial Field Settings](../../pdfviewer/images/InitialField.png)

### Textbox field settings

Using the `updateFormField` method, the form fields can be updated programmatically.

The following code example explains how to update the Textbox field properties on a button click.

{% tabs %}
{% highlight html tabtitle="Standalone" %}

<button id="updateProperties" onclick="updateProperties()">Update Properties</button>

<div style="width:100%;height:600px">
    @Html.EJS().PdfViewer("pdfviewer").DocumentPath("https://cdn.syncfusion.com/content/pdf/pdf-succinctly.pdf").Render()
</div>

<script>

    // Event triggers on Update Properties button click.
    function updateProperties() {
        var viewer = document.getElementById('pdfviewer').ej2_instances[0];
        var formField = viewer.retrieveFormFields();
        viewer.formDesignerModule.updateFormField(formField[0], {
            name: 'Textbox',
            isReadOnly: false,
            visibility: 'visible',
            isRequired: false,
            isPrint: true,
            tooltip: 'Textbox',
            thickness: 4,
            value:'Textbox',
            fontFamily: 'Courier',
            fontSize: 10,
            fontStyle: 'None',
            color: 'black',
            borderColor: 'black',
            backgroundColor: '#daeaf7ff',
            alignment: 'Left',
            maxLength: 0,
            isMultiline: false,
            bounds: { X: 146, Y: 229, Width: 150, Height: 24 }
        });
    }

</script>

{% endhighlight %}
{% highlight html tabtitle="Server-Backed" %}

<button id="updateProperties" onclick="updateProperties()">Update Properties</button>

<div style="width:100%;height:600px">
    @Html.EJS().PdfViewer("pdfviewer").ServiceUrl(VirtualPathUtility.ToAbsolute("~/PdfViewer/")).DocumentPath("https://cdn.syncfusion.com/content/pdf/pdf-succinctly.pdf").Render()
</div>

<script>

    // Event triggers on Update Properties button click.
    function updateProperties() {
        var viewer = document.getElementById('pdfviewer').ej2_instances[0];
        var formField = viewer.retrieveFormFields();
        viewer.formDesignerModule.updateFormField(formField[0], {
            name: 'Textbox',
            isReadOnly: false,
            visibility: 'visible',
            isRequired: false,
            isPrint: true,
            tooltip: 'Textbox',
            thickness: 4,
            value:'Textbox',
            fontFamily: 'Courier',
            fontSize: 10,
            fontStyle: 'None',
            color: 'black',
            borderColor: 'black',
            backgroundColor: '#daeaf7ff',
            alignment: 'Left',
            maxLength: 0,
            isMultiline: false,
            bounds: { X: 146, Y: 229, Width: 150, Height: 24 }
        });
    }

</script>

{% endhighlight %}
{% endtabs %}


The following code example explains how to update the properties of the textbox field added to the document from the form designer toolbar.

<script type="text/javascript">

window.onload = function () {
    var viewer = document.getElementById('pdfviewer').ej2_instances[0];
    viewer.textFieldSettings = {
        // Set the name of the form field element.
        name: 'Textbox',
        // Specify whether the Textbox field is in read-only or read-write mode.
        isReadOnly: false,
        // Set the visibility of the form field.
        visibility: 'visible',
        // Specify whether the field is mandatory or not.
        isRequired: false,
        // Specify whether to print the Textbox field.
        isPrint: true,
        // Set the text to be displayed as a tooltip.
        tooltip: 'Textbox',
        // Set the thickness of the Textbox field. To hide the borders, set the value to 0 (zero).
        thickness: 4,
        // Set the value of the form field element.
        value:'Textbox',
        // Set the font family of the textbox field.
        fontFamily: 'Courier',
        // Set the font size of the textbox field.
        fontSize: 10,
        // Specify the font style
        fontStyle: 'None',
        // Set the font color of the textbox field.
        color: 'black',
        // Set the border color of the textbox field.
        borderColor: 'black',
        // Set the background color of the textbox field.
        backgroundColor: '#daeaf7ff',
        // Set the alignment of the text.
        alignment: 'Left',
        // Set the maximum character length.
        maxLength: 0,
        // Allows multiline input in the text field. FALSE, by default.
        isMultiline: false
    }
}

</script>

![Textbox Field Settings](../../pdfviewer/images/Textbox.png)

### Password field settings

Using the `updateFormField` method, the form fields can be updated programmatically.

The following code example explains how to update the Password field properties on a button click.

{% tabs %}
{% highlight html tabtitle="Standalone" %}

<button id="updateProperties" onclick="updateProperties()">Update Properties</button>

<div style="width:100%;height:600px">
    @Html.EJS().PdfViewer("pdfviewer").DocumentPath("PDF_Succinctly.pdf").Render()
</div>

<script>

    // Event triggers on Update Properties button click.
    function updateProperties() {
        var viewer = document.getElementById('pdfviewer').ej2_instances[0];
        var formField = viewer.retrieveFormFields();
        viewer.formDesignerModule.updateFormField(formField[0], {
            name: 'Password',
            isReadOnly: false,
            visibility: 'visible',
            isRequired: false,
            isPrint: true,
            tooltip: 'Password',
            thickness: 4,
            value:'Password',
            fontFamily: 'Courier',
            fontSize: 10,
            fontStyle: 'None',
            color: 'black',
            borderColor: 'black',
            backgroundColor: '#daeaf7ff',
            alignment: 'Left',
            maxLength: 0,
            bounds: { X: 148, Y: 229, Width: 150, Height: 24 }
        });
    }

</script>

{% endhighlight %}
{% highlight html tabtitle="Server-Backed" %}

<button id="updateProperties" onclick="updateProperties()">Update Properties</button>

<div style="width:100%;height:600px">
    @Html.EJS().PdfViewer("pdfviewer").ServiceUrl(VirtualPathUtility.ToAbsolute("~/PdfViewer/")).DocumentPath("PDF_Succinctly.pdf").Render()
</div>

<script>

    // Event triggers on Update Properties button click.
    function updateProperties() {
        var viewer = document.getElementById('pdfviewer').ej2_instances[0];
        var formField = viewer.retrieveFormFields();
        viewer.formDesignerModule.updateFormField(formField[0], {
            name: 'Password',
            isReadOnly: false,
            visibility: 'visible',
            isRequired: false,
            isPrint: true,
            tooltip: 'Password',
            thickness: 4,
            value:'Password',
            fontFamily: 'Courier',
            fontSize: 10,
            fontStyle: 'None',
            color: 'black',
            borderColor: 'black',
            backgroundColor: '#daeaf7ff',
            alignment: 'Left',
            maxLength: 0,
            bounds: { X: 148, Y: 229, Width: 150, Height: 24 }
        });
    }

</script>

{% endhighlight %}
{% endtabs %}


The following code example explains how to update the properties of the password field added to the document from the form designer toolbar.

<script type="text/javascript">

window.onload = function () {
    var viewer = document.getElementById('pdfviewer').ej2_instances[0];
    viewer.passwordFieldSettings = {
        // Set the name of the form field element.
        name: 'Password',
        // Specify whether the Password field is in read-only or read-write mode.
        isReadOnly: false,
        // Set the visibility of the form field.
        visibility: 'visible',
        // Specify whether the field is mandatory or not.
        isRequired: false,
        // Specify whether to print the Password field.
        isPrint: true,
        // Set the text to be displayed as a tooltip.
        tooltip: 'Password',
        // Set the thickness of the Password field. To hide the borders, set the value to 0 (zero).
        thickness: 4,
        // Set the value of the form field element.
        value:'Password',
        // Set the font family of the Password field.
        fontFamily: 'Courier',
        // Set the font size of the Password field.
        fontSize: 10,
        // Specify the font style
        fontStyle: 'None',
        // Set the font color of the Password field.
        color: 'black',
        // Set the border color of the Password field.
        borderColor: 'black',
        // Set the background color of the Password field.
        backgroundColor: '#daeaf7ff',
        // Set the alignment of the text.
        alignment: 'Left',
        // Set the maximum character length.
        maxLength: 0,
    }
}

</script>

![Password Field Settings](../../pdfviewer/images/Password.png)

### CheckBox field settings

Using the `updateFormField` method, the form fields can be updated programmatically.

The following code example explains how to update the CheckBox field properties on a button click.

{% tabs %}
{% highlight html tabtitle="Standalone" %}

<button id="updateProperties" onclick="updateProperties()">Update Properties</button>

<div style="width:100%;height:600px">
    @Html.EJS().PdfViewer("pdfviewer").DocumentPath("https://cdn.syncfusion.com/content/pdf/pdf-succinctly.pdf").Render()
</div>

<script>

    // Event triggers on Update Properties button click.
    function updateProperties() {
        var viewer = document.getElementById('pdfviewer').ej2_instances[0];
        var formField = viewer.retrieveFormFields();
        viewer.formDesignerModule.updateFormField(formField[0], {
            name: 'CheckBox',
            isReadOnly: true,
            visibility: 'visible',
            isRequired: false,
            isPrint: true,
            tooltip: 'CheckBox',
            thickness: 4,
            isChecked: true,
            backgroundColor: '#daeaf7ff',
            borderColor: 'black',
            value: 'CheckBox'
        });
    }

</script>
{% endhighlight %}
{% highlight html tabtitle="Server-Backed" %}

<button id="updateProperties" onclick="updateProperties()">Update Properties</button>

<div style="width:100%;height:600px">
    @Html.EJS().PdfViewer("pdfviewer").ServiceUrl(VirtualPathUtility.ToAbsolute("~/PdfViewer/")).DocumentPath("https://cdn.syncfusion.com/content/pdf/pdf-succinctly.pdf").Render()
</div>

<script>

    // Event triggers on Update Properties button click.
    function updateProperties() {
        var viewer = document.getElementById('pdfviewer').ej2_instances[0];
        var formField = viewer.retrieveFormFields();
        viewer.formDesignerModule.updateFormField(formField[0], {
            name: 'CheckBox',
            isReadOnly: true,
            visibility: 'visible',
            isRequired: false,
            isPrint: true,
            tooltip: 'CheckBox',
            thickness: 4,
            isChecked: true,
            backgroundColor: '#daeaf7ff',
            borderColor: 'black',
            value: 'CheckBox'
        });
    }

</script>
{% endhighlight %}
{% endtabs %}


The following code example explains how to update the properties of the checkbox field added to the document from the form designer toolbar.

<script type="text/javascript">

window.onload = function () {
    var viewer = document.getElementById('pdfviewer').ej2_instances[0];
    viewer.checkBoxFieldSettings = {
        // Set the name of the form field element.
        name: 'CheckBox',
        // Specify whether the CheckBox field is in read-only or read-write mode.
        isReadOnly: false,
        // Set the visibility of the form field.
        visibility: 'visible',
        // Specify whether the field is mandatory or not.
        isRequired: false,
        // Specify whether to print the CheckBox field.
        isPrint: true,
        // Set the text to be displayed as a tooltip.
        tooltip: 'CheckBox',
        // Set the thickness of the CheckBox field. To hide the borders, set the value to 0 (zero).
        thickness: 4,
        // Specifies whether the check box is in checked state or not.
        isChecked: true,
        // Set the background color of the check box in hexadecimal string format.
        backgroundColor: '#daeaf7ff',
        // Set the border color of the check box field.
        borderColor: 'black'
        // Set the value of the form field element.
        value: 'CheckBox'
    }
}

</script>

![CheckBox Field Settings](../../pdfviewer/images/Checkbox.png)

### RadioButton field settings

Using the `updateFormField` method, the form fields can be updated programmatically.

The following code example explains how to update the RadioButton field properties on a button click.

{% tabs %}
{% highlight html tabtitle="Standalone" %}

<button id="updateProperties" onclick="updateProperties()">Update Properties</button>

<div style="width:100%;height:600px">
    @Html.EJS().PdfViewer("pdfviewer").DocumentPath("https://cdn.syncfusion.com/content/pdf/pdf-succinctly.pdf").Render()
</div>

<script>

    // Event triggers on Update Properties button click.
    function updateProperties() {
        var viewer = document.getElementById('pdfviewer').ej2_instances[0];
        var formField = viewer.retrieveFormFields();
        viewer.formDesignerModule.updateFormField(formField[0], {
            name: 'RadioButton',
            isReadOnly: false,
            visibility: 'visible',
            isRequired: false,
            isPrint: true,
            tooltip: 'RadioButton',
            thickness: 4,
            isSelected: true,
            backgroundColor: '#daeaf7ff',
            borderColor: 'black',
            value: 'RadioButton'
        });
    }

</script>

{% endhighlight %}
{% highlight html tabtitle="Server-Backed" %}

<button id="updateProperties" onclick="updateProperties()">Update Properties</button>

<div style="width:100%;height:600px">
    @Html.EJS().PdfViewer("pdfviewer").ServiceUrl(VirtualPathUtility.ToAbsolute("~/PdfViewer/")).DocumentPath("https://cdn.syncfusion.com/content/pdf/pdf-succinctly.pdf").Render()
</div>

<script>

    // Event triggers on Update Properties button click.
    function updateProperties() {
        var viewer = document.getElementById('pdfviewer').ej2_instances[0];
        var formField = viewer.retrieveFormFields();
        viewer.formDesignerModule.updateFormField(formField[0], {
            name: 'RadioButton',
            isReadOnly: false,
            visibility: 'visible',
            isRequired: false,
            isPrint: true,
            tooltip: 'RadioButton',
            thickness: 4,
            isSelected: true,
            backgroundColor: '#daeaf7ff',
            borderColor: 'black',
            value: 'RadioButton'
        });
    }

</script>

{% endhighlight %}
{% endtabs %}


The following code example explains how to update the properties of the radiobutton field added to the document from the form designer toolbar.

<script type="text/javascript">

window.onload = function () {
    var viewer = document.getElementById('pdfviewer').ej2_instances[0];
    viewer.radioButtonFieldSettings = {
        // Set the name of the form field element.
        name: 'RadioButton',
        // Specify whether the RadioButton field is in read-only or read-write mode.
        isReadOnly: false,
        // Set the visibility of the form field.
        visibility: 'visible',
        // Specify whether the field is mandatory or not.
        isRequired: false,
        // Specify whether to print the RadioButton field.
        isPrint: true,
        // Set the text to be displayed as a tooltip.
        tooltip: 'RadioButton',
        // Set the thickness of the RadioButton field. To hide the borders, set the value to 0 (zero).
        thickness: 4,
        // Specifies whether the radio button is in checked state or not.
        isSelected: true,
        // Set the background color of the radio button in hexadecimal string format.
        backgroundColor: '#daeaf7ff',
        // Set the border color of the radio button field.
        borderColor: 'black'
        // Set the value of the form field element.
        value: 'RadioButton'
    }
}

</script>

![RadioButton Field Settings](../../pdfviewer/images/Radiobutton.png)

### ListBox field settings

Using the `updateFormField` method, the form fields can be updated programmatically.

The following code example explains how to update the ListBox field properties on a button click.

{% tabs %}
{% highlight html tabtitle="Standalone" %}

<button id="updateProperties" onclick="updateProperties()">Update Properties</button>

<div style="width:100%;height:600px">
    @Html.EJS().PdfViewer("pdfviewer").DocumentPath("https://cdn.syncfusion.com/content/pdf/pdf-succinctly.pdf").Render()
</div>

<script>

    // Event triggers on Update Properties button click.
    function updateProperties() {
        var viewer = document.getElementById('pdfviewer').ej2_instances[0];
        var formField = viewer.retrieveFormFields();
        var customOptions = [
            { itemName: 'item1', itemValue: 'item1' },
            { itemName: 'item2', itemValue: 'item2' },
            { itemName: 'item3', itemValue: 'item3' }
        ];
        var formField = viewer.retrieveFormFields();
        viewer.formDesignerModule.updateFormField(formField[0], {
            name: 'ListBox',
            isReadOnly: false,
            visibility: 'visible',
            isRequired: false,
            isPrint: true,
            tooltip: 'ListBox',
            thickness: 4,
            fontFamily: 'Courier',
            fontSize: 10,
            fontStyle: 'None',
            color: 'black',
            borderColor: 'black',
            backgroundColor: '#daeaf7ff',
            alignment: 'Left',
            options: customOptions
        });
    }

</script>

{% endhighlight %}
{% highlight html tabtitle="Server-Backed" %}

<button id="updateProperties" onclick="updateProperties()">Update Properties</button>

<div style="width:100%;height:600px">
    @Html.EJS().PdfViewer("pdfviewer").ServiceUrl(VirtualPathUtility.ToAbsolute("~/PdfViewer/")).DocumentPath("https://cdn.syncfusion.com/content/pdf/pdf-succinctly.pdf").Render()
</div>

<script>

    // Event triggers on Update Properties button click.
    function updateProperties() {
        var viewer = document.getElementById('pdfviewer').ej2_instances[0];
        var formField = viewer.retrieveFormFields();
        var customOptions = [
            { itemName: 'item1', itemValue: 'item1' },
            { itemName: 'item2', itemValue: 'item2' },
            { itemName: 'item3', itemValue: 'item3' }
        ];
        var formField = viewer.retrieveFormFields();
        viewer.formDesignerModule.updateFormField(formField[0], {
            name: 'ListBox',
            isReadOnly: false,
            visibility: 'visible',
            isRequired: false,
            isPrint: true,
            tooltip: 'ListBox',
            thickness: 4,
            fontFamily: 'Courier',
            fontSize: 10,
            fontStyle: 'None',
            color: 'black',
            borderColor: 'black',
            backgroundColor: '#daeaf7ff',
            alignment: 'Left',
            options: customOptions
        });
    }

</script>

{% endhighlight %}
{% endtabs %}


The following code example explains how to update the properties of the listbox field added to the document from the form designer toolbar.

<script type="text/javascript">

window.onload = function () {
    var viewer = document.getElementById('pdfviewer').ej2_instances[0];
    var customOptions = [
        { itemName: 'item1', itemValue: 'item1' },
        { itemName: 'item2', itemValue: 'item2' },
        { itemName: 'item3', itemValue: 'item3' }
      ];
    viewer.listBoxFieldSettings = {
        // Set the name of the form field element.
        name: 'ListBox',
        // Specify whether the ListBox field is in read-only or read-write mode.
        isReadOnly: false,
        // Set the visibility of the form field.
        visibility: 'visible',
        // Specify whether the field is mandatory or not.
        isRequired: false,
        // Specify whether to print the ListBox field.
        isPrint: true,
        // Set the text to be displayed as a tooltip.
        tooltip: 'ListBox',
        // Set the thickness of the ListBox field. To hide the borders, set the value to 0 (zero).
        thickness: 4,
        // Set the value of the form field element.
        value:'ListBox',
        // Set the font family of the ListBox field.
        fontFamily: 'Courier',
        // Set the font size of the ListBox field.
        fontSize: 10,
        // Specify the font style
        fontStyle: 'None',
        // Set the  font color of the ListBox field.
        color: 'black',
        // Set the border color of the ListBox field.
        borderColor: 'black',
        // Set the background color of the ListBox field.
        backgroundColor: '#daeaf7ff',
        // Set the alignment of the text.
        alignment: 'Left',
        // Set the listbox items.
        options: customOptions
    };
}

</script>

![ListBox Field Settings](../../pdfviewer/images/Listbox.png)

### DropDown field settings

Using the `updateFormField` method, the form fields can be updated programmatically.

The following code example explains how to update the DropDown field properties on a button click.

{% tabs %}
{% highlight html tabtitle="Standalone" %}

<button id="updateProperties" onclick="updateProperties()">Update Properties</button>

<div style="width:100%;height:600px">
    @Html.EJS().PdfViewer("pdfviewer").DocumentPath("https://cdn.syncfusion.com/content/pdf/pdf-succinctly.pdf").Render()
</div>

<script>

    // Event triggers on Update Properties button click.
    function updateProperties() {
        var viewer = document.getElementById('pdfviewer').ej2_instances[0];
        var formField = viewer.retrieveFormFields();
        var customOptions = [
            { itemName: 'item1', itemValue: 'item1' },
            { itemName: 'item2', itemValue: 'item2' },
            { itemName: 'item3', itemValue: 'item3' }
        ];
        var formField = viewer.retrieveFormFields();
        viewer.formDesignerModule.updateFormField(formField[0], {
           name: 'DropDown',
            isReadOnly: false,
            visibility: 'visible',
            isRequired: false,
            isPrint: true,
            tooltip: 'DropDown',
            thickness: 4,
            fontFamily: 'Courier',
            fontSize: 10,
            fontStyle: 'None',
            color: 'black',
            borderColor: 'black',
            backgroundColor: '#daeaf7ff',
            alignment: 'Left',
            options: customOptions,
        });
    }

</script>

{% endhighlight %}
{% highlight html tabtitle="Server-Backed" %}

<button id="updateProperties" onclick="updateProperties()">Update Properties</button>

<div style="width:100%;height:600px">
    @Html.EJS().PdfViewer("pdfviewer").ServiceUrl(VirtualPathUtility.ToAbsolute("~/PdfViewer/")).DocumentPath("https://cdn.syncfusion.com/content/pdf/pdf-succinctly.pdf").Render()
</div>

<script>

    // Event triggers on Update Properties button click.
    function updateProperties() {
        var viewer = document.getElementById('pdfviewer').ej2_instances[0];
        var formField = viewer.retrieveFormFields();
        var customOptions = [
            { itemName: 'item1', itemValue: 'item1' },
            { itemName: 'item2', itemValue: 'item2' },
            { itemName: 'item3', itemValue: 'item3' }
        ];
        var formField = viewer.retrieveFormFields();
        viewer.formDesignerModule.updateFormField(formField[0], {
           name: 'DropDown',
            isReadOnly: false,
            visibility: 'visible',
            isRequired: false,
            isPrint: true,
            tooltip: 'DropDown',
            thickness: 4,
            fontFamily: 'Courier',
            fontSize: 10,
            fontStyle: 'None',
            color: 'black',
            borderColor: 'black',
            backgroundColor: '#daeaf7ff',
            alignment: 'Left',
            options: customOptions,
        });
    }

</script>

{% endhighlight %}
{% endtabs %}


The following code example explains how to update the properties of the dropdown field added to the document from the form designer toolbar.

<script type="text/javascript">

window.onload = function () {
    var viewer = document.getElementById('pdfviewer').ej2_instances[0];
    var customOptions = [
        { itemName: 'item1', itemValue: 'item1' },
        { itemName: 'item2', itemValue: 'item2' },
        { itemName: 'item3', itemValue: 'item3' }
      ];
       viewer.DropdownFieldSettings = {
      // Set the name of the form field element.
      name: 'DropDown',
      // Specify whether the DropDown field is in read-only or read-write mode.
      isReadOnly: false,
      // Set the visibility of the form field.
      visibility: 'visible',
      // Specify whether the field is mandatory or not.
      isRequired: false,
      // Specify whether to print the DropDown field.
      isPrint: true,
      // Set the text to be displayed as a tooltip.
      tooltip: 'DropDown',
      // Set the thickness of the DropDown field. To hide the borders, set the value to 0 (zero).
      thickness: 4,
      // Set the value of the form field element.
      value:'DropDown',
      // Set the font family of the DropDown field.
      fontFamily: 'Courier',
      // Set the font size of the DropDown field.
      fontSize: 10,
      // Specify the font style
      fontStyle: 'None',
      // Set the  font color of the DropDown field.
      color: 'black',
      // Set the border color of the DropDown field.
      borderColor: 'black',
      // Set the background color of the DropDown field.
      backgroundColor: '#daeaf7ff',
      // Set the alignment of the text.
      alignment: 'Left',
      // Set the DropDown items.
      options: customOptions
    } 
};

</script>

![DropDownBox Field Settings](../../pdfviewer/images/Dropdown.png)