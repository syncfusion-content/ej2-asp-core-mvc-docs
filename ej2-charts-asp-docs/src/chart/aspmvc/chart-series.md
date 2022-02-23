---
title: " Chart Series | ASP.NET MVC "

component: "Chart"

description: "Chart supports to render collection of series like multiple series or combination series."
---

# Chart Series

## Multiple Series

You can add multiple series to the chart by using [`Series`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartSeries.html) property.
The series are rendered in the order as it is added to the series array.

{% aspTab template="chart/series/multiple-series", sourceFiles="multiple-series.cs" %}

{% endaspTab %}

## Combination Series

Combination of different types like Line, column etc, can be rendered in a chart.

>Bar series cannot be combined with any other series as the axis orientation is different from other series.

{% aspTab template="chart/series/combination", sourceFiles="combination.cs" %}

{% endaspTab %}

## Enable Complex Property in Series

By setting `EnableComplexProperty` value as `true` in series you can bind complex data to the chart.

{% aspTab template="chart/series/complex", sourceFiles="complex.cs" %}

{% endaspTab %}