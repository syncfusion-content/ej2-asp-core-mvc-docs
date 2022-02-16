---
layout: post
title: Axis Types in ##Platform_Name## Stock Chart Component
description: Learn here all about Axis Types in Syncfusion ##Platform_Name## Stock Chart component and more.
platform: ej2-asp-core-mvc
control: Axis Types
publishingplatform: ##Platform_Name##
documentation: ug
---


# DateTime,Numeric and Logarithmic Axis

## DateTime Axis

Date time axis uses date time scale and displays the date time values as axis labels in the specified format and set the [`ValueType`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.StockChartStockChartAxis.html#Syncfusion_EJ2_Charts_StockChartStockChartAxis_ValueType) of axis to DateTime.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/stock-chart/stockchart-feature/datetime/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Datetime.cs" %}
{% include code-snippet/stock-chart/stockchart-feature/datetime/datetime.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/stock-chart/stockchart-feature/datetime/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Datetime.cs" %}
{% include code-snippet/stock-chart/stockchart-feature/datetime/datetime.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Logarithmic Axis

<!-- markdownlint-disable MD033 -->

Logarithmic axis uses logarithmic scale and it is very useful in visualizing data, when it has numerical values in
both lower order of magnitude (eg: 10<sup>-6</sup>) and higher order of magnitude (eg: 10<sup>6</sup>) and set the [`ValueType`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.StockChartStockChartAxis.html#Syncfusion_EJ2_Charts_StockChartStockChartAxis_ValueType) of axis to `Lograthmic`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/stock-chart/stockchart-feature/log/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Log.cs" %}
{% include code-snippet/stock-chart/stockchart-feature/log/log.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/stock-chart/stockchart-feature/log/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Log.cs" %}
{% include code-snippet/stock-chart/stockchart-feature/log/log.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## See Also

* [Axis Customization](./axis-customization/)