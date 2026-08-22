---
layout: post
title: Time Formatting in ##Platform_Name## Range Slider | Syncfusion
description: Learn how to display and format time values in ##Platform_Name## Range Slider using tick and tooltip customization.
platform: ej2-asp-core-mvc
control: Time Range Slider
publishingplatform: ##Platform_Name##
documentation: ug
---

# Time Formatting in Range Slider

The time formatting can be achieved same as the date formatting using [`renderingTicks`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.Slider.html#Syncfusion_EJ2_Inputs_Slider_RenderingTicks) and [`change`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.Slider.html#Syncfusion_EJ2_Inputs_Slider_Change) events. The process of time formatting is explained in the below sample.

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