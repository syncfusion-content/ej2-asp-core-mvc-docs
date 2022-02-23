# Export Multiple Grids

The excel export provides an option to export multiple grid data in the same excel file.

## Same sheet

The excel export provides support to export multiple grids in same sheet. To export in same sheet, define [`multipleExport`](https://ej2.syncfusion.com/documentation/api/grid/excelExportProperties/#multipleexport) type as **AppendToSheet** in [`exportProperties`](https://ej2.syncfusion.com/documentation/api/grid/excelExportProperties/#excelexportproperties). It have an option to provide blank rows between grids. These blank rows count can be defined by using the [`multipleExport`](https://ej2.syncfusion.com/documentation/api/grid/excelExportProperties/#multipleexport) as blankRows.

{% aspTab template="grid/excel-export/same-sheet", sourceFiles="same-sheet.cs" %}

{% endaspTab %}

> By default, [`multipleExport`](https://ej2.syncfusion.com/documentation/api/grid/excelExportProperties/#multipleexport) blankRows value is 5.

## New sheet

Excel exporting provides support to export multiple grids in new sheet. To export in new sheet, define  [`multipleExport`](https://ej2.syncfusion.com/documentation/api/grid/excelExportProperties/#multipleexport) type as **NewSheet** in [`exportProperties`](https://ej2.syncfusion.com/documentation/api/grid/excelExportProperties/#excelexportproperties).

{% aspTab template="grid/excel-export/new-sheet", sourceFiles="new-sheet.cs" %}

{% endaspTab %}