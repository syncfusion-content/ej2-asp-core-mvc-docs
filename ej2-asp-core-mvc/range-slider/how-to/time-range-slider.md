---
layout: post
title: Time Range Slider in ##Platform_Name## Range Slider Component
description: Learn here all about Time Range Slider in Syncfusion ##Platform_Name## Range Slider component and more.
platform: ej2-asp-core-mvc
control: Time Range Slider
publishingplatform: ##Platform_Name##
documentation: ug
---

# Time Range Slider

The time formatting can be achieved same as the date formatting using `renderingTicks` and `change` events. The process of time formatting is explained in the below sample.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/slider/time-format/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Time-format.cs" %}
{% include code-snippet/slider/time-format/time-format.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/slider/time-format/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Time-format.cs" %}
{% include code-snippet/slider/time-format/time-format.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![ASP .NET Core - Slider - Time - Format](../images/slider-time-format.png)