---
title: "Migration"
component: "TreeGrid"
description: Documentation on exporting TreeGrid content to Excel document and customizing the exported document with headers and footers, and file name changes."
---

# Excel Export

The excel export allows exporting TreeGrid data to Excel document. You need to use the
 `excelExport` method for exporting. To enable Excel export in the treegrid, set the [`AllowExcelExport`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~AllowExcelExport.html) as true.

To use excel export, You need to inject the `ExcelExport` module in treegrid.

{% aspTab template="tree-grid/excel-export/export", sourceFiles="export.cs" %}

{% endaspTab %}

## To customize excel export

The excel export provides an option to customize mapping of the treegrid to excel document.

### Export hidden columns

The excel export provides an option to export hidden columns of treegrid by defining `includeHiddenColumn` as `true`.

{% aspTab template="tree-grid/excel-export/hidden-column", sourceFiles="hidden-column.cs" %}

{% endaspTab %}

### Show or Hide columns on Exported Excel

You can show a hidden column or hide a visible column while printing the treegrid using [`ToolbarClick`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~ToolbarClick.html) and [`ExcelExportComplete`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~ExcelExportComplete.html) events.

In the `ToolbarClick` event, based on `args.item.text` as `Excel Export`. We can show or hide columns by setting `Column.Visible` property to `true` or `false` respectively.

In the excelExportComplete event, We have reversed the state back to the previous state.

In the below example, we have `Duration` as a hidden column in the treegrid. While exporting, we have changed `Duration` to visible column and `StartDate` as hidden column.

{% aspTab template="tree-grid/excel-export/show-hide", sourceFiles="show-hide.cs" %}

{% endaspTab %}

### Conditional Cell Formatting

TreeGrid cells in the exported Excel can be customized or formatted using [`ExcelQueryCellInfo`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~ExcelQueryCellInfo.html) event. In this event, we can format the treegrid cells of exported PDF document based on the column cell value.

In the below sample, we have set the background color for `Duration` column in the exported excel by `args.cell` and `backgroundColor` property.

{% aspTab template="tree-grid/excel-export/conditional-cell", sourceFiles="conditional-cell.cs" %}

{% endaspTab %}

### Theme

The excel export provides an option to include theme for exported excel document.

To apply theme in exported Excel, define the `theme` in `exportProperties` .

{% aspTab template="tree-grid/excel-export/theme", sourceFiles="theme.cs" %}

{% endaspTab %}

>By default, material theme is applied to exported excel document.

### To add header and footer

The excel export provides an option to include header and footer content for exported excel document.

{% aspTab template="tree-grid/excel-export/header-footer", sourceFiles="header-footer.cs" %}

{% endaspTab %}

### File Name for Exported document

You can assign the file name for the exported document by defining `fileName` property in `ExcelExportProperties`.

{% aspTab template="tree-grid/excel-export/file-name", sourceFiles="file-name.cs" %}

{% endaspTab %}

## Custom data source

The excel export provides an option to define datasource dynamically before exporting. To export data dynamically, define the `dataSource` in `exportProperties`.

{% aspTab template="tree-grid/excel-export/custom-data", sourceFiles="custom-data.cs" %}

{% endaspTab %}