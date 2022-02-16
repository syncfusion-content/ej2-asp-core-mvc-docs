---
layout: post
title: Period Selector in ##Platform_Name## Stock Chart Component
description: Learn here all about Period Selector in Syncfusion ##Platform_Name## Stock Chart component and more.
platform: ej2-asp-core-mvc
control: Period Selector
publishingplatform: ##Platform_Name##
documentation: ug
---


# Period selector

The period selector allows to select a range with specified periods. By default the period selector is enabled in stock chart.

## Periods

<!-- markdownlint-disable MD034 -->

Periods is an array of objects that allows users to specify the range of [`periods`] (https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.StockChart.html#Syncfusion_EJ2_Charts_StockChart_Periods). The `interval` property specifies the count value of the button, and the `text` property specifies the text to be displayed on button. The `intervalType` property allows users to customize the intervals of the buttons. The `intervalType` property supports the following interval types:

* Auto
* Years
* Quarter
* Months
* Weeks
* Days
* Hours
* Minutes
* Seconds

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/stock-chart/getting-started/period/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Period.cs" %}
{% include code-snippet/stock-chart/getting-started/period/period.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/stock-chart/getting-started/period/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Period.cs" %}
{% include code-snippet/stock-chart/getting-started/period/period.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Visibility of period selector

The [`enablePeriodSelector`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.StockChart.html#Syncfusion_EJ2_Charts_StockChart_EnablePeriodSelector) property allows users to toggle the visibility of period selector.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/stock-chart/getting-started/visiblityperiod/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Visiblityperiod.cs" %}
{% include code-snippet/stock-chart/getting-started/visiblityperiod/visiblityperiod.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/stock-chart/getting-started/visiblityperiod/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Visiblityperiod.cs" %}
{% include code-snippet/stock-chart/getting-started/visiblityperiod/visiblityperiod.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

