---
title: "Migration"
component: "TreeGrid"
description: Documentation on exporting TreeGrid content to Excel document and customizing the exported document with headers and footers, and file name changes."
---

# Excel Export

The excel export allows exporting TreeGrid data to Excel document. You need to use the
 [`excelExport`](https://ej2.syncfusion.com/documentation/api/grid/#excelexport) method for exporting. To enable Excel export in the treegrid, set the [`AllowExcelExport`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~AllowExcelExport.html) as true.

{% aspTab template="tree-grid/excel-export/export", sourceFiles="export.cs" %}

{% endaspTab %}

## To customize excel export

The excel export provides an option to customize mapping of the treegrid to excel document.

### Export hidden columns

The excel export provides an option to export hidden columns of treegrid by defining [`includeHiddenColumn`](https://ej2.syncfusion.com/documentation/api/grid/excelExportProperties/#includehiddencolumn) in [`ExcelExportProperties`](https://ej2.syncfusion.com/documentation/api/grid/excelExportProperties/#excelexportproperties) as **true**.

{% aspTab template="tree-grid/excel-export/hidden-column", sourceFiles="hidden-column.cs" %}

{% endaspTab %}

### Show or Hide columns on Exported Excel

You can show a hidden column or hide a visible column while printing the treegrid using [`ToolbarClick`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~ToolbarClick.html) and [`ExcelExportComplete`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~ExcelExportComplete.html) events.

In the [`ToolbarClick`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~ToolbarClick.html) event, based on **args.item.text** as **Excel Export**. We can show or hide columns by setting [`Visible`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~Visible.html) property to **true** or **false** respectively.

In [`ExcelExportComplete`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~ExcelExportComplete.html) event, We have reversed the state back to the previous state.

In the below example, we have **Duration** as a hidden column in the treegrid. While exporting, we have changed **Duration** to visible column and **StartDate** as hidden column.

{% aspTab template="tree-grid/excel-export/show-hide", sourceFiles="show-hide.cs" %}

{% endaspTab %}

### Conditional Cell Formatting

TreeGrid cells in the exported Excel can be customized or formatted using [`ExcelQueryCellInfo`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~ExcelQueryCellInfo.html) event. In this event, we can format the treegrid cells of exported PDF document based on the column cell value.

In the below sample, we have set the background color for **Duration** column in the exported excel by **args.cell** and **backgroundColor** property.

{% aspTab template="tree-grid/excel-export/conditional-cell", sourceFiles="conditional-cell.cs" %}

{% endaspTab %}

### Theme

The excel export provides an option to include theme for exported excel document.

To apply theme in exported Excel, define the [`theme`](https://ej2.syncfusion.com/documentation/api/grid/excelExportProperties/#theme) in [`ExcelExportProperties`](https://ej2.syncfusion.com/documentation/api/grid/excelExportProperties/#excelexportproperties).

{% aspTab template="tree-grid/excel-export/theme", sourceFiles="theme.cs" %}

{% endaspTab %}

>By default, material theme is applied to exported excel document.

### To add header and footer

The excel export provides an option to include header and footer content for exported excel document.

{% aspTab template="tree-grid/excel-export/header-footer", sourceFiles="header-footer.cs" %}

{% endaspTab %}

### File Name for Exported document

You can assign the file name for the exported document by defining [`fileName`](https://ej2.syncfusion.com/documentation/api/grid/excelExportProperties/#filename) property in [`ExcelExportProperties`](https://ej2.syncfusion.com/documentation/api/grid/excelExportProperties/#excelexportproperties).

{% aspTab template="tree-grid/excel-export/file-name", sourceFiles="file-name.cs" %}

{% endaspTab %}

### To persist collapsed state

You can persist the collapsed state in the exported document by defining `isCollapsedStatePersist` property as true in `TreeGridExcelExportProperties` parameter of [`excelExport`](https://ej2.syncfusion.com/documentation/api/grid/#excelexport) method.

{% aspTab template="tree-grid/excel-export/is-collapsed", sourceFiles="is-collapsed.cs" %}

{% endaspTab %}

> You can refer to our [`ASP.NET MVC Tree Grid`](https://www.syncfusion.com/aspnet-mvc-ui-controls/tree-grid) feature tour page for its groundbreaking feature representations. You can also explore our [`ASP.NET MVC Tree Grid example`](https://ej2.syncfusion.com/aspnetmvc/TreeGrid/Overview#/material) to knows how to present and manipulate data.