---
layout: post
title: Hilo Chart in ##Platform_Name## Syncfusion Chart Component
description: Learn here all about Hilo Chart in Syncfusion ##Platform_Name## Chart component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Hilo Chart
publishingplatform: ##Platform_Name##
documentation: ug
---


# Hilo in ASP.NET Core Charts Component

To get started with the ASP.NET Core Hilo charts, you can check on this video:

{% youtube "https://www.youtube.com/watch?v=O3akshh4BvM" %}

## Hilo

Hilo Series illustrates the price movements in stock using the high and low values. To render a Hilo series, use series [`Type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Type) as [`Hilo`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeriesType.html#Syncfusion_EJ2_Charts_ChartSeriesType_Hilo).

Hilo series requires 3 fields (x, high and low) to show the high and low price in the stock.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/financial-charts/hilo/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Hilo.cs" %}
{% include code-snippet/chart/series/financial-charts/hilo/hilo.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/financial-charts/hilo/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Hilo.cs" %}
{% include code-snippet/chart/series/financial-charts/hilo/hilo.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Series customization

The following properties can be used to customize the [`Hilo`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeriesType.html#Syncfusion_EJ2_Charts_ChartSeriesType_Hilo) series.

* [Fill](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Fill) – Specifies the color of the series.
* [Opacity](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Opacity) – Specifies the opacity of [Fill](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Fill).

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/financial-charts/hilo-series/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Hilo-series.cs" %}
{% include code-snippet/chart/series/financial-charts/hilo-series/hilo-series.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/financial-charts/hilo-series/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Hilo-series.cs" %}
{% include code-snippet/chart/series/financial-charts/hilo-series/hilo-series.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## See Also

* [Data Label](../data-labels)
* [Tooltip](../tool-tip)