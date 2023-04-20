---
layout: post
title: How to navigate to the next and previous signature fields ##Platform_Name## Pdfviewer Component
description: Learn how to navigate to the next and previous signature fields in Syncfusion ##Platform_Name## Pdfviewer component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: How to navigate to the next and previous signature fields
publishingplatform: ##Platform_Name##
documentation: ug
---

# How to navigate to the next and previous signature fields

Navigate to the next and previous signature fields programmatically in the Syncfusion PDF Viewer.

The `previousField()` method moves the focus to the previous signature field, and the `nextField()` method moves the focus to the next signature field.

To use these functions, you need to ensure that the Syncfusion PDF Viewer is properly initialized on the page, and that the formFieldsModule module is loaded.

Here's an example of how to use the `previousField()` and `nextField()` method:

```html

<button onclick="nextField()">nextField</button>
<button onclick="previousField()>previousField</button>

<script>
    function previousField() {
        var viewer = document.getElementById('pdfviewer').ej2_instances[0];
        viewer.formFieldsModule.previousField();
    }
    function nextField() {
        var viewer = document.getElementById('pdfviewer').ej2_instances[0];
        viewer.formFieldsModule.nextField();
    }
</script> 

```

The `previousField()` and `nextField()` methods are called on the formFieldsModule property of the viewer object when the corresponding buttons are clicked. When the functions are called, they use the `viewer.formFieldsModule` object to navigate between the form fields in the PDF document.

[View Sample in GitHub]()