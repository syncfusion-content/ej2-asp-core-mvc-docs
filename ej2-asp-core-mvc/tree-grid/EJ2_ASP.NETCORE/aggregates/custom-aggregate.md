---
layout: post
title: Custom Aggregate in ##Platform_Name## Tree Grid Component | Syncfusion
description: Learn here all about Custom Aggregate in Syncfusion ##Platform_Name## Tree Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Custom Aggregate
publishingplatform: ##Platform_Name##
documentation: ug
---


# Custom Aggregate in ##Platform_Name## Tree Grid Component

To calculate the aggregate value with your own aggregate functions, use the custom aggregate option. To use custom aggregation, specify the [`type`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridAggregateColumn~Type.html) as **Custom**, and provide the custom aggregate function in the [`customAggregate`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridAggregateColumn~CustomAggregate.html) property.

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



N> To access the custom aggregate value inside the template, use the key as **Custom**.
<br/> You can refer to our  [`ASP.NET Core Tree Grid`](https://www.syncfusion.com/aspnet-core-ui-controls/tree-grid) feature tour page for its groundbreaking feature representations. You can also explore our ASP.NET Core Tree Grid example [`ASP.NET Core Tree Grid example`](https://ej2.syncfusion.com/aspnetcore/TreeGrid/Overview#/material) to knows how to present and manipulate data.