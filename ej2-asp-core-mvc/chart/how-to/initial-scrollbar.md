---
layout: post
title: Initial Scrollbar in ##Platform_Name## Chart Component
description: Learn here all about Initial Scrollbar in Syncfusion ##Platform_Name## Chart component and more.
platform: ej2-asp-core-mvc
control: Initial Scrollbar
publishingplatform: ##Platform_Name##
documentation: ug
---


<!-- markdownlint-disable MD036 -->

# To make the scrollbar visible in initial rendering of chart

By setting `zoomFactor` in primaryXAxis and `isZoomed` value as `true` in [`load`](../../api/chart/chartModel/#load) event and `enableScrollbar` value as `true` in `zoomSettings`, you can make the scrollbar visible in initial rendering of chart.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/column/initial-scroll/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Initial-scroll.cs" %}
{% include code-snippet/chart/series/column/initial-scroll/initial-scroll.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/column/initial-scroll/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Initial-scroll.cs" %}
{% include code-snippet/chart/series/column/initial-scroll/initial-scroll.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

