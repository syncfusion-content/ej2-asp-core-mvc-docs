---
layout: post
title: Candle Chart in ##Platform_Name## Syncfusion Chart Component
description: Learn here all about Candle Chart in Syncfusion ##Platform_Name## Chart component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Candle Chart
publishingplatform: ##Platform_Name##
documentation: ug
---


# Candle in ##Platform_Name## Charts Component

## Candle

Candle series are similar to Hilo Open Close series, are used to represent the low, high, open and closing price over time. To render a candle series, use series [`Type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Type) as `Candle`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/financial-charts/candle/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Candle.cs" %}
{% include code-snippet/chart/series/financial-charts/candle/candle.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/financial-charts/candle/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Candle.cs" %}
{% include code-snippet/chart/series/financial-charts/candle/candle.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Hollow Candles

Candle charts allow to visually compare the current price with previous price by customizing the appearance.

Candles are filled/left as hollow based on the following criteria.

<!-- markdownlint-disable MD033 -->
<table>
<tr>
<td><b>States</b></td>
<td><b>Description </b></td>
</tr>
<tr>
<td>Filled</td>
<td>candle sticks are filled when the close value is lesser than the open value</td>
</tr>
<tr>
<td>Unfilled</td>
<td>candle sticks are unfilled when the close value is greater than the open value</td>
</tr>
</table>

The color of the candle will be defined by comparing with previous values.

* Bear color  will be applied when the current closing value is greater than the previous closing value.
* Bull color will be applied when the current closing value is less than the previous closing value.

By default, bullFillColor is set as red and bearFillColor is set as green.



## Solid Candles

[`EnableSolidCandles`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_EnableSolidCandles) is used to enable/disable the solid candles. By default is set to be false. The fill color of the candle will be defined by its opening and closing values.

[`BearFillColor`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_BearFillColor) will be applied when the opening value is less than the closing value. [`BullFillColor`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_BullFillColor) will be applied when the opening value is greater than closing value.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/financial-charts/solid-candles/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Solid-candles.cs" %}
{% include code-snippet/chart/series/financial-charts/solid-candles/solid-candles.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/financial-charts/solid-candles/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Solid-candles.cs" %}
{% include code-snippet/chart/series/financial-charts/solid-candles/solid-candles.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## See Also

* [Data Label](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartDataLabelSettings.html)
* [Tooltip](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartTooltipSettings.html)