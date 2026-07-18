---
layout: post
title: Last Value Label in ##Platform_Name## Syncfusion Chart Component
description: Learn here all about Data Labels in Syncfusion ##Platform_Name## Chart component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Last value label
publishingplatform: ##Platform_Name##
documentation: ug
---

# Last value label in ##Platform_Name## Chart Control

The `LastValueLabel` feature highlights the final data point in a series, making the latest trend or value easy to identify.

## Enable Last value label

Enable the label by setting the `Enable` property inside the `LastValueLabel` configuration. 

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/last-value-label/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="LastValueLabel.cs" %}
{% include code-snippet/chart/last-value-label/lastValueLabel.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/last-value-label/razor %}
{% endhighlight %}
{% highlight c# tabtitle="LastValueLabel.cs" %}
{% include code-snippet/chart/last-value-label/lastValueLabel.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Customization

Customize the appearance using properties such as `Font`, `Background`, `Border`, `DashArray`, `LineWidth`, `LineColor`, `Rx`, and `Ry`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/last-value-label-customization/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="LastValueLabelCustomization.cs" %}
{% include code-snippet/chart/last-value-label-customization/lastValueLabelCustomization.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/last-value-label-customization/razor %}
{% endhighlight %}
{% highlight c# tabtitle="LastValueLabelCustomization.cs" %}
{% include code-snippet/chart/last-value-label-customization/lastValueLabelCustomization.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}