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

To change the animation of the ContextMenu, [`animationSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.ContextMenu.html#Syncfusion_EJ2_Navigations_ContextMenu_AnimationSettings) property is used. The supported effects for ContextMenu are,

| Effect | Functionality |
| ------------ | ----------------------- |
| None | Specifies the sub menu transform with no animation effect. |
| SlideDown | Specifies the sub menu transform with slide down effect. |
| ZoomIn | Specifies the sub menu transform with zoom in effect. |
| FadeIn | Specifies the sub menu transform with fade in effect. |

The following sample illustrates how to open ContextMenu with `FadeIn` effect with the `duration` of `800ms`.

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


