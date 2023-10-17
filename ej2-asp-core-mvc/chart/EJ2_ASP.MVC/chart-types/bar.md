---
layout: post
title: Bar Chart in ##Platform_Name## Syncfusion Chart Component
description: Learn here all about Bar Chart in Syncfusion ##Platform_Name## Chart component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Bar chart
publishingplatform: ##Platform_Name##
documentation: ug
---


# Bar Charts in ##Platform_Name## Charts Component

## Bar

To render a bar series, use series [`Type`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Type) as [`Bar`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartSeriesType.html#Syncfusion_EJ2_Charts_ChartSeriesType_Bar).

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/bar-charts/bar/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Bar.cs" %}
{% include code-snippet/chart/series/bar-charts/bar/bar.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/bar-charts/bar/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Bar.cs" %}
{% include code-snippet/chart/series/bar-charts/bar/bar.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Bar space and width

The [`ColumnSpacing`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_ColumnSpacing) and [`ColumnWidth`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_ColumnWidth) properties are used to customize the space between bars.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/bar-charts/bar-space/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Bar-space.cs" %}
{% include code-snippet/chart/series/bar-charts/bar-space/bar-space.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/bar-charts/bar-space/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Bar-space.cs" %}
{% include code-snippet/chart/series/bar-charts/bar-space/bar-space.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


## Grouped bar

You can use the [`GroupName`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_GroupName) property to group the data points in the bar type charts. Data points with same group name are grouped together.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/bar-charts/group-bar/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Group-bar.cs" %}
{% include code-snippet/chart/series/bar-charts/group-bar/group-bar.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/bar-charts/group-bar/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Group-bar.cs" %}
{% include code-snippet/chart/series/bar-charts/group-bar/group-bar.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Cylindrical bar chart

To render a cylindrical bar chart, set the [`ColumnFacet`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_ColumnFacet) property to `Cylinder` in the chart series.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/bar-charts/bar-cylinder/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Bar-cylinder.cs" %}
{% include code-snippet/chart/series/bar-charts/bar-cylinder/bar-cylinder.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/bar-charts/bar-cylinder/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Bar-cylinder.cs" %}
{% include code-snippet/chart/series/bar-charts/bar-cylinder/bar-cylinder.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Series customization

The following properties can be used to customize the [`Bar`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartSeriesType.html#Syncfusion_EJ2_Charts_ChartSeriesType_Bar) series.

* [Fill](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Fill) – Specifies the color of the series.
* [Opacity](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Opacity) – Specifies the opacity of [Fill](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Fill).
* [DashArray](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_DashArray) – Specifies the dashes for series.
* [ChartSeriesBorder](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartBorder.html) – Specifies the [`Color`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartBorder.html#Syncfusion_EJ2_Charts_ChartBorder_Color) and [`Width`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartBorder.html#Syncfusion_EJ2_Charts_ChartBorder_Width) of series border.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/bar-charts/bar-series/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Bar-series.cs" %}
{% include code-snippet/chart/series/bar-charts/bar-series/bar-series.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/bar-charts/bar-series/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Bar-series.cs" %}
{% include code-snippet/chart/series/bar-charts/bar-series/bar-series.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## See also

* [Data Label](../data-labels)
* [Tooltip](../tool-tip)