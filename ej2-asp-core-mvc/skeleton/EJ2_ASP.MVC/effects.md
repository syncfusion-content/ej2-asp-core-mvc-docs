---
layout: post
title: Shimmer Effect in ##Platform_Name## Skeleton | Syncfusion
description: Learn how to apply shimmer effects in the Syncfusion ##Platform_Name## Skeleton control using Wave, Pulse, and Fade animations to improve loading experiences.
platform: ej2-asp-core-mvc
control: Effects
publishingplatform: ##Platform_Name##
documentation: ug
---

# Shimmer Effect in ##Platform_Name## Skeleton

You can use the [ShimmerEffect](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Notifications.Skeleton.html#Syncfusion_EJ2_Notifications_Skeleton_ShimmerEffect) property to change animation effect in the skeleton control. Skeleton supports `Wave`, `Pulse` and `Fade` effects and by default, the `ShimmerEffect` is set to `Wave` effect.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/skeleton/effects/pulse-effect/razor %}
{% endhighlight %}
{% highlight c# tabtitle="PulseEffect.cs" %}
{% include code-snippet/skeleton/effects/pulse-effect/pulseeffect.cs %}
{% endhighlight %}
{% endtabs %}

![ASP.NET MVC Skeleton Pulse Effect](images/skeleton-pulse-effect.png)

Below example demonstrates a list with pulse effect skeleton.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/skeleton/effects/effect/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Effect.cs" %}
{% include code-snippet/skeleton/effects/effect/effect.cs %}
{% endhighlight %}
{% endtabs %}

![ASP.NET MVC Skeleton Pulse Effect](images/skeleton-Effect.png)


