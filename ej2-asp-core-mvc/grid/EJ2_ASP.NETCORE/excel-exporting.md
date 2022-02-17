---
layout: post
title: Excel Exporting in ##Platform_Name## Grid Component
description: Learn here all about Excel Exporting in Syncfusion ##Platform_Name## Grid component and more.
platform: ej2-asp-core-mvc
control: Excel Exporting
publishingplatform: ##Platform_Name##
documentation: ug
---


# Excel Export

The excel export allows exporting Grid data to Excel document. You need to use the
 **ExcelExport** method for exporting. To enable Excel export in the grid, set the [`allowExcelExport`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_AllowExcelExport) property as true.

To use excel export, You need to define the **ExcelExport** in inbuild toolbar and define the [`toolbarClick`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ToolbarClick) event for exporting the Grid.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/excel-export/excel-export/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Excel-export.cs" %}
{% include code-snippet/grid/excel-export/excel-export/excel-export.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/excel-export/excel-export/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Excel-export.cs" %}
{% include code-snippet/grid/excel-export/excel-export/excel-export.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Multiple Grid exporting

The excel export provides an option to export multiple grid data in the same excel file.

### Same sheet

The excel export provides support to export multiple grids in same sheet. To export in same sheet, define **multipleExport.type** as **AppendToSheet** in **exportProperties**. It have an option to provide blank rows between grids. These blank rows count can be defined by using the **multipleExport.blankRows**.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/excel-export/same-sheet/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Same-sheet.cs" %}
{% include code-snippet/grid/excel-export/same-sheet/same-sheet.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/excel-export/same-sheet/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Same-sheet.cs" %}
{% include code-snippet/grid/excel-export/same-sheet/same-sheet.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> By default, **multipleExport.blankRows** value is 5.

### New Sheet

Excel exporting provides support to export multiple grids in new sheet. To export in new sheet, define  **multipleExport.type** as **NewSheet** in **exportProperties**.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/excel-export/new-sheet/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="New-sheet.cs" %}
{% include code-snippet/grid/excel-export/new-sheet/new-sheet.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/excel-export/new-sheet/razor %}
{% endhighlight %}
{% highlight c# tabtitle="New-sheet.cs" %}
{% include code-snippet/grid/excel-export/new-sheet/new-sheet.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## To customize excel export

The excel export provides an option to customize mapping of the grid to excel document.

### Export current page

The excel export provides an option to export the current page into excel. To export current page, define **exportType** to **currentpage**.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/excel-export/export-current/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Export-current.cs" %}
{% include code-snippet/grid/excel-export/export-current/export-current.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/excel-export/export-current/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Export-current.cs" %}
{% include code-snippet/grid/excel-export/export-current/export-current.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Export hidden columns

The excel export provides an option to export hidden columns of grid by defining **includeHiddenColumn** as **true**.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/excel-export/export-hidden/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Export-hidden.cs" %}
{% include code-snippet/grid/excel-export/export-hidden/export-hidden.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/excel-export/export-hidden/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Export-hidden.cs" %}
{% include code-snippet/grid/excel-export/export-hidden/export-hidden.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Show or Hide columns on Exported Excel

You can show a hidden column or hide a visible column while printing the grid using [`toolbarClick`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ToolbarClick) and [`excelExportComplete`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ExcelExportComplete) events.

In the [`toolbarClick`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ToolbarClick) event, based on **args.item.id** as **Grid_excelexport**. We can show or hide columns by setting [`visible`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_Visible) property of **e-grid-column** tag helper to **true** or **false** respectively.

In the [`excelExportComplete`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ExcelExportComplete) event, We have reversed the state back to the previous state.

In the below example, we have **CustomerID** as a hidden column in the grid. While exporting, we have changed **CustomerID** to visible column and **ShipCity** as hidden column.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/excel-export/show-hide/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Show-hide.cs" %}
{% include code-snippet/grid/excel-export/show-hide/show-hide.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/excel-export/show-hide/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Show-hide.cs" %}
{% include code-snippet/grid/excel-export/show-hide/show-hide.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Export with filter options

The excel export provides an option to export with filter option in excel by defining `enableFilter` as **true** .
It requires the [`allowFiltering`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_AllowFiltering) to be true.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/excel-export/enable-filter/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Enable-filter.cs" %}
{% include code-snippet/grid/excel-export/enable-filter/enable-filter.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/excel-export/enable-filter/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Enable-filter.cs" %}
{% include code-snippet/grid/excel-export/enable-filter/enable-filter.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

### Conditional Cell Formatting

Grid cells in the exported Excel can be customized or formatted using [`excelQueryCellInfo`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ExcelQueryCellInfo) event. In this event, we can format the grid cells of exported PDF document based on the column cell value.

In the below sample, we have set the background color for **Freight** column in the exported excel by **args.cell** and **backColor** property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/excel-export/cell-format/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Cell-format.cs" %}
{% include code-snippet/grid/excel-export/cell-format/cell-format.cs %}
{% endhighlight %}
{% highlight c# tabtitle="Cell-format.cs" %}
{% include code-snippet/grid/excel-export/cell-format/cell-format.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/excel-export/cell-format/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Cell-format.cs" %}
{% include code-snippet/grid/excel-export/cell-format/cell-format.cs %}
{% endhighlight %}
{% highlight c# tabtitle="Cell-format.cs" %}
{% include code-snippet/grid/excel-export/cell-format/cell-format.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Theme

The excel export provides an option to include theme for exported excel document.

To apply theme in exported Excel, define the **theme** in **exportProperties** .

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/excel-export/theme/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Theme.cs" %}
{% include code-snippet/grid/excel-export/theme/theme.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/excel-export/theme/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Theme.cs" %}
{% include code-snippet/grid/excel-export/theme/theme.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> By default, material theme is applied to exported excel document.

### To add header and footer

The excel export provides an option to include header and footer content for exported excel document.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/excel-export/header-footer/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Header-footer.cs" %}
{% include code-snippet/grid/excel-export/header-footer/header-footer.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/excel-export/header-footer/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Header-footer.cs" %}
{% include code-snippet/grid/excel-export/header-footer/header-footer.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### File Name for Exported document

You can assign the file name for the exported document by defining **fileName** property in **ExcelExportProperties**.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/excel-export/export-filename/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Export-filename.cs" %}
{% include code-snippet/grid/excel-export/export-filename/export-filename.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/excel-export/export-filename/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Export-filename.cs" %}
{% include code-snippet/grid/excel-export/export-filename/export-filename.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Custom data source

The excel export provides an option to define datasource dynamically before exporting. To export data dynamically, define the **dataSource** in **exportProperties**.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/excel-export/custom-data/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-data.cs" %}
{% include code-snippet/grid/excel-export/custom-data/custom-data.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/excel-export/custom-data/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-data.cs" %}
{% include code-snippet/grid/excel-export/custom-data/custom-data.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Exporting grouped records

The excel export provides outline option for grouped records which hides the detailed data for better viewing.
In grid, we have provided the outline option for the exported document when the data's are grouped.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/excel-export/excel-group/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Excel-group.cs" %}
{% include code-snippet/grid/excel-export/excel-group/excel-group.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/excel-export/excel-group/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Excel-group.cs" %}
{% include code-snippet/grid/excel-export/excel-group/excel-group.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Export the hierarchy grid

The grid have an option to export the hierarchy grid to excel document. By default, grid will exports the visible child grids in expanded state. you can change the exporting option by using the **ExcelExportProperties.hierarchyExportMode** property. The available options are,

| Mode     | Behavior    |
|----------|-------------|
| Expanded | Exports the visible child grids in expanded state. |
| All      | Exports the all the child grids in expanded state. |
| None     | Exports all child grids in collapse state. |

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/excel-export/hierarchy/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Hierarchy.cs" %}
{% include code-snippet/grid/excel-export/hierarchy/hierarchy.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/excel-export/hierarchy/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Hierarchy.cs" %}
{% include code-snippet/grid/excel-export/hierarchy/hierarchy.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



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

### Server Configuration

The following code snippet shows server configuration using ASP.NET Core Controller Action.

To Export the Grid in server side, You need to call the
 [`serverExcelExport`](https://ej2.syncfusion.com/documentation/api/grid/#serverexcelexport) method for passing the Grid properties to server exporting action.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/excel-export/server-export/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Server-exportCore.cs" %}
{% include code-snippet/grid/excel-export/server-export/server-exportCore.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/excel-export/server-export/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Server-exportCore.cs" %}
{% include code-snippet/grid/excel-export/server-export/server-exportCore.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> Refer to the GitHub sample for quick implementation and testing from [here](https://github.com/SyncfusionExamples/Grid-Server-side-export-ASP.Net-Core).

### CSV Export in server

You can export the Grid to CSV format by using the [`serverCsvExport`](https://ej2.syncfusion.com/documentation/api/grid/#servercsvexport) method which will pass the Grid properties to server.

In the below demo, we have invoked the above method inside the [`toolbarClick`](https://ej2.syncfusion.com/documentation/api/grid/#toolbarclick) event. In server side, we have deserialized the Grid properties and passed to the `CsvExport` method which will export the properties to CSV format.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/excel-export/server-csv-export/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Server-exportCore.cs" %}
{% include code-snippet/grid/excel-export/server-csv-export/server-exportCore.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/excel-export/server-csv-export/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Server-exportCore.cs" %}
{% include code-snippet/grid/excel-export/server-csv-export/server-exportCore.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


