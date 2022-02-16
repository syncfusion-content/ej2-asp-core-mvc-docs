---
layout: post
title: Aggregates in ##Platform_Name## Grid Component
description: Learn here all about Aggregates in Syncfusion ##Platform_Name## Grid component and more.
platform: ej2-asp-core-mvc
control: Aggregates
publishingplatform: ##Platform_Name##
documentation: ug
---


# Aggregates

Aggregate values are displayed in the footer, group footer, or group caption of the Grid. It can be configured through [`Aggregates`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Aggregates) property. The
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

> Multiple aggregates can be used for an aggregate column by setting the [`Type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridAggregateColumn.html#Syncfusion_EJ2_Grids_GridAggregateColumn_Type) property
with an array of aggregate types.
> Multiple types for a column is supported only when one of the aggregate templates is used.

## Footer aggregate

Footer aggregate value is calculated for all the rows, and it is displayed in the footer cells. Use the [`FooterTemplate`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridAggregateColumn.html#Syncfusion_EJ2_Grids_GridAggregateColumn_FooterTemplate) property to render the aggregate value in footer cells.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/aggregate/footer-agg/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Footer-agg.cs" %}
{% include code-snippet/grid/aggregate/footer-agg/footer-agg.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/aggregate/footer-agg/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Footer-agg.cs" %}
{% include code-snippet/grid/aggregate/footer-agg/footer-agg.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> The aggregate values must be accessed inside the template using their corresponding [`Type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridAggregateColumn.html#Syncfusion_EJ2_Grids_GridAggregateColumn_Type) name.

## How to format aggregate value

You can format the aggregate value result by using the [`Format`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridAggregateColumn.html#Syncfusion_EJ2_Grids_GridAggregateColumn_Format) property of [`GridAggregate Column`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridAggregateColumn.html).

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/aggregate/format-agg/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Format-agg.cs" %}
{% include code-snippet/grid/aggregate/format-agg/format-agg.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/aggregate/format-agg/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Format-agg.cs" %}
{% include code-snippet/grid/aggregate/format-agg/format-agg.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Group and caption aggregate

Group and caption aggregate values are calculated from the current group items.
If [`GroupFooterTemplate`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridAggregateColumn.html#Syncfusion_EJ2_Grids_GridAggregateColumn_GroupFooterTemplate) is provided, the aggregate values are displayed in the group footer cells; and if [`GroupCaptionTemplate`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridAggregateColumn.html#Syncfusion_EJ2_Grids_GridAggregateColumn_GroupCaptionTemplate)
 is provided, aggregate values are displayed in the group caption cells.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/aggregate/group-caption/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Group-caption.cs" %}
{% include code-snippet/grid/aggregate/group-caption/group-caption.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/aggregate/group-caption/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Group-caption.cs" %}
{% include code-snippet/grid/aggregate/group-caption/group-caption.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> The aggregate values must be accessed inside the template using their corresponding [`Type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridAggregateColumn.html#Syncfusion_EJ2_Grids_GridAggregateColumn_Type) property of [`GridAggregate Column`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridAggregateColumn.html) name.

## Custom aggregate

To calculate the aggregate value with your own aggregate functions, use the custom aggregate option. To use custom aggregation, specify the [`Type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridAggregateColumn.html#Syncfusion_EJ2_Grids_GridAggregateColumn_Type) as **Custom**, and provide the custom aggregate function in the [`CustomAggregate`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridAggregateColumn.html#Syncfusion_EJ2_Grids_GridAggregateColumn_CustomAggregate) property.

The custom aggregate function will be invoked with different arguments for total and group aggregations.
* **Total aggregation**: The custom aggregate function will be called with the whole data and current [`AggregateColumn`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridAggregateColumn.html)
object.
* **Group aggregation**: This will be called with the current group details and [`AggregateColumn`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridAggregateColumn.html) object.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/aggregate/custom-agg/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-agg.cs" %}
{% include code-snippet/grid/aggregate/custom-agg/custom-agg.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/aggregate/custom-agg/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-agg.cs" %}
{% include code-snippet/grid/aggregate/custom-agg/custom-agg.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> To access the custom aggregate value inside the template, use the key as **Custom**.

## Reactive aggregate update

When using batch editing, the aggregate values will be refreshed on every cell save. The footer, group footer, and group caption aggregate values will be refreshed.

> Adding a new record to the grouped grid will not refresh the aggregate values.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/aggregate/reactive-agg-batch-edit/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Reactive-agg-batch-edit.cs" %}
{% include code-snippet/grid/aggregate/reactive-agg-batch-edit/reactive-agg-batch-edit.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/aggregate/reactive-agg-batch-edit/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Reactive-agg-batch-edit.cs" %}
{% include code-snippet/grid/aggregate/reactive-agg-batch-edit/reactive-agg-batch-edit.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Refresh aggregates in inline edit mode

By default, reactive aggregate update is not supported by inline and dialog edit modes as it is not feasible to anticipate the value change event for every editor. But, you can refresh the aggregates manually in the inline edit mode using the refresh method of aggregate module.

In the following code, the input event for the Freight column editor has been registered and the aggregate value has been refreshed manually.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/aggregate/reactive-agg-inline-edit/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Reactive-agg-inline-edit.cs" %}
{% include code-snippet/grid/aggregate/reactive-agg-inline-edit/reactive-agg-inline-edit.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/aggregate/reactive-agg-inline-edit/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Reactive-agg-inline-edit.cs" %}
{% include code-snippet/grid/aggregate/reactive-agg-inline-edit/reactive-agg-inline-edit.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

