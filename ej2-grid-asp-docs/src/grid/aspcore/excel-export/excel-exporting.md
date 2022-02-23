---
title: "Excel Export"
component: "Grid"
description: "Documentation on exporting DataGrid content to Excel and customizing the exported document with multi-export, headers and footers, and file name changes."
---

# Excel Export

The excel export allows exporting Grid data to Excel document. You need to use the
 **ExcelExport** method for exporting. To enable Excel export in the grid, set the [`allowExcelExport`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_AllowExcelExport) property as true.

To use excel export, You need to define the **ExcelExport** in inbuild toolbar and define the [`toolbarClick`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ToolbarClick) event for exporting the Grid.

{% aspTab template="grid/excel-export/excel-export", sourceFiles="excel-export.cs" %}

{% endaspTab %}

## Show spinner while exporting

You can show/ hide spinner component while exporting the grid using `showSpinner`/ `hideSpinner` methods. You can use `toolbarClick` event to show spinner before exporting and hide a spinner in the `pdfExportComplete` or `excelExportComplete` event after the exporting.

In the `toolbarClick` event, based on the parameter `args.item.id` as `Grid_pdfexport` or `Grid_excelexport` we can call the `showSpinner` method from grid instance.

In the `pdfExportComplete` or `excelExportComplete` event, We can call the `hideSpinner` method.

In the below demo, we have rendered the default spinner component when exporting the grid.

{% aspTab template="grid/how-to/show-spinner-while-exporting", sourceFiles="show-spinner.cs" %}

{% endaspTab %}

## Custom data source

The excel export provides an option to define datasource dynamically before exporting. To export data dynamically, define the **dataSource** in **exportProperties**.

{% aspTab template="grid/excel-export/custom-data", sourceFiles="custom-data.cs" %}

{% endaspTab %}

## Passing additional parameters to the server when exporting

You can pass the additional parameter in the `query` property by invoking `addParams` method. In the `toolbarClick` event, you can define params as key and value pair so it will receive at the server side when exporting.

In the below example, we have passed `recordcount` as `12` using `addParams` method.

{% aspTab template="grid/how-to/passing-params-exporting", sourceFiles="addtional-parameter.cs" %}

{% endaspTab %}