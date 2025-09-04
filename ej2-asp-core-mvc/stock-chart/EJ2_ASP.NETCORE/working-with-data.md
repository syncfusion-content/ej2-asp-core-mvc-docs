---
layout: post
title: Working With Data in ##Platform_Name## Stock Chart Component
description: Learn here all about Working With Data in Syncfusion ##Platform_Name## Stock Chart component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Working With Data
publishingplatform: ##Platform_Name##
documentation: ug
---


<!-- markdownlint-disable MD036 -->

# Working with Data

Chart can visualise data bound from local or remote data.

## Local Data

You can bind a simple JSON data to the chart using [`dataSource`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.StockChartStockChartSeries.html#Syncfusion_EJ2_Charts_StockChartStockChartSeries_DataSource) property in series.

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

## Handling No data

{% if page.publishingplatform == "aspnet-core" %}

When no data is available to render in the stock chart, the `noDataTemplate` property can be used to display a custom layout within the chart area. This layout may include a message indicating the absence of data, a relevant image, or a button to initiate data loading. Styled text, images, or interactive elements can be incorporated to maintain design consistency and improve user guidance. Once data becomes available, the chart automatically updates to display the appropriate visualization.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/stock-chart/axis/working-data/no-data-template/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="No-data-template.cs" %}
{% include code-snippet/stock-chart/axis/working-data/no-data-template/no-data-template.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

When no data is available to render in the stock chart, the `NoDataTemplate` property can be used to display a custom layout within the chart area. This layout may include a message indicating the absence of data, a relevant image, or a button to initiate data loading. Styled text, images, or interactive elements can be incorporated to maintain design consistency and improve user guidance. Once data becomes available, the chart automatically updates to display the appropriate visualization.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/stock-chart/axis/working-data/No-data-template/razor %}
{% endhighlight %}
{% highlight c# tabtitle="No-data-template.cs" %}
{% include code-snippet/stock-chart/axis/working-data/no-data-template/no-data-template.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![ASP.NET Core Stock Chart Control](images/nodatatemplate-stockchart.png)

## See Also

* [Series Types](./series-types/)
