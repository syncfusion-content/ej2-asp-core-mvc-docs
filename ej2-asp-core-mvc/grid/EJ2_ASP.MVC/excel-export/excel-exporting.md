---
layout: post
title: Excel Exporting in Syncfusion ##Platform_Name## Grid Component
description: Learn here all about Excel Exporting in Syncfusion ##Platform_Name## Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Excel Exporting
publishingplatform: ##Platform_Name##
documentation: ug
---

# Excel exporting in ASP.NET MVC Grid component 

The Excel or CSV exporting feature in the ASP.NET MVC Grid component allows you to export the Grid data to an Excel or CSV document. This can be useful when you need to share or analyze the data in a spreadsheet format.

To enable Excel export in the Grid component, you need to set the [AllowExcelExport](https://help.syncfusion.com/cr/aspnetmvc-js2/syncfusion.ej2.grids.grid.html#Syncfusion_EJ2_Grids_Grid_AllowExcelExport) property to **true**. This property is responsible for enabling the Excel or CSV export option in the Grid.

To initiate the excel export process, you need to use the `excelExport` method provided by the Grid component. This method is responsible for exporting the Grid data to an Excel document.

> To initiate the CSV export process, you need to use the `csvExport` method provided by the Grid component. This method is responsible for exporting the Grid data to an CSV document.

The following example demonstrates how to perform a Excel or CSV export action in the grid:

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/excel-export/excel-export/razor %}
{% endhighlight %}
{% highlight c# tabtitle="excel-export.cs" %}
{% include code-snippet/grid/excel-export/excel-export/excel-export.cs %}
{% endhighlight %}
{% endtabs %}

![Excel exporting](../images/excel-exporting/excel-exporting.png)

## Show spinner while exporting 

Showing a spinner while exporting in the Grid enhances the experience by displaying a spinner during the export process. This feature provides a visual indication of the export progress, improving the understanding of the exporting process.

To show or hide a spinner while exporting the grid, you can utilize the `showSpinner` and `hideSpinner` methods provided by the Grid within the `ToolbarClick` event.

The [ToolbarClick](https://help.syncfusion.com/cr/aspnetmvc-js2/syncfusion.ej2.grids.grid.html#Syncfusion_EJ2_Grids_Grid_ToolbarClick) event is triggered when a toolbar item in the Grid is clicked. Within the event handler, the code checks if the clicked **item** is related with Excel or CSV export, specifically the **grid_excelexport** or **grid_csvexport** item. If a match is found, the `showSpinner` method is used on the Grid instance to display the spinner.

To hide the spinner after the exporting is completed, bind the [ExcelExportComplete](https://help.syncfusion.com/cr/aspnetmvc-js2/syncfusion.ej2.grids.grid.html#Syncfusion_EJ2_Grids_Grid_ExcelExportComplete) event and use the `hideSpinner` method on the Grid instance to hide the spinner.

The following example demonstrates how to show and hide the spinner during Excel export in a grid.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/excel-export/show-spinner-while-exporting/razor %}
{% endhighlight %}
{% highlight c# tabtitle="show-spinner.cs" %}
{% include code-snippet/grid/excel-export/show-spinner-while-exporting/show-spinner.cs %}
{% endhighlight %}
{% endtabs %}

## Binding custom data source while exporting

The Grid component provides a convenient way to export data to a Excel or CSV format. With the Excel or CSV export feature, you can define a custom data source while exporting. This allows you to export data that is not necessarily bind to the grid, which can be generated or retrieved based on your application logic.

To export data, you need to define the `DataSource` property within the `ExcelExportProperties` object. This property represents the data source that will be used for the Excel or CSV export.

The following example demonstrates how to render custom dataSource during Excel export. By calling the `excelExport` method and passing the `ExcelExportProperties` object through the grid instance, the grid data will be exported to a Excel using the dynamically defined data source.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/excel-export/custom-data/razor %}
{% endhighlight %}
{% highlight c# tabtitle="custom-data.cs" %}
{% include code-snippet/grid/excel-export/custom-data/custom-data.cs %}
{% endhighlight %}
{% endtabs %}

![Binding custom data source while exporting](../images/excel-exporting/excelexporting-custom.png)

## Exporting with custom aggregate

Exporting grid data with custom aggregates allows you to include additional calculated values in the exported file based on specific requirements. This feature is highly valuable for providing a comprehensive view of the data in the exported file, incorporating specific aggregated information for analysis or reporting purposes.

In order to utilize custom aggregation, you need to specify the `Type` property as **Custom** and provide the custom aggregate function in the `CustomAggregate` property.

Within the **customAggregateFn** function, it takes an input data that contains a result property. The function calculates the count of objects in this data where the **ShipCountry** field value is equal to **Brazil** and returns the count with a descriptive label.

The following example shows how to export the grid with a custom aggregate that shows the calculation of the **Brazil** count of the **ShipCountry** column.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/excel-export/excelexport-custom-aggregate/razor %}
{% endhighlight %}
{% highlight c# tabtitle="excel-export.cs" %}
{% include code-snippet/grid/excel-export/excelexport-custom-aggregate/excel-export.cs %}
{% endhighlight %}
{% endtabs %}

![Exporting with custom aggregate](../images/excel-exporting/excelexporting-aggregate.png)

## Exporting with cell and row spanning 

Exporting data from the Grid with cell and row spanning enables you to maintain cell and row layout in the exported data. This feature is useful when you have merged cells or rows in the Grid and you want to maintain the same structure in the exported file.

To achieve this, you can utilize the `RowSpan` and `ColSpan` properties in the [QueryCellInfo](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_QueryCellInfo) event of the Grid. This event allows you to define the span values for specific cells. Additionally, you can customize the appearance of the grid cells during the export using the [ExcelQueryCellInfo](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ExcelQueryCellInfo) event of the Grid.

The following example demonstrates how to perform export with cell and row spanning using `QueryCellInfo` and `ExcelQueryCellInfo` events of the Grid.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/excel-export/excelexport-cell-row-spanning/razor %}
{% endhighlight %}
{% highlight c# tabtitle="excel-export.cs" %}
{% include code-snippet/grid/excel-export/excelexport-cell-row-spanning/excel-export.cs %}
{% endhighlight %}
{% endtabs %}

![Exporting with cell and row spanning](../images/excel-exporting/excel-exporting-spanning.png)

> * The `updateCell` method does not support row and column spanning.

## Exporting with custom date format

The exporting functionality in the Syncfusion ASP.NET MVC Grid allows you to export grid data, including custom date format. This feature is useful when you need to export grid data with customized date values.

To apply a custom date format to grid columns during the export, you can utilize the `Columns.Format` property. This property allows you to define a custom format using format options.

The following example demonstrates how to export the grid with custom date format. In the example, the formatOptions object is used as the `Format` property for the **OrderDate** column. This custom date `Format` displays the date in the format of day-of-the-week, month abbreviation, day, and 2-digit year (e.g., Sun, May 8, '23).

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/excel-export/excelexport-date-format/razor %}
{% endhighlight %}
{% highlight c# tabtitle="excel-export.cs" %}
{% include code-snippet/grid/excel-export/excelexport-date-format/excel-export.cs %}
{% endhighlight %}
{% endtabs %}

![Exporting with custom date format](../images/excel-exporting/excelexport-format.png)

## Merge duplicate cells in a specific column before exporting

You can merge duplicate cells (based on their values) in a specific column of the Syncfusion Grid. This can be achieved by utilizing the [DataBound](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_DataBound) event. Additionally, you can merge duplicate cells in the specified column during export by using the [ExcelQueryCellInfo](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ExcelQueryCellInfo) event for Excel and CSV formats. This functionality is useful for improving the readability of your data and providing a clearer visual representation.

Here’s an example demonstrating how to merge duplicate cells in the OrderID column in both Grid view and export:

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/excel-export/excelexport-duplicate/razor %}
{% endhighlight %}
{% highlight c# tabtitle="excel-export.cs" %}
{% include code-snippet/grid/excel-export/excelexport-duplicate/excel-export.cs %}
{% endhighlight %}
{% endtabs %}

![Merge duplicate cells](../images/excel-exporting/excelexporting-merge.png)

## Exporting multiple grids

Exporting multiple grids in the Syncfusion ASP.NET MVC Grid component allows you to export different grids to compare them side by side in external applications on the same or different pages of a Excel. Each grid is identified by its unique ID. You can specify which grid to export by listing their IDs in the [ExportGrids](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ExportGrids) property.

### Same sheet

Excel exporting provides support for exporting multiple grids on the same page. This feature is particularly useful when you want to combine and organize data from different grids for a unified view in the exported Excel file.

To achieve this, you need to define the `MultipleExport.Type` property as **AppendToSheet** in the `ExcelExportProperties` object. This setting ensures that the data from each grid will be appended to the same Excel sheet.

Additionally, you have an option to include blank rows between the data of each grid to visually separate them in the exported Excel sheet. The number of blank rows to be inserted can be defined using the `MultipleExport.BlankRows` property.

The following example demonstrates how to export multiple grids to the same page in a Excel file when a toolbar item is clicked.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/excel-export/excelexport-samesheet/razor %}
{% endhighlight %}
{% highlight c# tabtitle="excel-export.cs" %}
{% include code-snippet/grid/excel-export/excelexport-samesheet/excel-export.cs %}
{% endhighlight %}
{% endtabs %}

>By default, **multipleExport.blankRows** value is 5.

![Same sheet](../images/excel-exporting/excelexporting-samesheet.gif)

### New sheet

Excel export functionality enables the exporting of multiple grids into separate pages (each grid on a new page) within the Excel file.

To achieve this, you can follow these steps:

1. Access the `ExcelExportProperties` of the Grid component.

2. Set the `MultipleExport.Type` to **NewPage**.

3. Trigger the Excel export operation.

The following example demonstrates how to export multiple grids to a Excel file when a toolbar item is clicked.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/excel-export/excelexport-newsheet/razor %}
{% endhighlight %}
{% highlight c# tabtitle="excel-export.cs" %}
{% include code-snippet/grid/excel-export/excelexport-newsheet/excel-export.cs %}
{% endhighlight %}
{% endtabs %}

![New sheet](../images/excel-exporting/excelexporting-newsheet.gif)

### Limitations

* Multiple grids exporting feature is not supported with server side exporting.

## Exporting hierarchy grid 

Exporting a hierarchy grid in the Syncfusion ASP.NET MVC Grid component allows you to generate a Excel or CSV document that includes the parent grid along with its child grids. This feature is useful when you need to export hierarchical data with its related details.

To achieve this, you can customize the exporting behavior by using the `ExcelExportProperties.HierarchyExportMode` property of the Grid. This property allows you to specify the exporting behavior for the hierarchy grid. The following options are available:

| Mode     | Behavior    |
|----------|-------------|
| Expanded | Exports the master grid with expanded child grids.|
| All      | Exports the master grid with all child grids, expanded or not. |
| None     | Exports only the master grid without any child grids. |

The following example demonstrates how to export hierarchical grid to Excel document. Also change the `ExcelExportProperties`.HierarchyExportMode` property by using [Value](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Buttons.Switch.html#Syncfusion_EJ2_Buttons_Switch_Value) property of the DropDownList component:

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/excel-export/excelexport-hierarchy/razor %}
{% endhighlight %}
{% highlight c# tabtitle="excel-export.cs" %}
{% include code-snippet/grid/excel-export/excelexport-hierarchy/excel-export.cs %}
{% endhighlight %}
{% endtabs %}

![Exporting hierarchy grid](../images/excel-exporting/excelexporting-heirachy.png)

### Limitations

* Microsoft Excel permits up to seven nested levels in outlines. So that in the grid we can able to provide only up to seven nested levels and if it exceeds more than seven levels then the document will be exported without outline option. Please refer the [Microsoft Limitation](https://learn.microsoft.com/en-us/sql/reporting-services/report-builder/exporting-to-microsoft-excel-report-builder-and-ssrs?view=sql-server-2017#ExcelLimitations).

## How to add formula for the cell while exporting

The Grid component provides a convenient way to add formulas to cells during the export process. This feature allows you to perform calculations and apply formulas to specific cells in the exported Excel document. This can be particularly useful when you need to include calculated values or perform complex calculations.

To add formulas to cells during the export process, you can utilize the `ValueAccessor` method along with the [ExcelQueryCellInfo](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ExcelQueryCellInfo) event. 

In the following example, the [ToolbarClick](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ToolbarClick) function handles a toolbar button click event. When the Excel Export button is clicked, it triggers the Excel export process. Inside this function, an `ExcelExportProperties` object is defined, specifying that hidden columns should be included in the export. Inside the `ExcelQueryCellInfo` event, the `ValueAccessor` method generates formulas for the desired cells and assigns these formulas to the cell's formula property, ensuring that the calculated values are exported to the Excel document:

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/excel-export/excelexport-addformula/razor %}
{% endhighlight %}
{% highlight c# tabtitle="excel-export.cs" %}
{% include code-snippet/grid/excel-export/excelexport-addformula/excel-export.cs %}
{% endhighlight %}
{% endtabs %}

![Add formula for the cell while exporting](../images/excel-exporting/excelexporting-formula.png)

## Passing additional parameters to the server when exporting

Passing additional parameters to the server when exporting data in the Syncfusion ASP.NET MVC Grid involves providing flexibility to include extra information or customize the export process based on specific requirements.

You can achieve this by utilizing the [Query](https://help.syncfusion.com/cr/aspnetmvc-js2/syncfusion.ej2.grids.grid.html#Syncfusion_EJ2_Grids_Grid_Query) property and the [ToolbarClick](https://help.syncfusion.com/cr/aspnetmvc-js2/syncfusion.ej2.grids.grid.html#Syncfusion_EJ2_Grids_Grid_ToolbarClick) event. Within the `Query` property, you can invoke the `AddParams` method to add parameters to the request.

The following example demonstrates how to pass additional parameters to the server when Excel exporting within the `ToolbarClick` event. Within the event, the additional parameters, specifically **Recordcount** as **15**, are passed using the `AddParams` method and displayed as a message.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/excel-export/additional-parameter/razor %}
{% endhighlight %}
{% highlight c# tabtitle="excel-export.cs" %}
{% include code-snippet/grid/excel-export/additional-parameter/excel-export.cs %}
{% endhighlight %}
{% endtabs %}

![Passing additional parameters to the server when exporting](../images/excel-exporting/additional-parameter.png)

## Limitations

* A CSV is a plain text format that does not support features such as cell rotation, font and color customization, column and row spanning, or adding formulas. CSV files store raw data without any formatting or styling.

## See Also

* [Copy & paste excel](https://www.syncfusion.com/blogs/post/essential-js-2-copying-and-pasting-excel-sheet-data-to-grid-asp-net-mvc.aspx)

* [Copy and pasting excel sheet data to Grid](https://www.syncfusion.com/blogs/post/copy-and-pasting-excel-sheet-data-to-syncfusion-grid-for-mvc.aspx)
