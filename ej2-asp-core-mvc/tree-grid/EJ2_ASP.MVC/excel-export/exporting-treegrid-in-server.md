---
layout: post
title: Exporting Tree Grid in Server in Syncfusion ##Platform_Name## Tree Grid Component
description: Learn here all about Exporting Tree Grid in Server in Syncfusion ##Platform_Name## Tree Grid Component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Exporting TreeGrid in Server
publishingplatform: ##Platform_Name##
documentation: ug
---


# Exporting Tree Grid in Server

The Tree Grid have an option to export the data to Excel in server side using tree grid server export library.

## Server dependencies

The Server side export functionality is shipped in the Syncfusion.EJ2.TreeGridExport package, which is available in Essential Studio&reg; and [nuget.org](https://www.nuget.org/).The following list of dependencies is required for tree grid server side Excel exporting action.

* Syncfusion.EJ2
* Syncfusion.EJ2.TreeGridExport

## Server configuration

The following code snippet shows server configuration using ASP.NET Core Controller Action.

To Export the tree grid in server side, You need to call the [`serverExcelExport`](https://ej2.syncfusion.com/documentation/api/treegrid/#serverexcelexport) method for passing the tree grid properties to server exporting action.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/excel-export/server-export/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Server-exportCore.cs" %}
{% include code-snippet/tree-grid/excel-export/server-export/server-exportCore.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/excel-export/server-export/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Server-exportMvc.cs" %}
{% include code-snippet/tree-grid/excel-export/server-export/server-exportMvc.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## CSV Export in server side

You can export the tree grid to CSV format by using the [`serverCsvExport`](https://ej2.syncfusion.com/documentation/api/treegrid/#servercsvexport) method which will pass the tree grid properties to server.

In the below demo, we have invoked the above method inside the [`toolbarClick`](https://ej2.syncfusion.com/documentation/api/treegrid#toolbarclick) event. In server side, we have deserialized the tree grid properties and passed to the [`EXportToCsv`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.TreeGridExport.TreeGridExcelExport.html#Syncfusion_EJ2_TreeGridExport_TreeGridExcelExport_ExportToCsv__1_Syncfusion_EJ2_TreeGrid_TreeGrid_System_Collections_IEnumerable_Syncfusion_EJ2_TreeGridExport_ExcelExportProperties_) method which will export the properties to CSV format.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/excel-export/server-csv-export/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Server-exportCore.cs" %}
{% include code-snippet/tree-grid/excel-export/server-csv-export/server-exportCore.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/excel-export/server-csv-export/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Server-exportMvc.cs" %}
{% include code-snippet/tree-grid/excel-export/server-csv-export/server-exportMvc.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Rotate a header text to a certain degree in the exported tree grid on the server side

The Tree Grid has support to customize the column header styles such as changing text orientation, the font color, and so on in the exported Excel file. To achieve this requirement, use the `ExcelHeaderCellRendering` event of the tree grid.

The `ExcelHeaderCellRendering` will be triggered when creating a column header for the excel document to be exported in the server side. Customize the column header in this event.

In the following demo, using the `HeaderCellRotate` method of the `TreeGridExcelExport` class in the `ExcelHeaderCellRendering` event, you can rotate the header text of the column header in the excel exported document.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/excel-export/server-rotate-header/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Server-RotateHeader.cs" %}
{% include code-snippet/tree-grid/excel-export/server-rotate-header/server-rotate-header.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/excel-export/server-rotate-header/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Server-RotateHeader.cs" %}
{% include code-snippet/tree-grid/excel-export/server-rotate-header/server-rotate-header.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}