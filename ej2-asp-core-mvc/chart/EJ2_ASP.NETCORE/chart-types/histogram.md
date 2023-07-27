---
layout: post
title: Histogram Chart in ##Platform_Name## Syncfusion Chart Component
description: Learn here all about Histogram Chart in Syncfusion ##Platform_Name## Chart component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Histogram Chart
publishingplatform: ##Platform_Name##
documentation: ug
---


# Histogram in ##Platform_Name## Charts Component

## Histogram

[`Histogram Chart`](https://www.syncfusion.com/aspnet-core-ui-controls/charts/chart-types/histogram-chart) can provide a visual display of large amounts of data that are difficult to understand in a tabular or spreadsheet form and it can be rendered by specifying the series [`Type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Type) to [`Histogram`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeriesType.html#Syncfusion_EJ2_Charts_ChartSeriesType_Histogram).

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/other-types/histogram/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Histogram.cs" %}
{% include code-snippet/chart/series/other-types/histogram/histogram.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/other-types/histogram/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Histogram.cs" %}
{% include code-snippet/chart/series/other-types/histogram/histogram.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## See Also

* [Data Label](../data-labels)
* [Tooltip](../tool-tip)