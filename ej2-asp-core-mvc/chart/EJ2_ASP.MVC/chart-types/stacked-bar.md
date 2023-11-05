---
layout: post
title: Stacked Bar Chart in ##Platform_Name## Syncfusion Chart Component
description: Learn here all about Stacked Bar Chart in Syncfusion ##Platform_Name## Chart component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Stacked bar chart
publishingplatform: ##Platform_Name##
documentation: ug
---


# Stacked Bar in ##Platform_Name## Charts Component

## Stacked bar

To render a stacked bar series, use series [`Type`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Type) as [`StackingBar`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartSeriesType.html#Syncfusion_EJ2_Charts_ChartSeriesType_StackingBar).

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/bar-charts/stackedbar/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Stackedbar.cs" %}
{% include code-snippet/chart/series/bar-charts/stackedbar/stackedbar.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/bar-charts/stackedbar/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Stackedbar.cs" %}
{% include code-snippet/chart/series/bar-charts/stackedbar/stackedbar.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Stacking group

You can use the [`StackingGroup`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_StackingGroup) property to group the stacked bar and 100% stacked bar. Columns with same group name are stacked on top of each other.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/bar-charts/group/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Group.cs" %}
{% include code-snippet/chart/series/bar-charts/group/group.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/bar-charts/group/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Group.cs" %}
{% include code-snippet/chart/series/bar-charts/group/group.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Cylindrical stacked bar chart

To render a cylindrical stacked bar chart, set the [`ColumnFacet`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_ColumnFacet) property to `Cylinder` in the chart series.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/bar-charts/stackedbar-cylinder/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Stackedbar-cylinder.cs" %}
{% include code-snippet/chart/series/bar-charts/stackedbar-cylinder/stackedbar-cylinder.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/bar-charts/stackedbar-cylinder/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Stackedbar-cylinder.cs" %}
{% include code-snippet/chart/series/bar-charts/stackedbar-cylinder/stackedbar-cylinder.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Series customization

The following properties can be used to customize the [`Stacked Bar`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartSeriesType.html#Syncfusion_EJ2_Charts_ChartSeriesType_StackingBar) series.

* [Fill](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Fill) – Specifies the color of the series.
* [Opacity](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Opacity) – Specifies the opacity of [Fill](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Fill).
* [DashArray](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_DashArray) – Specifies the dashes for series.
* [ChartSeriesBorder](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartBorder.html) – Specifies the [`Color`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartBorder.html#Syncfusion_EJ2_Charts_ChartBorder_Color) and [`Width`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartBorder.html#Syncfusion_EJ2_Charts_ChartBorder_Width) of series border.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/bar-charts/stackedbar-series/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Stackedbar-series.cs" %}
{% include code-snippet/chart/series/bar-charts/stackedbar-series/stackedbar-series.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/bar-charts/stackedbar-series/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Stackedbar-series.cs" %}
{% include code-snippet/chart/series/bar-charts/stackedbar-series/stackedbar-series.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## See also

* [Data Label](../data-labels)
* [Tooltip](../tool-tip)