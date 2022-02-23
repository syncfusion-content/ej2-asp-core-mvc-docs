---
title: " Chart Technical Indicators | ASP.NET MVC "

component: "Chart"

description: "Indicators represent a statistical approach to technical analysis as opposed to a subjective approach. we have different types of indicators."
---

<!-- markdownlint-disable MD036 -->

# Technical Indicators

A [`technical indicator`](https://www.syncfusion.com/aspnet-core-ui-controls/charts/technical-indicators) is a mathematical calculation based on historic price, volume or open interest information
that aims to forecast financial market direction.

Chart supports 10 types of technical indicators.

## Accumulation Distribution

Accumulation Distribution combines price and volume to show how money may be flowing into or out of stock.
To render a [`Accumulation Distribution Indicator`](https://ej2.syncfusion.com/aspnetcore/Chart/ADIChart#/material),
use indicator [`type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartIndicator.html#Syncfusion_EJ2_Charts_ChartIndicator_Type) as `AccumulationDistribution`.
To calculate the signal line [`volume`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartIndicator.html#Syncfusion_EJ2_Charts_ChartIndicator_Volume) field is additionally added with `dataSource`.

{% aspTab template="chart/technical-indicators/ad", sourceFiles="ad.cs" %}

{% endaspTab %}

## Average True Range (ATR)

ATR measures the stock volatility by comparing the current value with the
previous value. To render a Average True Range (ATR) Indicator,
use indicator [`type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartIndicator.html#Syncfusion_EJ2_Charts_ChartIndicator_Type) as `Atr`.
{% aspTab template="chart/technical-indicators/atr", sourceFiles="atr.cs" %}

{% endaspTab %}

## Bollinger Band

A chart overlay that shows the upper and lower limits of normal price movements based on the standard deviation of prices.
To render a Bollinger Band, use indicator [`type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartIndicator.html#Syncfusion_EJ2_Charts_ChartIndicator_Type) as `BollingerBand`.
Bollinger band will be represented by three lines (upperLine, lowerLine, signalLine).Bollinger Band
default values of the [`period`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartIndicator.html#Syncfusion_EJ2_Charts_ChartIndicator_Period) is 14 and
[`standardDeviations`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartIndicator.html#Syncfusion_EJ2_Charts_ChartIndicator_StandardDeviation) is 2.

{% aspTab template="chart/technical-indicators/bollinger", sourceFiles="bollinger.cs" %}

{% endaspTab %}

**Customization of BollingerBand**

`stroke`, `stroke-width`, and `color` of upperLine can be customized by using,[`upperLine`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartIndicator.html#Syncfusion_EJ2_Charts_ChartIndicator_UpperLine),
and the lowerLine can be customized by using [`lowerLine`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartIndicator.html#Syncfusion_EJ2_Charts_ChartIndicator_LowerLine) properties of indicator.

{% aspTab template="chart/getting-started/custom-bollinger", sourceFiles="custom-bollinger.cs" %}

{% endaspTab %}

## Exponential Moving Average (EMA)

Moving average Indicators are used to define the direction of the trend. To render a EMA Indicator,
use indicator [`type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartIndicator.html#Syncfusion_EJ2_Charts_ChartIndicator_Type) as `Ema`.
{% aspTab template="chart/technical-indicators/ema", sourceFiles="ema.cs" %}

{% endaspTab %}

## Momentum

Momentum shows the speed at which the price of the stock is changing. To render a Momentum indicator, use indicator
[`type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartIndicator.html#Syncfusion_EJ2_Charts_ChartIndicator_Type) as `Momentum`. Momentum indicator will be represented by two lines (upperLine,
signalLine).In momentum indicator the upperBand value is always render at the value 100.

{% aspTab template="chart/technical-indicators/momentum", sourceFiles="momentum.cs" %}

{% endaspTab %}

**Customization of MomentumIndicator**

`stroke`, `stroke-width`, and `color` of upperLine can be customized by using,[`upperLine`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartIndicator.html#Syncfusion_EJ2_Charts_ChartIndicator_UpperLine),
property of indicator.

{% aspTab template="chart/technical-indicators/custom-momentum", sourceFiles="custom-momentum.cs" %}

{% endaspTab %}

## Moving Average Convergence Divergence (MACD)

MACD is based on the difference between two EMA's. To render a MACD Indicator, use indicator [`type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartIndicator.html#Syncfusion_EJ2_Charts_ChartIndicator_Type) as
`MACD`.MACD indicator will be represented
by MACD line,signal line, MACD histogram. MACD histogram is used to differentiate MACD line and signal line.

{% aspTab template="chart/technical-indicators/macd", sourceFiles="macd.cs" %}

{% endaspTab %}

**Customization of MACD**

`stroke`, `stroke-width`, and `color`of macdLine can be customized by using,[`macdLine`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartIndicator.html#Syncfusion_EJ2_Charts_ChartIndicator_MacdLine),
property of indicator. The positive and negative changes of histogram can be customized by [`macdPositiveColor`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartIndicator.html#Syncfusion_EJ2_Charts_ChartIndicator_MacdPositiveColor)
and [`macdNegativeColor`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartIndicator.html#Syncfusion_EJ2_Charts_ChartIndicator_MacdNegativeColor) properties.
The [`macdType`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartIndicator.html#Syncfusion_EJ2_Charts_ChartIndicator_MacdType) is used to define the type of
MACD indicator. To customize the MACD period using [`slowPeriod`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartIndicator.html#Syncfusion_EJ2_Charts_ChartIndicator_SlowPeriod) and [`fastPeriod`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartIndicator.html#Syncfusion_EJ2_Charts_ChartIndicator_FastPeriod)
properties.

{% aspTab template="chart/technical-indicators/custom-macd", sourceFiles="custom-macd.cs" %}

{% endaspTab %}

## Relative Strength Index (RSI)

RSI shows how strongly a stock is moving in its current direction. To render a RSI Indicator, use
indicator [`type`](./https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartIndicator.html#Syncfusion_EJ2_Charts_ChartIndicator_Type) as `Rsi`.RSI indicator will be represented
by three lines (upperBand, lowerBand, signalLine). The upperBand and lowerBand values are customized by
[`overBought`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartIndicator.html#Syncfusion_EJ2_Charts_ChartIndicator_OverBought)
and [`overSold`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartIndicator.html#Syncfusion_EJ2_Charts_ChartIndicator_OverSold)
properties of indicator and the signalLine is calculated by RSI formula.

{% aspTab template="chart/technical-indicators/rsi", sourceFiles="rsi.cs" %}

{% endaspTab %}

## Simple Moving Average (SMA)

Moving average Indicators are used to define the direction of the trend. To render a SMA Indicator,
use indicator [`type`](./https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartIndicator.html#Syncfusion_EJ2_Charts_ChartIndicator_Type) as
`Sma`.

{% aspTab template="chart/technical-indicators/sma", sourceFiles="sma.cs" %}

{% endaspTab %}

## Stochastic

It shows how a stock is, when compared to previous state. To render a Stochastic indicator,
use indicator [`type`](./https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartIndicator.html#Syncfusion_EJ2_Charts_ChartIndicator_Type) as `Stochastic`.
stochastic indicator will be represented by four lines (upperLine, lowerLine, periodLine, signalLine).
In stochastic indicator the upperBand value and lowerBand value is customized by [`overBought`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartIndicator.html#Syncfusion_EJ2_Charts_ChartIndicator_OverBought)
and [`overBought`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartIndicator.html#Syncfusion_EJ2_Charts_ChartIndicator_OverBought)properties of indicators and the periodLine and
signalLine is render based on stochastic formula.

{% aspTab template="chart/technical-indicators/stochastic", sourceFiles="stochastic.cs" %}

{% endaspTab %}

**Customization of StochasticIndicator**

`stroke`, `stroke-width`, and `color` of upperLine can be customized by using,[`upperLine`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartIndicator.html#Syncfusion_EJ2_Charts_ChartIndicator_UpperLine),
the lowerLine can be customized by using [`lowerLine`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartIndicator.html#Syncfusion_EJ2_Charts_ChartIndicator_LowerLine)
and the periodLine can be customized by using [`periodLine`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartIndicator.html#Syncfusion_EJ2_Charts_ChartIndicator_PeriodLine)
properties of indicator. To customize the period to find the average price
using [`kPeriod`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartIndicator.html#Syncfusion_EJ2_Charts_ChartIndicator_KPeriod)
and [`dPeriod`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartIndicator.html#Syncfusion_EJ2_Charts_ChartIndicator_DPeriod)
properties.

{% aspTab template="chart/technical-indicators/custom-stochastic", sourceFiles="custom-stochastic.cs" %}

{% endaspTab %}

## Triangular Moving Average (TMA)

Moving average indicators are used to define the direction of the trend. To render a TMA Indicator,
use indicator [`type`](./https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartIndicator.html#Syncfusion_EJ2_Charts_ChartIndicator_Type) as
`TMA`.

{% aspTab template="chart/technical-indicators/tma", sourceFiles="tma.cs" %}

{% endaspTab %}

**Customization of Technical Indicators**

`stroke`, `stroke-width`, and `color` of signalLine can be customized by using,[`fill`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartIndicator.html#Syncfusion_EJ2_Charts_ChartIndicator_Fill),
[`width`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartIndicator.html#Syncfusion_EJ2_Charts_ChartIndicator_Width)
and [`dashArray`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartIndicator.html#Syncfusion_EJ2_Charts_ChartIndicator_DashArray)
properties and the [`period`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartIndicator.html#Syncfusion_EJ2_Charts_ChartIndicator_Period)
property is used to predict the data forecast calculations. The [`field`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartIndicator.html#Syncfusion_EJ2_Charts_ChartIndicator_Field)
value is used to the compare the current price with previous price. It is applicable to Bollinger bands and moving
averages. The [`showZones`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartIndicator.html#Syncfusion_EJ2_Charts_ChartIndicator_ShowZones)
property is used to shows/Hides the overBought and overSold regions. It is applicable for RSI and stochastic indicators.

{% aspTab template="chart/technical-indicators/custom-tma", sourceFiles="custom-tma.cs" %}

{% endaspTab %}

**Data Source**

Usually technical indicators are added along with a financial series. The [`seriesName`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartIndicator.html#Syncfusion_EJ2_Charts_ChartIndicator_SeriesName)
represents the series, the data of which has to be analysed through indicators.

Technical indicators can also be added without series using [`dataSource`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartIndicator.html#Syncfusion_EJ2_Charts_ChartIndicator_DataSource) property of indicator.

{% aspTab template="chart/technical-indicators/datasource", sourceFiles="datasource.cs" %}

{% endaspTab %}