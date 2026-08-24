---
layout: post
title: ##Platform_Name## TreeGrid Custom Aggregate | Syncfusion
description: Learn about implementing custom aggregates in the ##Platform_Name## TreeGrid, including configuration and usage of custom aggregation functions.
platform: ej2-asp-core-mvc
control: Custom Aggregate
publishingplatform: ##Platform_Name##
documentation: ug
---


# Custom Aggregate in ##Platform_Name## TreeGrid

To calculate the aggregate value with your own aggregate functions, use the custom aggregate option. To use custom aggregation, specify the [`Type`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.TreeGrid.TreeGridAggregateColumn.html#Syncfusion_EJ2_TreeGrid_TreeGridAggregateColumn_Type) as **Custom**, and provide the custom aggregate function in the [`CustomAggregate`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.TreeGrid.TreeGridAggregateColumn.html#Syncfusion_EJ2_TreeGrid_TreeGridAggregateColumn_CustomAggregate) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/aggregates/custom-Aggregate/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="CustomAggregate.cs" %}
{% include code-snippet/tree-grid/aggregates/custom-Aggregate/customAggregate.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/aggregates/custom-Aggregate/razor %}
{% endhighlight %}
{% highlight c# tabtitle="CustomAggregate.cs" %}
{% include code-snippet/tree-grid/aggregates/custom-Aggregate/customAggregate.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



N> To access the custom aggregate value inside the template, use the key as `Custom`.
<br/> You can refer to our [`ASP.NET MVC Tree Grid`](https://www.syncfusion.com/aspnet-mvc-ui-controls/tree-grid) feature tour page for its groundbreaking feature representations. You can also explore our [`ASP.NET MVC Tree Grid example`](https://ej2.syncfusion.com/aspnetmvc/treegrid/overview#/fluent2) to knows how to present and manipulate data.