---
layout: post
title: ##Platform_Name## TreeGrid Aggregates | Syncfusion
description: Learn how to configure, display, and customize aggregate values in ##Platform_Name## TreeGrid, including built-in aggregate types and child aggregation.
platform: ej2-asp-core-mvc
control: Aggregates
publishingplatform: ##Platform_Name##
documentation: ug
---


# Aggregates in ##Platform_Name## TreeGrid

Aggregate values are displayed in the TreeGrid footer and in parent row footer for child row aggregate values. It can be configured through [`e-treegrid-aggregates`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.TreeGrid.TreeGridAggregate.html) property. The [`field`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.TreeGrid.TreeGridAggregateColumn.html#Syncfusion_EJ2_TreeGrid_TreeGridAggregateColumn_Field) and [`type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.TreeGrid.TreeGridAggregateColumn.html#Syncfusion_EJ2_TreeGrid_TreeGridAggregateColumn_Type) are the minimum properties of [`e-treegrid-aggregate-column`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.TreeGrid.TreeGridAggregate.html) required to represent an aggregate column.

By default, the aggregate value can be displayed in the treegrid footer, and footer of child rows. To show the aggregate value in one of the cells, use the [`footerTemplate`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.TreeGrid.TreeGridAggregateColumn.html#Syncfusion_EJ2_TreeGrid_TreeGridAggregateColumn_FooterTemplate) property of [`e-treegrid-aggregate-column`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.TreeGrid.TreeGridAggregate.html) tag helper.

## Built-in aggregate types

The aggregate type should be specified in the [`type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.TreeGrid.TreeGridAggregateColumn.html#Syncfusion_EJ2_TreeGrid_TreeGridAggregateColumn_Type) property to configure an aggregate column.

The built-in aggregates are,
* Sum
* Average
* Min
* Max
* Count
* Truecount
* Falsecount

N> Multiple aggregates can be used for an aggregate column by setting the [`type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.TreeGrid.TreeGridAggregateColumn.html#Syncfusion_EJ2_TreeGrid_TreeGridAggregateColumn_Type) property with an array of aggregate types.
N> Multiple types for a column is supported only when one of the aggregate templates is used.

## Child aggregate

Aggregate value is calculated for child rows, and it is displayed in the parent row footer. Use the [`showChildSummary`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.TreeGrid.TreeGridAggregate.html#Syncfusion_EJ2_TreeGrid_TreeGridAggregate_ShowChildSummary) property to render the child rows aggregate value.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/aggregates/child-aggregate/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ChildAggregate.cs" %}
{% include code-snippet/tree-grid/aggregates/child-aggregate/childAggregate.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/aggregates/child-aggregate/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ChildAggregate.cs" %}
{% include code-snippet/tree-grid/aggregates/child-aggregate/childAggregate.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



N> You can refer to our  [`ASP.NET Core Tree Grid`](https://www.syncfusion.com/aspnet-core-ui-controls/tree-grid) feature tour page for its groundbreaking feature representations. You can also explore our ASP.NET Core Tree Grid example [`ASP.NET Core Tree Grid example`](https://ej2.syncfusion.com/aspnetcore/treegrid/overview#/fluent2) to knows how to present and manipulate data.