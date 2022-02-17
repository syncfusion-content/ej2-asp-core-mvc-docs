---
layout: post
title: Aggregates in ##Platform_Name## Tree Grid Component
description: Learn here all about Aggregates in Syncfusion ##Platform_Name## Tree Grid component and more.
platform: ej2-asp-core-mvc
control: Aggregates
publishingplatform: ##Platform_Name##
documentation: ug
---


# Aggregates

Aggregate values are displayed in the TreeGrid footer and in parent row footer for child row aggregate values. It can be configured through [`Aggregates`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~Aggregates.html) property.
 [`Field`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridAggregateColumn~Field.html) and [`Type`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridAggregateColumn~Type.html)
 are the minimum properties required to represent an aggregate column.

By default, the aggregate value can be displayed in the treegrid footer, and footer of child rows. To show the aggregate value in one of the cells, use the [`FooterTemplate`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridAggregateColumn~FooterTemplate.html).

## Built-in aggregate types

The aggregate type should be specified in the [`Type`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridAggregateColumn~Type.html) property to configure an aggregate column.

The built-in aggregates are,
* Sum
* Average
* Min
* Max
* Count
* Truecount
* Falsecount

> Multiple aggregates can be used for an aggregate column by setting the [`Type`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridAggregateColumn~Type.html) property
with an array of aggregate types.
> Multiple types for a column is supported only when one of the aggregate templates is used.

## Footer aggregate

Footer aggregate value is calculated for all the rows, and it is displayed in the footer cells. Use the [`FooterTemplate`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridAggregateColumn~FooterTemplate.html) property to render the aggregate value in footer cells.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/aggregates/footer-aggregate/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="FooterAggregate.cs" %}
{% include code-snippet/tree-grid/aggregates/footer-aggregate/footerAggregate.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/aggregates/footer-aggregate/razor %}
{% endhighlight %}
{% highlight c# tabtitle="FooterAggregate.cs" %}
{% include code-snippet/tree-grid/aggregates/footer-aggregate/footerAggregate.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> The aggregate values must be accessed inside the template using their corresponding [`Type`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridAggregateColumn~Type.html) name.

## Child aggregate

Aggregate value is calculated for child rows, and it is displayed in the parent row footer. Use the [`ShowChildSummary`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridAggregate~ShowChildSummary.html) property to render the child rows aggregate value.

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



## How to format aggregate value

You can format the aggregate value result by using the [`Format`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridAggregateColumn~Format.html) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/aggregates/format-Aggregate/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="FormatAggregate.cs" %}
{% include code-snippet/tree-grid/aggregates/format-Aggregate/formatAggregate.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/aggregates/format-Aggregate/razor %}
{% endhighlight %}
{% highlight c# tabtitle="FormatAggregate.cs" %}
{% include code-snippet/tree-grid/aggregates/format-Aggregate/formatAggregate.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Custom aggregate

To calculate the aggregate value with your own aggregate functions, use the custom aggregate option. To use custom aggregation, specify the [`Type`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridAggregateColumn~Type.html) as **Custom**, and provide the custom aggregate function in the [`CustomAggregate`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridAggregateColumn~CustomAggregate.html) property.

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



> To access the custom aggregate value inside the template, use the key as `Custom`.
> You can refer to our [`ASP.NET MVC Tree Grid`](https://www.syncfusion.com/aspnet-mvc-ui-controls/tree-grid) feature tour page for its groundbreaking feature representations. You can also explore our [`ASP.NET MVC Tree Grid example`](https://ej2.syncfusion.com/aspnetmvc/TreeGrid/Overview#/material) to knows how to present and manipulate data.