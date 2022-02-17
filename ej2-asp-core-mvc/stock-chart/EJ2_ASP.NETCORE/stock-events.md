---
layout: post
title: Stock Events in ##Platform_Name## Stock Chart Component
description: Learn here all about Stock Events in Syncfusion ##Platform_Name## Stock Chart component and more.
platform: ej2-asp-core-mvc
control: Stock Events
publishingplatform: ##Platform_Name##
documentation: ug
---

<!-- markdownlint-disable MD036 -->

# Stock Events

Stock Events visualizes stockevents in stockchart. 'SplineSeries' is used to represent selected data value. You can customize the specific data value using `stockEvents` event.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/stock-chart/stockchart-feature/stock-events/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="StockEvents.cs" %}
{% include code-snippet/stock-chart/stockchart-feature/stock-events/stockEvents.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/stock-chart/stockchart-feature/stock-events/razor %}
{% endhighlight %}
{% highlight c# tabtitle="StockEvents.cs" %}
{% include code-snippet/stock-chart/stockchart-feature/stock-events/stockEvents.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



**Stock Events for individual series**

By default, stock events will be showed for all series. Now, you can set the stock events for particular series using `SeriesIndexes` property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/stock-chart/stockchart-feature/stock-events-2/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Stock-events-2.cs" %}
{% include code-snippet/stock-chart/stockchart-feature/stock-events-2/stock-events-2.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/stock-chart/stockchart-feature/stock-events-2/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Stock-events-2.cs" %}
{% include code-snippet/stock-chart/stockchart-feature/stock-events-2/stock-events-2.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


