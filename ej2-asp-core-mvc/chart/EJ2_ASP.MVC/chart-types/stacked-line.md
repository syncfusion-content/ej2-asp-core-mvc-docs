---
layout: post
title: Stacked Line Chart in ##Platform_Name## Syncfusion Chart Component
description: Learn here all about Stacked Line Chart in Syncfusion ##Platform_Name## Chart component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Stacked Line Chart
publishingplatform: ##Platform_Name##
documentation: ug
---


# Stacked Line Chart in ##Platform_Name## Charts Component

## Stacked Line

To render a stacked line series, use series [`Type`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Type) as [`StackingLine`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartSeriesType.html#Syncfusion_EJ2_Charts_ChartSeriesType_StackingLine).

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/line-charts/stacked-line/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Stacked-line.cs" %}
{% include code-snippet/chart/series/line-charts/stacked-line/stacked-line.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/line-charts/stacked-line/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Stacked-line.cs" %}
{% include code-snippet/chart/series/line-charts/stacked-line/stacked-line.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Series customization

The following properties can be used to customize the [`Stacked Line`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartSeriesType.html#Syncfusion_EJ2_Charts_ChartSeriesType_StackingLine) series.

* [Fill](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Fill) – Specifies the color of the series.
* [Opacity](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Opacity) – Specifies the opacity of [Fill](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Fill).
* [Width](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Width) – Specifies the width for series.
* [DashArray](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_DashArray) – Specifies the dashes for series.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/line-charts/stacked-line-series/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Stacked-line-series.cs" %}
{% include code-snippet/chart/series/line-charts/stacked-line-series/stacked-line-series.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/line-charts/stacked-line-series/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Stacked-line-series.cs" %}
{% include code-snippet/chart/series/line-charts/stacked-line-series/stacked-line-series.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## See Also

* [Data Label](../data-labels)
* [Tooltip](../tool-tip)