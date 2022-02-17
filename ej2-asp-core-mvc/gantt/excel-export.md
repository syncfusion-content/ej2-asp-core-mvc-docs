---
layout: post
title: Excel Export in ##Platform_Name## Gantt Component
description: Learn here all about Excel Export in Syncfusion ##Platform_Name## Gantt component and more.
platform: ej2-asp-core-mvc
control: Excel Export
publishingplatform: ##Platform_Name##
documentation: ug
---


# Excel Export

Gantt supports client-side exporting, which allows you to export its data to the Excel and CSV formats. Use the `excelExport` and `csvExport` methods for exporting. To enable Excel export in the Gantt, set the [`AllowExcelExport`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Gantt.Gantt~AllowExcelExport.html) to true.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/excel-export/excelExport/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ExcelExport.cs" %}
{% include code-snippet/gantt/excel-export/excelExport/excelExport.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/excel-export/excelExport/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ExcelExport.cs" %}
{% include code-snippet/gantt/excel-export/excelExport/excelExport.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Multiple Gantt exporting

In Gantt, the Excel export provides support to export multiple Gantt data in new sheet or same sheet.

### Same sheet

The Excel export provides support to export multiple Gantt data in the same sheet. To export in same sheet, define `multipleExport.type` as `AppendToSheet` in `ExcelExportProperties`. You can also provide blank rows between exported multiple Gantt data. These blank rows count can be defined using `multipleExport.blankRows`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/excel-export/sameSheet/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="SameSheet.cs" %}
{% include code-snippet/gantt/excel-export/sameSheet/sameSheet.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/excel-export/sameSheet/razor %}
{% endhighlight %}
{% highlight c# tabtitle="SameSheet.cs" %}
{% include code-snippet/gantt/excel-export/sameSheet/sameSheet.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



>By default, `multipleExport.blankRows` value is 5.

### New sheet

The Excel exporting provides support to export multiple Gantt in new sheet. To export in new sheet, define `multipleExport.type` as `NewSheet` in `ExcelExportProperties`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/excel-export/newSheet/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="NewSheet.cs" %}
{% include code-snippet/gantt/excel-export/newSheet/newSheet.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/excel-export/newSheet/razor %}
{% endhighlight %}
{% highlight c# tabtitle="NewSheet.cs" %}
{% include code-snippet/gantt/excel-export/newSheet/newSheet.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Customize the Excel export

Gantt Excel export allows the users to customize the exported document based on requirement.

### Export hidden columns

In Gantt, the Excel export provides an option to export hidden columns by defining `includeHiddenColumn` as `true`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/excel-export/exportHiddenColumns/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ExportHiddenColumns.cs" %}
{% include code-snippet/gantt/excel-export/exportHiddenColumns/exportHiddenColumns.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/excel-export/exportHiddenColumns/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ExportHiddenColumns.cs" %}
{% include code-snippet/gantt/excel-export/exportHiddenColumns/exportHiddenColumns.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Show or hide columns on exported Excel

In Gantt, while exporting, you can show a hidden column or hide a visible column using the [`ToolbarClick`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Gantt.Gantt~ToolbarClick.html) and [`ExcelExportComplete`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Gantt.Gantt~ExcelExportComplete.html) events.

In the `ToolbarClick` event, using the `args.item.id` property, you can show or hide columns by setting the `Columns.Visible` property to `true` or `false` respectively.

Similarly, in the excelExportComplete event, you can revert the columns visibility back to the previous state.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/excel-export/showHideColumn/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ShowHideColumn.cs" %}
{% include code-snippet/gantt/excel-export/showHideColumn/showHideColumn.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/excel-export/showHideColumn/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ShowHideColumn.cs" %}
{% include code-snippet/gantt/excel-export/showHideColumn/showHideColumn.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Cell formatting during export

In Gantt, you can customize the TreeGrid cells in the exported document using the [`ExcelQueryCellInfo`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Gantt.Gantt~ExcelQueryCellInfo.html) event. In this event, you can format the TreeGrid cells of exported Excel and CSV documents based on the required condition.

In the following sample, the background color has been customized for `TaskId` column in the exported Excel using the `args.style` and `backColor` properties.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/excel-export/cellFormat/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="CellFormat.cs" %}
{% include code-snippet/gantt/excel-export/cellFormat/cellFormat.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/excel-export/cellFormat/razor %}
{% endhighlight %}
{% highlight c# tabtitle="CellFormat.cs" %}
{% include code-snippet/gantt/excel-export/cellFormat/cellFormat.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Theme

The Excel export also provides an option to include custom theme for exported Excel document.

To apply theme in exported Excel, define the `theme` in `ExcelExportProperties`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/excel-export/theme/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Theme.cs" %}
{% include code-snippet/gantt/excel-export/theme/theme.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/excel-export/theme/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Theme.cs" %}
{% include code-snippet/gantt/excel-export/theme/theme.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> By default, material theme is applied to the exported Excel document.

### Add header and footer

The Excel export also allows users to include header and footer contents to the exported Excel document.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/excel-export/headerFooter/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="HeaderFooter.cs" %}
{% include code-snippet/gantt/excel-export/headerFooter/headerFooter.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/excel-export/headerFooter/razor %}
{% endhighlight %}
{% highlight c# tabtitle="HeaderFooter.cs" %}
{% include code-snippet/gantt/excel-export/headerFooter/headerFooter.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### File name for exported document

You can set the required file name for the exported document by defining the `fileName` property in `ExcelExportProperties`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/excel-export/fileName/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="FileName.cs" %}
{% include code-snippet/gantt/excel-export/fileName/fileName.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/excel-export/fileName/razor %}
{% endhighlight %}
{% highlight c# tabtitle="FileName.cs" %}
{% include code-snippet/gantt/excel-export/fileName/fileName.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Custom data source

The excel export provides an option to define datasource dynamically before exporting. To export data dynamically, define the `dataSource` in `exportProperties`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/excel-export/customDataSource/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="CustomDataSource.cs" %}
{% include code-snippet/gantt/excel-export/customDataSource/customDataSource.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/excel-export/customDataSource/razor %}
{% endhighlight %}
{% highlight c# tabtitle="CustomDataSource.cs" %}
{% include code-snippet/gantt/excel-export/customDataSource/customDataSource.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

