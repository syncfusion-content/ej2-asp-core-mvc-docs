---
layout: post
title: Footer Aggregate in Syncfusion ##Platform_Name## Grid Component
description: Learn here all about Footer Aggregate in Syncfusion ##Platform_Name## Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Footer Aggregate
publishingplatform: ##Platform_Name##
documentation: ug
---

# Footer aggregate in ASP.Net MVC Grid component

The Syncfusion ASP.Net MVC Grid component allows you to calculate and display aggregate values in the footer cells. The footer aggregate value is calculated from all the rows in the grid. You can use the `FooterTemplate` property to render the aggregate value in the footer cells.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/aggregate/footer-aggregate/razor %}
{% endhighlight %}
{% highlight c# tabtitle="footer-aggregate.cs" %}
{% include code-snippet/grid/aggregate/footer-aggregate/footer-aggregate.cs %}
{% endhighlight %}
{% endtabs %}

![Footer Aggregates](../images/aggregates/footer-aggregate.png)

> * Use the template reference variable name **FooterTemplate** to specify the footer template.
> * Inside the template, access the aggregate values using their corresponding `Type` name. For example, to access the sum aggregate value, use **data.sum**.

## Format the aggregate value

To format the aggregate value result in the Syncfusion ASP.Net MVC Grid component, you can use the `Format` property of the `AggregateColumn`. The `Format` property allows you to specify a format string that determines how the aggregate value will be displayed.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/aggregate/format-aggregate/razor %}
{% endhighlight %}
{% highlight c# tabtitle="format-aggregate.cs" %}
{% include code-snippet/grid/aggregate/format-aggregate/format-aggregate.cs %}
{% endhighlight %}
{% endtabs %}

![Format the aggregate value](../images/aggregates/format-aggergate.png)

## How to place aggregates on top of the Grid

By default, the aggregated values are placed at the bottom of the footer section. It is possible to place the aggregated values at the top of the header. This is achieved by using the [DataBound](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_DataBound) event, `getHeaderContent`, and `getFooterContent` methods of the Grid.

In the following, footer content is appended to the header content using the `DataBound` event of the Grid.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/aggregate/top-aggregate/razor %}
{% endhighlight %}
{% highlight c# tabtitle="top-aggregate.cs" %}
{% include code-snippet/grid/aggregate/top-aggregate/top-aggregate.cs %}
{% endhighlight %}
{% endtabs %}

![Place aggregates on top of the Grid](../images/aggregates/top-aggergate.png)
