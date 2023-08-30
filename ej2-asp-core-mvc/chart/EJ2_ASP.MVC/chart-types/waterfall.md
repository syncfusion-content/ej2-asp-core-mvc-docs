---
layout: post
title: Waterfall Chart in ##Platform_Name## Syncfusion Chart Component
description: Learn here all about Waterfall Chart in Syncfusion ##Platform_Name## Chart component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Waterfall Chart
publishingplatform: ##Platform_Name##
documentation: ug
---


# Waterfall in ##Platform_Name## Charts Component

## Waterfall

Waterfall chart helps to understand the cumulative effect of the sequentially introduced positive and negative values. To render a Waterfall series, use series [`Type`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Type) as [`Waterfall`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartSeriesType.html#Syncfusion_EJ2_Charts_ChartSeriesType_Waterfall). [`IntermediateSumIndexes`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_IntermediateSumIndexes) property of waterfall is used to represent the in between the sum values and [`SumIndexes`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_SumIndexes) is used to represent the cumulative sum values.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/other-types/waterfall/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Waterfall.cs" %}
{% include code-snippet/chart/series/other-types/waterfall/waterfall.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/other-types/waterfall/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Waterfall.cs" %}
{% include code-snippet/chart/series/other-types/waterfall/waterfall.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Series customization

The negative changes of waterfall charts is represented by using [`NegativeFillColor`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_NegativeFillColor) and the summary changes are represented by using [`SummaryFillColor`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_SummaryFillColor) properties.

By default, the negativeFillColor as ‘#E94649’ and the summaryFillColor as ‘#4E81BC’.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/other-types/custom-waterfall/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-waterfall.cs" %}
{% include code-snippet/chart/series/other-types/custom-waterfall/custom-waterfall.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/other-types/custom-waterfall/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-waterfall.cs" %}
{% include code-snippet/chart/series/other-types/custom-waterfall/custom-waterfall.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## See Also

* [Data Label](../data-labels)
* [Tooltip](../tool-tip)