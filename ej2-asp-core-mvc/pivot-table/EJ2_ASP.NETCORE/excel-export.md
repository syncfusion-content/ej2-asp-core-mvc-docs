---
layout: post
title: Excel Export in ##Platform_Name## Syncfusion Pivot Table component
description: Learn here all about Excel Export in Syncfusion ##Platform_Name## Pivot Table component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Excel Export
publishingplatform: ##Platform_Name##
documentation: ug
---


# Excel Export in ##Platform_Name## Pivot Table component

The Pivot Table component supports exporting pivot data to **Excel** and **CSV** file formats. This enables data sharing and analysis in spreadsheet applications such as Microsoft Excel, Google Sheets, and more. To enable the export functionality, set the [`allowExcelExport`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_AllowExcelExport) property of the [`ejs-pivotview`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html) tag to **true**.

## Export data to an Excel file

Pivot Table data can be exported to an Excel file (.xlsx format) while preserving all formatting and structure. This format is compatible with Microsoft Excel and other spreadsheet applications. To export the data to Excel, invoke the `excelExport` method.

N> The pivot table component can be exported to Excel format using options available in the toolbar. For more details [`refer`](./tool-bar) here.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/excel-export/export/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Export.cs" %}
{% include code-snippet/pivot-table/excel-export/export/Export.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/excel-export/export/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Export.cs" %}
{% include code-snippet/pivot-table/excel-export/export/Export.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Excel Exporting](images/excel-exporting.png)

## Export data to a CSV file

Pivot Table data can be exported to a plain text CSV file. The CSV format is lightweight and compatible with most spreadsheet and data analysis applications. To export the data to CSV, invoke the `csvExport` method.

N> The pivot table component can be exported to CSV format using options available in the toolbar. For more details [`refer`](./tool-bar) here.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/excel-export/csv-export/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="CSVExport.cs" %}
{% include code-snippet/pivot-table/excel-export/csv-export/CSVExport.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/excel-export/csv-export/razor %}
{% endhighlight %}
{% highlight c# tabtitle="CSVExport.cs" %}
{% include code-snippet/pivot-table/excel-export/csv-export/CSVExport.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![CSV Exporting](images/CSV-exporting.png)

## Exporting multiple pivot tables

Multiple Pivot Tables can be exported to a single Excel file, allowing for side-by-side comparison on the same or different worksheets. Each Pivot Table must be rendered with a unique HTML element ID. For example, **PivotTable1** for the first table and **PivotTable2** for the second. To export both Pivot Tables to a single Excel file, provide their IDs in the `pivotTableIds` property of the `excelExportProperties`.

### Exporting to the same worksheet

Data from multiple Pivot Tables can be organized in a single view by exporting them to the same worksheet. Set the **multipleExport.type** property to **AppendToSheet** in the `excelExportProperties`, which will append each Pivot Table to the same sheet.

To add visual separation between Pivot Tables, use the **multipleExport.blankRows** property to specify the number of blank rows to insert between them. This helps maintain readability when multiple Pivot Tables are added in a single worksheet. After configuring these options, call the `excelExport` method with the `isMultipleExport` parameter set to **true**.

> By default, the **multipleExport.blankRows** property is set to **5** blank rows.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/excel-export/samesheet-export/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="SameSheetExport.cs" %}
{% include code-snippet/pivot-table/excel-export/samesheet-export/SameSheetExport.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/excel-export/samesheet-export/razor %}
{% endhighlight %}
{% highlight c# tabtitle="SameSheetExport.cs" %}
{% include code-snippet/pivot-table/excel-export/samesheet-export/SameSheetExport.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Exporting to same worksheet](images/exporting-to-same-worksheet.png)

### Exporting to a new worksheet

Multiple Pivot Tables can be organized into separate worksheets within a single Excel file for better structured data management. Set the **multipleExport.type** property to **NewSheet** in the `excelExportProperties`. Each Pivot Table will be exported to its own dedicated worksheet. After configuring these options, call the `excelExport` method with the `isMultipleExport` parameter set to **true**.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/excel-export/newsheet-export/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="NewSheetExport.cs" %}
{% include code-snippet/pivot-table/excel-export/newsheet-export/NewSheetExport.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/excel-export/newsheet-export/razor %}
{% endhighlight %}
{% highlight c# tabtitle="NewSheetExport.cs" %}
{% include code-snippet/pivot-table/excel-export/newsheet-export/NewSheetExport.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Exporting to new worksheet](images/exporting-to-new-worksheet.gif)

## Customize the pivot report during export

Pivot Table report settings can be customized before exporting, such as applying filters, adding formatting, or performing drill-down and drill-up operations. These customizations are applied exclusively to the exported file and do not affect the Pivot Table UI. To customize the export behavior, use the [`beforeExport`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_BeforeExport) event, which is triggered before the export operation begins.

In the following example, the [`beforeExport`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_BeforeExport) event is used to expand all Pivot Table headers by setting the [`expandAll`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_ExpandAll) property to **true**. The `generateGridData` method is then called to obtain the updated [`pivotValues`](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.pivotview.pivotview.html#Syncfusion_EJ2_PivotView_PivotView_PivotValues). The updated [`pivotValues`](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.pivotview.pivotview.html#Syncfusion_EJ2_PivotView_PivotView_PivotValues) are assigned to `args.dataCollections` for the export. Finally, [`expandAll`](https://ej2.syncfusion.com/javascript/documentation/api/pivotview/datasourcesettingsmodel#expandall) is set to **false** again to restore the original state of the Pivot Table.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/excel-export/customizing-pivot-report/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="CustomizingPivotReport.cs" %}
{% include code-snippet/pivot-table/excel-export/customizing-pivot-report/CustomizingPivotReport.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/excel-export/customizing-pivot-report/razor %}
{% endhighlight %}
{% highlight c# tabtitle="CustomizingPivotReport.cs" %}
{% include code-snippet/pivot-table/excel-export/customizing-pivot-report/CustomizingPivotReport.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Customize the pivot report](images/customizing-pivot-report.png)

## Export with custom aggregates

The Pivot Table supports exporting data with custom calculations beyond the default options such as **Sum**, **Count**, or **Average**. Custom aggregates enable advanced analytical scenarios where standard calculations are insufficient.

To add custom aggregates, follow these steps:

1.  Define custom aggregate names using the [localization](https://ej2.syncfusion.com/aspnetcore/documentation/pivot-table/globalization-and-localization#localization) option. These names will appear in the Pivot Table's aggregation menu.
2.  Add the custom aggregation types to the aggregate menu during Pivot Table initialization using the [`dataBound`](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.pivotview.pivotview.html#Syncfusion_EJ2_PivotView_PivotView_DataBound) event.
3.  Use the [`aggregateCellInfo`](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.pivotview.pivotview.html#Syncfusion_EJ2_PivotView_PivotView_AggregateCellInfo) event to specify the calculation logic for each custom type. This event is triggered for every aggregate cell, allowing you to apply your custom formulas.
4.  Finally, call the `excelExport` method to export the Pivot Table with all custom aggregations applied.

For detailed information about adding custom aggregation types, refer to the [custom aggregation documentation](./how-to/add-custom-aggregation-type-in-menu).

The following example demonstrates how to add two custom aggregate types to the aggregate menu: **CustomAggregateType 1**, which calculates a weighted average, and **CustomAggregateType 2**, which calculates the percentage of the total.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/excel-export/custom-aggregate-export/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="CustomAggregateExport.cs" %}
{% include code-snippet/pivot-table/excel-export/custom-aggregate-export/CustomAggregateExport.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/excel-export/custom-aggregate-export/razor %}
{% endhighlight %}
{% highlight c# tabtitle="CustomAggregateExport.cs" %}
{% include code-snippet/pivot-table/excel-export/custom-aggregate-export/CustomAggregateExport.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Export with custom aggregates](images/custom-aggregate-export.png)

## Export with custom date format

The Pivot Table component allows applying custom date formatting to date-type fields added to the **row** and **column** axes. This formatting ensures consistency across both the rendered pivot table and the exported file. Custom date formatting can be applied by configuring the [`e-formatsettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewFormatSetting.html) property using the following steps:

1. Set the [`name`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewFormatSetting.html#Syncfusion_EJ2_PivotView_PivotViewFormatSetting_Name) property to the target date field.
2. Set the [`type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewFormatSetting.html#Syncfusion_EJ2_PivotView_PivotViewFormatSetting_Type) property to **date** to identify the field as a date type.
3. Set the [`format`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewFormatSetting.html#Syncfusion_EJ2_PivotView_PivotViewFormatSetting_Format) property to the desired date format pattern (for example, `"EEE, MMM d, ''yy"`)

After configuration, call the `excelExport` method to export the Pivot Table with the applied formatting.

The following example demonstrates exporting a Pivot Table with a custom date format. The **Date** field uses the pattern `"EEE, MMM d, ''yy"`, which displays dates in the format: day-of-the-week abbreviation, month abbreviation, day, and two-digit year (for example, Sun, May 8, '23).

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/excel-export/custom-date-export/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="CustomDateExport.cs" %}
{% include code-snippet/pivot-table/excel-export/custom-date-export/CustomDateExport.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/excel-export/custom-date-export/razor %}
{% endhighlight %}
{% highlight c# tabtitle="CustomDateExport.cs" %}
{% include code-snippet/pivot-table/excel-export/custom-date-export/CustomDateExport.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Export with custom date format](images/custom-date-export.png)

## Remove row header during export

Row headers can be excluded from the exported Excel file when only values and column headers are required. To achieve this, use the [`beforeExport`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_BeforeExport) event to access pivot values through `args.dataCollections` and remove the row headers before exporting.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/excel-export/export-without-row-header/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ExportWithoutRowHeaders.cs" %}
{% include code-snippet/pivot-table/excel-export/export-without-row-header/ExportWithoutRowHeaders.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/excel-export/export-without-row-header/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ExportWithoutRowHeaders.cs" %}
{% include code-snippet/pivot-table/excel-export/export-without-row-header/ExportWithoutRowHeaders.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Export Without RowHeaders](images/export-without-row-header.png)

## Exclude Hidden Columns During Export

By default, all columns in the Pivot Table, including hidden ones, are exported. To exclude hidden columns, set the `includeHiddenColumn` property to **false** in `excelExportProperties`.

To hide a column, use the [`columnRender`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewGridSettings.html#Syncfusion_EJ2_PivotView_PivotViewGridSettings_ColumnRender) event in [`e-gridSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewGridSettings.html) to set the `visible` property of the target column to **false**. For more information, see the [Hide Specific Columns in Pivot Table](./how-to/hide-specific-columns-in-pivot-table) documentation.

After hiding the columns, set `includeHiddenColumn` to **false** in `excelExportProperties` to exclude them from the exported file. The exported file will then match the column structure displayed in the Pivot Table UI.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/excel-export/exclude-hidden-columns/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ExcludeHiddenColumns.cs" %}
{% include code-snippet/pivot-table/excel-export/exclude-hidden-columns/ExcludeHiddenColumns.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/excel-export/exclude-hidden-columns/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ExcludeHiddenColumns.cs" %}
{% include code-snippet/pivot-table/excel-export/exclude-hidden-columns/ExcludeHiddenColumns.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Rotate cell text during export

The style of each cell in the exported file can be customized, including rotating text, changing background colors, and applying other visual modifications. This approach is useful for creating visually distinct Pivot Table and for fitting text within limited space.

To rotate text, use the following events:

*   [`excelHeaderQueryCellInfo`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewGridSettings.html#Syncfusion_EJ2_PivotView_PivotViewGridSettings_ExcelHeaderQueryCellInfo): Triggered for column headers. This event is used to customize column header cell styles.
*   [`excelQueryCellInfo`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewGridSettings.html#Syncfusion_EJ2_PivotView_PivotViewGridSettings_ExcelQueryCellInfo): Triggered for row and value cells. This event is used to customize row header and value cell styles.

Within these events, set the `rotation` property in the `style` argument to rotate the text to the desired angle.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/excel-export/rotate-cell-text/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="RotateCellText.cs" %}
{% include code-snippet/pivot-table/excel-export/rotate-cell-text/RotateCellText.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/excel-export/rotate-cell-text/razor %}
{% endhighlight %}
{% highlight c# tabtitle="RotateCellText.cs" %}
{% include code-snippet/pivot-table/excel-export/rotate-cell-text/RotateCellText.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Apply custom styles based on specific conditions

When exporting Pivot Table data to Excel, custom styles can be applied to cells based on their values or other criteria. To apply custom styles, use the [`excelQueryCellInfo`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewGridSettings.html#Syncfusion_EJ2_PivotView_PivotViewGridSettings_ExcelQueryCellInfo) event. In this event, the cell information can be accessed through the `args.cell` property, and its style properties, such as `backColor`, `fontName`, and `fontColor`, can be customized.

The following example demonstrates how to apply conditional formatting to the **Sold** field values in the exported Excel document. Values below **1000** units are highlighted in **red**, while values of **1000** units or more are highlighted in **green**.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/excel-export/apply-custom-styles/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ApplyCustomStyles.cs" %}
{% include code-snippet/pivot-table/excel-export/apply-custom-styles/ApplyCustomStyles.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/excel-export/apply-custom-styles/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ApplyCustomStyles.cs" %}
{% include code-snippet/pivot-table/excel-export/apply-custom-styles/ApplyCustomStyles.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Apply Custom Styles](images/apply-custom-styles-while-export.png)

## Changing the pivot table style while exporting

The Excel export provides an option to change the colors of headers, captions, and records in a pivot table before exporting. To apply colors, define `theme` settings in `excelExportProperties` and pass it as a parameter to the `excelExport` method.

> By default, the material theme is applied to the exported Excel document.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/excel-export/theme-export/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ThemeExport.cs" %}
{% include code-snippet/pivot-table/excel-export/theme-export/ThemeExport.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/excel-export/theme-export/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ThemeExport.cs" %}
{% include code-snippet/pivot-table/excel-export/theme-export/ThemeExport.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Theme Export](images/theme-export.png)

## Add header and footer while exporting

The Excel export provides an option to include header and footer content in the Excel document before exporting. To add a header and footer, define the `header` and `footer` properties in `excelExportProperties` and pass them as parameters to the `excelExport` method.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/excel-export/header-footer/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ThemeExport.cs" %}
{% include code-snippet/pivot-table/excel-export/header-footer/ThemeExport.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/excel-export/header-footer/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ThemeExport.cs" %}
{% include code-snippet/pivot-table/excel-export/header-footer/ThemeExport.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Add header and footer](images/add-header-and-footer-while-exporting.png)

## Changing the file name while exporting

This option provides flexibility to specify a custom file name for your exported Excel document, making it easier to organize and identify your exported data. The Excel export provides an option to change the file name of the document before exporting. To change the file name, define the `fileName` property in the `excelExportProperties` object and pass it as a parameter to the `excelExport` method.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/excel-export/file-name/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="FileName.cs" %}
{% include code-snippet/pivot-table/excel-export/file-name/FileName.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/excel-export/file-name/razor %}
{% endhighlight %}
{% highlight c# tabtitle="FileName.cs" %}
{% include code-snippet/pivot-table/excel-export/file-name/FileName.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Changing the file name](images/changing-file-name.png)

## Show spinner during export

When exporting data, displaying a spinner provides visual feedback to end users that the export process is in progress. To show a spinner, invoke the `showWaitingPopup` method in the button's click event before calling the export method. After the export is complete, use the [`exportComplete`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_ExportComplete) event to trigger the `hideWaitingPopup` method, which will hide the spinner and indicate that the export has finished successfully.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/excel-export/show-spinner/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ShowSpinner.cs" %}
{% include code-snippet/pivot-table/excel-export/show-spinner/ShowSpinner.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/excel-export/show-spinner/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ShowSpinner.cs" %}
{% include code-snippet/pivot-table/excel-export/show-spinner/ShowSpinner.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Show spinner during export](images/show-spinner.png)

## Export only the current page

By default, the Pivot Table exports all data records, which can result in larger file sizes when a large data source is assigned to the Pivot Table. To improve performance, export only the data records currently visible in the viewport by setting the [`exportAllPages`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_ExportAllPages) property to **false**.

> This option is applicable only when the virtualization or paging feature is enabled.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/excel-export/exportallpages/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Exportallpages.cs" %}
{% include code-snippet/pivot-table/excel-export/exportallpages/exportallpages.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/excel-export/exportallpages/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Exportallpages.cs" %}
{% include code-snippet/pivot-table/excel-export/exportallpages/exportallpages.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Events

### ExcelQueryCellInfo

The [`excelQueryCellInfo`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewGridSettings.html#Syncfusion_EJ2_PivotView_PivotViewGridSettings_ExcelQueryCellInfo) event is triggered during the creation of each row and value cell while exporting data to Excel. This event offers options to change the content and style of individual cells in the exported Excel document, improving the flexibility and appearance of exported reports.

The event provides the following arguments:

* `value` – Represents the value of the current cell in the exported Excel sheet.
* `column` – Provides details about the column to which the current cell belongs.
* `data` – Contains all data for the row that includes the current cell.
* `style` – Defines the style settings (such as font, color, borders) applied to the current cell.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/grid-customization/excel-querycell/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ExcelQueryCell.cs" %}
{% include code-snippet/pivot-table/grid-customization/excel-querycell/ExcelQueryCell.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/grid-customization/excel-querycell/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ExcelQueryCell.cs" %}
{% include code-snippet/pivot-table/grid-customization/excel-querycell/ExcelQueryCell.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

### ExcelHeaderQueryCellInfo

The [`excelHeaderQueryCellInfo`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewGridSettings.html#Syncfusion_EJ2_PivotView_PivotViewGridSettings_ExcelHeaderQueryCellInfo) event provides the ability to modify header cell appearance and content during Excel export, ensuring exported documents match specific formatting requirements or business standards. This event triggers while processing each header cell during the Excel export operation. The event contains the following parameters:

* `cell` – Contains the current cell information and properties.
* `style` – Contains the style properties that can be applied to the cell.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/grid-customization/excel-headercell/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ExcelHeader.cs" %}
{% include code-snippet/pivot-table/grid-customization/excel-headercell/ExcelHeader.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/grid-customization/excel-headercell/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ExcelHeader.cs" %}
{% include code-snippet/pivot-table/grid-customization/excel-headercell/ExcelHeader.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

### ExportComplete

The [`exportComplete`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_ExportComplete) event triggers after the Pivot Table data exports to an Excel or CSV document. This event enables acquiring blob stream data for further processing and customization by setting the `isBlob` parameter to **true** when calling the `excelExport` method. The event includes the following parameters:

* `type` – Specifies the current export format such as PDF, Excel, or CSV.
* `promise` – Contains the promise object that resolves with blob data for the exported file.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/excel-export/blob-export/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Blob-export.cs" %}
{% include code-snippet/pivot-table/excel-export/blob-export/blob-export.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/excel-export/blob-export/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Blob-export.cs" %}
{% include code-snippet/pivot-table/excel-export/blob-export/blob-export.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Limitation when exporting millions of records to Excel format

Understanding this limitation helps you choose the appropriate export format based on your data size requirements and ensures optimal performance for large datasets. By default, Microsoft Excel supports only 1,048,576 records in an Excel sheet. Therefore, it is not possible to export millions of records to Excel format. You can refer to the [documentation link](https://support.microsoft.com/en-gb/office/excel-specifications-and-limits-1672b34d-7043-467e-8e27-269d656771c3) for more details on Microsoft Excel specifications and limits. For large datasets, it is recommended to export the data in CSV (Comma-Separated Values) or other formats that can handle large datasets more efficiently than Excel.

## See Also

* [PDF Exporting](./pdf-export)