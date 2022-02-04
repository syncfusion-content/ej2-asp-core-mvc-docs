---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Numeric Range Slider of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Numeric Range Slider
publishingplatform: ##Platform_Name##
documentation: ug
---

# Numeric Range Slider

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