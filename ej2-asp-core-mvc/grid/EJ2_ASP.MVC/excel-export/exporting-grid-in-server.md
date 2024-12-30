---
layout: post
title: Exporting Grid in Server in Syncfusion ##Platform_Name## Grid Component
description: Learn here all about Exporting Grid in Server in Syncfusion ##Platform_Name## Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Exporting Grid in Server
publishingplatform: ##Platform_Name##
documentation: ug
---

# Exporting grid in server in ASP.NET MVC Grid component

The Syncfusion Grid component in ASP.NET MVC provides a powerful option to export data to Excel on the server side using the Grid server export library. This allows you to perform Excel export operations on the server, providing additional security and flexibility. To enable server-side Excel exporting, you need to configure the server dependencies and implement the necessary server configuration.

## Server dependencies

To enable the server-side export functionality for the Syncfusion Grid component in ASP.NET MVC, you need to include the required dependencies for Grid server-side Excel exporting. These dependencies are essential for handling the export process on the server-side.

The server-side export functionality is provided in the **Syncfusion.EJ2.GridExport** package, which is available in Essential Studio and can also be obtained from [nuget.org](https://www.nuget.org/).

The following list of dependencies is required for Grid server-side Excel exporting action:

* **Syncfusion.EJ2**: This is the core package that includes the main components and functionalities of Syncfusion Essential JS 2.

* **Syncfusion.EJ2.GridExport**: This package contains the server-side export functionality specifically for the Grid component. It provides the necessary APIs and tools to handle data export to Excel on the server.

## Server configuration

To export the grid data to a Excel document on the server side, you need to perform the following server configuration using an ASP.NET MVC Controller Action:

1. Set up the necessary dependencies and imports in your server-side code.

2. Define a controller action that handles the server-side Excel export. This action should receive the Grid properties from the client-side and initiate the Excel export operation on the server.

3. Use the `serverExcelExport` method to pass the Grid properties to the server exporting action. This method allows you to specify the server action URL and other export options.

The following example shows server configuration using ASP.NET MVC Controller Action.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/excel-export/server-export/razor %}
{% endhighlight %}
{% highlight c# tabtitle="server-exportMVC.cs" %}
{% include code-snippet/grid/excel-export/server-export/server-exportMVC.cs %}
{% endhighlight %}
{% endtabs %}

![Server configuration](../images/excel-exporting/excel-export-server.png)

N> Refer to the GitHub sample for quick implementation and testing from [here](https://github.com/SyncfusionExamples/MVC-EJ2-Grid-server-side-exporting).

## CSV Export in server side

To perform CSV export on the server-side, you can use the `serverCsvExport` method, which sends the Grid properties to the server for processing and generating the CSV file.

To initiate the CSV export, you can invoke the `serverCsvExport` method within the [ToolbarClick](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ToolbarClick) event. Upon triggering the event, the server will deserialize the Grid properties and pass them to the `CsvExport` method, which will handle exporting the properties to the CSV format.

Here's an example of how you can accomplish CSV export on the server-side:

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/excel-export/server-csv-export/razor %}
{% endhighlight %}
{% highlight c# tabtitle="server-exportMVC.cs" %}
{% include code-snippet/grid/excel-export/server-csv-export/server-exportMVC.cs %}
{% endhighlight %}
{% endtabs %}

![CSV Export in server side](../images/excel-exporting/export-server-csv.png)

## Rotate a header text in the exported grid

The Grid provides support to customize the column header styles, including changing text orientation, font color, and other visual aspects, in the exported Excel file on the server-side. This feature is particularly useful when you want to enhance the appearance of the exported data and create a unique representation of the Grid in the Excel document.

To achieve this requirement, you can use the [ExcelHeaderQueryCellInfo](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ExcelHeaderQueryCellInfo) event of the Grid. This event is triggered when creating column headers for the Excel document to be exported on the server-side. In this event, you can collect the column header details and handle customizations.

In the following demo, using the `HeaderCellRotate` method of the `GridExcelExport` class in the [ServerExcelHeaderQueryCellInfo](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ServerExcelHeaderQueryCellInfo) event, you can rotate the header text of the column header in the excel exported document.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/excel-export/server-rotate-header/razor %}
{% endhighlight %}
{% highlight c# tabtitle="server-rotate-header.cs" %}
{% include code-snippet/grid/excel-export/server-rotate-header/server-rotate-header.cs %}
{% endhighlight %}
{% endtabs %}

![Rotate a header text in the exported grid](../images/excel-exporting/export-server-rotate.png)

## Limitations

* The export feature for detail and caption templates is not supported in server-side exporting.
* Multiple grids exporting feature is not supported with server side exporting.