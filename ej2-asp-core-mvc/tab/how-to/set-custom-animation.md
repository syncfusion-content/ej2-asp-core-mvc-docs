---
layout: post
title: How to set custom animation in ##Platform_Name## Tabs | Syncfusion
description: Apply custom animations to Syncfusion ##Platform_Name## Tabs for previous and next tab actions using the `Animation` library's easing, duration, and effect options.
platform: ej2-asp-core-mvc
control: Set Custom Animation
publishingplatform: ##Platform_Name##
documentation: ug
---


# How to set custom animation in ##Platform_Name## Tabs

Tab supports custom animations for both previous and next actions from the provided animation option of `Animation` library. The animation property also allows you to set easing, duration, and various other effects.

Default animation is given as `SlideLeftIn` for previous tab animation and `SlideRightIn` for next tab animation. You can also disable the animation by setting the animation effect as `None`. Also, use the following CSS to disable indicator animation for animation effect as `None`.

```CSS

.e-tab .e-tab-header:not(.e-vertical) .e-indicator, .e-tab .e-tab-header.e-vertical .e-indicator {
    transition: none;
}

```

The sample demonstrates some types of animation that suits Tab. You can check all the animation effects here.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tab/animation/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Styles.cs" %}
{% include code-snippet/tab/animation/styles.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tab/animation/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Styles.cs" %}
{% include code-snippet/tab/animation/styles.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![Custom Animation](../images/animation.PNG)