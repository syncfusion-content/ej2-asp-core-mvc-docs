---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Chart Print of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Chart Print
publishingplatform: ##Platform_Name##
documentation: ug
---


# Print and Export

## Print

The rendered chart can be printed directly from the browser by calling the public method print.

{% aspTab template="chart/accumulation-charts/chart-print/print", sourceFiles="print.cs" %}

{% endaspTab %}

## Export

The rendered chart can be exported to `Image`(jpeg or png) or `SVG` or `PDF` format by using the export method.
Input parameters for this method are `Export` Type for `format` and `fileName` of result.

{% aspTab template="chart/accumulation-charts/chart-print/export", sourceFiles="export.cs" %}

{% endaspTab %}