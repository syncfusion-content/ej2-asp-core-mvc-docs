---
layout: post
title: Bubble Chart in ##Platform_Name## Syncfusion Chart Component
description: Learn here all about Bubble Chart in Syncfusion ##Platform_Name## Chart component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Bubble Chart
publishingplatform: ##Platform_Name##
documentation: ug
---


# Bubble in ##Platform_Name## Charts Component

## Bubble

To render a bubble series, use series [`Type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Type) as `Bubble`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/scatter-bubble/bubble/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Bubble.cs" %}
{% include code-snippet/chart/series/scatter-bubble/bubble/bubble.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/scatter-bubble/bubble/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Bubble.cs" %}
{% include code-snippet/chart/series/scatter-bubble/bubble/bubble.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Size Mapping

`Size` property can be used to map the size value specified in data source.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/scatter-bubble/bubble-size/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Bubble-size.cs" %}
{% include code-snippet/chart/series/scatter-bubble/bubble-size/bubble-size.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/scatter-bubble/bubble-size/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Bubble-size.cs" %}
{% include code-snippet/chart/series/scatter-bubble/bubble-size/bubble-size.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Series customization

The following properties can be used to customize the `Bubble` series.

* [Fill](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Fill) – Specifies the color of the series.
* [Opacity](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Opacity) – Specifies the opacity of [Fill](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Fill).

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/scatter-bubble/bubble-series/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Bubble-series.cs" %}
{% include code-snippet/chart/series/scatter-bubble/bubble-series/bubble-series.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/scatter-bubble/bubble-series/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Bubble-series.cs" %}
{% include code-snippet/chart/series/scatter-bubble/bubble-series/bubble-series.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## See Also

* [Data Label](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartDataLabelSettings.html)
* [Tooltip](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartTooltipSettings.html)