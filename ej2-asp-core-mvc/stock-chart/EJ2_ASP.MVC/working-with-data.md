---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Working With Data of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Working With Data
publishingplatform: ##Platform_Name##
documentation: ug
---


<!-- markdownlint-disable MD036 -->

# Working with Data

Chart can visualise data bound from local or remote data.

## Local Data

You can bind a simple JSON data to the chart using
[`DataSource`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.StockChartStockChartSeries.html#Syncfusion_EJ2_Charts_StockChartStockChartSeries_DataSource) property in series.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/stock-chart/axis/working-data/local-data/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Local-data.cs" %}
{% include code-snippet/stock-chart/axis/working-data/local-data/local-data.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/stock-chart/axis/working-data/local-data/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Local-data.cs" %}
{% include code-snippet/stock-chart/axis/working-data/local-data/local-data.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## See Also

* [Series Types](./series-types/)
