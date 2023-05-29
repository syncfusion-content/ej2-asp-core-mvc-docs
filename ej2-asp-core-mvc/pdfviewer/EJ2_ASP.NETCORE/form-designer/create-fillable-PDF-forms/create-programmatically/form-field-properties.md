---
layout: post
title: Form Field Properties in EJ2 ASP.NET CORE PDF Viewer | Syncfusion
description: Learn here all about Form Field Properties in ASP.NET CORE PDF Viewer component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Form Field Properties
publishingplatform: ej2-asp-core-mvc
documentation: ug
---


# Form Field Properties 

Form field properties in Syncfusion PDF Viewer allow you to customize and interact with form fields embedded within PDF documents. This documentation provides an overview of the form field properties supported by the Syncfusion PDF Viewer and explains how to use them effectively.

  * Textbox
  * Password
  * CheckBox
  * RadioButton
  * ListBox
  * DropDown
  * SignatureField
  * InitialField

## Signature and initial fields settings

Using the `updateFormField` method, the form fields can be updated programmatically.

The following code example explains how to update the signature field properties on a button click.

```html

<button id="updateProperties" onclick="updateProperties()">Update Properties</button>

<div style="width:100%;height:600px">
    <ejs-pdfviewer id="pdfviewer"
                   style="height:600px"
                   serviceUrl="/api/PdfViewer"
                   documentPath=@ViewBag.DocumentPath>
    </ejs-pdfviewer>
</div>

<script>

    // Event triggers on Update Properties button click.
    function updateProperties() {
        var viewer = document.getElementById('pdfviewer').ej2_instances[0];
        var formField = viewer.retrieveFormFields();
        viewer.formDesignerModule.updateFormField(formField[0], {
            name: 'Signature',
            isReadOnly: true,
            visibility: 'visible',
            isRequired: false,
            isPrint: true,
            tooltip: 'Signature',
            thickness: 4
        });
    }
</script>

```

The following code example explains how to update the properties of the signature field added to the document from the form designer toolbar.

```html

<div style="width:100%;height:600px">
    <ejs-pdfviewer id="pdfviewer"
                   style="height:600px"
                   serviceUrl="/api/PdfViewer"
                   documentPath=@ViewBag.DocumentPath
                   documentLoad="onload"
                   >
    </ejs-pdfviewer>
</div>

<script>

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

```

![Signature Field Settings](../../../pdfviewer/images/signaturefield.png)

The following code example explains how to update the properties of the initial field added to the document from the form designer toolbar.

<script>

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

![Initial Field Settings](../../../pdfviewer/images/initialfield.png)

## Textbox field settings

Using the `updateFormField` method, the form fields can be updated programmatically.

The following code example explains how to update the Textbox field properties on a button click.

```html

<button id="updateProperties" onclick="updateProperties()">Update Properties</button>

<div style="width:100%;height:600px">
    <ejs-pdfviewer id="pdfviewer"
                   style="height:600px"
                   serviceUrl="/api/PdfViewer"
                   documentPath=@ViewBag.DocumentPath>
    </ejs-pdfviewer>
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

```

The following code example explains how to update the properties of the textbox field added to the document from the form designer toolbar.

```html

<div style="width:100%;height:600px">
    <ejs-pdfviewer id="pdfviewer"
                   style="height:600px"
                   serviceUrl="/api/PdfViewer"
                   documentPath=@ViewBag.DocumentPath
                   documentLoad="onload">
    </ejs-pdfviewer>
</div>

<script>

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

```

![Textbox Field Settings](../../../pdfviewer/images/textbox.png)

## Password field settings

Using the `updateFormField` method, the form fields can be updated programmatically.

The following code example explains how to update the Password field properties on a button click.

```html

<button id="updateProperties" onclick="updateProperties()">Update Properties</button>

<div style="width:100%;height:600px">
    <ejs-pdfviewer id="pdfviewer"
                   style="height:600px"
                   serviceUrl="/api/PdfViewer"
                   documentPath=@ViewBag.DocumentPath>
    </ejs-pdfviewer>
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
            backgroundColor:'#daeaf7ff',
            alignment: 'Left',
            maxLength: 0,
            bounds: { X: 148, Y: 229, Width: 150, Height: 24 }
        });
    }
</script>

```

The following code example explains how to update the properties of the password field added to the document from the form designer toolbar.

```html

<div style="width:100%;height:600px">
    <ejs-pdfviewer id="pdfviewer"
                   style="height:600px"
                   serviceUrl="/api/PdfViewer"
                   documentPath=@ViewBag.DocumentPath
                   documentLoad="onload">
    </ejs-pdfviewer>
</div>

<script>

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

```

![Password Field Settings](../../../pdfviewer/images/password.png)

## CheckBox field settings

Using the `updateFormField` method, the form fields can be updated programmatically.

The following code example explains how to update the CheckBox field properties on a button click.

```html

<button id="updateProperties" onclick="updateProperties()">Update Properties</button>

<div style="width:100%;height:600px">
    <ejs-pdfviewer id="pdfviewer"
                   style="height:600px"
                   serviceUrl="/api/PdfViewer"
                   documentPath=@ViewBag.DocumentPath>
    </ejs-pdfviewer>
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
        });
    }
</script>

```

The following code example explains how to update the properties of the password field added to the document from the form designer toolbar.

```html

<div style="width:100%;height:600px">
    <ejs-pdfviewer id="pdfviewer"
                   style="height:600px"
                   serviceUrl="/api/PdfViewer"
                   documentPath=@ViewBag.DocumentPath
                   documentLoad="onload">
    </ejs-pdfviewer>
</div>

<script>

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
        }
    }

</script>

```

![CheckBox Field Settings](../../../pdfviewer/images/checkbox.png)

## RadioButton field settings

Using the `updateFormField` method, the form fields can be updated programmatically.

The following code example explains how to update the RadioButton field properties on a button click.

```html

<button id="updateProperties" onclick="updateProperties()">Update Properties</button>

<div style="width:100%;height:600px">
    <ejs-pdfviewer id="pdfviewer"
                   style="height:600px"
                   serviceUrl="/api/PdfViewer"
                   documentPath=@ViewBag.DocumentPath>
    </ejs-pdfviewer>
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
        });
    }
</script>

```

The following code example explains how to update the properties of the password field added to the document from the form designer toolbar.

```html

<div style="width:100%;height:600px">
    <ejs-pdfviewer id="pdfviewer"
                   style="height:600px"
                   serviceUrl="/api/PdfViewer"
                   documentPath=@ViewBag.DocumentPath
                   documentLoad="onload">
    </ejs-pdfviewer>
</div>

<script>

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
        }
    }

</script>

```

![RadioButton Field Settings](../../../pdfviewer/images/radiobutton.png)

## ListBox field settings

Using the `updateFormField` method, the form fields can be updated programmatically.

The following code example explains how to update the ListBox field properties on a button click.

```html

<button id="updateProperties" onclick="updateProperties()">Update Properties</button>

<div style="width:100%;height:600px">
    <ejs-pdfviewer id="pdfviewer"
                   style="height:600px"
                   serviceUrl="/api/PdfViewer"
                   documentPath=@ViewBag.DocumentPath>
    </ejs-pdfviewer>
</div>

<script>
    // Event triggers on Update Properties button click.
    function updateProperties() {
        var viewer = document.getElementById('pdfviewer').ej2_instances[0];
        var formField = viewer.retrieveFormFields();
        const customOptions = [
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

```

The following code example explains how to update the properties of the dropdown field added to the document from the form designer toolbar.

```html

<div style="width:100%;height:600px">
    <ejs-pdfviewer id="pdfviewer"
                   style="height:600px"
                   serviceUrl="/api/PdfViewer"
                   documentPath=@ViewBag.DocumentPath
                   documentLoad="onload">
    </ejs-pdfviewer>
</div>

<script>

    window.onload = function () {
        var viewer = document.getElementById('pdfviewer').ej2_instances[0];
        const customOptions = [
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
        }
    };

</script>

```

![ListBox Field Settings](../../../pdfviewer/images/listbox.png)

## DropDown field settings

Using the `updateFormField` method, the form fields can be updated programmatically.

The following code example explains how to update the DropDown field properties on a button click.

```html

<button id="updateProperties" onclick="updateProperties()">Update Properties</button>

<div style="width:100%;height:600px">
    <ejs-pdfviewer id="pdfviewer"
                   style="height:600px"
                   serviceUrl="/api/PdfViewer"
                   documentPath=@ViewBag.DocumentPath>
    </ejs-pdfviewer>
</div>

<script>
    // Event triggers on Update Properties button click.
    function updateProperties() {
        var viewer = document.getElementById('pdfviewer').ej2_instances[0];
        var formField = viewer.retrieveFormFields();
        const customOptions = [
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

```

The following code example explains how to update the properties of the dropdown field added to the document from the form designer toolbar.

```html

<div style="width:100%;height:600px">
    <ejs-pdfviewer id="pdfviewer"
                   style="height:600px"
                   serviceUrl="/api/PdfViewer"
                   documentPath=@ViewBag.DocumentPath
                   documentLoad="onload">
    </ejs-pdfviewer>
</div>

<script>

    window.onload = function () {
        var viewer = document.getElementById('pdfviewer').ej2_instances[0];
        const customOptions = [
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

```

![DropDownBox Field Settings](../../../pdfviewer/images/dropdown.png)