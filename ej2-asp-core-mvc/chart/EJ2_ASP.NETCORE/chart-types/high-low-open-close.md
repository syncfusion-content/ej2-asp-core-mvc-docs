---
layout: post
title: High Low Open Close Chart in ##Platform_Name## Syncfusion Chart Component
description: Learn here all about High Low Open Close Chart in Syncfusion ##Platform_Name## Chart component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: High Low Open Close Chart
publishingplatform: ##Platform_Name##
documentation: ug
---


# High Low Open Close in ##Platform_Name## Charts Component

## High Low Open Close

HiloOpenClose series is used to represent the low, high, open and closing values over time. To render a HiloOpenClose series, use series [`Type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Type) as `HiloOpenClose`.

HiloOpenClose series requires 5 fields (x, high, low, open and close) to show the high, low, open and close price values in the stock.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/financial-charts/hilo-openclose/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Hilo-openclose.cs" %}
{% include code-snippet/chart/series/financial-charts/hilo-openclose/hilo-openclose.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/financial-charts/hilo-openclose/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Hilo-openclose.cs" %}
{% include code-snippet/chart/series/financial-charts/hilo-openclose/hilo-openclose.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Series customization

In HiloOpenClose series, [`BullFillColor`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_BullFillColor) is used to fill the segment when the open value is greater than the close value and [`BearFillColor`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_BearFillColor) is used to fill the segment when the open value is less than the close value.

By default, bullFillColor is set as red and bearFillColor is set as green.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/financial-charts/custom-openclose/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-openclose.cs" %}
{% include code-snippet/chart/series/financial-charts/custom-openclose/custom-openclose.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/financial-charts/custom-openclose/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-openclose.cs" %}
{% include code-snippet/chart/series/financial-charts/custom-openclose/custom-openclose.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## See Also

* [Data Label](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartDataLabelSettings.html)
* [Tooltip](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartTooltipSettings.html)