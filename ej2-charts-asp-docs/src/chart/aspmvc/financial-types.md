---
title: " Financial charts | ASP.NET MVC "

component: "Chart"

description: "Financial charts are used to illustrate the movements in the price of a financial instrument over time. chart have hilo, hiloopenclose,candle."
---

# Financial Charts

Financial charts are used to illustrate the movements in the price of a financial instrument over time.

Chart supports the following financial series

<!-- markdownlint-disable MD036 -->

## Hilo

Hilo Series illustrates the price movements in stock using the high and low values.
To render a Hilo series, use series [`Type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Type) as `Hilo`.

Hilo series requires 3 fields (x, high and low) to show the high and low price in the stock.

{% aspTab template="chart/series/financial-charts/hilo", sourceFiles="hilo.cs" %}

{% endaspTab %}

## High Low Open Close

HiloOpenClose series is used to represent the low, high, open and closing values over time.
To render a HiloOpenClose series, use series [`Type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Type) as `HiloOpenClose`.

HiloOpenClose series requires 5 fields (x, high, low, open and close) to show the high, low, open and close price
values in the stock.

{% aspTab template="chart/series/financial-charts/hilo-openclose", sourceFiles="hilo-openclose.cs" %}

{% endaspTab %}

### Customization of HiloOpenClose Series

In HiloOpenClose series, [`BullFillColor`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_BullFillColor) is used to fill the
 segment when the open value is greater than the close value and
[`BearFillColor`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_BearFillColor) is used to fill the segment when the open
value is less than the close value.

By default, bullFillColor is set as red and bearFillColor is set as green.

{% aspTab template="chart/series/financial-charts/custom-openclose", sourceFiles="custom-openclose.cs" %}

{% endaspTab %}

## Candle

Candle series are similar to Hilo Open Close series, are used to represent the low,
high, open and closing price over time. To render a candle series, use series
[`Type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Type) as `Candle`.

{% aspTab template="chart/series/financial-charts/candle", sourceFiles="candle.cs" %}

{% endaspTab %}

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

{% aspTab template="chart/series/financial-charts/solid-candles", sourceFiles="solid-candles.cs" %}

{% endaspTab %}

## See Also

* [Data label](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartDataLabelSettings.html)
* [Tooltip](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartTooltipSettings.html)