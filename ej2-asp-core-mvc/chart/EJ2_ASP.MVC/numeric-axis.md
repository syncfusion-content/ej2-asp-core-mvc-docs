---
layout: post
title: Numeric Axis in ##Platform_Name## Chart Component
description: Learn here all about Numeric Axis in Syncfusion ##Platform_Name## Chart component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Numeric Axis
publishingplatform: ##Platform_Name##
documentation: ug
---


<!-- markdownlint-disable MD036 -->

# Numeric Axis

The [numeric axis](https://ej2.syncfusion.com/aspnetcore/Chart/NumericAxis#/material) is used to represent numeric values in a chart. By default, the `ValueType` of an axis is set to [`Double`](https://www.syncfusion.com/aspnet-core-ui-controls/charts/chart-axis), which is suitable for displaying continuous numerical data.

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

The range of the axis is calculated automatically based on the provided data. You can also customize the visible range by using the [`Minimum`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_Minimum), [`Maximum`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_Maximum), and [`Interval`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_Interval) properties of the axis.

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

Padding can be applied to the minimum and maximum values of the axis range by using the [`RangePadding`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_RangePadding) property. The numeric axis supports the following padding options:

* None
* Round
* Additional
* Normal
* Auto

**Numeric - None**

When the [`RangePadding`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_RangePadding) property is set to `None`, the minimum and maximum values of the axis are derived directly from the data.

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

When the [`RangePadding`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_RangePadding) property is set to `Round`, the minimum and maximum values are rounded to the nearest values divisible by the interval. For example, if the minimum value is 3.5 and the interval is 1, the minimum value is rounded to 3.

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

When the [`RangePadding`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_RangePadding) property is set to `Additional`, one interval is added to both the minimum and maximum values of the axis range.

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

When the [`RangePadding`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_RangePadding) property is set to `Normal`, padding is applied to the axis based on the default range calculation.

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

When the [`RangePadding`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_RangePadding) property is set to `Auto`, the horizontal numeric axis uses `None` as padding, while the vertical numeric axis uses `Normal` padding.

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

Numeric axis labels can be formatted by using the [`LabelFormat`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_LabelFormat) property. This property supports all Globalize numeric formats.

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



The following table shows examples of commonly used numeric label formats and their corresponding outputs.

<!-- markdownlint-disable MD033 -->

<table>
    <tr>
        <td><b>Label Value</b></td>
        <td><b>Label Format</b></td>
        <td><b>Result</b></td>
        <td><b>Description</b></td>
    </tr>
    <tr>
        <td>1000</td>
        <td>n1</td>
        <td>1000.0</td>
        <td>Rounded to 1 decimal place</td>
    </tr>
    <tr>
        <td>1000</td>
        <td>n2</td>
        <td>1000.00</td>
        <td>Rounded to 2 decimal places</td>
    </tr>
    <tr>
        <td>1000</td>
        <td>n3</td>
        <td>1000.000</td>
        <td>Rounded to 3 decimal places</td>
    </tr>
    <tr>
        <td>0.01</td>
        <td>p1</td>
        <td>1.0%</td>
        <td>Converted to percentage with 1 decimal place</td>
    </tr>
    <tr>
        <td>0.01</td>
        <td>p2</td>
        <td>1.00%</td>
        <td>Converted to percentage with 2 decimal places</td>
    </tr>
    <tr>
        <td>0.01</td>
        <td>p3</td>
        <td>1.000%</td>
        <td>Converted to percentage with 3 decimal places</td>
    </tr>
    <tr>
        <td>1000</td>
        <td>c1</td>
        <td>$1000.0</td>
        <td>Currency format with 1 decimal place</td>
    </tr>
    <tr>
        <td>1000</td>
        <td>c2</td>
        <td>$1000.00</td>
        <td>Currency format with 2 decimal places</td>
    </tr>
</table>

## GroupingSeparator

To separate groups of thousands in numeric labels, enable the [`UseGroupingSeparator`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.Chart.html) property in the chart.

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

The numeric axis also supports custom label formats by using placeholders such as `{value}°C`, where `{value}` represents the numeric axis label. For example, the value `20` is displayed as `20°C`.

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

