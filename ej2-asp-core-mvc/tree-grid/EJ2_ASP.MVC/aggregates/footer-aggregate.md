---
layout: post
title: ##Platform_Name## TreeGrid Footer Aggregate | Syncfusion
description: Learn how to configure and display footer aggregate values in ##Platform_Name## TreeGrid, including API usage, templates, and formatting options.
platform: ej2-asp-core-mvc
control: Footer Aggregate
publishingplatform: ##Platform_Name##
documentation: ug
---


# Footer Aggregate in ##Platform_Name## TreeGrid

Footer aggregate value is calculated for all the rows, and it is displayed in the footer cells. Use the [`FooterTemplate`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.TreeGrid.TreeGridAggregateColumn.html#Syncfusion_EJ2_TreeGrid_TreeGridAggregateColumn_FooterTemplate) property to render the aggregate value in footer cells.

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



N> The aggregate values must be accessed inside the template using their corresponding [`Type`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.TreeGrid.TreeGridAggregateColumn.html#Syncfusion_EJ2_TreeGrid_TreeGridAggregateColumn_Type) name.

## How to format aggregate value

You can format the aggregate value result by using the [`Format`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.TreeGrid.TreeGridAggregateColumn.html#Syncfusion_EJ2_TreeGrid_TreeGridAggregateColumn_Format) property.

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



N> You can refer to our [`ASP.NET MVC Tree Grid`](https://www.syncfusion.com/aspnet-mvc-ui-controls/tree-grid) feature tour page for its groundbreaking feature representations. You can also explore our [`ASP.NET MVC Tree Grid example`](https://ej2.syncfusion.com/aspnetmvc/treegrid/overview#/fluent2) to knows how to present and manipulate data.