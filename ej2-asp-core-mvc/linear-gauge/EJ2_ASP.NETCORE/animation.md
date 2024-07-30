---
layout: post
title: Animation in the Syncfusion ##Platform_Name## Linear Gauge component
description: Learn here all about animation in the Syncfusion ##Platform_Name## Linear Gauge component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Animation
publishingplatform: ##Platform_Name##
documentation: ug
---


# Animation in ASP.NET Core Linear Gauge

All of the elements in the Linear Gauge, such as the axis lines, ticks, labels, ranges, pointers, and annotations, can be animated sequentially by using the [animationDuration](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.LinearGauge.LinearGauge.html#Syncfusion_EJ2_LinearGauge_LinearGauge_AnimationDuration) property. The animation for the Linear Gauge is enabled when the `animationDuration` property is set to an appropriate value in milliseconds, providing a smooth rendering effect for the component. If the `animationDuration` property is set to **0**, which is the default value, the animation effect is disabled. If the animation is enabled, the component will behave in the following order.

1. The axis line, ticks, labels, and ranges will all be animated at the same time.
2. If available, pointers will be animated in the same way as [pointer animation](https://ej2.syncfusion.com/aspnetcore/documentation/linear-gauge/pointers#pointer-animation).
3. If available, annotations will be animated.

The animation of the Linear Gauge is demonstrated in the following example.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/lineargauge/animation/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Animation.cs" %}
{% include code-snippet/lineargauge/animation/animation.cs %}
{% endhighlight %}
{% endtabs %}

{% endif %}

![Linear Gauge with animation](../linear-gauge/images/animation.gif)

> Only the pointer of the Linear Gauge can be animated individually, not the axis lines, ticks, labels, ranges, and annotations. You can refer this [link](https://ej2.syncfusion.com/aspnetcore/documentation/linear-gauge/pointers#pointer-animation) to enable only pointer animation.
