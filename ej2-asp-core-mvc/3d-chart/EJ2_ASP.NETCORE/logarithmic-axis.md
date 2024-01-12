---
layout: post
title: Logarithmic axis in ##Platform_Name## 3D Chart Component
description: Learn here all about logarithmic axis in Syncfusion ##Platform_Name## 3D Chart component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Logarithmic Axis
publishingplatform: ##Platform_Name##
documentation: ug
---


# Logarithmic axis in ##Platform_Name## 3D Chart Component

Logarithmic axis uses logarithmic scale and it is very useful in visualizing data, when it has numerical values in both lower order of magnitude (eg: 10<sup>-6</sup>) and higher order of magnitude (eg: 10<sup>6</sup>).

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/axis/log/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Log.cs" %}
{% include code-snippet/3d-chart/series/axis/log/log.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/axis/log/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Log.cs" %}
{% include code-snippet/3d-chart/series/axis/log/log.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Range

The range of an axis will be calculated automatically based on the provided data and it can also be customized by using the [`Minimum`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.Chart3DAxis.html#Syncfusion_EJ2_Charts_Chart3DAxis_Minimum), [`Maximum`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.Chart3DAxis.html#Syncfusion_EJ2_Charts_Chart3DAxis_Maximum) and [`Interval`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.Chart3DAxis.html#Syncfusion_EJ2_Charts_Chart3DAxis_Interval) properties of the axis.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/axis/log-range/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Log-range.cs" %}
{% include code-snippet/3d-chart/series/axis/log-range/log-range.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/axis/log-range/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Log-range.cs" %}
{% include code-snippet/3d-chart/series/axis/log-range/log-range.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Logarithmic base

Logarithmic base can be customized by using the [`LogBase`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.Chart3DAxis.html#Syncfusion_EJ2_Charts_Chart3DAxis_LogBase) property of the axis. For example when the `LogBase` is **5**, the axis values follows 5<sup>-2</sup>, 5<sup>-1</sup>, 5<sup>0</sup>, 5<sup>1</sup>, 5<sup>2</sup> etc.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/axis/log-base/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Log-base.cs" %}
{% include code-snippet/3d-chart/series/axis/log-base/log-base.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/axis/log-base/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Log-base.cs" %}
{% include code-snippet/3d-chart/series/axis/log-base/log-base.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Logarithmic interval

The interval of the logarithmic axis can be customized by using the [`Interval`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.Chart3DAxis.html#Syncfusion_EJ2_Charts_Chart3DAxis_Interval) property in the axis. When the logarithmic base is 10 and logarithmic **Interval** is 2, then the axis labels are placed at an interval of 10<sup>2</sup>. The default value of the [`Interval`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.Chart3DAxis.html#Syncfusion_EJ2_Charts_Chart3DAxis_Interval) is **1**.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/axis/log-interval/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Log-interval.cs" %}
{% include code-snippet/3d-chart/series/axis/log-interval/log-interval.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/axis/log-interval/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Log-interval.cs" %}
{% include code-snippet/3d-chart/series/axis/log-interval/log-interval.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

