---
layout: post
title: How to change animations in ##Platform_Name## Context Menu | Syncfusion
description: Configure Syncfusion ##Platform_Name## Context Menu submenu open/close animations via animationSettings, choosing None, SlideDown, ZoomIn, or FadeIn.
platform: ej2-asp-core-mvc
control: Change Animation Settings
publishingplatform: ##Platform_Name##
documentation: ug
---

# How to change animations in ##Platform_Name## Context Menu

To change the animation of the ContextMenu, the [`animationSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.ContextMenu.html#Syncfusion_EJ2_Navigations_ContextMenu_AnimationSettings) property is used. This property applies to both the submenu open and close animations. The supported effects for the ContextMenu are,

| Effect | Functionality |
| ------------ | ----------------------- |
| None | Specifies the submenu transform with no animation effect. |
| SlideDown | Specifies the submenu transform with slide down effect. |
| ZoomIn | Specifies the submenu transform with zoom in effect. |
| FadeIn | Specifies the submenu transform with fade in effect. |

Along with the `Effect`, the `Duration` (in milliseconds) and `Easing` options can be set to control the animation timing.

The following sample illustrates how to open the ContextMenu with the `FadeIn` effect and a `duration` of `800ms`. The `Effect` value can be changed to `None`, `SlideDown`, or `ZoomIn` to see the other animations.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/context-menu/howto/animation/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Animation.cs" %}
{% include code-snippet/context-menu/howto/animation/animation.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/context-menu/howto/animation/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Animation.cs" %}
{% include code-snippet/context-menu/howto/animation/animation.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


