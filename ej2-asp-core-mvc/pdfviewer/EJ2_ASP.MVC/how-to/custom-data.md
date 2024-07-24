---
layout: post
title: Custom Data for Form Fields in EJ2 ASP.NET MVC PDF Viewer | Syncfusion
description: Discover how customData stores and links custom metadata to form fields in ASP.NET MVC PDF Viewer component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Custom data for form fields
publishingplatform: ej2-asp-core-mvc
documentation: ug
---

# Add and Update Custom Data for Form Fields

The customData property allows you to associate custom data with form fields in the Syncfusion EJ2 PDF Viewer. This property can be used to attach additional metadata or information to form fields which can be retrieved or manipulated as needed.

### Add form field

The addFormField method allows you to add a new form field to the PDF document in the Syncfusion EJ2 PDF Viewer and set the customData value with respective form fields.

```ts
viewer.textFieldSettings = {
   customData: { Author: "Syncfusion" }
}
viewer.passwordFieldSettigs = {
   customData: { Author: "Syncfusion" }
}
viewer.radioButtonFieldSettigs = {
   customData: { Author: "Syncfusion" }
}
viewer.radioButtonFieldSettigs = {
   customData: { Author: "Syncfusion" }
}
viewer.listBoxFieldSettigs = {
   customData: { Author: "Syncfusion" }
}
viewer.signatureFieldSettigs = {
   customData: { Author: "Syncfusion" }
}
viewer.initialFieldSettigs = {
   customData: { Author: "Syncfusion" }
}

```

### Update form field

The updateFormField method enables you to update the properties of an existing form field in the PDF document, including setting the customData value.

```ts
function UpdateCustomData(args) {
       var viewer = document.getElementById('pdfViewer').ej2_instances[0];
       var fields = viewer.formFieldCollections;
       for (var x = 0; x < viewer.formFieldCollections.length; x++) {
         viewer.formDesignerModule.updateFormField(
           viewer.formFieldCollections[x],
           {
             customData: { author: 'Syncfusion' },
           }
         );
       }
   }

```
