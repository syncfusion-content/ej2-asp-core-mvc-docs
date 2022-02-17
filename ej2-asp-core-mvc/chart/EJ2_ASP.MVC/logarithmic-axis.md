---
layout: post
title: Logarithmic Axis in ##Platform_Name## Chart Component
description: Learn here all about Logarithmic Axis in Syncfusion ##Platform_Name## Chart component and more.
platform: ej2-asp-core-mvc
control: Logarithmic Axis
publishingplatform: ##Platform_Name##
documentation: ug
---


# Logarithmic Axis

<!-- markdownlint-disable MD033 -->

Logarithmic axis uses logarithmic scale and it is very useful in visualizing data, when it has numeric values in
both lower order of magnitude (eg: 10<sup>-6</sup>) and higher order of magnitude (eg: 10<sup>6</sup>).

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

Range of an axis, will be calculated automatically based on the provided data, you can also customize the range
of the axis using [`Minimum`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_Minimum), [`Maximum`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_Maximum)
and [`Interval`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_Interval) property of the axis.

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

Logarithmic base can be customized by using the [`LogBase`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_LogBase) property of the axis.
For example when the logBase is 5, the axis values follows 5<sup>-2</sup>, 5<sup>-1</sup>, 5<sup>0</sup>,
5<sup>1</sup>, 5<sup>2</sup> etc.

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

Logarithmic axis interval can be customized by using the [`Interval`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_Interval)
property of the axis. When the logarithmic base is 10 and logarithmic interval is 2, then the axis labels are
placed at an interval of 10<sup>2</sup>. The default value of the interval is 1.

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

