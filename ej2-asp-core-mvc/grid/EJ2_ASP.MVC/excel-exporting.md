---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Excel Exporting of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Excel Exporting
publishingplatform: ##Platform_Name##
documentation: ug
---


# Excel Export

The excel export allows exporting Grid data to Excel document. You need to use the
 [`excelExport`](https://ej2.syncfusion.com/documentation/api/grid/#excelexport) method for exporting. To enable Excel export in the grid, set the [`AllowExcelExport`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_AllowExcelExport) property as true.

To use excel export, You need to define the **ExcelExport** in inbuild toolbar and define the [`ToolbarClick`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ToolbarClick) event for exporting the Grid.

{% if page.publishingplatform == "aspnet-core" %}
{% tabs %}
{% highlight c# tabtitle="excel-export" %}
{% include_relative code-snippet/excel-export/excel-export/excel-export.cs %}
{% endhighlight %}
{% highlight cshtml tabtitle="excel-export" %}
{% include_relative code-snippet/excel-export/excel-export/taghelper %}
{% endhighlight %}
{% elsif page.publishingplatform == "aspnet-mvc" %}
{% highlight c# tabtitle="excel-export" %}
{% include_relative code-snippet/excel-export/excel-export/excel-export.cs %}
{% endhighlight %}
{% highlight razor tabtitle="excel-export" %}
{% include_relative code-snippet/excel-export/excel-export/razor %}
{% endhighlight %}
{% endtabs %}



## Multiple Grid exporting

The excel export provides an option to export multiple grid data in the same excel file.

### Same sheet

The excel export provides support to export multiple grids in same sheet. To export in same sheet, define [`multipleExport`](https://ej2.syncfusion.com/documentation/api/grid/excelExportProperties/#multipleexport) type as **AppendToSheet** in [`exportProperties`](https://ej2.syncfusion.com/documentation/api/grid/excelExportProperties/#excelexportproperties). It have an option to provide blank rows between grids. These blank rows count can be defined by using the [`multipleExport`](https://ej2.syncfusion.com/documentation/api/grid/excelExportProperties/#multipleexport) as blankRows.

{% if page.publishingplatform == "aspnet-core" %}
{% tabs %}
{% highlight c# tabtitle="same-sheet" %}
{% include_relative code-snippet/excel-export/same-sheet/same-sheet.cs %}
{% endhighlight %}
{% highlight cshtml tabtitle="same-sheet" %}
{% include_relative code-snippet/excel-export/same-sheet/taghelper %}
{% endhighlight %}
{% elsif page.publishingplatform == "aspnet-mvc" %}
{% highlight c# tabtitle="same-sheet" %}
{% include_relative code-snippet/excel-export/same-sheet/same-sheet.cs %}
{% endhighlight %}
{% highlight razor tabtitle="same-sheet" %}
{% include_relative code-snippet/excel-export/same-sheet/razor %}
{% endhighlight %}
{% endtabs %}



> By default, [`multipleExport`](https://ej2.syncfusion.com/documentation/api/grid/excelExportProperties/#multipleexport) blankRows value is 5.

### New Sheet

Excel exporting provides support to export multiple grids in new sheet. To export in new sheet, define  [`multipleExport`](https://ej2.syncfusion.com/documentation/api/grid/excelExportProperties/#multipleexport) type as **NewSheet** in [`exportProperties`](https://ej2.syncfusion.com/documentation/api/grid/excelExportProperties/#excelexportproperties).

{% if page.publishingplatform == "aspnet-core" %}
{% tabs %}
{% highlight c# tabtitle="new-sheet" %}
{% include_relative code-snippet/excel-export/new-sheet/new-sheet.cs %}
{% endhighlight %}
{% highlight cshtml tabtitle="new-sheet" %}
{% include_relative code-snippet/excel-export/new-sheet/taghelper %}
{% endhighlight %}
{% elsif page.publishingplatform == "aspnet-mvc" %}
{% highlight c# tabtitle="new-sheet" %}
{% include_relative code-snippet/excel-export/new-sheet/new-sheet.cs %}
{% endhighlight %}
{% highlight razor tabtitle="new-sheet" %}
{% include_relative code-snippet/excel-export/new-sheet/razor %}
{% endhighlight %}
{% endtabs %}



## To customize excel export

The excel export provides an option to customize mapping of the grid to excel document.

### Export current page

The excel export provides an option to export the current page into excel. To export current page, define [`exportType`](https://ej2.syncfusion.com/documentation/api/grid/excelExportProperties/#exporttype) to **currentpage**.

{% if page.publishingplatform == "aspnet-core" %}
{% tabs %}
{% highlight c# tabtitle="export-current" %}
{% include_relative code-snippet/excel-export/export-current/export-current.cs %}
{% endhighlight %}
{% highlight cshtml tabtitle="export-current" %}
{% include_relative code-snippet/excel-export/export-current/taghelper %}
{% endhighlight %}
{% elsif page.publishingplatform == "aspnet-mvc" %}
{% highlight c# tabtitle="export-current" %}
{% include_relative code-snippet/excel-export/export-current/export-current.cs %}
{% endhighlight %}
{% highlight razor tabtitle="export-current" %}
{% include_relative code-snippet/excel-export/export-current/razor %}
{% endhighlight %}
{% endtabs %}



### Export hidden columns

The excel export provides an option to export hidden columns of grid by defining [`includeHiddenColumn`](https://ej2.syncfusion.com/documentation/api/grid/excelExportProperties/#includehiddencolumn) as **true**.

{% if page.publishingplatform == "aspnet-core" %}
{% tabs %}
{% highlight c# tabtitle="export-hidden" %}
{% include_relative code-snippet/excel-export/export-hidden/export-hidden.cs %}
{% endhighlight %}
{% highlight cshtml tabtitle="export-hidden" %}
{% include_relative code-snippet/excel-export/export-hidden/taghelper %}
{% endhighlight %}
{% elsif page.publishingplatform == "aspnet-mvc" %}
{% highlight c# tabtitle="export-hidden" %}
{% include_relative code-snippet/excel-export/export-hidden/export-hidden.cs %}
{% endhighlight %}
{% highlight razor tabtitle="export-hidden" %}
{% include_relative code-snippet/excel-export/export-hidden/razor %}
{% endhighlight %}
{% endtabs %}



### Show or Hide columns on Exported Excel

You can show a hidden column or hide a visible column while printing the grid using [`ToolbarClick`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ToolbarClick) and [`ExcelExportComplete`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ExcelExportComplete) events.

In the [`ToolbarClick`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ToolbarClick) event, based on **args.item.id** as **Grid_excelexport**. We can show or hide columns by setting [`Visible`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_Visible) property of [`Column`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html) to **true** or **false** respectively.

In the [`ExcelExportComplete`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ExcelExportComplete) event, We have reversed the state back to the previous state.

In the below example, we have **CustomerID** as a hidden column in the grid. While exporting, we have changed **CustomerID** to visible column and **ShipCity** as hidden column.

{% if page.publishingplatform == "aspnet-core" %}
{% tabs %}
{% highlight c# tabtitle="show-hide" %}
{% include_relative code-snippet/excel-export/show-hide/show-hide.cs %}
{% endhighlight %}
{% highlight cshtml tabtitle="show-hide" %}
{% include_relative code-snippet/excel-export/show-hide/taghelper %}
{% endhighlight %}
{% elsif page.publishingplatform == "aspnet-mvc" %}
{% highlight c# tabtitle="show-hide" %}
{% include_relative code-snippet/excel-export/show-hide/show-hide.cs %}
{% endhighlight %}
{% highlight razor tabtitle="show-hide" %}
{% include_relative code-snippet/excel-export/show-hide/razor %}
{% endhighlight %}
{% endtabs %}



### Export with filter options

The excel export provides an option to export with filter option in excel by defining `enableFilter` as **true** .
It requires the [`allowFiltering`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_AllowFiltering) to be true.

{% if page.publishingplatform == "aspnet-core" %}
{% tabs %}
{% highlight c# tabtitle="enable-filter" %}
{% include_relative code-snippet/excel-export/enable-filter/enable-filter.cs %}
{% endhighlight %}
{% highlight cshtml tabtitle="enable-filter" %}
{% include_relative code-snippet/excel-export/enable-filter/taghelper %}
{% endhighlight %}
{% elsif page.publishingplatform == "aspnet-mvc" %}
{% highlight c# tabtitle="enable-filter" %}
{% include_relative code-snippet/excel-export/enable-filter/enable-filter.cs %}
{% endhighlight %}
{% highlight razor tabtitle="enable-filter" %}
{% include_relative code-snippet/excel-export/enable-filter/razor %}
{% endhighlight %}
{% endtabs %}



### Conditional Cell Formatting

Grid cells in the exported Excel can be customized or formatted using [`ExcelQueryCellInfo`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ExcelQueryCellInfo) event. In this event, we can format the grid cells of exported PDF document based on the column cell value.

In the below sample, we have set the background color for **Freight** column in the exported excel by using the arguments of [`ExcelQueryCellInfo`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ExcelQueryCellInfo) event and **backColor** property.

{% if page.publishingplatform == "aspnet-core" %}
{% tabs %}
{% highlight c# tabtitle="cell-format" %}
{% include_relative code-snippet/excel-export/cell-format/cell-formats.cs %}
{% endhighlight %}
{% highlight cshtml tabtitle="cell-format" %}
{% include_relative code-snippet/excel-export/cell-format/taghelper %}
{% endhighlight %}
{% elsif page.publishingplatform == "aspnet-mvc" %}
{% highlight c# tabtitle="cell-format" %}
{% include_relative code-snippet/excel-export/cell-format/cell-formats.cs %}
{% endhighlight %}
{% highlight razor tabtitle="cell-format" %}
{% include_relative code-snippet/excel-export/cell-format/razor %}
{% endhighlight %}
{% endtabs %}



### Theme

The excel export provides an option to include theme for exported excel document.

To apply theme in exported Excel, define the [`theme`](https://ej2.syncfusion.com/documentation/api/grid/excelExportProperties/#theme) in [`ExcelExportProperties`](https://ej2.syncfusion.com/documentation/api/grid/excelExportProperties/#properties).

{% if page.publishingplatform == "aspnet-core" %}
{% tabs %}
{% highlight c# tabtitle="theme" %}
{% include_relative code-snippet/excel-export/theme/theme.cs %}
{% endhighlight %}
{% highlight cshtml tabtitle="theme" %}
{% include_relative code-snippet/excel-export/theme/taghelper %}
{% endhighlight %}
{% elsif page.publishingplatform == "aspnet-mvc" %}
{% highlight c# tabtitle="theme" %}
{% include_relative code-snippet/excel-export/theme/theme.cs %}
{% endhighlight %}
{% highlight razor tabtitle="theme" %}
{% include_relative code-snippet/excel-export/theme/razor %}
{% endhighlight %}
{% endtabs %}



> By default, material theme is applied to exported excel document.

### To add header and footer

The excel export provides an option to include header and footer content for exported excel document.

{% if page.publishingplatform == "aspnet-core" %}
{% tabs %}
{% highlight c# tabtitle="header-footer" %}
{% include_relative code-snippet/excel-export/header-footer/header-footer.cs %}
{% endhighlight %}
{% highlight cshtml tabtitle="header-footer" %}
{% include_relative code-snippet/excel-export/header-footer/taghelper %}
{% endhighlight %}
{% elsif page.publishingplatform == "aspnet-mvc" %}
{% highlight c# tabtitle="header-footer" %}
{% include_relative code-snippet/excel-export/header-footer/header-footer.cs %}
{% endhighlight %}
{% highlight razor tabtitle="header-footer" %}
{% include_relative code-snippet/excel-export/header-footer/razor %}
{% endhighlight %}
{% endtabs %}



### File Name for Exported document

You can assign the file name for the exported document by defining [`fileName`](https://ej2.syncfusion.com/documentation/api/grid/excelExportProperties/#filename) property in [`ExcelExportProperties`](https://ej2.syncfusion.com/documentation/api/grid/excelExportProperties/#excelexportproperties).

{% if page.publishingplatform == "aspnet-core" %}
{% tabs %}
{% highlight c# tabtitle="export-filename" %}
{% include_relative code-snippet/excel-export/export-filename/export-filename.cs %}
{% endhighlight %}
{% highlight cshtml tabtitle="export-filename" %}
{% include_relative code-snippet/excel-export/export-filename/taghelper %}
{% endhighlight %}
{% elsif page.publishingplatform == "aspnet-mvc" %}
{% highlight c# tabtitle="export-filename" %}
{% include_relative code-snippet/excel-export/export-filename/export-filename.cs %}
{% endhighlight %}
{% highlight razor tabtitle="export-filename" %}
{% include_relative code-snippet/excel-export/export-filename/razor %}
{% endhighlight %}
{% endtabs %}



## Custom data source

The excel export provides an option to define datasource dynamically before exporting. To export data dynamically, define the [`dataSource`](https://ej2.syncfusion.com/documentation/api/grid/excelExportProperties/#datasource) in [`ExcelExportProperties`](https://ej2.syncfusion.com/documentation/api/grid/excelExportProperties/#excelexportproperties).

{% if page.publishingplatform == "aspnet-core" %}
{% tabs %}
{% highlight c# tabtitle="custom-data" %}
{% include_relative code-snippet/excel-export/custom-data/custom-data.cs %}
{% endhighlight %}
{% highlight cshtml tabtitle="custom-data" %}
{% include_relative code-snippet/excel-export/custom-data/taghelper %}
{% endhighlight %}
{% elsif page.publishingplatform == "aspnet-mvc" %}
{% highlight c# tabtitle="custom-data" %}
{% include_relative code-snippet/excel-export/custom-data/custom-data.cs %}
{% endhighlight %}
{% highlight razor tabtitle="custom-data" %}
{% include_relative code-snippet/excel-export/custom-data/razor %}
{% endhighlight %}
{% endtabs %}



## Exporting grouped records

The excel export provides outline option for grouped records which hides the detailed data for better viewing.
In grid, we have provided the outline option for the exported document when the data's are grouped.

{% if page.publishingplatform == "aspnet-core" %}
{% tabs %}
{% highlight c# tabtitle="excel-group" %}
{% include_relative code-snippet/excel-export/excel-group/excel-group.cs %}
{% endhighlight %}
{% highlight cshtml tabtitle="excel-group" %}
{% include_relative code-snippet/excel-export/excel-group/taghelper %}
{% endhighlight %}
{% elsif page.publishingplatform == "aspnet-mvc" %}
{% highlight c# tabtitle="excel-group" %}
{% include_relative code-snippet/excel-export/excel-group/excel-group.cs %}
{% endhighlight %}
{% highlight razor tabtitle="excel-group" %}
{% include_relative code-snippet/excel-export/excel-group/razor %}
{% endhighlight %}
{% endtabs %}



## Export the hierarchy grid

The grid have an option to export the hierarchy grid to excel document. By default, grid will exports the visible child grids in expanded state. you can change the exporting option by using the **hierarchyExportMode** property of [`ExcelExportProperties`](https://ej2.syncfusion.com/documentation/api/grid/excelExportProperties/#excelexportproperties). The available options are,

| Mode     | Behavior    |
|----------|-------------|
| Expanded | Exports the visible child grids in expanded state. |
| All      | Exports the all the child grids in expanded state. |
| None     | Exports all child grids in collapse state. |

{% if page.publishingplatform == "aspnet-core" %}
{% tabs %}
{% highlight c# tabtitle="hierarchy" %}
{% include_relative code-snippet/excel-export/hierarchy/hierarchy.cs %}
{% endhighlight %}
{% highlight cshtml tabtitle="hierarchy" %}
{% include_relative code-snippet/excel-export/hierarchy/taghelper %}
{% endhighlight %}
{% elsif page.publishingplatform == "aspnet-mvc" %}
{% highlight c# tabtitle="hierarchy" %}
{% include_relative code-snippet/excel-export/hierarchy/hierarchy.cs %}
{% endhighlight %}
{% highlight razor tabtitle="hierarchy" %}
{% include_relative code-snippet/excel-export/hierarchy/razor %}
{% endhighlight %}
{% endtabs %}



### Limitations

* Microsoft Excel permits up to seven nested levels in outlines. So that in the grid we can able to provide only up to seven nested levels
  and if it exceeds more than seven levels then the document will be exported without outline option.
  Please refer the [Microsoft Limitation](https://docs.microsoft.com/en-us/sql/reporting-services/report-builder/exporting-to-microsoft-excel-report-builder-and-ssrs?view=sql-server-2017#ExcelLimitations)

## Exporting Grid in server

The Grid have an option to export the data to Excel in server side using Grid server export library.

### Server Dependencies

The Server side export functionality is shipped in the Syncfusion.EJ2.GridExport package, which is available in Essential Studio and [nuget.org](https://www.nuget.org/).The following list of dependencies is required for Grid server side Excel exporting action.

* Syncfusion.EJ2
* Syncfusion.EJ2.GridExport
* Syncfusion.Compression.Base
* Syncfusion.XlsIO.Base

### Server Configuration

The following code snippets shows server configuration using ASP.NET MVC Controller Action.

To Export the Grid in server side, You need to call the
 [`serverExcelExport`](https://ej2.syncfusion.com/documentation/api/grid/#serverexcelexport) method for passing the Grid properties to server exporting action.

{% if page.publishingplatform == "aspnet-core" %}
{% tabs %}
{% highlight c# tabtitle="server-export" %}
{% include_relative code-snippet/excel-export/server-export/server-exportMVC.cs %}
{% endhighlight %}
{% highlight cshtml tabtitle="server-export" %}
{% include_relative code-snippet/excel-export/server-export/taghelper %}
{% endhighlight %}
{% elsif page.publishingplatform == "aspnet-mvc" %}
{% highlight c# tabtitle="server-export" %}
{% include_relative code-snippet/excel-export/server-export/server-exportMVC.cs %}
{% endhighlight %}
{% highlight razor tabtitle="server-export" %}
{% include_relative code-snippet/excel-export/server-export/razor %}
{% endhighlight %}
{% endtabs %}



> **Note:** Refer to the GitHub sample for quick implementation and testing from [here](https://github.com/SyncfusionExamples/MVC-EJ2-Grid-server-side-exporting).

### CSV Export in server

You can export the Grid to CSV format by using the [`serverCsvExport`](https://ej2.syncfusion.com/documentation/api/grid/#servercsvexport) method which will pass the Grid properties to server.

In the below demo, we have invoked the above method inside the [`toolbarClick`](https://ej2.syncfusion.com/documentation/api/grid/#toolbarclick) event. In server side, we have deserialized the Grid properties and passed to the `CsvExport` method which will export the properties to CSV format.

{% if page.publishingplatform == "aspnet-core" %}
{% tabs %}
{% highlight c# tabtitle="server-csv-export" %}
{% include_relative code-snippet/excel-export/server-csv-export/server-exportMVC.cs %}
{% endhighlight %}
{% highlight cshtml tabtitle="server-csv-export" %}
{% include_relative code-snippet/excel-export/server-csv-export/taghelper %}
{% endhighlight %}
{% elsif page.publishingplatform == "aspnet-mvc" %}
{% highlight c# tabtitle="server-csv-export" %}
{% include_relative code-snippet/excel-export/server-csv-export/server-exportMVC.cs %}
{% endhighlight %}
{% highlight razor tabtitle="server-csv-export" %}
{% include_relative code-snippet/excel-export/server-csv-export/razor %}
{% endhighlight %}
{% endtabs %}



## See Also

* [Copy & paste excel](https://www.syncfusion.com/blogs/post/essential-js-2-copying-and-pasting-excel-sheet-data-to-grid-asp-net-mvc.aspx)

* [Copy and pasting excel sheet data to Grid](https://www.syncfusion.com/blogs/post/copy-and-pasting-excel-sheet-data-to-syncfusion-grid-for-mvc.aspx)