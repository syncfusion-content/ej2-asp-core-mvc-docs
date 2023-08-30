---
layout: post
title: Spline Chart in ##Platform_Name## Syncfusion Chart Component
description: Learn here all about Spline Chart in Syncfusion ##Platform_Name## Chart component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Spline Chart
publishingplatform: ##Platform_Name##
documentation: ug
---


# Spline in ##Platform_Name## Charts Component

## Spline

To render a spline series, use series [`Type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Type) as [`Spline`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeriesType.html#Syncfusion_EJ2_Charts_ChartSeriesType_Spline).

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/line-charts/spline/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Spline.cs" %}
{% include code-snippet/chart/series/line-charts/spline/spline.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/line-charts/spline/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Spline.cs" %}
{% include code-snippet/chart/series/line-charts/spline/spline.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Type of spline

To specify the type of `Spline Chart`, use [`SplineType`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_SplineType) property. The spline types are **Clamped**, **Cardinal**, **Monotonic** and **Natural**.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/line-charts/splinetype/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Splinetype.cs" %}
{% include code-snippet/chart/series/line-charts/splinetype/splinetype.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/line-charts/splinetype/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Splinetype.cs" %}
{% include code-snippet/chart/series/line-charts/splinetype/splinetype.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Series customization

The following properties can be used to customize the [`Spline`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeriesType.html#Syncfusion_EJ2_Charts_ChartSeriesType_Spline) series.

* [Fill](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Fill) – Specifies the color of the series.
* [Opacity](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Opacity) – Specifies the opacity of [Fill](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Fill).
* [Width](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Width) – Specifies the width for series.
* [DashArray](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_DashArray) – Specifies the dashes for series.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/line-charts/spline-series/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Spline-series.cs" %}
{% include code-snippet/chart/series/line-charts/spline-series/spline-series.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/line-charts/spline-series/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Spline-series.cs" %}
{% include code-snippet/chart/series/line-charts/spline-series/spline-series.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## See Also

* [Data Label](../data-labels)
* [Tooltip](../tool-tip)