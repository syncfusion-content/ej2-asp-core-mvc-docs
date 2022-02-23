---
title: "Excel Export"
component: "Gantt"
description: "Learn how to export Gantt data to Excel and CSV documents in the Essential JS 2 Gantt control."
---

# Excel Export

Gantt supports client-side exporting, which allows you to export its data to the Excel and CSV formats. Use the `excelExport` and `csvExport` methods for exporting. To enable Excel export in the Gantt, set the [`AllowExcelExport`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Gantt.Gantt~AllowExcelExport.html) to true.

{% aspTab template="gantt/excel-export/excelExport", sourceFiles="excelExport.cs" %}

{% endaspTab %}

## Multiple Gantt exporting

In Gantt, the Excel export provides support to export multiple Gantt data in new sheet or same sheet.

### Same sheet

The Excel export provides support to export multiple Gantt data in the same sheet. To export in same sheet, define `multipleExport.type` as `AppendToSheet` in `ExcelExportProperties`. You can also provide blank rows between exported multiple Gantt data. These blank rows count can be defined using `multipleExport.blankRows`.

{% aspTab template="gantt/excel-export/sameSheet", sourceFiles="sameSheet.cs" %}

{% endaspTab %}

>By default, `multipleExport.blankRows` value is 5.

### New sheet

The Excel exporting provides support to export multiple Gantt in new sheet. To export in new sheet, define `multipleExport.type` as `NewSheet` in `ExcelExportProperties`.

{% aspTab template="gantt/excel-export/newSheet", sourceFiles="newSheet.cs" %}

{% endaspTab %}

## Customize the Excel export

Gantt Excel export allows the users to customize the exported document based on requirement.

### Export hidden columns

In Gantt, the Excel export provides an option to export hidden columns by defining `includeHiddenColumn` as `true`.

{% aspTab template="gantt/excel-export/exportHiddenColumns", sourceFiles="exportHiddenColumns.cs" %}

{% endaspTab %}

### Show or hide columns on exported Excel

In Gantt, while exporting, you can show a hidden column or hide a visible column using the [`ToolbarClick`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Gantt.Gantt~ToolbarClick.html) and [`ExcelExportComplete`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Gantt.Gantt~ExcelExportComplete.html) events.

In the `ToolbarClick` event, using the `args.item.id` property, you can show or hide columns by setting the `Columns.Visible` property to `true` or `false` respectively.

Similarly, in the excelExportComplete event, you can revert the columns visibility back to the previous state.

{% aspTab template="gantt/excel-export/showHideColumn", sourceFiles="showHideColumn.cs" %}

{% endaspTab %}

### Cell formatting during export

In Gantt, you can customize the TreeGrid cells in the exported document using the [`ExcelQueryCellInfo`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Gantt.Gantt~ExcelQueryCellInfo.html) event. In this event, you can format the TreeGrid cells of exported Excel and CSV documents based on the required condition.

In the following sample, the background color has been customized for `TaskId` column in the exported Excel using the `args.style` and `backColor` properties.

{% aspTab template="gantt/excel-export/cellFormat", sourceFiles="cellFormat.cs" %}

{% endaspTab %}

### Theme

The Excel export also provides an option to include custom theme for exported Excel document.

To apply theme in exported Excel, define the `theme` in `ExcelExportProperties`.

{% aspTab template="gantt/excel-export/theme", sourceFiles="theme.cs" %}

{% endaspTab %}

> By default, material theme is applied to the exported Excel document.

### Add header and footer

The Excel export also allows users to include header and footer contents to the exported Excel document.

{% aspTab template="gantt/excel-export/headerFooter", sourceFiles="headerFooter.cs" %}

{% endaspTab %}

### File name for exported document

You can set the required file name for the exported document by defining the `fileName` property in `ExcelExportProperties`.

{% aspTab template="gantt/excel-export/fileName", sourceFiles="fileName.cs" %}

{% endaspTab %}

## Custom data source

The excel export provides an option to define datasource dynamically before exporting. To export data dynamically, define the `dataSource` in `exportProperties`.

{% aspTab template="gantt/excel-export/customDataSource", sourceFiles="customDataSource.cs" %}

{% endaspTab %}