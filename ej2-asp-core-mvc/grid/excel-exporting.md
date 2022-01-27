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
 `ExcelExport` method for exporting. To enable Excel export in the grid, set the [`AllowExcelExport`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_AllowExcelExport) as true.

To use excel export, You need to define the `ExcelExport` in inbuild toolbar and define the toolbarClick event for exporting the Grid.

{% if page.publishingplatform == "aspnet-core" %}
{% tabs %}
{% highlight %}
{% include_relative code-snippet/excel-export/excel-export/excel-export.cs %}
{% endhighlight %}
{% highlight %}
{% include_relative code-snippet/excel-export/excel-export/taghelper %}
{% endhighlight %}
{% elsif page.publishingplatform == "aspnet-mvc" %}
{% highlight %} {% include_relative code-snippet/excel-export/excel-export/excel-export.cs %}
{% endhighlight %}
{% highlight %}
{% include_relative code-snippet/excel-export/excel-export/razor %}
{% endhighlight %}
{% endtabs %}



## Multiple Grid exporting

The excel export provides an option to export multiple grid data in the same excel file.

### Same sheet

The excel export provides support to export multiple grids in same sheet. To export in same sheet, define `multipleExport.type` as `AppendToSheet` in `exportProperties`. It have an option to provide blank rows between grids. These blank rows count can be defined by using the`multipleExport.blankRows`.

{% if page.publishingplatform == "aspnet-core" %}
{% tabs %}
{% highlight %}
{% include_relative code-snippet/excel-export/same-sheet/same-sheet.cs %}
{% endhighlight %}
{% highlight %}
{% include_relative code-snippet/excel-export/same-sheet/taghelper %}
{% endhighlight %}
{% elsif page.publishingplatform == "aspnet-mvc" %}
{% highlight %} {% include_relative code-snippet/excel-export/same-sheet/same-sheet.cs %}
{% endhighlight %}
{% highlight %}
{% include_relative code-snippet/excel-export/same-sheet/razor %}
{% endhighlight %}
{% endtabs %}



> By default, `multipleExport.blankRows` value is 5.

### New Sheet

Excel exporting provides support to export multiple grids in new sheet. To export in new sheet, define  `multipleExport.type` as `NewSheet` in `exportProperties`.

{% if page.publishingplatform == "aspnet-core" %}
{% tabs %}
{% highlight %}
{% include_relative code-snippet/excel-export/new-sheet/new-sheet.cs %}
{% endhighlight %}
{% highlight %}
{% include_relative code-snippet/excel-export/new-sheet/taghelper %}
{% endhighlight %}
{% elsif page.publishingplatform == "aspnet-mvc" %}
{% highlight %} {% include_relative code-snippet/excel-export/new-sheet/new-sheet.cs %}
{% endhighlight %}
{% highlight %}
{% include_relative code-snippet/excel-export/new-sheet/razor %}
{% endhighlight %}
{% endtabs %}



## To customize excel export

The excel export provides an option to customize mapping of the grid to excel document.

### Export current page

The excel export provides an option to export the current page into excel. To export current page, define `exportType` to `currentpage`.

{% if page.publishingplatform == "aspnet-core" %}
{% tabs %}
{% highlight %}
{% include_relative code-snippet/excel-export/export-current/export-current.cs %}
{% endhighlight %}
{% highlight %}
{% include_relative code-snippet/excel-export/export-current/taghelper %}
{% endhighlight %}
{% elsif page.publishingplatform == "aspnet-mvc" %}
{% highlight %} {% include_relative code-snippet/excel-export/export-current/export-current.cs %}
{% endhighlight %}
{% highlight %}
{% include_relative code-snippet/excel-export/export-current/razor %}
{% endhighlight %}
{% endtabs %}



### Export hidden columns

The excel export provides an option to export hidden columns of grid by defining `includeHiddenColumn` as `true`.

{% if page.publishingplatform == "aspnet-core" %}
{% tabs %}
{% highlight %}
{% include_relative code-snippet/excel-export/export-hidden/export-hidden.cs %}
{% endhighlight %}
{% highlight %}
{% include_relative code-snippet/excel-export/export-hidden/taghelper %}
{% endhighlight %}
{% elsif page.publishingplatform == "aspnet-mvc" %}
{% highlight %} {% include_relative code-snippet/excel-export/export-hidden/export-hidden.cs %}
{% endhighlight %}
{% highlight %}
{% include_relative code-snippet/excel-export/export-hidden/razor %}
{% endhighlight %}
{% endtabs %}



### Show or Hide columns on Exported Excel

You can show a hidden column or hide a visible column while printing the grid using [`toolbarClick`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ToolbarClick) and [`excelExportComplete`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ExcelExportComplete) events.

In the `toolbarClick` event, based on `args.item.id` as `Grid_pdfexport`. We can show or hide columns by setting `column.visible` property to `true` or `false` respectively.

In the excelExportComplete event, We have reversed the state back to the previous state.

In the below example, we have `CustomerID` as a hidden column in the grid. While exporting, we have changed `CustomerID` to visible column and `ShipCity` as hidden column.

{% if page.publishingplatform == "aspnet-core" %}
{% tabs %}
{% highlight %}
{% include_relative code-snippet/excel-export/show-hide/show-hide.cs %}
{% endhighlight %}
{% highlight %}
{% include_relative code-snippet/excel-export/show-hide/taghelper %}
{% endhighlight %}
{% elsif page.publishingplatform == "aspnet-mvc" %}
{% highlight %} {% include_relative code-snippet/excel-export/show-hide/show-hide.cs %}
{% endhighlight %}
{% highlight %}
{% include_relative code-snippet/excel-export/show-hide/razor %}
{% endhighlight %}
{% endtabs %}



### Conditional Cell Formatting

Grid cells in the exported Excel can be customized or formatted using [`excelQueryCellInfo`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ExcelQueryCellInfo) event. In this event, we can format the grid cells of exported PDF document based on the column cell value.

In the below sample, we have set the background color for `Freight` column in the exported excel by `args.cell` and `backColor` property.

{% if page.publishingplatform == "aspnet-core" %}
{% tabs %}
{% highlight %}
{% include_relative code-snippet/excel-export/cell-format/cell-format.cs %}
{% endhighlight %}
{% highlight %}
{% include_relative code-snippet/excel-export/cell-format/taghelper %}
{% endhighlight %}
{% elsif page.publishingplatform == "aspnet-mvc" %}
{% highlight %} {% include_relative code-snippet/excel-export/cell-format/cell-format.cs %}
{% endhighlight %}
{% highlight %}
{% include_relative code-snippet/excel-export/cell-format/razor %}
{% endhighlight %}
{% endtabs %}



### Theme

The excel export provides an option to include theme for exported excel document.

To apply theme in exported Excel, define the `theme` in `exportProperties` .

{% if page.publishingplatform == "aspnet-core" %}
{% tabs %}
{% highlight %}
{% include_relative code-snippet/excel-export/theme/theme.cs %}
{% endhighlight %}
{% highlight %}
{% include_relative code-snippet/excel-export/theme/taghelper %}
{% endhighlight %}
{% elsif page.publishingplatform == "aspnet-mvc" %}
{% highlight %} {% include_relative code-snippet/excel-export/theme/theme.cs %}
{% endhighlight %}
{% highlight %}
{% include_relative code-snippet/excel-export/theme/razor %}
{% endhighlight %}
{% endtabs %}



> By default, material theme is applied to exported excel document.

### To add header and footer

The excel export provides an option to include header and footer content for exported excel document.

{% if page.publishingplatform == "aspnet-core" %}
{% tabs %}
{% highlight %}
{% include_relative code-snippet/excel-export/header-footer/header-footer.cs %}
{% endhighlight %}
{% highlight %}
{% include_relative code-snippet/excel-export/header-footer/taghelper %}
{% endhighlight %}
{% elsif page.publishingplatform == "aspnet-mvc" %}
{% highlight %} {% include_relative code-snippet/excel-export/header-footer/header-footer.cs %}
{% endhighlight %}
{% highlight %}
{% include_relative code-snippet/excel-export/header-footer/razor %}
{% endhighlight %}
{% endtabs %}



### File Name for Exported document

You can assign the file name for the exported document by defining `fileName` property in `ExcelExportProperties`.

{% if page.publishingplatform == "aspnet-core" %}
{% tabs %}
{% highlight %}
{% include_relative code-snippet/excel-export/export-filename/export-filename.cs %}
{% endhighlight %}
{% highlight %}
{% include_relative code-snippet/excel-export/export-filename/taghelper %}
{% endhighlight %}
{% elsif page.publishingplatform == "aspnet-mvc" %}
{% highlight %} {% include_relative code-snippet/excel-export/export-filename/export-filename.cs %}
{% endhighlight %}
{% highlight %}
{% include_relative code-snippet/excel-export/export-filename/razor %}
{% endhighlight %}
{% endtabs %}



## Custom data source

The excel export provides an option to define datasource dynamically before exporting. To export data dynamically, define the `dataSource` in `exportProperties`.

{% if page.publishingplatform == "aspnet-core" %}
{% tabs %}
{% highlight %}
{% include_relative code-snippet/excel-export/custom-data/custom-data.cs %}
{% endhighlight %}
{% highlight %}
{% include_relative code-snippet/excel-export/custom-data/taghelper %}
{% endhighlight %}
{% elsif page.publishingplatform == "aspnet-mvc" %}
{% highlight %} {% include_relative code-snippet/excel-export/custom-data/custom-data.cs %}
{% endhighlight %}
{% highlight %}
{% include_relative code-snippet/excel-export/custom-data/razor %}
{% endhighlight %}
{% endtabs %}



## Exporting grouped records

The excel export provides outline option for grouped records which hides the detailed data for better viewing.
In grid, we have provided the outline option for the exported document when the data's are grouped.

{% if page.publishingplatform == "aspnet-core" %}
{% tabs %}
{% highlight %}
{% include_relative code-snippet/excel-export/excel-group/excel-group.cs %}
{% endhighlight %}
{% highlight %}
{% include_relative code-snippet/excel-export/excel-group/taghelper %}
{% endhighlight %}
{% elsif page.publishingplatform == "aspnet-mvc" %}
{% highlight %} {% include_relative code-snippet/excel-export/excel-group/excel-group.cs %}
{% endhighlight %}
{% highlight %}
{% include_relative code-snippet/excel-export/excel-group/razor %}
{% endhighlight %}
{% endtabs %}



## Export the hierarchy grid

The grid have an option to export the hierarchy grid to excel document. By default, grid will exports the visible child grids in expanded state. you can change the exporting option by using the `ExcelExportProperties.hierarchyExportMode` property. The available options are,

| Mode     | Behavior    |
|----------|-------------|
| Expanded | Exports the visible child grids in expanded state. |
| All      | Exports the all the child grids in expanded state. |
| None     | Exports all child grids in collapse state. |

{% if page.publishingplatform == "aspnet-core" %}
{% tabs %}
{% highlight %}
{% include_relative code-snippet/excel-export/hierarchy/hierarchy.cs %}
{% endhighlight %}
{% highlight %}
{% include_relative code-snippet/excel-export/hierarchy/taghelper %}
{% endhighlight %}
{% elsif page.publishingplatform == "aspnet-mvc" %}
{% highlight %} {% include_relative code-snippet/excel-export/hierarchy/hierarchy.cs %}
{% endhighlight %}
{% highlight %}
{% include_relative code-snippet/excel-export/hierarchy/razor %}
{% endhighlight %}
{% endtabs %}



### Limitations

* Microsoft Excel permits up to seven nested levels in outlines. So that in the grid we can able to provide only up to seven nested levels
  and if it exceeds more than seven levels then the document will be exported without outline option.
  Please refer the [Microsoft Limitation](https://docs.microsoft.com/en-us/sql/reporting-services/report-builder/exporting-to-microsoft-excel-report-builder-and-ssrs?view=sql-server-2017#ExcelLimitations)