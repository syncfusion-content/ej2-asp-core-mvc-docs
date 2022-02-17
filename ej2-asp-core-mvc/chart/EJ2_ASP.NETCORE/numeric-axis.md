---
layout: post
title: Numeric Axis in ##Platform_Name## Chart Component
description: Learn here all about Numeric Axis in Syncfusion ##Platform_Name## Chart component and more.
platform: ej2-asp-core-mvc
control: Numeric Axis
publishingplatform: ##Platform_Name##
documentation: ug
---


<!-- markdownlint-disable MD036 -->

# Numeric Axis

You can use numeric [`axis`](https://ej2.syncfusion.com/aspnetcore/Chart/NumericAxis#/material) to represent numeric values of data in chart. By default, the `valueType` of an axis is [`Double`](https://www.syncfusion.com/aspnet-core-ui-controls/charts/chart-axis).

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/double/double/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Double.cs" %}
{% include code-snippet/chart/axis/double/double/double.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/double/double/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Double.cs" %}
{% include code-snippet/chart/axis/double/double/double.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Range

Range for an axis, will be calculated automatically based on the provided data, you can also customize the range
of the axis using [`minimum`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_Minimum), [`maximum`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_Maximum)
and [`interval`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_Interval) property of the axis.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/double/range/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Range.cs" %}
{% include code-snippet/chart/axis/double/range/range.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/double/range/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Range.cs" %}
{% include code-snippet/chart/axis/double/range/range.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



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

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/double/none/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="None.cs" %}
{% include code-snippet/chart/axis/double/none/none.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/double/none/razor %}
{% endhighlight %}
{% highlight c# tabtitle="None.cs" %}
{% include code-snippet/chart/axis/double/none/none.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



**Numeric - Round**

When the [`rangePadding`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_RangePadding) is set to `Round`, minimum and maximum will be
rounded to the nearest possible value divisible by interval. For example, when the minimum is 3.5 and the interval
is 1, then the minimum will be rounded to 3.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/double/round/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Round.cs" %}
{% include code-snippet/chart/axis/double/round/round.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/double/round/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Round.cs" %}
{% include code-snippet/chart/axis/double/round/round.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



**Numeric - Additional**

When the [`rangePadding`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_RangePadding) is set to `Additional`, interval of an axis will
be padded to the minimum and maximum of the axis.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/double/additional/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Additional.cs" %}
{% include code-snippet/chart/axis/double/additional/additional.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/double/additional/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Additional.cs" %}
{% include code-snippet/chart/axis/double/additional/additional.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



**Numeric - Normal**

When the [`rangePadding`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_RangePadding) is set to `Normal`, padding is applied to the axis
based on default range calculation.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/double/normal/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Normal.cs" %}
{% include code-snippet/chart/axis/double/normal/normal.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/double/normal/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Normal.cs" %}
{% include code-snippet/chart/axis/double/normal/normal.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



**Numeric - Auto**

When the [`rangePadding`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_RangePadding) is set to `Auto`,horizontal numeric axis takes
None as padding calculation, while the vertical numeric axis takes Normal as padding calculation.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/double/auto/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Auto.cs" %}
{% include code-snippet/chart/axis/double/auto/auto.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/double/auto/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Auto.cs" %}
{% include code-snippet/chart/axis/double/auto/auto.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Label Format

**Numeric Label Format**

Numeric labels can be formatted by using the [`labelFormat`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_LabelFormat) property.
Numeric labels supports all globalize format.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/double/label-format/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Label-format.cs" %}
{% include code-snippet/chart/axis/double/label-format/label-format.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/double/label-format/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Label-format.cs" %}
{% include code-snippet/chart/axis/double/label-format/label-format.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



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

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/double/group/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Group.cs" %}
{% include code-snippet/chart/axis/double/group/group.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/double/group/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Group.cs" %}
{% include code-snippet/chart/axis/double/group/group.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Custom Label Format

Axis also supports custom label format using placeholder like {value}°C, in which the value represent the axis
label e.g 20°C.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/double/custom/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Custom.cs" %}
{% include code-snippet/chart/axis/double/custom/custom.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/double/custom/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Custom.cs" %}
{% include code-snippet/chart/axis/double/custom/custom.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

