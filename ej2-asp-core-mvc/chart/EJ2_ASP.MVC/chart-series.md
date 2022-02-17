---
layout: post
title: Chart Series in ##Platform_Name## Chart Component
description: Learn here all about Chart Series in Syncfusion ##Platform_Name## Chart component and more.
platform: ej2-asp-core-mvc
control: Chart Series
publishingplatform: ##Platform_Name##
documentation: ug
---


# Chart Series

## Multiple Series

You can add multiple series to the chart by using [`Series`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartSeries.html) property.
The series are rendered in the order as it is added to the series array.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/multiple-series/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Multiple-series.cs" %}
{% include code-snippet/chart/series/multiple-series/multiple-series.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/multiple-series/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Multiple-series.cs" %}
{% include code-snippet/chart/series/multiple-series/multiple-series.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Combination Series

Combination of different types like Line, column etc, can be rendered in a chart.

>Bar series cannot be combined with any other series as the axis orientation is different from other series.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/combination/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Combination.cs" %}
{% include code-snippet/chart/series/combination/combination.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/combination/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Combination.cs" %}
{% include code-snippet/chart/series/combination/combination.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Enable Complex Property in Series

By setting `EnableComplexProperty` value as `true` in series you can bind complex data to the chart.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/complex/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Complex.cs" %}
{% include code-snippet/chart/series/complex/complex.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/complex/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Complex.cs" %}
{% include code-snippet/chart/series/complex/complex.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

