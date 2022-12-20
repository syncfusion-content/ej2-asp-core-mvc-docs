---
layout: post
title: Create Programmatically in EJ2 ASP.NET CORE PDF Viewer | Syncfusion
description: Learn here all about Create Programmatically in ASP.NET CORE PDF Viewer component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Create Programmatically
publishingplatform: ej2-asp-core-mvc
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

```html
<div style="width:100%;height:600px">
    <ejs-pdfviewer id="pdfviewer"
                   style="height:600px"
                   serviceUrl="/api/PdfViewer"
                   documentPath=@ViewBag.DocumentPath
                   documentLoad="documentLoaded">
    </ejs-pdfviewer>
</div>
<script>
    function documentLoaded() {
        var pdfviewer = document.getElementById('pdfviewer').ej2_instances[0];
        pdfviewer.formDesignerModule.addFormField("Textbox",
            {
                name: "Textbox",
                bounds: { X: 146, Y: 229, Width: 150, Height: 24 }
            });
    }
</script>

```

## Edit/Update form field programmatically

Using updateFormField method, Form Field can be updated programmatically. We should get the Form Field object/Id from FormFieldCollections property that you would like to edit and pass it as a parameter to updateFormField method. The second parameter should be the properties that you would like to update for Form Field programmatically. We have updated the value and background Color properties of Textbox Form Field.

```html
<div style="width:100%;height:600px">
    <ejs-pdfviewer id="pdfviewer"
                   style="height:600px"
                   serviceUrl="/api/PdfViewer"
                   documentPath=@ViewBag.DocumentPath
                   documentLoad="documentLoaded">
    </ejs-pdfviewer>
</div>
<script>
    function documentLoaded() {
        var pdfviewer = document.getElementById('pdfviewer').ej2_instances[0];
        pdfviewer.formDesignerModule.addFormField("Textbox",
            { name: "Textbox", bounds: { X: 146, Y: 229, Width: 150, Height: 24 } });
        pdfviewer.formDesignerModule.addFormField("Textbox",
            { name: "Textfield", bounds: { X: 300, Y: 229, Width: 150, Height: 24 } });
        pdfviewer.formDesignerModule.updateFormField(pdfviewer.formFieldCollections[0],
            { backgroundColor: 'red' });
    }
</script>

```

## Delete form field programmatically

Using deleteFormField method, the form field can be deleted programmatically. We should retrieve the Form Field object/Id from FormFieldCollections property that you would like to delete and pass it as a parameter to deleteFormField method. To delete a Form Field programmatically, use the following code.

```html
<div style="width:100%;height:600px">
    <ejs-pdfviewer id="pdfviewer"
                   style="height:600px"
                   serviceUrl="/api/PdfViewer"
                   documentPath=@ViewBag.DocumentPath
                   documentLoad="documentLoaded">
    </ejs-pdfviewer>
</div>
<script>
    function documentLoaded() {
        var pdfviewer = document.getElementById('pdfviewer').ej2_instances[0];
        pdfviewer.formDesignerModule.addFormField("Textbox",
            { name: "Textbox", bounds: { X: 146, Y: 229, Width: 150, Height: 24 } });
        pdfviewer.formDesignerModule.addFormField("Textbox",
            { name: "Textfield", bounds: { X: 300, Y: 229, Width: 150, Height: 24 } });
        pdfviewer.formDesignerModule.deleteFormField(pdfviewer.formFieldCollections[0] });
     }
</script>

```

## Saving the form fields

When the download icon is selected on the toolbar, the Form Fields will be saved in the PDF document and this action will not affect the original document. Refer the below GIF for further reference.

![Alt text](../../../pdfviewer/images/saveformfield.gif)

You can invoke download action using following code snippet.

```html
<div style="width:100%;height:600px">
    <ejs-pdfviewer id="pdfviewer"
                   style="height:600px"
                   serviceUrl="/api/PdfViewer"
                   documentPath=@ViewBag.DocumentPath
                   enableDownload="true">
    </ejs-pdfviewer>
</div>
<script>
    window.onload = function () {
        var pdfViewer = document.getElementById('pdfviewer').ej2_instances[0];
        pdfViewer.download();
    }
</script>

```

## Printing the form fields

When the print icon is selected on the toolbar, the PDF document will be printed along with the Form Fields added to the pages and this action will not affect the original document. Refer the below GIF for further reference.

![Alt text](../../../pdfviewer/images/printformfield.gif)

You can invoke print action using the following code snippet.,

```html
<div style="width:100%;height:600px">
    <ejs-pdfviewer id="pdfviewer"
                   style="height:600px"
                   serviceUrl="/api/PdfViewer"
                   documentPath=@ViewBag.DocumentPath
                   enablePrint="true">
    </ejs-pdfviewer>
</div>
<script>
    window.onload = function () {
        var pdfViewer = document.getElementById('pdfviewer').ej2_instances[0];
        pdfViewer.print.print();
    }
</script>

```

## Open the existing PDF document

We can open the already saved PDF document contains Form Fields in it by clicking the open icon in the toolbar. Refer the below GIF for further reference.

![Alt text](../../../pdfviewer/images/openexistingpdf.gif)

## Validate form fields

The form fields in the PDF Document will be validated when the `enableFormFieldsValidation` is set to true and hook the validateFormFields. The validateFormFields will be triggered when the PDF document is downloaded or printed with the non-filled form fields. The non-filled fields will be obtained in the `nonFillableFields` property of the event arguments of validateFormFields.

Add the following code snippet to validate the form fields,

```html
<div style="width:100%;height:600px">
    <ejs-pdfviewer id="pdfviewer"
                   style="height:600px"
                   serviceUrl="/api/PdfViewer"
                   documentPath=@ViewBag.DocumentPath
                   EnableFormFieldsValidation=true
                   ValidateFormFields="validateFormFields">
    </ejs-pdfviewer>
</div>
<script>
    function validateFormFields(args) {
        var nonfilledFormFields = args.nonFillableFields;
    }
</script>

```

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

```javascript

<button id="exportFdf">Export FDF</button>
<button id="importFdf"> Import FDF</button>
<!--Add the PDF Viewer-->
<div id="pdfViewer" style="height: 640px; width: 100%"></div>

// Event triggers on Export FDF button click.
document.getElementById('exportFdf').addEventListener('click', ()=> {
    // Data must be the desired path for the exported document.
    viewer.exportFormFields('Data', FormFieldDataFormat.Fdf);
});

// Event triggers on Import FDF button click.
document.getElementById('importFdf').addEventListener('click', ()=> {
    // The file for importing the form fields should be placed in the desired location, and the path should be provided correctly.
    viewer.importFormFields('File', FormFieldDataFormat.Fdf);
});

```

### Export and import as XFDF

The following code explains how to export the form field data as XFDF.

```javascript
<button id="exportXfdf">Export XFDF</button>
<button id="importXfdf"> Import XFDF</button>
<!--Add the PDF Viewer-->
<div id="pdfViewer" style="height: 640px; width: 100%"></div>

// Event triggers on Export XFDF button click.
document.getElementById('exportXfdf').addEventListener('click', ()=> {
    // Data must be the desired path for the exported document.
    viewer.exportFormFields('Data', FormFieldDataFormat.Xfdf);
});

// Event triggers on Import XFDF button click.
document.getElementById('importXfdf').addEventListener('click', ()=> {
    // The file for importing the form fields should be placed in the desired location, and the path should be provided correctly.
    viewer.importFormFields('File', FormFieldDataFormat.Xfdf);
});
```

### Export and import as JSON

The following code explains how to export the form field data as JSON.

```javascript

<button id="exportJson">Export JSON</button>
<button id="importJson"> Import JSON</button>
<!--Add the PDF Viewer-->
<div id="pdfViewer" style="height: 640px; width: 100%"></div>

// Event triggers on Export JSON button click.
document.getElementById('exportJson').addEventListener('click', ()=> {
    // Data must be the desired path for the exported document.
    viewer.exportFormFields('Data', FormFieldDataFormat.Json);
});

// Event triggers on Import JSON button click.
document.getElementById('importJson').addEventListener('click', ()=> {
    // The file for importing the form fields should be placed in the desired location, and the path should be provided correctly
    viewer.importFormFields('File', FormFieldDataFormat.Json);
});
```

### Export and import as Object

The PDF Viewer control supports exporting the form field data as an object, and the exported data will be imported into the current PDF document from the object.

The following code shows how to export the form field data as an object and import the form field data from that object into the current PDF document via a button click.

```javascript

<button id="exportDataAsObject">Export Object</button>
<button id="importData"> Import Data</button>
<!--Add the PDF Viewer-->
<div id="pdfViewer" style="height: 640px; width: 100%"></div>

var exportedData;

// Event triggers on Export Object button click.
document.getElementById('exportDataAsObject').addEventListener('click', ()=> {
    // Export the form field data to an FDF object.
    viewer.exportFormFieldsAsObject(FormFieldDataFormat.Fdf).then(value => {
        exportedData = value;
    });

    // // Export the form field data to an XFDF object.
    // viewer.exportFormFieldsAsObject(FormFieldDataFormat.Xfdf).then(value =>{
    //      exportedData = value;
    // })

    // // Export the form field data to an JSON object.
    // viewer.exportFormFieldsAsObject(FormFieldDataFormat.Json).then(value =>{
    //      exportedData = value;
    // })
});

// Event triggers on Import Data button click.
document.getElementById('importData').addEventListener('click', ()=> {
    // Import the form field data from the FDF object into the current PDF document.
    viewer.importFormFields(exportedData, FormFieldDataFormat.Fdf);

    //// Import the form field data from the XFDF object into the current PDF document.
    //viewer.importFormFields (exportedData, FormFieldDataFormat.Xfdf);

    //// Import the form field data from the FDF object into the current PDF document.
    //viewer.importFormFields (exportedData, FormFieldDataFormat.Json);
});
```

## Signature and initial fields settings

Using the `updateFormField` method, the form fields can be updated programmatically.

The following code example explains how to update the signature field properties on a button click.

```javascript

document.getElementById('updateProperties').addEventListener('click',function() {
    var formField = viewer.retrieveFormFields();
    viewer.formDesignerModule.updateFormField(formField[0], {
        name: 'Initial',
        isReadOnly: true,
        visibility: 'visible',
        isRequired: false,
        isPrint: true,
        tooltip: 'Initial',
        thickness: 4
    });
});

```