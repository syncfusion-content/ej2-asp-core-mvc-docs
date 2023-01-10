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
* Syncfusion.Compression.Base
* Syncfusion.XlsIO.Base

## Server configuration

The following code snippets shows server configuration using ASP.NET MVC Controller Action.

To Export the Grid in server side, You need to call the [`serverExcelExport`](https://ej2.syncfusion.com/documentation/api/grid/#serverexcelexport) method for passing the Grid properties to server exporting action.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/excel-export/server-export/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Server-exportMVC.cs" %}
{% include code-snippet/grid/excel-export/server-export/server-exportMVC.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/excel-export/server-export/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Server-exportMVC.cs" %}
{% include code-snippet/grid/excel-export/server-export/server-exportMVC.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



N> Refer to the GitHub sample for quick implementation and testing from [here](https://github.com/SyncfusionExamples/MVC-EJ2-Grid-server-side-exporting).

## CSV export in server

You can export the Grid to CSV format by using the [`serverCsvExport`](https://ej2.syncfusion.com/documentation/api/grid/#servercsvexport) method which will pass the Grid properties to server.

In the below demo, we have invoked the above method inside the [`toolbarClick`](https://ej2.syncfusion.com/documentation/api/grid/#toolbarclick) event. In server side, we have deserialized the Grid properties and passed to the `CsvExport` method which will export the properties to CSV format.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/excel-export/server-csv-export/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Server-exportMVC.cs" %}
{% include code-snippet/grid/excel-export/server-csv-export/server-exportMVC.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/excel-export/server-csv-export/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Server-exportMVC.cs" %}
{% include code-snippet/grid/excel-export/server-csv-export/server-exportMVC.cs %}
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

