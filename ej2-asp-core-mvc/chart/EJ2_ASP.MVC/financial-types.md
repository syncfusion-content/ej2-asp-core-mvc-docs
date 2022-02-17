---
layout: post
title: Financial Types in ##Platform_Name## Chart Component
description: Learn here all about Financial Types in Syncfusion ##Platform_Name## Chart component and more.
platform: ej2-asp-core-mvc
control: Financial Types
publishingplatform: ##Platform_Name##
documentation: ug
---


# Financial Charts

Financial charts are used to illustrate the movements in the price of a financial instrument over time.

Chart supports the following financial series

<!-- markdownlint-disable MD036 -->

## Hilo

Hilo Series illustrates the price movements in stock using the high and low values.
To render a Hilo series, use series [`Type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Type) as `Hilo`.

Hilo series requires 3 fields (x, high and low) to show the high and low price in the stock.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/financial-charts/hilo/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Hilo.cs" %}
{% include code-snippet/chart/series/financial-charts/hilo/hilo.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/financial-charts/hilo/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Hilo.cs" %}
{% include code-snippet/chart/series/financial-charts/hilo/hilo.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## High Low Open Close

HiloOpenClose series is used to represent the low, high, open and closing values over time.
To render a HiloOpenClose series, use series [`Type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Type) as `HiloOpenClose`.

HiloOpenClose series requires 5 fields (x, high, low, open and close) to show the high, low, open and close price
values in the stock.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/financial-charts/hilo-openclose/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Hilo-openclose.cs" %}
{% include code-snippet/chart/series/financial-charts/hilo-openclose/hilo-openclose.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/financial-charts/hilo-openclose/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Hilo-openclose.cs" %}
{% include code-snippet/chart/series/financial-charts/hilo-openclose/hilo-openclose.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Customization of HiloOpenClose Series

In HiloOpenClose series, [`BullFillColor`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_BullFillColor) is used to fill the
 segment when the open value is greater than the close value and
[`BearFillColor`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_BearFillColor) is used to fill the segment when the open
value is less than the close value.

By default, bullFillColor is set as red and bearFillColor is set as green.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/financial-charts/custom-openclose/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-openclose.cs" %}
{% include code-snippet/chart/series/financial-charts/custom-openclose/custom-openclose.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/financial-charts/custom-openclose/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-openclose.cs" %}
{% include code-snippet/chart/series/financial-charts/custom-openclose/custom-openclose.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Candle

Candle series are similar to Hilo Open Close series, are used to represent the low,
high, open and closing price over time. To render a candle series, use series
[`Type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Type) as `Candle`.

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



**Hollow Candles**

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

Bear color  will be applied when the current closing value is greater than the previous closing value.
Bull color will be applied when the current closing value is less than the previous closing value.

By default, bullFillColor is set as red and bearFillColor is set as green.

**Solid Candles**

[`BnableSolidCandles`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_EnableSolidCandles) is used to enable/disable the solid
candles. By default is set to be false. The fill color of the candle will be defined by its opening and closing values.

[`BearFillColor`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_BearFillColor) will be applied when the opening value is less than the closing value.
[`BullFillColor`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_BullFillColor)
will be applied when the opening value is greater than closing value.

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

* [Data label](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartDataLabelSettings.html)
* [Tooltip](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartTooltipSettings.html)