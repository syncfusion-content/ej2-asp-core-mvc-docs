---
layout: post
title: Excel Exporting in ##Platform_Name## Grid Component
description: Learn here all about Excel Exporting in Syncfusion ##Platform_Name## Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Excel Exporting
publishingplatform: ##Platform_Name##
documentation: ug
---


# Excel Export

The excel export allows exporting Grid data to Excel document. You need to use the
 **ExcelExport** method for exporting. To enable Excel export in the grid, set the [`allowExcelExport`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_AllowExcelExport) property as true.

To use excel export, You need to define the **ExcelExport** in inbuild toolbar and define the [`toolbarClick`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ToolbarClick) event for exporting the Grid.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/excel-export/excel-export/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Excel-export.cs" %}
{% include code-snippet/grid/excel-export/excel-export/excel-export.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/excel-export/excel-export/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Excel-export.cs" %}
{% include code-snippet/grid/excel-export/excel-export/excel-export.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Show spinner while exporting

You can show/ hide spinner component while exporting the grid using **showSpinner**/ **hideSpinner** methods. You can use [`toolbarClick`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ToolbarClick) event to show spinner before exporting and hide a spinner in the [`pdfExportComplete`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_PdfExportComplete) or [`excelExportComplete`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ExcelExportComplete) event after the exporting.

In the [`toolbarClick`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ToolbarClick) event, based on the parameter **args.item.id** as **Grid_pdfexport** or **Grid_excelexport** we can call the **showSpinner** method from grid instance.

In the [`pdfExportComplete`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_PdfExportComplete) or [`excelExportComplete`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ExcelExportComplete) events, We can call the `hideSpinner` method.

In the below demo, we have rendered the default spinner component when exporting the grid.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/how-to/show-spinner-while-exporting/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Show-spinner.cs" %}
{% include code-snippet/grid/how-to/show-spinner-while-exporting/show-spinner.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/how-to/show-spinner-while-exporting/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Show-spinner.cs" %}
{% include code-snippet/grid/how-to/show-spinner-while-exporting/show-spinner.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Custom data source

The excel export provides an option to define datasource dynamically before exporting. To export data dynamically, define the **dataSource** in **exportProperties**.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/excel-export/custom-data/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-data.cs" %}
{% include code-snippet/grid/excel-export/custom-data/custom-data.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/excel-export/custom-data/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-data.cs" %}
{% include code-snippet/grid/excel-export/custom-data/custom-data.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Passing additional parameters to the server when exporting

You can pass the additional parameter in the [`query`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Query) property by invoking **addParams** method. In the [`toolbarClick`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ToolbarClick) event, you can define params as key and value pair so it will receive at the server side when exporting.

In the below example, we have passed **recordcount** as **12** using **addParams** method.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/how-to/passing-params-exporting/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Addtional-parameter.cs" %}
{% include code-snippet/grid/how-to/passing-params-exporting/addtional-parameter.cs %}
{% endhighlight %}
{% highlight c# tabtitle="Addtional-parameter.cs" %}
{% include code-snippet/grid/how-to/passing-params-exporting/addtional-parameter.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/how-to/passing-params-exporting/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Addtional-parameter.cs" %}
{% include code-snippet/grid/how-to/passing-params-exporting/addtional-parameter.cs %}
{% endhighlight %}
{% highlight c# tabtitle="Addtional-parameter.cs" %}
{% include code-snippet/grid/how-to/passing-params-exporting/addtional-parameter.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

