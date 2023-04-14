---
layout: post
title: Scatter Chart in ##Platform_Name## Syncfusion Chart Component
description: Learn here all about Scatter Chart in Syncfusion ##Platform_Name## Chart component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Scatter Chart
publishingplatform: ##Platform_Name##
documentation: ug
---


# Scatter in ##Platform_Name## Charts Component

## Scatter

To render a scatter series, use series [`Type`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Type) as `Scatter`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/scatter-bubble/scatter/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Scatter.cs" %}
{% include code-snippet/chart/series/scatter-bubble/scatter/scatter.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/scatter-bubble/scatter/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Scatter.cs" %}
{% include code-snippet/chart/series/scatter-bubble/scatter/scatter.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Series customization

The following properties can be used to customize the `Scatter` series.

* [Fill](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Fill) – Specifies the color of the series.
* [Opacity](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Opacity) – Specifies the opacity of [Fill](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Fill).
* [Shape](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartShape.html) – Specifies the shape of the scatter series.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/scatter-bubble/scatter-series/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Scatter-series.cs" %}
{% include code-snippet/chart/series/scatter-bubble/scatter-series/scatter-series.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/scatter-bubble/scatter-series/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Scatter-series.cs" %}
{% include code-snippet/chart/series/scatter-bubble/scatter-series/scatter-series.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## See Also

* [Data Label](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartDataLabelSettings.html)
* [Tooltip](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartTooltipSettings.html)