---
layout: post
title: Numeric Formatting in ##Platform_Name## Range Slider | Syncfusion
description: Learn how to format numeric values in ##Platform_Name## Range Slider using decimal precision, fixed values, and custom units.
platform: ej2-asp-core-mvc
control: Numeric Range Slider
publishingplatform: ##Platform_Name##
documentation: ug
---

# Numeric Formatting in Range Slider

The numeric values can be formatted into different decimal digits or fixed number of whole numbers or to represent the units. The Numeric processing is demonstrated below.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/slider/numeric-value/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Numeric-value.cs" %}
{% include code-snippet/slider/numeric-value/numeric-value.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/slider/numeric-value/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Numeric-value.cs" %}
{% include code-snippet/slider/numeric-value/numeric-value.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![ASP .NET Core - Slider - Format](../images/slider-numeric-value.png)