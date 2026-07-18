---
layout: post
title: Logarithmic Axis in ##Platform_Name## Chart Component
description: Learn here all about Logarithmic Axis in Syncfusion ##Platform_Name## Chart component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Logarithmic Axis
publishingplatform: ##Platform_Name##
documentation: ug
---


# Logarithmic Axis

<!-- markdownlint-disable MD033 -->

The logarithmic axis uses a logarithmic scale and is particularly useful for visualizing data that spans a wide range of values. It effectively represents datasets that include both very small values (for example, 10<sup>-6</sup>) and very large values (for example, 10<sup>6</sup>) within the same chart, improving readability and comparison.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/log/log/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Log.cs" %}
{% include code-snippet/chart/axis/log/log/log.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/log/log/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Log.cs" %}
{% include code-snippet/chart/axis/log/log/log.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Range

The range of the logarithmic axis is calculated automatically based on the provided data. This automatic calculation ensures that all data points are visible within the chart area. The axis range can also be customized explicitly using the [`Minimum`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_Minimum), [`Maximum`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_Maximum), and [`Interval`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_Interval) properties.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/log/range/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Range.cs" %}
{% include code-snippet/chart/axis/log/range/range.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/log/range/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Range.cs" %}
{% include code-snippet/chart/axis/log/range/range.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Logarithmic Base

The logarithmic base of the axis can be customized using the [`LogBase`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_LogBase) property. This property determines how the axis values are distributed along the scale.  

For example, when the logarithmic base is set to `5`, the axis values follow the sequence 5<sup>-2</sup>, 5<sup>-1</sup>, 5<sup>0</sup>, 5<sup>1</sup>, 5<sup>2</sup>, and so on.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/log/base/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Base.cs" %}
{% include code-snippet/chart/axis/log/base/base.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/log/base/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Base.cs" %}
{% include code-snippet/chart/axis/log/base/base.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Logarithmic Interval

The spacing between logarithmic axis labels can be controlled using the [`Interval`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_Interval) property. This property defines the step size between consecutive logarithmic values.  

For example, when the logarithmic base is `10` and the interval is set to `2`, the axis labels are placed at values such as 10<sup>2</sup>, 10<sup>4</sup>, and 10<sup>6</sup>. The default value of the interval is `1`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/log/interval/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Interval.cs" %}
{% include code-snippet/chart/axis/log/interval/interval.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/log/interval/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Interval.cs" %}
{% include code-snippet/chart/axis/log/interval/interval.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

