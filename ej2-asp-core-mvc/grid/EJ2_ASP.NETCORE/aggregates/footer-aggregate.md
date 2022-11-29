---
layout: post
title: Footer Aggregate in Syncfusion ##Platform_Name## Grid Component
description: Learn here all about Footer Aggregate in Syncfusion ##Platform_Name## Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Footer Aggregate
publishingplatform: ##Platform_Name##
documentation: ug
---


# Footer Aggregate in ASP.Net Core Grid Component

Footer aggregate value is calculated for all the rows, and it is displayed in the footer cells. Use the [`footerTemplate`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridAggregateColumn.html#Syncfusion_EJ2_Grids_GridAggregateColumn_FooterTemplate) property to render the aggregate value in footer cells.

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
{% highlight c# tabtitle="footer-agg.cs" %}
{% include code-snippet/grid/aggregate/footer-agg/footer-agg.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> The aggregate values must be accessed inside the template using their corresponding [`type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridAggregateColumn.html#Syncfusion_EJ2_Grids_GridAggregateColumn_Type) name.

## How to format aggregate value

You can format the aggregate value result by using the [`format`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridAggregateColumn.html#Syncfusion_EJ2_Grids_GridAggregateColumn_Format) property.

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


## How to place aggregates on top of the Grid

By default, the aggregated values are placed at the bottom of the footer section. It is possible to place the aggregated values at the top of the header. This is achieved by using the [dataBound](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_DataBound) event, `getHeaderContent`, and `getFooterContent` methods of the Grid.

In the following sample, the footer element is appended to the header element using the `getHeaderContent` and `getFooterContent` methods in the `dataBound` event.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/aggregate/top-aggregate/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Aggregate.cs" %}
{% include code-snippet/grid/aggregate/top-aggregate/top-aggregate.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/aggregate/top-aggregate/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Aggregate.cs" %}
{% include code-snippet/grid/aggregate/top-aggregate/top-aggregate.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}
