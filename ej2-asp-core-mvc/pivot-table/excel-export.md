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



## Customization during excel export

The Excel export provides an option to customize mapping of the pivot table to excel document.

### Theme

The Excel export provides an option to include theme for exported Excel document.

To apply theme in exported Excel, define the `theme` in `excelExportProperties`.

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



### To add header and footer

The Excel export provides an option to include header and footer content for the exported Excel document.

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



## See Also

* [PDF Exporting](./pdf-export)