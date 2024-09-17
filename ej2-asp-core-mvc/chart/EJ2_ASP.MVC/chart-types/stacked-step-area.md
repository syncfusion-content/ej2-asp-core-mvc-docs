---
layout: post
title: Stacked Step Area Chart in ##Platform_Name## Syncfusion Chart Component
description: Learn here all about Stacked Step Area Chart in Syncfusion ##Platform_Name## Chart component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Stacked Step Area Chart
publishingplatform: ##Platform_Name##
documentation: ug
---


# Stacked step area in ##Platform_Name## Charts component

## Stacked step area

To render a stacked step area series, use series [`Type`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Type) as [`StackingStepArea`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartSeriesType.html#Syncfusion_EJ2_Charts_ChartSeriesType_StackingStepArea).

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/area-charts/stacked-step-area/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Stacked-step-area.cs" %}
{% include code-snippet/chart/series/area-charts/stacked-step-area/stacked-step-area.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/area-charts/stacked-step-area/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Stacked-step-area.cs" %}
{% include code-snippet/chart/series/area-charts/stacked-step-area/stacked-step-area.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Series customization

The following properties can be used to customize the [`Stacked Step Area`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartSeriesType.html#Syncfusion_EJ2_Charts_ChartSeriesType_StackingStepArea) series.

* [Fill](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Fill) – Specifies the color of the series.
* [Opacity](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Opacity) – Specifies the opacity of [Fill](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Fill).
* [DashArray](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_DashArray) – Specifies the dashes for series.
* [ChartSeriesBorder](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartBorder.html) – Specifies the [`Color`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartBorder.html#Syncfusion_EJ2_Charts_ChartBorder_Color) and [`Width`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartBorder.html#Syncfusion_EJ2_Charts_ChartBorder_Width) of series border.
* [Step](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Step) – Specifies the position of the step for the series.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/area-charts/stackedsteparea-series/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Stackedsteparea-series.cs" %}
{% include code-snippet/chart/series/area-charts/stackedsteparea-series/stackedsteparea-series.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/area-charts/stackedsteparea-series/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Stackedsteparea-series.cs" %}
{% include code-snippet/chart/series/area-charts/stackedsteparea-series/stackedsteparea-series.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



**No risers**

The [`NoRisers`] feature allows the stacked step area series to appear as a continuous flow, eliminating the vertical lines between points. This approach is useful for highlighting trends without the distraction of risers.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/area-charts/stackedsteparea/no-risers/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="No-risers.cs" %}
{% include code-snippet/chart/series/area-charts/stackedsteparea/no-risers/no-risers.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/area-charts/stackedsteparea/no-risers/razor %}
{% endhighlight %}
{% highlight c# tabtitle="No-risers.cs" %}
{% include code-snippet/chart/series/area-charts/stackedsteparea/no-risers/no-risers.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## See also

* [Data Label](../data-labels)
* [Tooltip](../tool-tip)