---
layout: post
title: Trend Lines in ##Platform_Name## Stock Chart Component
description: Learn here all about Trend Lines in Syncfusion ##Platform_Name## Stock Chart component and more.
platform: ej2-asp-core-mvc
control: Trend Lines
publishingplatform: ##Platform_Name##
documentation: ug
---


# Trendlines

Trendlines are used to show the direction and speed of price.

Stock Chart supports 6 types of trendlines namely `Linear`,`Exponential`,`Logarithmic`,`Polynomial`,`Power`,`Moving Average`. By using trendline dropdown button you can add or remove the required trendline type.

## Linear

A linear trendline is a best fit straight line that is used with simpler data sets.To render a linear trendline,
use trendline [`type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.StockChartTrendlines.html#Syncfusion_EJ2_Charts_StockChartTrendlines_Type) as `Linear`.

## Exponential

An exponential trendline is a curved line that is most useful when data values rise or fall at increasingly higher rates. You cannot create an exponential trendline, if your data contains zero or negative values.
To render a exponential trendline,
use trendline [`type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.StockChartTrendlines.html#Syncfusion_EJ2_Charts_StockChartTrendlines_Type) as `Exponential`.

## Logarithmic

A logarithmic trendline is a best-fit curved line that is most useful when the rate of change in the data increases or decreases quickly and then levels out. A logarithmic trendline can use negative and/or positive values.
To render a logarithmic trendline, use trendline [`type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.StockChartTrendlines.html#Syncfusion_EJ2_Charts_StockChartTrendlines_Type) as `Logarithmic`.

## Polynomial

A polynomial trendline is a curved line that is used when data fluctuates.
to render a polynomial trendline,
use trendline [`type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.StockChartTrendlines.html#Syncfusion_EJ2_Charts_StockChartTrendlines_Type) as `Polynomial`.
`polynomialOrder` used to define the polynomial value.

## Power

A power trendline is a curved line that is best used with data sets that compare measurements that increase at a specific rate.
To render a power trendline, use trendline [`type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.StockChartTrendlines.html#Syncfusion_EJ2_Charts_StockChartTrendlines_Type) as `Power`.

## Moving Average

A moving average trendline smoothen out fluctuations in data to show a pattern or trend more clearly.
To render a moving average trendline, use trendline [`type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.StockChartTrendlines.html#Syncfusion_EJ2_Charts_StockChartTrendlines_Type) as `MovingAverage`.

`period` property defines the period to find the moving average.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/stock-chart/stockchart-feature/trendlines/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Trendlines.cs" %}
{% include code-snippet/stock-chart/stockchart-feature/trendlines/trendlines.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/stock-chart/stockchart-feature/trendlines/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Trendlines.cs" %}
{% include code-snippet/stock-chart/stockchart-feature/trendlines/trendlines.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Customization of Trendline

The [`fill`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.StockChartTrendlines.html#Syncfusion_EJ2_Charts_StockChartTrendlines_Fill) and [`width`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.StockChartTrendlines.html#Syncfusion_EJ2_Charts_StockChartTrendlines_Width) properties are used to customize the appearance of the trendline.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/stock-chart/stockchart-feature/customtrendlines/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Customtrendlines.cs" %}
{% include code-snippet/stock-chart/stockchart-feature/customtrendlines/customtrendlines.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/stock-chart/stockchart-feature/customtrendlines/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Customtrendlines.cs" %}
{% include code-snippet/stock-chart/stockchart-feature/customtrendlines/customtrendlines.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


