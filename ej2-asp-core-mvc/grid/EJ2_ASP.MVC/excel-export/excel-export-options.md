---
layout: post
title: Excel Export Options in Syncfusion ##Platform_Name## Grid Component
description: Learn here all about Excel Export Options in Syncfusion ##Platform_Name## Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Excel Export Options
publishingplatform: ##Platform_Name##
documentation: ug
---

# Excel export options in ASP.NET MVC Grid component

The Syncfusion ASP.NET MVC Grid component allows you to customize the Excel or CSV export options functionality. This flexibility enables you to have greater control over the exported content and layout to meet your specific requirements.

The Excel or CSV export action can be customized based on your requirements using the `ExcelExportProperties` property. By using the `ExcelExportProperties` property, you can export specific columns, exclude or include hidden column, export with custom data source, enable filter in the exported excel or CSV file, change the file name, add header and footer, multiple grid exporting, customize the data based on query, define delimiter for CSV exporting and set the theme.

## Export current page records

Exporting the current page in Syncfusion ASP.NET MVC Grid to a Excel or CSV document provides the ability to export the currently displayed page records. This feature allows for generating Excel or CSV documents that specifically include the content from the current page of the grid. 

To export the current page of the grid to an Excel or CSV document, you need to specify the `ExportType` property. This property allows you to define which records you want to export. You can choose between two options:

1. **CurrentPage**: Exports only the records on the current grid page.
2. **AllPages**: Exports all the records from the grid.

The following example demonstrates how to export current page to a Excel document when a toolbar item is clicked.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/excel-export/export-current/razor %}
{% endhighlight %}
{% highlight c# tabtitle="export-current.cs" %}
{% include code-snippet/grid/excel-export/export-current/export-current.cs %}
{% endhighlight %}
{% endtabs %}

## Export the selected records 

Exporting only the selected records from the Grid allows generating Excel or CSV document that include only the desired data from the Grid. This feature provides the flexibility to export specific records that are relevant to the needs, enabling more focused and targeted Excel or CSV exports.

To export only the selected records by utilizing the `ExportProperties.DataSource` property in the `ToolbarClick` event.

To export the selected records from the grid to a Excel or CSV file, you can follow these steps:

1. Handle the [ToolbarClick](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ToolbarClick) event of the Grid.

2. Retrieve the selected records using the `getSelectedRecords` method.

3. Assign the selected data to the `ExportProperties.DataSource` property.

4. Trigger the export operation using the `excelExport` or `csvExport` method.

The following example demonstrates how to export the selected records to a Excel document when a toolbar item is clicked.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/excel-export/export-selected-data/razor %}
{% endhighlight %}
{% highlight c# tabtitle="selected-data.cs" %}
{% include code-snippet/grid/excel-export/export-selected-data/selected-data.cs %}
{% endhighlight %}
{% endtabs %}

![Export the selected records](../images/excel-exporting/exceloption-selected.png)

## Exporting grouped records

The Grid component provides an outline option for grouped records, allowing you to hide detailed data for better viewing in the exported document. This feature is particularly useful when you need to share data that is grouped based on specific columns and maintain the grouping structure in the exported file.

To achieve this functionality, you need to enable grouping in the Grid by setting the [AllowGrouping](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_AllowGrouping) property to **true** . Additionally, you need define the [GroupSettings.Columns](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.GridGroupSettings.html#Syncfusion_EJ2_Grids_GridGroupSettings_Columns) property to specify the columns by which you want to group the data.

The following example demonstrates how to export grouped records to an Excel document when a toolbar item is clicked.:

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/excel-export/excel-group/razor %}
{% endhighlight %}
{% highlight c# tabtitle="selected-data.cs" %}
{% include code-snippet/grid/excel-export/excel-group/excel-group.cs %}
{% endhighlight %}
{% endtabs %}

![Exporting grouped records](../images/excel-exporting/exportoption-group.png)

## Export with hidden columns

Exporting hidden columns in the Syncfusion ASP.NET MVC Grid allows you to include hidden columns in the exported Excel document. This feature is useful when you have columns that are hidden in the UI but still need to be included in the exported document.

To export hidden columns of the grid to a Excel or CSV file, you need to set the `IncludeHiddenColumn` property as **true** in the `ExcelExportProperties` property.

The following example demonstrates how to export hidden columns to a Excel file. In this example, the **ShipCity** column, which is not visible in the UI, is exported to the Excel document. You can also export the grid by changing the `ExcelExportProperties.IncludeHiddenColumn` property based on the switch toggle using the [Checked](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Buttons.Switch.html#Syncfusion_EJ2_Buttons_Switch_Checked) property of the [EJ2 Toggle Switch Button](https://ej2.syncfusion.com/aspnetmvc/documentation/switch/getting-started) component.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/excel-export/export-hidden/razor %}
{% endhighlight %}
{% highlight c# tabtitle="xport-hidden.cs" %}
{% include code-snippet/grid/excel-export/export-hidden/export-hidden.cs %}
{% endhighlight %}
{% endtabs %}

![Export with hidden columns](../images/excel-exporting/exceloption-hidden.png)

## Show or hide columns while exporting

The Grid component provides the functionality to show or hide columns dynamically during the export process. This feature allows you to selectively display or hide specific columns based on your requirements.

To show or hide columns based on user interaction during the export process, you can follow these steps:

1. Handle the [ToolbarClick](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ToolbarClick) event of the Grid component.

2. Update the visibility of the desired columns by setting the `Visible` property of the column to **true** or **false**.

3. Export the grid to Excel.

4. Handle the [ExcelExportComplete](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ExcelExportComplete) event to restore the column visibility to its original state.

In the following example, the **CustomerID** is initially a hidden column in the grid. However, during the export process, the **CustomerID** column is made visible, while the **Freight** column is hidden.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/excel-export/show-hide/razor %}
{% endhighlight %}
{% highlight c# tabtitle="xport-hidden.cs" %}
{% include code-snippet/grid/excel-export/show-hide/show-hide.cs %}
{% endhighlight %}
{% endtabs %}

![Show or hide columns while exporting](../images/excel-exporting/exceloption-show.png)

## Enable filtering in the exported excel file

The Grid allows you to export data to Excel or CSV with filter options and also export only filtered records. This feature is especially beneficial when you need to share data with others while preserving the ability for them to filter and analyze the data in Excel or CSV.

To enable this feature, you should set the `EnableFilter` property to **true** in the `ExcelExportProperties` object. Additionally, you need to set [AllowFiltering](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_AllowFiltering) to **true** in the grid configuration. This property enables filtering in the grid.

The following example demonstrates how to export data with filter options to an Excel document when a toolbar item is clicked:

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/excel-export/export-enable-filtering/razor %}
{% endhighlight %}
{% highlight c# tabtitle="export-filtering.cs" %}
{% include code-snippet/grid/excel-export/export-enable-filtering/export-filtering.cs %}
{% endhighlight %}
{% endtabs %}

![Enable filtering](../images/excel-exporting/exportoption-enable-filtering.png)

## Define file name

The Syncfusion ASP.NET MVC Grid component allows you to specify a custom file name for the exported Excel or CSV document. This feature enables you to provide a meaningful and descriptive name for the exported file, making it easier to identify and manage the exported data.

To assign a custom file name for the exported document, you can set the `FileName` property of the `ExcelExportProperties` property to the desired file name.

The following example demonstrates how to define a file name using `ExcelExportProperties.FileName` property when exporting to Excel, based on the entered value as the file name.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/excel-export/export-filename/razor %}
{% endhighlight %}
{% highlight c# tabtitle="export-filename.cs" %}
{% include code-snippet/grid/excel-export/export-filename/export-filename.cs %}
{% endhighlight %}
{% endtabs %}

![ Define file name](../images/excel-exporting/exceloption-filename.png)

## Export the master detail grid

The export functionality within the master-detail grid feature of the Grid enables you to export not only the master grid but also the associated detail grid onto a single Excel sheet. This feature proves to be particularly valuable when dealing with hierarchical data represented by two grids in the exported Excel file, allowing for comprehensive analysis and management.

To export the master-detail grid on the same sheet, you need to set the `MultipleExport.Type` property of the `ExcelExportProperties` object to **AppendToSheet**. It also has an option to provide blank space between the grids. This blank space can be defined by using `MultipleExport.BlankRows` property.

The following example demonstrates how to export master detail grid to the same page in a Excel file when a toolbar item is clicked. The [RowSelected](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_RowSelected) event dynamically updates the detail grid based on the selected master record:

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/excel-export/masterdetailgrid/razor %}
{% endhighlight %}
{% highlight c# tabtitle="masterdetailgrid.cs" %}
{% include code-snippet/grid/excel-export/masterdetailgrid/masterdetailgrid.cs %}
{% endhighlight %}
{% endtabs %}

![Export the master detail grid](../images/excel-exporting/exportoption-mastergrid.png)

## Customizing columns on export

The Grid component allows you to customize the appearance of grid columns in your exported Excel or CSV documents. This feature empowers you to tailor specific column attributes such as field, header text, and text alignment, ensuring that your exported Excels align perfectly with your design and reporting requirements.

To customize the grid columns, you can follow these steps:

1. Access the `ExcelExportProperties.Column` of the Grid component.

2. Set the `Column` object with attributes such as `Field`, `HeaderText`, and `TextAlign` to define the desired format.

3. Trigger the Excel or CSV export operation to apply the customized column settings.

The following example demonstrates how to customize the grid columns when exporting a document. In this scenario, the attributes for different columns have been customized: **OrderID** with `TextAlign` set to Right, **CustomerID** with headerText as **Customer Name**, and **Freight** with a center-aligned `TextAlign` property, which is not rendered in the grid columns:

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/excel-export/export-customizing-columns/razor %}
{% endhighlight %}
{% highlight c# tabtitle="export-customize.cs" %}
{% include code-snippet/grid/excel-export/export-customizing-columns/export-customize.cs %}
{% endhighlight %}
{% endtabs %}

![Customizing columns on export](../images/excel-exporting/exceloption-customizing-columns.png)

## Font and color customization 

The Excel export feature in Grid provides an option to include themes for the exported Excel document. This feature is particularly useful when you want to maintain a consistent and visually appealing style for the exported data in Excel.

To apply a theme to the exported Excel document, you can define the `Theme` property within the `ExcelExportProperties`. This property allows you to specify the `Theme` to be used in the exported Excel file, including styles for the caption, header, and record content.

`Caption`: This property defines the theme style for the caption content in the exported Excel document. The caption is the title or description that appears at the top of the exported Excel sheet.

`Header`: This property is used to defines the style for the header content in the exported Excel document. The header corresponds to the column headers in the Grid.

`Record`: This property defines the theme style for the record content in the exported Excel document. The record represents the data rows in the Grid that are exported to Excel.

In the following example, apply font styling to the caption, header, and record in the Excel file using the `Theme` property:

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/excel-export/theme/razor %}
{% endhighlight %}
{% highlight c# tabtitle="theme.cs" %}
{% include code-snippet/grid/excel-export/theme/theme.cs %}
{% endhighlight %}
{% endtabs %}

![Customizing columns on export](../images/excel-exporting/exceloption-font-color.png)

>By default, material theme is applied to exported excel document.

## Rotate a header text in the exported grid

The Grid provides support to customize the column header styles, such as changing the text orientation, font color, and more, in the exported Excel file. This feature is useful when you want to enhance the visual appearance of the exported data and provide a unique representation of the Grid in the Excel document.

To achieve this requirement, use the [ExcelHeaderQueryCellInfo](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ExcelHeaderQueryCellInfo) event of the Grid. This event is triggered when creating a column header for the Excel document to be exported. By customizing the column header within this event, you can easily rotate the header text to a certain degree in the exported Grid, making the data presentation in the Excel document more visually appealing and tailored to your specific requirements.

In the following demo, using the `Rotation` property of the style argument in the `ExcelHeaderQueryCellInfo` event, you can rotate the header text of the column header in the excel exported document.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/excel-export/header-rotate/razor %}
{% endhighlight %}
{% highlight c# tabtitle="header-rotate.cs" %}
{% include code-snippet/grid/excel-export/header-rotate/header-rotate.cs %}
{% endhighlight %}
{% endtabs %}

![Customizing columns on export](../images/excel-exporting/exceloption-rotate.png)

## Conditional cell formatting

When exporting data from the Grid, you have an option to conditionally format the cells in the exported Excel document. This allows you to customize the appearance of specific cells based on their values or other criteria.

To achieve this feature, you need to use the [ExcelQueryCellInfo](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ExcelQueryCellInfo) event of the Grid component. This event is triggered for each cell during the export process to Excel. Within this event, you can access the cell object using the `args.Cell` property and modify its properties, such as the background color, based on your desired conditions.

The following example demonstrate how to customize the background color of the Freight column in the exported Excel document using the **args.cell** and **backgroundColor** properties of the `ExcelQueryCellInfo` event.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/excel-export/cell-format/razor %}
{% endhighlight %}
{% highlight c# tabtitle="cell-format.cs" %}
{% include code-snippet/grid/excel-export/cell-format/cell-format.cs %}
{% endhighlight %}
{% endtabs %}

![Conditional cell formatting](../images/excel-exporting/exceloption-cell-format.png)

## Adding header and footer in the exported Excel file

The Excel or CSV Export feature in Grid component allows you to include header and footer content in the exported Excel or CSV document. This feature is particularly useful when you want to add additional information or branding to the exported Excel or CSV file.

To achieve this, you can use [ToolbarClick](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ToolbarClick) event along with defining the `Header` and `Footer` properties in the `ExcelExportProperties` object allowing you to customize the header and footer content.

The following example demonstrates how to add a header and footer to the exported grid:

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/excel-export/header-footer/razor %}
{% endhighlight %}
{% highlight c# tabtitle="header-footer.cs" %}
{% include code-snippet/grid/excel-export/header-footer/header-footer.cs %}
{% endhighlight %}
{% endtabs %}

![Adding header and footer](../images/excel-exporting/exceloption-header-footer.gif)

## Export grid as blob

The Grid offers an option to export the data as a Blob instead of downloading it as a file in the browser. To export the grid as a Blob, set the `isBlob` parameter to **true** in the `excelExport` method. The grid returns the promise of a blob in the [ExcelExportComplete](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ExcelExportComplete) event.

The following example demonstrates how to obtain the blob data of the exported grid by executing the promise in the `ExcelExportComplete` event.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/excel-export/export-grid-as-blob/razor %}
{% endhighlight %}
{% highlight c# tabtitle="excel-option.cs" %}
{% include code-snippet/grid/excel-export/export-grid-as-blob/excel-option.cs %}
{% endhighlight %}
{% endtabs %}