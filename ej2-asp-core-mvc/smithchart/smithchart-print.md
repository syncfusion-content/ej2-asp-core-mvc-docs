---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Smithchart Print of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Smithchart Print
publishingplatform: ##Platform_Name##
documentation: ug
---


# Print and Export

## Print

The rendered smithchart can be printed directly from the browser by calling the public method print. ID of the smithchart's div element must be passed as argument to that method.

{% aspTab template="smithchart/print/print", sourceFiles="print.cs" %}

{% endaspTab %}

## Export

The rendered smithchart can be exported to JPEG , PNG, SVG or PDF format by using export method in smithchart. Input parameters for this method are Export Type for format and fileName of result.

{% aspTab template="smithchart/print/export", sourceFiles="export.cs" %}

{% endaspTab %}