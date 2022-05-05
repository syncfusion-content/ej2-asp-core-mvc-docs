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

In Carousel, two built-in animations are provided for slide transitions. You can disable animation using the [animation](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.Carousel.html#Syncfusion_EJ2_Navigations_Carousel_Animation) property. By default, Slide animation is applied for the transition between slides.

The following demo depicts the example for fade animation,

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/carousel/animations/fade/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/carousel/animations/fade/fade.cs %}
{% endhighlight %}
{% endtabs %}

![Carousel fade animation](../images/fade_animation.gif)

### Custom animation

In Carousel, you can use customized animation effects for slide transitions using the [customEffect](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.CarouselAnimationSettings.html#Syncfusion_EJ2_Navigations_CarouselAnimationSettings_CustomEffect) option of the [animation](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.Carousel.html#Syncfusion_EJ2_Navigations_Carousel_Animation) property.

The following demo depicts the example for `parallax` custom animation,

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/carousel/animations/custom-animation/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/carousel/animations/custom-animation/custom-animation.cs %}
{% endhighlight %}
{% endtabs %}

![Carousel custom animation](../images/parallax_animation.gif)

## Intervals between slides

Using the items property, you can set different intervals for each item to transition between slides. The default interval is `5000 ms` (5 seconds). The following example depicts the code for setting the different intervals between each item.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/carousel/animations/intervals/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/carousel/animations/intervals/intervals.cs %}
{% endhighlight %}
{% endtabs %}

**Note**: Interval property can accept value in terms of milliseconds.

## Auto play slides

In the carousel, all slides transitions are performed continuously after the specified or default intervals. You can enable or disable the auto slide transition using the [autoPlay](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.Carousel.html#Syncfusion_EJ2_Navigations_Carousel_AutoPlay) property. The following example depicts the code to enable or disable the auto slide transitions.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/carousel/animations/auto-play/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/carousel/animations/auto-play/auto-play.cs %}
{% endhighlight %}
{% endtabs %}

![Carousel autoplay slides](../images/auto_play.png)

## Looping slides

In the carousel, slides transitions are repeated continuously when you reach the last slide by default. You can enable or disable the infinite slide transition using the [loop](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.Carousel.html#Syncfusion_EJ2_Navigations_Carousel_Loop) property. The following example depicts the code to enable or disable the infinite slide transitions.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/carousel/animations/loop/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/carousel/animations/loop/loop.cs %}
{% endhighlight %}
{% endtabs %}

![Carousel loop slides](../images/looping_slides.png)

## Slide changing events

Using the [slideChanging](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.Carousel.html#Syncfusion_EJ2_Navigations_Carousel_SlideChanging) or [slideChanged](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.Carousel.html#Syncfusion_EJ2_Navigations_Carousel_SlideChanged) events of the Carousel component, you can perform sample end customization while the carousel items are switched.

The following demo depicts the example for carousel events,

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/carousel/animations/slide-events/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/carousel/animations/slide-events/slide-events.cs %}
{% endhighlight %}
{% endtabs %}

## Disable touch swiping

In the carousel, you can swipe the carousel slides using touch actions by default. The swipe action can be enabled or disabled using the [enableTouchSwipe](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.Carousel.html#Syncfusion_EJ2_Navigations_Carousel_EnableTouchSwipe) property. The following example depicts the code to disable the swipe action for the slide.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/carousel/animations/touch-swipe/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/carousel/animations/touch-swipe/touch-swipe.cs %}
{% endhighlight %}
{% endtabs %}
