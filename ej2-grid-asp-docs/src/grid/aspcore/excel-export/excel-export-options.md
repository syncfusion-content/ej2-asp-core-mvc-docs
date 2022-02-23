# Excel Export Options

The excel export provides an option to customize mapping of the grid to excel document.

## Export current page

The excel export provides an option to export the current page into excel. To export current page, define **exportType** to **currentpage**.

{% aspTab template="grid/excel-export/export-current", sourceFiles="export-current.cs" %}

{% endaspTab %}

## Export the selected records only

You can export the selected records data by passing it to **exportProperties.dataSource** Property in the [`toolbarClick`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ToolbarClick) event.

In the below exporting demo, We can get the selected records using **getSelectedRecords** method and pass the selected data to **PdfExport** or **excelExport** property.

{% aspTab template="grid/how-to/export-selected-data", sourceFiles="selected-data.cs" %}

{% endaspTab %}

## Export hidden columns

The excel export provides an option to export hidden columns of grid by defining **includeHiddenColumn** as **true**.

{% aspTab template="grid/excel-export/export-hidden", sourceFiles="export-hidden.cs" %}

{% endaspTab %}

## Show or hide columns

You can show a hidden column or hide a visible column while printing the grid using [`toolbarClick`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ToolbarClick) and [`excelExportComplete`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ExcelExportComplete) events.

In the [`toolbarClick`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ToolbarClick) event, based on **args.item.id** as **Grid_excelexport**. We can show or hide columns by setting [`visible`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_Visible) property of **e-grid-column** tag helper to **true** or **false** respectively.

In the [`excelExportComplete`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ExcelExportComplete) event, We have reversed the state back to the previous state.

In the below example, we have **CustomerID** as a hidden column in the grid. While exporting, we have changed **CustomerID** to visible column and **ShipCity** as hidden column.

{% aspTab template="grid/excel-export/show-hide", sourceFiles="show-hide.cs" %}

{% endaspTab %}

## Export with filter options

The excel export provides an option to export with filter option in excel by defining `enableFilter` as **true** .
It requires the [`allowFiltering`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_AllowFiltering) to be true.

{% aspTab template="grid/excel-export/enable-filter", sourceFiles="enable-filter.cs" %}

## Exporting grouped records

The excel export provides outline option for grouped records which hides the detailed data for better viewing.
In grid, we have provided the outline option for the exported document when the data's are grouped.

{% aspTab template="grid/excel-export/excel-group", sourceFiles="excel-group.cs" %}

{% endaspTab %}

## Define file name

You can assign the file name for the exported document by defining **fileName** property in **ExcelExportProperties**.

{% aspTab template="grid/excel-export/export-filename", sourceFiles="export-filename.cs" %}

{% endaspTab %}
