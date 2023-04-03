---
layout: post
title: Stacked Column Chart in ##Platform_Name## Syncfusion Chart Component
description: Learn here all about Stacked Column Chart in Syncfusion ##Platform_Name## Chart component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Stacked Column Chart
publishingplatform: ##Platform_Name##
documentation: ug
---


# Stacked Column in ##Platform_Name## Charts Component

## Stacked Column

To render a stacked column series, use series [`Type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Type) as `StackingColumn`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/column-charts/stackedcolumn/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Stackedcolumn.cs" %}
{% include code-snippet/chart/series/column-charts/stackedcolumn/stackedcolumn.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/column-charts/stackedcolumn/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Stackedcolumn.cs" %}
{% include code-snippet/chart/series/column-charts/stackedcolumn/stackedcolumn.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Stacking Group

You can use the [`StackingGroup`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_StackingGroup) property to group the stacked columns and 100% stacked columns. Columns with same group name are stacked on top of each other.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/column-charts/group/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Group.cs" %}
{% include code-snippet/chart/series/column-charts/group/group.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/column-charts/group/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Group.cs" %}
{% include code-snippet/chart/series/column-charts/group/group.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Series customization

The following properties can be used to customize the `Stacked Column` series.

* [Fill](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Fill) – Specifies the color of the series.
* [Opacity](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Opacity) – Specifies the opacity of [Fill](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Fill).
* [DashArray](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_DashArray) – Specifies the dashes for series.
* [ChartSeriesBorder](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Border) – Specifies the [`Color`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartBorder.html#Syncfusion_EJ2_Charts_ChartBorder_Color) and [`Width`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartBorder.html#Syncfusion_EJ2_Charts_ChartBorder_Width) of series border.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/column-charts/stackedcolumn-series/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Stackedcolumn-series.cs" %}
{% include code-snippet/chart/series/column-charts/stackedcolumn-series/stackedcolumn-series.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/column-charts/stackedcolumn-series/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Stackedcolumn-series.cs" %}
{% include code-snippet/chart/series/column-charts/stackedcolumn-series/stackedcolumn-series.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## See Also

* [Data Label](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartDataLabelSettings.html)
* [Tooltip](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartTooltipSettings.html)