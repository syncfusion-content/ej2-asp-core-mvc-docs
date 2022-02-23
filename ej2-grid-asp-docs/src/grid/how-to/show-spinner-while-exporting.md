---
title: "Show Spinner when Exporting"
component: "Grid"
description: "Learn how to Show spinner when exporting the grid."
---

# Show Spinner on Grid when Exporting

You can show/ hide spinner component while exporting the grid using `showSpinner`/ `hideSpinner` methods. You can use `toolbarClick` event to show spinner before exporting and hide a spinner in the `pdfExportComplete` or `excelExportComplete` event after the exporting.

In the `toolbarClick` event, based on the parameter `args.item.id` as `Grid_pdfexport` or `Grid_excelexport` we can call the `showSpinner` method from grid instance.

In the `pdfExportComplete` or `excelExportComplete` event, We can call the `hideSpinner` method.

In the below demo, we have rendered the default spinner component when exporting the grid.

{% aspTab template="grid/how-to/show-spinner-while-exporting", sourceFiles="show-spinner.cs" %}

{% endaspTab %}