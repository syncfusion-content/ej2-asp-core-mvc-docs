---
layout: post
title: Pareto Chart in ##Platform_Name## Syncfusion Chart Component
description: Learn here all about Pareto Chart in Syncfusion ##Platform_Name## Chart component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Pareto Chart
publishingplatform: ##Platform_Name##
documentation: ug
---


# Pareto in ##Platform_Name## Charts Component

## Pareto

Pareto charts are used to find the cumulative values of data in different categories. It is a combination of Column and Line series. The initial values are represented by column chart and the cumulative values are represented by Line chart. To render a pareto chart, use series [`Type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Type) as [`Pareto`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeriesType.html#Syncfusion_EJ2_Charts_ChartSeriesType_Pareto).

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/other-types/pareto/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Pareto.cs" %}
{% include code-snippet/chart/series/other-types/pareto/pareto.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/other-types/pareto/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Pareto.cs" %}
{% include code-snippet/chart/series/other-types/pareto/pareto.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Pareto customization

The pareto line series can be customized by using the [`Marker`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartParetoOptions.html#Syncfusion_EJ2_Charts_ChartParetoOptions_Marker), [`Width`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartParetoOptions.html#Syncfusion_EJ2_Charts_ChartParetoOptions_Width), [`DashArray`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartParetoOptions.html#Syncfusion_EJ2_Charts_ChartParetoOptions_DashArray), and [`Fill`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartParetoOptions.html#Syncfusion_EJ2_Charts_ChartParetoOptions_Fill) properties in the [`ParetoOptions`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartParetoOptions.html). The secondary axis for the pareto series can be shown or hidden using the [`ShowAxis`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartParetoOptions.html#Syncfusion_EJ2_Charts_ChartParetoOptions_ShowAxis) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/other-types/pareto-customization/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Pareto-customization.cs" %}
{% include code-snippet/chart/series/other-types/pareto-customization/pareto-customization.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/other-types/pareto-customization/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Pareto-customization.cs" %}
{% include code-snippet/chart/series/other-types/pareto-customization/pareto-customization.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## See also

* [Data Label](../data-labels)
* [Tooltip](../tool-tip)