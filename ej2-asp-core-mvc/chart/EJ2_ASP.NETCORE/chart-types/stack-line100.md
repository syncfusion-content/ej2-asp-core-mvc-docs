---
layout: post
title: 100% Stacked Line Chart in ##Platform_Name## Syncfusion Chart Component
description: Learn here all about 100% Stacked Line Chart in Syncfusion ##Platform_Name## Chart component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: 100% Stacked Line Chart
publishingplatform: ##Platform_Name##
documentation: ug
---


# 100% Stacked Line in ##Platform_Name## Charts Component

## 100% Stacked Line

To render a 100% stacked line series, use series [`Type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Type) as [`StackingLine100`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeriesType.html#Syncfusion_EJ2_Charts_ChartSeriesType_StackingLine100).

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/line-charts/stacked-line-100/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Stacked-line-100.cs" %}
{% include code-snippet/chart/series/line-charts/stacked-line-100/stacked-line-100.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/line-charts/stacked-line-100/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Stacked-line-100.cs" %}
{% include code-snippet/chart/series/line-charts/stacked-line-100/stacked-line-100.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Series customization

The following properties can be used to customize the [`100% Stacked Line`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeriesType.html#Syncfusion_EJ2_Charts_ChartSeriesType_StackingLine100) series.

* [Fill](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Fill) – Specifies the color of the series.
* [Opacity](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Opacity) – Specifies the opacity of [Fill](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Fill).
* [Width](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Width) – Specifies the width for series.
* [DashArray](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_DashArray) – Specifies the dashes for series.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/line-charts/stacked-line-100-series/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Stacked-line-100-series.cs" %}
{% include code-snippet/chart/series/line-charts/stacked-line-100-series/stacked-line-100-series.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/line-charts/stacked-line-100-series/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Stacked-line-100-series.cs" %}
{% include code-snippet/chart/series/line-charts/stacked-line-100-series/stacked-line-100-series.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## See Also

* [Data Label](../data-labels)
* [Tooltip](../tool-tip)