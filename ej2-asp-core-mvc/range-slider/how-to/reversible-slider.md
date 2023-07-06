---
layout: post
title: Reversible Range Slider in ##Platform_Name## Range Slider Component
description: Learn here all about Reversible Range Slider in Syncfusion ##Platform_Name## Range Slider component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Reversible Range Slider
publishingplatform: ##Platform_Name##
documentation: ug
---

# Reversible Range Slider

You can create a Range Slider rendered with values in reverse order by setting the `min` property to the maximum value and the `max` property to the minimum value. An example of how to achieve a reversible Range Slider is shown below

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/slider/reversible-slider/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Reversible-slider.cs" %}
{% include code-snippet/slider/reversible-slider/reversible-slider.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/slider/reversible-slider/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Reversible-slider.cs" %}
{% include code-snippet/slider/reversible-slider/reversible-slider.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![ASP .NET Core - Slider - Reverse](../images/reversible-slider.gif)

> Reversible order can be achieved with `Horizontal` orientation Range Slider by setting `enableRtl` as true.