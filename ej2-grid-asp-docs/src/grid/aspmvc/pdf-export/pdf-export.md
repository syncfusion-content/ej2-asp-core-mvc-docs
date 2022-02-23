---
title: "PDF Export"
component: "Grid"
description: "Documentation on exporting DataGrid content to PDF format and customizing the exported document with multi-export, headers and footers, and file name changes."
---

# PDF Export

PDF export allows exporting Grid data to PDF document. You need to use the
[`PdfExport`](https://ej2.syncfusion.com/documentation/api/grid/#pdfexport) method for exporting. To enable PDF export in the grid, set the [`AllowPdfExport`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_AllowPdfExport) as true.

{% aspTab template="grid/pdf-export/pdf-export", sourceFiles="pdf-export.cs" %}

{% endaspTab %}

## Show spinner while exporting

You can show/ hide spinner component while exporting the grid using **showSpinner**/ **hideSpinner** methods. You can use [`ToolbarClick`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ToolbarClick) event to show spinner before exporting and hide a spinner in the [`PdfExportComplete`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_PdfExportComplete) or [`ExcelExportComplete`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ExcelExportComplete) event after the exporting.

In the [`ToolbarClick`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ToolbarClick) event, based on the parameter **args.item.id** as **Grid_pdfexport** or **Grid_excelexport** we can call the **showSpinner** method from grid instance.

In the [`PdfExportComplete`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_PdfExportComplete) or [`ExcelExportComplete`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ExcelExportComplete) event, We can call the **hideSpinner** method.

In the below demo, we have rendered the default spinner component when exporting the grid.

{% aspTab template="grid/how-to/show-spinner-while-exporting", sourceFiles="show-spinner.cs" %}

{% endaspTab %}

## Custom data source

PDF export provides an option to define datasource dynamically before exporting. To export data dynamically, define the [`dataSource`](https://ej2.syncfusion.com/documentation/api/grid/pdfExportProperties/#datasource) in [`PdfExportProperties`](https://ej2.syncfusion.com/documentation/api/grid/pdfExportProperties/#pdfexportproperties).

{% aspTab template="grid/pdf-export/custom-data", sourceFiles="custom-data.cs" %}

{% endaspTab %}

## Passing additional parameters to the server when exporting

You can pass the additional parameter in the [`Query`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Query) property by invoking **addParams** method. In the [`ToolbarClick`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ToolbarClick) event, you can define params as key and value pair so it will receive at the server side when exporting.

In the below example, we have passed **recordcount** as **12** using **addParams** method.

{% aspTab template="grid/how-to/passing-params-exporting", sourceFiles="addtional-parameter.cs" %}

{% endaspTab %}

## Export large number of columns in a single page

By default, when the grid has large number of columns, then the PDF export will split more pages for the exceeded columns rendering. To achieve large number of columns exported in a single page, you need to set the **allowHorizontalOverFlow** property as **false** in the [`toolbarClick`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Grids.Grid~ToolbarClick.html) event.

{% aspTab template="grid/pdf-export/large-columns", sourceFiles="large-columns.cs" %}

{% endaspTab %}

## See Also

* [How can I change a layout to export to pdf in ASP.NET MVC Grid](https://www.syncfusion.com/forums/138196/how-can-i-change-a-layout-to-export-to-pdf-in-asp-net-mvc-grid)