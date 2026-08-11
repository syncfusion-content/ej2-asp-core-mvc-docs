---
layout: post
title: Add or remove series in ##Platform_Name## Chart | Syncfusion
description: Learn here all about Add or Remove series in Syncfusion ##Platform_Name## Chart component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Add or Remove
publishingplatform: ##Platform_Name##
documentation: ug
---


<!-- markdownlint-disable MD036 -->

# How to add or remove a series dynamically in ##Platform_Name## Chart

You can add or remove the chart series dynamically by using the `addSeries` or `removeSeries` method.

To add or remove the series dynamically, follow the given steps:

**Step 1**:

To add a new series to chart dynamically, pass the series value to the `addSeries` method.

To remove the new series from chart dynamically, pass the series index to the `removeSeries` method.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/how-to/add-remove/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Add-remove.cs" %}
{% include code-snippet/chart/how-to/add-remove/add-remove.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/how-to/add-remove/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Add-remove.cs" %}
{% include code-snippet/chart/how-to/add-remove/add-remove.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

