---
layout: post
title: Date Time Axis in ##Platform_Name## Chart Component
description: Learn here all about Date Time Axis in Syncfusion ##Platform_Name## Chart component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Date Time Axis
publishingplatform: ##Platform_Name##
documentation: ug
---


<!-- markdownlint-disable MD036 -->

# DateTime and DateTimeCategory Axis

## DateTime Axis

The DateTime axis uses a date-time scale and displays date-time values as axis labels based on the specified format. This axis type is ideal for visualizing time-based data such as trends, timelines, and time-series data.

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

The DateTimeCategory axis is used to render date-time values with non-linear intervals. This axis type is especially useful when certain time ranges, such as weekends or holidays, need to be excluded. In the following example, only business days are displayed within a week.

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

Range of an axis will be calculated automatically based on the provided data, you can also customize the range of the axis using [`Minimum`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_Minimum), [`Maximum`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_Maximum) and [`Interval`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_Interval) property of the axis.

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

Date-time intervals can be customized using the [`Interval`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_Interval) and [`IntervalType`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_IntervalType) properties of the axis. For example, when the interval is set to `2` and the interval type is set to `Years`, the axis displays labels at two-year intervals.

The DateTime axis supports the following interval types:

- Auto
- Years
- Months
- Days
- Hours
- Minutes
- Seconds

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

Padding can be applied to the minimum and maximum values of the axis range using the [`RangePadding`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_RangePadding) property. The DateTime axis supports the following range padding types:

- None
- Round
- Additional

**DateTime - None**

When the [`RangePadding`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_RangePadding) property is set to `None`, the minimum and maximum values of the axis are calculated directly from the data values.

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

When the [`RangePadding`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_RangePadding) property is set to `Round`, the minimum and maximum values are rounded to the nearest interval boundary. For example, if the minimum value is January 15 and the interval type is set to `Months` with an interval of `1`, the axis minimum is adjusted to January 1.

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

When the [`RangePadding`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_RangePadding) property is set to `Additional`, an additional interval is added before the minimum and after the maximum values of the axis range to provide extra spacing.

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

Date values displayed on the DateTime axis can be formatted using the [`LabelFormat`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_LabelFormat) property. This property supports globalized date and time formats for clear and localized label rendering.

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



The following table illustrates the output produced by applying commonly used date-time format strings to the `LabelFormat` property.

<!-- markdownlint-disable MD033 -->

<table>
    <tr>
        <td><b>Label Value</b></td>
        <td><b>Label Format Property Value</b></td>
        <td><b>Result</b></td>
        <td><b>Description</b></td>
    </tr>
    <tr>
        <td>new Date(2000, 03, 10)</td>
        <td>EEEE</td>
        <td>Monday</td>
        <td>Displays the full name of the day</td>
    </tr>
    <tr>
        <td>new Date(2000, 03, 10)</td>
        <td>yMd</td>
        <td>04/10/2000</td>
        <td>Displays the date in month/day/year format</td>
    </tr>
    <tr>
        <td>new Date(2000, 03, 10)</td>
        <td>MMM</td>
        <td>Apr</td>
        <td>Displays the abbreviated month name</td>
    </tr>
    <tr>
        <td>new Date(2000, 03, 10)</td>
        <td>hm</td>
        <tdtd>
        <td>Displays the time in hours and minutes</td>
    </tr>
    <tr>
        <td>new Date(2000, 03, 10)</td>
        <td>hms</td>
        <td>12:00:00 AM</td>
        <td>Displays the time in hours, minutes, and seconds</td>
    </tr>
</table>

<!-- markdownlint-disable MD033 -->

## Custom Label Format

Axis also supports custom label format using placeholder like `{value}°C`, in which the value represent the axis label e.g 20°C.

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

