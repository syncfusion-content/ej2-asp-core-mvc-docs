---
layout: post
title: Date time axis in ##Platform_Name## 3D Chart Component
description: Learn here all about date time axis in Syncfusion ##Platform_Name## 3D Chart component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Date Time Axis
publishingplatform: ##Platform_Name##
documentation: ug
---

# Date time axis in ##Platform_Name## 3D Chart Component

## DateTime axis

Date time axis uses date time scale and displays the date time values as axis labels in the specified format.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/datetime-axis/datetime/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Datetime.cs" %}
{% include code-snippet/3d-chart/series/datetime-axis/datetime/datetime.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/datetime-axis/datetime/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Datetime.cs" %}
{% include code-snippet/3d-chart/series/datetime-axis/datetime/datetime.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## DateTimeCategory axis

Date-time category axis is used to display the date-time values with non-linear intervals. For example, the business days alone have been depicted in a week here.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/datetime-axis/datetime-category/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Datetime-category.cs" %}
{% include code-snippet/3d-chart/series/datetime-axis/datetime-category/datetime-category.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/datetime-axis/datetime-category/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Datetime-category.cs" %}
{% include code-snippet/3d-chart/series/datetime-axis/datetime-category/datetime-category.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Range

Range of an axis will be calculated automatically based on the provided data, you can also customize the range of the axis using [`Minimum`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.Chart3DAxis.html#Syncfusion_EJ2_Charts_Chart3DAxis_Minimum), [`Maximum`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.Chart3DAxis.html#Syncfusion_EJ2_Charts_Chart3DAxis_Maximum) and [`Interval`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.Chart3DAxis.html#Syncfusion_EJ2_Charts_Chart3DAxis_Interval) property of the axis.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/datetime-axis/range/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Range.cs" %}
{% include code-snippet/3d-chart/series/datetime-axis/range/range.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/datetime-axis/range/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Range.cs" %}
{% include code-snippet/3d-chart/series/datetime-axis/range/range.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Interval customization

Date time intervals can be customized by using the [`Interval`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.Chart3DAxis.html#Syncfusion_EJ2_Charts_Chart3DAxis_Interval) and [`IntervalType`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.Chart3DAxis.html#Syncfusion_EJ2_Charts_Chart3DAxis_IntervalType) properties of the axis. For example, when you set interval as 2 and intervalType as years, it considers 2 years as interval. Datetime axis supports following interval types,

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
{% include code-snippet/3d-chart/series/datetime-axis/interval/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Interval.cs" %}
{% include code-snippet/3d-chart/series/datetime-axis/interval/interval.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/datetime-axis/interval/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Interval.cs" %}
{% include code-snippet/3d-chart/series/datetime-axis/interval/interval.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



**Applying padding to the range**

Padding can be applied to the minimum and maximum extremes of the range by using the [`RangePadding`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.Chart3DAxis.html#Syncfusion_EJ2_Charts_Chart3DAxis_RangePadding) property. Date time axis supports the following types of padding,

* None
* Round
* Additional

**Datetime - None**

When the [`RangePadding`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.Chart3DAxis.html#Syncfusion_EJ2_Charts_Chart3DAxis_RangePadding) is set to `None`, minimum and maximum of an axis is based on the data.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/datetime-axis/none/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="None.cs" %}
{% include code-snippet/3d-chart/series/datetime-axis/none/none.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/datetime-axis/none/razor %}
{% endhighlight %}
{% highlight c# tabtitle="None.cs" %}
{% include code-snippet/3d-chart/series/datetime-axis/none/none.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



**Datetime - Round**

When the [`RangePadding`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.Chart3DAxis.html#Syncfusion_EJ2_Charts_Chart3DAxis_RangePadding) is set to `Round`, minimum and maximum will be rounded to the nearest possible value, which is divisible by interval. For example, when the minimum is 15th Jan, interval is 1 and the interval type is ‘month’, then the axis minimum will be Jan 1st.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/datetime-axis/round/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Round.cs" %}
{% include code-snippet/3d-chart/series/datetime-axis/round/round.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/datetime-axis/round/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Round.cs" %}
{% include code-snippet/3d-chart/series/datetime-axis/round/round.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



**Datetime - Additional**

When the [`RangePadding`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.Chart3DAxis.html#Syncfusion_EJ2_Charts_Chart3DAxis_RangePadding) is set to `Additional`, interval of an axis will be padded to the minimum and maximum of the axis.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/datetime-axis/additional/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Additional.cs" %}
{% include code-snippet/3d-chart/series/datetime-axis/additional/additional.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/datetime-axis/additional/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Additional.cs" %}
{% include code-snippet/3d-chart/series/datetime-axis/additional/additional.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Label format

The date can be formatted and parsed to all globalize format using [`LabelFormat`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.Chart3DAxis.html#Syncfusion_EJ2_Charts_Chart3DAxis_LabelFormat) property in an axis.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/datetime-axis/label-format/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Label-format.cs" %}
{% include code-snippet/3d-chart/series/datetime-axis/label-format/label-format.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/datetime-axis/label-format/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Label-format.cs" %}
{% include code-snippet/3d-chart/series/datetime-axis/label-format/label-format.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



The following table describes the result of applying some common date time formats to the `LabelFormat` property

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
<td>The Date is displayed in day format.</td>
</tr>
<tr>
<td>new Date(2000, 03, 10)</td>
<td>yMd</td>
<td>04/10/2000</td>
<td>The Date is displayed in month/date/year format.</td>
</tr>
<tr>
<td>new Date(2000, 03, 10)</td>
<td> MMM </td>
<td>Apr</td>
<td>The Shorthand month for the date is displayed.</td>
</tr>
<tr>
<td>new Date(2000, 03, 10)</td>
<td>hm</td>
<td>12:00 AM</td>
<td>Time of the date value is displayed as label.</td>
</tr>
<tr>
<td>new Date(2000, 03, 10)</td>
<td>hms</td>
<td>12:00:00 AM</td>
<td>The Label is displayed in hours:minutes:seconds format.</td>
</tr>
</table>

<!-- markdownlint-disable MD033 -->

## Custom label format

Axis also supports custom label format using placeholder like {value}°C, in which the value represent the axis label e.g 20°C.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/datetime-axis/custom/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Custom.cs" %}
{% include code-snippet/3d-chart/series/datetime-axis/custom/custom.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/datetime-axis/custom/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Custom.cs" %}
{% include code-snippet/3d-chart/series/datetime-axis/custom/custom.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

