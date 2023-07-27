---
layout: post
title: Custom Aggregate in ##Platform_Name## Grid Component
description: Learn here all about Custom Aggregate in Syncfusion ##Platform_Name## Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Custom Aggregate
publishingplatform: ##Platform_Name##
documentation: ug
---


# Custom Aggregate

To calculate the aggregate value with your own aggregate functions, use the custom aggregate option. To use custom aggregation, specify the [`Type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridAggregateColumn.html#Syncfusion_EJ2_Grids_GridAggregateColumn_Type) as **Custom**, and provide the custom aggregate function in the [`CustomAggregate`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridAggregateColumn.html#Syncfusion_EJ2_Grids_GridAggregateColumn_CustomAggregate) property.

The custom aggregate function will be invoked with different arguments for total and group aggregations.

* **Total aggregation**: The custom aggregate function will be called with the whole data and current [`AggregateColumn`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridAggregateColumn.html) object.
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



N> To access the custom aggregate value inside the template, use the key as **Custom**.