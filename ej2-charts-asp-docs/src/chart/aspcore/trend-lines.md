---
title: " Chart Trendlines | ASP.NET MVC "

component: "Chart"

description: "Trendlines are used to show the direction and speed of price. Chart supports 6 types of trendlines and also provides trendlines customization."
---

<!-- markdownlint-disable MD036 -->

# Trendlines

Trendlines are used to show the direction and speed of price.

Trendlines can be generated for Cartesian type series (Line, Column, Scatter, Area, Candle, Hilo etc.)
except bar type series. You can add more than one trendline to a series.

Chart supports 6 types of trendlines.

## Linear

A linear trendline is a best fit straight line that is used with simpler data sets. To render a linear trendline,
use trendline [`type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartTrendline.html) as `Linear`.

{% aspTab template="chart/trendlines/linear", sourceFiles="linear.cs" %}

{% endaspTab %}

## Exponential

An exponential trendline is a curved line that is most useful when data values rise or fall
at increasingly higher rates. You cannot create an exponential trendline, if your data contains zero or negative values.

To render a exponential trendline,
use trendline [`type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartTrendline.html) as `Exponential`.

{% aspTab template="chart/trendlines/exponential", sourceFiles="exponential.cs" %}

{% endaspTab %}

## Logarithmic

A logarithmic trendline is a best-fit curved line that is most useful when the rate of change
in the data increases or decreases quickly and then levels out.

A logarithmic trendline can use negative and/or positive values.

To render a logarithmic trendline, use trendline [`type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartTrendline.html) as `Logarithmic`.

{% aspTab template="chart/trendlines/logarithmic", sourceFiles="logarithmic.cs" %}

{% endaspTab %}

## Polynomial

A polynomial trendline is a curved line that is used when data fluctuates.

To render a polynomial trendline,
use trendline [`type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartTrendline.html) as `Polynomial`.

`polynomialOrder` used to define the polynomial value.

{% aspTab template="chart/trendlines/polynomial", sourceFiles="polynomial.cs" %}

{% endaspTab %}

## Power

A power trendline is a curved line that is best used with data sets that compare measurements that increase at a specific rate.

To render a power trendline, use trendline [`type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartTrendline.html) as `Power`.

{% aspTab template="chart/trendlines/power", sourceFiles="power.cs" %}

{% endaspTab %}

## Moving Average

A moving average trendline smoothen out fluctuations in data to show a pattern or trend more clearly.

To render a moving average trendline, use trendline [`type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartTrendline.html) as `MovingAverage`.

`period` property defines the period to find the moving average.

{% aspTab template="chart/trendlines/movingaverage", sourceFiles="movingaverage.cs" %}

{% endaspTab %}

**Customization of Trendlines**

The [`fill`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartTrendline.html#Syncfusion_EJ2_Charts_ChartTrendline_Fill)
and [`width`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartTrendline.html#Syncfusion_EJ2_Charts_ChartTrendline_Width)
properties are used to customize the appearance of the trendline.

{% aspTab template="chart/trendlines/custom-trendline", sourceFiles="custom-trendline.cs" %}

{% endaspTab %}

## Forecasting

Trendlines forecasting is the prediction of future/past situations.

Forecasting can be classified into two types as follows

Forward Forecasting
Backward Forecasting

**Forward Forecasting**

The value set for forwardForecast is used to determine the distance moving towards the future trend.

{% aspTab template="chart/trendlines/forward-forecast", sourceFiles="forward-forecast.cs" %}

{% endaspTab %}

**Backward Forecasting**

The value set for the backwardForecast is used to determine the past trends.

{% aspTab template="chart/trendlines/backward-forecast", sourceFiles="backward-forecast.cs" %}

{% endaspTab %}