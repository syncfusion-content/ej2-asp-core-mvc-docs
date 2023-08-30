---
layout: post
title: Radar Chart in ##Platform_Name## Syncfusion Chart Component
description: Learn here all about Radar Chart in Syncfusion ##Platform_Name## Chart component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Radar Chart
publishingplatform: ##Platform_Name##
documentation: ug
---


# Radar in ##Platform_Name## Charts Component

## Radar

To render a radar series, use series [`Type`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Type) as [`Radar`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartSeriesType.html#Syncfusion_EJ2_Charts_ChartSeriesType_Radar).

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/polar-radar/radar-line/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Radar-line.cs" %}
{% include code-snippet/chart/series/polar-radar/radar-line/radar-line.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/polar-radar/radar-line/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Radar-line.cs" %}
{% include code-snippet/chart/series/polar-radar/radar-line/radar-line.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Series customization

### Start Angle

You can customize the start angle of the radar series using [`StartAngle`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_StartAngle) property. By default, `StartAngle` is 0 degree.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/polar-radar/start-angle/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Start-angle.cs" %}
{% include code-snippet/chart/series/polar-radar/start-angle/start-angle.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/polar-radar/start-angle/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Start-angle.cs" %}
{% include code-snippet/chart/series/polar-radar/start-angle/start-angle.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Coefficient in axis

You can customize the radius of the radar series using [`Coefficient`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_Coefficient) property. By default, `Coefficient` is 100.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/polar-radar/co-efficient/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Co-efficient.cs" %}
{% include code-snippet/chart/series/polar-radar/co-efficient/co-efficient.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/polar-radar/co-efficient/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Co-efficient.cs" %}
{% include code-snippet/chart/series/polar-radar/co-efficient/co-efficient.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## See Also

* [Data Label](../data-labels)
* [Tooltip](../tool-tip)