---
layout: post
title: Animation in ##Platform_Name## Tooltip Component
description: Learn here all about Animation in Syncfusion ##Platform_Name## Tooltip component and more.
platform: ej2-asp-core-mvc
control: Animation
publishingplatform: ##Platform_Name##
documentation: ug
---


# Animation

To animate the Tooltip, a set of specific animation effects are available, and it can be controlled using the `animation` property.
 The animation property also allows you to set delay, duration, and various other effects of your choice.

`AnimationModel` is derived from base to apply the chosen animation effect, duration, etc. on Tooltips.

By default, Tooltip entrance occurs over 150 ms using the `ease-out` timing function. It exits also at 150 ms,
but uses `ease-in` timing function.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tooltip/animation-default/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Animation.cs" %}
{% include code-snippet/tooltip/animation-default/animation.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tooltip/animation-default/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Animation.cs" %}
{% include code-snippet/tooltip/animation-default/animation.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![ASP .NET Core - Tooltip - Animation](./images/tooltip-animation.png)

The default animation effect for the Tooltip is set to `FadeIn` for its open action, and `FadeOut` for its close action.
The default `duration` is set to 150 ms and `delay` is set to 0.

## Animation effects

The animation effects that are applicable to Tooltips are:

* `FadeIn`
* `FadeOut`
* `FadeZoomIn`
* `FadeZoomOut`
* `FlipXDownIn`
* `FlipXDownOut`
* `FlipXUpIn`
* `FlipXUpOut`
* `FlipYLeftIn`
* `FlipYLeftOut`
* `FlipYRightIn`
* `FlipYRightOut`
* `ZoomIn`
* `ZoomOut`
* `None`

When the `effect` is specified as `None`, no effect will be applied to the Tooltip, and animation is considered to be set to `off`.

> Some of the above animation effects suits the Tooltip better when its tip pointer is hidden.
> This can be achieved by setting the `showTipPointer` to false.

## Animating via open/close methods

Animations can also be applied on Tooltips dynamically through `open` and `close` methods. These methods accept the animation model as an
 optional parameter. If you pass `TooltipAnimationSettings`, animation takes this model; otherwise, it takes the values from the
  `animation` property. It is also possible to pass different animations for Tooltips on each target.

Refer to the code snippet below to apply animations using public methods.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tooltip/animation-openclose/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Animation-openclose.cs" %}
{% include code-snippet/tooltip/animation-openclose/animation-openclose.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tooltip/animation-openclose/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Animation-openclose.cs" %}
{% include code-snippet/tooltip/animation-openclose/animation-openclose.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![ASP .NET Core - Tooltip - Animation Open Close Method](./images/tooltip-animation.png)

## Apply transition

The transition effect can be applied on Tooltips by using the `beforeRender` event as given in the
 following work-around code example.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tooltip/animation-transition/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Animation-transition.cs" %}
{% include code-snippet/tooltip/animation-transition/animation-transition.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tooltip/animation-transition/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Animation-transition.cs" %}
{% include code-snippet/tooltip/animation-transition/animation-transition.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![ASP .NET Core - Tooltip - Animation Transition](./images/tooltip-transition.png)