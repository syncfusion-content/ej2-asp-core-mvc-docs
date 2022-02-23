---
title: " RangeNavigator Export and Print | ASP.NET MVC "

component: "RangeNavigator"

description: "The rendered rangenavigator can be printed or exported directly from the browser by calling the public method print and export."
---

# Export and print

## Export

The rendered Range Selector can be exported to **JPEG**, **PNG**, **SVG**, or **PDF** format by using the `export` method in the Range Selector. This method contains the following parameters:

* **Type** - To specify the export type. The component can be exported to **JPEG**, **PNG**, **SVG**, or **PDF** format.
* **File name** - To specify the file name to export.
* **Orientation** - To specify the orientation type. This is applicable only for PDF export type.

{% aspTab template="range-navigator/print/export", sourceFiles="export.cs" %}

{% endaspTab %}

## Print

The rendered Range Selector can be printed directly from the browser by calling the public method `print`.

{% aspTab template="range-navigator/print/print", sourceFiles="print.cs" %}

{% endaspTab %}