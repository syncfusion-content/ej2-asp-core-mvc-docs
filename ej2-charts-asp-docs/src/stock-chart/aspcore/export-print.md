---
title: "Stock Chart Print and Export | ASP.NET MVC "

component: "Stock Chart"

description: "The rendered stock chart can be printed or exported directly using print and export button in period selector."
---

# Print and Export

The rendered stock chart can be exported to `JPEG`, `PNG`, `SVG`, or `PDF` format using the export dropdown button in the period selector toolbar. You can choose the required format using the export dropdown button in stock-chart.

The rendered stock chart can be printed directly using print button in period selector toolbar.

{% aspTab template="stock-chart/getting-started/print", sourceFiles="print.cs" %}

{% endaspTab %}

## Disable Export and print

To empty the value of `exportType` for to disable the Export button.

{% aspTab template="stock-chart/getting-started/disable", sourceFiles="disable.cs" %}

{% endaspTab %}