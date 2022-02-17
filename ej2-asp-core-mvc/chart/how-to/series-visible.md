---
layout: post
title: Series Visible in ##Platform_Name## Chart Component
description: Learn here all about Series Visible in Syncfusion ##Platform_Name## Chart component and more.
platform: ej2-asp-core-mvc
control: Series Visible
publishingplatform: ##Platform_Name##
documentation: ug
---


<!-- markdownlint-disable MD036 -->

# Show series based on respective legend click

By using the `chartMouseClick` event, you can show the series based on respective legend click. In this event, you can get the legend target id, using which you can get the current series index. Based on the index, you can set value of `visible` to `true` or `false`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/column/series-visible/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Series-visible.cs" %}
{% include code-snippet/chart/series/column/series-visible/series-visible.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/column/series-visible/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Series-visible.cs" %}
{% include code-snippet/chart/series/column/series-visible/series-visible.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

