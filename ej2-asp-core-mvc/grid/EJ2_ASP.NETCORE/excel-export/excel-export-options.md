---
layout: post
title: Excel Export Options in Syncfusion ##Platform_Name## Grid Control | Syncfusion
description: Learn here all about Excel Export Options in Syncfusion ##Platform_Name## Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Excel Export Options
publishingplatform: ##Platform_Name##
documentation: ug
---



# Excel Export Options in ASP.NET Core Grid Control

The excel export provides an option to customize mapping of the grid to excel document.

## Export current page

The excel export provides an option to export the current page into excel. To export current page, define **exportType** to **currentpage**.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/excel-export/export-current/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Export-current.cs" %}
{% include code-snippet/grid/excel-export/export-current/export-current.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/excel-export/export-current/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Export-current.cs" %}
{% include code-snippet/grid/excel-export/export-current/export-current.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Export the selected records only

You can export the selected records data by passing it to **exportProperties.dataSource** Property in the [`toolbarClick`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ToolbarClick) event.

In the below exporting demo, We can get the selected records using **getSelectedRecords** method and pass the selected data to **PdfExport** or **excelExport** property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/how-to/export-selected-data/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Selected-data.cs" %}
{% include code-snippet/grid/how-to/export-selected-data/selected-data.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/how-to/export-selected-data/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Selected-data.cs" %}
{% include code-snippet/grid/how-to/export-selected-data/selected-data.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Export hidden columns

The excel export provides an option to export hidden columns of grid by defining **includeHiddenColumn** as **true**.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/excel-export/export-hidden/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Export-hidden.cs" %}
{% include code-snippet/grid/excel-export/export-hidden/export-hidden.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/excel-export/export-hidden/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Export-hidden.cs" %}
{% include code-snippet/grid/excel-export/export-hidden/export-hidden.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Show or hide columns

You can show a hidden column or hide a visible column while printing the grid using [`toolbarClick`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ToolbarClick) and [`excelExportComplete`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ExcelExportComplete) events.

In the [`toolbarClick`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ToolbarClick) event, based on **args.item.id** as **Grid_excelexport**. We can show or hide columns by setting [`visible`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_Visible) property of **e-grid-column** tag helper to **true** or **false** respectively.

In the [`excelExportComplete`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ExcelExportComplete) event, We have reversed the state back to the previous state.

In the below example, we have **CustomerID** as a hidden column in the grid. While exporting, we have changed **CustomerID** to visible column and **ShipCity** as hidden column.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/excel-export/show-hide/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Show-hide.cs" %}
{% include code-snippet/grid/excel-export/show-hide/show-hide.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/excel-export/show-hide/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Show-hide.cs" %}
{% include code-snippet/grid/excel-export/show-hide/show-hide.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Export with filter options

The excel export provides an option to export with filter option in excel by defining `enableFilter` as **true**. It requires the [`allowFiltering`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_AllowFiltering) to be true.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/excel-export/enable-filter/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Enable-filter.cs" %}
{% include code-snippet/grid/excel-export/enable-filter/enable-filter.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/excel-export/enable-filter/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Enable-filter.cs" %}
{% include code-snippet/grid/excel-export/enable-filter/enable-filter.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Exporting grouped records

The excel export provides outline option for grouped records which hides the detailed data for better viewing. In grid, we have provided the outline option for the exported document when the data's are grouped.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/excel-export/excel-group/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Excel-group.cs" %}
{% include code-snippet/grid/excel-export/excel-group/excel-group.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/excel-export/excel-group/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Excel-group.cs" %}
{% include code-snippet/grid/excel-export/excel-group/excel-group.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Define file name

You can assign the file name for the exported document by defining **fileName** property in **ExcelExportProperties**.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/excel-export/export-filename/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Export-filename.cs" %}
{% include code-snippet/grid/excel-export/export-filename/export-filename.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/excel-export/export-filename/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Export-filename.cs" %}
{% include code-snippet/grid/excel-export/export-filename/export-filename.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


## Export the master detail grid

It is possible to export the master-detail grid on the same Excel sheet using the `ExcelExportProperties` class in the grid.

To export the master-detail grid on the same sheet in the following sample, you need to set the `multipleExport.type` to `AppendToSheet` in the exportProperties. A promise object is created by exporting the master grid first, and then the detail grid is exported after the master grid has been successfully exported.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/excel-export/masterdetailgrid/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Master-Detail.cs" %}
{% include code-snippet/grid/excel-export/masterdetailgrid/masterdetailgrid.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/excel-export/masterdetailgrid/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Master-Detail.cs" %}
{% include code-snippet/grid/excel-export/masterdetailgrid/masterdetailgrid.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Export grid as blob

The Grid offers an option to export the data as a Blob instead of downloading it as a file in the browser. To export the grid as a Blob, set the `isBlob` parameter to **true** in the [excelExport](https://ej2.syncfusion.com/documentation/api/grid/#excelexport) method. The grid returns the promise of a blob in the [excelExportComplete](https://ej2.syncfusion.com/documentation/api/grid/#excelexportcomplete) event.

The following example demonstrates how to obtain the blob data of the exported grid by executing the promise in the `excelExportComplete` event.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/excel-export/export-grid-as-blob/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Export-blob.cs" %}
{% include code-snippet/grid/excel-export/export-grid-as-blob/export-blob.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/excel-export/export-grid-as-blob/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Export-blob.cs" %}
{% include code-snippet/grid/excel-export/export-grid-as-blob/export-blob.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}