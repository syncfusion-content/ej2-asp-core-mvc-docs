---
layout: post
title: How to add a dotted line in ##Platform_Name## Chart | Syncfusion
description: Learn here all about Dotted Line in Syncfusion ##Platform_Name## Chart component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Dotted Line
publishingplatform: ##Platform_Name##
documentation: ug
---


# How to add a dotted line using Annotation in ##Platform_Name## Chart

By using `annotation`, you can add dotted lines in the chart.

To add dotted lines in the chart, follow the given steps:

**Step 1**: Initialize the custom elements by using the `annotation` property.

By setting `coordinateUnits` value as `point` in annotation object, you can place dotted lines in the chart based on point x and y values.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/column/dotted-annotation/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Dotted-annotation.cs" %}
{% include code-snippet/chart/series/column/dotted-annotation/dotted-annotation.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/column/dotted-annotation/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Dotted-annotation.cs" %}
{% include code-snippet/chart/series/column/dotted-annotation/dotted-annotation.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

