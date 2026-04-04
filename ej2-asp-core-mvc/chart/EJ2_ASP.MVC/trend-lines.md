---
layout: post
title: Trend Lines in ##Platform_Name## Chart Component
description: Learn here all about Trend Lines in Syncfusion ##Platform_Name## Chart component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Trend Lines
publishingplatform: ##Platform_Name##
documentation: ug
---


<!-- markdownlint-disable MD036 -->

# Trend Lines in ##Platform_Name## Chart Component

Trendlines help identify patterns, direction, and overall trends in numerical data. They project the general movement of data values and are widely used in analytics, forecasting, and financial charts. Trendlines can be added to Cartesian series types such as Line, Column, Scatter, Area, Candle, and Hilo (excluding bar series). Multiple trendlines can be added to a single series based on the analysis needs.

Charts support six types of trendlines: **Linear**, **Exponential**, **Logarithmic**, **Polynomial**, **Power**, and **Moving Average**.

## Linear

A linear trendline is a straight, best‑fit line used to describe data with a constant rate of increase or decrease. Set the trendline [`Type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartTrendline.html) to `Linear`.

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

An exponential trendline displays a curved pattern useful when data rises or falls at increasing rates. Exponential trendlines cannot be generated if the dataset includes zero or negative values.

Set the trendline [`Type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartTrendline.html) to `Exponential`.

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

A logarithmic trendline is a best‑fit curved line suitable when the data increases or decreases quickly and then stabilizes. It supports both positive and negative values.

Set [`Type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartTrendline.html) to `Logarithmic`.

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

A polynomial trendline is useful when data fluctuates. It uses a curved line that can model more complex datasets.

Set [`Type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartTrendline.html) to `Polynomial`. Use [`PolynomialOrder`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartTrendline.html#Syncfusion_EJ2_Charts_ChartTrendline_PolynomialOrder) to define the degree of the polynomial.

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

A power trendline is ideal for datasets where measurements increase at a constant rate. It displays a curved line that best fits exponential growth or decay patterns.

Set [`Type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartTrendline.html) to `Power`.

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

A moving average trendline smooths fluctuations to reveal overall trends more clearly. The [`Period`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartTrendline.html#Syncfusion_EJ2_Charts_ChartTrendline_Period) property specifies the number of data points used to calculate each average.

Set [`Type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartTrendline.html) to `MovingAverage`.

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

Customize trendline appearance using the [`Fill`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartTrendline.html#Syncfusion_EJ2_Charts_ChartTrendline_Fill) property for color and the [`Width`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartTrendline.html#Syncfusion_EJ2_Charts_ChartTrendline_Width) property for line thickness.

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

Trendline forecasting extends the existing trendline to estimate future and past values.

**Forward Forecasting**

Use the [`ForwardForecast`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartTrendline.html#Syncfusion_EJ2_Charts_ChartTrendline_ForwardForecast) property to extend the trendline into the future.

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

Use the [`BackwardForecast`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartTrendline.html#Syncfusion_EJ2_Charts_ChartTrendline_BackwardForecast) property to extend the trendline into past data points.

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


## Show or hide a trendline

Control visibility using the [`Visible`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartTrendline.html#Syncfusion_EJ2_Charts_ChartTrendline_Visible) property of the trendline.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/trendlines/hide/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Hide.cs" %}
{% include code-snippet/chart/trendlines/hide/hide.cs %}
{% endhighlight %}
{% endtabs %}
