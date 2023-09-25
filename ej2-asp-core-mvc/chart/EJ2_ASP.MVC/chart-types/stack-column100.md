---
layout: post
title: 100% Stacked Column Chart in ##Platform_Name## Syncfusion Chart Component
description: Learn here all about 100% Stacked Column Chart in Syncfusion ##Platform_Name## Chart component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: 100% Stacked column chart
publishingplatform: ##Platform_Name##
documentation: ug
---


# 100% Stacked Column in ##Platform_Name## Charts Component

## 100% Stacked column

To render a 100% stacked column series, use series [`Type`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Type) as [`StackingColumn100`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartSeriesType.html#Syncfusion_EJ2_Charts_ChartSeriesType_StackingColumn100).

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/column-charts/100perstackedcolumn/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Stackedcolumn100.cs" %}
{% include code-snippet/chart/series/column-charts/100perstackedcolumn/stackedcolumn100.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/column-charts/100perstackedcolumn/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Stackedcolumn100.cs" %}
{% include code-snippet/chart/series/column-charts/100perstackedcolumn/stackedcolumn100.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## 100% Cylindrical stacked column chart

To render a 100% cylindrical stacked column chart, set the `ColumnFacet` property to `Cylinder` in the chart series.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/column-charts/stackedcolumn100-cylinder/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Stackedcolumn100-cylinder.cs" %}
{% include code-snippet/chart/series/column-charts/stackedcolumn100-cylinder/stackedcolumn100-cylinder.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/column-charts/stackedcolumn100-cylinder/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Stackedcolumn100-cylinder.cs" %}
{% include code-snippet/chart/series/column-charts/stackedcolumn100-cylinder/stackedcolumn100-cylinder.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Series customization

The following properties can be used to customize the [`100% Stacked Column`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartSeriesType.html#Syncfusion_EJ2_Charts_ChartSeriesType_StackingColumn100) series.

* [Fill](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Fill) – Specifies the color of the series.
* [Opacity](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Opacity) – Specifies the opacity of [Fill](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Fill).
* [DashArray](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_DashArray) – Specifies the dashes for series.
* [ChartSeriesBorder](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartBorder.html) – Specifies the [`Color`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartBorder.html#Syncfusion_EJ2_Charts_ChartBorder_Color) and [`Width`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartBorder.html#Syncfusion_EJ2_Charts_ChartBorder_Width) of series border.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/column-charts/stackedcolumn-100-series/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Stackedcolumn-100-series.cs" %}
{% include code-snippet/chart/series/column-charts/stackedcolumn-100-series/stackedcolumn-100-series.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/column-charts/stackedcolumn-100-series/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Stackedcolumn-100-series.cs" %}
{% include code-snippet/chart/series/column-charts/stackedcolumn-100-series/stackedcolumn-100-series.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## See also

* [Data Label](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartDataLabelSettings.html)
* [Tooltip](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartTooltipSettings.html)