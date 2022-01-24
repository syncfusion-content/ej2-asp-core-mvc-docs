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
You can pass array of ID of elements or element to this method. By default it take element of the chart.

{% aspTab template="chart/getting-started/print", sourceFiles="print.cs" %}

{% endaspTab %}

## Export

The rendered chart can be exported to `JPEG`, `PNG`, `SVG`, or `PDF` format using the export method in chart. The input parameters for this method are `Export Type` for format and `fileName` for result.

The optional parameters for this method are,
* `orientation` - either portrait or landscape,
* `controls` - pass collections of controls for multiple export,
* `width` - width of chart export,
* `height` - height of chart export,
* `header` - header for the exported chart, and
* `footer` - footer for the exported chart.

{% aspTab template="chart/getting-started/export", sourceFiles="export.cs" %}

{% endaspTab %}
<!-- markdownlint-disable MD036 -->
**Export with optional parameters**
<!-- markdownlint-disable MD036 -->
The rendered chart can be exported to specific orientation, width and height by passing it as optional parameters in the export method of chart

{% aspTab template="chart/getting-started/export-optionalParameter", sourceFiles="export.cs" %}

{% endaspTab %}

## Multiple Chart Export

You can export the multiple charts in single page by passing the multiple chart objects in the export
method of chart.

To export multiple charts in a single page, follow the given steps:

**Step 1**:

Initially, render more than one chart to export, and then add button to export the multiple charts. In
button click, call the export private method in charts, and then pass the multiple chart objects in the
export method.

{% aspTab template="chart/getting-started/multi-export", sourceFiles="multi-export.cs" %}

{% endaspTab %}