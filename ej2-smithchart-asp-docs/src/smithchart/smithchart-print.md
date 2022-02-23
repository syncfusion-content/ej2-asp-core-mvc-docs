---
title: "Print and Export"
component: "Smith Chart"
description: "Print and export support in smith chart"
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