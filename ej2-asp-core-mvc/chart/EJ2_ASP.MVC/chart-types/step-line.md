---
layout: post
title: Step Line Chart in ##Platform_Name## Syncfusion Chart Component
description: Learn here all about Step Line Chart in Syncfusion ##Platform_Name## Chart component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Step Line Chart
publishingplatform: ##Platform_Name##
documentation: ug
---


# Step line chart in ##Platform_Name## Charts component

## Step line

To render a step line series, use series [`Type`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Type) as [`StepLine`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartSeriesType.html#Syncfusion_EJ2_Charts_ChartSeriesType_StepLine).

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/line-charts/stepline/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Stepline.cs" %}
{% include code-snippet/chart/series/line-charts/stepline/stepline.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/line-charts/stepline/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Stepline.cs" %}
{% include code-snippet/chart/series/line-charts/stepline/stepline.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Series customization

The following properties can be used to customize the [`Step Line`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartSeriesType.html#Syncfusion_EJ2_Charts_ChartSeriesType_StepLine) series.

* [Fill](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Fill) – Specifies the color of the series.
* [Opacity](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Opacity) – Specifies the opacity of [Fill](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Fill).
* [Width](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Width) – Specifies the width for series.
* [DashArray](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_DashArray) – Specifies the dashes for series.
* [Step](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Step) – Specifies the position of the step for the series.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/line-charts/steplineseries/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Steplineseries.cs" %}
{% include code-snippet/chart/series/line-charts/steplineseries/steplineseries.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/line-charts/steplineseries/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Steplineseries.cs" %}
{% include code-snippet/chart/series/line-charts/steplineseries/steplineseries.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



**No risers**

The [`NoRisers`] feature allows the step line series to appear as a continuous flow, eliminating the vertical lines between points. This approach is useful for highlighting trends without the distraction of risers.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/area-charts/stepline/no-risers/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="No-risers.cs" %}
{% include code-snippet/chart/series/area-charts/stepline/no-risers/no-risers.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/area-charts/stepline/no-risers/razor %}
{% endhighlight %}
{% highlight c# tabtitle="No-risers.cs" %}
{% include code-snippet/chart/series/area-charts/stepline/no-risers/no-risers.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## See also

* [Data Label](../data-labels)
* [Tooltip](../tool-tip)