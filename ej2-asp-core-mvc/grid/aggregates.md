---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Aggregates of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Aggregates
publishingplatform: ##Platform_Name##
documentation: ug
---


# Aggregates

Aggregate values are displayed in the footer, group footer, or group caption of the Grid. It can be configured through `Aggregates` property.
 [`Field`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridAggregateColumn.html#Syncfusion_EJ2_Grids_GridAggregateColumn_Field) and
  [`Type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridAggregateColumn.html#Syncfusion_EJ2_Grids_GridAggregateColumn_Type)
 are the minimum properties required to represent an aggregate column.

By default, the aggregate value can be displayed in the footer, group, and caption cells. To show the aggregate value in one of the cells, use the [`FooterTemplate`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridAggregateColumn.html#Syncfusion_EJ2_Grids_GridAggregateColumn_FooterTemplate),
[`GroupFooterTemplate`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridAggregateColumn.html#Syncfusion_EJ2_Grids_GridAggregateColumn_GroupFooterTemplate),
 or [`GroupCaptionTemplate`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridAggregateColumn.html#Syncfusion_EJ2_Grids_GridAggregateColumn_GroupCaptionTemplate) property.

## Built-in aggregate types

The aggregate type should be specified in the [`Type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridAggregateColumn.html#Syncfusion_EJ2_Grids_GridAggregateColumn_Type) property to configure an aggregate column.

The built-in aggregates are,
* Sum
* Average
* Min
* Max
* Count
* TrueCount
* FalseCount

> * Multiple aggregates can be used for an aggregate column by setting the [`Type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridAggregateColumn.html#Syncfusion_EJ2_Grids_GridAggregateColumn_Type) property
with an array of aggregate types.
> * Multiple types for a column is supported only when one of the aggregate templates is used.

## Footer aggregate

Footer aggregate value is calculated for all the rows, and it is displayed in the footer cells. Use the [`FooterTemplate`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridAggregateColumn.html#Syncfusion_EJ2_Grids_GridAggregateColumn_FooterTemplate) property to render the aggregate value in footer cells.

{% if page.publishingplatform == "aspnet-core" %}
{% tabs %}
{% highlight %}
{% include_relative code-snippet/aggregate/footer-agg/footer-agg.cs %}
{% endhighlight %}
{% highlight %}
{% include_relative code-snippet/aggregate/footer-agg/taghelper %}
{% endhighlight %}
{% elsif page.publishingplatform == "aspnet-mvc" %}
{% highlight %} {% include_relative code-snippet/aggregate/footer-agg/footer-agg.cs %}
{% endhighlight %}
{% highlight %}
{% include_relative code-snippet/aggregate/footer-agg/razor %}
{% endhighlight %}
{% endtabs %}



> The aggregate values must be accessed inside the template using their corresponding [`Type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridAggregateColumn.html#Syncfusion_EJ2_Grids_GridAggregateColumn_Type) name.

## How to format aggregate value

You can format the aggregate value result by using the [`Format`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridAggregateColumn.html#Syncfusion_EJ2_Grids_GridAggregateColumn_Format) property.

{% if page.publishingplatform == "aspnet-core" %}
{% tabs %}
{% highlight %}
{% include_relative code-snippet/aggregate/format-agg/format-agg.cs %}
{% endhighlight %}
{% highlight %}
{% include_relative code-snippet/aggregate/format-agg/taghelper %}
{% endhighlight %}
{% elsif page.publishingplatform == "aspnet-mvc" %}
{% highlight %} {% include_relative code-snippet/aggregate/format-agg/format-agg.cs %}
{% endhighlight %}
{% highlight %}
{% include_relative code-snippet/aggregate/format-agg/razor %}
{% endhighlight %}
{% endtabs %}



## Group and caption aggregate

Group and caption aggregate values are calculated from the current group items.
If [`GroupFooterTemplate`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridAggregateColumn.html#Syncfusion_EJ2_Grids_GridAggregateColumn_GroupFooterTemplate) is provided, the aggregate values are displayed in the group footer cells; and if [`GroupCaptionTemplate`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridAggregateColumn.html#Syncfusion_EJ2_Grids_GridAggregateColumn_GroupCaptionTemplate)
 is provided, aggregate values are displayed in the group caption cells.

{% if page.publishingplatform == "aspnet-core" %}
{% tabs %}
{% highlight %}
{% include_relative code-snippet/aggregate/group-caption/group-caption.cs %}
{% endhighlight %}
{% highlight %}
{% include_relative code-snippet/aggregate/group-caption/taghelper %}
{% endhighlight %}
{% elsif page.publishingplatform == "aspnet-mvc" %}
{% highlight %} {% include_relative code-snippet/aggregate/group-caption/group-caption.cs %}
{% endhighlight %}
{% highlight %}
{% include_relative code-snippet/aggregate/group-caption/razor %}
{% endhighlight %}
{% endtabs %}



> The aggregate values must be accessed inside the template using their corresponding [`Type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridAggregateColumn.html#Syncfusion_EJ2_Grids_GridAggregateColumn_Type) name.

## Custom aggregate

To calculate the aggregate value with your own aggregate functions, use the custom aggregate option. To use custom aggregation, specify the [`Type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridAggregateColumn.html#Syncfusion_EJ2_Grids_GridAggregateColumn_Type) as `Custom`, and provide the custom aggregate function in the [`CustomAggregate`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridAggregateColumn.html#Syncfusion_EJ2_Grids_GridAggregateColumn_CustomAggregate) property.

The custom aggregate function will be invoked with different arguments for total and group aggregations.
* **Total aggregation**: The custom aggregate function will be called with the whole data and current [`AggregateColumn`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridAggregateColumn.html#Syncfusion_EJ2_Grids_GridAggregateColumn_ColumnName)
object.
* **Group aggregation**: This will be called with the current group details and [`AggregateColumn`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridAggregateColumn.html#Syncfusion_EJ2_Grids_GridAggregateColumn_ColumnName) object.

{% if page.publishingplatform == "aspnet-core" %}
{% tabs %}
{% highlight %}
{% include_relative code-snippet/aggregate/custom-agg/custom-agg.cs %}
{% endhighlight %}
{% highlight %}
{% include_relative code-snippet/aggregate/custom-agg/taghelper %}
{% endhighlight %}
{% elsif page.publishingplatform == "aspnet-mvc" %}
{% highlight %} {% include_relative code-snippet/aggregate/custom-agg/custom-agg.cs %}
{% endhighlight %}
{% highlight %}
{% include_relative code-snippet/aggregate/custom-agg/razor %}
{% endhighlight %}
{% endtabs %}



> To access the custom aggregate value inside the template, use the key as `Custom`.

## Reactive aggregate update

When using batch editing, the aggregate values will be refreshed on every cell save. The footer, group footer, and group caption aggregate values will be refreshed.

> Adding a new record to the grouped grid will not refresh the aggregate values.

{% if page.publishingplatform == "aspnet-core" %}
{% tabs %}
{% highlight %}
{% include_relative code-snippet/aggregate/reactive-agg-batch-edit/reactive-agg-batch-edit.cs %}
{% endhighlight %}
{% highlight %}
{% include_relative code-snippet/aggregate/reactive-agg-batch-edit/taghelper %}
{% endhighlight %}
{% elsif page.publishingplatform == "aspnet-mvc" %}
{% highlight %} {% include_relative code-snippet/aggregate/reactive-agg-batch-edit/reactive-agg-batch-edit.cs %}
{% endhighlight %}
{% highlight %}
{% include_relative code-snippet/aggregate/reactive-agg-batch-edit/razor %}
{% endhighlight %}
{% endtabs %}



### Refresh aggregates in inline edit mode

By default, reactive aggregate update is not supported by inline and dialog edit modes as it is not feasible to anticipate the value change event for every editor. But, you can refresh the aggregates manually in the inline edit mode using the refresh method of aggregate module.

In the following code, the input event for the Freight column editor has been registered and the aggregate value has been refreshed manually.

{% if page.publishingplatform == "aspnet-core" %}
{% tabs %}
{% highlight %}
{% include_relative code-snippet/aggregate/reactive-agg-inline-edit/reactive-agg-inline-edit.cs %}
{% endhighlight %}
{% highlight %}
{% include_relative code-snippet/aggregate/reactive-agg-inline-edit/taghelper %}
{% endhighlight %}
{% elsif page.publishingplatform == "aspnet-mvc" %}
{% highlight %} {% include_relative code-snippet/aggregate/reactive-agg-inline-edit/reactive-agg-inline-edit.cs %}
{% endhighlight %}
{% highlight %}
{% include_relative code-snippet/aggregate/reactive-agg-inline-edit/razor %}
{% endhighlight %}
{% endtabs %}

