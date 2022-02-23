---
title: "Exporting Filtered Data Only"
component: "Grid"
description: "Learn how to export Filtered Data Only."
---

# Exporting Filtered Data Only

You can export the filtered data by defining the resulted data in `exportProperties.dataSource` before export.

In the below Pdf exporting demo, We have gotten the filtered data by applying filter query to the grid data and then defines the resulted data in `exportProperties.dataSource` and pass it to `pdfExport` method.

{% aspTab template="grid/how-to/export-filtered-data", sourceFiles="export-filtered-data.cs" %}

{% endaspTab %}
