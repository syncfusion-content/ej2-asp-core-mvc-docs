---
layout: post
title: Date Time Axis in ##Platform_Name## Chart Component
description: Learn here all about Date Time Axis in Syncfusion ##Platform_Name## Chart component and more.
platform: ej2-asp-core-mvc
control: Date Time Axis
publishingplatform: ##Platform_Name##
documentation: ug
---


<!-- markdownlint-disable MD036 -->

# DateTime and DateTimeCategory Axis

## DateTime Axis

 Date time axis uses date time scale and displays the date time values as axis labels in the specified format.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/datetime/dateTime/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Datetime.cs" %}
{% include code-snippet/chart/axis/datetime/dateTime/datetime.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/datetime/dateTime/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Datetime.cs" %}
{% include code-snippet/chart/axis/datetime/dateTime/datetime.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## DateTimeCategory Axis

Date-time category axis is used to display the date-time values with non-linear intervals. For example, the
business days alone have been depicted in a week here.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/datetime/datetimeCategory/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="DateCategory.cs" %}
{% include code-snippet/chart/axis/datetime/datetimeCategory/dateCategory.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/datetime/datetimeCategory/razor %}
{% endhighlight %}
{% highlight c# tabtitle="DateCategory.cs" %}
{% include code-snippet/chart/axis/datetime/datetimeCategory/dateCategory.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Range

Range for an axis, will be calculated automatically based on the provided data, you can also customize the range
of the axis using [`Minimum`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_Minimum), [`Maximum`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_Maximum)
and [`Interval`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_Interval) property of the axis.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/datetime/range/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Range.cs" %}
{% include code-snippet/chart/axis/datetime/range/range.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/datetime/range/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Range.cs" %}
{% include code-snippet/chart/axis/datetime/range/range.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Interval Customization

Date time intervals can be customized by using the [`Interval`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_Interval) and
[`IntervalType`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_IntervalType) properties of the axis.
For example, when you set interval as 2 and intervalType as years, it considers 2 years as interval.
DateTime axis supports following interval types,

* Auto
* Years
* Months
* Days
* Hours
* Minutes
* Seconds

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/datetime/interval/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Interval.cs" %}
{% include code-snippet/chart/axis/datetime/interval/interval.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/datetime/interval/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Interval.cs" %}
{% include code-snippet/chart/axis/datetime/interval/interval.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



**Applying Padding to the Range**

Padding can be applied to the minimum and maximum extremes of the range by using the
[`RangePadding`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_RangePadding) property. Date time axis supports the following types
of padding,

* None
* Round
* Additional

**DateTime - None**

When the [`RangePadding`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_RangePadding) is set to `None`, minimum and maximum of the axis is based on the data.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/datetime/none/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="None.cs" %}
{% include code-snippet/chart/axis/datetime/none/none.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/datetime/none/razor %}
{% endhighlight %}
{% highlight c# tabtitle="None.cs" %}
{% include code-snippet/chart/axis/datetime/none/none.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



**DateTime - Round**

When the [`RangePadding`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_RangePadding) is set to `Round`, minimum and maximum will be
rounded to the nearest possible value divisible by interval. For example, when the minimum is 15th Jan, interval is
1 and the interval type is ‘month’, then the axis minimum will be Jan 1st.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/datetime/round/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Round.cs" %}
{% include code-snippet/chart/axis/datetime/round/round.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/datetime/round/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Round.cs" %}
{% include code-snippet/chart/axis/datetime/round/round.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



**DateTime - Additional**

When the [`RangePadding`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_RangePadding) is set to `Additional`, interval of an axis will
be padded to the minimum and maximum of the axis.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/datetime/additional/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Additional.cs" %}
{% include code-snippet/chart/axis/datetime/additional/additional.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/datetime/additional/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Additional.cs" %}
{% include code-snippet/chart/axis/datetime/additional/additional.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Label Format

You can format and parse the date to all globalize format using [`LabelFormat`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_LabelFormat) property in an axis.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/datetime/label-format/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Label-format.cs" %}
{% include code-snippet/chart/axis/datetime/label-format/label-format.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/datetime/label-format/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Label-format.cs" %}
{% include code-snippet/chart/axis/datetime/label-format/label-format.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



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

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/datetime/custom/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Custom.cs" %}
{% include code-snippet/chart/axis/datetime/custom/custom.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/datetime/custom/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Custom.cs" %}
{% include code-snippet/chart/axis/datetime/custom/custom.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

