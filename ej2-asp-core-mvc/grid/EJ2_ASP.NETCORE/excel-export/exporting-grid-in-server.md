---
layout: post
title: Exporting Grid in Server in Syncfusion ##Platform_Name## Grid Component
description: Learn here all about Exporting Grid in Server in Syncfusion ##Platform_Name## Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Exporting Grid in Server
publishingplatform: ##Platform_Name##
documentation: ug
---


# Exporting Grid in Server

The Grid have an option to export the data to Excel in server side using Grid server export library.

## Server dependencies

The Server side export functionality is shipped in the Syncfusion.EJ2.GridExport package, which is available in Essential Studio and [nuget.org](https://www.nuget.org/).The following list of dependencies is required for Grid server side Excel exporting action.

* Syncfusion.EJ2
* Syncfusion.EJ2.GridExport

## Server configuration

The following code snippet shows server configuration using ASP.NET Core Controller Action.

To Export the Grid in server side, You need to call the [`serverExcelExport`](https://ej2.syncfusion.com/documentation/api/grid/#serverexcelexport) method for passing the Grid properties to server exporting action.

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



N> Refer to the GitHub sample for quick implementation and testing from [here](https://github.com/SyncfusionExamples/Grid-Server-side-export-ASP.Net-Core).

## CSV Export in server side

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


## Export grid as memory stream

The Grid offers an option to export the data as a Memory Stream instead of downloading it as a file in the browser. To obtain the Memory Stream of the exported grid, set the `IsMemoryStream` parameter to **true** in the [ExcelExport](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.GridExport.GridExcelExport.html#Syncfusion_EJ2_GridExport_GridExcelExport_ExcelExport__1_Syncfusion_EJ2_Grids_Grid_System_Collections_IEnumerable_Syncfusion_EJ2_GridExport_ExcelExportProperties_) and [CsvExport](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.GridExport.GridExcelExport.html#Syncfusion_EJ2_GridExport_GridExcelExport_CsvExport__1_Syncfusion_EJ2_Grids_Grid_System_Collections_IEnumerable_Syncfusion_EJ2_GridExport_ExcelExportProperties_) methods.

The following code demonstrates how to get the memory stream of exported grid.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/excel-export/server-export-ms/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Server-exportCore.cs" %}
{% include code-snippet/grid/excel-export/server-export-ms/server-exportCore.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/excel-export/server-export-ms/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Server-exportCore.cs" %}
{% include code-snippet/grid/excel-export/server-export-ms/server-exportCore.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Merge grid's memory stream with an existing stream

The [Essential XlsIO](https://help.syncfusion.com/file-formats/xlsio/overview) library is used to merge the multiple memory streams into a single stream.

In the following code, `ExcelEngine` is used to open the grid's and external XLSX file's stream as a workbook and copy all the worksheets from the source workbook to the destination workbook using the `AddCopy` method of WorkSheets.

To learn more about the merge option, please refer to this [documentation](https://help.syncfusion.com/file-formats/xlsio/working-with-excel-worksheet#move-or-copy-a-worksheet).

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

## Rotate a header text to a certain degree in the exported grid on the server side

The DataGrid has support to customize the column header styles such as changing text orientation, the font color, and so on in the exported Excel file. To achieve this requirement, use the `ServerExcelHeaderQueryCellInfo` event of the Grid.

The `ServerExcelHeaderQueryCellInfo` will be triggered when creating a column header for the excel document to be exported in the server side. Customize the column header in this event.

In the following demo, using the `HeaderCellRotate` method of the `GridExcelExport` class in the `ServerExcelHeaderQueryCellInfo` event, you can rotate the header text of the column header in the excel exported document.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/excel-export/server-rotate-header/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Server-RotateHeader.cs" %}
{% include code-snippet/grid/excel-export/server-rotate-header/server-rotate-header.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/excel-export/server-rotate-header/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Server-RotateHeader.cs" %}
{% include code-snippet/grid/excel-export/server-rotate-header/server-rotate-header.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Limitations

* The export feature for detail and caption templates is not supported in server-side exporting.
* Multiple grids exporting feature is not supported with server side exporting.
