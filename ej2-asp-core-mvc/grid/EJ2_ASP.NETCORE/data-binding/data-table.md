---
layout: post
title: DataTable in ##Platform_Name## Grid Component
description: Learn here all about DataTable in Syncfusion ##Platform_Name## Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: DataTable
publishingplatform: ##Platform_Name##
documentation: ug
---


# DataTable

DataTable represents a table with relational data which has in-built schema to work easily with data column and data row objects.

You can bind `DataTable` to the grid by using [`dataSource`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_DataSource) property. While binding DataTable like below, grid actions such as `Sorting`, `Filtering`, `Grouping`, `Paging` etc., will handle at client side.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/data-binding/datatable/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Datatable.cs" %}
{% include code-snippet/grid/data-binding/datatable/datatable.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/data-binding/datatable/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Datatable.cs" %}
{% include code-snippet/grid/data-binding/datatable/datatable.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> `DataTable` will be supported from .Net Core 2.0.

## DataTable with on-demand Grid actions

[`On-Demand grid actions`](#handling-on-demand-grid-actions/) helps you to improve performance for large data application. To perform server side grid actions for DataTable, you need to convert `DataTable` to `IEnumerable` using `Utils.DataTableToJson` method. Thereby in controller action, you need to use `DataOperations` class for performing grid actions and return result as JSON with `result` and `count` pair.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/data-binding/clientdatatable/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Dataoperation.cs" %}
{% include code-snippet/grid/data-binding/clientdatatable/dataoperation.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/data-binding/clientdatatable/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Dataoperation.cs" %}
{% include code-snippet/grid/data-binding/clientdatatable/dataoperation.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## DataTable with CRUD operations

To perform server side CRUD operations for DataTable, you need to use `InsertUrl`, `UpdateUrl` and `RemoveUrl` of `DataManager` for inserting, updating and deleting the records in the specified controller actions.

To pass the data from client side to server side when performing CRUD operations, you need to use `ExpandoObject` as a parameter for inserting and adding actions.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/data-binding/cruddatatable/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Dataoperation.cs" %}
{% include code-snippet/grid/data-binding/cruddatatable/dataoperation.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/data-binding/cruddatatable/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Dataoperation.cs" %}
{% include code-snippet/grid/data-binding/cruddatatable/dataoperation.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

