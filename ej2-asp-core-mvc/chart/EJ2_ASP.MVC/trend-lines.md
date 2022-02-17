---
layout: post
title: Trend Lines in ##Platform_Name## Chart Component
description: Learn here all about Trend Lines in Syncfusion ##Platform_Name## Chart component and more.
platform: ej2-asp-core-mvc
control: Trend Lines
publishingplatform: ##Platform_Name##
documentation: ug
---


<!-- markdownlint-disable MD036 -->

# Trendlines

Trendlines are used to show the direction and speed of price.

Trendlines can be generated for Cartesian type series (Line, Column, Scatter, Area, Candle, Hilo etc.)
except bar type series. You can add more than one trendline to a series.

Chart supports 6 types of trendlines.

## Linear

A linear trendline is a best fit straight line that is used with simpler data sets. To render a linear trendline,
use trendline [`Type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartTrendline.html) as `Linear`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/trendlines/linear/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Linear.cs" %}
{% include code-snippet/chart/trendlines/linear/linear.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/trendlines/linear/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Linear.cs" %}
{% include code-snippet/chart/trendlines/linear/linear.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Exponential

An exponential trendline is a curved line that is most useful when data values rise or fall
at increasingly higher rates. You cannot create an exponential trendline, if your data contains zero or negative values.

To render a exponential trendline,
use trendline [`Type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartTrendline.html) as `Exponential`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/trendlines/exponential/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Exponential.cs" %}
{% include code-snippet/chart/trendlines/exponential/exponential.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/trendlines/exponential/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Exponential.cs" %}
{% include code-snippet/chart/trendlines/exponential/exponential.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Logarithmic

A logarithmic trendline is a best-fit curved line that is most useful when the rate of change
in the data increases or decreases quickly and then levels out.

A logarithmic trendline can use negative and/or positive values.

To render a logarithmic trendline, use trendline [`Type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartTrendline.html) as `Logarithmic`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/trendlines/logarithmic/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Logarithmic.cs" %}
{% include code-snippet/chart/trendlines/logarithmic/logarithmic.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/trendlines/logarithmic/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Logarithmic.cs" %}
{% include code-snippet/chart/trendlines/logarithmic/logarithmic.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Polynomial

A polynomial trendline is a curved line that is used when data fluctuates.

To render a polynomial trendline,
use trendline [`Type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartTrendline.html) as `Polynomial`.

`PolynomialOrder` used to define the polynomial value.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/trendlines/polynomial/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Polynomial.cs" %}
{% include code-snippet/chart/trendlines/polynomial/polynomial.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/trendlines/polynomial/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Polynomial.cs" %}
{% include code-snippet/chart/trendlines/polynomial/polynomial.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Power

A power trendline is a curved line that is best used with data sets that compare measurements that increase at a specific rate.

To render a power trendline, use trendline [`Type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartTrendline.html) as `Power`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/trendlines/power/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Power.cs" %}
{% include code-snippet/chart/trendlines/power/power.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/trendlines/power/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Power.cs" %}
{% include code-snippet/chart/trendlines/power/power.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Moving Average

A moving average trendline smoothen out fluctuations in data to show a pattern or trend more clearly.

To render a moving average trendline, use trendline [`Type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartTrendline.html) as `MovingAverage`.

`Period` property defines the period to find the moving average.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/trendlines/movingaverage/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Movingaverage.cs" %}
{% include code-snippet/chart/trendlines/movingaverage/movingaverage.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/trendlines/movingaverage/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Movingaverage.cs" %}
{% include code-snippet/chart/trendlines/movingaverage/movingaverage.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



**Customization of Trendlines**

The [`Fill`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartTrendline.html#Syncfusion_EJ2_Charts_ChartTrendline_Fill)
and [`Width`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartTrendline.html#Syncfusion_EJ2_Charts_ChartTrendline_Width)
properties are used to customize the appearance of the trendline.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/trendlines/custom-trendline/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-trendline.cs" %}
{% include code-snippet/chart/trendlines/custom-trendline/custom-trendline.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/trendlines/custom-trendline/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-trendline.cs" %}
{% include code-snippet/chart/trendlines/custom-trendline/custom-trendline.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Forecasting

Trendlines forecasting is the prediction of future/past situations.

Forecasting can be classified into two types as follows

Forward Forecasting
Backward Forecasting

**Forward Forecasting**

The value set for forwardForecast is used to determine the distance moving towards the future trend.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/trendlines/forward-forecast/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Forward-forecast.cs" %}
{% include code-snippet/chart/trendlines/forward-forecast/forward-forecast.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/trendlines/forward-forecast/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Forward-forecast.cs" %}
{% include code-snippet/chart/trendlines/forward-forecast/forward-forecast.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



**Backward Forecasting**

The value set for the backwardForecast is used to determine the past trends.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/trendlines/backward-forecast/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Backward-forecast.cs" %}
{% include code-snippet/chart/trendlines/backward-forecast/backward-forecast.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/trendlines/backward-forecast/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Backward-forecast.cs" %}
{% include code-snippet/chart/trendlines/backward-forecast/backward-forecast.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

