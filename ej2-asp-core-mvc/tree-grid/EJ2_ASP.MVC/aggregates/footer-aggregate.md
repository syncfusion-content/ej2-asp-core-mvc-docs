---
layout: post
title: Footer Aggregate in ##Platform_Name## Tree Grid Component | Syncfusion
description: Learn here all about Footer Aggregate in Syncfusion ##Platform_Name## Tree Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Footer Aggregate
publishingplatform: ##Platform_Name##
documentation: ug
---


# Footer aggregate in ##Platform_Name## Tree Grid Component

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



> You can refer to our [`ASP.NET MVC Tree Grid`](https://www.syncfusion.com/aspnet-mvc-ui-controls/tree-grid) feature tour page for its groundbreaking feature representations. You can also explore our [`ASP.NET MVC Tree Grid example`](https://ej2.syncfusion.com/aspnetmvc/TreeGrid/Overview#/material) to knows how to present and manipulate data.