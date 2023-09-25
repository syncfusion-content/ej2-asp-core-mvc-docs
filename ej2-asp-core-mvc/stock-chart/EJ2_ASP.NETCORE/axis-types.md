---
layout: post
title: Axis Types in ##Platform_Name## Stock Chart Component
description: Learn here all about Axis Types in Syncfusion ##Platform_Name## Stock Chart component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Axis types
publishingplatform: ##Platform_Name##
documentation: ug
---


# Axis types

## DateTime axis

DateTime axis uses date time scale and displays the date time values as axis labels in the specified format. To use DateTime axis, set the [`ValueType`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.StockChartStockChartAxis.html#Syncfusion_EJ2_Charts_StockChartStockChartAxis_ValueType) of axis to `DateTime`.

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



## DateTimeCategory axis

DateTimeCategory axis in the stock chart is used to display only business days. To use DateTimeCategory axis, set the [`ValueType`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.StockChartStockChartAxis.html#Syncfusion_EJ2_Charts_StockChartStockChartAxis_ValueType) of axis to `DateTimeCategory`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/stock-chart/stockchart-feature/datetimecategory/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Datetimecategory.cs" %}
{% include code-snippet/stock-chart/stockchart-feature/datetimecategory/datetimecategory.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/stock-chart/stockchart-feature/datetimecategory/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Datetimecategory.cs" %}
{% include code-snippet/stock-chart/stockchart-feature/datetimecategory/datetimecategory.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Logarithmic axis

<!-- markdownlint-disable MD033 -->

Logarithmic axis uses logarithmic scale and it is very useful in visualizing data, when it has numerical values in both lower order of magnitude (eg: 10<sup>-6</sup>) and higher order of magnitude (eg: 10<sup>6</sup>). To use Logarithmic axis, set the[`ValueType`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.StockChartStockChartAxis.html#Syncfusion_EJ2_Charts_StockChartStockChartAxis_ValueType) of axis to `Logarithmic`.

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



## See also

* [Axis Customization](./axis-customization/)