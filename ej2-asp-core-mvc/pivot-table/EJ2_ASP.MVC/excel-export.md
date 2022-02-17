---
layout: post
title: Excel Export in ##Platform_Name## Pivot Table Component
description: Learn here all about Excel Export in Syncfusion ##Platform_Name## Pivot Table component and more.
platform: ej2-asp-core-mvc
control: Excel Export
publishingplatform: ##Platform_Name##
documentation: ug
---


# Excel Export

The Excel export allows Pivot Table data to be exported as Excel document. To enable Excel export in the pivot table, set the [`AllowExcelExport`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_AllowExcelExport) property in [`PivotView`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotView.html) class to **true**. Once the API is set, user needs to call the `excelExport` method for exporting on external button click.

> The pivot table component can be exported to Excel format using options available in the toolbar. For more details [`refer`](./tool-bar) here.

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



## Multiple pivot table exporting

The Excel export provides an option to export multiple pivot table data in the same Excel file.

### Same WorkSheet

The Excel export provides support to export multiple pivot tables in same sheet. To export in same sheet, define `multipleExport.type` as `AppendToSheet` in `excelExportProperties`. It has an option to provide blank rows between pivot tables and these blank row(s) count can be defined using the`multipleExport.blankRows` property.

>By default, `multipleExport.blankRows` value is 5 between pivot table's within the same sheet.

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



### New WorkSheet

Excel export provides support to export multiple pivot tables into new sheets. To export in new sheets, define  `multipleExport.type` as `NewSheet` in `excelExportProperties`.

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



## Changing the pivot table style while exporting

The Excel export provides an option to change colors for headers, caption and records in pivot table before exporting. In-order to apply colors, define **theme** settings in **excelExportProperties** object and pass it as a parameter to the `excelExport` method.

>By default, material theme is applied to exported Excel document.

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



## Add header and footer while exporting

The Excel export provides an option to include header and footer content for the excel document before exporting. In-order to add header and footer, define **header** and **footer** properties in **excelExportProperties** object and pass it as a parameter to the `excelExport` method.

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



## Changing the file name while exporting

The Excel export provides an option to change file name of the document before exporting. In-order to change the file name, define **fileName** property in **excelExportProperties** object and pass it as a parameter to the `excelExport` method.

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



## CSV Export

Also, the Excel export allows pivot table data to be exported in `CSV` file format. To export pivot table in `CSV` file format, you need to use the `csvExport` method.

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



## Virtual Scroll Data

You can export the pivot table virtual scroll data as Excel/CSV document by using PivotEngine export without any performance degradation. To enable PivotEngine export in the pivot table, set the [`AllowExcelExport`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_AllowExcelExport) as true. You need to use the `exportToExcel` method for PivotEngine export.

> PivotEngine export will be performed while enabling virtual scrolling by default.

### Virtual Scroll Data Excel Export

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/excel-export/engine-export/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Export.cs" %}
{% include code-snippet/pivot-table/excel-export/engine-export/Export.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/excel-export/engine-export/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Export.cs" %}
{% include code-snippet/pivot-table/excel-export/engine-export/Export.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Virtual Scroll Data CSV Export

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/excel-export/engine-csv-export/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="CSVExport.cs" %}
{% include code-snippet/pivot-table/excel-export/engine-csv-export/CSVExport.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/excel-export/engine-csv-export/razor %}
{% endhighlight %}
{% highlight c# tabtitle="CSVExport.cs" %}
{% include code-snippet/pivot-table/excel-export/engine-csv-export/CSVExport.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Export all pages

The pivot engine exports the entire virtual data of the pivot table (i.e. the data that contains all of the records used to render the complete pivot table) as an Excel/CSV document. To export just the current viewport of the pivot table, set the [`exportAllPages`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_ExportAllPages) property to **false**. To use the pivot engine export, add the `ExcelExport` module into the pivot table.

> By default, the pivot engine export will be performed while virtual scrolling is enabled.

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

The event `ExcelQueryCellInfo` triggers while framing each row and value cell during Excel export. It allows the user to customize the cell value, style etc. of the current cell. It has the following parameters:

* `value` - It holds the cell value.
* `column` -  It holds column information for the current cell.
* `data` - It holds the entire row data across the current cell.
* `style`  - It holds the style properties for the cell.

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

The event `ExcelHeaderQueryCellInfo` triggers on framing each header cell during Excel export. It allows the user to customize the cell value, style etc. of the current cell. It has the following parameters:

* `cell` - It holds the current cell information.
* `style`  -  It holds the style properties for the cell.

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



## See Also

* [PDF Exporting](./pdf-export)