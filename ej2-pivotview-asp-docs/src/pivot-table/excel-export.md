---
title: "Excel Exporting"
component: "Pivot Table"
description: "Export pivot table data to Excel document."
---

# Excel Export

The Excel export allows Pivot Table data to be exported as Excel document. To enable Excel export in the pivot table, set the [`AllowExcelExport`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_AllowExcelExport) property in [`PivotView`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotView.html) class to **true**. Once the API is set, user needs to call the `excelExport` method for exporting on external button click.

> The pivot table component can be exported to Excel format using options available in the toolbar. For more details [`refer`](./tool-bar) here.

{% aspTab template="pivot-table/excel-export/export", sourceFiles="Export.cs" %}

{% endaspTab %}

## Multiple pivot table exporting

The Excel export provides an option to export multiple pivot table data in the same Excel file.

### Same WorkSheet

The Excel export provides support to export multiple pivot tables in same sheet. To export in same sheet, define `multipleExport.type` as `AppendToSheet` in `excelExportProperties`. It has an option to provide blank rows between pivot tables and these blank row(s) count can be defined using the`multipleExport.blankRows` property.

>By default, `multipleExport.blankRows` value is 5 between pivot table's within the same sheet.

{% aspTab template="pivot-table/excel-export/samesheet-export", sourceFiles="SameSheetExport.cs" %}

{% endaspTab %}

### New WorkSheet

Excel export provides support to export multiple pivot tables into new sheets. To export in new sheets, define  `multipleExport.type` as `NewSheet` in `excelExportProperties`.

{% aspTab template="pivot-table/excel-export/newsheet-export", sourceFiles="NewSheetExport.cs" %}

{% endaspTab %}

## Customization during excel export

The Excel export provides an option to customize mapping of the pivot table to excel document.

### Theme

The Excel export provides an option to include theme for exported Excel document.

To apply theme in exported Excel, define the `theme` in `excelExportProperties`.

>By default, material theme is applied to exported Excel document.

{% aspTab template="pivot-table/excel-export/theme-export", sourceFiles="ThemeExport.cs" %}

{% endaspTab %}

### To add header and footer

The Excel export provides an option to include header and footer content for the exported Excel document.

{% aspTab template="pivot-table/excel-export/header-footer", sourceFiles="HeaderFooter.cs" %}

{% endaspTab %}

## CSV Export

Also, the Excel export allows pivot table data to be exported in `CSV` file format. To export pivot table in `CSV` file format, you need to use the `csvExport` method.

{% aspTab template="pivot-table/excel-export/csv-export", sourceFiles="CSVExport.cs" %}

{% endaspTab %}

## Virtual Scroll Data

You can export the pivot table virtual scroll data as Excel/CSV document by using PivotEngine export without any performance degradation. To enable PivotEngine export in the pivot table, set the [`AllowExcelExport`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_AllowExcelExport) as true. You need to use the `exportToExcel` method for PivotEngine export.

> PivotEngine export will be performed while enabling virtual scrolling by default.

### Virtual Scroll Data Excel Export

{% aspTab template="pivot-table/excel-export/engine-export", sourceFiles="Export.cs" %}

{% endaspTab %}

### Virtual Scroll Data CSV Export

{% aspTab template="pivot-table/excel-export/engine-csv-export", sourceFiles="CSVExport.cs" %}

{% endaspTab %}

## See Also

* [PDF Exporting](./pdf-export)