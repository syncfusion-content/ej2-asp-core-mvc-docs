---
layout: post
title: Animations and Transitions in ##Platform_Name## Carousel Control
description: Checkout and learn about Animations and Transitions in ##Platform_Name## Carousel control of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Animations and Transitions
publishingplatform: ##Platform_Name##
documentation: ug
---

# Animations and Transitions

## Animations

### Fade animation

In Carousel, two built-in animations are provided for slide transitions. You can disable animation using the [Animation](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Navigations.Carousel.html#Syncfusion_EJ2_Navigations_Carousel_Animation) property. By default, Slide animation is applied for the transition between slides.

The following demo depicts the example for fade animation,

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/carousel/animations/fade/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/carousel/animations/fade/fade.cs %}
{% endhighlight %}
{% endtabs %}

### Custom animation

In Carousel, you can use customized animation effects for slide transitions using the [CustomEffect](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Navigations.CarouselAnimationSettings.html#Syncfusion_EJ2_Navigations_CarouselAnimationSettings_CustomEffect) option of the [Animation](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Navigations.Carousel.html#Syncfusion_EJ2_Navigations_Carousel_Animation) property.

The following demo depicts the example for `parallax` custom animation,

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/carousel/animations/custom-animation/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/carousel/animations/custom-animation/custom-animation.cs %}
{% endhighlight %}
{% endtabs %}

## Intervals between slides

Using the items property, you can set different intervals for each item to transition between slides. The default interval is `5000 ms` (5 seconds). The following example depicts the code for setting the different intervals between each item.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/carousel/animations/intervals/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/carousel/animations/intervals/intervals.cs %}
{% endhighlight %}
{% endtabs %}

**Note**: Interval property can accept value in terms of milliseconds.

## Auto play slides

In the carousel, all slides transitions are performed continuously after the specified or default intervals. You can enable or disable the auto slide transition using the [AutoPlay](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Navigations.Carousel.html#Syncfusion_EJ2_Navigations_Carousel_AutoPlay) property. The following example depicts the code to enable or disable the auto slide transitions.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/carousel/animations/auto-play/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/carousel/animations/auto-play/auto-play.cs %}
{% endhighlight %}
{% endtabs %}

## Looping slides

In the carousel, slides transitions are repeated continuously when you reach the last slide by default. You can enable or disable the infinite slide transition using the [Loop](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Navigations.Carousel.html#Syncfusion_EJ2_Navigations_Carousel_Loop) property. The following example depicts the code to enable or disable the infinite slide transitions.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/carousel/animations/loop/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/carousel/animations/loop/loop.cs %}
{% endhighlight %}
{% endtabs %}

## Slide changing events

Using the [SlideChanging](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Navigations.Carousel.html#Syncfusion_EJ2_Navigations_Carousel_SlideChanging) or [SlideChanged](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Navigations.Carousel.html#Syncfusion_EJ2_Navigations_Carousel_SlideChanged) events of the Carousel component, you can perform sample end customization while the carousel items are switched.

The following demo depicts the example for carousel events,

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/carousel/animations/slide-events/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/carousel/animations/slide-events/slide-events.cs %}
{% endhighlight %}
{% endtabs %}

## Disable touch swiping

In the carousel, you can swipe the carousel slides using touch actions by default. The swipe action can be enabled or disabled using the [EnableTouchSwipe](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Navigations.Carousel.html#Syncfusion_EJ2_Navigations_Carousel_EnableTouchSwipe) property. The following example depicts the code to disable the swipe action for the slide.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/carousel/animations/touch-swipe/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/carousel/animations/touch-swipe/touch-swipe.cs %}
{% endhighlight %}
{% endtabs %}
