---
layout: post
title: Series label in ##Platform_Name## Chart | Syncfusion
description: Learn here all about Series label in Syncfusion ##Platform_Name## Chart component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core
control: Series label
documentation: ug
---

# Series label in ##Platform_Name## Chart

The series label displays the name of each series inline, positioned near the end of the series path or the last visible data point. This helps identify each series without referring to the legend.

## Overview

Enable series labels using the [`LabelSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_LabelSettings) property within the series configuration. Set the [`Visible`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeriesLabelSettings.html#Syncfusion_EJ2_Charts_ChartSeriesLabelSettings_Visible) property to **true** to display the label.

{% tabs %}

{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/series-label/tagHelper %}
{% endhighlight %}

{% highlight c# tabtitle="Series-label.cs" %}
{% include code-snippet/chart/series/series-label/series-label.cs %}
{% endhighlight %}

{% endtabs %}

## Customization

Customize the appearance of series labels using the following properties:

* [`Text`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeriesLabelSettings.html#Syncfusion_EJ2_Charts_ChartSeriesLabelSettings_Text)
* [`Font`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeriesLabelSettings.html#Syncfusion_EJ2_Charts_ChartSeriesLabelSettings_Font)
* [`Background`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeriesLabelSettings.html#Syncfusion_EJ2_Charts_ChartSeriesLabelSettings_Background)
* [`Border`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeriesLabelSettings.html#Syncfusion_EJ2_Charts_ChartSeriesLabelSettings_Border)
* [`Opacity`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeriesLabelSettings.html#Syncfusion_EJ2_Charts_ChartSeriesLabelSettings_Opacity)
* [`ShowOverlapText`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeriesLabelSettings.html#Syncfusion_EJ2_Charts_ChartSeriesLabelSettings_ShowOverlapText)

{% tabs %}

{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/series-label-customization/tagHelper %}
{% endhighlight %}

{% highlight c# tabtitle="Series-label-customization.cs" %}
{% include code-snippet/chart/series/series-label-customization/series-label-customization.cs %}
{% endhighlight %}

{% endtabs %}