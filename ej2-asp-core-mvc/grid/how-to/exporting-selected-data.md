---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Exporting Selected Data of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Exporting Selected Data
publishingplatform: ##Platform_Name##
documentation: ug
---


# Exporting the Selected Records

You can export the selected records data by passing it to `exportProperties.dataSource` Property in the `toolbarClick` event.

In the below exporting demo, We can get the selected records using `getSelectedRecords` method and pass the selected data to `PdfExport` or `excelExport` property.

{% aspTab template="grid/how-to/export-selected-data", sourceFiles="selected-data.cs" %}

{% endaspTab %}