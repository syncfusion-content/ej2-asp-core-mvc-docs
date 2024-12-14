---
layout: post
title: Pdf Export in ##Platform_Name## Grid Component
description: Learn here all about Pdf Export in Syncfusion ##Platform_Name## Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Pdf Export
publishingplatform: ##Platform_Name##
documentation: ug
---

# Pdf export in ASP.NET MVC Grid component

The PDF export feature in the Syncfusion ASP.NET MVC Grid allows you to export grid data to a PDF document, providing the ability to generate printable reports or share data in a standardized format.

To enable PDF export in the grid, you need to set the [AllowPdfExport](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_AllowPdfExport) property to **true** and use the `PdfExport` method for exporting. 

The following example demonstrates how to perform a PDF export action in the grid.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/pdf-export/pdf-export/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Pdf-export.cs" %}
{% include code-snippet/grid/pdf-export/pdf-export/pdf-export.cs %}
{% endhighlight %}
{% endtabs %}

![Export Exporting](../images/pdf-export/pdf-exporting.png)

## Show spinner while exporting

Showing a spinner while exporting in the Syncfusion ASP.NET MVC Grid enhances the experience by displaying a spinner during the export process. This feature provides a visual indication of the export progress, improving the understanding of the exporting process.

To show or hide a spinner while exporting the grid, you can utilize the `ShowSpinner` and `HideSpinner` methods provided by the Grid within the [ToolbarClick](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ToolbarClick) event.

The `ToolbarClick` event is triggered when a toolbar item in the Grid is clicked. Within the event handler, the code checks if the clicked **item** is related with PDF export, specifically the **Grid_pdfexport** item. If a match is found, the `ShowSpinner` method is used on the Grid instance to display the spinner. 

To hide the spinner after the exporting is completed, bind the [PdfExportComplete](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_PdfExportComplete) event and use the `HideSpinner` method on the Grid instance to hide the spinner.

The following example demonstrates how to show and hide the spinner during PDF export in a grid.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/pdf-export/show-spinner-while-exporting/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Show-spinner.cs" %}
{% include code-snippet/grid/pdf-export/show-spinner-while-exporting/show-spinner.cs %}
{% endhighlight %}
{% endtabs %}

## Binding custom data source while exporting

The Syncfusion ASP.NET MVC Grid component provides a convenient way to export data to a PDF format. With the PDF export feature, you can define a custom data source while exporting. This allows you to export data that is not necessarily bind to the grid, which can be generated or retrieved based on your application logic.

To export data, you need to define the [DataSource](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_DataSource) property within the `PdfExportProperties` object. This property represents the data source that will be used for the PDF export.

The following example demonstrates how to render custom data source during PDF export. By utilizing the `PdfExport` method and passing the `PdfExportProperties` object through the grid instance, the grid data will be exported to a PDF using the dynamically defined data source.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/pdf-export/custom-data/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-data.cs" %}
{% include code-snippet/grid/pdf-export/custom-data/custom-data.cs %}
{% endhighlight %}
{% endtabs %}

![Export Custom Data](../images/pdf-export/export-custom-data.png)

> Make sure to utilize the `Field` property that you have declared in the grid columns when modifying the data source for exporting.

## Exporting with custom aggregate

Custom aggregates in the Syncfusion ASP.NET MVC Grid involves exporting grid data that includes additional calculated values based on specific requirements. This feature enables you to show the comprehensive view of the data in the exported file by incorporating the specific aggregated information you need for analysis or reporting purposes.

In order to utilize custom aggregation, you need to specify the `Type` property as **Custom** and provide the custom aggregate function in the `CustomAggregate` property. 

Within the **CustomAggregateFn** function, it takes an input data that contains a result property. The function calculates the count of objects in this data where the **ShipCountry** field value is equal to **Brazil** and returns the count with a descriptive label.

The following example shows how to export the grid with a custom aggregate that shows the calculation of the **Brazil** count of the **ShipCountry** column.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/pdf-export/custom-aggregate/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-data.cs" %}
{% include code-snippet/grid/pdf-export/custom-aggregate/custom-aggregate.cs  %}
{% endhighlight %}
{% endtabs %}

![Export Custom Aggregate](../images/pdf-export/custom-aggregate.png)

## Exporting with cell and row spanning

Exporting data from the Syncfusion ASP.NET MVC Grid with cell and row spanning enables you to maintain cell and row layout in the exported data. This feature is useful when you have merged cells or rows in the Grid and you want to maintain the same structure in the exported file.

To achieve this, you can utilize the `RowSpan` and `ColSpan` properties in the [QueryCellInfo](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_QueryCellInfo) event of the Grid. This event allows you to define the span values for specific cells. Additionally, you can customize the appearance of the grid cells during the export using the [PdfQueryCellInfo](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_PdfQueryCellInfo) event of the Grid.

The following example demonstrates how to perform export with cell and row spanning using `QueryCellInfo` and `PdfQueryCellInfo` events of the Grid.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/pdf-export/pdf-spanning/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Spanning.cs" %}
{% include code-snippet/grid/pdf-export/pdf-spanning/pdf-spanning.cs %}
{% endhighlight %}
{% endtabs %}

![Export Spanning](../images/pdf-export/export-spanning.png)

> * The `UpdateCell` method does not support row and column spanning.

## Merge duplicate cells in a specific column before exporting

You can merge duplicate cells (based on their values) in a specific column of the Syncfusion Grid. This can be achieved by utilizing the [DataBound](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_DataBound) event. Additionally, you can merge duplicate cells in the specified column during export by using the [PdfQueryCellInfo](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_PdfQueryCellInfo) event for PDF format. This functionality is useful for improving the readability of your data and providing a clearer visual representation.

Here’s an example demonstrating how to merge duplicate cells in the **OrderID** column in both Grid view and export:

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/pdf-export/export-duplicate-cell/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Spanning.cs" %}
{% include code-snippet/grid/pdf-export/export-duplicate-cell/export-duplicate-cell.cs %}
{% endhighlight %}
{% endtabs %}

![Export Duplicate Cell](../images/pdf-export/export-duplicate-cell.png)

## Exporting with custom date format

The exporting functionality in the Syncfusion ASP.NET MVC Grid allows you to export grid data, including custom date format. This feature is useful when you need to export grid data with customized date values. 

To apply a custom date format to grid columns during the export, you can utilize the `Format` property. This property allows you to define a custom format using format options.

The following example demonstrates how to export the grid data with custom date format. In this example, the formatOptions object is used as the `Format` property for the **OrderDate** column. This custom date format displays the date in the format of day-of-the-week, month abbreviation, day, and 2-digit year (e.g., Thu, Jul 4, '96).

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/pdf-export/export-date-format/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Spanning.cs" %}
{% include code-snippet/grid/pdf-export/export-date-format/export-date-format.cs %}
{% endhighlight %}
{% endtabs %}

![Export Duplicate Cell](../images/pdf-export/custom-date-format.png)

## Exporting multiple grids

Exporting multiple grids in the Syncfusion ASP.NET MVC Grid component allows you to export different grids to compare them side by side in external applications on the same or different pages of a PDF file.  Each grid is identified by its unique ID. You can specify which grid to export by listing their **IDs** in the [ExportGrids](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ExportGrids) property.

### Same page

PDF exporting provides support for exporting multiple grids on the same page. To export the grids on the same page, define `MultipleExport->Type` as **AppendToPage** in `PdfExportProperties`. It also has an option to provide blank space between the grids. This blank space can be defined by using `MultipleExport->BlankSpace` property. 

The following example demonstrates how to export multiple grids to the same page in a PDF file when a toolbar item is clicked.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/pdf-export/same-page/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Multiple.cs" %}
{% include code-snippet/grid/pdf-export/same-page/same-page.cs %}
{% endhighlight %}
{% endtabs %}

![Export Same Page](../images/pdf-export/export-same-page.png)

### New page

PDF export functionality enables the exporting of multiple grids into separate pages (each grid on a new page) within the PDF file.

To achieve this, you can follow these steps:

1. Access the `PdfExportProperties` of the Grid component.

2. Set the `MultipleExport->Type` property to **NewPage**.

3. Trigger the PDF export operation.

The following example demonstrates how to export multiple grids to a PDF file when a toolbar item is clicked.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/pdf-export/multiple/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Multiple.cs" %}
{% include code-snippet/grid/pdf-export/multiple/multiple.cs %}
{% endhighlight %}
{% endtabs %}

![Export New Page](../images/pdf-export/export-new-page.gif)

### Limitations

* Multiple grids exporting feature is not supported with server side exporting.

## Exporting hierarchy grid

Exporting a hierarchy grid in the Syncfusion ASP.NET MVC Grid component allows you to generate a PDF document that includes the master grid along with its child grids. This feature is useful when you need to export hierarchical data with its related details.

To achieve this, you can customize the exporting behavior by using the `PdfExportProperties.HierarchyExportMode` property of the Grid.

The `HierarchyExportMode` property allows you to specify the exporting behavior for the hierarchy grid. The following options are available:

| Mode     | Behavior    |
|----------|-------------|
| Expanded | Exports the master grid with expanded child grids. |
| All      | Exports the master grid with all child grids, expanded or not. |
| None     | Exports only the master grid without any child grids. |

The following example demonstrates how to export hierarchical grid to PDF document. Also change the `PdfExportProperties.HierarchyExportMode` property by using `Value` property of the `DropDownList` component.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/pdf-export/hierarchy/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Hierarchy.cs" %}
{% include code-snippet/grid/pdf-export/hierarchy/hierarchy.cs %}
{% endhighlight %}
{% endtabs %}

![Export Hierarchy Grid](../images/pdf-export/export-hierarchy-grid.png)

## Remove header row while exporting

When exporting data from the Syncfusion ASP.NET MVC Grid, you have an option to remove the header row from the exported file. This can be useful when you want to export grid data without including the header values in the exported document.

To achieve this, you can utilize the `PdfHeaderQueryCellInfo` event of the Grid. This event allows you to customize the header cells during the PDF export process. By handling this event, you can remove the header row from the exported file by not providing any content and height for the header cells. This ensures that the exported file contains only the data rows without including the header information.

The following example demonstrates how to perform export without header using `PdfHeaderQueryCellInfo` event of the Grid.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/pdf-export/remove-header/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Pdf-Export.cs" %}
{% include code-snippet/grid/pdf-export/remove-header/remove-header.cs %}
{% endhighlight %}
{% endtabs %}

![Export Remove Header](../images/pdf-export/remove-header.png)

## See Also

* [How can I change a layout to export to pdf in ASP.NET MVC Grid](https://www.syncfusion.com/forums/138196/how-can-i-change-a-layout-to-export-to-pdf-in-asp-net-mvc-grid)