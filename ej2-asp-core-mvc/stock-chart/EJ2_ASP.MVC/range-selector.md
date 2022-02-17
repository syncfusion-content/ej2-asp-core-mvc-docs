---
layout: post
title: Range Selector in ##Platform_Name## Stock Chart Component
description: Learn here all about Range Selector in Syncfusion ##Platform_Name## Stock Chart component and more.
platform: ej2-asp-core-mvc
control: Range Selector
publishingplatform: ##Platform_Name##
documentation: ug
---


# Range selector

The period selector allows to select a range with specified periods. By default the period selector is enabled in stock chart.

# Selecting Range

The left and right thumb of RangeNavigator are used to indicate the selected range in the large collection of data. Following are the ways you can select a range.

* By dragging the thumbs.
* By tapping on the labels.
* By setting the start and end through Date Range button.

Following code example shows the [`EnableSelector`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.StockChart.html#Syncfusion_EJ2_Charts_StockChart_EnableSelector) property allows users to toggle the visibility of enable selector.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/stock-chart/getting-started/range/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Range.cs" %}
{% include code-snippet/stock-chart/getting-started/range/range.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/stock-chart/getting-started/range/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Range.cs" %}
{% include code-snippet/stock-chart/getting-started/range/range.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


