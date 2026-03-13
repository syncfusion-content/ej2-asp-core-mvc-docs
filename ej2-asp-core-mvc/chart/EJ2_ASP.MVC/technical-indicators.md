---
layout: post
title: Technical Indicators in ##Platform_Name## Chart Component
description: Learn here all about Technical Indicators in Syncfusion ##Platform_Name## Chart component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Technical Indicators
publishingplatform: ##Platform_Name##
documentation: ug
---


<!-- markdownlint-disable MD036 -->

# Technical Indicators

A [`Technical indicator`](https://www.syncfusion.com/aspnet-core-ui-controls/charts/technical-indicators) is a mathematical calculation based on historical price, volume, or open‑interest information that aims to forecast financial market direction.

Chart supports 10 types of technical indicators.

## Accumulation Distribution

Accumulation Distribution combines price and volume to show how money may be flowing into or out of a stock. To render an [`Accumulation Distribution Indicator`](https://ej2.syncfusion.com/aspnetcore/Chart/ADIChart#/material), use indicator [`Type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartIndicator.html#Syncfusion_EJ2_Charts_ChartIndicator_Type) as `AccumulationDistribution`. To calculate the signal line, the [`Volume`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartIndicator.html#Syncfusion_EJ2_Charts_ChartIndicator_Volume) field must be included in the `DataSource`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/technical-indicators/ad/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Ad.cs" %}
{% include code-snippet/chart/technical-indicators/ad/ad.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/technical-indicators/ad/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Ad.cs" %}
{% include code-snippet/chart/technical-indicators/ad/ad.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Average True Range (ATR)

ATR measures stock volatility by comparing the current value with the previous value. To render an Average True Range (ATR) indicator, use indicator [`Type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartIndicator.html#Syncfusion_EJ2_Charts_ChartIndicator_Type) as `Atr`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/technical-indicators/atr/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Atr.cs" %}
{% include code-snippet/chart/technical-indicators/atr/atr.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/technical-indicators/atr/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Atr.cs" %}
{% include code-snippet/chart/technical-indicators/atr/atr.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Bollinger Band

A chart overlay that shows the upper and lower limits of normal price movements based on the standard deviation of prices. To render a Bollinger Band, use indicator [`Type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartIndicator.html#Syncfusion_EJ2_Charts_ChartIndicator_Type) as `BollingerBand`. Bollinger Band is represented by three lines (`upperLine`, `lowerLine`, `signalLine`). The default values of the Bollinger Band [`Period`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartIndicator.html#Syncfusion_EJ2_Charts_ChartIndicator_Period) is 14 and [`StandardDeviations`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartIndicator.html#Syncfusion_EJ2_Charts_ChartIndicator_StandardDeviation) is 2.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/technical-indicators/bollinger/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Bollinger.cs" %}
{% include code-snippet/chart/technical-indicators/bollinger/bollinger.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/technical-indicators/bollinger/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Bollinger.cs" %}
{% include code-snippet/chart/technical-indicators/bollinger/bollinger.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



**Customization of BollingerBand**

`stroke`, `stroke-width`, and `color` of `upperLine` can be customized by using [`UpperLine`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartIndicator.html#Syncfusion_EJ2_Charts_ChartIndicator_UpperLine), and the `lowerLine` can be customized by using [`LowerLine`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartIndicator.html#Syncfusion_EJ2_Charts_ChartIndicator_LowerLine) properties of the indicator.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/getting-started/custom-bollinger/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-bollinger.cs" %}
{% include code-snippet/chart/getting-started/custom-bollinger/custom-bollinger.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/getting-started/custom-bollinger/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-bollinger.cs" %}
{% include code-snippet/chart/getting-started/custom-bollinger/custom-bollinger.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Exponential Moving Average (EMA)

Moving average indicators are used to define the direction of the trend. To render an EMA indicator, use indicator [`Type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartIndicator.html#Syncfusion_EJ2_Charts_ChartIndicator_Type) as `Ema`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/technical-indicators/ema/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Ema.cs" %}
{% include code-snippet/chart/technical-indicators/ema/ema.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/technical-indicators/ema/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Ema.cs" %}
{% include code-snippet/chart/technical-indicators/ema/ema.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Momentum

Momentum shows the speed at which the stock price is changing. To render a Momentum indicator, use indicator [`Type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartIndicator.html#Syncfusion_EJ2_Charts_ChartIndicator_Type) as `Momentum`. The Momentum indicator is represented by two lines (`upperLine`, `signalLine`). In the Momentum indicator, the `upperBand` value is always rendered at 100.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/technical-indicators/momentum/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Momentum.cs" %}
{% include code-snippet/chart/technical-indicators/momentum/momentum.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/technical-indicators/momentum/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Momentum.cs" %}
{% include code-snippet/chart/technical-indicators/momentum/momentum.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



**Customization of MomentumIndicator**

`stroke`, `stroke-width`, and `color` of `upperLine` can be customized by using the [`UpperLine`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartIndicator.html#Syncfusion_EJ2_Charts_ChartIndicator_UpperLine) property of the indicator.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/technical-indicators/custom-momentum/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-momentum.cs" %}
{% include code-snippet/chart/technical-indicators/custom-momentum/custom-momentum.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/technical-indicators/custom-momentum/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-momentum.cs" %}
{% include code-snippet/chart/technical-indicators/custom-momentum/custom-momentum.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Moving Average Convergence Divergence (MACD)

MACD is based on the difference between two EMAs. To render a MACD indicator, use indicator [`Type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartIndicator.html#Syncfusion_EJ2_Charts_ChartIndicator_Type) as `Macd`. The MACD indicator is represented by the MACD line, signal line, and MACD histogram. The MACD histogram highlights the difference between the MACD line and the signal line.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/technical-indicators/macd/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Macd.cs" %}
{% include code-snippet/chart/technical-indicators/macd/macd.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/technical-indicators/macd/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Macd.cs" %}
{% include code-snippet/chart/technical-indicators/macd/macd.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



**Customization of MACD**

`stroke`, `stroke-width`, and `color` of `macdLine` can be customized by using the [`MacdLine`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartIndicator.html#Syncfusion_EJ2_Charts_ChartIndicator_MacdLine) property of the indicator. The positive and negative changes of the histogram can be customized by [`MacdPositiveColor`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartIndicator.html#Syncfusion_EJ2_Charts_ChartIndicator_MacdPositiveColor) and [`MacdNegativeColor`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartIndicator.html#Syncfusion_EJ2_Charts_ChartIndicator_MacdNegativeColor) properties. The [`MacdType`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartIndicator.html#Syncfusion_EJ2_Charts_ChartIndicator_MacdType) is used to define the type of MACD indicator. Customize the MACD period using [`SlowPeriod`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartIndicator.html#Syncfusion_EJ2_Charts_ChartIndicator_SlowPeriod) and [`FastPeriod`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartIndicator.html#Syncfusion_EJ2_Charts_ChartIndicator_FastPeriod) properties.

By default, `MacdType` is `Both`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/technical-indicators/custom-macd/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-macd.cs" %}
{% include code-snippet/chart/technical-indicators/custom-macd/custom-macd.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/technical-indicators/custom-macd/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-macd.cs" %}
{% include code-snippet/chart/technical-indicators/custom-macd/custom-macd.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Relative Strength Index (RSI)

RSI shows how strongly a stock is moving in its current direction. To render an RSI indicator, use indicator [`Type`](./https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartIndicator.html#Syncfusion_EJ2_Charts_ChartIndicator_Type) as `Rsi`. The RSI indicator is represented by three lines (`upperBand`, `lowerBand`, `signalLine`). The `upperBand` and `lowerBand` values are customized by [`OverBought`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartIndicator.html#Syncfusion_EJ2_Charts_ChartIndicator_OverBought) and [`OverSold`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartIndicator.html#Syncfusion_EJ2_Charts_ChartIndicator_OverSold) properties of the indicator, and the `signalLine` is calculated using the RSI formula.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/technical-indicators/rsi/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Rsi.cs" %}
{% include code-snippet/chart/technical-indicators/rsi/rsi.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/technical-indicators/rsi/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Rsi.cs" %}
{% include code-snippet/chart/technical-indicators/rsi/rsi.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Simple Moving Average (SMA)

Moving average indicators are used to define the direction of the trend. To render an SMA indicator, use indicator [`Type`](./https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartIndicator.html#Syncfusion_EJ2_Charts_ChartIndicator_Type) as `Sma`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/technical-indicators/sma/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Sma.cs" %}
{% include code-snippet/chart/technical-indicators/sma/sma.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/technical-indicators/sma/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Sma.cs" %}
{% include code-snippet/chart/technical-indicators/sma/sma.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Stochastic

Stochastic shows how a stock compares to its previous price levels. To render a Stochastic indicator, use indicator [`Type`](./https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartIndicator.html#Syncfusion_EJ2_Charts_ChartIndicator_Type) as `Stochastic`. The Stochastic indicator is represented by four lines (`upperLine`, `lowerLine`, `periodLine`, `signalLine`). The `upperBand` and `lowerBand` values are customized by [`OverBought`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartIndicator.html#Syncfusion_EJ2_Charts_ChartIndicator_OverBought) and [`OverSold`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartIndicator.html#Syncfusion_EJ2_Charts_ChartIndicator_OverSold) properties of the indicator, and the `periodLine` and `signalLine` are rendered based on the stochastic formula.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/technical-indicators/stochastic/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Stochastic.cs" %}
{% include code-snippet/chart/technical-indicators/stochastic/stochastic.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/technical-indicators/stochastic/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Stochastic.cs" %}
{% include code-snippet/chart/technical-indicators/stochastic/stochastic.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



**Customization of StochasticIndicator**

`stroke`, `stroke-width`, and `color` of `upperLine` can be customized by using [`UpperLine`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartIndicator.html#Syncfusion_EJ2_Charts_ChartIndicator_UpperLine), the `lowerLine` can be customized by using [`LowerLine`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartIndicator.html#Syncfusion_EJ2_Charts_ChartIndicator_LowerLine), and the `periodLine` can be customized by using [`PeriodLine`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartIndicator.html#Syncfusion_EJ2_Charts_ChartIndicator_PeriodLine) properties of the indicator. Customize the period used to find the average price using [`KPeriod`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartIndicator.html#Syncfusion_EJ2_Charts_ChartIndicator_KPeriod) and [`DPeriod`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartIndicator.html#Syncfusion_EJ2_Charts_ChartIndicator_DPeriod) properties.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/technical-indicators/custom-stochastic/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-stochastic.cs" %}
{% include code-snippet/chart/technical-indicators/custom-stochastic/custom-stochastic.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/technical-indicators/custom-stochastic/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-stochastic.cs" %}
{% include code-snippet/chart/technical-indicators/custom-stochastic/custom-stochastic.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Triangular Moving Average (TMA)

Moving average indicators are used to define the direction of the trend. To render a TMA indicator, use indicator [`Type`](./https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartIndicator.html#Syncfusion_EJ2_Charts_ChartIndicator_Type) as `Tma`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/technical-indicators/tma/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Tma.cs" %}
{% include code-snippet/chart/technical-indicators/tma/tma.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/technical-indicators/tma/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Tma.cs" %}
{% include code-snippet/chart/technical-indicators/tma/tma.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



**Customization of Technical Indicators**

`stroke`, `stroke-width`, and `color` of `signalLine` can be customized by using [`Fill`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartIndicator.html#Syncfusion_EJ2_Charts_ChartIndicator_Fill), [`Width`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartIndicator.html#Syncfusion_EJ2_Charts_ChartIndicator_Width), and [`DashArray`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartIndicator.html#Syncfusion_EJ2_Charts_ChartIndicator_DashArray) properties. The [`Period`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartIndicator.html#Syncfusion_EJ2_Charts_ChartIndicator_Period) property defines the number of data points used for calculations. The [`Field`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartIndicator.html#Syncfusion_EJ2_Charts_ChartIndicator_Field) value determines which price value to compare with the previous price. It is applicable to Bollinger Bands and moving averages. The [`ShowZones`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartIndicator.html#Syncfusion_EJ2_Charts_ChartIndicator_ShowZones) property shows or hides the overbought and oversold regions. It is applicable for RSI and Stochastic indicators.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/technical-indicators/custom-tma/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-tma.cs" %}
{% include code-snippet/chart/technical-indicators/custom-tma/custom-tma.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/technical-indicators/custom-tma/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-tma.cs" %}
{% include code-snippet/chart/technical-indicators/custom-tma/custom-tma.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



**Data Source**

Usually, technical indicators are added along with a financial series. The [`SeriesName`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartIndicator.html#Syncfusion_EJ2_Charts_ChartIndicator_SeriesName) represents the series whose data has to be analyzed through indicators.

Technical indicators can also be added without a series by using the [`DataSource`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartIndicator.html#Syncfusion_EJ2_Charts_ChartIndicator_DataSource) property of the indicator.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/technical-indicators/datasource/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Datasource.cs" %}
{% include code-snippet/chart/technical-indicators/datasource/datasource.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/technical-indicators/datasource/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Datasource.cs" %}
{% include code-snippet/chart/technical-indicators/datasource/datasource.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

