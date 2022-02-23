---
title: " Chart Numeric Axis | ASP.NET MVC "

component: "Chart"

description: "Numeric axis used to represent numeric values data in chart. we can customize the range, label format and ranga padding in numeric axis. "
---

<!-- markdownlint-disable MD036 -->

# Numeric Axis

You can use numeric [`axis`](https://ej2.syncfusion.com/aspnetcore/Chart/NumericAxis#/material) to represent numeric values of data in chart. By default, the `valueType` of an axis is [`Double`](https://www.syncfusion.com/aspnet-core-ui-controls/charts/chart-axis).

{% aspTab template="chart/axis/double/double", sourceFiles="double.cs" %}

{% endaspTab %}

## Range

Range for an axis, will be calculated automatically based on the provided data, you can also customize the range
of the axis using [`minimum`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_Minimum), [`maximum`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_Maximum)
and [`interval`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_Interval) property of the axis.

{% aspTab template="chart/axis/double/range", sourceFiles="range.cs" %}

{% endaspTab %}

## Range Padding

Padding can be applied to the minimum and maximum extremes of the axis range by using the
[`rangePadding`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_RangePadding) property. Numeric axis supports following types of padding.

* None
* Round
* Additional
* Normal
* Auto

**Numeric - None**

When the [`rangePadding`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_RangePadding) is set to `None`, minimum and maximum of an axis is based on the data.

{% aspTab template="chart/axis/double/none", sourceFiles="none.cs" %}

{% endaspTab %}

**Numeric - Round**

When the [`rangePadding`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_RangePadding) is set to `Round`, minimum and maximum will be
rounded to the nearest possible value divisible by interval. For example, when the minimum is 3.5 and the interval
is 1, then the minimum will be rounded to 3.

{% aspTab template="chart/axis/double/round", sourceFiles="round.cs" %}

{% endaspTab %}

**Numeric - Additional**

When the [`rangePadding`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_RangePadding) is set to `Additional`, interval of an axis will
be padded to the minimum and maximum of the axis.

{% aspTab template="chart/axis/double/additional", sourceFiles="additional.cs" %}

{% endaspTab %}

**Numeric - Normal**

When the [`rangePadding`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_RangePadding) is set to `Normal`, padding is applied to the axis
based on default range calculation.

{% aspTab template="chart/axis/double/normal", sourceFiles="normal.cs" %}

{% endaspTab %}

**Numeric - Auto**

When the [`rangePadding`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_RangePadding) is set to `Auto`,horizontal numeric axis takes
None as padding calculation, while the vertical numeric axis takes Normal as padding calculation.

{% aspTab template="chart/axis/double/auto", sourceFiles="auto.cs" %}

{% endaspTab %}

## Label Format

**Numeric Label Format**

Numeric labels can be formatted by using the [`labelFormat`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_LabelFormat) property.
Numeric labels supports all globalize format.

{% aspTab template="chart/axis/double/label-format", sourceFiles="label-format.cs" %}

{% endaspTab %}

The following table describes the result of applying some commonly used label formats on numeric values.

<!-- markdownlint-disable MD033 -->

<table>
<tr>
<td><b>Label Value</b></td>
<td><b>Label Format property value</b></td>
<td><b>Result </b></td>
<td><b>Description </b></td>
</tr>
<tr>
<td>1000</td>
<td>n1</td>
<td>1000.0</td>
<td>The Number is rounded to 1 decimal place</td>
</tr>
<tr>
<td>1000</td>
<td>n2</td>
<td>1000.00</td>
<td>The Number is rounded to 2 decimal place</td>
</tr>
<tr>
<td>1000</td>
<td>n3</td>
<td>1000.000</td>
<td>The Number is rounded to 3 decimal place</td>
</tr>
<tr>
<td>0.01</td>
<td>p1</td>
<td>1.0%</td>
<td>The Number is converted to percentage with 1 decimal place</td>
</tr>
<tr>
<td>0.01</td>
<td>p2</td>
<td>1.00%</td>
<td>The Number is converted to percentage with 2 decimal place</td>
</tr>
<tr>
<td>0.01</td>
<td>p3</td>
<td>1.000%</td>
<td>The Number is converted to percentage with 3 decimal place</td>
</tr>
<tr>
<td>1000</td>
<td>c1</td>
<td>$1000.0</td>
<td>The Currency symbol is appended to number and number is rounded to 1 decimal place</td>
</tr>
<tr>
<td>1000</td>
<td>c2</td>
<td>$1000.00</td>
<td>The Currency symbol is appended to number and number is rounded to 2 decimal place</td>
</tr>
</table>

## GroupingSeparator

To separate groups of thousands, use [`useGroupingSeparator`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.Chart.html)
property in chart.

{% aspTab template="chart/axis/double/group", sourceFiles="group.cs" %}

{% endaspTab %}

## Custom Label Format

Axis also supports custom label format using placeholder like {value}°C, in which the value represent the axis
label e.g 20°C.

{% aspTab template="chart/axis/double/custom", sourceFiles="custom.cs" %}

{% endaspTab %}