---
title: " Chart Datetime Axis | ASP.NET MVC "

component: "Chart"

description: "Date time axis uses date time scale and displays the date time values as axis labels in the specified format."
---

<!-- markdownlint-disable MD036 -->

# DateTime and DateTimeCategory Axis

## DateTime Axis

 Date time axis uses date time scale and displays the date time values as axis labels in the specified format.

{% aspTab template="chart/axis/datetime/dateTime", sourceFiles="datetime.cs" %}

{% endaspTab %}

## DateTimeCategory Axis

Date-time category axis is used to display the date-time values with non-linear intervals. For example, the
business days alone have been depicted in a week here.

{% aspTab template="chart/axis/datetime/datetimeCategory", sourceFiles="dateCategory.cs" %}

{% endaspTab %}

### Range

Range for an axis, will be calculated automatically based on the provided data, you can also customize the range
of the axis using [`minimum`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_Minimum), [`maximum`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_Maximum)
and [`interval`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_Interval) property of the axis.

{% aspTab template="chart/axis/datetime/range", sourceFiles="range.cs" %}

{% endaspTab %}

### Interval Customization

Date time intervals can be customized by using the [`interval`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_Interval) and
[`intervalType`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_IntervalType) properties of the axis.
For example, when you set interval as 2 and intervalType as years, it considers 2 years as interval.
DateTime axis supports following interval types,

* Auto
* Years
* Months
* Days
* Hours
* Minutes
* Seconds

{% aspTab template="chart/axis/datetime/interval", sourceFiles="interval.cs" %}

{% endaspTab %}

**Applying Padding to the Range**

Padding can be applied to the minimum and maximum extremes of the range by using the
[`rangePadding`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_RangePadding) property. Date time axis supports the following types
of padding,

* None
* Round
* Additional

**DateTime - None**

When the [`rangePadding`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_RangePadding) is set to `None`, minimum and maximum of the axis is based on the data.

{% aspTab template="chart/axis/datetime/none", sourceFiles="none.cs" %}

{% endaspTab %}

**DateTime - Round**

When the [`rangePadding`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_RangePadding) is set to `Round`, minimum and maximum will be
rounded to the nearest possible value divisible by interval. For example, when the minimum is 15th Jan, interval is
1 and the interval type is ‘month’, then the axis minimum will be Jan 1st.

{% aspTab template="chart/axis/datetime/round", sourceFiles="round.cs" %}

{% endaspTab %}

**DateTime - Additional**

When the [`rangePadding`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_RangePadding) is set to `Additional`, interval of an axis will
be padded to the minimum and maximum of the axis.

{% aspTab template="chart/axis/datetime/additional", sourceFiles="additional.cs" %}

{% endaspTab %}

## Label Format

You can format and parse the date to all globalize format using [`labelFormat`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_LabelFormat) property in an axis.

{% aspTab template="chart/axis/datetime/label-format", sourceFiles="label-format.cs" %}

{% endaspTab %}

The following table describes the result of applying some common date time formats to the labelFormat property

<!-- markdownlint-disable MD033 -->

<table>
<tr>
<td><b>Label Value</b></td>
<td><b>Label Format Property Value</b></td>
<td><b>Result </b></td>
<td><b>Description </b></td>
</tr>
<tr>
<td>new Date(2000, 03, 10)</td>
<td>EEEE</td>
<td>Monday</td>
<td>The Date is displayed in day format</td>
</tr>
<tr>
<td>new Date(2000, 03, 10)</td>
<td>yMd</td>
<td>04/10/2000</td>
<td>The Date is displayed in month/date/year format</td>
</tr>
<tr>
<td>new Date(2000, 03, 10)</td>
<td> MMM </td>
<td>Apr</td>
<td>The Shorthand month for the date is displayed</td>
</tr>
<tr>
<td>new Date(2000, 03, 10)</td>
<td>hm</td>
<td>12:00 AM</td>
<td>Time of the date value is displayed as label</td>
</tr>
<tr>
<td>new Date(2000, 03, 10)</td>
<td>hms</td>
<td>12:00:00 AM</td>
<td>The Label is displayed in hours:minutes:seconds format</td>
</tr>
</table>

<!-- markdownlint-disable MD033 -->

## Custom Label Format

Axis also supports custom label format using placeholder like {value}°C, in which the value represent the axis
label e.g 20°C.

{% aspTab template="chart/axis/datetime/custom", sourceFiles="custom.cs" %}

{% endaspTab %}