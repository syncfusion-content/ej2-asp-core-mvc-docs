---
title: " Chart Logarithmic Axis | ASP.NET MVC "

component: "Chart"

description: "Logarithmic axis uses logarithmic scale is defined as one where the units on an axis are powers, or logarithms, of a base number, usually 10."
---

# Logarithmic Axis

<!-- markdownlint-disable MD033 -->

Logarithmic axis uses logarithmic scale and it is very useful in visualizing data, when it has numeric values in
both lower order of magnitude (eg: 10<sup>-6</sup>) and higher order of magnitude (eg: 10<sup>6</sup>).

{% aspTab template="chart/axis/log/log", sourceFiles="log.cs" %}

{% endaspTab %}

## Range

Range of an axis, will be calculated automatically based on the provided data, you can also customize the range
of the axis using [`minimum`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_Minimum), [`maximum`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_Maximum)
and [`interval`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_Interval) property of the axis.

{% aspTab template="chart/axis/log/range", sourceFiles="range.cs" %}

{% endaspTab %}

## Logarithmic Base

Logarithmic base can be customized by using the [`logBase`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_LogBase) property of the axis.
For example when the logBase is 5, the axis values follows 5<sup>-2</sup>, 5<sup>-1</sup>, 5<sup>0</sup>,
5<sup>1</sup>, 5<sup>2</sup> etc.

{% aspTab template="chart/axis/log/base", sourceFiles="base.cs" %}

{% endaspTab %}

## Logarithmic Interval

Logarithmic axis interval can be customized by using the [`interval`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_Interval)
property of the axis. When the logarithmic base is 10 and logarithmic interval is 2, then the axis labels are
placed at an interval of 10<sup>2</sup>. The default value of the interval is 1.

{% aspTab template="chart/axis/log/interval", sourceFiles="interval.cs" %}

{% endaspTab %}